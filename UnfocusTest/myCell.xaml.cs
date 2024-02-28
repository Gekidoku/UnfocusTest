namespace UnfocusTest;

public partial class myCell : ContentView
{
	public myCell()
	{
		 InitializeComponent();

            var InstructiesAlarmFrame = new Border()
            {
                FlowDirection = FlowDirection.LeftToRight,
                
                VerticalOptions = LayoutOptions.FillAndExpand
            
            };

            var InstructionAlarmGrid = new Grid();
            InstructionAlarmGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100, GridUnitType.Star) });
            InstructionAlarmGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            var graybox = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                
            };
            var ObjInstructiesLabel = new Label()
            {
                
               
            };
            ObjInstructiesLabel.SetBinding(Label.TextProperty, "Header");
            graybox.Add(ObjInstructiesLabel);
            InstructionAlarmGrid.Add(graybox, 0, 0);
            InstructionAlarmGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });

            var MyHtmlView = new WebView() {
                VerticalOptions = LayoutOptions.FillAndExpand,
             
            };
            MyHtmlView.SetBinding(WebView.SourceProperty, "Source");
          
           


            var myborder = new Border()
            {
               
                 VerticalOptions = LayoutOptions.FillAndExpand
                
            };
            myborder.Content = MyHtmlView;
            InstructionAlarmGrid.Add(myborder, 0, 1);
            InstructiesAlarmFrame.Content = InstructionAlarmGrid;
            this.Content = InstructiesAlarmFrame;

	}
}