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
    
    public partial class ÜrünMarka
    {
        public string ÜrünMarkaID { get; set; }
        public string ÜrünID { get; set; }
        public string MarkaID { get; set; }
    
        public virtual Markalar Markalar { get; set; }
        public virtual Ürünler Ürünler { get; set; }
    }
}
