using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Movies_CQRS_Feb16.Models;

public partial class MoviesContext : DbContext
{
    public MoviesContext()
    {
    }

    public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//    => optionsBuilder.UseSqlServer("Data Source=IN3305444W1;Initial Catalog=Movies;trusted_connection=TRUE;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>(entity =>
        {
            entity.ToTable("genre");

            entity.Property(e => e.GenreId).HasColumnName("genreId");
            entity.Property(e => e.GenreName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("genreName");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("movie");

            entity.Property(e => e.MovieId).HasColumnName("movieId");
            entity.Property(e => e.GenreId).HasColumnName("genreId");
            entity.Property(e => e.MovieName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("movieName");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
