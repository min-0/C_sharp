using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 평균_최대_최소
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] iAarry01 = new int[10];
            System.Random ranNum = new System.Random();
            for (int i = 0; i < iAarry01.Length; i++)
            {
                iAarry01[i] = ranNum.Next(1, 101);
            }
            label1.Text = "";

            for(int i = 0; i < iAarry01.Length; i++)
            {
                label1.Text += "iAarry01[" + i + "] = " + iAarry01[i] + "     ";
                if ((i + 1) % 2 == 0)
                    label1.Text += "\n\n";
            }
            int maxNum = iAarry01[0];
            int minNum = iAarry01[0];
            int Sum = 0;
            double Average = 0;
            for(int i = 0; i < iAarry01.Length; i++ )
            {
                if (maxNum < iAarry01[i])
                    maxNum = iAarry01[i];
                if (minNum > iAarry01[i])
                    minNum = iAarry01[i];

                Sum += iAarry01[i];
            }
            Average = Sum / iAarry01.Length;
            label1.Text += "\n\n배열의 최대는 " + maxNum +
                "\n\n배열의 최소는 " + minNum +
                "\n\n" + iAarry01.Length + "개 원소 배열의 평균은 " + Average;
        }
    }
}
