namespace ZinaraAdminMain
{
    partial class Topup
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topUpCardNumber = new System.Windows.Forms.Label();
            this.txtammount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // topUpCardNumber
            // 
            this.topUpCardNumber.AutoSize = true;
            this.topUpCardNumber.Location = new System.Drawing.Point(115, 19);
            this.topUpCardNumber.Name = "topUpCardNumber";
            this.topUpCardNumber.Size = new System.Drawing.Size(29, 15);
            this.topUpCardNumber.TabIndex = 2;
            this.topUpCardNumber.Text = "N/A";
            // 
            // txtammount
            // 
            this.txtammount.Location = new System.Drawing.Point(115, 58);
            this.txtammount.Name = "txtammount";
            this.txtammount.Size = new System.Drawing.Size(137, 23);
            this.txtammount.TabIndex = 3;
            this.txtammount.TextChanged += new System.EventHandler(this.txtammount_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "TopUp Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currencyCombo
            // 
            this.currencyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "$ZWL",
            "$USD"});
            this.currencyCombo.Location = new System.Drawing.Point(114, 89);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(137, 23);
            this.currencyCombo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Currency";
            // 
            // Topup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currencyCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtammount);
            this.Controls.Add(this.topUpCardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Topup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label topUpCardNumber;
        private System.Windows.Forms.TextBox txtammount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Label label3;
    }
}