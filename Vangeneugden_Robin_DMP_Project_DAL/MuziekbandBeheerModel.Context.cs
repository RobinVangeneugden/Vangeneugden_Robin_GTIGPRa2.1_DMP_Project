﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vangeneugden_Robin_DMP_Project_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MuziekbandEntities : DbContext
    {
        public MuziekbandEntities()
            : base("name=MuziekbandEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Groep> Groep { get; set; }
        public virtual DbSet<GroepOptreden> GroepOptreden { get; set; }
        public virtual DbSet<GroepRepetitie> GroepRepetitie { get; set; }
        public virtual DbSet<Instrument> Instrument { get; set; }
        public virtual DbSet<Lid> Lid { get; set; }
        public virtual DbSet<LidGroep> LidGroep { get; set; }
        public virtual DbSet<LidInstrument> LidInstrument { get; set; }
        public virtual DbSet<Locatie> Locatie { get; set; }
        public virtual DbSet<Optreden> Optreden { get; set; }
        public virtual DbSet<Repetitie> Repetitie { get; set; }
    }
}