using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_19_UlyanovTV
{
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //создаём экземпляр класса
            ConnectDB ConnDb = new ConnectDB();
            //создаём экзепляр класса MySqlConnection и присваиваем ему значение которое возвращает метод Initialization
            MySqlConnection connDb = new MySqlConnection(ConnDb.conn);
            //объявляем переменную запроса к БД
            string zapros = "SELECT id, fio, theme_kurs FROM t_stud";
            try
            {
                connDb.Open();
                //Создаём экземпляр класса MySqlDataAdapter, и даём ему 2 переменные (запрос к бд, и сами данные для подключения)
                MySqlDataAdapter adapter = new MySqlDataAdapter(zapros, connDb);
                //Воображаемая таблица с данными
                DataSet dataset = new DataSet();
                //Объединяем 2 переменные успеха, в результате чего Адаптер вытягивает данные в Воображаемую таблицу
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch
            {
                MessageBox.Show("Ошибка! Что-то пошло не так!");
            }
            finally
            {
                connDb.Close();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Штука, которая будет действовать когда кликнешь ЛКМ в dataGridView
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;

                string index;
                string id;

                index = dataGridView1.SelectedCells[0].RowIndex.ToString();
                id = dataGridView1.Rows[Convert.ToInt32(index)].Cells[1].Value.ToString();
                MessageBox.Show(id);
            }
        }
    }
}
