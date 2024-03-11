using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.UserControlManager
{
    public partial class ManagerEmployeeManagement : UserControl
    {
        public ManagerEmployeeManagement()
        {
            InitializeComponent();
        }
        DatabaseConnector connector = new DatabaseConnector();
        DataTable table = new DataTable();

        private void ManagerEmployeeManagement_Load(object sender, EventArgs e)
        {
            ViewLoading("EmployeeDetailView");

        }

        private void ManagerAddEmployee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ManagerEmployeeIDCombobox.Text) &&
                !string.IsNullOrEmpty(ManagerEmployeeName.Text) &&
                !string.IsNullOrEmpty(ManagerEmployeeSalaryUnit.Text) &&
                !string.IsNullOrEmpty(ManagerEmployeeSalary.Text) &&
                !string.IsNullOrEmpty(ManagerEmployeeEmail.Text) &&
                !string.IsNullOrEmpty(ManagerEmployeePhoneContact.Text) &&
                !string.IsNullOrEmpty(ManagerFirstDateOfWork.Text))
            {
                // Kiểm tra định dạng của Salary Unit
                if (float.TryParse(ManagerEmployeeSalaryUnit.Text, out float salaryUnit) &&
                    // Kiểm tra định dạng của Salary
                    float.TryParse(ManagerEmployeeSalary.Text, out float salary) &&
                    // Kiểm tra định dạng của Phone Contact
                    float.TryParse(ManagerEmployeePhoneContact.Text, out float phoneContact) &&
                    // Kiểm tra định dạng của First Date of Work
                    DateTime.TryParse(ManagerFirstDateOfWork.Text, out DateTime firstDateOfWork))
                {
                    // Thực hiện stored procedure để thêm nhân viên
                    SqlParameter[] insertParameters = {
                        new SqlParameter("@EmployeeID", ManagerEmployeeIDCombobox.Text),
                        new SqlParameter("@EmployeeName", ManagerEmployeeName.Text),
                        new SqlParameter("@EmployeeSalaryUnit", salaryUnit),
                        new SqlParameter("@EmployeeSalary", salary),
                        new SqlParameter("@EmployeeEmail", ManagerEmployeeEmail.Text),
                        new SqlParameter("@EmployeePhoneContact", phoneContact),
                        new SqlParameter("@FirstDateOfWork", firstDateOfWork)
                // Thêm các tham số khác tương ứng với cột trong bảng
                    };
                    connector.ActionProc("EmployeeDetailsAdd", insertParameters);
                    ViewLoading("EmployeeDetailView");
                }
                else
                {
                    MessageBox.Show("Invalid format. Please enter valid numeric values for Salary Unit, Salary, Phone Contact, and valid date format for First Date of Work.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }
        }


        // Main Loading
        public void ViewLoading(string Procname)
        {
            LoadDataToDataGridView(Procname);
            AddButtonColumn("EditColumn", "Edit", 7);
            AddButtonColumn("DeleteButtonColumn", "Delete", 8);
        }
        //Loading datagridview
        private void LoadDataToDataGridView(string Procname)
        {
            table = connector.ActionProc(Procname, null);
            ManagerEmployeeManagementDatagridview.DataSource = table;
            ManagerEmployeeManagementDatagridview.AllowUserToAddRows = false;
        }
        //AddColums
        private void AddButtonColumn(string columnName, string buttonText, int columnIndex)
        {
            if (ManagerEmployeeManagementDatagridview.Columns[columnName] == null && columnIndex <= ManagerEmployeeManagementDatagridview.Columns.Count)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = columnName;
                ManagerEmployeeManagementDatagridview.Columns.Insert(columnIndex, buttonColumn);
                buttonColumn.Width = 70;
                buttonColumn.Text = buttonText;
                buttonColumn.UseColumnTextForButtonValue = true;
            }
        }

        private void ManagerEmployeeManagementDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string employeeID = ManagerEmployeeManagementDatagridview.Rows[e.RowIndex].Cells["EmployeeID"].Value?.ToString();
            string employeeName = ManagerEmployeeManagementDatagridview.Rows[e.RowIndex].Cells["EmployeeName"].Value?.ToString();

            if (ManagerEmployeeManagementDatagridview.Columns[e.ColumnIndex].Name == "DeleteButtonColumn")
            {
                DialogResult firstConfirmation = MessageBox.Show("Bạn có chắc muốn xóa danh mục này? Hành động này sẽ xóa tất cả các mục trong danh mục này và không thể hoàn tác.", "Xác nhận xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (firstConfirmation == DialogResult.Yes)
                {
                    DialogResult secondConfirmation = MessageBox.Show("Bạn thực sự muốn tiếp tục? Hành động này sẽ xóa vĩnh viễn và không thể khôi phục. Kèm theo đó là các Items đang xuất hiện bên trong sẽ bị xóa vĩnh viến và không thể khôi phục", "Xác nhận xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (secondConfirmation == DialogResult.Yes)
                    {
                        SqlParameter[] parameters = {
                            new SqlParameter("@EmployeeID", employeeID),
                            new SqlParameter("@EmployeeName", employeeName)
                };

                        connector.ActionProc("EmployeeDetailsDelete", parameters);
                        ViewLoading("EmployeeDetailView");
                    }
                }
            }
            else if (ManagerEmployeeManagementDatagridview.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                ManagerEmployeeIDCombobox.Text = employeeID;
                ManagerEmployeeName.Text = employeeName;
                ManagerEmployeeSalaryUnit.Text = ManagerEmployeeManagementDatagridview.Rows[e.RowIndex].Cells["EmployeeSalaryUnit"].Value?.ToString();
                ManagerEmployeeSalary.Text = ManagerEmployeeManagementDatagridview.Rows[e.RowIndex].Cells["EmployeeSalary"].Value?.ToString();
                ManagerEmployeeEmail.Text = ManagerEmployeeManagementDatagridview.Rows[e.RowIndex].Cells["EmployeeEmail"].Value?.ToString();
                ManagerEmployeePhoneContact.Text = ManagerEmployeeManagementDatagridview.Rows[e.RowIndex].Cells["EmployeePhoneContact"].Value?.ToString();
                ManagerFirstDateOfWork.Text = ManagerEmployeeManagementDatagridview.Rows[e.RowIndex].Cells["FirstDateOfWork"].Value?.ToString();
            }

        }


        private void ManagerEmployeeGridviewReload_Click(object sender, EventArgs e)
        {
            ViewLoading("EmployeeDetailView");
        }

        private void ManagerEmployeeUpdatebut_Click(object sender, EventArgs e)
        {
            if (float.TryParse(ManagerEmployeeSalaryUnit.Text, out float salaryUnit) &&
                    // Kiểm tra định dạng của Salary
                    float.TryParse(ManagerEmployeeSalary.Text, out float salary) &&
                    // Kiểm tra định dạng của Phone Contact
                    float.TryParse(ManagerEmployeePhoneContact.Text, out float phoneContact) &&
                    // Kiểm tra định dạng của First Date of Work
                    DateTime.TryParse(ManagerFirstDateOfWork.Text, out DateTime firstDateOfWork) &&
                    // Kiểm tra định dạng của last Date of Work
                    DateTime.TryParse(ManagerLastDateOfWork.Text, out DateTime LastDateOfWork))
            {
                SqlParameter[] insertParameters = {
                        new SqlParameter("@EmployeeID", ManagerEmployeeIDCombobox.Text),
                        new SqlParameter("@EmployeeName", ManagerEmployeeName.Text),
                        new SqlParameter("@EmployeeSalaryUnit", salaryUnit),
                        new SqlParameter("@EmployeeSalary", salary),
                        new SqlParameter("@EmployeeEmail", ManagerEmployeeEmail.Text),
                        new SqlParameter("@EmployeePhoneContact", phoneContact),
                        new SqlParameter("@FirstDateOfWork", firstDateOfWork),
                        new SqlParameter("@LastDateOfWork", LastDateOfWork)
                    };
                connector.ActionProc("EmployeeDetailsUpdate", insertParameters);
                MessageBox.Show("Success");
                ViewLoading("EmployeeDetailView");
            }


        }
    }
}
