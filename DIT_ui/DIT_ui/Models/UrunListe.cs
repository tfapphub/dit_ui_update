using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DIT_ui.Models
{
    public class UrunListe
    {
       public ObservableCollection<ÜrünModel> Urünler { get; set; }

        public UrunListe()
        {
            Urünler = new ObservableCollection<ÜrünModel>
            {
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
                new ÜrünModel {ürünAdi = "Eti Cin", aciklama = "24gr.", miktar = 2, fotoUrl = "https://cdn.cimri.io/image/240x240/eticingrportakallbiskvi_47585431.jpg"},
            };
        }
    }
}
