using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public class ConnectDB1
    {
        //поля, к которым будут присваиваться значения, для подключения к Базе данных
        public string conn1;
        public string Host;
        public string Port;
        public string User;
        public string Database;
        public string Password;

        //метод Инициализации (создания подключения к бд)
        public string Initialization1()
        {
            //Присваиваем значения переменным
            Host = "caseum.ru";
            Port = "33333";
            User = "test_user";
            Database = "db_test";
            Password = "test_pass";
            //объявляем поле отвечающее за создание подключения к бд
            string connecionString1;
            //создаём подключение
            connecionString1 = $"server={Host};port={Port};user={User};database={Database};password={Password};";

            conn1 = connecionString1;
            //возвращаем созданное подлючение (для удобства в виде переменной conn)
            return conn1;
        }
    }
}
