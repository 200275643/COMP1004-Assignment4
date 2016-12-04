namespace COMP1004_Assignment4
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.SummaryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(20, 53);
            this.ProductsDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.Size = new System.Drawing.Size(1277, 489);
            this.ProductsDataGridView.TabIndex = 0;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(1172, 572);
            this.NextButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(125, 32);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(983, 572);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(125, 32);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectionLabel.Location = new System.Drawing.Point(20, 579);
            this.SelectionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(131, 18);
            this.SelectionLabel.TabIndex = 3;
            this.SelectionLabel.Text = "Your selection:";
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.BackColor = System.Drawing.Color.White;
            this.SummaryTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummaryTextBox.Location = new System.Drawing.Point(178, 572);
            this.SummaryTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.ReadOnly = true;
            this.SummaryTextBox.Size = new System.Drawing.Size(762, 27);
            this.SummaryTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dollar Computer Products List";
            // 
            // SelectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1320, 620);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SummaryTextBox);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ProductsDataGridView);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Form";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.TextBox SummaryTextBox;
        private System.Windows.Forms.Label label1;
    }
}