﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mifinca.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mifincaEntities : DbContext
    {
        public mifincaEntities()
            : base("name=mifincaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bodega> bodega { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<finca> finca { get; set; }
        public virtual DbSet<planilla> planilla { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<tarea> tarea { get; set; }
        public virtual DbSet<tipo_tarea> tipo_tarea { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}