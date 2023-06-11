namespace InventorySystemGrocery
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCatExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnClearCat = new System.Windows.Forms.Button();
            this.lblCatID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnCatExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 97);
            this.panel1.TabIndex = 0;
            // 
            // btnCatExit
            // 
            this.btnCatExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatExit.FlatAppearance.BorderSize = 0;
            this.btnCatExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCatExit.Image")));
            this.btnCatExit.Location = new System.Drawing.Point(616, 0);
            this.btnCatExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCatExit.Name = "btnCatExit";
            this.btnCatExit.Size = new System.Drawing.Size(36, 35);
            this.btnCatExit.TabIndex = 36;
            this.btnCatExit.UseVisualStyleBackColor = true;
            this.btnCatExit.Click += new System.EventHandler(this.btnCatExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(18, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name:";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(219, 156);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(398, 35);
            this.txtCategory.TabIndex = 2;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.ForeColor = System.Drawing.Color.White;
            this.btnAddCat.Location = new System.Drawing.Point(251, 217);
            this.btnAddCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(84, 38);
            this.btnAddCat.TabIndex = 34;
            this.btnAddCat.Text = "ADD";
            this.btnAddCat.UseVisualStyleBackColor = false;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnClearCat
            // 
            this.btnClearCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearCat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClearCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCat.ForeColor = System.Drawing.Color.White;
            this.btnClearCat.Location = new System.Drawing.Point(468, 218);
            this.btnClearCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearCat.Name = "btnClearCat";
            this.btnClearCat.Size = new System.Drawing.Size(94, 38);
            this.btnClearCat.TabIndex = 35;
            this.btnClearCat.Text = "CLEAR";
            this.btnClearCat.UseVisualStyleBackColor = false;
            this.btnClearCat.Click += new System.EventHandler(this.btnClearCat_Click);
            // 
            // lblCatID
            // 
            this.lblCatID.AutoSize = true;
            this.lblCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatID.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCatID.Location = new System.Drawing.Point(33, 218);
            this.lblCatID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatID.Name = "lblCatID";
            this.lblCatID.Size = new System.Drawing.Size(134, 26);
            this.lblCatID.TabIndex = 36;
            this.lblCatID.Text = "Category ID:";
            this.lblCatID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(343, 218);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 38);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(651, 302);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCatID);
            this.Controls.Add(this.btnClearCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblCatID;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCategory;
        public System.Windows.Forms.Button btnAddCat;
        public System.Windows.Forms.Button btnClearCat;
        public System.Windows.Forms.Button btnCatExit;
        public System.Windows.Forms.Button btnUpdate;
    }
}