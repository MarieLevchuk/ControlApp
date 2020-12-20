namespace ControllApp
{
    partial class AddItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxAddItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxAddPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxAddQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.CBoxManufacturersInAdd = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(452, 51);
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
            this.LblClose.Location = new System.Drawing.Point(400, 12);
            this.LblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(47, 32);
            this.LblClose.TabIndex = 1;
            this.LblClose.Text = "x";
            this.LblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose manufcturer:";
            // 
            // TBoxAddItem
            // 
            this.TBoxAddItem.Location = new System.Drawing.Point(212, 163);
            this.TBoxAddItem.MaximumSize = new System.Drawing.Size(400, 33);
            this.TBoxAddItem.MinimumSize = new System.Drawing.Size(180, 33);
            this.TBoxAddItem.Name = "TBoxAddItem";
            this.TBoxAddItem.Size = new System.Drawing.Size(200, 26);
            this.TBoxAddItem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name of item";
            // 
            // TBoxAddPrice
            // 
            this.TBoxAddPrice.Location = new System.Drawing.Point(212, 283);
            this.TBoxAddPrice.MaximumSize = new System.Drawing.Size(400, 33);
            this.TBoxAddPrice.MinimumSize = new System.Drawing.Size(180, 33);
            this.TBoxAddPrice.Name = "TBoxAddPrice";
            this.TBoxAddPrice.Size = new System.Drawing.Size(200, 26);
            this.TBoxAddPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price, $";
            // 
            // TBoxAddQuantity
            // 
            this.TBoxAddQuantity.Location = new System.Drawing.Point(213, 224);
            this.TBoxAddQuantity.MaximumSize = new System.Drawing.Size(400, 33);
            this.TBoxAddQuantity.MinimumSize = new System.Drawing.Size(180, 33);
            this.TBoxAddQuantity.Name = "TBoxAddQuantity";
            this.TBoxAddQuantity.Size = new System.Drawing.Size(200, 26);
            this.TBoxAddQuantity.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.panel2.Location = new System.Drawing.Point(12, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 3);
            this.panel2.TabIndex = 12;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddItem.FlatAppearance.BorderSize = 0;
            this.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.BtnAddItem.Location = new System.Drawing.Point(32, 345);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(381, 58);
            this.BtnAddItem.TabIndex = 13;
            this.BtnAddItem.Text = "ADD NEW ITEM";
            this.BtnAddItem.UseVisualStyleBackColor = false;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // CBoxManufacturersInAdd
            // 
            this.CBoxManufacturersInAdd.FormattingEnabled = true;
            this.CBoxManufacturersInAdd.Location = new System.Drawing.Point(213, 97);
            this.CBoxManufacturersInAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBoxManufacturersInAdd.Name = "CBoxManufacturersInAdd";
            this.CBoxManufacturersInAdd.Size = new System.Drawing.Size(200, 28);
            this.CBoxManufacturersInAdd.TabIndex = 14;
            this.CBoxManufacturersInAdd.SelectedIndexChanged += new System.EventHandler(this.CBoxManufacturers_SelectedIndexChanged);
            // 
            // _addItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(452, 420);
            this.Controls.Add(this.CBoxManufacturersInAdd);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TBoxAddQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxAddPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBoxAddItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_addItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxAddPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxAddQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAddItem;
        public System.Windows.Forms.ComboBox CBoxManufacturersInAdd;
        private System.Windows.Forms.Label LblClose;
    }
}