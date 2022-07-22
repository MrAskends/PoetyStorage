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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            if (Main.mainFormFirstShowing)
            {
                Main.mainFormFirstShowing = false;
                if (!Main.user.admin) // Если пользователь не администратор
                {
                    buttonSettings.Visible = false; // Скрываем кнопку настроек
                }
                comboBoxAuthors.Items.Clear(); // Очищаем элементы комбобокса
                comboBoxPoems.Enabled = false; // Выключаем комбобокс со стихами
                labelFirstname.Text = "Имя : " + Main.user.firstName; // Задаем лейблу начальное значение
                labelLastname.Text = "Фамилия : " + Main.user.lastName; // Задаем лейблу начальное значение
                labelNickname.Text = "Псевдоним : " + Main.user.login; // Задаем лейблу начальное значение
                Main.connection.MySqlGetAuthors(); // Метод получения всех доступных авторов
                foreach (string authorName in Main.allAuthorNames) // Проходим по всему списку и добавляем всех доступных авторов в комбобокс
                {
                    comboBoxAuthors.Items.Add(authorName); // Записываем в комбобокс authorName
                }
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            try
            {
                Main.connection.MySqlOpenConnection(); // Вызывает метод подключения к БД
                Main.connection.MySqlCreateDataBase(); // Вызывает метод создания БД
                Main.connection.MySqlCreateTables(); // Вызывает метод создания таблиц в БД
                Main.mainFormShowing = false;
                FormLogin loginForm = new FormLogin(); // Создание формы для логина
                loginForm.Show(); // Открытие второй формы (Логинига)
                this.Hide(); // Эту форму скрываем
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Выводим сообщение об ошбике
                Application.Exit();
            }
        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPoems.Items.Clear(); // Очищаем элементы комбобокса
            comboBoxPoems.Enabled = true; // Включаем комбобокс со стихами
            Main.connection.MySqlGetAuthorsPoems(Convert.ToString(comboBoxAuthors.SelectedItem)); // Метод получения всех доступных стихотворений автора
            foreach (string poemName in Main.allAuthorsPoems) // Проходим по всему списку и добавляем все доступные стихи авторова в комбобокс
            {
                comboBoxPoems.Items.Add(poemName); // Записываем в комбобокс poemName
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings(); // Создание формы для добавления новых стихотворений
            settingsForm.Show(); // Открытие формы для добавления новых стихотворений
            this.Hide();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(comboBoxPoems.Text))
            {
                Main.poemName = comboBoxPoems.SelectedItem.ToString(); // Записываем название выбранного стихотворения
                FormReading readingForm = new FormReading(); // Создание формы для чтения стихотворений
                readingForm.Show(); // Открытие формы для чтения стихотворений
                this.Hide();
            }
            else
                MessageBox.Show("Не выбрано стихотворение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Выводим сообщение об ошбике
        }
    }
}
