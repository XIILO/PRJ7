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
using System.Drawing;

namespace StorageManager.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        DatabaseConnector connector = new DatabaseConnector();
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginFromBut_Click(object sender, EventArgs e)
        {
            if(UsernameTex == null || PasswordTex == null)
            {
                MessageBox.Show("Input your Username and Password !");
                return;
            }
            else
            {
                string Procname1 = "AccountVerify";
                string Procname2 = "AccountVerifyID";
                SqlParameter[] parameters1 =
                {
                    new SqlParameter("@Username", UsernameTex.Text),
                    new SqlParameter("@Password", PasswordTex.Text)

                };
                SqlParameter[] parameters2 =
                {
                    new SqlParameter("@Username", UsernameTex.Text),
                    new SqlParameter("@Password", PasswordTex.Text)
                };
                if(connector.VerifyProcedure(Procname1, parameters1))
                {
                    if(connector.VerifyProcedure(Procname2, parameters2))
                    {
                        ManagerProgram manager = new ManagerProgram();
                        manager.Show();
                        // Disable but EmployeeCategoryBut and EmployeeWatchReportBut from manager
                        /*DisableButtonWithColor(manager.ManagerEmployeeManagementbut);
                        DisableButtonWithColor(manager.ManagerWatchReportBut);*/
                        this.Hide();
                    }
                    else
                    {
                        ManagerProgram manager = new ManagerProgram();
                        manager.Show();
                        // Disable but EmployeeCategoryBut and EmployeeWatchReportBut from manager
/*                        DisableButtonWithColor(manager.ManagerEmployeeManagementbut);
                        DisableButtonWithColor(manager.ManagerWatchReportBut);*/
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Your Username and password invalid ! ");
                    return;
                }
            }
        }

        private void DisableButtonWithColor(Guna.UI2.WinForms.Guna2Button button)
        {
            button.Enabled = false;
            button.FillColor = Color.FromArgb(165, 214, 167);
        }

    }
}
