﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PeopleDBEntities : DbContext
    {
        public PeopleDBEntities()
            : base("name=PeopleDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Shagrir> Shagrirs { get; set; }
        public DbSet<Sharing> Sharings { get; set; }
    }
}
