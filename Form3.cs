using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form3 : Form
    {
        private string parol = "12345";
        private int role=0;
        public Form3()
        {
            InitializeComponent();
            comboBox1.SelectedItem="user";
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            AcceptButton = button1;
            CancelButton = button2;
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("user");
            textBox1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "admin")
            {
                textBox1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                MD5 md5 = MD5.Create();
                Byte[] logandpar = md5.ComputeHash(Encoding.UTF8.GetBytes("admin" + textBox1.Text));
                Byte[] rightpar = md5.ComputeHash(Encoding.UTF8.GetBytes("admin" + parol));
                if (Convert.ToString(logandpar) == Convert.ToString(rightpar))
                {
                    role=1;
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
        }
        public int Getrole()
        {
            return (role);
        }
    }
}
