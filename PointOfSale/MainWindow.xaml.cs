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

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Menu = new MenuItemSelectionControl(this);
            Menu.PropertyChanged += OrderSummary.OnPropertyChanged;
            CurrentControl = Menu;
            currentControl.Content = CurrentControl;
            
        }


        public void ChangeControl(UIElement change)
        {
            currentControl.Content = change;
        }
    }
}
