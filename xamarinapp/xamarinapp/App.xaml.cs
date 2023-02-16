using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //here I set some example property
            Task.Run(async () =>
            {
                if (!Properties.ContainsKey("test"))
                {
                    Properties.Add("test", "test");
                    await SavePropertiesAsync();
                }
            });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
