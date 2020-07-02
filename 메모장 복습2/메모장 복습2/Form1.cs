using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 메모장_복습2
{
    public partial class Form1 : Form
    {
        bool isModified = false;
        bool hasFileName = false;
        string sFileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);

                    if (answer == DialogResult.Yes)
                    {
                        if (hasFileName == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter
                                (sFileName, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                            hasFileName = true;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                isModified = false;
                                hasFileName = true;
                            }
                        }
                    }
                }
                textBox1.Text = "";
                isModified = false;
                hasFileName = false;
                sFileName = "";
            }
            catch
            {
                MessageBox.Show("새 파일을 불러오는 도중 이상이 발생했습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장"
                        , MessageBoxButtons.YesNo);

                    if (answer == DialogResult.Yes)
                    {
                        if (hasFileName == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter
                                (sFileName, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                            hasFileName = true;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                isModified = false;
                                hasFileName = true;
                            }
                        }
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader fs = new System.IO.StreamReader
                        (sFileName, System.Text.Encoding.Default);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    isModified = false;
                    hasFileName = true;
                }
            }
            catch
            {
                MessageBox.Show("열기를 하는 도중 문제가 발생했습니다", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);

                    if (answer == DialogResult.Yes)
                    {
                        if (hasFileName == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter
                                (sFileName, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                            hasFileName = true;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                isModified = false;
                                hasFileName = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("저장을 불러오는 도중 이상이 발생했습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 모두선택ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //끝내기//
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료하시겠습니까?", "저장",
                        MessageBoxButtons.YesNoCancel);

                    if (answer == DialogResult.Yes)
                    {
                        if (hasFileName == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter
                                (sFileName, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                            hasFileName = true;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                isModified = false;
                                hasFileName = true;
                            }
                        }
                    }
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("끝내는 도중 이상이 발생했습니다", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste("");
        }

        private void 모두선택ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void 색깔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료하시겠습니까?", "저장",
                        MessageBoxButtons.YesNoCancel);

                    if (answer == DialogResult.Yes)
                    {
                        if (hasFileName == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter
                                (sFileName, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                            hasFileName = true;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                isModified = false;
                                hasFileName = true;
                            }
                        }
                    }
                    else if (answer == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("끝내는 도중 이상이 발생했습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
