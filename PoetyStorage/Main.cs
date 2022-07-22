using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoetyStorage
{
    static class Main
    {

        public static DataBase connection; // Создаем объект класса DataBase

        public static User user; // Создаем объект класса User

        public static List<string> allAuthorNames; // Создаем список авторов которые есть

        public static List<string> allAuthorsPoems; // Создаем список произведений выбранного автора которые есть

        public static string authorName; // Создаем строку для хранения имени автора

        public static string poemName; // Создаем строку для хранения названия выбранного стихотворения

        public static string poemText; // Создаем строку для хранения текста выбранного стихотворения

        public static bool registrationFormClosing; // Флаг для отлавливания закрытия окна регистрации

        public static bool loginFormClosing; // Флаг для отлавливания закрытия окна логина

        public static bool mainFormShowing; // Флаг для отлавливания открытия главного окна

        public static bool mainFormFirstShowing; // Флаг для отлавливания первого открытия главного окна

        public static bool settingsFormClosing; // Флаг для отлавливания закрытия окна настроек

        public static bool readingFormClosing; // Флаг для отлавливания закрытия окна чтения

        static Main() // Singleton класса
        {
            connection = new DataBase("localhost", 3306, "root", "", "poety_storage", 100000);
            user = new User();
            allAuthorNames = new List<string>();
            allAuthorsPoems = new List<string>();
            authorName = "";
            poemName = "";
            poemText = "";
            registrationFormClosing = false;
            loginFormClosing = false;
            mainFormShowing = false;
            mainFormFirstShowing = false;
            settingsFormClosing = false;
            readingFormClosing = false;
        }

    }
}
