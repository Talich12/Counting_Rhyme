using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form4 f4;
        private async void button1_Click(object sender, EventArgs e)
        {   if (comboBox1.SelectedItem != null)
            {
                if (textBox1.Text.Length > 0)
                {
                    string text = textBox1.Text;
                    int k = 0;
                    for (int i = 0; i < text.Length - 2; i++)
                    {
                        if (text[i] != ' ' && text[i + 1] == ' ')
                        {
                            k++;
                        }
                    }
                    k++;
                    DataBase.k = k;
                    f4 = new Form4();
                    f4.ShowDialog();
                }
                else
                {
                    button1.Text = "Введите считалочку!";
                    await Task.Delay(2000);
                    button1.Text = "Запустить считалочку!!!";
                }
            }
            else
            {
                button1.Text = "Введите количество участников!";
                await Task.Delay(2000);
                button1.Text = "Запустить считалочку!!!";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase.n = Convert.ToInt32(comboBox1.SelectedItem);
            DataBase.n1 = Convert.ToInt32(comboBox1.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataBase.text = Convert.ToString(textBox1.Text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
