using Business;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        private void btnFilter(object sender, RoutedEventArgs e)
        {

            BInvoice bInvoice = new BInvoice();
            var date = DateTime.Parse(dpFecha.Text);
            McDataGrid.ItemsSource = bInvoice.GetInvoicesByDate(date);


        }
    }
}
