﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Data_Logic
{
    class Gum : ISnacks
    {
        public string CompanyName { get; set; }
        public string BrandName { get; set; }
        public int AmountPresent { get; set; }
        public double SnackPrice { get; set; }

        public Gum()
        {
            CompanyName = "";
            BrandName = "";
            AmountPresent = 0;
            SnackPrice = 0.00;
        }
        public Gum(string company, string brand, int amount, double price)
        {
            CompanyName = company;
            BrandName = brand;
            AmountPresent = amount;
            SnackPrice = price;
        }
    }
}
