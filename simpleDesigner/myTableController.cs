using Foundation;
using System;
using UIKit;

namespace simpleDesigner
{
    public partial class myTableController : UITableViewController
    {
        public myTableController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

             this.NavigationItem.Title = "Vegs";
            string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            TableView.Source = new TableSource(tableItems);
          
        }
    }
    
}