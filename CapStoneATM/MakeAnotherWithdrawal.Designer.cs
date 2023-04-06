
namespace CapStoneATM
{
    partial class MakeAnotherWithdrawal
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
            this.btn_anotherWithdrawal = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_anotherWithdrawal
            // 
            this.btn_anotherWithdrawal.Location = new System.Drawing.Point(632, 478);
            this.btn_anotherWithdrawal.Name = "btn_anotherWithdrawal";
            this.btn_anotherWithdrawal.Size = new System.Drawing.Size(150, 46);
            this.btn_anotherWithdrawal.TabIndex = 0;
            this.btn_anotherWithdrawal.Text = "Yes";
            this.btn_anotherWithdrawal.UseVisualStyleBackColor = true;
            this.btn_anotherWithdrawal.Click += new System.EventHandler(this.btn_anotherWithdrawal_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(405, 478);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(208, 46);
            this.btn_logOut.TabIndex = 1;
            this.btn_logOut.Text = "No and log out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Withdrawal succeseful. Would you like to make another withdrawal? ";
            // 
            // btn_editAccount
            // 
            this.btn_editAccount.Location = new System.Drawing.Point(118, 478);
            this.btn_editAccount.Name = "btn_editAccount";
            this.btn_editAccount.Size = new System.Drawing.Size(270, 46);
            this.btn_editAccount.TabIndex = 3;
            this.btn_editAccount.Text = "No and Edit account";
            this.btn_editAccount.UseVisualStyleBackColor = true;
            this.btn_editAccount.Click += new System.EventHandler(this.btn_editAccount_Click);
            // 
            // MakeAnotherWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 624);
            this.Controls.Add(this.btn_editAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_anotherWithdrawal);
            this.Name = "MakeAnotherWithdrawal";
            this.Text = "MakeAnotherWithdrawal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anotherWithdrawal;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editAccount;
    }
}