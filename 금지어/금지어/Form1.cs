using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 금지어
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sUnacceptableWords = new string[4];
            sUnacceptableWords[0] = "바보";
            sUnacceptableWords[1] = "메롱";
            sUnacceptableWords[2] = "님아";
            sUnacceptableWords[3] = "8억";

            string sAllArticle = textBox1.Text;
            foreach (string sUAW in sUnacceptableWords)
            {
                string FirstStr = "";
                string SecondStr = "";
                int FindPosition = sAllArticle.IndexOf(sUAW);
                while (FindPosition >= 0)
                {
                    FirstStr = sAllArticle.Substring(0, FindPosition);
                    SecondStr = sAllArticle.Substring(FindPosition + sUAW.Length);
                    sAllArticle = FirstStr + "금지어" + SecondStr;
                    FindPosition = sAllArticle.IndexOf(sUAW);
                }
            }
            textBox1.Text = sAllArticle;
        }
    }
}
