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
    public partial class ChooseMaterial : Form
    {
        List<Material> materials;
        MaterialService materialService;
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

        public ChooseMaterial(int row, Form form)
        {
            InitializeComponent();
            materialService = new MaterialService();
            rowSelect = row;
            this.form = form;
            loadData();

        }


        public ChooseMaterial()
        {
            InitializeComponent();
            materialService = new MaterialService();
            loadData();
            this.form = new Form();

        }

        public void loadData()
        {
            listMaterial.DataSource = null;
            listMaterial.Items.Clear();
            materials = materialService.GetAll(false);
            if (materials.Count > 0)
            {
                listMaterial.DataSource = materials;
                listMaterial.DisplayMember = "tenNguyenLieu";
                listMaterial.ValueMember = "idNguyenLieu";
            }
        }

        public void loadDataWithParam(List<Material> listData)
        {
            listMaterial.DataSource = null;
            listMaterial.Items.Clear();
            if (materials.Count > 0)
            {
                listMaterial.DataSource = listData;
                listMaterial.DisplayMember = "tenNguyenLieu";
                listMaterial.ValueMember = "idNguyenLieu";
            }
        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            string key = inputSearch.Text;
            List<Material> listData = materials.FindAll(m => m.tenNguyenLieu.ToLower().Contains(key.ToLower()));
            loadDataWithParam(listData);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.loadData();
            Material selectedValue = (Material)listMaterial.SelectedItem;

            if (selectedValue == null) return;


            // Kiểm tra xem form thuộc kiểu nào
            if (this.form is FormAddInvoceExportMaterialGo)
            {
                FormAddInvoceExportMaterialGo formE = (FormAddInvoceExportMaterialGo)form;

                formE.handleLoadData(rowSelect, selectedValue);

            }
            else if (form is DetailInvoice)
            {
                DetailInvoice formE = (DetailInvoice)form;
                formE.handleLoadData(rowSelect, selectedValue);
            }


            this.Close();
        }
    }
}
