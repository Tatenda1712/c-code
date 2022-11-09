namespace ZinaraAdminMain
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginpassword = new System.Windows.Forms.TextBox();
            this.loginemail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loginerror = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // loginpassword
            // 
            this.loginpassword.Location = new System.Drawing.Point(48, 285);
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.Size = new System.Drawing.Size(174, 23);
            this.loginpassword.TabIndex = 2;
            // 
            // loginemail
            // 
            this.loginemail.Location = new System.Drawing.Point(48, 233);
            this.loginemail.Name = "loginemail";
            this.loginemail.Size = new System.Drawing.Size(174, 23);
            this.loginemail.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(91, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginerror
            // 
            this.loginerror.AutoSize = true;
            this.loginerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginerror.Location = new System.Drawing.Point(49, 311);
            this.loginerror.Name = "loginerror";
            this.loginerror.Size = new System.Drawing.Size(0, 15);
            this.loginerror.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ZinaraAdminMain.Properties.Resources.loginimage_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 176);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginerror);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginemail);
            this.Controls.Add(this.loginpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox loginpassword;
        private TextBox loginemail;
        private Button button1;
        private Label loginerror;
        private PictureBox pictureBox1;
    }
}