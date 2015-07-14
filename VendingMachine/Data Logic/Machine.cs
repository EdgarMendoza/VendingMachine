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
            RetrieveSnacksPresent();
        }

        public void AddMoney(int amount, int snackChoice)
        {

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

        public void SaveSnacksPresent()
        {
            StreamWriter sWriter = null;
            string output = null;

            try
            {
                foreach(string path in filePaths)
                {
                    if (File.Exists(path))
                        File.Delete(path);

                    File.Create(path);
                }

                foreach(ISnacks snack in SnacksPresent)
                {
                    output = String.Format("{0},{1},{2},{3:N2}", snack.CompanyName, snack.BrandName, snack.AmountPresent, snack.SnackPrice);

                    if (snack is Cookies)
                        sWriter = new StreamWriter(filePaths[0]);
                    else if (snack is Chocolate)
                        sWriter = new StreamWriter(filePaths[1]);
                    else if (snack is Cookies)
                        sWriter = new StreamWriter(filePaths[2]);
                    else if (snack is Gum)
                        sWriter = new StreamWriter(filePaths[3]);

                    sWriter.WriteLine(output);
                    sWriter = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sWriter.Flush();
                sWriter.Close();
            }
        }

        public void RetrieveSnacksPresent()
        {
            string line;
            bool finished = false;
            string[] lineValue;
            StreamReader sr = null;
            ISnacks snack = null;

            try
            {
                foreach(string path in filePaths)
                {
                    sr = new StreamReader(path);

                    while(!(finished))
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
            finally
            {
                sr.Close();
            }
        }

        public void CreateFiles()
        {
            foreach (string path in filePaths)
            {
                if (!(File.Exists(path)))
                    File.Create(path);
            }
        }
    }
}
