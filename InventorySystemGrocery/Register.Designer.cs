namespace InventorySystemGrocery
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnStock = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStock.BackColor = System.Drawing.Color.DarkCyan;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.Aqua;
            this.btnStock.Location = new System.Drawing.Point(452, 562);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(188, 55);
            this.btnStock.TabIndex = 35;
            this.btnStock.Text = "VIEW STOCK";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Aqua;
            this.btnClear.Location = new System.Drawing.Point(298, 562);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 55);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Aqua;
            this.btnAdd.Location = new System.Drawing.Point(146, 562);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 55);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRegDate.Location = new System.Drawing.Point(888, 165);
            this.dtpRegDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(298, 26);
            this.dtpRegDate.TabIndex = 16;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGenerate.Location = new System.Drawing.Point(669, 182);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(176, 49);
            this.btnGenerate.TabIndex = 31;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(298, 425);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(354, 35);
            this.txtPrice.TabIndex = 30;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(298, 368);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(354, 35);
            this.txtQuantity.TabIndex = 29;
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDesc.Location = new System.Drawing.Point(298, 248);
            this.txtProductDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(544, 35);
            this.txtProductDesc.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(40, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(40, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(40, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Category:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(40, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Product Description:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(40, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Code:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(452, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock In";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductCode.Enabled = false;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(298, 185);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(354, 35);
            this.txtProductCode.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 118);
            this.panel1.TabIndex = 20;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(298, 315);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(354, 37);
            this.cbCategory.TabIndex = 36;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(40, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 32);
            this.label7.TabIndex = 37;
            this.label7.Text = "Expiration Date:";
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpExpiration.Location = new System.Drawing.Point(298, 491);
            this.dtpExpiration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(298, 26);
            this.dtpExpiration.TabIndex = 38;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.Location = new System.Drawing.Point(656, 306);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(52, 58);
            this.btnAddCategory.TabIndex = 39;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 658);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dtpExpiration);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpRegDate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private System.Windows.Forms.Button btnAddCategory;
    }
}