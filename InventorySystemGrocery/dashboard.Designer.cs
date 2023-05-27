namespace InventorySystemGrocery
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forTimer = new System.Windows.Forms.Label();
            this.btnupExit = new System.Windows.Forms.Button();
            this.btnupEnlarge = new System.Windows.Forms.Button();
            this.btnupMinimize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnAllform = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-2, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "Purchase";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Purchase";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(13, 167);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(130, 53);
            this.btnInventory.TabIndex = 4;
            this.btnInventory.Text = "   Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(13, 375);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(130, 53);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "    Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(13, 99);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(130, 53);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "    Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.forTimer);
            this.panel2.Controls.Add(this.btnupExit);
            this.panel2.Controls.Add(this.btnupEnlarge);
            this.panel2.Controls.Add(this.btnupMinimize);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 25);
            this.panel2.TabIndex = 1;
            // 
            // forTimer
            // 
            this.forTimer.AutoSize = true;
            this.forTimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forTimer.ForeColor = System.Drawing.Color.White;
            this.forTimer.Location = new System.Drawing.Point(264, 5);
            this.forTimer.Name = "forTimer";
            this.forTimer.Size = new System.Drawing.Size(41, 16);
            this.forTimer.TabIndex = 2;
            this.forTimer.Text = "label1";
            // 
            // btnupExit
            // 
            this.btnupExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupExit.FlatAppearance.BorderSize = 0;
            this.btnupExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupExit.Image = ((System.Drawing.Image)(resources.GetObject("btnupExit.Image")));
            this.btnupExit.Location = new System.Drawing.Point(605, 1);
            this.btnupExit.Name = "btnupExit";
            this.btnupExit.Size = new System.Drawing.Size(25, 24);
            this.btnupExit.TabIndex = 3;
            this.btnupExit.UseVisualStyleBackColor = true;
            this.btnupExit.Click += new System.EventHandler(this.btnupExit_Click);
            // 
            // btnupEnlarge
            // 
            this.btnupEnlarge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnupEnlarge.FlatAppearance.BorderSize = 0;
            this.btnupEnlarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupEnlarge.Image = ((System.Drawing.Image)(resources.GetObject("btnupEnlarge.Image")));
            this.btnupEnlarge.Location = new System.Drawing.Point(576, 1);
            this.btnupEnlarge.Name = "btnupEnlarge";
            this.btnupEnlarge.Size = new System.Drawing.Size(25, 25);
            this.btnupEnlarge.TabIndex = 4;
            this.btnupEnlarge.UseVisualStyleBackColor = true;
            this.btnupEnlarge.Click += new System.EventHandler(this.btnupEnlarge_Click);
            // 
            // btnupMinimize
            // 
            this.btnupMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupMinimize.FlatAppearance.BorderSize = 0;
            this.btnupMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnupMinimize.Image")));
            this.btnupMinimize.Location = new System.Drawing.Point(545, 8);
            this.btnupMinimize.Name = "btnupMinimize";
            this.btnupMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnupMinimize.TabIndex = 5;
            this.btnupMinimize.UseVisualStyleBackColor = true;
            this.btnupMinimize.Click += new System.EventHandler(this.btnupMinimize_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnAllform
            // 
            this.pnAllform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAllform.Location = new System.Drawing.Point(162, 25);
            this.pnAllform.Name = "pnAllform";
            this.pnAllform.Size = new System.Drawing.Size(638, 425);
            this.pnAllform.TabIndex = 2;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnAllform);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnupMinimize;
        private System.Windows.Forms.Button btnupExit;
        private System.Windows.Forms.Button btnupEnlarge;
        private System.Windows.Forms.Label forTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnAllform;
    }
}