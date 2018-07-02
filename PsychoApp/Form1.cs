using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace PsychoApp
{
    public partial class Form1 : Form
    {
        public string Name_psycho { get; set; }

        public string GetString(int numberString, string filePath, Encoding encoding)
        {
            IEnumerable<string> result = File.ReadLines(filePath).Skip(numberString).Take(1);

            string newString = null;

            foreach (string str in result)
            {
                newString += str;
            }

            return newString;
        }
        public Form1()
        {
            InitializeComponent();
            btn_1.Text = GetString(1, "questions.txt", Encoding.UTF8);
            btn_2.Text = GetString(2, "questions.txt", Encoding.Default);
            label1.Text = GetString(0, "questions.txt", Encoding.Default);
        }
                
        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (btn_1.Text == GetString(1, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "P";
                btn_1.Text = GetString(4, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(5, "questions.txt", Encoding.Default);
                label1.Text = GetString(3, "questions.txt", Encoding.Default);
            }
            else if (btn_1.Text == GetString(4, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "N";
                btn_1.Text = GetString(10, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(11, "questions.txt", Encoding.Default);
                label1.Text = GetString(9, "questions.txt", Encoding.Default);
            }
            else if (btn_1.Text == GetString(7, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "T";
                btn_1.Text = GetString(16, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(17, "questions.txt", Encoding.Default);
                label1.Text = GetString(15, "questions.txt", Encoding.Default);
            }
            else if (btn_1.Text == GetString(10, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = GetString(22, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(23, "questions.txt", Encoding.Default);
                label1.Text = GetString(21, "questions.txt", Encoding.Default);
            }
            else if (btn_1.Text == GetString(13, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = GetString(28, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(29, "questions.txt", Encoding.Default);
                label1.Text = GetString(27, "questions.txt", Encoding.Default);
            }
            else if (btn_1.Text == GetString(16, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = GetString(34, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(35, "questions.txt", Encoding.Default);
                label1.Text = GetString(33, "questions.txt", Encoding.Default);
            }
            else if (btn_1.Text == GetString(19, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = GetString(40, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(41, "questions.txt", Encoding.Default);
                label1.Text = GetString(39, "questions.txt", Encoding.Default);
            }
            else if (btn_1.Text == GetString(22, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "T";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == GetString(25, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "T";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == GetString(28, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "T";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == GetString(31, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "T";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == GetString(34, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "N";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == GetString(37, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "N";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == GetString(40, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "N";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == GetString(43, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "N";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
        }
        
        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (btn_2.Text == GetString(2, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "J";
                btn_1.Text = GetString(7, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(8, "questions.txt", Encoding.Default);
                label1.Text = GetString(6, "questions.txt", Encoding.Default);
            }
            else if (btn_2.Text == GetString(5, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "S";
                btn_1.Text = GetString(13, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(14, "questions.txt", Encoding.Default);
                label1.Text = GetString(12, "questions.txt", Encoding.Default);
            }
            else if (btn_2.Text == GetString(8, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "F";
                btn_1.Text = GetString(19, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(20, "questions.txt", Encoding.Default);
                label1.Text = GetString(18, "questions.txt", Encoding.Default);
            }
            else if (btn_2.Text == GetString(11, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = GetString(25, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(26, "questions.txt", Encoding.Default);
                label1.Text = GetString(24, "questions.txt", Encoding.Default);
            }
            else if (btn_2.Text == GetString(14, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = GetString(31, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(32, "questions.txt", Encoding.Default);
                label1.Text = GetString(30, "questions.txt", Encoding.Default); ;
            }
            else if (btn_2.Text == GetString(17, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = GetString(37, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(38, "questions.txt", Encoding.Default);
                label1.Text = GetString(36, "questions.txt", Encoding.Default);
            }
            else if (btn_2.Text == GetString(20, "questions.txt", Encoding.Default))
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = GetString(43, "questions.txt", Encoding.Default);
                btn_2.Text = GetString(44, "questions.txt", Encoding.Default);
                label1.Text = GetString(42, "questions.txt", Encoding.Default);
            }
            else if (btn_2.Text == GetString(23, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "F";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == GetString(26, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "F";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == GetString(29, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "F";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == GetString(32, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "F";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == GetString(35, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "S";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == GetString(38, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "S";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == GetString(41, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "S";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == GetString(44, "questions.txt", Encoding.Default))
            {
                Hide();
                Name_psycho = Name_psycho + "S";
                Regex myReg0 = new Regex("E|I");
                Regex myReg1 = new Regex("S|N");
                Regex myReg2 = new Regex("T|F");
                Regex myReg3 = new Regex("P|J");
                Match match0 = myReg0.Match(Name_psycho);
                Match match1 = myReg1.Match(Name_psycho);
                Match match2 = myReg2.Match(Name_psycho);
                Match match3 = myReg3.Match(Name_psycho);
                Name_psycho = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
                Form2 newForm = new Form2();
                newForm.Owner = this;
                newForm.ShowDialog();
                Close();
            }
            //Regex myReg0 = new Regex("E|I");
            //Regex myReg1 = new Regex("S|N");
            //Regex myReg2 = new Regex("T|F");
            //Regex myReg3 = new Regex("P|J");
            //Match match0 = myReg0.Match(Name_psycho);
            //Match match1 = myReg1.Match(Name_psycho);
            //Match match2 = myReg2.Match(Name_psycho);
            //Match match3 = myReg3.Match(Name_psycho);
            //EndResult = string.Format("{0}{1}{2}{3}", match0, match1, match2, match3);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }
    }
}