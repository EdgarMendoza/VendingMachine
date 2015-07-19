using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Data_Logic;

namespace VendingMachine
{
    //This partial class deals mainly with the management of the snack slots
    //Methods will be used when using the auto-add snacks option
    public partial class MainForm
    {
        static int amountOfRows = 4;
        static int amountOfColumns = 5;
        static int snackSlots = amountOfRows * amountOfColumns;
        int snackSlotsFilled = 0;

        string btnEmptyMessage = "Sorry," + Environment.NewLine + "This Is Empty";

        //Snack amount present in each snack slot
        //The array index corresponds with rows and columns i.e. ([0,0] = row 1, column 1)
        int[,] snackSlotsAmounts = new int[amountOfRows, amountOfColumns];

        private void AddSnackToSlot(int amountToAdd)
        {
            SetSnackAmount(amountToAdd);

            AddChips();
            AddChocolate();
            AddCookies();
            AddGum();

            machine1.SaveSnacksPresent();
        }
        private string CreateButtonMessage(ISnacks snackMsg)
        {
            return (snackMsg.CompanyName + Environment.NewLine + snackMsg.BrandName + Environment.NewLine + "$" + snackMsg.SnackPrice.ToString("F"));
        }

        private void SetSnackAmount(int amounts)
        {
            for(int row = 0; row < amountOfRows; row++)
            {
                for(int column = 0; column < amountOfColumns; column++)
                {
                    snackSlotsAmounts[row, column] = amounts;
                }
            }

            for(int index = 0; index < amountOfColumns; index++)
            {
                preMadeChips[index].AmountPresent = amounts;
                preMadeChocolate[index].AmountPresent = amounts;
                preMadeCookies[index].AmountPresent = amounts;
                preMadeGum[index].AmountPresent = amounts;
            }
        }

        private void AddChips()
        {
            string[] btnMessages = new string[amountOfColumns];

            //Set button text
            for(int x = 0; x < amountOfColumns; x++)
                btnMessages[x] = CreateButtonMessage(preMadeChips[x]);

            //Add text to buttons
            snack1_1Button.Text = btnMessages[0];
            snack1_2Button.Text = btnMessages[1];
            snack1_3Button.Text = btnMessages[2];
            snack1_4Button.Text = btnMessages[3];
            snack1_5Button.Text = btnMessages[4];

            snackSlotsFilled += 5;

            //Add chips to machine snacklist
            for (int index = 0; index < amountOfColumns; index++)
                machine1.SnacksPresent.Add(preMadeChips[index]);
        }
        private void AddChocolate()
        {
            string[] btnMessages = new string[amountOfColumns];

            //Set button text
            for (int x = 0; x < amountOfColumns; x++)
                btnMessages[x] = CreateButtonMessage(preMadeChocolate[x]);

            //Add text to buttons
            snack2_1Button.Text = btnMessages[0];
            snack2_2Button.Text = btnMessages[1];
            snack2_3Button.Text = btnMessages[2];
            snack2_4Button.Text = btnMessages[3];
            snack2_5Button.Text = btnMessages[4];

            snackSlotsFilled += 5;

            //Add chips to machine snacklist
            for (int index = 0; index < amountOfColumns; index++)
                machine1.SnacksPresent.Add(preMadeChocolate[index]);
        }
        private void AddCookies()
        {
            string[] btnMessages = new string[amountOfColumns];

            //Set button text
            for (int x = 0; x < amountOfColumns; x++)
                btnMessages[x] = CreateButtonMessage(preMadeCookies[x]);

            //Add text to buttons
            snack3_1Button.Text = btnMessages[0];
            snack3_2Button.Text = btnMessages[1];
            snack3_3Button.Text = btnMessages[2];
            snack3_4Button.Text = btnMessages[3];
            snack3_5Button.Text = btnMessages[4];

            snackSlotsFilled += 5;

            //Add chips to machine snacklist
            for (int index = 0; index < amountOfColumns; index++)
                machine1.SnacksPresent.Add(preMadeCookies[index]);
        }
        private void AddGum()
        {
            string[] btnMessages = new string[amountOfColumns];

            //Set button text
            for (int x = 0; x < amountOfColumns; x++)
                btnMessages[x] = CreateButtonMessage(preMadeGum[x]);

            //Add text to buttons
            snack4_1Button.Text = btnMessages[0];
            snack4_2Button.Text = btnMessages[1];
            snack4_3Button.Text = btnMessages[2];
            snack4_4Button.Text = btnMessages[3];
            snack4_5Button.Text = btnMessages[4];

            snackSlotsFilled += 5;

            //Add chips to machine snacklist
            for (int index = 0; index < amountOfColumns; index++)
                machine1.SnacksPresent.Add(preMadeGum[index]);
        }



        //Pre-Made Snacks Information
        ISnacks[] preMadeChips = new ISnacks[amountOfColumns];
        ISnacks[] preMadeChocolate = new ISnacks[amountOfColumns];
        ISnacks[] preMadeCookies = new ISnacks[amountOfColumns];
        ISnacks[] preMadeGum = new ISnacks[amountOfColumns];

        //Chips Information
        string chipsCompany = "FritoLays";
        string[] fritoLaysBrands = new string[] { "Lays", "Doritos", "Cheetos", "Tostitos", "Ruffles" };
        double[] fritoLaysPrice = new double[] { 1.25, 1.50, 1.50, 1.25, 1.75 };

        //Chocolate Information
        string chocolateCompany = "Mars";
        string[] marsBrands = new string[] { "3Muskeeters", "Dove", "m&m", "Milky Way", "Snickers" };
        double[] marsPrice = new double[] { 1.00, 1.00, 1.00, 1.00, 1.00 };

        //Cookies Information
        string cookiesCompany = "Nabisco";
        string[] nabiscoBrands = new string[] { "Oreo", "Ritz", "Chips Ahoy", "Teddy Grahams", "Nilla" };
        double[] nabiscoPrice = new double[] { 1.50, 1.50, 1.50, 1.50, 1.50 };

        //Gum Information
        string gumCompany = "Wrigley";
        string[] wrigleyBrands = new string[] { "5Gum", "BigRed", "Doublemint", "eclipse", "extra" };
        double[] wrigleyPrice = new double[] { .75, .75, .75, .75, .75 };

        private void InitializePreMadeSnacks()
        {
            for(int x = 0; x < amountOfColumns; x++)
            {
                preMadeChips[x] = new Chips(chipsCompany, fritoLaysBrands[x], 0, fritoLaysPrice[x]);

                preMadeChocolate[x] = new Chocolate(chocolateCompany, marsBrands[x], 0, marsPrice[x]);

                preMadeCookies[x] = new Cookies(cookiesCompany, nabiscoBrands[x], 0, nabiscoPrice[x]);

                preMadeGum[x] = new Gum(gumCompany, wrigleyBrands[x], 0, wrigleyPrice[x]);
            }
        }
    }
}
