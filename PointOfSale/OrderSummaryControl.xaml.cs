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
using System.ComponentModel;
using GyroScope.Data.Entrees;
using GyroScope.Data.Drinks;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using GyroScope.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// Private testing variables to ensure behavior
        /// First is populating List property
        /// </summary>
        private List<string> Order = new List<string>();
        private decimal Total = 0.0m;

        /// <summary>
        /// Stand in private variable for orderNumber integer
        /// </summary>
        private int orderNum = 1;

        /// <summary>
        /// Stand in DateTime getter for testing purposes
        /// </summary>
        private string time = DateTime.Now.ToShortTimeString();

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Main constructor of OrderSummaryControl class
        /// Calls test method TextPopulate() for functionality testing
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
            this.DataContext = this;
            PropertyChanged += OnPropertyChanged;
            TextPopulate();
        }

        /// <summary>
        /// Helper method to populated both the header TextBox and ListViewBox for displaying order
        /// </summary>
        public void TextPopulate()
        {
            OrderNumberBox.Text = "Order Number " + orderNum + "\n" + DateTime.Now.ToShortTimeString(); 
            TotalTextBox.Items.Add("SubTotal " + Total);
        }

        public void CancelOrder()
        {
            OrderTextBox.Items.Clear();
            TotalTextBox.Items.Clear();
            TextPopulate();
            if (orderNum > 1)
            {
                orderNum--;
            }
        }

        public void CompleteOrder()
        {
            OrderTextBox.Items.Clear();
            TotalTextBox.Items.Clear();
            orderNum++;
        }
        /// <summary>
        /// Updater method called when master OrderList is modified in the ItemCustomization namespace controllers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ///Formatting spacer for the list
            string spacer = "    ";
            ///Clears the text box each time the method is called
            OrderTextBox.Items.Clear();
            TotalTextBox.Items.Clear();

            ///Checks if the sender is IEnumerable, in this case a List
            if (sender is IEnumerable<object> list)
            {
                ///Sets decimal that controls the subtotal to 0.0 prior to the loop
                Total = 0.0m;

                ///Loops through the IEnermerable object checking to see the type of each object
                foreach (object x in list)
                {         
                    if(x is Entree entree )
                    {
                        ///Adds the name to the text box
                        OrderTextBox.Items.Add(entree.Name);
                        Total += entree.Price;
                        ///Loops through IEnermrable List<string> of special instructions for printing
                        for(int i = 0;  i < entree.SpecialInstructions.Count(); i++)
                        {
                            OrderTextBox.Items.Add(spacer + entree.SpecialInstructions.ElementAt(i));
                        }
                    }

                    if (x is Drink drink)
                    {
                        Total += drink.Price;
                        OrderTextBox.Items.Add(drink.Name);
                    }

                    if (x is Side side)
                    {
                        Total += side.Price;
                        OrderTextBox.Items.Add(side.Name);
                    }

                    if(x is Treat treat)
                    {
                        Total += treat.Price;
                        OrderTextBox.Items.Add(treat.Name);
                    }
                }
            }


            TextPopulate();
        }
    }
}
