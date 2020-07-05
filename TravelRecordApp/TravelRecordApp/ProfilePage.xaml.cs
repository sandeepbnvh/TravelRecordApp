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
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            var assembly = typeof(ProfilePage);
            ic_boy.Source = ImageSource.FromResource("TravelRecordApp.Assets.Images.ic_boy.png", assembly);
        }
        public override string ToString()
        {
            return this.Title;
        }

      
    }
}