using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Data_Logic
{
    interface ISnacks
    {
        string CompanyName { get; set; }
        string BrandName { get; set; }
        int AmountPresent { get; set; }
        double SnackPrice { get; set; }
    }
}
