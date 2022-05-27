
namespace WindowsFormsDB
{
    partial class Form1
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
            this.l_Login = new System.Windows.Forms.Label();
            this.l_Password = new System.Windows.Forms.Label();
            this.b_SignIn = new System.Windows.Forms.Button();
            this.t_password = new System.Windows.Forms.TextBox();
            this.t_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // l_Login
            // 
            this.l_Login.AutoSize = true;
            this.l_Login.Location = new System.Drawing.Point(303, 90);
            this.l_Login.Name = "l_Login";
            this.l_Login.Size = new System.Drawing.Size(59, 20);
            this.l_Login.TabIndex = 0;
            this.l_Login.Text = "LOGIN";
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.Location = new System.Drawing.Point(279, 165);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(103, 20);
            this.l_Password.TabIndex = 1;
            this.l_Password.Text = "PASSWORD";
            // 
            // b_SignIn
            // 
            this.b_SignIn.Location = new System.Drawing.Point(279, 273);
            this.b_SignIn.Name = "b_SignIn";
            this.b_SignIn.Size = new System.Drawing.Size(103, 49);
            this.b_SignIn.TabIndex = 2;
            this.b_SignIn.Text = "SIGN IN";
            this.b_SignIn.UseVisualStyleBackColor = true;
            this.b_SignIn.Click += new System.EventHandler(this.b_SignIn_Click);
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(237, 198);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(186, 26);
            this.t_password.TabIndex = 3;
            // 
            // t_login
            // 
            this.t_login.Location = new System.Drawing.Point(237, 123);
            this.t_login.Name = "t_login";
            this.t_login.Size = new System.Drawing.Size(186, 26);
            this.t_login.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.t_login);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.b_SignIn);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.l_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Login;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.Button b_SignIn;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.TextBox t_login;
    }
}

