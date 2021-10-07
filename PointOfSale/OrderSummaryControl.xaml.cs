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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Private testing variables to ensure behavior
        /// First is populating List property
        /// </summary>
        private List<string> Test = new List<string> { "Test1", "Test2" };

        /// <summary>
        /// Stand in private variable for orderNumber integer
        /// </summary>
        private int orderNumTest = 13;

        /// <summary>
        /// Stand in DateTime getter for testing purposes
        /// </summary>
        private string time = DateTime.Now.ToShortTimeString();

        /// <summary>
        /// Main constructor of OrderSummaryControl class
        /// Calls test method TextPopulate() for functionality testing
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
            TextPopulate();
        }

        /// <summary>
        /// Helper method to populated both the header TextBox and ListViewBox for displaying order
        /// </summary>
        public void TextPopulate()
        {
            OrderTextBox.ItemsSource = Test;
            OrderNumberBox.Text = "Order Number " + orderNumTest + "\n" + time;
        }
    }
}
