﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXWebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BIBLIOTECAEntities : DbContext
    {
        public BIBLIOTECAEntities()
            : base("name=BIBLIOTECAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BIBLIOTECA> BIBLIOTECA { get; set; }
        public virtual DbSet<LIBRO> LIBRO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}