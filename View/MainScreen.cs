using System.Collections;
using System.Windows.Forms;
using FinalProject_QUANLYKHO.Contanst;
using FinalProject_QUANLYKHO.Properties;
using FinalProject_QUANLYKHO.View.BakeView;
using FinalProject_QUANLYKHO.View.MaterialView;
using FinalProject_QUANLYKHO.View.CustomerView;
using FinalProject_QUANLYKHO.View.Authentication;
using FinalProject_QUANLYKHO.View.DecentralizationView;
using FinalProject_QUANLYKHO.View.ImportMaterialView;
using FinalProject_QUANLYKHO.View.InvoceView;
using Microsoft.VisualBasic;

namespace FinalProject_QUANLYKHO
{

    public partial class Form1 : Form
    {

        private int formActive = ContanstApp.MAIN_SCREEN;
        private bool closeMenu = false;
        private List<Button> buttons = new List<Button>();
        private Form currentForm;

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainForm.Controls.Add(childForm);
            panelMainForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        public void switchForm(int active)
        {
            if (active == ContanstApp.BAKE_SCREEN)
            {
                OpenChildForm(new ManagerBake());
                labelActiveBar.Text = "Quản lý danh mục bánh";
            }
            else if (active == ContanstApp.CUSTOMER_SCREEN)
            {
                OpenChildForm(new ManagerCustomer());
                labelActiveBar.Text = "Quản lý danh mục khách hàng";
            }
            else if (active == ContanstApp.MATERIAL_SCREEN)
            {
                OpenChildForm(new ManagerMaterial());
                labelActiveBar.Text = "Quản lý danh mục nguyên liệu";
            }
            else if (active == ContanstApp.DECENTRALIZATION)
            {
                OpenChildForm(new ManagerDecentralization());
                labelActiveBar.Text = "Phần quyền";
            }
            else if (active == ContanstApp.EXPORT_MATERIAL_GO)
            {
                OpenChildForm(new ManagerExportMaterialGo());
                labelActiveBar.Text = ContanstApp.NAME_NAV_EXPORT_MATERIAL_GO;
            }
            else if (active == ContanstApp.MAIN_MENU_INVOCE)
            {
                OpenChildForm(new InvoceMenuView());
                labelActiveBar.Text = " Quản lý hóa đơn cửa hàng.";
            }
            else
            {
                if (currentForm != null)
                {
                    currentForm.Close();
                }
                labelActiveBar.Text = "Màn hình chính";
            }

        }

        public Form1()
        {

            InitializeComponent();
            buttons.Add(btnActiveBakeScreen);
            buttons.Add(btnActiveMainScreen);
            buttons.Add(btnActiveCustomerScreen);
            buttons.Add(btnActiveMaterialScreen);
            buttons.Add(btnActiveDecentrialtion);
            buttons.Add(btnActiveManagerInvoce);
         
        }


        private void DiableAllNavigate()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                Button button = buttons[i];
                ChangeStatusBtnNavigate(button, false);
            }
        }

        private void ChangeStatusBtnNavigate(Button button, bool b)
        {
            if (button == null)
            {
                return;
            }
            if (b)
            {
                button.BackColor = ContanstApp.ACTIVE_COLOR;
            }
            else
            {
                button.BackColor = Color.Transparent;
            }
        }





        private void btnActiveMainScreen_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DiableAllNavigate();
                ChangeStatusBtnNavigate(button, true);
                switchForm(ContanstApp.MAIN_SCREEN);
            }
        }

        private void btnActiveBakeScreen_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DiableAllNavigate();
                ChangeStatusBtnNavigate(button, true);
                switchForm(ContanstApp.BAKE_SCREEN);
            }
        }

        private void btnActiveCustomerScreen_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DiableAllNavigate();
                ChangeStatusBtnNavigate(button, true);
                switchForm(ContanstApp.CUSTOMER_SCREEN);
            }
        }

        private void btnActiveMaterialScreen_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DiableAllNavigate();
                ChangeStatusBtnNavigate(button, true);
                switchForm(ContanstApp.MATERIAL_SCREEN);
            }
        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (closeMenu)
            {
                // Expand the sidebar
                panelFlowSidebar.Width = panelFlowSidebar.MaximumSize.Width;
                closeMenu = false;
                panelHeader.Location = new Point(panelFlowSidebar.MaximumSize.Width, panelHeader.Location.Y);
                panelMainForm.Location = new Point(panelFlowSidebar.MaximumSize.Width, panelMainForm.Location.Y);


                btnActiveMainScreen.Text = ContanstApp.NAME_NAV_HOME;
                btnActiveCustomerScreen.Text = ContanstApp.NAME_NAV_CUSTOMER;
                btnActiveBakeScreen.Text = ContanstApp.NAME_NAV_BAKE;
                btnActiveMaterialScreen.Text = ContanstApp.NAME_NAV_MANAGER_INVOCE;


            }
            else
            {
                // Collapse the sidebar
                panelFlowSidebar.Width = panelFlowSidebar.MinimumSize.Width;
                panelHeader.Location = new Point(panelFlowSidebar.MinimumSize.Width, panelHeader.Location.Y);
                panelMainForm.Location = new Point(panelFlowSidebar.MinimumSize.Width, panelMainForm.Location.Y);
                closeMenu = true;

                btnActiveMainScreen.Text = "";
                btnActiveCustomerScreen.Text = "";
                btnActiveBakeScreen.Text = "";
                btnActiveMaterialScreen.Text = "";
                btnActiveDecentrialtion.Text = "";
                btnActiveManagerInvoce.Text = "";

            }

            // Adjust the widths of panelHeader and panelMainForm
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;

            panelHeader.Width = screenWidth - panelFlowSidebar.Width;
            panelMainForm.Width = screenWidth - panelFlowSidebar.Width;

        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = false;
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.role = -1;
            Properties.Settings.Default.Save();

            Form1 form = (Form1)Application.OpenForms["Form1"];
            Authentication formmain = new Authentication();
            formmain.Show();
            form.Hide();
        }

        private void btnActiveDecentrialtion_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DiableAllNavigate();
                ChangeStatusBtnNavigate(button, true);
                switchForm(ContanstApp.DECENTRALIZATION);
            }
        }

        private void btnActiveManagerInvoce_click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                DiableAllNavigate();
                ChangeStatusBtnNavigate(button, true);
                switchForm(ContanstApp.MAIN_MENU_INVOCE);
            }
        }
    }
}