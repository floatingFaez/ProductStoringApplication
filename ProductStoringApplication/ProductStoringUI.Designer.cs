namespace ProductStoringApplication
{
    partial class ProductStoringForm
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
            this.selectItemLabel = new System.Windows.Forms.Label();
            this.itemNumberLabel = new System.Windows.Forms.Label();
            this.selectItemComboBox = new System.Windows.Forms.ComboBox();
            this.itemNumberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.currentAmountLabel = new System.Windows.Forms.Label();
            this.productInfoListView = new System.Windows.Forms.ListView();
            this.serialNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectItemLabel
            // 
            this.selectItemLabel.AutoSize = true;
            this.selectItemLabel.Location = new System.Drawing.Point(26, 25);
            this.selectItemLabel.Name = "selectItemLabel";
            this.selectItemLabel.Size = new System.Drawing.Size(60, 13);
            this.selectItemLabel.TabIndex = 0;
            this.selectItemLabel.Text = "Select Item";
            // 
            // itemNumberLabel
            // 
            this.itemNumberLabel.AutoSize = true;
            this.itemNumberLabel.Location = new System.Drawing.Point(351, 25);
            this.itemNumberLabel.Name = "itemNumberLabel";
            this.itemNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.itemNumberLabel.TabIndex = 0;
            this.itemNumberLabel.Text = "Number Of Item";
            // 
            // selectItemComboBox
            // 
            this.selectItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectItemComboBox.FormattingEnabled = true;
            this.selectItemComboBox.Items.AddRange(new object[] {
            "Mother Board",
            "Processor",
            "Hard Disc",
            "Ram",
            "Graphics Card",
            "Casing",
            "DVD Writer",
            "Mouse",
            "Keyboard",
            "Monitor",
            "Spaker",
            "Power Supply",
            "Pendrive",
            "Portable Drive"});
            this.selectItemComboBox.Location = new System.Drawing.Point(117, 21);
            this.selectItemComboBox.Name = "selectItemComboBox";
            this.selectItemComboBox.Size = new System.Drawing.Size(190, 21);
            this.selectItemComboBox.TabIndex = 1;
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.Location = new System.Drawing.Point(447, 22);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(163, 20);
            this.itemNumberTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(639, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(639, 48);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // currentAmountLabel
            // 
            this.currentAmountLabel.AutoSize = true;
            this.currentAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAmountLabel.Location = new System.Drawing.Point(30, 110);
            this.currentAmountLabel.Name = "currentAmountLabel";
            this.currentAmountLabel.Size = new System.Drawing.Size(164, 16);
            this.currentAmountLabel.TabIndex = 4;
            this.currentAmountLabel.Text = "Current Total Amount : ";
            // 
            // productInfoListView
            // 
            this.productInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNumberHeader,
            this.productNameHeader,
            this.unitPriceHeader,
            this.totalPriceHeader});
            this.productInfoListView.FullRowSelect = true;
            this.productInfoListView.GridLines = true;
            this.productInfoListView.Location = new System.Drawing.Point(29, 149);
            this.productInfoListView.MultiSelect = false;
            this.productInfoListView.Name = "productInfoListView";
            this.productInfoListView.Size = new System.Drawing.Size(678, 195);
            this.productInfoListView.TabIndex = 5;
            this.productInfoListView.UseCompatibleStateImageBehavior = false;
            this.productInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // serialNumberHeader
            // 
            this.serialNumberHeader.Text = "SL NO";
            this.serialNumberHeader.Width = 53;
            // 
            // productNameHeader
            // 
            this.productNameHeader.Text = "Product Name";
            this.productNameHeader.Width = 204;
            // 
            // unitPriceHeader
            // 
            this.unitPriceHeader.Text = "Unit Price";
            this.unitPriceHeader.Width = 115;
            // 
            // totalPriceHeader
            // 
            this.totalPriceHeader.Text = "Total Price";
            this.totalPriceHeader.Width = 143;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(201, 108);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(0, 18);
            this.amountLabel.TabIndex = 6;
            // 
            // ProductStoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 356);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.productInfoListView);
            this.Controls.Add(this.currentAmountLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.itemNumberTextBox);
            this.Controls.Add(this.selectItemComboBox);
            this.Controls.Add(this.itemNumberLabel);
            this.Controls.Add(this.selectItemLabel);
            this.Name = "ProductStoringForm";
            this.Text = "Product Storing Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectItemLabel;
        private System.Windows.Forms.Label itemNumberLabel;
        private System.Windows.Forms.ComboBox selectItemComboBox;
        private System.Windows.Forms.TextBox itemNumberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label currentAmountLabel;
        private System.Windows.Forms.ListView productInfoListView;
        private System.Windows.Forms.ColumnHeader serialNumberHeader;
        private System.Windows.Forms.ColumnHeader productNameHeader;
        private System.Windows.Forms.ColumnHeader unitPriceHeader;
        private System.Windows.Forms.ColumnHeader totalPriceHeader;
        private System.Windows.Forms.Label amountLabel;
    }
}

