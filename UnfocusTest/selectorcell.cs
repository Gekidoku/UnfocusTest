

namespace UnfocusTest;

public class selectorcell : DataTemplateSelector
{

DataTemplate MyTemplate;
public selectorcell(){
    this.MyTemplate = new DataTemplate(typeof(myCell));

}
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return MyTemplate;
    }
}
