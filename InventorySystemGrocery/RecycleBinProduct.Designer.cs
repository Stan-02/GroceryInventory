namespace InventorySystemGrocery
{
    partial class RecycleBinProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBinProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCatExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVProdBin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restore = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdBin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnCatExit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 86);
            this.panel2.TabIndex = 20;
            // 
            // btnCatExit
            // 
            this.btnCatExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatExit.FlatAppearance.BorderSize = 0;
            this.btnCatExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCatExit.Image")));
            this.btnCatExit.Location = new System.Drawing.Point(1054, 2);
            this.btnCatExit.Name = "btnCatExit";
            this.btnCatExit.Size = new System.Drawing.Size(24, 23);
            this.btnCatExit.TabIndex = 37;
            this.btnCatExit.UseVisualStyleBackColor = true;
            this.btnCatExit.Click += new System.EventHandler(this.btnCatExit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 42);
            this.label2.TabIndex = 23;
            this.label2.Text = "Product Recycle Bin";
            // 
            // DGVProdBin
            // 
            this.DGVProdBin.AllowUserToAddRows = false;
            this.DGVProdBin.BackgroundColor = System.Drawing.Color.White;
            this.DGVProdBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVProdBin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProdBin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProdBin.ColumnHeadersHeight = 34;
            this.DGVProdBin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVProdBin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ProductCode,
            this.Column9,
            this.Column2,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Restore,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProdBin.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProdBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProdBin.EnableHeadersVisualStyles = false;
            this.DGVProdBin.Location = new System.Drawing.Point(0, 86);
            this.DGVProdBin.Name = "DGVProdBin";
            this.DGVProdBin.RowHeadersVisible = false;
            this.DGVProdBin.RowHeadersWidth = 62;
            this.DGVProdBin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProdBin.Size = new System.Drawing.Size(1080, 394);
            this.DGVProdBin.TabIndex = 21;
            this.DGVProdBin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProdBin_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 8.251877F;
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // ProductCode
            // 
            this.ProductCode.FillWeight = 19.17921F;
            this.ProductCode.HeaderText = "ProductCode";
            this.ProductCode.MinimumWidth = 8;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Product Name";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 456.8528F;
            this.Column2.HeaderText = "Product Description";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 155;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 26.50313F;
            this.Column4.HeaderText = "Category";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 52.1784F;
            this.Column6.HeaderText = "Quantity";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 37.0346F;
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Expiration Date";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Restore
            // 
            this.Restore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Restore.HeaderText = "";
            this.Restore.Image = ((System.Drawing.Image)(resources.GetObject("Restore.Image")));
            this.Restore.MinimumWidth = 8;
            this.Restore.Name = "Restore";
            this.Restore.Width = 8;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Width = 8;
            // 
            // RecycleBinProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 480);
            this.Controls.Add(this.DGVProdBin);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecycleBinProduct";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProdBin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCatExit;
        private System.Windows.Forms.DataGridView DGVProdBin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Restore;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}