﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PetShopEntities : DbContext
    {
        public PetShopEntities()
            : base("name=PetShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kargo_Firmaları> Kargo_Firmaları { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Markalar> Markalar { get; set; }
        public virtual DbSet<Müşteri_Adresleri> Müşteri_Adresleri { get; set; }
        public virtual DbSet<Müşteriler> Müşteriler { get; set; }
        public virtual DbSet<Sepet> Sepet { get; set; }
        public virtual DbSet<SiparişDetayları> SiparişDetayları { get; set; }
        public virtual DbSet<Siparişler> Siparişler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ülke> Ülke { get; set; }
        public virtual DbSet<Ürünler> Ürünler { get; set; }
        public virtual DbSet<ÜrünMarka> ÜrünMarka { get; set; }
        public virtual DbSet<ÜrünÖzellikleri> ÜrünÖzellikleri { get; set; }
    }
}
