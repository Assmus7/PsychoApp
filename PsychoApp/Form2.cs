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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using OfficeOpenXml;


namespace PsychoApp
{
    public partial class Form2 : Form
    {
        public int NamePeople1 { get; set; }
        public int NamePeople2 { get; set; }
        public int NamePeople3 { get; set; }
        public int NamePeople4 { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Btn2_1_Click(object sender, EventArgs e)
        {
            //Form3 g = (Form3)Owner;
            NamePeople1 = 1123;
            NamePeople2 = 4334;
            NamePeople3 = 5656;
            NamePeople4 = 878;
            
          
            if (MessageBox.Show("Вы уверены?", "Выйти?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                
                using (var excel = new ExcelPackage())
                {
                    var ws = excel.Workbook.Worksheets.Add("MyWorksheet");

                    ws.Cells["A1"].Value = NamePeople1;
                    ws.Cells["B1"].Value = NamePeople2/*g.NumberOfGender*/;
                    ws.Cells["C1"].Value = NamePeople3;
                    ws.Cells["D1"].Value = textBox1.Text;

                    excel.SaveAs(new FileInfo("myExcel.xlsx"));
                }

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
