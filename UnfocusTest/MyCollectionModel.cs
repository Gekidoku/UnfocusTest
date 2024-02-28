namespace UnfocusTest;

public class MyCollectionModel
{
    public string HtmlString {get;set;}
    public string Header {get;set;}
    public HtmlWebViewSource Source
        {
            get
            {
                var item = new HtmlWebViewSource()
                {
                    Html = HtmlString,
                    
                };
                return item;
            }
        }

}
