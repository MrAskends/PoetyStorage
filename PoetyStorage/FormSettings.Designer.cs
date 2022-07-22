
namespace PoetyStorage
{
    partial class FormSettings
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
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelPoemName = new System.Windows.Forms.Label();
            this.labelPoemText = new System.Windows.Forms.Label();
            this.buttonAddPoem = new System.Windows.Forms.Button();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxPoemName = new System.Windows.Forms.TextBox();
            this.textBoxPoemText = new System.Windows.Forms.TextBox();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorName.Location = new System.Drawing.Point(301, 12);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(86, 19);
            this.labelAuthorName.TabIndex = 0;
            this.labelAuthorName.Text = "Имя автора";
            // 
            // labelPoemName
            // 
            this.labelPoemName.AutoSize = true;
            this.labelPoemName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoemName.Location = new System.Drawing.Point(257, 61);
            this.labelPoemName.Name = "labelPoemName";
            this.labelPoemName.Size = new System.Drawing.Size(177, 19);
            this.labelPoemName.TabIndex = 1;
            this.labelPoemName.Text = "Название стихотворения";
            // 
            // labelPoemText
            // 
            this.labelPoemText.AutoSize = true;
            this.labelPoemText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoemText.Location = new System.Drawing.Point(270, 112);
            this.labelPoemText.Name = "labelPoemText";
            this.labelPoemText.Size = new System.Drawing.Size(149, 19);
            this.labelPoemText.TabIndex = 2;
            this.labelPoemText.Text = "Текст стихотворения";
            // 
            // buttonAddPoem
            // 
            this.buttonAddPoem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPoem.Location = new System.Drawing.Point(82, 374);
            this.buttonAddPoem.Name = "buttonAddPoem";
            this.buttonAddPoem.Size = new System.Drawing.Size(512, 64);
            this.buttonAddPoem.TabIndex = 4;
            this.buttonAddPoem.Text = "Добавить стихотворение";
            this.buttonAddPoem.UseVisualStyleBackColor = true;
            this.buttonAddPoem.Click += new System.EventHandler(this.buttonAddPoem_Click);
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthorName.Location = new System.Drawing.Point(82, 32);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(512, 26);
            this.textBoxAuthorName.TabIndex = 5;
            // 
            // textBoxPoemName
            // 
            this.textBoxPoemName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoemName.Location = new System.Drawing.Point(82, 83);
            this.textBoxPoemName.Name = "textBoxPoemName";
            this.textBoxPoemName.Size = new System.Drawing.Size(512, 26);
            this.textBoxPoemName.TabIndex = 6;
            // 
            // textBoxPoemText
            // 
            this.textBoxPoemText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoemText.Location = new System.Drawing.Point(82, 132);
            this.textBoxPoemText.Multiline = true;
            this.textBoxPoemText.Name = "textBoxPoemText";
            this.textBoxPoemText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPoemText.Size = new System.Drawing.Size(512, 236);
            this.textBoxPoemText.TabIndex = 7;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatAppearance.BorderSize = 0;
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.Image = global::PoetyStorage.Properties.Resources.Back;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(64, 64);
            this.buttonBackToMainMenu.TabIndex = 3;
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.textBoxPoemText);
            this.Controls.Add(this.textBoxPoemName);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.buttonAddPoem);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.labelPoemText);
            this.Controls.Add(this.labelPoemName);
            this.Controls.Add(this.labelAuthorName);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poety storage settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelPoemName;
        private System.Windows.Forms.Label labelPoemText;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonAddPoem;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.TextBox textBoxPoemName;
        private System.Windows.Forms.TextBox textBoxPoemText;
    }
}