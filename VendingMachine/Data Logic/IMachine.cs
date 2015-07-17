using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Data_Logic
{
    interface IMachine
    {
        //Used for runtime storage of snacks present in machine
        List<ISnacks> SnacksPresent { get; set; }
        double MoneyEntered { get; set; }


        void AddMoney(double amount, int snackChoice);

        //Will take the index of the snack chosen and return a string message
        //Will call the ReturnMoney method
        string GiveSnack(int index);

        string ReturnMoney(int index);

        //Saves the snacks present in the list to txt files for storage
        void SaveSnacksPresent();

        //Will retrieve snacks present in the txt files to the list
        //Likely only used in startup
        void RetrieveSnacksPresent();
    }
}
