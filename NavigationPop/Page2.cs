using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationPop
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            var popPageButton = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Pop This Page"
            };

            popPageButton.Clicked += OnPopPageButtonClicked;

            Title = "Page 2";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    popPageButton
                }
            };
        }

        private void OnPopPageButtonClicked(object sender, EventArgs e)
        {
            //Task.Run(async () => await Navigation.PopAsync());
            //Task.Run(async () => await Navigation.PopAsync());
            //Task.Run(async () => await Navigation.PopAsync());
            //Task.Run(() => Navigation.PopAsync());
            Navigation.PopAsync();
            Navigation.PopAsync();
            Navigation.PopAsync();
        }
    }
}
