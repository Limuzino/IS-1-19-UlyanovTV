using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_19_UlyanovTV
{
    public partial class Zadanie2 : Form
    {
        public Zadanie2()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {   
            //создаём экземпляр класса
            ConnectDB ConnDb = new ConnectDB();
            //создаём экзепляр класса MySqlConnection и присваиваем ему значение которое возвращает метод Initialization
            MySqlConnection connDb = new MySqlConnection(ConnDb.Initialization());
            //Пробуем подключиться к БД
            try
            {
                connDb.Open();
                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                //здесь я поигрался с исключением, хотелось выводить проблему более подробно
                string message = ex.Message;
                MessageBox.Show(message);
            }
            finally
            {
                connDb.Close();
            }
        }
    }
}
