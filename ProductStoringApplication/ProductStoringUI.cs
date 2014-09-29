using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductStoringApplication
{
    public partial class ProductStoringForm : Form
    {
        public ProductStoringForm()
        {
            InitializeComponent();
        }
        int i = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            string productName = selectItemComboBox.Text;
            double unitPrice = 0;

            switch (productName)
            {
                case "Mother Board":
                    unitPrice = 8700;
                    break;
                case "Processor":
                    unitPrice = 10000;
                    break;
                case "Hard Disc":
                    unitPrice = 3400;
                    break;
                case "Ram":
                    unitPrice = 1200;
                    break;
                case "Graphics Card":
                    unitPrice = 4200;
                    break;
                case "Casing":
                    unitPrice = 1100;
                    break;
                case "DVD Writer":
                    unitPrice = 2600;
                    break;
                case "Mouse":
                    unitPrice = 300;
                    break;
                case "Keyboard":
                    unitPrice = 500;
                    break;
                case "Monitor":
                    unitPrice = 7500;
                    break;
                case "Speaker":
                    unitPrice = 1800;
                    break;
                case "Power Supply":
                    unitPrice = 1300;
                    break;
                case "Pendrive":
                    unitPrice = 750;
                    break;
                case "Portable Drive":
                    unitPrice = 5000;
                    break;
            }

            int itemNumber = Convert.ToInt32(itemNumberTextBox.Text);
            itemNumberTextBox.Text = "";
            double totalPrice = unitPrice * itemNumber;

            amountLabel.Text = Convert.ToString(totalPrice) + "/=";
            string counter = Convert.ToString(++i);
            ListViewItem lvi = new ListViewItem(counter);
            lvi.SubItems.Add(selectItemComboBox.Text);
            lvi.SubItems.Add(Convert.ToString(unitPrice));
            lvi.SubItems.Add(Convert.ToString(totalPrice));
            productInfoListView.Items.Add(lvi);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            productInfoListView.Items.Clear();
            itemNumberTextBox.Text = "";
            amountLabel.Text = "";
            i = 0;
        }

        
        
        
    }
}
