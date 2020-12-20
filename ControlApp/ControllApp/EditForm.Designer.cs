namespace ControllApp
{
    partial class EditForm
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
            this.TBoxNewQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBoxNewPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnItemEdit = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(444, 51);
            this.panel1.TabIndex = 1;
            // 
            // LblClose
            // 
            this.LblClose.AutoEllipsis = true;
            this.LblClose.AutoSize = true;
            this.LblClose.BackColor = System.Drawing.Color.Transparent;
            this.LblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblClose.Font = new System.Drawing.Font("CommercialPi BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(11)))));
            this.LblClose.Location = new System.Drawing.Point(389, 9);
            this.LblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(47, 32);
            this.LblClose.TabIndex = 1;
            this.LblClose.Text = "x";
            this.LblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // TBoxNewQuantity
            // 
            this.TBoxNewQuantity.Location = new System.Drawing.Point(223, 80);
            this.TBoxNewQuantity.MaximumSize = new System.Drawing.Size(400, 33);
            this.TBoxNewQuantity.MinimumSize = new System.Drawing.Size(180, 33);
            this.TBoxNewQuantity.Name = "TBoxNewQuantity";
            this.TBoxNewQuantity.Size = new System.Drawing.Size(200, 26);
            this.TBoxNewQuantity.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter quantity";
            // 
            // TBoxNewPrice
            // 
            this.TBoxNewPrice.Location = new System.Drawing.Point(222, 139);
            this.TBoxNewPrice.MaximumSize = new System.Drawing.Size(400, 33);
            this.TBoxNewPrice.MinimumSize = new System.Drawing.Size(180, 33);
            this.TBoxNewPrice.Name = "TBoxNewPrice";
            this.TBoxNewPrice.Size = new System.Drawing.Size(200, 26);
            this.TBoxNewPrice.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter price, $";
            // 
            // BtnItemEdit
            // 
            this.BtnItemEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.BtnItemEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnItemEdit.FlatAppearance.BorderSize = 0;
            this.BtnItemEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItemEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnItemEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.BtnItemEdit.Location = new System.Drawing.Point(18, 197);
            this.BtnItemEdit.Name = "BtnItemEdit";
            this.BtnItemEdit.Size = new System.Drawing.Size(405, 58);
            this.BtnItemEdit.TabIndex = 18;
            this.BtnItemEdit.Text = "SAVE CHANGES";
            this.BtnItemEdit.UseVisualStyleBackColor = false;
            this.BtnItemEdit.Click += new System.EventHandler(this.BtnItemEdit_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(444, 270);
            this.Controls.Add(this.BtnItemEdit);
            this.Controls.Add(this.TBoxNewQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxNewPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.TextBox TBoxNewQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBoxNewPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnItemEdit;
    }
}