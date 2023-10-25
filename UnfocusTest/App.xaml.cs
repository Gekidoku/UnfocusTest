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

            //Variant one
            // MainPage = new AppShell();

            //Variant two
            MainPage = new NavigationPage(new OnResumePlaceholderPage());

            
            //Variant Three
            //MainThread.BeginInvokeOnMainThread(async () =>
            //{
            //    //Uncomment to make variant three work
            //    //await Task.Delay(100);
            //    MainPage = new NavigationPage(new OnResumePlaceholderPage());
            //});
        }

    }
}