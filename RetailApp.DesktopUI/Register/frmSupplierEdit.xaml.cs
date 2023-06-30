using RetailApp.ViewModels.Suplier;
using System.Windows;

namespace RetailApp.DesktopUI.Register
{
    /// <summary>
    /// Interaction logic for frmSupplierEdit.xaml
    /// </summary>
    public partial class frmSupplierEdit : Window
    {
        private SupplierViewModel _supplierViewModel;

        public frmSupplierEdit(SupplierViewModel supplierViewModel)
        {
            InitializeComponent();
            _supplierViewModel = supplierViewModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _supplierViewModel;
            dtgAdress.ItemsSource = _supplierViewModel.addresViewModel;
            dtgPhone.ItemsSource = _supplierViewModel.PhoneViewModel;
        }
    }
}
