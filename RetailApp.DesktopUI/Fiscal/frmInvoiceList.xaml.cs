using RetailApp.DesktopUI.Register;
using RetailApp.ViewModels.Address;
using RetailApp.ViewModels.Phone;
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
                Name = "Gitflow2",
                ComercialName = "Fornecedor",
                CNPJ = "74405915000113",
                IE = "844334130001",
                IEST = "844334130001-ST",
                CRT = 1,
                addresViewModel = new List<AddresViewModel>()
                {
                    new AddresViewModel
                    {
                        IdAdress = 1,
                        MainAdress = true,
                        StreetName = "Rua 1",
                        StreetNumber = "1",
                        StreetAditionalInformation = "Complemento 1",
                        Neighborhood = "Bairro 1",
                        ZipCode= "111111111",
                        CityViewModel = new CityViewModel
                        {
                            IdCity = 1,
                            CityName = "Cidade 1",
                            State = "ST1",
                            CountryViewModel = new CountryViewModel
                            {
                                IdCountry = 1,
                                CountryName = "País 1"
                            }
                        }
                    },
                    new AddresViewModel
                    {
                        IdAdress = 2,
                        MainAdress = false,
                        StreetName = "Rua 2",
                        StreetNumber = "2",
                        StreetAditionalInformation = "Complemento 2",
                        Neighborhood = "Bairro 2",
                        ZipCode= "222222222",
                        CityViewModel = new CityViewModel
                        {
                            IdCity = 2,
                            CityName = "Cidade 2",
                            State = "ST2",
                            CountryViewModel = new CountryViewModel
                            {
                                IdCountry = 2,
                                CountryName = "País 2"
                            }
                        }
                    }
                },
                PhoneViewModel = new List<PhoneViewModel>()
                {
                    new PhoneViewModel
                    {
                        IdPhone = 1,
                        MainPhone = true,
                        PhoneNumber = "11111111111"
                    },
                    new PhoneViewModel
                    {
                        IdPhone = 2,
                        MainPhone = false,
                        PhoneNumber = "22222222222"
                    }
                }
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
