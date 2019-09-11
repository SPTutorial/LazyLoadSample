using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LazyLoadSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void ListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            (BindingContext as MainPageViewModel).LoadMoreItems(e.Item as MyData);
        }
    }
}
