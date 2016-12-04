// RAD-Assignment4, Chandra Reddy Gundam #200275643, 01-12-2016.
// This program select product table from Microsoft Azure and put products list to Data Grid,
// user can choose any product, save and read from files
// final form show all data and calculate total cost
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using COMP1004_Assignment4.Modules;
using System.Diagnostics;

namespace COMP1004_Assignment4
{
    public partial class ProductInfoForm : Form
    {
        // form variables
        public SelectForm previousForm;
        public product orderedProduct = Program.orderedProduct;

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        // method section
        /// <summary>
        /// this method save form information to file
        /// </summary>
        private void saveToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Product";
            // properties for save file
            saveFileDialog.Filter = "Text Files(*.txt) | *.txt ";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Title = "Save as";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                // create an instance of writer object
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName, true);

                // write to file
                writer.WriteLine(orderedProduct.productID + ";" +
                orderedProduct.cost + ";" +
                orderedProduct.manufacturer + ";" +
                orderedProduct.model + ";" +
                orderedProduct.RAM_type + ";" +
                orderedProduct.RAM_size + ";" +
                orderedProduct.displaytype + ";" +
                orderedProduct.screensize + ";" +
                orderedProduct.resolution + ";" +
                orderedProduct.CPU_brand + ";" +
                orderedProduct.CPU_Class + ";" +
                orderedProduct.CPU_number + ";" +
                orderedProduct.CPU_speed + ";" +
                orderedProduct.CPU_type + ";" +
                orderedProduct.condition + ";" +
                orderedProduct.OS + ";" +
                orderedProduct.platform + ";" +
                orderedProduct.HDD_size + ";" +
                orderedProduct.HDD_speed + ";" +
                orderedProduct.GPU_Type + ";" +
                orderedProduct.optical_drive + ";" +
                orderedProduct.Audio_type + ";" +
                orderedProduct.LAN + ";" +
                orderedProduct.WIFI + ";" +
                orderedProduct.width + ";" +
                orderedProduct.height + ";" +
                orderedProduct.depth + ";" +
                orderedProduct.weight + ";" +
                orderedProduct.moust_type + ";" +
                orderedProduct.power + ";" +
                orderedProduct.webcam);
                // close
                writer.Close();

                MessageBox.Show("File saved", "Success", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// this method open file and use reader to get information
        /// </summary>
        private void OpenFile()
        {
            // create object open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // set properties
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Text Files(*.txt) | *.txt | All Files(*.*) | *.*";

            // open dialog box
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                try
                {
                    // create reader
                    StreamReader reader = new StreamReader(openFileDialog.FileName);

                    // read in the data with readline to the object
                    string orderDataString = reader.ReadLine();

                    // close the streams
                    reader.Close();

                    // convert data to array
                    string[] orderArray = orderDataString.Split(';');

                    restoreOrder(orderArray);

                    MessageBox.Show("Your order was restored", "Success", MessageBoxButtons.OK);
                    fillForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// this method restore previous order from order array
        /// </summary>
        /// <param name="orderArray"></param>
        private void restoreOrder(string[] orderArray)
        {
            orderedProduct.productID = short.Parse(orderArray[0]);
            orderedProduct.cost = Convert.ToDecimal(orderArray[1]);
            orderedProduct.manufacturer = orderArray[2];
            orderedProduct.model = orderArray[3];
            orderedProduct.RAM_type = orderArray[4];
            orderedProduct.RAM_size = orderArray[5];
            orderedProduct.displaytype = orderArray[6];
            orderedProduct.screensize = orderArray[7];
            orderedProduct.resolution = orderArray[8];
            orderedProduct.CPU_brand = orderArray[9];
            orderedProduct.CPU_Class = orderArray[10];
            orderedProduct.CPU_number = orderArray[11];
            orderedProduct.CPU_speed = orderArray[12];
            orderedProduct.CPU_type = orderArray[13];
            orderedProduct.condition = orderArray[14];
            orderedProduct.OS = orderArray[15];
            orderedProduct.platform = orderArray[16];
            orderedProduct.HDD_size = orderArray[17];
            orderedProduct.HDD_speed = orderArray[18];
            orderedProduct.GPU_Type = orderArray[19];
            orderedProduct.optical_drive = orderArray[20];
            orderedProduct.Audio_type = orderArray[21];
            orderedProduct.LAN = orderArray[22];
            orderedProduct.WIFI = orderArray[23];
            orderedProduct.width = orderArray[24];
            orderedProduct.height = orderArray[25];
            orderedProduct.depth = orderArray[26];
            orderedProduct.weight = orderArray[27];
            orderedProduct.moust_type = orderArray[28];
            orderedProduct.power = orderArray[29];
            orderedProduct.webcam = orderArray[30];
        }


        /// <summary>
        /// fill form with information from product object
        /// </summary>
        private void fillForm()
        {
            ProductIDTextBox.Text = orderedProduct.productID.ToString();
            CostTextBox.Text = "$" + Math.Round(Convert.ToDouble(orderedProduct.cost), 2).ToString();
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
            // activate next button
            NextButton.Enabled = true;
        }

        /// <summary>
        /// shows previous form
        /// </summary>
        private void showPreviousForm()
        {
            if (previousForm == null)
            {
                previousForm = new SelectForm();
            }
            previousForm.Show();
            this.Hide();
        }

        /// <summary>
        /// close application
        /// </summary>
        private void exit()
        {
            Application.Exit();
        }

        // events section

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            // add if statement here 
            if (Program.openFromFile)
            {
                OpenFile();
                Program.openFromFile = false;
            }
            if (orderedProduct.productID != 0)
            {
                fillForm();
            }
        }

        /// <summary>
        /// go to next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            orderForm.Show();
            this.Hide();
        }
        /// <summary>
        /// close app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            showPreviousForm();
        }

        private void SelectMenuItem_Click(object sender, EventArgs e)
        {
            showPreviousForm();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (orderedProduct.productID == 0)
            {
                MessageBox.Show("Sorry, you need to select a product to do this", "Error", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveToFile();
                }
            }
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OpenFile();
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
