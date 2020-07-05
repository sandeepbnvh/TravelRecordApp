using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
namespace TravelRecordApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);
            iconImage.Source = ImageSource.FromResource("TravelRecordApp.Assets.Images.plane.png", assembly);
        }

        private void  LoginButton_Clicked(object sender, EventArgs e)
        {
           bool isEmailEmpty= string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if(isEmailEmpty  ||isPasswordEmpty)
            {
                
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        [Obsolete]
        private void OpenBrowser(string url)
        {
            Device.OpenUri(new Uri(url));
        }
    }
}
