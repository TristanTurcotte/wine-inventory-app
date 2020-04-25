namespace WineInventoryApp.Controls.Pages
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmitLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.linkLblForgotPass = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Page";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLblForgotPass);
            this.panel1.Controls.Add(this.btnSubmitLogin);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.txtBoxUsername);
            this.panel1.Location = new System.Drawing.Point(280, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 209);
            this.panel1.TabIndex = 6;
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.Location = new System.Drawing.Point(71, 142);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitLogin.TabIndex = 10;
            this.btnSubmitLogin.Text = "Login";
            this.btnSubmitLogin.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(18, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(82, 83);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 7;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(82, 45);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUsername.TabIndex = 6;
            // 
            // linkLblForgotPass
            // 
            this.linkLblForgotPass.AutoSize = true;
            this.linkLblForgotPass.Location = new System.Drawing.Point(3, 185);
            this.linkLblForgotPass.Name = "linkLblForgotPass";
            this.linkLblForgotPass.Size = new System.Drawing.Size(114, 13);
            this.linkLblForgotPass.TabIndex = 11;
            this.linkLblForgotPass.TabStop = true;
            this.linkLblForgotPass.Text = "Forgot your password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "This is an example user control showing how a page would be made.";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 426);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(800, 426);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLblForgotPass;
        private System.Windows.Forms.Button btnSubmitLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MaskedTextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label label2;
    }
}
