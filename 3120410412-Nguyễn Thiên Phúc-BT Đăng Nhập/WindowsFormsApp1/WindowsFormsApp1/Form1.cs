using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Hãy điền ID và mật khẩu !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                    if (checkBox1.Checked == true)
                    {
                        Properties.Settings.Default.ID = textBox1.Text;
                        Properties.Settings.Default.Pass = textBox2.Text;
                        Properties.Settings.Default.Save();
                    }
                    MessageBox.Show("Đăng nhập", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Properties.Settings.Default.State = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.State = true;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ID != string.Empty)
            {
                bool flag = Properties.Settings.Default.State;
                if (flag == true)
                {
                    checkBox1.Checked = true;   //Hiển thị tick trên checbox
                    textBox1.Text = Properties.Settings.Default.ID;
                    textBox2.Text = Properties.Settings.Default.Pass;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }
    }
}
