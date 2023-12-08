using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using FinalProject_QUANLYKHO.View.ImportMaterialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_QUANLYKHO.View.InvoceExportMaterialGoView
{
    public partial class ChooseBake : Form
    {
        List<Bake> bakes;
        BakeService bakeService;
        int rowSelect = 0;
        Form form = new Form();

        public void setFormParent(Form form)
        {
            this.form = form;
        }

        public void setRowSelect(int row)
        {
            this.rowSelect = row;
        }

        public ChooseBake(int row, Form form)
        {
            InitializeComponent();
            bakeService = new BakeService();
            rowSelect = row;
            this.form = form;
            loadData();

        }


        public ChooseBake()
        {
            InitializeComponent();
            bakeService = new BakeService();
            loadData();
            this.form = new Form();

        }

        public void loadData()
        {
            listBake.DataSource = null;
            listBake.Items.Clear();
            bakes = bakeService.GetAll(false);
            if (bakes.Count > 0)
            {
                listBake.DataSource = bakes;
                listBake.DisplayMember = "tenBanh";
                listBake.ValueMember = "idBanh";
            }
        }

        public void loadDataWithParam(List<Bake> listData)
        {
            listBake.DataSource = null;
            listBake.Items.Clear();
            if (bakes.Count > 0)
            {
                listBake.DataSource = listData;
                listBake.DisplayMember = "tenBanh";
                listBake.ValueMember = "idBanh";
            }
        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            string key = inputSearch.Text;
            List<Bake> listData = bakes.FindAll(m => m.tenBanh.ToLower().Contains(key.ToLower()));
            loadDataWithParam(listData);
        }
        private void listBake_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục được chọn hay không
            if (listBake.SelectedItem != null)
            {
                // Lấy đối tượng Bake tương ứng với mục được chọn
                Bake selectedBake = (Bake)listBake.SelectedItem;

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Bake selectedBake = (Bake)listBake.SelectedItem;
            if (selectedBake == null) return;


            // Kiểm tra xem form thuộc kiểu nào
            if (this.form is FormAddInvoceExportBakeGo)
            {
                FormAddInvoceExportBakeGo formE = (FormAddInvoceExportBakeGo)form;

                formE.handleLoadData(rowSelect, selectedBake);

            }
            else if (this.form is DetailBakeBill)
            {
                DetailBakeBill formE = (DetailBakeBill)form;
                formE.handleLoadData(rowSelect, selectedBake);
            }
            else if(this.form is FormAddInvoceImportBakeOutSide)
            {
                FormAddInvoceImportBakeOutSide formE = (FormAddInvoceImportBakeOutSide)form;
                formE.handleLoadData(rowSelect, selectedBake);
            }
            else if (this.form is DetailBakeBillImport)
            {
                DetailBakeBillImport formE = (DetailBakeBillImport)form;
                formE.handleLoadData(rowSelect, selectedBake);
            }


            this.Close();
        }
    }
}
