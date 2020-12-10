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
        List<int> mass = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = listBox1.Items.Count;
            MessageBox.Show(res.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mass.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            listBox1.Items.Clear();
            listBox1.DataSource = mass;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int result = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if ((int)listBox1.Items[i] % 7 == 0)
                {
                    result += Convert.ToInt32(listBox1.Items[i]);
                }
            }
            MessageBox.Show(result.ToString());
        }
        //О программе(меню)
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-31  \n" +
                "Практическая 10, вариант 2: \n" +
                "Составьте программу вычисления в массиве суммы всех чисел, кратных 7");
        }
        //О программе
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-31  \n" +
                "Практическая 10, вариант 2: \n" +
                "Составьте программу вычисления в массиве суммы всех чисел, кратных 7");
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
