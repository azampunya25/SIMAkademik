﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIMAkademik.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AKADEMIKEntities : DbContext
    {
        public AKADEMIKEntities()
            : base("name=AKADEMIKEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLM_AGAMA> TBLM_AGAMA { get; set; }
        public virtual DbSet<TBLM_DESA> TBLM_DESA { get; set; }
        public virtual DbSet<TBLM_DOSEN> TBLM_DOSEN { get; set; }
        public virtual DbSet<TBLM_FAKULTAS> TBLM_FAKULTAS { get; set; }
        public virtual DbSet<TBLM_GOLDAR> TBLM_GOLDAR { get; set; }
        public virtual DbSet<TBLM_JURUSAN> TBLM_JURUSAN { get; set; }
        public virtual DbSet<TBLM_KARYAWAN> TBLM_KARYAWAN { get; set; }
        public virtual DbSet<TBLM_KECAMATAN> TBLM_KECAMATAN { get; set; }
        public virtual DbSet<TBLM_KMTK> TBLM_KMTK { get; set; }
        public virtual DbSet<TBLM_KOTA> TBLM_KOTA { get; set; }
        public virtual DbSet<TBLM_MATAKULIAH> TBLM_MATAKULIAH { get; set; }
        public virtual DbSet<TBLM_PROVINSI> TBLM_PROVINSI { get; set; }
        public virtual DbSet<TBLM_SEX> TBLM_SEX { get; set; }
        public virtual DbSet<TBLM_NEGARA> TBLM_NEGARA { get; set; }
        public virtual DbSet<TBLM_PROGRAM> TBLM_PROGRAM { get; set; }
        public virtual DbSet<TBLM_SATUSMAHASISWA> TBLM_SATUSMAHASISWA { get; set; }
        public virtual DbSet<TBLM_STATUSSIPIL> TBLM_STATUSSIPIL { get; set; }
        public virtual DbSet<TBLM_WARGANEGARA> TBLM_WARGANEGARA { get; set; }
        public virtual DbSet<TBLM_MAHASISWA> TBLM_MAHASISWA { get; set; }
    }
}
