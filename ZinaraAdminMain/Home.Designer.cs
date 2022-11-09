namespace ZinaraAdminMain
{
    partial class Home
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeTopUpAccount = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.homeerror = new System.Windows.Forms.Label();
            this.newCardNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblnewcard = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iderror = new System.Windows.Forms.Label();
            this.displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(86, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(263, 21);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.displayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.displayPanel.Controls.Add(this.iderror);
            this.displayPanel.Controls.Add(this.pictureBox1);
            this.displayPanel.Controls.Add(this.homeTopUpAccount);
            this.displayPanel.Controls.Add(this.logoutButton);
            this.displayPanel.Controls.Add(this.label14);
            this.displayPanel.Controls.Add(this.groupBox2);
            this.displayPanel.Controls.Add(this.groupBox1);
            this.displayPanel.Controls.Add(this.txtId);
            this.displayPanel.Controls.Add(this.button1);
            this.displayPanel.Location = new System.Drawing.Point(0, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(800, 358);
            this.displayPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ZinaraAdminMain.Properties.Resources.zinaralogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 123);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // homeTopUpAccount
            // 
            this.homeTopUpAccount.BackColor = System.Drawing.Color.Yellow;
            this.homeTopUpAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homeTopUpAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeTopUpAccount.Location = new System.Drawing.Point(563, 12);
            this.homeTopUpAccount.Name = "homeTopUpAccount";
            this.homeTopUpAccount.Size = new System.Drawing.Size(122, 25);
            this.homeTopUpAccount.TabIndex = 9;
            this.homeTopUpAccount.Text = "Topup Card";
            this.homeTopUpAccount.UseVisualStyleBackColor = false;
            this.homeTopUpAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(691, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(85, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "ID Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.homeerror);
            this.groupBox2.Controls.Add(this.newCardNumber);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblnewcard);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(405, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 164);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Card Details";
            // 
            // homeerror
            // 
            this.homeerror.AutoSize = true;
            this.homeerror.ForeColor = System.Drawing.Color.Red;
            this.homeerror.Location = new System.Drawing.Point(158, 121);
            this.homeerror.Name = "homeerror";
            this.homeerror.Size = new System.Drawing.Size(0, 15);
            this.homeerror.TabIndex = 5;
            // 
            // newCardNumber
            // 
            this.newCardNumber.Location = new System.Drawing.Point(158, 85);
            this.newCardNumber.Name = "newCardNumber";
            this.newCardNumber.Size = new System.Drawing.Size(160, 23);
            this.newCardNumber.TabIndex = 4;
            this.newCardNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Card Number :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(83, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Please  Tap new Card";
            // 
            // lblnewcard
            // 
            this.lblnewcard.AutoSize = true;
            this.lblnewcard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnewcard.Location = new System.Drawing.Point(158, 56);
            this.lblnewcard.Name = "lblnewcard";
            this.lblnewcard.Size = new System.Drawing.Size(33, 17);
            this.lblnewcard.TabIndex = 1;
            this.lblnewcard.Text = "N/A";
            this.lblnewcard.Click += new System.EventHandler(this.lblnewcard_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "New Card Number :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladdress);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(145, 121);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(29, 15);
            this.lbladdress.TabIndex = 11;
            this.lbladdress.Text = "N/A";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(145, 93);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(29, 15);
            this.lblemail.TabIndex = 10;
            this.lblemail.Text = "N/A";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(145, 61);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 15);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "N/A";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(145, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(29, 15);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Number :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(497, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Assign Card";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // iderror
            // 
            this.iderror.AutoSize = true;
            this.iderror.ForeColor = System.Drawing.Color.Red;
            this.iderror.Location = new System.Drawing.Point(130, 44);
            this.iderror.Name = "iderror";
            this.iderror.Size = new System.Drawing.Size(0, 15);
            this.iderror.TabIndex = 11;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button assignNewCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnewcard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button homeTopUpAccount;
        private PictureBox pictureBox1;
        private TextBox newCardNumber;
        private Label label7;
        private Label homeerror;
        private Label iderror;
    }
}
