//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sepet
    {
        public string SepetID { get; set; }
        public string MüşteriID { get; set; }
        public string ÜrünID { get; set; }
        public string Adet { get; set; }
        public string ToplamFiyat { get; set; }
    
        public virtual Müşteriler Müşteriler { get; set; }
        public virtual Ürünler Ürünler { get; set; }
    }
}
