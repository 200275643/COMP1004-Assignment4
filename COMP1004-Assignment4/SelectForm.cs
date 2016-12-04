
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
using COMP1004_Assignment4.Modules;
using System.Diagnostics;

namespace COMP1004_Assignment4
{
    public partial class SelectForm : Form
    {
        public StartForm previousForm;

        product orderedProduct = Program.orderedProduct;
        // add db connection variable
        public ProductsContext db = new ProductsContext();

        public SelectForm()
        {
            InitializeComponent();
        }

        // form methods
        /// <summary>
        /// this method select data from products table and add it to data grid biew
        /// </summary>
        private void getProducts()
        {

            // select from db
            List<product> productList = (from product in db.products select product).ToList();

            // fill data grid view from product list
            ProductsDataGridView.DataSource = productList;
        }
        /// <summary>
        /// highlight the row and unlock next button
        /// </summary>
        /// <param name="e"></param>
        private void rowSelected(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // row selected
                var row = ProductsDataGridView.Rows[e.RowIndex];
                row.Selected = true;
                // get product ID
                int selectedProductID = Convert.ToInt32(row.Cells[0].Value);
                // get product from DB
                var selectedProduct = (from product
                                       in db.products
                                       where product.productID == selectedProductID
                                       select product).FirstOrDefault();

                // store data in product object
                fillProductObject(selectedProduct);

                // put data from object to text field
                SummaryTextBox.Text = orderedProduct.manufacturer + " " + orderedProduct.model +
                    ". Priced at: $" + Math.Round(Convert.ToDouble(orderedProduct.cost), 2);
                // unlock next button
                NextButton.Enabled = true;
            }

        }

        private void fillProductObject(product selectedProduct)
        {
            orderedProduct.productID = selectedProduct.productID;
            orderedProduct.cost = selectedProduct.cost;
            orderedProduct.manufacturer = selectedProduct.manufacturer;
            orderedProduct.model = selectedProduct.model;
            orderedProduct.RAM_type = selectedProduct.RAM_type;
            orderedProduct.RAM_size = selectedProduct.RAM_size;
            orderedProduct.displaytype = selectedProduct.displaytype;
            orderedProduct.screensize = selectedProduct.screensize;
            orderedProduct.resolution = selectedProduct.resolution;
            orderedProduct.CPU_brand = selectedProduct.CPU_brand;
            orderedProduct.CPU_Class = selectedProduct.CPU_Class;
            orderedProduct.CPU_number = selectedProduct.CPU_number;
            orderedProduct.CPU_speed = selectedProduct.CPU_speed;
            orderedProduct.CPU_type = selectedProduct.CPU_type;
            orderedProduct.condition = selectedProduct.condition;
            orderedProduct.OS = selectedProduct.OS;
            orderedProduct.platform = selectedProduct.platform;
            orderedProduct.HDD_size = selectedProduct.HDD_size;
            orderedProduct.HDD_speed = selectedProduct.HDD_speed;
            orderedProduct.GPU_Type = selectedProduct.GPU_Type;
            orderedProduct.optical_drive = selectedProduct.optical_drive;
            orderedProduct.Audio_type = selectedProduct.Audio_type;
            orderedProduct.LAN = selectedProduct.LAN;
            orderedProduct.WIFI = selectedProduct.WIFI;
            orderedProduct.width = selectedProduct.width;
            orderedProduct.height = selectedProduct.height;
            orderedProduct.depth = selectedProduct.depth;
            orderedProduct.weight = selectedProduct.weight;
            orderedProduct.moust_type = selectedProduct.moust_type;
            orderedProduct.power = selectedProduct.power;
            orderedProduct.webcam = selectedProduct.webcam;
        }

        /// <summary>
        /// close app
        /// </summary>
        private void exit()
        {
            Application.Exit();
        }

        // form events

        private void CancelButton_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;
            productInfoForm.Show();
            this.Hide();

        }
        /// <summary>
        /// data grid click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected(e);
        }
        /// <summary>
        /// load event that runs get products method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            getProducts();
        }
    }
}
