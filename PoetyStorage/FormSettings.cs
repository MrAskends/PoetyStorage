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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            Main.settingsFormClosing = false;
        }



        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.settingsFormClosing)
            {
                Application.Exit();
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show(); // Показываем главную форму
            Main.settingsFormClosing = true;
            this.Close();
        }

        private void buttonAddPoem_Click(object sender, EventArgs e)
        {
            if(CheckDataCorrectness()) // Если данные корректны
            {
                Main.connection.MySqlAddPoem(textBoxAuthorName.Text, textBoxPoemName.Text, textBoxPoemText.Text); // Вызов метода добавления нового стихотворения в БД
                textBoxAuthorName.Clear(); // Очищаем текстбокс с именем автора
                textBoxPoemName.Clear(); // Очищаем текстбокс с названием стихотворения
                textBoxPoemText.Clear(); // Очищаем текстбокс с текстом стихотворения
                Main.mainFormFirstShowing = true;
            }

        }

        private bool CheckDataCorrectness() // Метод для проверки корректности введенных данных
        {
            if (textBoxAuthorName.Text == "" || textBoxPoemName.Text == "" || textBoxPoemText.Text == "") // Проверка что все поля заполнены 
            {
                MessageBox.Show("Одно из полей не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Main.connection.MySqlCheckPoem(textBoxPoemName.Text))  // Проверка на присутствие в бд такого же стихотворения
            {
                MessageBox.Show("Такое произведение уже есть в хранилище.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
