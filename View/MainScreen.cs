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
using System.Runtime.ConstrainedExecution;
using FinalProject_QUANLYKHO.Service;
using System.Windows.Forms.DataVisualization.Charting;
using System;

namespace FinalProject_QUANLYKHO
{

    public partial class Form1 : Form
    {
        MainService mainService = new MainService();
        private int formActive = ContanstApp.MAIN_SCREEN;
        private bool closeMenu = false;
        private List<Button> buttons = new List<Button>();
        private Form currentForm;
        private Button btnActive;
        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();

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
            initStyleButton();
            initData();
            initChart();

        }

        private void initChart()
        {
            /*  List<DataPoint> dataPoints = new List<DataPoint>
              {
                  new DataPoint(1, 10),
                  new DataPoint(2, 20),
                  new DataPoint(3, 15),
                  new DataPoint(4, 25),
                  new DataPoint(5, 18),
              };

              chart.Series[0].Points.DataBind(dataPoints, "X", "Y", "");*/
            chart.ForeColor = Color.White;
            chart.Series[0].Points.AddXY(1, 10);
            chart.Series[0].Points.AddXY(2, 20);
            chart.Series[0].Points.AddXY(3, 15);
            chart.Series[0].Points.AddXY(4, 25);
            chart.Series[0].Points.AddXY(5, 18);

            // Customize chart appearance
            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.ChartAreas[0].AxisX.Title = "Tháng";
            chart.ChartAreas[0].AxisY.Title = "Tổng tiền";
        }

        private void initStyleButton()
        {
            btnActive = btnActiveMainScreen;
            buttons.Add(btnActiveBakeScreen);
            buttons.Add(btnActiveMainScreen);
            buttons.Add(btnActiveCustomerScreen);
            buttons.Add(btnActiveMaterialScreen);
            buttons.Add(btnActiveDecentrialtion);
            buttons.Add(btnActiveManagerInvoce);
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            buttons.Add(btn4);
            buttons.Add(btn5);
            buttons.Add(btn6);
            buttons.Add(btn7);
            buttons.Add(btn8);


            for (int i = 0; i < buttons.Count; i++)
            {
                Button button = buttons[i];
                button.MouseEnter += btn_MouseEnter;
                button.MouseLeave += btn_MouseLeave;
            }

            bntHome.MouseEnter += btn_MouseEnter;
            bntHome.MouseLeave += btn_MouseLeave;
            btnMenu.MouseEnter += btn_MouseEnter;
            btnMenu.MouseLeave += btn_MouseLeave;
            btnExit.MouseEnter += btn_MouseEnter;
            btnExit.MouseLeave += btn_MouseLeave;
        }

        private void initData()
        {
            this.startDate = pickDateStart.Value;
            this.endDate = pickDateEnd.Value;

            int tonKhoBanh = mainService.GetInventoryForBakedGoods();
            int tonKhoNguyenLieu = mainService.GetInventoryForMaterials();
            double tongthunguyenlieu = mainService.GetTotalAmountForHoaDonXuatNguyenLieu(startDate, endDate);
            double tongThuBanh = mainService.GetTotalAmountForHoaDonXuatBanh(startDate, endDate);

            lbTonKhoBanh.Text = "Tồn : " + tonKhoBanh + " bánh";
            lbTonKhoNguyenLieu.Text = "Tồn : " + tonKhoNguyenLieu + " nguyên liệu";
            lbTotalExportMaterial.Text = tongthunguyenlieu + " vnd";
            lbTotalExportBake.Text = tongThuBanh + " vnd";
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

                btnActive = button;
            }
            else
            {
                button.BackColor = ContanstApp.INACTIVE_COLOR; ;
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



        //handle hover button side barr
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            // btnActiveManagerInvoce.BackColor = ContanstApp.INACTIVE_COLOR; 
            if (sender is Button) // Kiểm tra xem đối tượng sender có phải là Button hay không
            {
                Button enteredButton = (Button)sender; // Ép kiểu sender về Button
                                                       // enteredButton.BackColor = ContanstApp.INACTIVE_COLOR;
                enteredButton.ForeColor = ContanstApp.TEXT_ACTIVE_COLOR;
                enteredButton.BackColor = ContanstApp.ACTIVE_COLOR;
            }
        }

        // Sự kiện khi chuột rời khỏi nút
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            //btnActiveManagerInvoce.BackColor = ContanstApp.INACTIVE_COLOR;
            if (sender is Button) // Kiểm tra xem đối tượng sender có phải là Button hay không
            {
                Button enteredButton = (Button)sender;

                enteredButton.ForeColor = ContanstApp.TEXT_COLOR;
                enteredButton.BackColor = Color.Transparent;
            }

            btnActive.BackColor = ContanstApp.ACTIVE_COLOR;

        }



        private void btnMenu_Click_1(object sender, EventArgs e)
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
                btnActiveMaterialScreen.Text = ContanstApp.NAME_NAV_MATERIAL;
                btnActiveManagerInvoce.Text = ContanstApp.NAME_NAV_MANAGER_INVOCE;
                btnActiveDecentrialtion.Text = ContanstApp.NAME_NAV_DECERLIZATION;

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!");
            Properties.Settings.Default.username = null;
            Properties.Settings.Default.role = -1;
            Properties.Settings.Default.login = false;
            Properties.Settings.Default.idTaiKhoan = null;
            Properties.Settings.Default.Save();

            Authentication form = new Authentication();
            form.Show();
            this.Hide();
        }

        private void pickDateStart_ValueChanged_1(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            this.startDate = dateTimePicker.Value;
            this.initData();
        }

        private void pickDateEnd_ValueChanged_1(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            this.endDate = dateTimePicker.Value;
            this.initData();
        }
    }
}