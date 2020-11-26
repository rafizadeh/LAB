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

namespace _01052020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillExcelData();
        }
        #region ClosedXML
        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Excel yaradilsin mi?", "Excel", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                var workbook = new XLWorkbook();

                var ws = workbook.Worksheets.Add("Sample worksheet 1");

                ws.Cell("A1").Value = "First Cell";
                ws.Column("A").Width = 30;
                ws.Row(1).Height = 20;

                ws.Column("A").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Row(1).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Top);

                ws.Range("A3:C5").Merge();

                ws.Cell("A3").Value = "Merged Cell";

                workbook.SaveAs(@"C:\Users\User\Desktop\DemoExcel.xlsx");
            }
        }
        #endregion

        #region Excel to DataGridView
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

        #endregion

    }
}
