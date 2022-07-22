
namespace PoetyStorage
{
    partial class FormReading
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
            this.labelPoemName = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.labelPoem = new System.Windows.Forms.Label();
            this.textBoxPoemText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPoemName
            // 
            this.labelPoemName.AutoSize = true;
            this.labelPoemName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoemName.Location = new System.Drawing.Point(82, 34);
            this.labelPoemName.Name = "labelPoemName";
            this.labelPoemName.Size = new System.Drawing.Size(188, 19);
            this.labelPoemName.TabIndex = 6;
            this.labelPoemName.Text = "Название стихотворения : ";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorName.Location = new System.Drawing.Point(82, 12);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(62, 19);
            this.labelAuthorName.TabIndex = 5;
            this.labelAuthorName.Text = "Автор : ";
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatAppearance.BorderSize = 0;
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.Image = global::PoetyStorage.Properties.Resources.Back;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(64, 64);
            this.buttonBackToMainMenu.TabIndex = 4;
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // labelPoem
            // 
            this.labelPoem.AutoSize = true;
            this.labelPoem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoem.Location = new System.Drawing.Point(82, 57);
            this.labelPoem.Name = "labelPoem";
            this.labelPoem.Size = new System.Drawing.Size(120, 19);
            this.labelPoem.TabIndex = 7;
            this.labelPoem.Text = "Стихотворение :";
            // 
            // textBoxPoemText
            // 
            this.textBoxPoemText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoemText.Location = new System.Drawing.Point(12, 82);
            this.textBoxPoemText.Multiline = true;
            this.textBoxPoemText.Name = "textBoxPoemText";
            this.textBoxPoemText.ReadOnly = true;
            this.textBoxPoemText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPoemText.Size = new System.Drawing.Size(514, 356);
            this.textBoxPoemText.TabIndex = 8;
            this.textBoxPoemText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.textBoxPoemText);
            this.Controls.Add(this.labelPoem);
            this.Controls.Add(this.labelPoemName);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Name = "FormReading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poety storage reading";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReading_FormClosing);
            this.Load += new System.EventHandler(this.FormReading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Label labelPoemName;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelPoem;
        private System.Windows.Forms.TextBox textBoxPoemText;
    }
}