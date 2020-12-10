using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        //Создание новой коллекции для использования в программе
        List<int> mass = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        //Очищение массива
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Добавление элементов в массив: Через коллекцию mass
            mass.Add(Convert.ToInt32(textBox1.Text));
            //Напрямую в listBox1
            listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            //Очищение textBox для удобства 
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Вывод количества элементов массива по свойсву mass.Count
            MessageBox.Show("Количество элементов = " + " " + mass.Count + " ");
            int result = 0;//переменная для вывода с начальным значением 0
            //Цикл до количества всех элементов listBox
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                //Условие кратности 7ми элементов listBox 
                if ((int)listBox1.Items[i] % 7 == 0)
                {
                    //Присваивание раннее заданной переменной result значения элемента listBox, прошедшего проверку на кратность
                    result += Convert.ToInt32(listBox1.Items[i]);
                }
            }
            //Вывод result через message box
            MessageBox.Show("Сумма элементов таблицы кратных 7 = " + result);
        }
        //О программе(Меню)
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-31  \n" +
                "Практическая 10, вариант 2: \n" +
                "Составьте программу вычисления в массиве суммы всех чисел, кратных 7");
        }
        //О программе(Форма)
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-31  \n" +
                "Практическая 10, вариант 2: \n" +
                "Составьте программу вычисления в массиве суммы всех чисел, кратных 7");
        }
        //Выйти(Меню)
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Выйти(Форма)
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //При нажатии клавиши Enter в textBox произойдет нажатие кнопки "Добавить элемент в массив"
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button2_Click(sender, e);
        }
    }
}
