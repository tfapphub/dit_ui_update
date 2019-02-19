using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT_ui.Tabs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cart : ContentPage
	{
		public Cart ()
		{
			InitializeComponent ();
		}

	    private void Btn_güncelle_OnClicked(object sender, EventArgs e)
	    {
	        this.DisplayAlert("Güncelle", "Miktar Giriniz", "Güncelle");
	    }

	    private void Btn_sil_OnClicked(object sender, EventArgs e)
	    {
	        this.DisplayAlert("Sil", "Ürünü listenizden kaldırmak istediğinizden emin misiniz?", "Kaldır", "İptal");
	    }
	}
}