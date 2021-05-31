using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//3 layers
using DAL;
//Word
using Word = Microsoft.Office.Interop.Word;

namespace Care_Management_and_Private_Parking
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            dgvEmp.DataSource = EmployeeDAL.Instance.getAllEmp();
            dgvEmp.RowTemplate.Height = 80;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvEmp.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //Custom cái độ rộng của các cột của datagridview
            dgvEmp.Columns[0].Width = 50;
            dgvEmp.Columns[1].Width = 150;
            dgvEmp.Columns[2].Width = 60;
            dgvEmp.Columns[3].Width = 80;
            dgvEmp.Columns[4].Width = 95;
            dgvEmp.Columns[5].Width = 119;
            dgvEmp.Columns[6].Width = 140;
            dgvEmp.Columns[7].Width = 80;
            dgvEmp.Columns[8].Width = 100;
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Please Insert Name!!!", "Search By Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reload();
            }
            else
            {
                DataTable tab = EmployeeDAL.Instance.searchByName(tbSearch.Text);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find Name Like: " + tbSearch.Text, "Search By Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reload();
                }
                else
                {
                    dgvEmp.DataSource = tab;
                    tbSearch.Text = "";
                }
            }            
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                MessageBox.Show("Please Insert ID!!!", "Search By ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reload();
            }
            else
            {
                DataTable tab = EmployeeDAL.Instance.getEmpByID(tbSearch.Text);

                if (tab.Rows.Count == 0)
                {
                    MessageBox.Show("Can't Find ID: " + tbSearch.Text, "Search By ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reload();
                }
                else
                {
                    dgvEmp.DataSource = tab;
                    tbSearch.Text = "";
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string id = dgvEmp.CurrentRow.Cells[0].Value.ToString();
            ManageEmployeeForm frm = new ManageEmployeeForm(id);
            frm.ShowDialog();
            reload();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm frm = new ManageEmployeeForm();
            frm.ShowDialog();
            reload();
        }
        void reload()
        {
            dgvEmp.DataSource = EmployeeDAL.Instance.getAllEmp();
            tbSearch.Text = null;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }


        System.Data.DataTable tableMAIN = new System.Data.DataTable();

        #region in file word
        private void loaddgvMAIN()
        {
            tableMAIN = EmployeeDAL.Instance.getAllEmp();
            tableMAIN.Columns["ID"].ColumnName = "Mã Nhân Viên";
            tableMAIN.Columns["FullName"].ColumnName = "Họ Tên";
            tableMAIN.Columns["Gender"].ColumnName = "Giới";
            tableMAIN.Columns["Birthday"].ColumnName = "Ngày Sinh";
            tableMAIN.Columns["PhoneNumber"].ColumnName = "Điện Thoại";
            tableMAIN.Columns["IdentityNumber"].ColumnName = "CMND";
            tableMAIN.Columns["Email"].ColumnName = "Email";
            tableMAIN.Columns["Job"].ColumnName = "Chức Vụ";
            tableMAIN.Columns["Appearance"].ColumnName = "Hình Ảnh";
            dgv2.DataSource = tableMAIN;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "EmployeeList.docx";

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
            dgvEmp.DataSource = EmployeeDAL.Instance.getAllEmp();
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

                    headerRange1.Fields.Add(headerRange1, Word.WdFieldType.wdFieldPage);

                    headerRange1.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    headerRange1.Font.ColorIndex = Word.WdColorIndex.wdBlack;
                    headerRange1.Font.Size = 12;
                    headerRange1.Font.Name = "Times new roman";
                    headerRange1.Font.Bold = 1;
                    headerRange1.Text = "       ĐƠN VỊ: CÔNG TY..................";
                    headerRange1.InsertParagraphAfter();

                    oCollapseEnd = Word.WdCollapseDirection.wdCollapseEnd;
                    headerRange1.Collapse(ref oCollapseEnd);
                    headerRange1.Text = "                PHÒNG NHÂN SỰ";
                    headerRange1.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                }
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
                paraHead.Range.Font.Size = 20;
                paraHead.Range.Font.Name = "Times new roman";
                paraHead.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHead.Range.Text = "DANH SÁCH NHÂN VIÊN";
                paraHead.Range.InsertParagraphAfter();

                moveCursor(ref oDoc);
                Microsoft.Office.Interop.Word.Paragraph para1 = oDoc.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                para1.Range.Font.Size = 14;
                para1.Range.Font.Name = "Times new roman";
                para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.Text = "Bộ phận: Nhân viên của công ty.......................";
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
                        if (c == 2)
                        {
                            string Gender = DGV.Rows[r].Cells[c].Value.ToString();
                            if (Gender == "Male")
                                DataArray[r, c] = "Nam";
                            else
                                DataArray[r, c] = "Nữ";
                        }
                        else if (c == 3)
                        {
                            string Bdate = DGV.Rows[r].Cells[c].Value.ToString();
                            string dateNonTime = "";
                            for (int i = 0; ; ++i)
                            {
                                if (Bdate[i] == ' ')
                                    break;
                                dateNonTime += Bdate[i];
                            }
                            DataArray[r, c] = dateNonTime;
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
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 10;

                //Add header row manually - (thêm hàng tựa đề của bảng)
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //Table Style - (Kiểu bảng)
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 3");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //Save Image
                for (r = 0; r <= RowCount-1; r++)
                {
                    byte[] imgbyte = (byte[])DGV.Rows[r].Cells[8].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 3, 9).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 3, 9).Range.InsertParagraph();
                }
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
                para3.Range.Text = "\n\n        Người lập";
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
    }
}
