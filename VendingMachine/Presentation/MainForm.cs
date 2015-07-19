using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Data_Logic;
using VendingMachine.Presentation;

namespace VendingMachine
{
    public partial class MainForm : Form
    {
        Machine machine1 = new Machine();

        string idleMessage = Environment.NewLine + "Welcome" + Environment.NewLine + Environment.NewLine + "Todays Is:" + Environment.NewLine + DateTime.Today.ToString("D");

        public MainForm()
        {
            InitializeComponent();
            mainTxtDisplay.Text = idleMessage;

            InitializePreMadeSnacks();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
                System.Windows.Forms.Application.Exit();
            else
                System.Environment.Exit(1);
        }

        private void addASnackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var form = new AddSnackForm())
            {
                form.ClearForm();
                form.ShowDialog();
                while(form.DialogResult == DialogResult.OK)
                {
                    machine1.AddSnack(form.SnackType, form.ManufactureName, form.BrandName, form.SnackAmount, form.SnackPrice);

                    form.ClearForm();
                    form.ShowDialog();
                }

                if (form.DialogResult == DialogResult.Cancel)
                    machine1.SaveSnacksPresent();
            }
        }

        private void printList_Click(object sender, EventArgs e)
        {
            machine1.PrintSnackList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            machine1.SaveSnacksPresent();
        }

        private void add1OfEachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int snackAmount = 1;

            AddSnackToSlot(snackAmount);
        }

        private void seeSnacksPresentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            machine1.PrintSnackList();
        }
    }
}
