﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dcm.EntityModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CrmEntities : DbContext
    {
        public CrmEntities()
            : base("name=CrmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<crm_kurumlar> crm_kurumlar { get; set; }
        public virtual DbSet<crm_bireyler> crm_bireyler { get; set; }
        public virtual DbSet<ref_crm_project_types> ref_crm_project_types { get; set; }
        public virtual DbSet<crm_bireyler_kurumlar_v> crm_bireyler_kurumlar_v { get; set; }
        public virtual DbSet<crm_projects> crm_projects { get; set; }
    }
}