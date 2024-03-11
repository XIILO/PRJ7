using Guna.UI2.WinForms;

namespace StorageManager.UserControler
{
    partial class EmployeeItemsManagemt
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            EmployeCategoryDatagridview = new Guna2DataGridView();
            EmployeeReloadBut = new Guna2CircleButton();
            EmployeeFindBut = new Guna2CircleButton();
            guna2CustomGradientPanel2 = new Guna2CustomGradientPanel();
            FindAndAddCategoriesBut = new Guna2TextBox();
            EmployeeAddCategory = new Guna2Button();
            ((System.ComponentModel.ISupportInitialize)EmployeCategoryDatagridview).BeginInit();
            SuspendLayout();
            // 
            // EmployeCategoryDatagridview
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            EmployeCategoryDatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            EmployeCategoryDatagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmployeCategoryDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmployeCategoryDatagridview.ColumnHeadersHeight = 4;
            EmployeCategoryDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmployeCategoryDatagridview.DefaultCellStyle = dataGridViewCellStyle3;
            EmployeCategoryDatagridview.Dock = DockStyle.Bottom;
            EmployeCategoryDatagridview.GridColor = Color.FromArgb(231, 229, 255);
            EmployeCategoryDatagridview.Location = new Point(0, 289);
            EmployeCategoryDatagridview.Margin = new Padding(0);
            EmployeCategoryDatagridview.Name = "EmployeCategoryDatagridview";
            EmployeCategoryDatagridview.RowHeadersVisible = false;
            EmployeCategoryDatagridview.Size = new Size(1248, 588);
            EmployeCategoryDatagridview.TabIndex = 7;
            EmployeCategoryDatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmployeCategoryDatagridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeCategoryDatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmployeCategoryDatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmployeCategoryDatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmployeCategoryDatagridview.ThemeStyle.BackColor = Color.White;
            EmployeCategoryDatagridview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmployeCategoryDatagridview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            EmployeCategoryDatagridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeCategoryDatagridview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            EmployeCategoryDatagridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmployeCategoryDatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeCategoryDatagridview.ThemeStyle.HeaderStyle.Height = 4;
            EmployeCategoryDatagridview.ThemeStyle.ReadOnly = false;
            EmployeCategoryDatagridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmployeCategoryDatagridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeCategoryDatagridview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            EmployeCategoryDatagridview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmployeCategoryDatagridview.ThemeStyle.RowsStyle.Height = 25;
            EmployeCategoryDatagridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmployeCategoryDatagridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmployeCategoryDatagridview.CellContentClick += EmployeCategoryDatagridview_CellContentClick;
            // 
            // EmployeeReloadBut
            // 
            EmployeeReloadBut.DisabledState.BorderColor = Color.DarkGray;
            EmployeeReloadBut.DisabledState.CustomBorderColor = Color.DarkGray;
            EmployeeReloadBut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EmployeeReloadBut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EmployeeReloadBut.Font = new Font("Segoe UI", 9F);
            EmployeeReloadBut.ForeColor = Color.White;
            EmployeeReloadBut.Location = new Point(1206, 225);
            EmployeeReloadBut.Name = "EmployeeReloadBut";
            EmployeeReloadBut.ShadowDecoration.CustomizableEdges = customizableEdges1;
            EmployeeReloadBut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            EmployeeReloadBut.Size = new Size(35, 35);
            EmployeeReloadBut.TabIndex = 13;
            // 
            // EmployeeFindBut
            // 
            EmployeeFindBut.DisabledState.BorderColor = Color.DarkGray;
            EmployeeFindBut.DisabledState.CustomBorderColor = Color.DarkGray;
            EmployeeFindBut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EmployeeFindBut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EmployeeFindBut.Font = new Font("Segoe UI", 9F);
            EmployeeFindBut.ForeColor = Color.White;
            EmployeeFindBut.Location = new Point(230, 225);
            EmployeeFindBut.Name = "EmployeeFindBut";
            EmployeeFindBut.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EmployeeFindBut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            EmployeeFindBut.Size = new Size(35, 35);
            EmployeeFindBut.TabIndex = 12;
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel2.FillColor = Color.FromArgb(165, 214, 167);
            guna2CustomGradientPanel2.FillColor2 = Color.FromArgb(165, 214, 167);
            guna2CustomGradientPanel2.Location = new Point(0, 263);
            guna2CustomGradientPanel2.Margin = new Padding(0);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel2.Size = new Size(1248, 26);
            guna2CustomGradientPanel2.TabIndex = 11;
            // 
            // FindAndAddCategoriesBut
            // 
            FindAndAddCategoriesBut.AutoRoundedCorners = true;
            FindAndAddCategoriesBut.BorderRadius = 16;
            FindAndAddCategoriesBut.CustomizableEdges = customizableEdges5;
            FindAndAddCategoriesBut.DefaultText = "";
            FindAndAddCategoriesBut.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            FindAndAddCategoriesBut.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            FindAndAddCategoriesBut.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            FindAndAddCategoriesBut.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            FindAndAddCategoriesBut.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            FindAndAddCategoriesBut.Font = new Font("Segoe UI", 9F);
            FindAndAddCategoriesBut.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            FindAndAddCategoriesBut.Location = new Point(3, 225);
            FindAndAddCategoriesBut.Name = "FindAndAddCategoriesBut";
            FindAndAddCategoriesBut.PasswordChar = '\0';
            FindAndAddCategoriesBut.PlaceholderText = "Serch or Add";
            FindAndAddCategoriesBut.SelectedText = "";
            FindAndAddCategoriesBut.ShadowDecoration.CustomizableEdges = customizableEdges6;
            FindAndAddCategoriesBut.Size = new Size(221, 35);
            FindAndAddCategoriesBut.TabIndex = 10;
            // 
            // EmployeeAddCategory
            // 
            EmployeeAddCategory.AutoRoundedCorners = true;
            EmployeeAddCategory.BorderRadius = 16;
            EmployeeAddCategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            EmployeeAddCategory.CustomizableEdges = customizableEdges7;
            EmployeeAddCategory.DisabledState.BorderColor = Color.DarkGray;
            EmployeeAddCategory.DisabledState.CustomBorderColor = Color.DarkGray;
            EmployeeAddCategory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EmployeeAddCategory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EmployeeAddCategory.Font = new Font("Segoe UI", 9F);
            EmployeeAddCategory.ForeColor = Color.White;
            EmployeeAddCategory.Location = new Point(1058, 225);
            EmployeeAddCategory.Name = "EmployeeAddCategory";
            EmployeeAddCategory.ShadowDecoration.CustomizableEdges = customizableEdges8;
            EmployeeAddCategory.Size = new Size(142, 35);
            EmployeeAddCategory.TabIndex = 9;
            EmployeeAddCategory.Text = "New Category";
            // 
            // EmployeeItemsManagemt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EmployeeReloadBut);
            Controls.Add(EmployeeFindBut);
            Controls.Add(guna2CustomGradientPanel2);
            Controls.Add(FindAndAddCategoriesBut);
            Controls.Add(EmployeeAddCategory);
            Controls.Add(EmployeCategoryDatagridview);
            Margin = new Padding(0);
            Name = "EmployeeItemsManagemt";
            Size = new Size(1248, 877);
            Load += EmployeeItemsManagemt_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeCategoryDatagridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna2DataGridView EmployeCategoryDatagridview;
        private Guna2CircleButton EmployeeReloadBut;
        private Guna2CircleButton EmployeeFindBut;
        private Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna2TextBox FindAndAddCategoriesBut;
        private Guna2Button EmployeeAddCategory;
    }
}
