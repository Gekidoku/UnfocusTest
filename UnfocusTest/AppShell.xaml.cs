
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

            var CollectionViewP = new FlyoutItem()
            {
                Title = "CollectionView",


            };
            CollectionViewP.Items.Add(new ShellContent()
            {
                Route = "CollectionViewPage",
                ContentTemplate = new DataTemplate(typeof(MainPage)),

            });
            this.Items.Add(SplashPage);


            var MenuI = new MenuItem()
            {
                Text = "SetMainPage",
               
            };
            MenuI.Clicked += MenuI_Clicked;
            this.Items.Add(MenuI);
        }

        private void MenuI_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new OnResumePlaceholderPage());
        }
    }
}