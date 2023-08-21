namespace UnfocusTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            SetView();
        }
        public void SetView()
        {
            var MyEditor = new Editor()
            {
               
                MaximumHeightRequest = 60
            };
            MyEditor.Unfocused += MyEditor_Unfocused;
            var MyScroll = new ScrollView()
            {
                Orientation = ScrollOrientation.Vertical
            };
            MyScroll.Content = MyEditor; 
            this.Content = MyScroll;
        }

        private void MyEditor_Unfocused(object sender, FocusEventArgs e)
        {
            var test = "hi";
            var test2 = "another hi";
        }
    }
}