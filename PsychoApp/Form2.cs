using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PsychoApp
{
    public partial class Form2 : Form
    {

        //Form1 g = (Form1)Owner;
        //Regex myReg0 = new Regex("E|I");
        //Regex myReg1 = new Regex("S|N");
        //Regex myReg2 = new Regex("T|F");
        //Regex myReg3 = new Regex("P|J");
        //Match match0 = myReg0.Match(g.Name_psycho);
        //Match match1 = myReg1.Match(g.Name_psycho);
        //Match match2 = myReg2.Match(g.Name_psycho);
        //Match match3 = myReg3.Match(g.Name_psycho);
        //string YeahBoy = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);

        public Form2()
        {
            InitializeComponent();
            //g.Name_psycho


            //string a = ((Form1)Owner).Name_psycho;
            //Regex myReg0 = new Regex("E|I");
            //Regex myReg1 = new Regex("S|N");
            //Regex myReg2 = new Regex("T|F");
            //Regex myReg3 = new Regex("P|J");
            //Match match0 = myReg0.Match(a);
            //Match match1 = myReg1.Match(a);
            //Match match2 = myReg2.Match(a);
            //Match match3 = myReg3.Match(a);
            //string YeahBoy = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
            //textBox1.Text = YeahBoy;


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
