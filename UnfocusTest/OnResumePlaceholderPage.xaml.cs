using Microsoft.Maui.Controls.PlatformConfiguration;

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
               
                Text = "I will now click the button. this switches the mainpage to a shell page. then i will press a flyoutitem and the app will freeze with no message in the terminal"
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