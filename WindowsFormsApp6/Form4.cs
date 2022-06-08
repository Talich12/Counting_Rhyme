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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = DataBase.text;
            int n = DataBase.n;
            List<string> list = new List<string>() {"Паша","Лера","Женя","Соня","Максим","Денис"};
            for (int i =0; i<n; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(126, 269);
                pictureBox.Image = Properties.Resources.img;
                Label label = new Label();
                pictureBox.Location = new Point(50+150*i,200);
                label.ForeColor = Color.Black;
                label.Location = new Point(75+150*i,180);
                label.Text = list[i];
                Controls.Add(label);
                Controls.Add(pictureBox);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "Паша", "Лера", "Женя", "Соня", "Максим", "Денис" };
            int k = DataBase.k;
            int n = DataBase.n;
            int n1 = DataBase.n1;
            List<int> Lint = DataBase.kol;
            int count = 0;
            int res = k;
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Size = new Size(63, 87);
            pictureBox1.Image = Properties.Resources.img3;

            while (res > n1)
            {
                res -= n1;
            }
            res--;
            for(int i =0; i<k; i++)
            {
                pictureBox1.Location = new Point(80 + 150 * Lint[count], 490);
                if (pictureBox1.Location.X > 80 + 150 * (n - 1))
                {
                    count = 0;
                    pictureBox1.Location = new Point(80 + 150 * Lint[count], 490);
                }
                Controls.Add(pictureBox1);
                count++;
                await Task.Delay(500);

            }
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Size = new Size(71, 62);
            pictureBox2.Image = Properties.Resources.img5;
            pictureBox2.Location = new Point(70 + 150*Lint[res],120);
            Controls.Add(pictureBox2);
            pictureBox1.Dispose();
            DataBase.kol.RemoveAt(res);
            DataBase.n1 = n1-1;
            if (n1 == 2)
            {
                button1.Dispose();
                label1.Text = $"{list[Lint[0]]} Выйграл(а)!!!";
            }
        }
    }
}
