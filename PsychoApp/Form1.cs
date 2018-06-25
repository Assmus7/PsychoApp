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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Name_psycho { get; set; }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (btn_1.Text == "вопрос №1")
            {
                Name_psycho = Name_psycho + "P";
                btn_1.Text = "вопрос №3";
                btn_2.Text = "вопрос №4";
            }
            else if (btn_1.Text == "вопрос №3")
            {
                Name_psycho = Name_psycho + "N";
                btn_1.Text = "вопрос №7";
                btn_2.Text = "вопрос №8";
            }
            else if (btn_1.Text == "вопрос №7")
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = "вопрос №15";
                btn_2.Text = "вопрос №16";
            }
            else if (btn_1.Text == "вопрос №9")
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = "вопрос №19";
                btn_2.Text = "вопрос №20";
            }
            else if (btn_1.Text == "вопрос №5")
            {
                Name_psycho = Name_psycho + "T";
                btn_1.Text = "вопрос №11";
                btn_2.Text = "вопрос №12";
            }
            else if (btn_1.Text == "вопрос №11")
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = "вопрос №23";
                btn_2.Text = "вопрос №24";
            }
            else if (btn_1.Text == "вопрос №13")
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = "вопрос №27";
                btn_2.Text = "вопрос №28";
            }
            else if (btn_1.Text == "вопрос №15")
            {
                Hide();
                Name_psycho = Name_psycho + "T";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == "вопрос №17")
            {
                Hide();
                Name_psycho = Name_psycho + "T";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == "вопрос №19")
            {
                Hide();
                Name_psycho = Name_psycho + "T";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == "вопрос №21")
            {
                Hide();
                Name_psycho = Name_psycho + "T";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == "вопрос №23")
            {
                Hide();
                Name_psycho = Name_psycho + "N";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == "вопрос №25")
            {
                Hide();
                Name_psycho = Name_psycho + "N";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == "вопрос №27")
            {
                Hide();
                Name_psycho = Name_psycho + "N";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_1.Text == "вопрос №29")
            {
                Hide();
                Name_psycho = Name_psycho + "N";
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
            if (btn_2.Text == "вопрос №2")
            {
                Name_psycho = Name_psycho + "J";
                btn_1.Text = "вопрос №5";
                btn_2.Text = "вопрос №6";
            }
            else if (btn_2.Text == "вопрос №4")
            {
                Name_psycho = Name_psycho + "S";
                btn_1.Text = "вопрос №9";
                btn_2.Text = "вопрос №10";
            }
            else if (btn_2.Text == "вопрос №8")
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = "вопрос №17";
                btn_2.Text = "вопрос №18";
            }
            else if (btn_2.Text == "вопрос №10")
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = "вопрос №21";
                btn_2.Text = "вопрос №22";
            }
            else if (btn_2.Text == "вопрос №6")
            {
                Name_psycho = Name_psycho + "F";
                btn_1.Text = "вопрос №13";
                btn_2.Text = "вопрос №14";
            }
            else if (btn_2.Text == "вопрос №12")
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = "вопрос №25";
                btn_2.Text = "вопрос №26";
            }
            else if (btn_2.Text == "вопрос №14")
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = "вопрос №29";
                btn_2.Text = "вопрос №30";
            }
            else if (btn_2.Text == "вопрос №16")
            {
                Hide();
                Name_psycho = Name_psycho + "F";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == "вопрос №18")
            {
                Hide();
                Name_psycho = Name_psycho + "F";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == "вопрос №20")
            {
                Hide();
                Name_psycho = Name_psycho + "F";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == "вопрос №22")
            {
                Hide();
                Name_psycho = Name_psycho + "F";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == "вопрос №24")
            {
                Hide();
                Name_psycho = Name_psycho + "S";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == "вопрос №26")
            {
                Hide();
                Name_psycho = Name_psycho + "S";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == "вопрос №28")
            {
                Hide();
                Name_psycho = Name_psycho + "S";
                Form2 newForm = new Form2
                {
                    Owner = this
                };
                newForm.ShowDialog();
                Close();
            }
            else if (btn_2.Text == "вопрос №30")
            {
                Hide();
                Name_psycho = Name_psycho + "S";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Owner = this;
                newForm.ShowDialog();
                Close();
                //Name_psycho = newForm.Name_form2;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }
    }
}



//btn_2.Text = "вопрос №4
