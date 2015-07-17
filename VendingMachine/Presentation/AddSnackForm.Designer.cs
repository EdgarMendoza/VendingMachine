namespace VendingMachine.Presentation
{
    partial class AddSnackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.companyFieldLabel = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.snackTypeCombo = new System.Windows.Forms.ComboBox();
            this.brandTxtLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.addSnackBtn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyFieldLabel
            // 
            this.companyFieldLabel.AutoSize = true;
            this.companyFieldLabel.Location = new System.Drawing.Point(12, 40);
            this.companyFieldLabel.Name = "companyFieldLabel";
            this.companyFieldLabel.Size = new System.Drawing.Size(85, 13);
            this.companyFieldLabel.TabIndex = 0;
            this.companyFieldLabel.Text = "Company Name:";
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(103, 37);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(121, 21);
            this.companyComboBox.TabIndex = 2;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(13, 13);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(68, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Snack Type:";
            // 
            // snackTypeCombo
            // 
            this.snackTypeCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Chips",
            "Chocolate",
            "Cookies",
            "Gum"});
            this.snackTypeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.snackTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.snackTypeCombo.FormattingEnabled = true;
            this.snackTypeCombo.Items.AddRange(new object[] {
            "Chips",
            "Chocolate",
            "Cookies",
            "Gum"});
            this.snackTypeCombo.Location = new System.Drawing.Point(103, 10);
            this.snackTypeCombo.Name = "snackTypeCombo";
            this.snackTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.snackTypeCombo.TabIndex = 1;
            // 
            // brandTxtLabel
            // 
            this.brandTxtLabel.AutoSize = true;
            this.brandTxtLabel.Location = new System.Drawing.Point(13, 67);
            this.brandTxtLabel.Name = "brandTxtLabel";
            this.brandTxtLabel.Size = new System.Drawing.Size(69, 13);
            this.brandTxtLabel.TabIndex = 4;
            this.brandTxtLabel.Text = "Brand Name:";
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(103, 64);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandComboBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(13, 94);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(80, 13);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Snack Amount:";
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(103, 91);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(100, 20);
            this.amountTxtBox.TabIndex = 4;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(13, 120);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(68, 13);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Snack Price:";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(103, 117);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.priceTxtBox.TabIndex = 5;
            // 
            // addSnackBtn
            // 
            this.addSnackBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addSnackBtn.Location = new System.Drawing.Point(16, 159);
            this.addSnackBtn.Name = "addSnackBtn";
            this.addSnackBtn.Size = new System.Drawing.Size(97, 73);
            this.addSnackBtn.TabIndex = 6;
            this.addSnackBtn.Text = "Add Snack";
            this.addSnackBtn.UseVisualStyleBackColor = true;
            this.addSnackBtn.Click += new System.EventHandler(this.addSnackBtn_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(132, 193);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(92, 39);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close Form";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddSnackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 265);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addSnackBtn);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.brandTxtLabel);
            this.Controls.Add(this.snackTypeCombo);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.companyFieldLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSnackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddSnackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyFieldLabel;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox snackTypeCombo;
        private System.Windows.Forms.Label brandTxtLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Button addSnackBtn;
        private System.Windows.Forms.Button closeButton;
    }
}