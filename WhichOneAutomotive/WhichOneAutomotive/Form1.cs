using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhichOneAutomotive
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weightCar1 = 0.0;
            double weightCar2 = 0.0;
            int hpCar1 = 0;
            int hpCar2 = 0;

            double car1;
            double car2;

            try
            { 
            weightCar1 = double.Parse(textBox1.Text);
            weightCar2 = double.Parse(textBox6.Text);

            hpCar1 = int.Parse(textBox2.Text);
            hpCar2 = int.Parse(textBox5.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("      Please enter numerical values!");
            }
            if (textBox1.Text == "" || textBox2.Text == ""  || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("     All boxes must be filled with data!");
            }
            else
            {
                car1 = hpCar1 / weightCar1;
                car2 = hpCar2 / weightCar2;

                textBox8.Text = Math.Round(car1, 3).ToString();
                textBox9.Text = Math.Round(car2, 3).ToString();

                if(car1 > car2)
                {
                    textBox7.Text = "Car One";
                }
                else
                {
                    textBox7.Text = "Car Two";
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("             WhichOneAutomotive v1.0" + "\n" + "         Created by Daniel Galabov 2018");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
