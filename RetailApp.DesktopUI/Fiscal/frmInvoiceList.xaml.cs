using RetailApp.DesktopUI.Register;
using RetailApp.ViewModels.Suplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RetailApp.DesktopUI.Fiscal
{
    /// <summary>
    /// Interaction logic for frmInvoiceList.xaml
    /// </summary>
    public partial class frmInvoiceList : Window
    {
        public frmInvoiceList()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            SupplierViewModel supplierViewModel = new SupplierViewModel
            {
                Name = "Nome do fornecedor",
                ComercialName = "Fantasia do fornecedor",
                CNPJ = "74405915000113",
                IE = "844334230002",
                IEST = "844334230002-ST",
                CRT = 1
            };

            frmSupplierEdit frmSupplierEdit = new frmSupplierEdit(supplierViewModel);
            frmSupplierEdit.Owner = this;
            bool? supplierEditResult = frmSupplierEdit.ShowDialog();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
