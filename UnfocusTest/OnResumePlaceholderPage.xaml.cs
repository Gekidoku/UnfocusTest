namespace UnfocusTest
{
    public partial class OnResumePlaceholderPage : ContentPage
    {
        int count = 0;

        public OnResumePlaceholderPage()
        {
            InitializeComponent();
            SetView();
        }
        public void SetView()
        {
            var MyLabel = new Label()
            {
               
                Text = "Now bring the app to the background and then back to the foreground. You'll notice a crash on onresume"
            };
             var MyButton = new Button(){
                Text = "switchmain"
             };
             MyButton.Clicked += (sender, e) => {
                App.Current.MainPage = new AppShell();
             };
             var stack = new StackLayout();
             stack.Add(MyLabel);
             stack.Add(MyButton);

            var MyScroll = new ScrollView()
            {
                Orientation = ScrollOrientation.Vertical
            };
            MyScroll.Content = stack; 
            this.Content = MyScroll;
        }

       
    }
}