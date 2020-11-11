using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_M15_WinFormsFramework
{
    public partial class Form1 : Form
    {
        // ctor
        public Form1()
        {
            InitializeComponent();
        }

        // felder
        int counter = 0;

        // methods
        void CountSteps(Button clickedBtn)
        {
            string btnText = clickedBtn.Text;
            if (btnText == "")
            {
                if (counter % 2 == 0)
                {
                    clickedBtn.Text = "X";
                    CheckWinner("X");
                }
                else
                {
                    clickedBtn.Text = "O";
                    CheckWinner("O");
                }
                counter++;
            }
            else
            {
                MessageBox.Show("Diese Zelle ist schon besetzt!");
            }
        }

        void CheckWinner(string x_or_o)
        {
            if ((button1.Text == x_or_o && button2.Text == x_or_o && button3.Text == x_or_o) ||
                (button4.Text == x_or_o && button5.Text == x_or_o && button6.Text == x_or_o) ||
                (button7.Text == x_or_o && button8.Text == x_or_o && button9.Text == x_or_o) ||
                (button1.Text == x_or_o && button4.Text == x_or_o && button7.Text == x_or_o) ||
                (button2.Text == x_or_o && button5.Text == x_or_o && button8.Text == x_or_o) ||
                (button3.Text == x_or_o && button6.Text == x_or_o && button9.Text == x_or_o) ||
                (button1.Text == x_or_o && button5.Text == x_or_o && button9.Text == x_or_o) ||
                (button3.Text == x_or_o && button5.Text == x_or_o && button7.Text == x_or_o))
            {
                textBox1.Text += x_or_o;
            }
            else if (counter == 9)
            {
                MessageBox.Show("Unentschieden, macht lieber Sport!");
                Close(); // Schließt das aktuelle Formular
            }



        }

        private void button_Click(object sender, EventArgs e)
        {
            // CountSteps((Button)sender); // oder
            CountSteps(sender as Button);
        }        
    }
}
