﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AreaManager.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AreaManagerdbEntities : DbContext
    {
        public AreaManagerdbEntities()
            : base("name=AreaManagerdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<MUser> MUsers { get; set; }
        public virtual DbSet<ObjectLocation> ObjectLocations { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<Organize> Organizes { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
    }
}
