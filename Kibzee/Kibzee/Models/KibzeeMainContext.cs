using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kibzee.Models
{
    public partial class KibzeeMainContext : DbContext
    {
        public KibzeeMainContext()
        {
        }

        public KibzeeMainContext(DbContextOptions<KibzeeMainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<ContactDetails> ContactDetails { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Instruments> Instruments { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<UserInstruments> UserInstruments { get; set; }
        public virtual DbSet<UserPhotos> UserPhotos { get; set; }
        public virtual DbSet<UserPosts> UserPosts { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<ContactDetails>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.Property(e => e.ContactId)
                    .HasColumnName("contactID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AltEmail)
                    .HasColumnName("altEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AltPhone)
                    .HasColumnName("altPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<Friends>(entity =>
            {
                entity.HasKey(e => e.ConnectionId);

                entity.Property(e => e.ConnectionId)
                    .HasColumnName("connectionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FriendId).HasColumnName("friendID");

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<Instruments>(entity =>
            {
                entity.HasKey(e => e.InstId);

                entity.Property(e => e.InstId)
                    .HasColumnName("instID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GradeSchemaId).HasColumnName("gradeSchemaID");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentName)
                    .HasColumnName("instrumentName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Photos>(entity =>
            {
                entity.HasKey(e => e.PhotoId);

                entity.Property(e => e.PhotoId)
                    .HasColumnName("photoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasColumnName("caption")
                    .HasColumnType("text");

                entity.Property(e => e.DateUploaded)
                    .HasColumnName("dateUploaded")
                    .HasColumnType("date");

                entity.Property(e => e.FileName)
                    .HasColumnName("fileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoName)
                    .HasColumnName("photoName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.Property(e => e.PostId)
                    .HasColumnName("postID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NumLikes).HasColumnName("numLikes");

                entity.Property(e => e.PostContent)
                    .IsRequired()
                    .HasColumnName("postContent")
                    .HasColumnType("text");

                entity.Property(e => e.PostDate)
                    .HasColumnName("postDate")
                    .HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<UserInstruments>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.InstrumentId).HasColumnName("instrumentID");

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<UserPhotos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PhotoId).HasColumnName("photoID");

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<UserPosts>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PostId).HasColumnName("postID");

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
