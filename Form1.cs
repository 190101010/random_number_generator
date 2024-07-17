using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_number_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number = 0, guess_number = 0, point = 1000;

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random r = new Random();
            number = r.Next(100);
            label8.Text = number.ToString();
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess;
            guess_number++;
            if (guess_number <= 10)
            {
                guess = int.Parse(textBox1.Text);
                label6.Text = guess_number.ToString();
                if (number < guess)
                {
                    label5.Text = "decrease your guess!";
                    point = point - 100;
                    label7.Text = point.ToString(); 

                }
                else if (number > guess)
                {
                    label5.Text = "increase your guess!";
                    point = point - 100;
                    label7.Text = point.ToString();

                }
                else
                {
                    label5.Text = "congrats!" + label6.Text + " is the number of you've tried!";
                }
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("there is no right to guess! The game will close!");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
