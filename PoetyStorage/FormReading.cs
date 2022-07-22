using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoetyStorage
{
    public partial class FormReading : Form
    {
        public FormReading()
        {
            InitializeComponent();
            Main.readingFormClosing = false;
        }

        private void FormReading_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.readingFormClosing)
            {
                Application.Exit();
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show(); // Показываем главную форму
            Main.readingFormClosing = true;
            this.Close();
        }

        private void FormReading_Load(object sender, EventArgs e)
        {
            Main.connection.MySqlGetPoem(); // Вызываем метод получения стихотворения
            labelAuthorName.Text = "Автор : " + Main.authorName; // Заполняем имя автора
            labelPoemName.Text = "Название стихотворения : " + Main.poemName; // заполняем название стихотворения
            textBoxPoemText.Text = Main.poemText; // Заполняем текстбокс самим стихотворением

        }
    }
}
