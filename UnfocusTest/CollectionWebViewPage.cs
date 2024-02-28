using UnfocusTest;

namespace UnfocusTest;

public class CollectionWebViewPage : ContentPage
{
	public CollectionWebViewPage()
	{
		this.Title = "test";
		this.BindingContext = new MyCollectionViewModel();
		 var DashItems = new CollectionView()
            {
                FlowDirection = FlowDirection.RightToLeft,
                ItemTemplate = new selectorcell(),
                Margin = 0,
                VerticalOptions = LayoutOptions.Fill,
                ItemSizingStrategy = ItemSizingStrategy.MeasureAllItems,

            };
            DashItems.SetBinding(CollectionView.ItemsSourceProperty, "Model", BindingMode.TwoWay);
            Content = DashItems;
	}
}