using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine.Presentation
{
    public partial class AddSnackForm : Form
    {
        public string SnackType { get; set; }
        public string ManufactureName { get; set; }
        public string BrandName { get; set; }
        public int SnackAmount { get; set; }
        public double SnackPrice { get; set; }

        public AddSnackForm()
        {
            InitializeComponent();
        }

        public void ClearForm()
        {
            snackTypeCombo.Text = "";
            companyComboBox.Text = "";
            brandComboBox.Text = "";
            amountTxtBox.Text = "";
            priceTxtBox.Text = "";
        }

        private void addSnackBtn_Click(object sender, EventArgs e)
        {
            int amount;
            double price;
            bool intParseResult;
            bool doubleParseResult;

            if (snackTypeCombo.Text == "" || companyComboBox.Text == "" || brandComboBox.Text == "" || amountTxtBox.Text == "" || priceTxtBox.Text == "")
            {
                MessageBox.Show("All Fields Are Required");
            }
            else
            {
                intParseResult = int.TryParse(amountTxtBox.Text, out amount);
                doubleParseResult = Double.TryParse(priceTxtBox.Text, out price);

                if (amount == 0)
                    MessageBox.Show("Please enter a whole number for the amount");
                else if(price == 0)
                {
                    MessageBox.Show("Please enter a correct price number");
                }
                else
                { 
                    this.SnackType = snackTypeCombo.Text;
                    this.ManufactureName = companyComboBox.Text;
                    this.BrandName = brandComboBox.Text;
                    this.SnackAmount = amount;
                    this.SnackPrice = price;

                    this.Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
