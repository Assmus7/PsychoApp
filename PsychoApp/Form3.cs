using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PsychoApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
            
        }
        public int NamePeople { get; set; }
        public string NumberOfGender { get; set; }
        public int CountEntreJulia { get; set; }
        public int CountEntreSergei { get; set; }
        public int CountEntreZhenya { get; set; }
        public int CountEntreDmitriy { get; set; }
        public int CountEntreAlexey { get; set; }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2
            {
                Owner = this
            };

            string passJulia = "123";
            string passSergei = "234";
            string passZhenya = "345";
            string passDmitriy = "456";
            string passAlexey = "567";

            if (textBox1.Text == passJulia && (radioButton1.Checked || radioButton2.Checked))
            {
                if (radioButton1.Checked)
                {
                    NumberOfGender = "1";
                }
                else if(radioButton2.Checked)
                {
                    NumberOfGender = "2";
                }               
                NamePeople = 1;
                CountEntreJulia += 1;
                Hide();
                //Form2 newForm2 = new Form2
                //{
                //    Owner = this
                //};
                Form1 newForm1 = new Form1
                {
                    Owner = this
                };
                newForm1.ShowDialog();
                Close();
            }            
            if (textBox1.Text == passSergei && (radioButton1.Checked || radioButton2.Checked))
            {
                if (radioButton1.Checked)
                {
                    NumberOfGender = "1";
                }
                else
                {
                    NumberOfGender = "2";
                }
                NamePeople = 2;
                CountEntreSergei += 1;
                Hide();
                Form1 newForm1 = new Form1
                {
                    Owner = this
                };
                newForm1.ShowDialog();
                Close();
            }
            if (textBox1.Text == passZhenya && (radioButton1.Checked || radioButton2.Checked))
            {
                if (radioButton1.Checked)
                {
                    NumberOfGender = "1";
                }
                else
                {
                    NumberOfGender = "2";
                }
                NamePeople = 3;
                CountEntreZhenya += 1;
                Hide();
                Form1 newForm1 = new Form1
                {
                    Owner = this
                };
                newForm1.ShowDialog();
                Close();
            }
            if (textBox1.Text == passDmitriy && (radioButton1.Checked || radioButton2.Checked))
            {
                if (radioButton1.Checked)
                {
                    NumberOfGender = "1";
                }
                else
                {
                    NumberOfGender = "2";
                }
                NamePeople = 4;
                CountEntreDmitriy += 1;
                Hide();
                Form1 newForm1 = new Form1
                {
                    Owner = this
                };
                newForm1.ShowDialog();
                Close();
            }
            if (textBox1.Text == passAlexey && (radioButton1.Checked || radioButton2.Checked))
            {                
                if (radioButton1.Checked)
                {
                    NumberOfGender = "1";
                }
                else if(radioButton2.Checked)
                {
                    NumberOfGender = "2";
                }                
                NamePeople = 5;
                CountEntreAlexey += 1;
                Hide();
                Form1 newForm1 = new Form1
                {
                    Owner = this
                };
                newForm1.ShowDialog();
                Close();
            }
            else
            {
                label2.Text = "Неправильный пароль\nили не выбран пол";
                textBox1.Clear();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
