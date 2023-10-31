namespace UnfocusTest;

public partial class CollectionViewPage : ContentPage
{
	public CollectionViewPage()
	{
		InitializeComponent();
		this.BindingContext = new CollectionViewModel();
	}
}