using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using CarPanelWithMobileApp.Common;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace CarPanelWithMobileApp
{
    public sealed partial class MainPage : Page
    {
        //private StreamSocket _socket;

        //private RfcommDeviceService _service;
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            var T = new SettingsDialog().ShowAsync();
        }

        private void ThanksButton_Click(object sender, RoutedEventArgs e)
        {
            var T = new SettingsDialog().ShowAsync();
        }

        private void EnableMusicCenterToggleButton_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MediaControl.Visibility =
                EnableMusicCenterToggleButton.IsEnabled ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}