using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
//3 layers
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class ManageSalary : Form
    {
        public ManageSalary()
        {
            InitializeComponent();
        }

        private void ManageSalary_Load(object sender, EventArgs e)
        {
            dgv.DataSource = ManageSalaryDAL.Instance.ShowSalary();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbMonth.SelectedItem == null && cbYear.SelectedItem == null)
                dgv.DataSource = ManageSalaryDAL.Instance.ShowSalary();
            else if (cbMonth.SelectedItem == null)
                dgv.DataSource = ManageSalaryDAL.Instance.SearchSalaryByYear(Convert.ToInt32(cbYear.SelectedItem));
            else if (cbYear.SelectedItem == null)
                dgv.DataSource = ManageSalaryDAL.Instance.SearchSalaryByMonth(Convert.ToInt32(cbMonth.SelectedItem));
            else
                dgv.DataSource = ManageSalaryDAL.Instance.SearchSalaryByMonthYear(Convert.ToInt32(cbMonth.SelectedItem), Convert.ToInt32(cbYear.SelectedItem));
        }

        #region in file word
        private void btnSaveFileWORD_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "SalaryEmployee.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dgv, sfd.FileName);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //Add Rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }//End Row loop
                }//End Column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //Page orinatation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp += DataArray[r, c] + "\t";
                    }
                }
                //Table Format
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //Header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 9;

                //Add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //Table Style
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //Header test
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "DANH SÁCH LƯƠNG NHÂN VIÊN";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //Save the file
                oDoc.SaveAs(filename);
            }
        }
        #endregion

        #region in file PDF
        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                string EmpID = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(EmpID);
                                string MonthWork = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(MonthWork);
                                string YearWork = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(YearWork);
                                //string dateNonTime = "";
                                //for (int i = 0; ; ++i)
                                //{
                                //    if (Bdate[i] == ' ')
                                //        break;
                                //    dateNonTime += Bdate[i];
                                //}
                                string NumberofHourWork = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(NumberofHourWork);
                                string SalaryEmployee = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(SalaryEmployee);
                                //byte[] imageByte = (byte[])row.Cells[7].Value;
                                //iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                //pdfTable.AddCell(Image);
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        #endregion
    }
}
