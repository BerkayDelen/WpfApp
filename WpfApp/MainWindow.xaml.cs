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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        public MainWindow()
        {
            InitializeComponent();

            
            customers = new List<Customer>()
            {
                new Customer() { AD="Ali",SOYAD="CAN" },
                 new Customer() { AD="Berkay",SOYAD="DELEN" },
                 new Customer() { AD="Mert",SOYAD="KORKMAZ" }
                
            };

            Customer cs = new Customer() { AD = "Hasan", SOYAD = "Ali" };
            customers.Add(cs);
            tb1.ItemsSource = customers;

        }

        public void Windows_Load(object sender, RoutedEventArgs e)
        {
            
            
        }

       
    }

    internal class Customer
    {
        public string AD { get; set; }
        public string SOYAD { get; set; }
    }
}
