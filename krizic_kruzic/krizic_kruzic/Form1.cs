using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krizic_kruzic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            
        }
        int kojiIgrac = 1;
        string stanje1 = "Na redu je: Player One";
        string stanje2 = "Na redu je: Player Two";
        int brojX = 3;
        int brojO = 3;
        
        void pobjeda()
        {
            //X iksevi
            if ((button1.Text == "X") && (button2.Text == "X") && (button3.Text == "X"))
            {
                label2.Text = "Player X je pobijedio";
                resetiranje();
            }
            if((button1.Text == "X") && (button4.Text == "X") && (button7.Text == "X"))
            {
                label2.Text = "Player X je pobijedio";
                resetiranje();
            }
            else if ((button1.Text == "X") && (button5.Text == "X") && (button9.Text == "X"))
            {
                label2.Text = "Player X je pobijedio";
                resetiranje();
            }
            else if ((button3.Text == "X") && (button6.Text == "X") && (button9.Text == "X"))
            {
                label2.Text = "Player X je pobijedio";
                resetiranje();
            }
            else if ((button7.Text == "X") && (button8.Text == "X") && (button9.Text == "X"))
            {
                label2.Text = "Player X je pobijedio";
                resetiranje();
            }
            else if((button4.Text == "X") && (button5.Text == "X") && (button6.Text == "X"))
            {
                label2.Text = "Player X je pobijedio";
                resetiranje();
            }
            else if ((button2.Text == "X") && (button5.Text == "X") && (button8.Text == "X"))
            {
                label2.Text = "Player X je pobijedio";
                resetiranje();
            }
            else if ((button7.Text == "X") && (button5.Text == "X") && (button3.Text == "X"))
            {
                label2.Text = "Player X je pobijedio";
                resetiranje();
            }
            //
            //O krugovi
            if ((button1.Text == "O") && (button2.Text == "O") && (button3.Text == "O"))
            {
                label2.Text = "Player O je pobijedio";
                resetiranje();
            }
            else if ((button1.Text == "O") && (button4.Text == "O") && (button7.Text == "O"))
            {
                label2.Text = "Player O je pobijedio";
                resetiranje();
            }
            else if ((button1.Text == "O") && (button5.Text == "O") && (button9.Text == "O"))
            {
                label2.Text = "Player O je pobijedio";
                resetiranje();
            }
            else if ((button3.Text == "O") && (button6.Text == "O") && (button9.Text == "O"))
            {
                label2.Text = "Player O je pobijedio";
                resetiranje();
            }
            else if ((button7.Text == "O") && (button8.Text == "O") && (button9.Text == "O"))
            {
                label2.Text = "Player O je pobijedio";
                resetiranje();
            }
            else if ((button4.Text == "O") && (button5.Text == "O") && (button6.Text == "O"))
            {
                label2.Text = "Player O je pobijedio";
                resetiranje();
            }
            else if ((button2.Text == "O") && (button5.Text == "O") && (button8.Text == "O"))
            {
                label2.Text = "Player O je pobijedio";
                resetiranje();
            }
            else if ((button7.Text == "O") && (button5.Text == "O") && (button3.Text == "O"))
            {
                label2.Text = "Player O je pobijedio";
                resetiranje();
            }
        }
        void resetiranje()
        {
            start.Enabled = true;
            reset.Enabled = false;
            label1.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        void red()
        {
            if (kojiIgrac == 1)
            {
                if(button1.Text=="O")
                    button1.Enabled=false;
                else
                    button1.Enabled=true;
                if (button2.Text == "O")
                    button2.Enabled = false;
                else
                    button2.Enabled = true;
                if (button3.Text == "O")
                    button3.Enabled = false;
                else
                    button3.Enabled = true;
                if (button4.Text == "O")
                    button4.Enabled = false;
                else
                    button4.Enabled = true;
                if (button5.Text == "O")
                    button5.Enabled = false;
                else
                    button5.Enabled = true;
                if (button6.Text == "O")
                    button6.Enabled = false;
                else
                    button6.Enabled = true;
                if (button7.Text == "O")
                    button7.Enabled = false;
                else
                    button7.Enabled = true;
                if (button8.Text == "O")
                    button8.Enabled = false;
                else
                    button8.Enabled = true;
                if (button9.Text == "O")
                    button9.Enabled = false;
                else
                    button9.Enabled = true;

            }
            else if (kojiIgrac == 2)
            {
                if (button1.Text == "X")
                    button1.Enabled = false;
                else
                    button1.Enabled = true;
                if (button2.Text == "X")
                    button2.Enabled = false;
                else
                    button2.Enabled = true;
                if (button3.Text == "X")
                    button3.Enabled = false;
                else
                    button3.Enabled = true;
                if (button4.Text == "X")
                    button4.Enabled = false;
                else
                    button4.Enabled = true;
                if (button5.Text == "X")
                    button5.Enabled = false;
                else
                    button5.Enabled = true;
                if (button6.Text == "X")
                    button6.Enabled = false;
                else
                    button6.Enabled = true;
                if (button7.Text == "X")
                    button7.Enabled = false;
                else
                    button7.Enabled = true;
                if (button8.Text == "X")
                    button8.Enabled = false;
                else
                    button8.Enabled = true;
                if (button9.Text == "X")
                    button9.Enabled = false;
                else
                    button9.Enabled = true;
            }
        }
        string sadrzaj = "";
        /*void imaLi()
        {
            if (button1.Text != "")
            {
                sadrzaj= button1.Text;
            }
            
        }*/
        //string nista = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (kojiIgrac == 1)
            {
                button1.Text = "X";
                label1.Text = stanje2;
                button1.ForeColor = Color.Blue;
                kojiIgrac=2;
            }
            else if(kojiIgrac == 2)
            {
                button1.Text = "O";
                label1.Text = stanje1;
                button1.ForeColor = Color.Blue;
                kojiIgrac =1;
            }
            if (button1.Text.Length==1)
            {
                sadrzaj = button1.Text;

                button5.Text = sadrzaj;
                button1.Text = "";
                /*Console.WriteLine("yes");
                Console.WriteLine(button1.Text);
                Console.WriteLine("yes");*/
                //button1.Text.Remove(0);
            }
            pobjeda();
            red();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resetiranje();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "Na redu je: Player One";
            reset.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            start.Enabled = false;
            
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kojiIgrac == 1)
            {
                button2.Text = "X";
                label1.Text = stanje2;
                button2.ForeColor = Color.Blue;
                kojiIgrac = 2;
            }
            else if (kojiIgrac == 2)
            {
                button2.Text = "O";
                label1.Text = stanje1;
                button2.ForeColor = Color.Blue;
                kojiIgrac = 1;
            }
            pobjeda();
            red();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kojiIgrac == 1)
            {
                button3.Text = "X";
                label1.Text = stanje2;
                button3.ForeColor = Color.Blue;
                kojiIgrac = 2;
            }
            else if (kojiIgrac == 2)
            {
                button3.Text = "O";
                label1.Text = stanje1;
                button3.ForeColor = Color.Blue;
                kojiIgrac = 1;
            }
            pobjeda();
            red();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kojiIgrac == 1)
            {
                button4.Text = "X";
                label1.Text = stanje2;
                button4.ForeColor = Color.Blue;
                kojiIgrac = 2;
            }
            else if (kojiIgrac == 2)
            {
                button4.Text = "O";
                label1.Text = stanje1;
                button4.ForeColor = Color.Blue;
                kojiIgrac = 1;
            }
            pobjeda();
            red();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kojiIgrac == 1)
            {
                button5.Text = "X";
                label1.Text = stanje2;
                button5.ForeColor = Color.Blue;
                kojiIgrac = 2;
            }
            else if (kojiIgrac == 2)
            {
                button5.Text = "O";
                label1.Text = stanje1;
                button5.ForeColor = Color.Blue;
                kojiIgrac = 1;
            }
            pobjeda();
            red();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kojiIgrac == 1)
            {
                button6.Text = "X";
                label1.Text = stanje2;
                button6.ForeColor = Color.Blue;
                kojiIgrac = 2;
            }
            else if (kojiIgrac == 2)
            {
                button6.Text = "O";
                label1.Text = stanje1;
                button6.ForeColor = Color.Blue;
                kojiIgrac = 1;
            }
            pobjeda();
            red();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (kojiIgrac == 1)
            {
                button7.Text = "X";
                label1.Text = stanje2;
                button7.ForeColor = Color.Blue;
                kojiIgrac = 2;
            }
            else if (kojiIgrac == 2)
            {
                button7.Text = "O";
                label1.Text = stanje1;
                button7.ForeColor = Color.Blue;
                kojiIgrac = 1;
            }
            pobjeda();
            red();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (kojiIgrac == 1)
            {
                button8.Text = "X";
                label1.Text = stanje2;
                button8.ForeColor = Color.Blue;
                kojiIgrac = 2;
            }
            else if (kojiIgrac == 2)
            {
                button8.Text = "O";
                label1.Text = stanje1;
                button8.ForeColor = Color.Blue;
                kojiIgrac = 1;
            }
            pobjeda();
            red();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (kojiIgrac == 1)
            {
                button9.Text = "X";
                label1.Text = stanje2;
                button9.ForeColor = Color.Blue;
                kojiIgrac = 2;
            }
            else if (kojiIgrac == 2)
            {
                button9.Text = "O";
                label1.Text = stanje1;
                button9.ForeColor = Color.Blue;
                kojiIgrac = 1;
            }
            pobjeda();
            red();
        }
        
    }
}
