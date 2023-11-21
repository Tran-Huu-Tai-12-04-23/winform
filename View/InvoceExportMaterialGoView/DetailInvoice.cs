using FinalProject_QUANLYKHO.Models;
using FinalProject_QUANLYKHO.Service;
using Syncfusion.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_QUANLYKHO.View.ImportMaterialView
{
    public partial class DetailInvoice : Form
    {
        private Invoice invoice;
        private InvoceService invoiceService;
        private List<Invoice> invoices;
        private int currentIndexInvoice = 0;
        private double total = 0 ;

        public DetailInvoice()
        {
            InitializeComponent();
            invoiceService = new InvoceService();
        }

        public DetailInvoice(List<Invoice> invoices, Invoice invoice)
        {
            this.invoices = invoices;
            this.currentIndexInvoice = invoices.FindIndex(inv => inv.idHoaDon == invoice.idHoaDon);
            this.invoice = invoice;
            invoiceService = new InvoceService();
            InitializeComponent();
            if (invoice == null) return;
            loadData(invoice.idHoaDon);
        }

        public void loadData(String idHoaDon)
        {
            dataGridViewDetailInvoice.Rows.Clear();
            List<InvoiceDetail> invoiceDetails = invoiceService.GetInvoiceDetails(idHoaDon);
            calculatorTotal(invoiceDetails);
            lbExportDepartment.Text = invoice.tenBoPhanXuat;
            lbIdInvoice.Text = invoice.idHoaDon;

            foreach (InvoiceDetail invDT in invoiceDetails)
            {
                object[] rowData = new object[] { invDT.material.tenNguyenLieu, invDT.material.sl, invDT.material.donVi, invDT.sl, invDT.tongTien };
                dataGridViewDetailInvoice.Rows.Add(rowData);
            }
        }

        private void btnPrevInvoice_Click(object sender, EventArgs e)
        {
            if (currentIndexInvoice <= 0)
            {
                return;
            }

            currentIndexInvoice--;

            Invoice invoiceIndex = invoices[currentIndexInvoice];

            if (invoiceIndex == null) return;

            loadData(invoiceIndex.idHoaDon);

            restartStatusBtn();
        }

        private void btnNextInvoice_Click(object sender, EventArgs e)
        {
            if (currentIndexInvoice >= invoices.Count - 1)
            {
                return;
            }

            currentIndexInvoice++;


            Invoice invoiceIndex = invoices[currentIndexInvoice];

            if (invoiceIndex == null) return;

            loadData(invoiceIndex.idHoaDon);

            restartStatusBtn();
        }

        public void restartStatusBtn()
        {
            if (currentIndexInvoice >= invoices.Count - 1)
            {
                btnNextInvoice.Enabled = false;
            }
            else
            {
                btnNextInvoice.Enabled = true;
            }

            if (currentIndexInvoice <= 0)
            {
                btnPrevInvoice.Enabled = false;
            }
            else
            {
                btnPrevInvoice.Enabled = true;
            }

        }

        public void calculatorTotal(List<InvoiceDetail> detailInvoices) {

            total= detailInvoices.Sum(detail => detail.tongTien);
            lbTotalInvoce.Text = total.ToString();



        }
    }


}
