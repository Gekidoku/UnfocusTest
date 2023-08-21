namespace UnfocusTest
{
    public partial class EditorWithVmPage : ContentPage
    {
        int count = 0;

        public EditorWithVmPage()
        {
            InitializeComponent();
            this.BindingContext = new MyEditorViewModel();
            SetView();
        }
        public void SetView()
        {
            var mystack = new StackLayout();
            var MyEditor = new Editor()
            {
               
                MaximumHeightRequest = 60
            };
            MyEditor.SetBinding(Editor.TextProperty, "MyTextValue");
            MyEditor.SetBinding(Editor.IsFocusedProperty, "IsUnFocused");
            mystack.Add(MyEditor);

            var myDummy = new Switch()
            {

            };
            mystack.Add(myDummy);
            var MyScroll = new ScrollView()
            {
                Orientation = ScrollOrientation.Vertical
            };
            MyScroll.Content = mystack; 
            this.Content = MyScroll;
        }

        
    }
}