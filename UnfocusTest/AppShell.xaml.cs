namespace UnfocusTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            var SplashPage = new FlyoutItem()
            {
                Title = "Doesnt work",
                

            };
            SplashPage.Items.Add(new ShellContent()
            {
                Route = "MainPage",
                ContentTemplate = new DataTemplate(typeof(MainPage)),

            });
            this.Items.Add(SplashPage);
            var VMPage = new FlyoutItem()
            {
                Title = "With ViewModel",


            };
            VMPage.Items.Add(new ShellContent()
            {
                Route = "EditorWithVmPage",
                ContentTemplate = new DataTemplate(typeof(EditorWithVmPage)),

            });
            this.Items.Add(VMPage);
        }
    }
}