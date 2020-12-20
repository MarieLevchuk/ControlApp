namespace ControllApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxManufacturers = new System.Windows.Forms.ComboBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRemoveManufacturer = new System.Windows.Forms.Button();
            this.BtnAddManufacturer = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(73)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.LblClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 51);
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
            this.LblClose.Location = new System.Drawing.Point(880, 13);
            this.LblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(47, 32);
            this.LblClose.TabIndex = 0;
            this.LblClose.Text = "x";
            this.LblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manufcturer";
            // 
            // CBoxManufacturers
            // 
            this.CBoxManufacturers.FormattingEnabled = true;
            this.CBoxManufacturers.Location = new System.Drawing.Point(170, 80);
            this.CBoxManufacturers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBoxManufacturers.Name = "CBoxManufacturers";
            this.CBoxManufacturers.Size = new System.Drawing.Size(200, 28);
            this.CBoxManufacturers.TabIndex = 2;
            this.CBoxManufacturers.SelectedIndexChanged += new System.EventHandler(this.CBoxManufacturers_SelectedIndexChanged);
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(228)))));
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DataGrid.Location = new System.Drawing.Point(18, 140);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.Size = new System.Drawing.Size(897, 432);
            this.DataGrid.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price, $";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // BtnRemoveManufacturer
            // 
            this.BtnRemoveManufacturer.BackColor = System.Drawing.Color.Transparent;
            this.BtnRemoveManufacturer.BackgroundImage = global::ControllApp.Properties.Resources.icon_manufacturer_remove;
            this.BtnRemoveManufacturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRemoveManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveManufacturer.FlatAppearance.BorderSize = 0;
            this.BtnRemoveManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveManufacturer.Location = new System.Drawing.Point(505, 77);
            this.BtnRemoveManufacturer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRemoveManufacturer.Name = "BtnRemoveManufacturer";
            this.BtnRemoveManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRemoveManufacturer.Size = new System.Drawing.Size(46, 33);
            this.BtnRemoveManufacturer.TabIndex = 10;
            this.BtnRemoveManufacturer.UseVisualStyleBackColor = false;
            this.BtnRemoveManufacturer.Click += new System.EventHandler(this.BtnRemoveManufacturer_Click);
            // 
            // BtnAddManufacturer
            // 
            this.BtnAddManufacturer.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddManufacturer.BackgroundImage = global::ControllApp.Properties.Resources.icon_manufacturer;
            this.BtnAddManufacturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddManufacturer.FlatAppearance.BorderSize = 0;
            this.BtnAddManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddManufacturer.Location = new System.Drawing.Point(448, 76);
            this.BtnAddManufacturer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddManufacturer.Name = "BtnAddManufacturer";
            this.BtnAddManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAddManufacturer.Size = new System.Drawing.Size(46, 33);
            this.BtnAddManufacturer.TabIndex = 9;
            this.BtnAddManufacturer.UseVisualStyleBackColor = false;
            this.BtnAddManufacturer.Click += new System.EventHandler(this.BtnAddManufacturer_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.BackgroundImage = global::ControllApp.Properties.Resources.icon_update;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(813, 92);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEdit.Size = new System.Drawing.Size(34, 35);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.Transparent;
            this.BtnRemove.BackgroundImage = global::ControllApp.Properties.Resources.icon_delete;
            this.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Location = new System.Drawing.Point(870, 92);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRemove.Size = new System.Drawing.Size(34, 35);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefresh.BackgroundImage = global::ControllApp.Properties.Resources.icon_refresh;
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Location = new System.Drawing.Point(397, 76);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRefresh.Size = new System.Drawing.Size(34, 35);
            this.BtnRefresh.TabIndex = 5;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.BackgroundImage = global::ControllApp.Properties.Resources.icon_add;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(752, 92);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdd.Size = new System.Drawing.Size(34, 35);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(937, 580);
            this.Controls.Add(this.BtnRemoveManufacturer);
            this.Controls.Add(this.BtnAddManufacturer);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.CBoxManufacturers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label LblClose;
        public System.Windows.Forms.ComboBox CBoxManufacturers;
        private System.Windows.Forms.Button BtnAddManufacturer;
        private System.Windows.Forms.Button BtnRemoveManufacturer;
    }
}

