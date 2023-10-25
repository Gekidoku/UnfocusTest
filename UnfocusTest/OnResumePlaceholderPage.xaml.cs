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
           
            var MyScroll = new ScrollView()
            {
                Orientation = ScrollOrientation.Vertical
            };
            MyScroll.Content = MyLabel; 
            this.Content = MyScroll;
        }

       
    }
}