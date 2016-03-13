namespace TopCat.ViewController
{
    using GalaSoft.MvvmLight.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ViewModel;
    using UIKit;
    using Foundation;

    partial class MainMenuViewController: UITableViewController
    {
        private readonly List<Binding> _bindings = new List<Binding>();

        private MainMenuViewModel Vm
        {
            get
            {
                return Application.Locator.MainMenu;
            }
        }

        protected internal MainMenuViewController(IntPtr handle) : base(handle)
        {
            TableView.Source = new OrderMenuTableViewSource();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TableView.Source = Vm.OrderMenuTableViewSource;      
        }

    }
}
