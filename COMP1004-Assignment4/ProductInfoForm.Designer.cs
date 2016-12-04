namespace COMP1004_Assignment4
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.OsLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductInfoBox = new System.Windows.Forms.GroupBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.TechSpecsBox = new System.Windows.Forms.GroupBox();
            this.WebcamTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.StripMenu.SuspendLayout();
            this.ProductInfoBox.SuspendLayout();
            this.TechSpecsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.EditMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(963, 26);
            this.StripMenu.TabIndex = 0;
            this.StripMenu.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.ExitMenuItem});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(49, 22);
            this.MenuItemFile.Text = "File";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(119, 22);
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(119, 22);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(52, 22);
            this.EditMenuItem.Text = "Edit";
            // 
            // SelectMenuItem
            // 
            this.SelectMenuItem.Name = "SelectMenuItem";
            this.SelectMenuItem.Size = new System.Drawing.Size(263, 22);
            this.SelectMenuItem.Text = "Select Another Product";
            this.SelectMenuItem.Click += new System.EventHandler(this.SelectMenuItem_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductIDLabel.Location = new System.Drawing.Point(41, 51);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(94, 18);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionLabel.Location = new System.Drawing.Point(339, 51);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(86, 18);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(670, 51);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(45, 18);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlatformLabel.Location = new System.Drawing.Point(23, 31);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(77, 18);
            this.PlatformLabel.TabIndex = 4;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(23, 78);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(114, 18);
            this.ManufacturerLabel.TabIndex = 5;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // OsLabel
            // 
            this.OsLabel.AutoSize = true;
            this.OsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OsLabel.Location = new System.Drawing.Point(488, 34);
            this.OsLabel.Name = "OsLabel";
            this.OsLabel.Size = new System.Drawing.Size(31, 18);
            this.OsLabel.TabIndex = 6;
            this.OsLabel.Text = "OS";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.Location = new System.Drawing.Point(488, 81);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(56, 18);
            this.ModelLabel.TabIndex = 7;
            this.ModelLabel.Text = "Model";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(6, 130);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(84, 18);
            this.CPUTypeLabel.TabIndex = 8;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(56, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(56, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 10;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmLabel.Location = new System.Drawing.Point(41, 462);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(233, 18);
            this.ConfirmLabel.TabIndex = 11;
            this.ConfirmLabel.Text = "Click Next to Confirm Order";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(293, 130);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(97, 18);
            this.CPUSpeedLabel.TabIndex = 12;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(308, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 18);
            this.label13.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(308, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 18);
            this.label14.TabIndex = 14;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDDLabel.Location = new System.Drawing.Point(582, 46);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(44, 18);
            this.HDDLabel.TabIndex = 15;
            this.HDDLabel.Text = "HDD";
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPULabel.Location = new System.Drawing.Point(582, 88);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(85, 18);
            this.GPULabel.TabIndex = 16;
            this.GPULabel.Text = "GPU Type";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WebCamLabel.Location = new System.Drawing.Point(582, 130);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(80, 18);
            this.WebCamLabel.TabIndex = 17;
            this.WebCamLabel.Text = "WebCam";
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(363, 448);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Padding = new System.Windows.Forms.Padding(5);
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(223, 46);
            this.SelectAnotherProductButton.TabIndex = 18;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(691, 448);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.CancelButton.Size = new System.Drawing.Size(101, 46);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(816, 448);
            this.NextButton.Name = "NextButton";
            this.NextButton.Padding = new System.Windows.Forms.Padding(5);
            this.NextButton.Size = new System.Drawing.Size(101, 46);
            this.NextButton.TabIndex = 20;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductInfoBox
            // 
            this.ProductInfoBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoBox.Controls.Add(this.OSTextBox);
            this.ProductInfoBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoBox.Controls.Add(this.OsLabel);
            this.ProductInfoBox.Controls.Add(this.ModelLabel);
            this.ProductInfoBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductInfoBox.Location = new System.Drawing.Point(35, 90);
            this.ProductInfoBox.Name = "ProductInfoBox";
            this.ProductInfoBox.Size = new System.Drawing.Size(882, 131);
            this.ProductInfoBox.TabIndex = 21;
            this.ProductInfoBox.TabStop = false;
            this.ProductInfoBox.Text = "Product Info";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTextBox.Location = new System.Drawing.Point(596, 81);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(264, 27);
            this.ModelTextBox.TabIndex = 27;
            // 
            // OSTextBox
            // 
            this.OSTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OSTextBox.Location = new System.Drawing.Point(596, 31);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(264, 27);
            this.OSTextBox.TabIndex = 26;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(165, 78);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(264, 27);
            this.ManufacturerTextBox.TabIndex = 25;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlatformTextBox.Location = new System.Drawing.Point(165, 31);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(264, 27);
            this.PlatformTextBox.TabIndex = 24;
            // 
            // TechSpecsBox
            // 
            this.TechSpecsBox.Controls.Add(this.WebcamTextBox);
            this.TechSpecsBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecsBox.Controls.Add(this.CPUNumberTextBox);
            this.TechSpecsBox.Controls.Add(this.LCDSizeTextBox);
            this.TechSpecsBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsBox.Controls.Add(this.GPULabel);
            this.TechSpecsBox.Controls.Add(this.HDDLabel);
            this.TechSpecsBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechSpecsBox.Location = new System.Drawing.Point(35, 240);
            this.TechSpecsBox.Name = "TechSpecsBox";
            this.TechSpecsBox.Size = new System.Drawing.Size(882, 184);
            this.TechSpecsBox.TabIndex = 22;
            this.TechSpecsBox.TabStop = false;
            this.TechSpecsBox.Text = "Tech Specs";
            // 
            // WebcamTextBox
            // 
            this.WebcamTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WebcamTextBox.Location = new System.Drawing.Point(690, 124);
            this.WebcamTextBox.Name = "WebcamTextBox";
            this.WebcamTextBox.Size = new System.Drawing.Size(170, 27);
            this.WebcamTextBox.TabIndex = 32;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPUTypeTextBox.Location = new System.Drawing.Point(690, 82);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(170, 27);
            this.GPUTypeTextBox.TabIndex = 31;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(406, 124);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(170, 27);
            this.CPUSpeedTextBox.TabIndex = 30;
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUNumberTextBox.Location = new System.Drawing.Point(406, 82);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(170, 27);
            this.CPUNumberTextBox.TabIndex = 29;
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCDSizeTextBox.Location = new System.Drawing.Point(406, 43);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.Size = new System.Drawing.Size(170, 27);
            this.LCDSizeTextBox.TabIndex = 28;
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDDTextBox.Location = new System.Drawing.Point(690, 40);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(170, 27);
            this.HDDTextBox.TabIndex = 27;
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUTypeTextBox.Location = new System.Drawing.Point(117, 124);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(170, 27);
            this.CPUTypeTextBox.TabIndex = 26;
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUBrandTextBox.Location = new System.Drawing.Point(117, 84);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(170, 27);
            this.CPUBrandTextBox.TabIndex = 25;
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryTextBox.Location = new System.Drawing.Point(117, 40);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(170, 27);
            this.MemoryTextBox.TabIndex = 24;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryLabel.Location = new System.Drawing.Point(6, 46);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(71, 18);
            this.MemoryLabel.TabIndex = 4;
            this.MemoryLabel.Text = "Memory";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(6, 90);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(94, 18);
            this.CPUBrandLabel.TabIndex = 5;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCDSizeLabel.Location = new System.Drawing.Point(293, 46);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(80, 18);
            this.LCDSizeLabel.TabIndex = 6;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(293, 88);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(110, 18);
            this.CPUNumberLabel.TabIndex = 7;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductIDTextBox.Location = new System.Drawing.Point(141, 48);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(167, 27);
            this.ProductIDTextBox.TabIndex = 23;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionTextBox.Location = new System.Drawing.Point(431, 48);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(187, 27);
            this.ConditionTextBox.TabIndex = 24;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostTextBox.Location = new System.Drawing.Point(730, 48);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(187, 27);
            this.CostTextBox.TabIndex = 25;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(963, 513);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.TechSpecsBox);
            this.Controls.Add(this.ProductInfoBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.StripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.StripMenu;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.ProductInfoBox.ResumeLayout(false);
            this.ProductInfoBox.PerformLayout();
            this.TechSpecsBox.ResumeLayout(false);
            this.TechSpecsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label OsLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox ProductInfoBox;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.GroupBox TechSpecsBox;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox WebcamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
    }
}