using Xamarin.Forms;

namespace Bit.App
{
    public class App : Application
    {
        public App()
        {
            MainPage = new HomePage();
        }
    }

    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Content = new Label { Text = "Hello" };
        }
    }
}
