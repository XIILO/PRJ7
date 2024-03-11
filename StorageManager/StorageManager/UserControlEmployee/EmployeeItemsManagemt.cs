using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.UserControler
{
    public partial class EmployeeItemsManagemt : UserControl
    {
        public EmployeeItemsManagemt()
        {
            InitializeComponent();
        }

        DatabaseConnector connector = new DatabaseConnector();
        DataTable table = new DataTable();
        private void EmployeeItemsManagemt_Load(object sender, EventArgs e)
        {

        }

        public void ViewLoading(string procname)
        {
        }

        private void EmployeCategoryDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
