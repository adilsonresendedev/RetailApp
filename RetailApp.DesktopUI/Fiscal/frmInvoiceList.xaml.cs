﻿using RetailApp.DesktopUI.Register;
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
            frmSupplierEdit frmSupplierEdit = new frmSupplierEdit();
            frmSupplierEdit.Owner = this;
            bool? result = frmSupplierEdit.ShowDialog();

            if (result == true)
            {

            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
