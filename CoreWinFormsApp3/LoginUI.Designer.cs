
namespace CoreWinFormsApp3
{
    partial class LoginUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(116, 181);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(116, 104);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(347, 27);
            this.txt_login.TabIndex = 2;
            this.txt_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_login_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(116, 233);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(347, 27);
            this.txt_password.TabIndex = 3;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(116, 311);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(94, 29);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(312, 311);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(94, 29);
            this.btn_annuler.TabIndex = 5;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Name = "LoginUI";
            this.Text = "LoginUI";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
    }
}