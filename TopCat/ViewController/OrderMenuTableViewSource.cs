namespace TopCat.ViewController
{
    using System;
    using Foundation;
    using UIKit;
    using System.Collections.Generic;

    internal class OrderMenuTableViewSource : UITableViewSource
    {
        List<string> orderItems;
        string cellIdentifier = "MainMenuTableCell";

        public OrderMenuTableViewSource()
        {
            orderItems = new List<string>();
            orderItems.Add("Fetch Food");
            orderItems.Add("Fetch CNG");
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            string item = orderItems[indexPath.Row];

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            }

            cell.TextLabel.Text = item;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return orderItems.Count;
        }
    }
}