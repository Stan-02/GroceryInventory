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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOutHistory));
            this.DGVHisInvent = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchHistory = new System.Windows.Forms.TextBox();
            this.purchaseSearch = new System.Windows.Forms.Button();
            this.btnCatExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHisInvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVHisInvent.ColumnHeadersHeight = 34;
            this.DGVHisInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVHisInvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column3,
            this.Column2,
            this.Column6,
            this.Column5,
            this.Column4,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVHisInvent.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVHisInvent.EnableHeadersVisualStyles = false;
            this.DGVHisInvent.Location = new System.Drawing.Point(1, 108);
            this.DGVHisInvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVHisInvent.Name = "DGVHisInvent";
            this.DGVHisInvent.RowHeadersVisible = false;
            this.DGVHisInvent.RowHeadersWidth = 62;
            this.DGVHisInvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVHisInvent.Size = new System.Drawing.Size(1226, 549);
            this.DGVHisInvent.TabIndex = 15;
            this.DGVHisInvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHisInvent_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.txtSearchHistory);
            this.panel3.Controls.Add(this.purchaseSearch);
            this.panel3.Location = new System.Drawing.Point(1, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 63);
            this.panel3.TabIndex = 19;
            // 
            // txtSearchHistory
            // 
            this.txtSearchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchHistory.Location = new System.Drawing.Point(62, 14);
            this.txtSearchHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchHistory.Name = "txtSearchHistory";
            this.txtSearchHistory.Size = new System.Drawing.Size(410, 35);
            this.txtSearchHistory.TabIndex = 12;
            this.txtSearchHistory.TextChanged += new System.EventHandler(this.txtSearchHistory_TextChanged);
            // 
            // purchaseSearch
            // 
            this.purchaseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseSearch.FlatAppearance.BorderSize = 0;
            this.purchaseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseSearch.Image = ((System.Drawing.Image)(resources.GetObject("purchaseSearch.Image")));
            this.purchaseSearch.Location = new System.Drawing.Point(12, 3);
            this.purchaseSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.purchaseSearch.Name = "purchaseSearch";
            this.purchaseSearch.Size = new System.Drawing.Size(46, 57);
            this.purchaseSearch.TabIndex = 12;
            this.purchaseSearch.UseVisualStyleBackColor = true;
            // 
            // btnCatExit
            // 
            this.btnCatExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatExit.FlatAppearance.BorderSize = 0;
            this.btnCatExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCatExit.Image")));
            this.btnCatExit.Location = new System.Drawing.Point(1181, -2);
            this.btnCatExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCatExit.Name = "btnCatExit";
            this.btnCatExit.Size = new System.Drawing.Size(46, 43);
            this.btnCatExit.TabIndex = 37;
            this.btnCatExit.UseVisualStyleBackColor = true;
            this.btnCatExit.Click += new System.EventHandler(this.btnCatExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 64);
            this.label1.TabIndex = 38;
            this.label1.Text = "Stock Out History";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FillWeight = 8.251877F;
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 72;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "StockOutID";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 135;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 19.17921F;
            this.Column3.HeaderText = "Product Code";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 456.8528F;
            this.Column2.HeaderText = "Product Description";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 201;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 52.1784F;
            this.Column6.HeaderText = "Quantity";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 111;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.FillWeight = 37.0346F;
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 85;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 82;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Total";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // StockOutHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1226, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCatExit);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVHisInvent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchHistory;
        private System.Windows.Forms.Button purchaseSearch;
        public System.Windows.Forms.Button btnCatExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}