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

namespace Lab4
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

        public class Donation
        {
            private double donation;
            private double expense = .17;
            private double afterExpense;
            private double totalExpense;


            public Donation(double donation, double afterExpense, double totalExpense)
            {
                this.donation = donation;
                this.afterExpense = afterExpense;
                this.totalExpense = totalExpense;
            }

            //Calculates 17% operating fees
            public double OperateExpense()
            {
                double calculation = donation * expense;
                afterExpense = donation - calculation;
                
                return afterExpense;
            }

            //Using a ref to modify total amount of donations recieved after operation costs are applied.
            public double TotalExpense(ref double totalDono)
            {
                return totalDono = totalExpense + afterExpense;
            }

        }





        private void donateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Donation donated = new Donation(Convert.ToDouble(donatedValue.Text), Convert.ToDouble(afterExpense.Text), Convert.ToDouble(totalValue.Text));
                double expensePaid = donated.OperateExpense();
                afterExpense.Text = expensePaid.ToString();
                double totalCalc = donated.TotalExpense(ref expensePaid);
                totalValue.Text = totalCalc.ToString();
                

            }
            catch(FormatException)
            {
                MessageBox.Show("Please input a donation.");
                
            }

        }
    }
}
