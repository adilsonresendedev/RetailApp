﻿using RetailApp.DesktopUI.Register;
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
                Name = "Nome do fornecedor",
                ComercialName = "Fantasia do fornecedor",
                CNPJ = "74405915000113",
                IE = "844334230002",
                IEST = "844334230002-ST",
                CRT = 1,
                addresViewModel = new List<AddresViewModel>()
                {
                    new AddresViewModel
                    {
                        IdAdress = 1,
                        MainAdress = true,
                        StreetName = "Street name 1",
                        StreetNumber = "1",
                        Neighborhood = "Bairro 1",
                        ZipCode = "1",
                        CityViewModel = new CityViewModel
                        {
                            IdCity = 1,
                            CityName = "Cidade 1",
                            State = "ST1",
                            CountryViewModel = new CountryViewModel
                            {
                                IdCountry = 1,
                                CountryName = "Braza 1"
                            }
                        }
                    },
                    new AddresViewModel
                    {
                        IdAdress = 2,
                        MainAdress = false,
                        StreetName = "Street name 2",
                        StreetNumber = "2",
                        Neighborhood = "Bairro 2",
                        ZipCode = "2",
                        CityViewModel = new CityViewModel
                        {
                            IdCity = 2,
                            CityName = "Cidade 2",
                            State = "ST2",
                            CountryViewModel = new CountryViewModel
                            {
                                IdCountry = 1,
                                CountryName = "Braza 2"
                            }
                        }
                    }
                },
                PhoneViewModel = new List<PhoneViewModel>()
                {
                    new PhoneViewModel{
                        IdPhone = 1,
                        MainPhone = true,
                        PhoneNumber = "1111111111"
                    },
                    new PhoneViewModel
                    {
                        IdPhone = 2,
                        MainPhone = false,
                        PhoneNumber = "2222222222"
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
