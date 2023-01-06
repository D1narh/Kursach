using MaimApp.Class;
using MaimApp.Class.MainProductC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using MaimApp.BLL;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Media.Imaging;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace MaimApp.Views
{
    /// <summary>
    /// Логика взаимодействия для MainProduct.xaml
    /// </summary>
    public partial class MainProduct : Window
    {
        private readonly Formatter _formatter = new Formatter();
        public MainProduct()
        {
            InitializeComponent();

            AirTickets.Background = new SolidColorBrush(Colors.Black) { Opacity = 0.3 };
            BusTickets.Background = new SolidColorBrush(Colors.Black) { Opacity = 0.3 };
            Hotels.Background = new SolidColorBrush(Colors.Black) { Opacity = 0.3 };
            Adventures.Background = new SolidColorBrush(Colors.Black) { Opacity = 0.3 };
        }

        private async Task GetAllSite()
        {
            var result = await _formatter.GetAddressesFromUrl(
                 "https://101hotels.com/api/hotel/search?r=0.1345066605085845&params=%7B%22city_ids%22%3A%5B2%5D%2C%22hotel_ids%22%3A%5B%5D%2C%22destination%22%3A%7B%7D%7D");
            //"https://101hotels.com/api/hotel/search?r=0.5406233108723135&params=%7B%22city_ids%22%3A%5B75%5D%2C%22hotel_ids%22%3A%5B%5D%2C%22destination%22%3A%7B%7D%7D" Астрахань id=75
            //"https://101hotels.com/api/hotel/search?r=0.8865264677573255&params=%7B%22city_ids%22%3A%5B2%5D%2C%22hotel_ids%22%3A%5B%5D%2C%22destination%22%3A%7B%7D%7D" Москва
        }

        public static string GetUserCountryByIp()
        {
            IpInfo ipInfo = new IpInfo();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io");
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }

            return ipInfo.Country;
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

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadProduct();

            Animation.BeginAnimation(Image.VisibilityProperty, null);
        }
        public async Task LoadProduct()
        {
            ViewProduct viewProduct = new ViewProduct();



           list.ItemsSource = await Task.Run(() => viewProduct.FillCatalog());
        }
    }
}
