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

            btn_1.Text = v1;
            btn_2.Text = v2;
            label1.Text = lnamev1v2;

        }

        private string lnamev1v2 = "name";
        private string lnamev3v4 = "name1";
        private string lnamev5v6 = "name2";
        private string lnamev7v8 = "name3";
        private string lnamev9v10 = "name4";
        private string lnamev11v12 = "name5";
        private string lnamev13v14 = "name6";
        private string lnamev15v16 = "name7";
        private string lnamev17v18 = "name8";
        private string lnamev19v20 = "name9";
        private string lnamev21v22 = "name10";
        private string lnamev23v24 = "name11";
        private string lnamev25v26 = "name12";
        private string lnamev27v28 = "name13";
        private string lnamev29v30 = "name14";
        public string Name_psycho { get; set; }
        private string v1 = "Предпочитаете действовать по ситуации, импровизировать. Легко меняете планы. Умеете проявить гибкость и использовать шанс";
        private string v2 = "Предпочитаете действовать по намеченному плану, независимо от ситуации. Необходимость менять планы на ходу вас напрягает. Ваши мнения и решения устойчивы";
        private string v3 = "У меня развитая интуиция. Умею уступить в мелочах сейчас, чтобы дробится цели позже. Весь мир - в будущем.";
        private string v4 = "Ценю то, что имею сейчас. Нужно жить сегодня, а не откладывать на потом";
        private string v5 = "Рассудок; холодный анализ; логика; объективный подход; трезвое мышление; непредвзятость; сдержанность.";
        private string v6 = "Чувства, эмоции; сопереживание людям; неравнодушие; сердечность.";
        private string v7 = "Общителен со всеми. Легко завожу знакомства и берусь за все.";
        private string v8 = "Общителен только с близкими. Душевный покой. Переживания в себе.";
        private string v9 = "Воля; преодоление трудностей; сила и красота.";
        private string v10 = "Ощущение момента; интересы близких; эстетика.";
        private string v11 = "Правильные действия.";
        private string v12 = "Анализ и размышление.";
        private string v13 = "Очень часто везде открыто выражаю эмоции.";
        private string v14 = "Стараюсь скрывать и сдерживать эмоции.";
        private string v15 = "Вдохновляющие идеи; начинания и теории.";
        private string v16 = "Интересные, талантливые люди, общение.";
        private string v17 = "Скептическое предвидение; логика важнее.";
        private string v18 = "Эмоциональное предчувствие; поэтичность.";
        private string v19 = "Логика действий это главное, чувства вторичны.";
        private string v20 = "Понимаю отношения между людьми. Знаю как ими манипулировать.";
        private string v21 = "Практичность; умелые руки; независимость.";
        private string v22 = "Теплое общение и эмоции. Тяга к удовольствиям.";
        private string v23 = "Быстрота и эффективность.";
        private string v24 = "Добросовестность дел; надежность, качество.";
        private string v25 = "Мягкий и демократичный исследователь.";
        private string v26 = "Практик с сильной волей.";
        private string v27 = "Хорошая интуиция, сопереживание, драматизм.";
        private string v28 = "Радость, эмоции, доброе настроение.";
        private string v29 = "Объективность. Предвидя последствия, стараюсь не допускать и погашать конфликты.";
        private string v30 = "Субъективность. Исходя из своего опыта, могу пойти на конфликт чтобы защитить своих.";


        private void Btn_1_Click(object sender, EventArgs e)
        {

            if (btn_1.Text == v1)
            {
                Name_psycho = Name_psycho + "P";
                btn_1.Text = v3;
                btn_2.Text = v4;
                label1.Text = lnamev3v4;
            }
            else if (btn_1.Text == v3)
            {
                Name_psycho = Name_psycho + "N";
                btn_1.Text = v7;
                btn_2.Text = v8;
                label1.Text = lnamev7v8;
            }
            else if (btn_1.Text == v7)
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = v15;
                btn_2.Text = v16;
                label1.Text = lnamev15v16;
            }
            else if (btn_1.Text == v9)
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = v19;
                btn_2.Text = v20;
                label1.Text = lnamev19v20;
            }
            else if (btn_1.Text == v5)
            {
                Name_psycho = Name_psycho + "T";
                btn_1.Text = v11;
                btn_2.Text = v12;
                label1.Text = lnamev11v12;
            }
            else if (btn_1.Text == v11)
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = v23;
                btn_2.Text = v24;
                label1.Text = lnamev23v24;
            }
            else if (btn_1.Text == v13)
            {
                Name_psycho = Name_psycho + "E";
                btn_1.Text = v27;
                btn_2.Text = v28;
                label1.Text = lnamev27v28;
            }
            else if (btn_1.Text == v15)
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
            else if (btn_1.Text == v17)
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
            else if (btn_1.Text == v19)
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
            else if (btn_1.Text == v21)
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
            else if (btn_1.Text == v23)
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
            else if (btn_1.Text == v25)
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
            else if (btn_1.Text == v27)
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
            else if (btn_1.Text == v29)
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
            if (btn_2.Text == v2)
            {
                Name_psycho = Name_psycho + "J";
                btn_1.Text = v5;
                btn_2.Text = v6;
                label1.Text = lnamev5v6;
            }
            else if (btn_2.Text == v4)
            {
                Name_psycho = Name_psycho + "S";
                btn_1.Text = v9;
                btn_2.Text = v10;
                label1.Text = lnamev9v10;
            }
            else if (btn_2.Text == v8)
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = v17;
                btn_2.Text = v18;
                label1.Text = lnamev17v18;
            }
            else if (btn_2.Text == v10)
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = v21;
                btn_2.Text = v22;
                label1.Text = lnamev21v22;
            }
            else if (btn_2.Text == v6)
            {
                Name_psycho = Name_psycho + "F";
                btn_1.Text = v13;
                btn_2.Text = v14;
                label1.Text = lnamev13v14;
            }
            else if (btn_2.Text == v12)
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = v25;
                btn_2.Text = v26;
                label1.Text = lnamev25v26;
            }
            else if (btn_2.Text == v14)
            {
                Name_psycho = Name_psycho + "I";
                btn_1.Text = v29;
                btn_2.Text = v30;
                label1.Text = lnamev29v30;
            }
            else if (btn_2.Text == v16)
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
            else if (btn_2.Text == v18)
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
            else if (btn_2.Text == v20)
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
            else if (btn_2.Text == v22)
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
            else if (btn_2.Text == v24)
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
            else if (btn_2.Text == v26)
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
            else if (btn_2.Text == v28)
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
            else if (btn_2.Text == v30)
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