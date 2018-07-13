﻿using System;
using System.Windows.Forms;

namespace PsychoApp
{
    public partial class FormPass : Form
    {
        public FormPass()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
            
        }
        public int NamePeople { get; set; }
        public int NumberOfGender { get; set; }
        public int CountEntreJulia { get; set; }
        public int CountEntreSergei { get; set; }
        public int CountEntreZhenya { get; set; }
        public int CountEntreDmitriy { get; set; }
        public int CountEntreAlexey { get; set; }



        private void button1_Click(object sender, EventArgs e)
        {
            

            string passJulia = "123";
            string passSergei = "18031990";
            string passZhenya = "345";
            string passDmitriy = "119160s";
            string passAlexey = "567";

            if (textBox1.Text == passJulia && (radioButton1.Checked || radioButton2.Checked))
            {

                if (radioButton1.Checked)
                {
                    NumberOfGender = 1;

                }
                else if(radioButton2.Checked)
                {
                    NumberOfGender = 2;
                }               
                NamePeople = 1;
                Hide();
                FormTest newForm1 = new FormTest
                {
                    Owner = this,
                    NumberOfGender = NumberOfGender,
                    NamePeople = NamePeople
                };
                newForm1.ShowDialog();
                Close();
            }            
            if (textBox1.Text == passSergei && (radioButton1.Checked || radioButton2.Checked))
            {
                if (radioButton1.Checked)
                {
                    NumberOfGender = 1;
                }
                else
                {
                    NumberOfGender = 2;
                }
                NamePeople = 2;
                Hide();
                FormTest newForm1 = new FormTest
                {
                    Owner = this,
                    NumberOfGender = NumberOfGender,
                    NamePeople = NamePeople
                };
                newForm1.ShowDialog();
                Close();
            }
            if (textBox1.Text == passZhenya && (radioButton1.Checked || radioButton2.Checked))
            {
                if (radioButton1.Checked)
                {
                    NumberOfGender = 1;
                }
                else
                {
                    NumberOfGender = 2;
                }
                NamePeople = 3;
                CountEntreZhenya += 1;
                Hide();
                FormTest newForm1 = new FormTest
                {
                    Owner = this,
                    NumberOfGender = NumberOfGender,
                    NamePeople = NamePeople
                };
                newForm1.ShowDialog();
                Close();
            }
            if (textBox1.Text == passDmitriy && (radioButton1.Checked || radioButton2.Checked))
            {
                if (radioButton1.Checked)
                {
                    NumberOfGender = 1;
                }
                else
                {
                    NumberOfGender = 2;
                }
                NamePeople = 4;
                CountEntreDmitriy += 1;
                Hide();
                FormTest newForm1 = new FormTest
                {
                    Owner = this,
                    NumberOfGender = NumberOfGender,
                    NamePeople = NamePeople
                };
                newForm1.ShowDialog();
                Close();
            }
            if (textBox1.Text == passAlexey && (radioButton1.Checked || radioButton2.Checked))
            {                
                if (radioButton1.Checked)
                {
                    NumberOfGender = 1;
                }
                else if(radioButton2.Checked)
                {
                    NumberOfGender = 2;
                }                
                NamePeople = 5;
                CountEntreAlexey += 1;
                Hide();
                FormTest newForm1 = new FormTest
                {
                    Owner = this,
                    NumberOfGender = NumberOfGender,
                    NamePeople = NamePeople
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
