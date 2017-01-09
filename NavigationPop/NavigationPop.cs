using System;

using Xamarin.Forms;

namespace NavigationPop
{
    public class App : Application
    {
        public App()
        {
            var nextPageButton = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Next Page"
            };

            nextPageButton.Clicked += OnNextPageButtonClicked;

            // The root page of your application
            var content = new ContentPage
            {
                Title = "NavigationPop",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Root page. Click below."
                        },
                        nextPageButton
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            MainPage.Navigation.PushAsync(new Page2());
        }
    }
}
