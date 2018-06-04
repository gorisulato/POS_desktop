﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class POS_Entities : DbContext
    {
        public POS_Entities()
            : base("name=Point_Of_SalesEntities")
        {
        }

        public POS_Entities(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<P_Colour> P_Colour { get; set; }
        public virtual DbSet<TSalesDetail> TSalesDetails { get; set; }
        public virtual DbSet<TInventory> TInventories { get; set; }
        public virtual DbSet<PCustomer> PCustomers { get; set; }
        public virtual DbSet<PPaymentType> PPaymentTypes { get; set; }
        public virtual DbSet<TSale> TSales { get; set; }
        public virtual DbSet<TRole> TRoles { get; set; }
        public virtual DbSet<TUser> TUsers { get; set; }
        public virtual DbSet<PSupplier> PSuppliers { get; set; }
        public virtual DbSet<TPurchaseOrder> TPurchaseOrders { get; set; }
        public virtual DbSet<TPurchaseOrderDetail> TPurchaseOrderDetails { get; set; }
        public virtual DbSet<TReceiveingDetail> TReceiveingDetails { get; set; }
        public virtual DbSet<TReceiveingStock> TReceiveingStocks { get; set; }
    }
}
