using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 민증_복습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string skID = textBox1.Text;
            if (skID.IndexOf("-") >=0)
            {
                label2.Text = "-를 빼고 입력하세요";
            }
            else if (skID.Length != 13)
            {
                label2.Text = "똑바로 입력해";
            }
            else
            {
                int[] eachNum = new int[13];
                for(int i = 0; i < skID.Length; i++)
                {
                    eachNum[i] = int.Parse(skID.Substring(i, 1));
                }

                int Y = 0;
                for (int i = 0; i < 8; i++)
                {
                    Y = Y + eachNum[i] * (i + 2);
                }

                for(int i=8; i<12; i++)
                {
                    Y = Y + eachNum[i] * (i - 6);
                }

                int Z = (11 - (Y % 11)) % 10;
                if(Z == eachNum[12])
                {
                    label2.Text = "정답";
                }
                else
                {
                    label2.Text = "땡";
                }
            }
        }
    }
}
