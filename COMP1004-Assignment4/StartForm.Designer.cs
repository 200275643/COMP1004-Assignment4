namespace COMP1004_Assignment4
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartImage = new System.Windows.Forms.PictureBox();
            this.StartOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartLabel.Location = new System.Drawing.Point(44, 21);
            this.StartLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(228, 18);
            this.StartLabel.TabIndex = 0;
            this.StartLabel.Text = "Order your computer today";
            // 
            // StartImage
            // 
            this.StartImage.Image = global::COMP1004_Assignment4.Properties.Resources.dollar;
            this.StartImage.Location = new System.Drawing.Point(14, 43);
            this.StartImage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StartImage.Name = "StartImage";
            this.StartImage.Size = new System.Drawing.Size(297, 304);
            this.StartImage.TabIndex = 1;
            this.StartImage.TabStop = false;
            // 
            // StartOrderButton
            // 
            this.StartOrderButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartOrderButton.Location = new System.Drawing.Point(14, 364);
            this.StartOrderButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StartOrderButton.Name = "StartOrderButton";
            this.StartOrderButton.Size = new System.Drawing.Size(297, 52);
            this.StartOrderButton.TabIndex = 2;
            this.StartOrderButton.Text = "Start New Order";
            this.StartOrderButton.UseVisualStyleBackColor = true;
            this.StartOrderButton.Click += new System.EventHandler(this.StartOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(14, 424);
            this.OpenSavedOrderButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(297, 51);
            this.OpenSavedOrderButton.TabIndex = 3;
            this.OpenSavedOrderButton.Text = "Open a Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(14, 483);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(297, 51);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(327, 550);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenSavedOrderButton);
            this.Controls.Add(this.StartOrderButton);
            this.Controls.Add(this.StartImage);
            this.Controls.Add(this.StartLabel);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computers!";
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.PictureBox StartImage;
        private System.Windows.Forms.Button StartOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
    }
}