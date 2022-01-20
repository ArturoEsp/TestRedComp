using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEB_API.Models
{
    public partial class DB_ESCUELAContext : DbContext
    {
        public DB_ESCUELAContext()
        {
        }

        public DB_ESCUELAContext(DbContextOptions<DB_ESCUELAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<Calificacion> Calificacion { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Promedio> Promedio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6R4MVRJ\\SQLEXPRESS; Database=DB_ESCUELA;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasIndex(e => e.Cedula)
                    .HasName("UQ__Alumno__415B7BE5311495DF")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AulaId).HasColumnName("aula_id");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnName("cedula")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Aula)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.AulaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Alumno__aula_id__398D8EEE");
            });

            modelBuilder.Entity<Aula>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Edificio)
                    .IsRequired()
                    .HasColumnName("edificio")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasColumnName("numero")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Calificacion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AlumnoId).HasColumnName("alumno_id");

                entity.Property(e => e.Calificacion1)
                    .HasColumnName("calificacion")
                    .HasColumnType("decimal(2, 2)");

                entity.Property(e => e.MateriaId).HasColumnName("materia_id");

                entity.HasOne(d => d.Alumno)
                    .WithMany()
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calificac__alumn__48CFD27E");

                entity.HasOne(d => d.Materia)
                    .WithMany()
                    .HasForeignKey(d => d.MateriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calificac__mater__49C3F6B7");
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("UQ__Materia__72AFBCC6A5094CCE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfesorId).HasColumnName("profesor_id");

                entity.HasOne(d => d.Profesor)
                    .WithMany(p => p.Materia)
                    .HasForeignKey(d => d.ProfesorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Materia__profeso__4316F928");
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.HasIndex(e => e.Identificacion)
                    .HasName("UQ__Profesor__C196DEC75488837B")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AulaId).HasColumnName("aula_id");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasColumnName("identificacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Aula)
                    .WithMany(p => p.Profesor)
                    .HasForeignKey(d => d.AulaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Profesor__aula_i__3D5E1FD2");
            });

            modelBuilder.Entity<Promedio>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AlumnoId).HasColumnName("alumno_id");

                entity.Property(e => e.Promedio1)
                    .HasColumnName("promedio")
                    .HasColumnType("decimal(2, 2)");

                entity.HasOne(d => d.Alumno)
                    .WithMany()
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Promedio__alumno__3F466844");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
