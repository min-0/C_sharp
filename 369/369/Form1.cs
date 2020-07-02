using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _369
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int sum = 0;
                string sOutPut = "";

                if (iData01 < iData02)
                {
                    if (iData01 > 1 && iData02 <= 9)
                    {
                        if (iData02 > 2 && iData02 < 10)
                        {
                            sOutPut = "구구단 " + iData01 + "단 부터 " + iData02 + "단 까지 입니다!\n\n";
                            for (int k = iData01; k <= iData02; k++)
                            {
                                for (int i = 2; i <= 9; i++)
                                {
                                    sum = i * k;
                                    sOutPut += k + " X " + i + " = " + sum + "\n";
                                }
                                sOutPut += "\n";
                            }
                            label3.Text = sOutPut;
                        }
                        else
                        {
                            label3.Text = "2와 9 사이의 수를 입력하세요!";
                        }
                    }
                    else
                    {
                        label3.Text = "2와 9 사이의 수를 입력하세요!";
                    }
                }
                else
                {
                    label3.Text ="시작 단수가 마지막 단수보다 작거나 같아야 합니다!";
                }
            }
            catch(Exception ee)
            {
                label3.Text = ee.Message;
            }
        }
    }
}
