using System;
using System.Collections.Generic;
using EF008.ReverseEngineeringNETCLI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF008.ReverseEngineeringNETCLI.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Speaker> Speakers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source = .; initial catalog = TechTalk; Integrated Security = SSPI; TrustServerCertificate = TRUE;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Events__3214EC073AAB355E");

            entity.HasOne(d => d.Speaker).WithMany(p => p.Events)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Events__SpeakerI__267ABA7A");
        });

        modelBuilder.Entity<Speaker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Speakers__3214EC0736C723DA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
