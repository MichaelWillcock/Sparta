using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CreatedDBtoCSharp
{
    public partial class Eng86Context : DbContext
    {
        public Eng86Context()
        {
        }

        public Eng86Context(DbContextOptions<Eng86Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Course1> Courses1 { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Location1> Locations1 { get; set; }
        public virtual DbSet<Stream> Streams { get; set; }
        public virtual DbSet<Stream1> Streams1 { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Trainee1> Trainees1 { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Trainer1> Trainers1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Eng86;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.AbreviatedName)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Abreviated_Name");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Course_Name");

                entity.Property(e => e.CourseType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Course_Type");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("End_Date");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("Start_Date");

                entity.Property(e => e.Trainer)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course1>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__Courses__C92D718796FBB6F1");

                entity.ToTable("Courses");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.AbreviatedName)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Abreviated_Name");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Course_Name");

                entity.Property(e => e.CourseType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Course_Type");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("End_Date");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("Start_Date");

                entity.Property(e => e.Stream)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trainer)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Reigion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location1>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__Location__E7FEA477545DDF60");

                entity.ToTable("Locations");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Reigion)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stream>(entity =>
            {
                entity.ToTable("Stream");

                entity.Property(e => e.StreamId).HasColumnName("StreamID");

                entity.Property(e => e.Stream1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Stream");
            });

            modelBuilder.Entity<Stream1>(entity =>
            {
                entity.HasKey(e => e.StreamId)
                    .HasName("PK__Streams__07C87AB27D71FDAE");

                entity.ToTable("Streams");

                entity.Property(e => e.StreamId).HasColumnName("StreamID");

                entity.Property(e => e.Stream)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trainee>(entity =>
            {
                entity.ToTable("Trainee");

                entity.Property(e => e.TraineeId).HasColumnName("TraineeID");

                entity.Property(e => e.Course)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Progress)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Trainer)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trainee1>(entity =>
            {
                entity.HasKey(e => e.TraineeId)
                    .HasName("PK__Trainees__3BA911AA1DADEC1C");

                entity.ToTable("Trainees");

                entity.Property(e => e.TraineeId).HasColumnName("TraineeID");

                entity.Property(e => e.Course)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Progress)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Trainer)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("Trainer");

                entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

                entity.Property(e => e.Course)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trainer1>(entity =>
            {
                entity.HasKey(e => e.TrainerId)
                    .HasName("PK__Trainers__366A1B9C416D4F1A");

                entity.ToTable("Trainers");

                entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

                entity.Property(e => e.Course)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
