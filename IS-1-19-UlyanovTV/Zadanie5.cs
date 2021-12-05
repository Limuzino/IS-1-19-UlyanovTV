using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnectDB;

namespace IS_1_19_UlyanovTV
{
    public partial class Zadanie5 : Form
    {
        public Zadanie5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //создаём экземпляр класса
            ConnectDB1 ConnDb1 = new ConnectDB1();
            //создаём экзепляр класса MySqlConnection и присваиваем ему значение которое возвращает метод Initialization
            MySqlConnection connDb = new MySqlConnection(ConnDb1.conn1);
            string fioStud = textBox1.Text;
            string datetime = textBox2.Text;
            string datetimeStud = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            MessageBox.Show(datetimeStud);
            string zapros = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{fioStud}','{datetime}');";
            int x = 0;
            try
            {
                connDb.Open();

                MySqlCommand com1 = new MySqlCommand(zapros, connDb);
                x = com1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //здесь я поигрался с исключением, хотелось выводить проблему более подробно
                string message = ex.Message;
                MessageBox.Show(message);
                this.Close();
            }
            finally
            {
                connDb.Close();

                if (x != 0)
                {
                    MessageBox.Show("Успешно!");
                }
            }
        }
    }
}
