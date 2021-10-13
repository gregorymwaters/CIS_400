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
using PointOfSale.ItemCustomizations;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        GyroCustomization gc;
        LibraLibationCustomization llc;
        SideCustomization sc;
        TeaCustomization tc;
        TreatsCustomization Tc;
        MainWindow mainWindow;
        public List<object> OrderItems = new List<object>();
        List<Drink> DrinkOrderItems = new List<Drink>();
        public MenuItemSelectionControl()
        {
            gc = new GyroCustomization();
            InitializeComponent();
            gc.FinishGyro += OnFinishItem;
        }

        /// <summary>
        /// Constructor that takes in MainWindow to allow for switching of user controls
        /// </summary>
        /// <param name="main"></param>
        public MenuItemSelectionControl(MainWindow main)
        {
            ///Instancing each of the customization controls
            gc = new GyroCustomization();
            llc = new LibraLibationCustomization();
            sc = new SideCustomization();
            tc = new TeaCustomization();
            Tc = new TreatsCustomization();
            mainWindow = main;
            InitializeComponent();

            ///Adding event listeners to each customization control
            gc.FinishGyro += OnFinishItem;
            llc.FinishLL += OnFinishItem;
            tc.FinishTea += OnFinishItem;
            sc.FinishSide += OnFinishItem;
            Tc.FinishAI += OnFinishItem;
            

        }

        /// <summary>
        /// Click event handler for Leo Lamb Gyro Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeoButton_Click(object sender, RoutedEventArgs e)
        {
            LeoLambGyro leoOrder = new LeoLambGyro();
            gc.DataContext = leoOrder;
            gc.AddItem(leoOrder);
            mainWindow.ChangeControl(gc);
        }

        /// <summary>
        /// Click event handler for Scorpio Spicy Gyro Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScorpioButton_Click(object sender, RoutedEventArgs e)
        {
            ScorpioSpicyGyro scorpioOrder = new ScorpioSpicyGyro();
            gc.DataContext = scorpioOrder;
            gc.AddItem(scorpioOrder);
            mainWindow.ChangeControl(gc);
        }

        /// <summary>
        /// Click event handler for Virgo Classic Gyro Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VirgoButton_Click(object sender, RoutedEventArgs e)
        {
            VirgoClassicGyro virgoOrder = new VirgoClassicGyro();
            gc.DataContext = virgoOrder;
            gc.AddItem(virgoOrder);
            mainWindow.ChangeControl(gc);
        }

        /// <summary>
        /// Click event handler for Pisces Fish Dish Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicesButton_Click(object sender, RoutedEventArgs e)
        {
            PiscesFishDish picesOrder = new PiscesFishDish();
            OrderItems.Add(picesOrder);
            PropertyChanged?.Invoke(OrderItems, new PropertyChangedEventArgs("FishOrderItems"));
        }

        /// <summary>
        /// Click event handler for Aries Fries Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AriesButton_Click(object sender, RoutedEventArgs e)
        {
            AriesFries ariesOrder = new AriesFries();
            sc.DataContext = ariesOrder;
            sc.AddItem(ariesOrder);
            mainWindow.ChangeControl(sc);
        }

        /// <summary>
        /// Click event handler for Gemini Stuffed Grape Leaves Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeminiButton_Click(object sender, RoutedEventArgs e)
        {
            GeminiStuffedGrapeLeaves geminiOrder = new GeminiStuffedGrapeLeaves();
            sc.DataContext = geminiOrder;
            sc.AddItem(geminiOrder);
            mainWindow.ChangeControl(sc);
        }

        /// <summary>
        /// Click event handler for Sagittarius Greek Salad Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SagitButton_Click(object sender, RoutedEventArgs e)
        {
            SagittariusGreekSalad sagitOrder = new SagittariusGreekSalad();
            sc.DataContext = sagitOrder;
            sc.AddItem(sagitOrder);
            mainWindow.ChangeControl(sc);
        }

        /// <summary>
        /// Click event handler for Taurus Tabuleg Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TarusButton_Click(object sender, RoutedEventArgs e)
        {
            TaurusTabuleh taurusOrder = new TaurusTabuleh();
            sc.DataContext = taurusOrder;
            sc.AddItem(taurusOrder);
            mainWindow.ChangeControl(sc);
        }

        /// <summary>
        /// Click event handler for Aquarius Ice Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AquariusButton_Click(object sender, RoutedEventArgs e)
        {
            AquariusIce aquariusOrder = new AquariusIce();
            Tc.DataContext = aquariusOrder;
            Tc.AddItem(aquariusOrder);
            mainWindow.ChangeControl(Tc);
        }

        /// <summary>
        /// Click event handler for Cancer Halvla Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancerButton_Click(object sender, RoutedEventArgs e)
        {
            CancerHalvaCake cancerOrder = new CancerHalvaCake();
            OrderItems.Add(cancerOrder);
            PropertyChanged?.Invoke(OrderItems, new PropertyChangedEventArgs("CancerOrderItems"));
        }

        /// <summary>
        /// Click event handler for Libra Libation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LibraButton_Click(object sender, RoutedEventArgs e)
        {
            LibraLibation libraOrder = new LibraLibation();
            llc.DataContext = libraOrder;
            llc.AddItem(libraOrder);
            mainWindow.ChangeControl(llc);
        }

        /// <summary>
        /// Click event handler for Capricorn Moutain Tea Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CapricornButton_Click(object sender, RoutedEventArgs e)
        {
            CapricornMountainTea capricornOrder = new CapricornMountainTea();
            tc.DataContext = capricornOrder;
            tc.AddItem(capricornOrder);
            mainWindow.ChangeControl(tc);
        }


        /// <summary>
        /// Event handler for "Finish Item" button found within each customization control
        /// Raises property changed event for changes to the master order list OrderItems
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnFinishItem(object sender, EventArgs e)
        {
            if(sender is GyroCustomization _gc)
            {
                OrderItems.Add(_gc.Gyro);
                PropertyChanged?.Invoke(OrderItems, new PropertyChangedEventArgs("GyroOrderItems"));
            }

            if(sender is LibraLibationCustomization _llc)
            {
                OrderItems.Add(_llc.Drink);
                PropertyChanged?.Invoke(OrderItems, new PropertyChangedEventArgs("DrinkOrderItems"));
            }

            if(sender is TeaCustomization _cmt)
            {
                OrderItems.Add(_cmt.Drink);
                PropertyChanged?.Invoke(OrderItems, new PropertyChangedEventArgs("TeaOrderItems"));
            }

            if(sender is SideCustomization _sc)
            {
                OrderItems.Add(_sc.Side);
                PropertyChanged?.Invoke(OrderItems, new PropertyChangedEventArgs("SideOrderItems"));
            }

            if(sender is TreatsCustomization _tc)
            {
                OrderItems.Add(_tc.Ice);
                PropertyChanged?.Invoke(OrderItems, new PropertyChangedEventArgs("TreatOrderItems"));
            }

            mainWindow.ChangeControl(this);
        }

        public void CompleteOrder()
        {
            OrderItems.Clear();
        }

       

       


    }
}
