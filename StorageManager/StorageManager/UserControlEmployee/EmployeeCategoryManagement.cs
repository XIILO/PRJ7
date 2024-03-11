using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.UserControler
{
    public partial class EmployeeCategoryManagement : UserControl
    {
        public EmployeeCategoryManagement()
        {
            InitializeComponent();
        }

        DatabaseConnector Connector = new DatabaseConnector();
        DataTable table = new DataTable();
        //Add
        private void EmployeeAddCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmployeeCategoryName.Text))
            {
                SqlParameter[] parameters1 = {
                    new SqlParameter("@CategoryName", EmployeeCategoryName.Text)
                };
                SqlParameter[] parameters2 = {
                    new SqlParameter("@CategoryName", EmployeeCategoryName.Text)
                };
                if (!Connector.VerifyProcedure("CategoryVerify", parameters1))
                {
                    Connector.ActionProc("CategoryAdd", parameters2);
                    ViewLoading("CategoryView");
                }
                else
                {
                    MessageBox.Show("Invalid Category Because It's Existing");
                }
            }
            else
            {
                MessageBox.Show("No Blank");
            }
        }
        //Main Loading
        private void EmployeeCategoryManagement_Load(object sender, EventArgs e)
        {
            ViewLoading("CategoryView");
        }


        //Loading
        public void ViewLoading(string Procname)
        {
            table = Connector.ActionProc(Procname, null);
            EmployeCategoryDatagridview.DataSource = table;
            EmployeCategoryDatagridview.AllowUserToAddRows = false;

            if (EmployeCategoryDatagridview.Columns["DeleteButtonColumn"] == null)
            {
                DataGridViewButtonColumn EditColumn = new DataGridViewButtonColumn();
                EditColumn.Name = "EditColumn";
                EmployeCategoryDatagridview.Columns.Insert(2, EditColumn);
                EditColumn.Width = 70;
                EditColumn.Text = "Edit";
                EditColumn.UseColumnTextForButtonValue = true;

                /*DataGridViewButtonColumn Altercolumn = new DataGridViewButtonColumn();
                Altercolumn.Name = "AlterColumn";
                EmployeCategoryDatagridview.Columns.Insert(3, Altercolumn);
                Altercolumn.Width = 70;
                Altercolumn.Text = "Alter";
                Altercolumn.UseColumnTextForButtonValue = true;*/

                DataGridViewButtonColumn Deletebutomcolumn = new DataGridViewButtonColumn();
                Deletebutomcolumn.Name = "DeleteButtonColumn";
                EmployeCategoryDatagridview.Columns.Insert(3, Deletebutomcolumn);
                Deletebutomcolumn.Width = 70;
                Deletebutomcolumn.Text = "Delete";
                Deletebutomcolumn.UseColumnTextForButtonValue = true;

            }

        }

        //DataGridView Data Delete

        private void EmployeCategoryDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && EmployeCategoryDatagridview.Columns[e.ColumnIndex].Name == "DeleteButtonColumn")
            {
                string CategoryID = EmployeCategoryDatagridview.Rows[e.RowIndex].Cells["CategoryID"].Value?.ToString();
                if (!string.IsNullOrEmpty(CategoryID))
                {
                    DialogResult firstConfirmation = MessageBox.Show("Bạn có chắc muốn xóa danh mục này? Hành động này sẽ xóa tất cả các mục trong danh mục này và không thể hoàn tác.", "Xác nhận xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (firstConfirmation == DialogResult.Yes)
                    {
                        DialogResult secondConfirmation = MessageBox.Show("Bạn thực sự muốn tiếp tục? Hành động này sẽ xóa vĩnh viễn và không thể khôi phục. Kèm theo đó là các Items đang xuất hiện bên trong sẽ bị xóa vĩnh viến và không thể khôi phục", "Xác nhận xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (secondConfirmation == DialogResult.Yes)
                        {
                            SqlParameter[] parameters = {
                                new SqlParameter("@CategoryID", CategoryID)
                            };
                            Connector.ActionProc("CategoryDelete", parameters);
                            ViewLoading("CategoryView");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa!");
                    return;
                }
            }
            if (e.RowIndex >= 0 && EmployeCategoryDatagridview.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                int selectedRowIndex = EmployeCategoryDatagridview.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = EmployeCategoryDatagridview.Rows[selectedRowIndex];
                EmployeeCategoryID.Text = selectedRow.Cells["CategoryID"].Value?.ToString();
                EmployeeCategoryName.Text = selectedRow.Cells["CategoryName"].Value?.ToString();
            }
        }




        //Find
        private void EmployeeFindBut_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(FindAndAddCategoriesBut.Text))
            {
                MessageBox.Show("Write the name of the category to find");
                return;
            }
            else
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@SearchTerm", FindAndAddCategoriesBut.Text)
                };
                table = Connector.ActionProc("CategorySerch", parameters);
                EmployeCategoryDatagridview.DataSource = table;

            }

        }


        //Reload
        private void EmployeeReloadBut_Click(object sender, EventArgs e)
        {
            ViewLoading("CategoryView");
        }

        private void EmployeCategoryDatagridview_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.ColumnIndex == EmployeCategoryDatagridview.Columns["CategoryID"].Index)
            {
                string B = EmployeCategoryDatagridview.Rows[e.RowIndex].Cells["CategoryID"].Value?.ToString();
                MessageBox.Show($"Giá trị B sau khi chỉnh sửa: {B}");

            }*/
        }

        private void EmployeeUpdateCategory_Click(object sender, EventArgs e)
        {
            
        }
    }
}
