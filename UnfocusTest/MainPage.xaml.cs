using Syncfusion.Maui.Toolkit.TextInputLayout;

namespace UnfocusTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
            SetView();

        }
        public void SetView()
        {
            var teststack = new StackLayout()
            {
                Orientation = StackOrientation.Vertical
            };

            var wrapper = new SfTextInputLayout()
            {
                Hint = "Prijs",
                HelperText = "Jouw prijs",
                LeadingViewPosition= ViewPosition.Inside,
                LeadingView = new Label() { Text = "💶",FontSize=20 },

                
            };

            var MyEditor = new Entry()
            {
               
               
                Keyboard = Keyboard.Numeric,
                
            };
            MyEditor.SetBinding(Entry.TextProperty, "Price");
            MyEditor.Unfocused += MyEditor_Unfocused;
            wrapper.Content = MyEditor;
            teststack.Children.Add(wrapper);
            var btn = new Button()
            {
                Text = "OK",
            };
            btn.SetBinding(Button.CommandProperty, "MyBreakPointCommand");
            teststack.Children.Add(btn);
            var MyScroll = new ScrollView()
            {
                Orientation = ScrollOrientation.Vertical
            };
            MyScroll.Content = teststack; 
            this.Content = MyScroll;
        }

        private void MyEditor_Unfocused(object sender, FocusEventArgs e)
        {
            var test = "hi";
            var test2 = "another hi";
        }
    }
}