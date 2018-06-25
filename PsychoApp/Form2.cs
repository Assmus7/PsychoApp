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

        public string Name_form2 { get; set; }
        public Form2()
        {
            InitializeComponent();
            //label1.Text = Name_form2;
            //Form1 main = this.Owner as Form1;
            //if (main != null)
            //{
            //    string s = main.Name_psycho;
            //    main.Name_psycho = Name_form2;
            //}

            //label1.Text = Name_form2;
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
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Form1 g = (Form1)this.Owner;
            label1.Text = g.Name_psycho;
        }
    }
}
