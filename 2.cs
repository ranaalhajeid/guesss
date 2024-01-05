using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUESS_ASS
{
    public partial class Form1 : Form
    {
        private int randomNum;
        private const int min = 1;
        private const int max = 1000;
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            randomNum = random.Next(min, max + 1);
            label1.Text = "I have a number between 1 and 1000--can you guess my number?";
            label2.Text = "guess result appears here";
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Enabled = true;
            this.BackColor = DefaultBackColor;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {

                label1.Enabled = true;
                try
                {

                    int text = int.Parse(textBox1.Text);
                    if (text == min )
                    {
                        label2.Text = "Correct!";
                        this.BackColor = Color.Green;
                        textBox1.Enabled = false;
                        button1.Enabled = false;

                    }else
                    if ( text == max)
                    {
                        label2.Text = "Correct!";
                        this.BackColor = Color.Green;
                        textBox1.Enabled = false;
                        button1.Enabled = false;

                    }
                    else
                    {
                        if (text > randomNum)
                        {
                            label2.Text = "Too High ,try another number";
                            this.BackColor = Color.Blue;
                            label1.Enabled = true;


                        }

                        else
                        {
                            label2.Text = "Too low ,try another number";
                            this.BackColor = Color.Red;
                            label1.Enabled = true;



                        }
                    }
                }

                catch
                {
                    MessageBox.Show("Please Enter a valid number");

                }








            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
    }

