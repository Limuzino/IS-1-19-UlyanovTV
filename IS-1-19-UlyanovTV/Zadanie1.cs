using System;
using System.Windows.Forms;

namespace IS_1_19_UlyanovTV
{
    public partial class Zadanie1 : Form
    {
        public Zadanie1()
        {
            InitializeComponent();
        }

        abstract class Components<T> //Абстрактный, бобщённый класс от которого будут наследоваться родительские (Компоненты)
        {
            //переменные
            protected string Price; //Цена
            protected string YOI; //Год выпуска (Year of issue)
            protected T VC; //Артикул (Vendor code)

            //конструктор класса
            public Components (string price, string yoi, T vc)
            {
                Price = price;
                YOI = yoi;
                VC = vc;
            }

            //метод вывода информации
            public abstract void Display(ListBox lb);
        }

        class CP : Components <string> //Первый дочерний класс (ЦП)
        {
            //переменные, закрытые свойствами с помощью конструктора
            string Frequency; //Частота

            public string Frequency1
            {
                get { return Frequency; }
                set { Frequency = value; } 
            }
            string NOC; //Количество ядер (Number of Cores)

            public string NOC1
            {
                get { return NOC; }
                set { NOC = value; }
            }
            string NOT; //Количество потоков (Number of Threads)

            public string NOT1
            {
                get { return NOT; }
                set { NOT = value; }
            }

            //конструктор класса
            public CP (string price, string yoi, string vc, string frequency, string noc, string not)
                    :base (price, yoi, vc)
            {
                Frequency1 = frequency;
                NOC1 = noc;
                NOT1 = not;
            }

            //метод вывода информации (В данном случае о ЦП)
            public override void Display(ListBox listbox1)
            {
                listbox1.Items.Add("Ваша информация о ЦП:");
                listbox1.Items.Add($"Цена: {Price}");
                listbox1.Items.Add($"Год выпуска: {YOI}");
                listbox1.Items.Add($"Артикул: {VC}");
                listbox1.Items.Add($"Частота: {Frequency1}");
                listbox1.Items.Add($"Количество ядер: {NOC1}");
                listbox1.Items.Add($"Количество потоков: {NOT1}");
                listbox1.Items.Add("--------------------------------------------------------------------------------");
            }
        }

        class VideoCard : Components <string> //Второй дочерний класс (Видеокарта)
        {
            //переменные, закрытые свойствами с помощью конструктора
            string Frequency; //Частота

            public string Frequency1
            {
                get { return Frequency; }
                set { Frequency = value; }
            }
            string Performance; //Производительность

            public string Performance1
            {
                get { return Performance; }
                set { Performance = value; }
            }
            string Memory; //Объём памяти

            public string Memory1
            {
                get { return Memory; }
                set { Memory = value; }
            }

            //конструктор класса
            public VideoCard(string price, string yoi, string vc, string frequency, string performance, string memory)
                    : base(price, yoi, vc)
            {
                Frequency1 = frequency;
                Performance1 = performance;
                Memory1 = memory;
            }

            //метод вывода информации (В данном случае о Видеокарте)
            public override void Display(ListBox listbox1)
            {
                listbox1.Items.Add("Ваша информация о Видеокарте:");
                listbox1.Items.Add($"Цена: {Price}");
                listbox1.Items.Add($"Год выпуска: {YOI}");
                listbox1.Items.Add($"Артикул: {VC}");
                listbox1.Items.Add($"Частота: {Frequency1}");
                listbox1.Items.Add($"Производительность: {Performance1}");
                listbox1.Items.Add($"Объём памяти: {Memory1}");
                listbox1.Items.Add("--------------------------------------------------------------------------------");
            }
        }
        //Глобальные экземпляры классов
        CP cp;
        VideoCard vc;

        //Приводим в исполнение через кнопки
        private void button1_Click(object sender, EventArgs e)
        {
            //перестраховка от глупого человека
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Вы не заполнили строку Цена");
                return;
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Вы не заполнили строку Год выпуска");
                return;
            }
            else if (String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Вы не заполнили строку Артикул");
                return;
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Вы не заполнили строку Частота");
                return;
            }
            else if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Вы не заполнили строку Ядер ЦП");
                return;
            }
            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Вы не заполнили строку Потоков ЦП");
                return;
            }
            cp = new CP(textBox1.Text, textBox2.Text, textBox9.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            cp.Display(listBox1);
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //перестраховка от глупого человека
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Вы не заполнили строку Цена");
                return;
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Вы не заполнили строку Год выпуска");
                return;
            }
            else if (String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Вы не заполнили строку Артикул");
                return;
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Вы не заполнили строку Частота");
                return;
            }
            else if (String.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Вы не заполнили строку Производительности видеокарты");
                return;
            }
            else if (String.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Вы не заполнили строку Объёма памяти видеокарты");
                return;
            }
            vc = new VideoCard(textBox1.Text, textBox2.Text, textBox9.Text, textBox3.Text, textBox7.Text, textBox8.Text);
            vc.Display(listBox1);
            
        }

    }
}
