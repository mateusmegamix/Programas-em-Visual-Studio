﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APK.DESKTOP.MODEL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tccEntities : DbContext
    {
        public tccEntities()
            : base("name=tccEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CadastroCliente> CadastroCliente { get; set; }
        public virtual DbSet<CadastroFesta> CadastroFesta { get; set; }
        public virtual DbSet<CadastroHotel> CadastroHotel { get; set; }
        public virtual DbSet<CadastroJogo> CadastroJogo { get; set; }
        public virtual DbSet<CadastroUsuario> CadastroUsuario { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
    }
}
