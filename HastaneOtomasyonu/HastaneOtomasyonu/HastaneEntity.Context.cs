﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneOtomasyonu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HastaneOtomasyonEntities : DbContext
    {
        public HastaneOtomasyonEntities()
            : base("name=HastaneOtomasyonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolumler> Bolumler { get; set; }
        public virtual DbSet<Doktorlar> Doktorlar { get; set; }
        public virtual DbSet<Hastalar> Hastalar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
