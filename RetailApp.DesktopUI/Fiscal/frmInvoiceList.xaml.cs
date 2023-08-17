using RetailApp.ApiClient.InvoiceClient;
using RetailApp.DesktopUI.FileHelper;
using RetailApp.DesktopUI.Register;
using RetailApp.Utility.ExtensionMethods;
using RetailApp.ViewModels;
using RetailApp.ViewModels.Address;
using RetailApp.ViewModels.Fiscal;
using RetailApp.ViewModels.Phone;
using RetailApp.ViewModels.Suplier;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

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

        private async void btnImport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string xmlString = FileUtility.GetStringFromXml();
                if (string.IsNullOrWhiteSpace(xmlString))
                {
                    MessageBox.Show("Arquivo XML inválido!");
                    return;
                }

                InvoiceApiClient invoiceApiClient = new InvoiceApiClient();
                ResponseViewModel<InvoiceViewModel> responseViewModel = await invoiceApiClient.GetByXml(xmlString.ToBase64());

                SupplierViewModel supplierViewModel = responseViewModel.Data.SupplierViewModel;
                frmSupplierEdit frmSupplierEdit = new frmSupplierEdit(supplierViewModel);

                frmSupplierEdit.Owner = this;
                bool? supplierEditResult = frmSupplierEdit.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
