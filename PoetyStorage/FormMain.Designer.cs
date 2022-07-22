
namespace PoetyStorage
{
    partial class FormMain
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
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelNickname = new System.Windows.Forms.Label();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelPoem = new System.Windows.Forms.Label();
            this.comboBoxPoems = new System.Windows.Forms.ComboBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelLastname.Location = new System.Drawing.Point(10, 8);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(83, 19);
            this.labelLastname.TabIndex = 0;
            this.labelLastname.Text = "Фамилия : ";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelFirstname.Location = new System.Drawing.Point(10, 24);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(48, 19);
            this.labelFirstname.TabIndex = 1;
            this.labelFirstname.Text = "Имя : ";
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelNickname.Location = new System.Drawing.Point(10, 41);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(97, 19);
            this.labelNickname.TabIndex = 2;
            this.labelNickname.Text = "Псевдоним : ";
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(12, 82);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(291, 27);
            this.comboBoxAuthors.TabIndex = 4;
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthors_SelectedIndexChanged);
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonRead.Location = new System.Drawing.Point(89, 167);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(146, 35);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Читать";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelAuthor.Location = new System.Drawing.Point(135, 60);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(51, 19);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Автор";
            // 
            // labelPoem
            // 
            this.labelPoem.AutoSize = true;
            this.labelPoem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPoem.Location = new System.Drawing.Point(101, 112);
            this.labelPoem.Name = "labelPoem";
            this.labelPoem.Size = new System.Drawing.Size(113, 19);
            this.labelPoem.TabIndex = 7;
            this.labelPoem.Text = "Стихотворение";
            // 
            // comboBoxPoems
            // 
            this.comboBoxPoems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPoems.Enabled = false;
            this.comboBoxPoems.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxPoems.FormattingEnabled = true;
            this.comboBoxPoems.Location = new System.Drawing.Point(12, 134);
            this.comboBoxPoems.Name = "comboBoxPoems";
            this.comboBoxPoems.Size = new System.Drawing.Size(291, 27);
            this.comboBoxPoems.TabIndex = 8;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Image = global::PoetyStorage.Properties.Resources.Settings;
            this.buttonSettings.Location = new System.Drawing.Point(249, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(64, 64);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 209);
            this.Controls.Add(this.comboBoxPoems);
            this.Controls.Add(this.labelPoem);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelLastname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poety storage";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPoem;
        private System.Windows.Forms.ComboBox comboBoxPoems;
    }
}

