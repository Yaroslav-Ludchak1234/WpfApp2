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

namespace WpfApp2
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

        private void btnRezalt_Click(object sender, RoutedEventArgs e)
        {
            int usd; 
            double k; 
            double uhy; 
            int cost = 100;
            k = Convert.ToDouble(TextKurs.Text);
            usd = Convert.ToInt32(TextUSD.Text);            
            if (Convert.ToString(RezaltCombo.Text) == "Пластик") cost = 100;
            if (Convert.ToString(RezaltCombo.Text) == "Залізо") cost = 150;
            if (Convert.ToString(RezaltCombo.Text) == "Алюміній") cost = 200;
            uhy = usd * k * cost;
            Rezalt.Text = "Розмір "+ usd.ToString("n") + "X" + k.ToString("n") + "Ціна : " + cost.ToString() + "Сума :" + uhy.ToString();
        }
    }
}
