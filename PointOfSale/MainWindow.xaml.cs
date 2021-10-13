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
using PointOfSale.ItemCustomizations;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public UIElement CurrentControl = new UIElement();
        public event PropertyChangedEventHandler PropertyChanged;
        public MenuItemSelectionControl Menu;
        public OrderSummaryControl Order;

        /// <summary>
        /// Main Window hook, establishes control context for display
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Menu = new MenuItemSelectionControl(this);
            Menu.PropertyChanged += OrderSummary.OnPropertyChanged;
            CurrentControl = Menu;
            currentControl.Content = CurrentControl;
            
        }

        /// <summary>
        /// Method for changing control based on actions elsewhere in the design
        /// </summary>
        /// <param name="change"></param>
        public void ChangeControl(UIElement change)
        {
            currentControl.Content = change;
        }

        /// <summary>
        /// Functionality for "Back To Menu" Button, simply changes UI contrl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            currentControl.Content = Menu;
        }

        /// <summary>
        /// Functionality for Cancel Order button
        /// Updates master OrderItems list and OrderSummary display and order number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Menu.OrderItems.Clear();
            OrderSummary.CancelOrder();
            currentControl.Content = Menu;
        }

        /// <summary>
        /// Functionality for Complete Order button
        /// Updates Order number and resets master OrderITems list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteButton_Click(object sender, RoutedEventArgs e)
        {
            Menu.CompleteOrder();
            OrderSummary.CompleteOrder();
            currentControl.Content = Menu;
        }
    }
}
