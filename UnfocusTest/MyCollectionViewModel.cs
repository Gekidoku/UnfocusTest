using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace UnfocusTest;

public class MyCollectionViewModel : INotifyCollectionChanged
{
    public ObservableCollection<MyCollectionModel> Model {get;set;}= new ObservableCollection<MyCollectionModel>();

    public MyCollectionViewModel()
    {
        var mylist = new List<MyCollectionModel>(); 
        mylist.Add(new MyCollectionModel()
        {
            Header = "TestHeader",
            HtmlString = "<div style=\"font-size:22;font-family:Roboto, sans-serif;color:black\" ><br/><b>Na een aantal zaken die zijn voorgevallen graag extra aandacht voor de opvolging, lees de aangepaste instucties!!</b><br/></div>",         
        });
        mylist.Add(new MyCollectionModel()
        {
            Header = "TestHeaderTwo",
            HtmlString = @"<div style=""font-size:22;font-family:Roboto, sans-serif;color:black""><p><strong>Tijden dat Name gebeld dient te worden:</strong></p><p>- Ma t/m za van 18:00 tot 09:00 uur</p> <p>- Zondag 24/7</p> <p> </p> <p>Name wordt ook gebeld bij:</p> <ul> <li><span style=""font-size: 1em;"">Geen gehoor van onderstaande nummers</span></li> <li><span style=""font-size: 1em;"">Meerdere alarmen tegelijk</span></li> <li><span style=""font-size: 1em;"">Op verzoek van één van de onderstaande contactpersonen:</span></li> </ul> <ol> <li>Name</li> <li>Name</li> <li>Name </li> </ol></div>"
            
            });
            Model = new ObservableCollection<MyCollectionModel>(mylist);


    }
    public event NotifyCollectionChangedEventHandler CollectionChanged;
}
