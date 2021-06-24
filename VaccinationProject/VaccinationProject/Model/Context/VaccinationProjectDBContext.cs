using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VaccinationProject.Context
{
    public partial class VaccinationProjectDBContext : DbContext
    {
        public VaccinationProjectDBContext()
        {
        }

        public VaccinationProjectDBContext(DbContextOptions<VaccinationProjectDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booth> Booths { get; set; }
        public virtual DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<PriorityGroup> PriorityGroups { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }
        public virtual DbSet<VaccinationProcess> VaccinationProcesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=VaccinationProjectDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Booth>(entity =>
            {
                entity.ToTable("BOOTH");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerBooth)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChronicDisease>(entity =>
            {
                entity.ToTable("CHRONIC_DISEASE");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ChronicDisease1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ChronicDisease");

                entity.Property(e => e.DuiCitizen)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Dui_Citizen");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.ChronicDiseases)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHRONIC_D__Dui_C__4CA06362");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__C0317D90E225FF92");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdManager).HasColumnName("Id_Manager");

                entity.Property(e => e.IdPriorityGroup).HasColumnName("Id_PriorityGroup");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__Id_Mana__4BAC3F29");

                entity.HasOne(d => d.IdPriorityGroupNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdPriorityGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__Id_Prio__4AB81AF0");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("MANAGER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTypeEmployee).HasColumnName("Id_TypeEmployee");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTypeEmployeeNavigation)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.IdTypeEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MANAGER__Id_Type__46E78A0C");
            });

            modelBuilder.Entity<PriorityGroup>(entity =>
            {
                entity.ToTable("PRIORITY_GROUP");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PriorityGroup1)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("PriorityGroup");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasKey(e => new { e.IdManager, e.IdBooth })
                    .HasName("PK__REGISTER__0C8393A5333FD3B2");

                entity.ToTable("REGISTER");

                entity.Property(e => e.IdManager).HasColumnName("Id_Manager");

                entity.Property(e => e.IdBooth).HasColumnName("Id_Booth");

                entity.Property(e => e.DateLogin).HasColumnType("datetime");

                entity.HasOne(d => d.IdBoothNavigation)
                    .WithMany(p => p.Registers)
                    .HasForeignKey(d => d.IdBooth)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTER__Id_Boo__49C3F6B7");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Registers)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTER__Id_Man__48CFD27E");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("RESERVATION");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateReservation).HasColumnType("datetime");

                entity.Property(e => e.DuiCitizen)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Dui_Citizen");

                entity.Property(e => e.VaccinationPlace)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RESERVATI__Dui_C__4D94879B");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("SIDE_EFFECTS");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SideEffect1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SideEffect");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.ToTable("TYPE_EMPLOYEE");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TypeEmployee1)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TypeEmployee");
            });

            modelBuilder.Entity<VaccinationProcess>(entity =>
            {
                entity.ToTable("VACCINATION_PROCESS");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateSecondDose)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_SecondDose");

                entity.Property(e => e.DateVaccination).HasColumnType("datetime");

                entity.Property(e => e.DatewWaitingQueue).HasColumnType("datetime");

                entity.Property(e => e.IdReservation).HasColumnName("Id_Reservation");

                entity.Property(e => e.IdSideEffects).HasColumnName("Id_SideEffects");

                entity.Property(e => e.PlaceSecondDose)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Place_SecondDose");

                entity.Property(e => e.TimeSideEffects).HasColumnName("Time_SideEffects");

                entity.HasOne(d => d.IdReservationNavigation)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.IdReservation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__Id_Re__4F7CD00D");

                entity.HasOne(d => d.IdSideEffectsNavigation)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.IdSideEffects)
                    .HasConstraintName("FK__VACCINATI__Id_Si__4E88ABD4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
