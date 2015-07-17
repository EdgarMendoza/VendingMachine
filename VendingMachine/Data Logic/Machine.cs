using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine.Data_Logic
{
    class Machine : IMachine
    {
        public List<ISnacks> SnacksPresent { get; set; }
        public double MoneyEntered { get; set; }

        string directoryPath = @"Data Storage";
        //Order: chips, chocolate, cookies, gum
        string[] filePaths = 
            {
                @"Data Storage\ChipsData.txt",
                @"Data Storage\ChocolateData.txt",
                @"Data Storage\CookiesData.txt",
                @"Data Storage\GumData.txt"
            };

        public Machine()
        {
            CreateFiles();
            SnacksPresent = new List<ISnacks>();
            RetrieveSnacksPresent();
        }

        public void PrintSnackList()
        {
            string output = String.Empty;
            foreach(ISnacks snack in SnacksPresent)
            {
                output += (CreateOutputLine(snack) + "\n");
            }
            MessageBox.Show(output);
        }

        //Receives information about a snack and adds it to the list according to the type recieved
        public void AddSnack(string type, string company, string brand, int amount, double price)
        {
            if (type == "Chips")
                SnacksPresent.Add(new Chips(company, brand, amount, price));
            else if (type == "Chocolate")
                SnacksPresent.Add(new Chocolate(company, brand, amount, price));
            else if (type == "Cookies")
                SnacksPresent.Add(new Cookies(company, brand, amount, price));
            else if (type == "Gum")
                SnacksPresent.Add(new Gum(company, brand, amount, price));
        }
        //Receives the amount of money inserted and the snack choice
        //Is the main starting point after the user enters money and a snack choice
        public void AddMoney(double amount, int snackChoice)
        {
            MoneyEntered = amount;


        }

        public string GiveSnack(int index)
        {
            string message = null;

            if (SnacksPresent[index] is Chocolate || SnacksPresent[index] is Gum)
                message = "Here is your " + SnacksPresent[index].CompanyName + " " + SnacksPresent[index].BrandName;
            else if (SnacksPresent[index] is Chips || SnacksPresent[index] is Cookies)
                message = "Here are your " + SnacksPresent[index].CompanyName + " " + SnacksPresent[index].BrandName;

            SnacksPresent[index].AmountPresent--;

            return message;
        }

        public string ReturnMoney(int index)
        {
            string message = null;
            string thanksGreeting = "Thank You, Please Shop Again";

            if (index == -1)
                message = String.Format("Here is your money ${0:N2}", MoneyEntered);
            else
            {
                double change = MoneyEntered - SnacksPresent[index].SnackPrice;

                if (change != 0)
                    message = String.Format("Here is your change ${0:N2}", change);
            }

            return String.Format(message + "\n" + thanksGreeting);
        }

        //Saves the List SnacksPresent into text files according to the type of snack
        public void SaveSnacksPresent()
        {
            List<ISnacks> snackType = new List<ISnacks>();

            try
            {
                foreach(string filePath in filePaths)
                {
                    if (File.Exists(filePath))
                        File.Delete(filePath);

                    File.Create(filePath).Dispose();
                }

                //Save snacks of type Chips
                foreach(ISnacks chips in SnacksPresent)
                {
                    if (chips is Chips)
                        snackType.Add(chips);
                }
                SaveSnackType(snackType, filePaths[0]);
                snackType.Clear();

                //Save snacks of type Chocolate
                foreach(ISnacks chocolate in SnacksPresent)
                {
                    if(chocolate is Chocolate)
                        snackType.Add(chocolate);
                }
                SaveSnackType(snackType, filePaths[1]);
                snackType.Clear();

                //Save snacks of type Cookies
                foreach(ISnacks cookies in SnacksPresent)
                {
                    if (cookies is Cookies)
                        snackType.Add(cookies);
                }
                SaveSnackType(snackType, filePaths[2]);
                snackType.Clear();

                //Save snacks of type Gum
                foreach(ISnacks gum in SnacksPresent)
                {
                    if (gum is Gum)
                        snackType.Add(gum);
                }
                SaveSnackType(snackType, filePaths[3]);
                snackType.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CreateOutputLine(ISnacks snack)
        {
            return String.Format("{0},{1},{2},{3:N2}", snack.CompanyName, snack.BrandName, snack.AmountPresent, snack.SnackPrice);
        }
        private void SaveSnackType(List<ISnacks> snackType, string path)
        {
            string output = null;
            using(StreamWriter sWriter = new StreamWriter(path))
            {
                foreach(ISnacks snack in snackType)
                {
                    output = CreateOutputLine(snack);
                    sWriter.WriteLine(output);
                }
            }
        }

        //Retrieves the snancks saved in the text files and adds them to the SnackPresent List
        public void RetrieveSnacksPresent()
        {
            foreach(string path in filePaths)
            {
                ReadSnackType(path);
            }
        }
        private void ReadSnackType(string path)
        {
            string line;
            bool finished = false;
            string[] lineValue;
            StreamReader sr = null;
            ISnacks snack = null;

            try
            {
                using (sr = new StreamReader(path))
                {
                    while (!(finished))
                    {
                        line = sr.ReadLine();

                        if (line != null)
                        {
                            lineValue = line.Split(',');

                            if (path == filePaths[0])
                                snack = new Chips(lineValue[0], lineValue[1], Convert.ToInt32(lineValue[2]), Convert.ToDouble(lineValue[3]));
                            else if (path == filePaths[1])
                                snack = new Chocolate(lineValue[0], lineValue[1], Convert.ToInt32(lineValue[2]), Convert.ToDouble(lineValue[3]));
                            else if (path == filePaths[2])
                                snack = new Cookies(lineValue[0], lineValue[1], Convert.ToInt32(lineValue[2]), Convert.ToDouble(lineValue[3]));
                            else if (path == filePaths[3])
                                snack = new Gum(lineValue[0], lineValue[1], Convert.ToInt32(lineValue[2]), Convert.ToDouble(lineValue[3]));

                            SnacksPresent.Add(snack);
                        }
                        else
                            finished = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Is called in the constructor and will create the directory and blank files if they do not already exist
        public void CreateFiles()
        {
            try
            {
                if (!(Directory.Exists(directoryPath)))
                    Directory.CreateDirectory(directoryPath);

                foreach (string path in filePaths)
                {
                    if (!File.Exists(path))
                        File.Create(path).Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
