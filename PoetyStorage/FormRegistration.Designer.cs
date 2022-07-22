
namespace PoetyStorage
{
    partial class FormRegistration
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.labelPasswordRepeat = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonRegistration.Location = new System.Drawing.Point(9, 231);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(171, 26);
            this.buttonRegistration.TabIndex = 11;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPassword.Location = new System.Drawing.Point(10, 50);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(171, 17);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Введите пароль";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelLogin.Location = new System.Drawing.Point(10, 6);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(171, 17);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Введите логин";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(10, 70);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(172, 22);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxLogin.Location = new System.Drawing.Point(10, 26);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(172, 22);
            this.textBoxLogin.TabIndex = 7;
            // 
            // textBoxPasswordRepeat
            // 
            this.textBoxPasswordRepeat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxPasswordRepeat.Location = new System.Drawing.Point(10, 114);
            this.textBoxPasswordRepeat.Multiline = true;
            this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            this.textBoxPasswordRepeat.PasswordChar = '●';
            this.textBoxPasswordRepeat.Size = new System.Drawing.Size(172, 22);
            this.textBoxPasswordRepeat.TabIndex = 12;
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPasswordRepeat.Location = new System.Drawing.Point(10, 94);
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(171, 17);
            this.labelPasswordRepeat.TabIndex = 13;
            this.labelPasswordRepeat.Text = "Повторите пароль";
            this.labelPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstname
            // 
            this.labelFirstname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelFirstname.Location = new System.Drawing.Point(10, 139);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(171, 17);
            this.labelFirstname.TabIndex = 14;
            this.labelFirstname.Text = "Введите имя";
            this.labelFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxFirstname.Location = new System.Drawing.Point(10, 159);
            this.textBoxFirstname.Multiline = true;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(172, 22);
            this.textBoxFirstname.TabIndex = 15;
            // 
            // labelLastname
            // 
            this.labelLastname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelLastname.Location = new System.Drawing.Point(10, 183);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(171, 17);
            this.labelLastname.TabIndex = 16;
            this.labelLastname.Text = "Введите фамилию";
            this.labelLastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxLastname.Location = new System.Drawing.Point(10, 203);
            this.textBoxLastname.Multiline = true;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(172, 22);
            this.textBoxLastname.TabIndex = 17;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonLogin.Location = new System.Drawing.Point(9, 263);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(171, 26);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 295);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelPasswordRepeat);
            this.Controls.Add(this.textBoxPasswordRepeat);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poety storage registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPasswordRepeat;
        private System.Windows.Forms.Label labelPasswordRepeat;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Button buttonLogin;
    }
}