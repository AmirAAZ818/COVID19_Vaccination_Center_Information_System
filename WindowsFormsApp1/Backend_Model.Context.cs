﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllForms
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Vaccine_Project_dbEntities : DbContext
    {
        public Vaccine_Project_dbEntities()
            : base("name=Vaccine_Project_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Login_Table> Login_Table { get; set; }
        public virtual DbSet<Patient_Table> Patient_Table { get; set; }
        public virtual DbSet<Vaccine_Table> Vaccine_Table { get; set; }
    }
}