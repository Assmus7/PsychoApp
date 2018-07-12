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
using Microsoft.Office.Interop.Excel;

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




                ////    Excel.Application exApp = new Excel.Application();
                ////    exApp.Visible = false;
                ////    exApp.Workbooks.Add();
                ////    Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
                ////    workSheet.Cells[1, 1] = "№";
                ////    workSheet.Cells[1, 2] = "Имя студента";
                ////    workSheet.Cells[1, 3] = "Группа";
                ////    workSheet.Cells[1, 4] = "Средний балл";
                ////    int rowExcel = 2;
                ////    for (int i = 0; i < NGrants; i++)
                ////{
                ////    workSheet.Cells[rowExcel, "A"] = NamePeople1/*.Rows[i].Cells[0].Value*/;
                ////        workSheet.Cells[rowExcel, "B"] = NamePeople2/*.Rows[i].Cells[1].Value*/;
                ////        workSheet.Cells[rowExcel, "C"] = NamePeople3/*.Rows[i].Cells[2].Value*/;
                ////        workSheet.Cells[rowExcel, "D"] = NamePeople4/*.Rows[i].Cells[4].Value*/;
                ////        ++rowExcel;
                ////}




                ////    FileInfo excelFile = new FileInfo("myExcel.xlsx");
                ////exApp.GetSaveAsFilename(excelFile);
                ////workSheet.SaveAs("MyExcel.xls");

                //////////////////////////using (ExcelPackage p = new ExcelPackage(FileInfo))
                ////////////////////////using (var excel = new ExcelPackage())
                ////////////////////////{
                ////////////////////////    var ws = excel.Workbook.Worksheets.Add("MyResult");



                ////////////////////////    ws.Cells["A1"].Value = NamePeople1;
                ////////////////////////    ws.Cells["B1"].Value = NamePeople2/*g.NumberOfGender*/;
                ////////////////////////    var _ws = excel.Workbook.Worksheets[1];
                ////////////////////////    int iRows = _ws.Dimension.Rows;             //считает кол-во строк
                ////////////////////////    int iColumns = _ws.Dimension.Columns;       //считает кол-во столбцов
                ////////////////////////    ws.Cells["E1"].Value = iRows;
                ////////////////////////    ws.Cells["F1"].Value = iColumns;

                ////////////////////////    //ws.Cells["D11"].Value = rowCnt;

                ////////////////////////    excel.SaveAs(new FileInfo("myExcel2.xlsx"));
                ////////////////////////    //FileInfo excelFile = new FileInfo("myExcel.xlsx");
                ////////////////////////    //excel.SaveAs(excelFile);
                ////////////////////////}

                ////создаём новое Excel приложение
                //Excel.Application exApp = new Excel.Application();
                ////добавляем рабочую книгу
                //exApp.Workbooks.Add();
                ////обращаемся к активному листу (по умолчанию он первый)
                //Excel.Worksheet workSheet = (Excel.Worksheet)exApp.ActiveSheet;
                ////добавляем строку в Excel файл
                //workSheet.Cells[4, 1] = "4.1";
                ////Вместо чисел можно использовать буквенное обозначение.
                //workSheet.Cells[1, "B"] = "1.B";
                //workSheet.Cells[2, 4] = "1.3";
                ////Сохранение в Excel файл;
                //workSheet.SaveAs("MyExcel". );


                


                //FormTest g = (FormTest)Owner;
                //Form3 m = (Form3)Owner;

                int i = 1;
                string path = "MyTest.txt";
                using (StreamReader sr = new StreamReader("MyTest.txt"))
                {
                    String line;
                    
                    while ((line = sr.ReadLine()) != null) 
                    {
                        i++;
                        
                    }
                    //if ((line = sr.ReadLine()) == null)
                    //{
                    //    i = 1;
                    //}
                    //i++;
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
            FormTest g = (FormTest)Owner;
            label1.Text = g.Name_psycho;
            textBox1.Text = g.Name_psycho;

        }
    }
}
