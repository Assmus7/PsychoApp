using System;
using System.Windows.Forms;
using System.IO;

namespace PsychoApp
{
    public partial class FormResult : Form
    {
        public int NumberOfGender { get; internal set; }
        public int NamePeople { get; internal set; }
        public string Name_psycho { get; internal set; }

        public FormResult()
        {
            InitializeComponent();
        }

        private void Btn2_1_Click(object sender, EventArgs e)
        {
            
          
            if (MessageBox.Show("Вы уверены?", "Выйти?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int i = 1;
                string path = "MyTest.txt";
                using (StreamReader sr = new StreamReader("MyTest.txt"))
                {
                    String line;
                    
                    while ((line = sr.ReadLine()) != null) 
                    {
                        i++; 
                    }
                }

                using (StreamWriter sw = File.AppendText(path))
                {
                    
                    sw.WriteLine(NamePeople + "." + i + "." + NumberOfGender + "." + Name_psycho);
                }

                System.Windows.Forms.Application.Exit();
            }
            else
            {
            }
        }
        
        private void Btn2_2_Click(object sender, EventArgs e)
        {
            Hide();
            FormTest form = new FormTest();
            form.ShowDialog();
            Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            //label1.Text = Name_psycho;
            textBox1.Text = Name_psycho;

        }
    }
}
