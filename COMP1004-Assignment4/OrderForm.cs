
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP1004_Assignment4.Modules;
using System.Diagnostics;

namespace COMP1004_Assignment4
{
    public partial class OrderForm : Form
    {
        product orderedProduct = Program.orderedProduct;
        public ProductInfoForm previousForm;
        public OrderForm()
        {
            InitializeComponent();
        }

        // method section
        /// <summary>
        /// this method fill text boxes from information stored in product object
        /// </summary>
        private void fillForm()
        {
            ConditionTextBox.Text = orderedProduct.condition;
            ManufacturerTextBox.Text = orderedProduct.manufacturer;
            PlatformTextBox.Text = orderedProduct.platform;
            ModelTextBox.Text = orderedProduct.model;
            LCDSizeTextBox.Text = orderedProduct.screensize;
            MemoryTextBox.Text = orderedProduct.RAM_size;
            CPUBrandTextBox.Text = orderedProduct.CPU_brand;
            CPUTypeTextBox.Text = orderedProduct.CPU_type;
            CPUNumberTextBox.Text = orderedProduct.CPU_number;
            CPUSpeedTextBox.Text = orderedProduct.CPU_speed;
            HDDTextBox.Text = orderedProduct.HDD_size;
            GPUTypeTextBox.Text = orderedProduct.GPU_Type;
            WebcamTextBox.Text = orderedProduct.webcam;
            OSTextBox.Text = orderedProduct.OS;

            // put product picture to picture box
            ComputerPictureBox.Image = (Image)COMP1004_Assignment4.Properties.Resources.ResourceManager.GetObject("comp" + orderedProduct.productID);

            // put cost, taxes and total cost of product
            PriceTextBox.Text = "$" + Math.Round(Convert.ToDouble(orderedProduct.cost), 2).ToString();
            SalesTaxTextBox.Text = "$" + Math.Round(Convert.ToDouble(orderedProduct.cost) * 0.13, 2).ToString();
            TotalTextBox.Text = "$" + Math.Round(Convert.ToDouble(orderedProduct.cost) * 1.13, 2).ToString();

        }

        /// <summary>
        /// this method show previous form
        /// </summary>
        private void showPreviousForm()
        {
            this.previousForm.Show();
            this.Hide();
        }

        /// <summary>
        /// shows message box and close app
        /// </summary>
        private void finishOrder()
        {
            MessageBox.Show("Thank you.\n\nYour order will be proceed in 7-10 business days.", "Thank you", MessageBoxButtons.OK);
            exit();
        }

        /// <summary>
        /// close application
        /// </summary>
        private void exit()
        {
            Application.Exit();
        }

        // events section

        /// <summary>
        /// load form event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            fillForm();
        }

        private void aboutStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program created by Sergei st#200325005. \nVersion 1.1 \nWebsite: www.chaoz.ca. \nDollar Computers Inc. \nPhone: 8 800 555 3535", "About program");
        }

        /// <summary>
        /// show printing message box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is printing", "Print");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            showPreviousForm();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPreviousForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            finishOrder();
        }
    }
}
