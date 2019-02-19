using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIT_ui.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT_ui.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_OnCurrentPageChanged(object sender, EventArgs e)
        {
            this.Title = this.CurrentPage.Title;
        }

        private async void fatura_onclick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FaturaGecmisi());
        }


    }
}