﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace museumProj.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tootEntities : DbContext
    {
        public tootEntities()
            : base("name=tootEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<catogery> catogeries { get; set; }
        public virtual DbSet<menument_images> menument_images { get; set; }
        public virtual DbSet<menument> menuments { get; set; }
        public virtual DbSet<place_images> place_images { get; set; }
        public virtual DbSet<place> places { get; set; }
        public virtual DbSet<places_cat> places_cat { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<gift> gifts { get; set; }
        public virtual DbSet<house> houses { get; set; }
    }
}
