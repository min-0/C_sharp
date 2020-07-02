using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 민증_유효성_검사
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
            if (skID.IndexOf("-") >= 0)
            {
                label2.Text = "-를 빼고 입력하세요";
            }
            else if (skID.Length != 13)
            {
                label2.Text = "정확히 입력하세요";
            }
            else
            {
                int[] eachNUM = new int[13];
                for (int i = 0; i < skID.Length; i++)
                {
                    eachNUM[i] = int.Parse(skID.Substring(i, 1));
                }

                int Y = 0;
                for (int i = 0; i < 8; i++)
                {
                    Y = Y + eachNUM[i] * (i + 2);
                }
                for (int i = 8; i < 12; i++)
                {
                    Y = Y + eachNUM[i] * (i - 6);
                }

                int Z = (11 - (Y % 11)) % 10;
                if (Z == eachNUM[12])
                {
                    label2.Text = "올바른 주민번호 입니다";
                }
                else
                {
                    label2.Text = "올바르지 않는 주민번호 입니다";
                }
            }
        }
    }
}
