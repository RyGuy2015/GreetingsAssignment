using System;
using Xamarin.Forms;

namespace Greetings
{
    class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            Content = new Label
            {
                Text = "Greetings, Xamarin.Forms!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                //XAlign = TextAlignment.Center,
                //YAlign = TextAlignment.Center
                BackgroundColor = Color.Yellow,
                TextColor = Color.Blue
            };
            // Padding = new Thickness(0, 20, 0, 0);
            Padding = Device.OnPlatform(new Thickness(0, 20, 0, 0), new Thickness(0), new Thickness(0));
            
        }
       
    }
}
