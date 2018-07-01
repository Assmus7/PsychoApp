using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychoApp
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        
        private void Btn2_1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Выйти?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }
        
        private void Btn2_2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Form1 g = (Form1)Owner;
            label1.Text = g.Name_psycho;
            textBox1.Text = g.Name_psycho;
        }
    }
}
