using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ExcelLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillExcelData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Yaradim?","Excel Creation",MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                var workbook = new XLWorkbook();

                var ws = workbook.Worksheets.Add("Example Sheet");

                ws.Cell("A1").Value = "It's getting tough";
                ws.Cell("B5").Value = "testing";
                ws.Column("A").Width = 30;
                ws.Column("B").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                ws.Column("B").Style.Font.SetFontSize(20);
                //ws.Column("B").Style.Fill.SetBackgroundColor(XLColor.Alizarin);
                ws.Row(5).Height = 30;
                ws.Row(5).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Range("B3:C4").Merge();

                ws.Cell("B3").Value = "Merged cell";
                ws.Cell("B3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Top);

                workbook.SaveAs(@"C:\Users\User\Desktop\empty.xlsx");
            }
        }

        private void FillExcelData()
        {
            var workbook = new XLWorkbook(@"C:\Users\User\Desktop\SampleData.xlsx");
            var ws = workbook.Worksheet(2);

            foreach (var row in ws.RowsUsed().Skip(1))
            {
                DateTime dt = DateTime.Parse(row.Cell(1).Value.ToString());
                dgvExcel.Rows.Add(dt.ToString("dd.MM.yyyy"),
                                    row.Cell(2).Value.ToString(),
                                    row.Cell(3).Value.ToString(),
                                    row.Cell(4).Value.ToString(),
                                    row.Cell(5).Value.ToString(),
                                    row.Cell(6).Value.ToString(),
                                    row.Cell(7).Value.ToString());
            }
        }
    }
}
