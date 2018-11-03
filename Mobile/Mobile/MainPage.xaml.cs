using Android.Bluetooth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Java.Lang;
using Java.Util;
using Xamarin.Forms;
using Exception = System.Exception;

namespace Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var adapter = BluetoothAdapter.DefaultAdapter;
            if (adapter == null)
                throw new Exception("No Bluetooth adapter found.");

            if (!adapter.IsEnabled)
                throw new Exception("Bluetooth adapter is not enabled.");

            var device = (from bd in adapter.BondedDevices
                where bd.Name == "PROFYEV"
                select bd).FirstOrDefault();

            if (device == null)
            {
                var devices = (from bd in adapter.BondedDevices
                    select bd).ToArray();
            }
            else
            {
                var _socket = device.CreateRfcommSocketToServiceRecord(UUID.FromString("00001101-0000-1000-8000-00805f9b34fb"));

                await _socket.ConnectAsync();

                try
                {
                    var outStream = _socket.OutputStream;
                    var message = new Java.Lang.String("Hello!");
                    var msgBuffer = message.GetBytes();
                    outStream.Write(msgBuffer, 0, msgBuffer.Length);
                }
                catch (Exception exception)
                {
                }

                //var rssi = _socket.RemoteDevice.;
            }
        }
    }
}
