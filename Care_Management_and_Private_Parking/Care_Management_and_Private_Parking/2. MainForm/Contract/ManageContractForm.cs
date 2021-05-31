using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
//3 layers
using DAL;

namespace Care_Management_and_Private_Parking
{
    public partial class ManageContractForm : Form
    {
        public ManageContractForm()
        {
            InitializeComponent();
        }

        private void ManageContractForm_Load(object sender, EventArgs e)
        {
            //combobox
            fillCB();
            //dgv
            dgv.DataSource = ContractDAL.Instance.ShowContract();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
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

        #region combobox
        private void fillCB()
        {
            //emp
            cbEmpID.DataSource = ContractDAL.Instance.ShowEmpID();               //Lấy thông tin của role
            cbEmpID.DisplayMember = "EmpID";
            cbEmpID.ValueMember = "EmpID";
            cbEmpID.SelectedIndex = -1;
            //Customer
            cbCusID.DataSource = ContractDAL.Instance.ShowCusID();               //Lấy thông tin của role
            cbCusID.DisplayMember = "CusID";
            cbCusID.ValueMember = "CusID";
            cbCusID.SelectedIndex = -1;
            //veh
            cbVehID.DataSource = ContractDAL.Instance.ShowVehID();               //Lấy thông tin của role
            cbVehID.DisplayMember = "VehID";
            cbVehID.ValueMember = "VehID";
            cbVehID.SelectedIndex = -1;
        }
        #endregion

        #region Các nút
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ContractDAL.Instance.ShowContract();
            fillCB();
            cbEmpID.SelectedIndex = -1;
            cbVehID.SelectedIndex = -1;
            cbCusID.SelectedIndex = -1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbCusID.SelectedItem == null && cbEmpID.SelectedItem == null && cbVehID.SelectedItem == null)
                MessageBox.Show("Please fill the value!!!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

            else if (cbCusID.SelectedItem == null && cbVehID.SelectedItem == null)
                dgv.DataSource = ContractDAL.Instance.ShowEmpIDContract((cbEmpID.SelectedValue).ToString());
            else if (cbCusID.SelectedItem == null && cbEmpID.SelectedItem == null)
                dgv.DataSource = ContractDAL.Instance.ShowVehIDContract((cbVehID.SelectedValue).ToString());
            else if (cbVehID.SelectedItem == null && cbEmpID.SelectedItem == null)
                dgv.DataSource = ContractDAL.Instance.ShowCusIDContract((cbCusID.SelectedValue).ToString());

            else if (cbCusID.SelectedItem == null)
                dgv.DataSource = ContractDAL.Instance.ShowVehIDEmpIDContract((cbVehID.SelectedValue).ToString(), (cbEmpID.SelectedValue).ToString());
            else if (cbEmpID.SelectedItem == null)
                dgv.DataSource = ContractDAL.Instance.ShowCusIDVehIDContract((cbCusID.SelectedValue).ToString(), (cbVehID.SelectedValue).ToString());
            else if (cbVehID.SelectedItem == null)
                dgv.DataSource = ContractDAL.Instance.ShowEmpIDCusIDContract((cbEmpID.SelectedValue).ToString(), (cbCusID.SelectedValue).ToString());

            else
                dgv.DataSource = ContractDAL.Instance.ShowAllFindContract((cbEmpID.SelectedValue).ToString(), (cbVehID.SelectedValue).ToString(), (cbCusID.SelectedValue).ToString());
        }

        #endregion
    }
}
