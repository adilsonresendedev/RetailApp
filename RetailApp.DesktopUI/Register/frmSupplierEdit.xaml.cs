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
        }
    }
}
