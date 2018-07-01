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

namespace PsychoApp
{



    public partial class Form1 : Form
    {
        //private Microsoft.Office.Interop.Excel.Application excelapp;


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



            //label1.Text = lnamev1v2;

            //var Q1 = 0;
            //string nameQ1= "1";

            //StreamReader reader = new StreamReader("questions.txt", Encoding.Default);

            //if (Q1 == 0)
            //{
            //    nameQ1 = (reader.ReadLine());
            //    Q1++;
            //}
            //label1.Text = nameQ1;
        }


        public string Name_psycho { get; set; }

        //private string lnamev1v2 = "name";
        //private string lnamev3v4 = "name1";
        //private string lnamev5v6 = "name2";
        //private string lnamev7v8 = "name3";
        //private string lnamev9v10 = "name4";
        //private string lnamev11v12 = "name5";
        //private string lnamev13v14 = "name6";
        //private string lnamev15v16 = "name7";
        //private string lnamev17v18 = "name8";
        //private string lnamev19v20 = "name9";
        //private string lnamev21v22 = "name10";
        //private string lnamev23v24 = "name11";
        //private string lnamev25v26 = "name12";
        //private string lnamev27v28 = "name13";
        //private string lnamev29v30 = "name14";
        //private string v1 = "Предпочитаете действовать по ситуации, импровизировать. Легко меняете планы. Умеете проявить гибкость и использовать шанс";
        //private string v2 = "Предпочитаете действовать по намеченному плану, независимо от ситуации. Необходимость менять планы на ходу вас напрягает. Ваши мнения и решения устойчивы";
        //private string v3 = "У меня развитая интуиция. Умею уступить в мелочах сейчас, чтобы дробится цели позже. Весь мир - в будущем.";
        //private string v4 = "Ценю то, что имею сейчас. Нужно жить сегодня, а не откладывать на потом";
        //private string v5 = "Рассудок; холодный анализ; логика; объективный подход; трезвое мышление; непредвзятость; сдержанность.";
        //private string v6 = "Чувства, эмоции; сопереживание людям; неравнодушие; сердечность.";
        //private string v7 = "Общителен со всеми. Легко завожу знакомства и берусь за все.";
        //private string v8 = "Общителен только с близкими. Душевный покой. Переживания в себе.";
        //private string v9 = "Воля; преодоление трудностей; сила и красота.";
        //private string v10 = "Ощущение момента; интересы близких; эстетика.";
        //private string v11 = "Правильные действия.";
        //private string v12 = "Анализ и размышление.";
        //private string v13 = "Очень часто везде открыто выражаю эмоции.";
        //private string v14 = "Стараюсь скрывать и сдерживать эмоции.";
        //private string v15 = "Вдохновляющие идеи; начинания и теории.";
        //private string v16 = "Интересные, талантливые люди, общение.";
        //private string v17 = "Скептическое предвидение; логика важнее.";
        //private string v18 = "Эмоциональное предчувствие; поэтичность.";
        //private string v19 = "Логика действий это главное, чувства вторичны.";
        //private string v20 = "Понимаю отношения между людьми. Знаю как ими манипулировать.";
        //private string v21 = "Практичность; умелые руки; независимость.";
        //private string v22 = "Теплое общение и эмоции. Тяга к удовольствиям.";
        //private string v23 = "Быстрота и эффективность.";
        //private string v24 = "Добросовестность дел; надежность, качество.";
        //private string v25 = "Мягкий и демократичный исследователь.";
        //private string v26 = "Практик с сильной волей.";
        //private string v27 = "Хорошая интуиция, сопереживание, драматизм.";
        //private string v28 = "Радость, эмоции, доброе настроение.";
        //private string v29 = "Объективность. Предвидя последствия, стараюсь не допускать и погашать конфликты.";
        //private string v30 = "Субъективность. Исходя из своего опыта, могу пойти на конфликт чтобы защитить своих.";


        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (btn_1.Text == GetString(1, "questions.txt", Encoding.Default))
            {
                //var Q2 = 3;
                //string nameQ2 = "1";
                //StreamReader reader = new StreamReader("questions.txt", Encoding.Default);

                //if (Q2 < 4)
                //{
                //    nameQ2 = reader.ReadLine();
                //    Q2++;
                //}
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