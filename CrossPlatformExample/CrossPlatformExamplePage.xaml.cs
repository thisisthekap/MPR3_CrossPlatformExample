using Xamarin.Forms;
using CrossPlatformExample.Proxy;
using System;

namespace CrossPlatformExample
{
    public partial class CrossPlatformExamplePage : ContentPage
    {
        // The android simulator and devices have no access to localhost. Use your IP.
        private const string hostName = "localhost";

        public CrossPlatformExamplePage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtValueToSquare.Text, out int valueToSquare))
            {
                txtValueToSquare.Text = (await new CrossPlatformExampleClient(new Uri($"http://{hostname}:5000/")).SquareAsync(valueToSquare)).ToString();
            }
        }
    }
}
