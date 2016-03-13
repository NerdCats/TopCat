namespace TopCat.ViewModel
{
    using GalaSoft.MvvmLight;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ViewController;
    using UIKit;

    public class MainMenuViewModel : ViewModelBase
    {
        public const string OrderMenuTableViewSourcePropertyName = "OrderMenuTableViewSource";
        private UITableViewSource _orderMenuTableViewSource = null;
        public UITableViewSource OrderMenuTableViewSource
        {
            get
            {
                return _orderMenuTableViewSource;
            }

            set
            {
                Set(ref _orderMenuTableViewSource, value);
            }
        }

        public MainMenuViewModel()
        {
            OrderMenuTableViewSource = new OrderMenuTableViewSource();
        }
    }
}
