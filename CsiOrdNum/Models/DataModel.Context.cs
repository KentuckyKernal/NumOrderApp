﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsiOrdNum.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Table_1> Table_1 { get; set; }
    
        public virtual ObjectResult<Order01> GetOrder01()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order01>("GetOrder01");
        }
    
        public virtual ObjectResult<Order02> GetOrder02()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order02>("GetOrder02");
        }
    }
}
