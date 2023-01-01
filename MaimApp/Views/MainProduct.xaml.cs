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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace MaimApp.Views
{
    /// <summary>
    /// Логика взаимодействия для MainProduct.xaml
    /// </summary>
    public partial class MainProduct : Window
    {
        public MainProduct()
        {
            InitializeComponent();

            AirTickets.Background = new SolidColorBrush(Colors.Black) { Opacity = 0.3 };
            BusTickets.Background = new SolidColorBrush(Colors.Black) { Opacity = 0.3 };
            Hotels.Background = new SolidColorBrush(Colors.Black) { Opacity = 0.3 };
            Adventures.Background = new SolidColorBrush(Colors.Black) { Opacity = 0.3 };
        }

        private void AirTickets_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationEnter(AirTickets);
        }

        private void AirTickets_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationLeave(AirTickets);
        }

        private void BusTickets_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationEnter(BusTickets);
        }

        private void BusTickets_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationLeave(BusTickets);
        }

        private void Adventures_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationEnter(Adventures);
        }

        private void Adventures_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationLeave(Adventures);
        }

        private void Hotels_MouseEnter(object sender, MouseEventArgs e)
        {
            AnimationEnter(Hotels);
        }

        private void Hotels_MouseLeave(object sender, MouseEventArgs e)
        {
            AnimationLeave(Hotels);
        }
        public void AnimationEnter(Button name)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.To = 140;
            anim.Duration = TimeSpan.FromSeconds(0.1);
            name.BeginAnimation(WidthProperty, anim);
        }
        public void AnimationLeave(Button name)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.To = 130;
            anim.Duration = TimeSpan.FromSeconds(0.1);
            name.BeginAnimation(WidthProperty, anim);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            if (ComboBoxGrid.Visibility == Visibility.Hidden)
            {
                ComboBoxGrid.Visibility = Visibility.Visible;
                anim.To = 145;
                anim.Duration = TimeSpan.FromSeconds(0.25);
                ComboBoxGrid.BeginAnimation(HeightProperty, anim);
            }
            else
            {
                anim.To = 0;
                anim.Duration = TimeSpan.FromSeconds(0.1);
                ComboBoxGrid.BeginAnimation(HeightProperty, anim);
                ComboBoxGrid.Visibility = Visibility.Hidden;
            }
        }
    }
}
