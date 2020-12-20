namespace ControllApp
{
    partial class AddManufcturerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblClose = new System.Windows.Forms.Label();
            this.BtnAddManufacturer = new System.Windows.Forms.Button();
            this.TBoxAddCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBoxAddManufacturer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.LblClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 51);
            this.panel1.TabIndex = 0;
            // 
            // LblClose
            // 
            this.LblClose.AutoEllipsis = true;
            this.LblClose.AutoSize = true;
            this.LblClose.BackColor = System.Drawing.Color.Transparent;
            this.LblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblClose.Font = new System.Drawing.Font("CommercialPi BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.LblClose.Location = new System.Drawing.Point(364, 14);
            this.LblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(47, 32);
            this.LblClose.TabIndex = 2;
            this.LblClose.Text = "x";
            this.LblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // BtnAddManufacturer
            // 
            this.BtnAddManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.BtnAddManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddManufacturer.FlatAppearance.BorderSize = 0;
            this.BtnAddManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.BtnAddManufacturer.Location = new System.Drawing.Point(18, 194);
            this.BtnAddManufacturer.Name = "BtnAddManufacturer";
            this.BtnAddManufacturer.Size = new System.Drawing.Size(381, 58);
            this.BtnAddManufacturer.TabIndex = 25;
            this.BtnAddManufacturer.Text = "ADD NEW MANUFACTURER";
            this.BtnAddManufacturer.UseVisualStyleBackColor = false;
            this.BtnAddManufacturer.Click += new System.EventHandler(this.BtnAddManufacturer_Click);
            // 
            // TBoxAddCountry
            // 
            this.TBoxAddCountry.Location = new System.Drawing.Point(182, 136);
            this.TBoxAddCountry.MaximumSize = new System.Drawing.Size(400, 33);
            this.TBoxAddCountry.MinimumSize = new System.Drawing.Size(180, 33);
            this.TBoxAddCountry.Name = "TBoxAddCountry";
            this.TBoxAddCountry.Size = new System.Drawing.Size(217, 26);
            this.TBoxAddCountry.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Country";
            // 
            // TBoxAddManufacturer
            // 
            this.TBoxAddManufacturer.Location = new System.Drawing.Point(182, 75);
            this.TBoxAddManufacturer.MaximumSize = new System.Drawing.Size(400, 33);
            this.TBoxAddManufacturer.MinimumSize = new System.Drawing.Size(180, 33);
            this.TBoxAddManufacturer.Name = "TBoxAddManufacturer";
            this.TBoxAddManufacturer.Size = new System.Drawing.Size(216, 26);
            this.TBoxAddManufacturer.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Manufacturer";
            // 
            // AddManufcturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(421, 272);
            this.Controls.Add(this.BtnAddManufacturer);
            this.Controls.Add(this.TBoxAddCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxAddManufacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddManufcturerForm";
            this.Text = "ManufcturersForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.Button BtnAddManufacturer;
        private System.Windows.Forms.TextBox TBoxAddCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBoxAddManufacturer;
        private System.Windows.Forms.Label label2;
    }
}