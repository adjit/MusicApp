using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MusicApp.Models
{
    public partial class MusicAppContext : DbContext
    {
        public MusicAppContext()
        {
        }

        public MusicAppContext(DbContextOptions<MusicAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MusicApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Albums>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasColumnName("Album_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArtistId).HasColumnName("Artist_id");

                entity.Property(e => e.CoverImage)
                    .HasColumnName("Cover_Image")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfRatings).HasColumnName("Number_of_Ratings");

                entity.Property(e => e.Rating).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RecordLabel)
                    .IsRequired()
                    .HasColumnName("Record_Label")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("Release_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Review)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("Albums_Artist_id_FK");
            });

            modelBuilder.Entity<Artists>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtistName)
                    .IsRequired()
                    .HasColumnName("Artist_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Songs>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlbumId).HasColumnName("Album_id");

                entity.Property(e => e.ArtistId).HasColumnName("Artist_id");

                entity.Property(e => e.SongLength).HasColumnName("Song_Length");

                entity.Property(e => e.SongName)
                    .IsRequired()
                    .HasColumnName("Song_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SongNumber).HasColumnName("Song_Number");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Songs_Album_id_FK");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Songs_Artist_id_FK");
            });
        }
    }
}
