using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BodyFat : ContentPage
	{
        public BodyFat()
        {
            InitializeComponent();
            AddStuff();
        }

        private void AddStuff()
        {
            BoxView boxView = new BoxView();
            boxView.HeightRequest = 100;
            boxView.WidthRequest = 100;
            boxView.HorizontalOptions = LayoutOptions.Center;
            boxView.VerticalOptions = LayoutOptions.Center;
            boxView.Color = Color.Red;

            slContent.Children.Add(boxView);
        }

        private void btnTest_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TestPage1());

        }
    }
}