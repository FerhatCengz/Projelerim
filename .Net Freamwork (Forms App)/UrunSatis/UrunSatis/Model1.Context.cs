﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrunSatis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SatisMagzaEntities : DbContext
    {
        public SatisMagzaEntities()
            : base("name=SatisMagzaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<Tbl_SatisUrun> Tbl_SatisUrun { get; set; }
        public virtual DbSet<Tbl_Image> Tbl_Image { get; set; }
        public virtual DbSet<TBL_URUNEKLE> TBL_URUNEKLE { get; set; }
    
        public virtual ObjectResult<Nullable<short>> KABANGETIR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<short>>("KABANGETIR");
        }
    
        public virtual ObjectResult<Nullable<int>> KABANGETiR2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("KABANGETiR2");
        }
    }
}
