﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sensors_with_entity_framework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_EntityEntities : DbContext
    {
        public DB_EntityEntities()
            : base("name=DB_EntityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MeasurementUnits> MeasurementUnits { get; set; }
        public virtual DbSet<Sensors> Sensors { get; set; }
        public virtual DbSet<SensorTypes> SensorTypes { get; set; }
    }
}
