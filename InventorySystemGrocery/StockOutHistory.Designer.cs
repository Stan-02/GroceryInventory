namespace InventorySystemGrocery
{
    partial class StockOutHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutHistory));
            this.DGVHisInvent = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchHistory = new System.Windows.Forms.TextBox();
            this.purchaseSearch = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHisInvent)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVHisInvent
            // 
            this.DGVHisInvent.AllowUserToAddRows = false;
            this.DGVHisInvent.BackgroundColor = System.Drawing.Color.White;
            this.DGVHisInvent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHisInvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVHisInvent.ColumnHeadersHeight = 34;
            this.DGVHisInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVHisInvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column6,
            this.Column5,
            this.Column4,
            this.Column8});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVHisInvent.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVHisInvent.EnableHeadersVisualStyles = false;
            this.DGVHisInvent.Location = new System.Drawing.Point(1, 108);
            this.DGVHisInvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVHisInvent.Name = "DGVHisInvent";
            this.DGVHisInvent.RowHeadersVisible = false;
            this.DGVHisInvent.RowHeadersWidth = 62;
            this.DGVHisInvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVHisInvent.Size = new System.Drawing.Size(1620, 545);
            this.DGVHisInvent.TabIndex = 15;
            this.DGVHisInvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHisInvent_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtSearchHistory);
            this.panel3.Controls.Add(this.purchaseSearch);
            this.panel3.Location = new System.Drawing.Point(10, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 63);
            this.panel3.TabIndex = 19;
            // 
            // txtSearchHistory
            // 
            this.txtSearchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchHistory.Location = new System.Drawing.Point(62, 14);
            this.txtSearchHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchHistory.Name = "txtSearchHistory";
            this.txtSearchHistory.Size = new System.Drawing.Size(488, 35);
            this.txtSearchHistory.TabIndex = 12;
            this.txtSearchHistory.TextChanged += new System.EventHandler(this.txtSearchHistory_TextChanged);
            // 
            // purchaseSearch
            // 
            this.purchaseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseSearch.FlatAppearance.BorderSize = 0;
            this.purchaseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseSearch.Image = ((System.Drawing.Image)(resources.GetObject("purchaseSearch.Image")));
            this.purchaseSearch.Location = new System.Drawing.Point(6, 5);
            this.purchaseSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.purchaseSearch.Name = "purchaseSearch";
            this.purchaseSearch.Size = new System.Drawing.Size(46, 57);
            this.purchaseSearch.TabIndex = 12;
            this.purchaseSearch.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 8.251877F;
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 19.17921F;
            this.Column3.HeaderText = "Product Code";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 456.8528F;
            this.Column2.HeaderText = "Product Description";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
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
            this.Column5.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // StockOutHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1620, 648);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DGVHisInvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockOutHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DGVHisInvent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVHisInvent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchHistory;
        private System.Windows.Forms.Button purchaseSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}