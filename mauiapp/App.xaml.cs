namespace mauiapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            //This code does not compile in maui, becusase of being obsolete
            //Properties.TryGetValue("test", out object value);
            //

            //This code works, but does not access my old properties
            var test = Preferences.Get("test", default(string));
        }
    }
}