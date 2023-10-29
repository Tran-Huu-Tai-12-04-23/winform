using System.Collections;
using System.Windows.Forms;
using FinalProject_QUANLYKHO.Contanst;
using FinalProject_QUANLYKHO.Properties;
using FinalProject_QUANLYKHO.View.BakeView;
using FinalProject_QUANLYKHO.View.MaterialView;
using FinalProject_QUANLYKHO.View.CustomerView;

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


        private void switchForm(int active)
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

            }
            else
            {
                // Collapse the sidebar
                panelFlowSidebar.Width = panelFlowSidebar.MinimumSize.Width;
                panelHeader.Location = new Point(panelFlowSidebar.MinimumSize.Width, panelHeader.Location.Y);
                panelMainForm.Location = new Point(panelFlowSidebar.MinimumSize.Width, panelMainForm.Location.Y);
                closeMenu = true;

            }

            // Adjust the widths of panelHeader and panelMainForm
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;

            panelHeader.Width = screenWidth - panelFlowSidebar.Width;
            panelMainForm.Width = screenWidth - panelFlowSidebar.Width;

        }



    }
}