using RetailApp.DesktopUI.Fiscal;
using RetailApp.Utility;
using RetailApp.ViewModels.Fiscal;
using System.Windows;

namespace RetailApp.DesktopUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ImportXML()
        {
            string xmlContent = FileUtility.GetStringFromXml();
            nfeProc nfeProc = XmlUtility.XmlToClass<nfeProc>(xmlContent);
        }

        private void meiFiscal_Click(object sender, RoutedEventArgs e)
        {
            frmInvoiceList frmInvoiceList = new frmInvoiceList();
            frmInvoiceList.Owner = this;
            bool? result = frmInvoiceList.ShowDialog();
        }
    }
}
