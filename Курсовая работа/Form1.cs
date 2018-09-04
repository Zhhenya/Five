using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Курсовая_работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IOF.Read_Weight();
            Neuron.Weight_(IOF.Get_Weight());
            bool f = true ;
            Neuron.Training(f, this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        public void Set_Label(String st)
        {
            Color[] clr = new Color[10] { Color.Red, Color.Green, Color.GreenYellow, Color.Aqua, Color.Plum, Color.Snow, Color.AliceBlue, Color.Beige, Color.Teal, Color.DarkOrange}; //Массив цветов
            int n;
            Random rnd = new Random();
            n = rnd.Next(0, 9);
            label2.Font = new Font(FontFamily.GenericSerif, 12, FontStyle.Bold);
            label2.ForeColor = clr[n];
            label2.Text = st;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
                Image.Init(image);
                Occasion.Init_OccasionOprnFileDialog(true);
                Neuron.Init(Image.GetArrayPixel(), Image.Get_Widht(), Image.Get_Height());
                Neuron.Init_Weight(Image.Get_Height() * Image.Get_Widht());
                IOF.Read_Weight();
                Neuron.Weight_(IOF.Get_Weight());
                Neuron.Init_bias(7);
            }
        }
        //False
        private void button2_Click(object sender, EventArgs e)
        {
            bool f = true;
            Neuron.Init_bias(7);
            Neuron.Training(f, this);
        }
        //True
        private void button1_Click(object sender, EventArgs e)
        {
            IOF.Save_Weight();
            label2.Text = "Запись";

        }
        //Проверить
        private void button4_Click(object sender, EventArgs e)
        {
            IOF.Read_Weight();
            Neuron.Weight_(IOF.Get_Weight());
            Neuron.Count_weight(this);
        }
        //5
        private void button5_Click(object sender, EventArgs e)
        {
            bool f = true;
            Neuron.Init_bias(7);
            Neuron.Training(f, this);
        }
        //не 5
        private void button6_Click(object sender, EventArgs e)
        {
            bool f = false;
            Neuron.Init_bias(7);
            Neuron.Training(f, this);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция находится на стадии разработки");
        }


        private void режимОбученияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Occasion.Get_occasionOpenFileDialog())
            {
                button1.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button4.Visible = false;
            }
            else
                MessageBox.Show("Сначала откройте картинку");
                  
        }

        private void режимТестированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Occasion.Get_occasionOpenFileDialog())
            {
                button1.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button4.Visible = true;
            }
            else
                MessageBox.Show("Сначала откройте картинку");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F = new Курсовая_работа.Form2();
            F.ShowDialog();
        }
    }
}
