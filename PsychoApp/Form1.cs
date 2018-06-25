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

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (btn_1.Text == "вопрос №1")
            {
                Name_psycho = Name_psycho + "P";
                btn_1.Text = "вопрос №3";
                btn_2.Text = "вопрос №4";
                label1.Text = Name_psycho;
            }
            else if (btn_1.Text == "вопрос №3")
            {
                Name_psycho = Name_psycho + "N";
                btn_1.Text = "вопрос №7";
                btn_2.Text = "вопрос №8";
                label1.Text = Name_psycho;
            }
            else if (btn_1.Text == "вопрос №7")
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = "вопрос №15";
                btn_2.Text = "вопрос №16";
                label1.Text = Name_psycho;
            }
            else if (btn_1.Text == "вопрос №9")
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = "вопрос №19";
                btn_2.Text = "вопрос №20";
                label1.Text = Name_psycho;
            }
            else if (btn_1.Text == "вопрос №5")
            {
                Name_psycho = Name_psycho + "T";
                btn_1.Text = "вопрос №11";
                btn_2.Text = "вопрос №12";
                label1.Text = Name_psycho;
            }
            else if (btn_1.Text == "вопрос №11")
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = "вопрос №23";
                btn_2.Text = "вопрос №24";
                label1.Text = Name_psycho;
            }
            else if (btn_1.Text == "вопрос №13")
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = "вопрос №27";
                btn_2.Text = "вопрос №28";
                label1.Text = Name_psycho;
            }
            else if (btn_1.Text == "вопрос №15")
            {
                Name_psycho = Name_psycho + "T";
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_1.Text == "вопрос №17")
            {
                Name_psycho = Name_psycho + "T";
                //MessageBox.Show(Name_psycho, "Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_1.Text == "вопрос №19")
            {
                Name_psycho = Name_psycho + "T";
                //MessageBox.Show(Name_psycho, "Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_1.Text == "вопрос №21")
            {
                Name_psycho = Name_psycho + "T";
                //MessageBox.Show(Name_psycho, "Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_1.Text == "вопрос №23")
            {
                Name_psycho = Name_psycho + "N";
                //MessageBox.Show(Name_psycho, "Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_1.Text == "вопрос №25")
            {
                Name_psycho = Name_psycho + "N";
                //MessageBox.Show(Name_psycho, "Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_1.Text == "вопрос №27")
            {
                Name_psycho = Name_psycho + "N";
                //MessageBox.Show(Name_psycho, "Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_1.Text == "вопрос №29")
            {
                Name_psycho = Name_psycho + "N";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            //string question4 = "вопрос №4";
            if (btn_2.Text == "вопрос №2")
            {
                Name_psycho = Name_psycho + "J";
                btn_1.Text = "вопрос №5";
                btn_2.Text = "вопрос №6";
                label1.Text = Name_psycho;
            }
            else if (btn_2.Text == "вопрос №4")
            {
                Name_psycho = Name_psycho + "S";
                btn_1.Text = "вопрос №9";
                btn_2.Text = "вопрос №10";
                label1.Text = Name_psycho;
            }
            else if (btn_2.Text == "вопрос №8")
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = "вопрос №17";
                btn_2.Text = "вопрос №18";
                label1.Text = Name_psycho;
            }
            else if (btn_2.Text == "вопрос №10")
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = "вопрос №21";
                btn_2.Text = "вопрос №22";
                label1.Text = Name_psycho;
            }
            else if (btn_2.Text == "вопрос №6")
            {
                Name_psycho = Name_psycho + "F";
                btn_1.Text = "вопрос №13";
                btn_2.Text = "вопрос №14";
                label1.Text = Name_psycho;
            }
            else if (btn_2.Text == "вопрос №12")
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = "вопрос №25";
                btn_2.Text = "вопрос №26";
                label1.Text = Name_psycho;
            }
            else if (btn_2.Text == "вопрос №14")
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = "вопрос №29";
                btn_2.Text = "вопрос №30";
                label1.Text = Name_psycho;
            }
            else if (btn_2.Text == "вопрос №16")
            {
                Name_psycho = Name_psycho + "F";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_2.Text == "вопрос №18")
            {
                Name_psycho = Name_psycho + "F";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_2.Text == "вопрос №20")
            {
                Name_psycho = Name_psycho + "F";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_2.Text == "вопрос №22")
            {
                Name_psycho = Name_psycho + "F";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_2.Text == "вопрос №24")
            {
                Name_psycho = Name_psycho + "S";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_2.Text == "вопрос №26")
            {
                Name_psycho = Name_psycho + "S";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_2.Text == "вопрос №28")
            {
                Name_psycho = Name_psycho + "S";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else if (btn_2.Text == "вопрос №30")
            {
                Name_psycho = Name_psycho + "S";
                //MessageBox.Show(Name_psycho,"Результат");
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



//btn_2.Text = "вопрос №4
