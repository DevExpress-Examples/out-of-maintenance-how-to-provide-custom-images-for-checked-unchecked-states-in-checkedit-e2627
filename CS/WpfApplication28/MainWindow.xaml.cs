using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace WpfApplication28
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
            DataTable table = new DataTable();
            table.Columns.Add("Subject", typeof(string));
            table.Columns.Add("IsRead", typeof(bool));
            table.Rows.Add(new object[] {"Mail1", true});
            table.Rows.Add(new object[] {"Mail2", false});
            
            gridControl1.DataSource = table;
        }
    }
}
