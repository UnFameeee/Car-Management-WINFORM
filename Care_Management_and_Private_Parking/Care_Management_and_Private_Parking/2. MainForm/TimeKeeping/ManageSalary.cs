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
using System.IO;
//Word
using Word = Microsoft.Office.Interop.Word;
//PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
//Excel
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
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

        #region Properties
        System.Data.DataTable tableMAIN = new System.Data.DataTable();
        #endregion

        private void ManageSalary_Load(object sender, EventArgs e)
        {
            dgv.DataSource = ManageSalaryDAL.Instance.ShowSalary();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
        }

        private void loaddgvMAIN()
        {
            tableMAIN = ManageSalaryDAL.Instance.ShowSalary();
            tableMAIN.Columns["EmpID"].ColumnName = "Mã Nhân Viên";
            tableMAIN.Columns["MonthWork"].ColumnName = "Tháng";
            tableMAIN.Columns["YearWork"].ColumnName = "Năm";
            tableMAIN.Columns["NumberofHourWork"].ColumnName = "Số giờ làm";
            tableMAIN.Columns["SalaryEmployee"].ColumnName = "Lương";
            dgv2.DataSource = tableMAIN;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbMonth.SelectedIndex != -1 && cbYear.SelectedIndex != -1)
            {
                if (cbMonth.SelectedIndex != -1)
                    dgv.DataSource = ManageSalaryDAL.Instance.SearchSalaryByYear(Convert.ToInt32(cbYear.SelectedItem));
                else if (cbYear.SelectedIndex != -1)
                    dgv.DataSource = ManageSalaryDAL.Instance.SearchSalaryByMonth(Convert.ToInt32(cbMonth.SelectedItem));
                else
                    dgv.DataSource = ManageSalaryDAL.Instance.SearchSalaryByMonthYear(Convert.ToInt32(cbMonth.SelectedItem), Convert.ToInt32(cbYear.SelectedItem));
            }
            else
            {
                MessageBox.Show("Please choose the value!!!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ManageSalaryDAL.Instance.ShowSalary();
            cbMonth.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
        }

        #region in file WORD
        private void btnSaveFileWORD_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "SalaryEmployee.docx";

            loaddgvMAIN();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (Export_Data_To_Word(dgv2, sfd.FileName))
                {
                    MessageBox.Show("Successful!!!", "Save to file word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessful!!!", "Save to file word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dgv.DataSource = ManageSalaryDAL.Instance.ShowSalary();
        }

        #region Di chuyển con trỏ xuống cuối cùng
        private void moveCursor(ref Word.Document oDoc)
        { 
            object StartPos = 0;
            object Endpos = 1;
            Microsoft.Office.Interop.Word.Range rng = oDoc.Range(ref StartPos, ref Endpos);
            object NewEndPos = rng.StoryLength - 1;
            rng = oDoc.Range(ref NewEndPos, ref NewEndPos);
            rng.Select();
        }
        #endregion

        public bool Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                #region Variable
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //
                object missing = System.Reflection.Missing.Value;
                object oCollapseEnd = Word.WdCollapseDirection.wdCollapseEnd;
                #endregion

                #region Auto Pagenumber
                oDoc.ActiveWindow.View.Type = Word.WdViewType.wdPrintView;
                object nullobject = System.Reflection.Missing.Value;
                oDoc.ActiveWindow.ActivePane.View.SeekView = Word.WdSeekView.wdSeekPrimaryFooter;
                oDoc.ActiveWindow.Selection.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                oDoc.ActiveWindow.Selection.Font.Name = "Arial";
                oDoc.ActiveWindow.Selection.Font.Bold = 1;
                oDoc.ActiveWindow.Selection.Font.Size = 14;
                oDoc.ActiveWindow.Selection.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                Object CurrentPage = Word.WdFieldType.wdFieldPage;
                oDoc.ActiveWindow.Selection.Fields.Add(oDoc.ActiveWindow.Selection.Range, ref CurrentPage, ref nullobject, ref nullobject);
                #endregion

                #region Header
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange1 = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    //headerRange1.Fields.Add(headerRange1, Word.WdFieldType.wdFieldPage);
                    //headerRange1.Text = "DANH SÁCH LƯƠNG NHÂN VIÊN";
                    //headerRange1.Font.Size = 16;
                    //headerRange1.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    headerRange1.Fields.Add(headerRange1, Word.WdFieldType.wdFieldPage);

                    headerRange1.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    headerRange1.Font.ColorIndex = Word.WdColorIndex.wdBlack;
                    headerRange1.Font.Size = 12;
                    headerRange1.Font.Name = "Times new roman";
                    headerRange1.Font.Bold = 1;
                    headerRange1.Text = "Đơn vị: Công ty....";
                    headerRange1.InsertParagraphAfter();

                    //object oCollapseEnd = Word.WdCollapseDirection.wdCollapseEnd;
                    //headerRange1.Collapse(ref oCollapseEnd);
                    //headerRange1.Text = "DANH SÁCH";
                    //headerRange1.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                #endregion

                #region Footer
                //foreach (Microsoft.Office.Interop.Word.Section wordSection in oDoc.Sections)
                //{
                //    //Get the footer range and add the footer details.
                //    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGreen;
                //    footerRange.Font.Name = "Times new roman";
                //    footerRange.Font.Bold = 1;
                //    footerRange.Font.Size = 10;
                //    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //    footerRange.Text = "Danh sách tiền lương";
                //}
                #endregion

                #region Set cấu hình font chữ của toàn word
                //oDoc.Content.SetRange(0, 0);
                oDoc.Content.Font.Size = 12;
                oDoc.Content.Font.Bold = 0;
                oDoc.Content.Font.Name = "Times new roman";
                oDoc.Content.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oDoc.Content.InsertParagraphAfter();
                #endregion

                #region Cài đặt chữ phần trên
                moveCursor(ref oDoc);
                Microsoft.Office.Interop.Word.Paragraph paraHead = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeadingHead = "Heading 1";
                paraHead.Range.set_Style(ref styleHeadingHead);
                paraHead.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                paraHead.Range.Font.Bold = 1;
                paraHead.Range.Font.Size = 16;
                paraHead.Range.Font.Name = "Times new roman";
                paraHead.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHead.Range.Text = "DANH SÁCH TIỀN LƯƠNG NHÂN VIÊN";
                paraHead.Range.InsertParagraphAfter();

                moveCursor(ref oDoc);
                Microsoft.Office.Interop.Word.Paragraph para1 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                para1.Range.Font.Size = 10;
                para1.Range.Font.Name = "Times new roman";
                para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.Text = "Bộ phận:.................................";
                para1.Range.InsertParagraphAfter();
                #endregion

                moveCursor(ref oDoc);

                #region Thêm dữ liệu từ dgv vào word
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //Add Rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        if(c == 3 || c == 4)
                        {
                            DGV.Rows[r].Cells[c].Value = Convert.ToInt32(DGV.Rows[r].Cells[c].Value);
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                        }
                        else
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }//End Row loop
                }//End Column loop

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
                #endregion

                #region Table-Format  
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
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Arial";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //Add header row manually - (thêm hàng tựa đề của bảng)
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //Table Style - (Kiểu bảng)
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 6");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                #endregion

                #region Phần nội dung phía dưới Table (Đã add bên trên)
                moveCursor(ref oDoc);
                Microsoft.Office.Interop.Word.Paragraph para2 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                para2.Range.Font.Name = "Times new roman";
                para2.Range.Font.Size = 12;
                para2.Range.Text = "\nNgày....Tháng....Năm....";
                para2.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para2.Range.InsertParagraphAfter();

                moveCursor(ref oDoc);
                Microsoft.Office.Interop.Word.Paragraph para3 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading3 = "Heading 3";
                para3.Range.set_Style(ref styleHeading3);
                para3.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                para3.Range.Font.Name = "Times new roman";
                para3.Range.Font.Size = 12;
                para3.Range.Text = "\n\n        Người lập                       Quản lý trực tiếp               Giám đốc bộ phận                Giám đốc nhân sự                Giám đốc điều hành";
                para3.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para3.Range.InsertParagraphAfter();
                #endregion

                moveCursor(ref oDoc);

                //Save the file
                oDoc.SaveAs(filename);
                return true;
            }
            return false;
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

        #region in file EXCEL
        private void btnSaveFileExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Export To Excel";
            sfd.Filter = "To Excel (Xlsx)|*.xlsx";
            sfd.FileName = "SalaryEmployee.xlsx";

            loaddgvMAIN();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (Export_DataGridView_To_Excel(dgv2, sfd.FileName))
                {
                    MessageBox.Show("Successful!!!", "Save to file excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessful!!!", "Save to file excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool Export_DataGridView_To_Excel(DataGridView DGV, string filename)
        {
            try
            {
                string[] Alphabit = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                              "N", "O","P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                string Range_Letter = Alphabit[DGV.Columns.Count];
                string Range_Row = (DGV.Rows.Count + 1).ToString();

                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

                Excel.Application oApp;
                Excel.Worksheet oSheet;
                Excel.Workbook oBook;

                oApp = new Excel.Application();
                oApp.Application.Visible = true;
                oBook = oApp.Workbooks.Add();
                oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);

                for (int x = 0; x < DGV.Columns.Count; x++)
                {
                    // creating Columns :
                    oSheet.Cells[1, x + 2] = DGV.Columns[x].HeaderText;
                }


                for (int i = 0; i < DGV.Columns.Count; i++)
                {
                    for (int j = 0; j < DGV.Rows.Count; j++)
                    {
                        // creating rows :
                        if (i == 3 || i == 4)
                        {
                            DGV.Rows[j].Cells[i].Value = Convert.ToInt32(DGV.Rows[j].Cells[i].Value);
                            oSheet.Cells[j + 2, i + 2] = DGV.Rows[j].Cells[i].Value;
                        }
                        else
                            oSheet.Cells[j + 2, i + 2] = DGV.Rows[j].Cells[i].Value;
                    }
                }

                //Add some formatting
                //row1
                Range rng1 = oSheet.get_Range("B1", Range_Letter + "1");
                rng1.Font.Size = 14;
                rng1.Font.Bold = true;
                rng1.Cells.Borders.LineStyle = XlLineStyle.xlDouble;
                rng1.Cells.Borders.Color = System.Drawing.Color.Green;
                rng1.Font.Color = System.Drawing.Color.Yellow;
                rng1.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                rng1.Interior.Color = System.Drawing.Color.Green;

                //row2
                Range rng2 = oSheet.get_Range("B4", Range_Letter + Range_Row);
                rng2.WrapText = false;
                rng2.Font.Size = 12;
                rng2.Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
                rng2.Cells.Borders.Color = System.Drawing.Color.DarkGreen;
                rng2.VerticalAlignment = XlVAlign.xlVAlignCenter;
                rng2.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                rng2.Interior.Color = System.Drawing.Color.LightGreen;
                rng2.EntireColumn.AutoFit();
                rng2.EntireRow.AutoFit();

                //Add a header row
                oSheet.get_Range("B1", Range_Letter + "2").EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Missing.Value);
                oSheet.Cells[1, 3] = "DANH SÁCH LƯƠNG NHÂN VIÊN";
                Range rng3 = oSheet.get_Range("B1", Range_Letter + "2");
                rng3.Merge(Missing.Value);
                rng3.Font.Size = 16;
                rng3.Font.Color = System.Drawing.Color.White;
                rng3.Font.Bold = true;
                rng3.VerticalAlignment = XlVAlign.xlVAlignCenter;
                rng3.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                rng3.Interior.Color = System.Drawing.Color.DarkGreen;


                oBook.SaveAs(filename);
                oBook.Close();
                oApp.Quit();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}