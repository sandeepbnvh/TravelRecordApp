using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage: ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            var assembly = typeof(SignUpPage);
            iconImage.Source = ImageSource.FromResource("TravelRecordApp.Assets.Images.handshake.png", assembly);

        }

        private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

       
    }
}