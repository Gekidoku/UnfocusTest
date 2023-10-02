namespace UnfocusTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override void OnResume()
        {
            base.OnResume();
            LogoutUser();
        }
        public static void LogoutUser()
        {
            App.Current.MainPage = new AppShell();
        }
    }
}