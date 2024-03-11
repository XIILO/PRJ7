using StorageManager.UserControlEmployee;
using StorageManager.UserControler;
using StorageManager.UserControlManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.Views
{
    public partial class ManagerProgram : Form
    {
        public ManagerProgram()
        {
            InitializeComponent();
        }

        private void ManagerProgram_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeCategoryBut_Click(object sender, EventArgs e)
        {
            EmployeeCategoryManagement EmployeeCategoryControl = new EmployeeCategoryManagement();
            EmployeeCategoryPanel.Controls.Clear();
            EmployeeCategoryPanel.Controls.Add(EmployeeCategoryControl);


        }

        private void EmployeeItemsManagementBut_Click(object sender, EventArgs e)
        {
            EmployeeItemsManagemt EIM = new EmployeeItemsManagemt();
            EmployeeCategoryPanel.Controls.Clear();
            EmployeeCategoryPanel.Controls.Add(EIM);
        }

        private void EmployeeWatchReportBut_Click(object sender, EventArgs e)
        {
            EmployeeWatchReports EWP = new EmployeeWatchReports();
            EmployeeCategoryPanel.Controls.Clear();
            EmployeeCategoryPanel.Controls.Add(EWP);
        }

        private void EmployeeSuppliersManagement_Click(object sender, EventArgs e)
        {
            EmployeeSupplierManagement ESM = new EmployeeSupplierManagement();
            EmployeeCategoryPanel.Controls.Clear();
            EmployeeCategoryPanel.Controls.Add(ESM);
        }

        private void ManagerWatchReportBut_Click(object sender, EventArgs e)
        {

        }

        private void ManagerEmployeeManagementbut_Click(object sender, EventArgs e)
        {
            ManagerEmployeeManagement MEM = new ManagerEmployeeManagement();
            EmployeeCategoryPanel.Controls.Clear();
            EmployeeCategoryPanel.Controls.Add(MEM);
        }
    }
}
     