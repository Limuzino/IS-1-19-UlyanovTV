using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_19_UlyanovTV
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }

    //класс для подключени
    public class ConnectDB
    {
        //поля, к которым будут присваиваться значения, для подключения к Базе данных
        public string conn;
        public string Host;
        public string Port;
        public string User;
        public string Database;
        public string Password;

        //метод Инициализации (создания подключения к бд)
        public string Initialization()
        {
            //Присваиваем значения переменным
            Host = "caseum.ru";
            Port = "33333";
            User = "test_user";
            Database = "db_test";
            Password = "test_pass";
            //объявляем поле отвечающее за создание подключения к бд
            string connecionString;
            //создаём подключение
            connecionString = $"server={Host};port={Port};user={User};database={Database};password={Password};";

            conn = connecionString;
            //возвращаем созданное подлючение (для удобства в виде переменной conn)
            return conn;
        }
    }
}
