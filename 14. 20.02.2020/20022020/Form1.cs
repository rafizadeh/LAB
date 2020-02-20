using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20022020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InsertCommaBetween(string s)
            {
                return string.Join(",", s.ToCharArray());
            }
            string str = textBox1.Text;
            MessageBox.Show(InsertCommaBetween(str));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int digit = 0;
            int letter = 0;
            int symbol = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    digit++;
                }
                else if(Char.IsLetter(s[i]))
                {
                    letter++;
                }
                else if(s[i].ToString() != " ")
                {
                    symbol++;
                }
            }
            MessageBox.Show("Letter: " + letter + " Digit: " + digit + " Symbol: " + symbol);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            MessageBox.Show(s.Replace(" ", ""));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int charCounter = 0;
            int wordCounter = 0;
            string s = textBox1.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    wordCounter++;
                }
                else
                {
                    charCounter++;
                }
            }

            MessageBox.Show("Soz sayi:" + wordCounter + " Herf sayi:" + charCounter);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] s = textBox1.Text.Split(' ');
            string res = "";
            string str = s.ToString();

            foreach (var item in s)
            {
                for (int j = item.Length - 1; j >= 0; j--)
                {
                    res += item[j];
                }
                if(res.Length < str.Length)
                {
                    res += " ";
                }
            }
            MessageBox.Show(res.ToUpper());
        }
    }
}
