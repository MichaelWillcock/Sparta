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
using SouthwindApp;
using SouthwindContextBusiness;

namespace GUIForDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerManager _customerManager = new CustomerManager();
        public MainWindow()
        {
            InitializeComponent();
            FillListBox();
        }
        private void FillListBox()
        {
            listBox1.ItemsSource = _customerManager.RetrieveAll();
        }
        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            bool x = false;
            using (var db = new SouthwindContext())
            {
                var query =
                    from c in db.Customers
                    where c.CustomerId == CustomerIdInput.Text
                    select c.CustomerId;
                foreach (var item in query)
                {
                    if (item.Contains(CustomerIdInput.Text))
                    {
                        MessageBox.Show("Error, CustomerId already taken. Please enter a different option");
                        break;
                    }
                    else
                    {
                        x = true;
                    }
                }
            }
            if (x == true)
            {
                _customerManager.AddCustomer(CustomerIdInput.Text, ContactNameInput.Text);
            }
            FillListBox();
        }
        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            _customerManager.RemoveCustomer(CustomerIdInput.Text);
            FillListBox();
        }
    }
}
