using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Qlist.ModelM2s
{
    public partial class dbM2Context : DbContext
    {
        public dbM2Context()
        {
        }

        public dbM2Context(DbContextOptions<dbM2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<MemberAsgmtawardedHistory> MemberAsgmtawardedHistories { get; set; }
        public virtual DbSet<ProjectDocument> ProjectDocuments { get; set; }
        public virtual DbSet<ProjectHd> ProjectHds { get; set; }
        public virtual DbSet<ProjectHdhistory> ProjectHdhistories { get; set; }
        public virtual DbSet<ProjectRatypeTl> ProjectRatypeTls { get; set; }
        public virtual DbSet<ProjectRunNo> ProjectRunNos { get; set; }
        public virtual DbSet<ProjectSubMemberAsgmt> ProjectSubMemberAsgmts { get; set; }
        public virtual DbSet<ProjectSubProjectTl> ProjectSubProjectTls { get; set; }
        public virtual DbSet<ProjectSubProjectTlhistory> ProjectSubProjectTlhistories { get; set; }
        public virtual DbSet<RatypeMaster> RatypeMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=119.59.114.151;Initial Catalog=TarawebM2;Persist Security Info=False;User ID=sa;Password=Veer2519");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberAsgmtawardedHistory>(entity =>
            {
                entity.ToTable("MemberASGMTAwardedHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DateAwarded).HasColumnType("datetime");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MemberAssignmentId).HasColumnName("MemberAssignmentID");

                entity.HasOne(d => d.MemberAssignment)
                    .WithMany(p => p.MemberAsgmtawardedHistories)
                    .HasForeignKey(d => d.MemberAssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberASGMTAwardedHistory_ProjectSubMemberASGMT");
            });

            modelBuilder.Entity<ProjectDocument>(entity =>
            {
                entity.ToTable("ProjectDocument");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DocumentPath).IsRequired();

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.HasOne(d => d.ProjectSubProjectTl)
                    .WithMany(p => p.ProjectDocuments)
                    .HasForeignKey(d => d.ProjectSubProjectTlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectDocument_ProjectSubProjectTL");
            });

            modelBuilder.Entity<ProjectHd>(entity =>
            {
                entity.ToTable("ProjectHD");

                entity.HasIndex(e => new { e.ProjectHdrunNo, e.ProjectName }, "UK_ProjectHD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ContactInfo).IsRequired();

                entity.Property(e => e.CreateDated)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerInfo).IsRequired();

                entity.Property(e => e.PlanFinishDate).HasColumnType("date");

                entity.Property(e => e.PlanStartDate).HasColumnType("date");

                entity.Property(e => e.ProjectHdrunNo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("ProjectHDRunNo");

                entity.Property(e => e.ProjectHdstatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ProjectHDStatus");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProjectHdhistory>(entity =>
            {
                entity.ToTable("ProjectHDHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.ProjectHdid).HasColumnName("ProjectHDID");

                entity.Property(e => e.Remark).IsRequired();

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.ProjectHd)
                    .WithMany(p => p.ProjectHdhistories)
                    .HasForeignKey(d => d.ProjectHdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectHDHistory_ProjectHD");
            });

            modelBuilder.Entity<ProjectRatypeTl>(entity =>
            {
                entity.ToTable("ProjectRATypeTL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.Property(e => e.RatypeMasterId).HasColumnName("RATypeMasterID");

                entity.HasOne(d => d.ProjectSubProjectTl)
                    .WithMany(p => p.ProjectRatypeTls)
                    .HasForeignKey(d => d.ProjectSubProjectTlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRATypeTL_ProjectSubProjectTL");

                entity.HasOne(d => d.RatypeMaster)
                    .WithMany(p => p.ProjectRatypeTls)
                    .HasForeignKey(d => d.RatypeMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRATypeTL_RATypeMaster");
            });

            modelBuilder.Entity<ProjectRunNo>(entity =>
            {
                entity.ToTable("ProjectRunNo");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ProjectSubMemberAsgmt>(entity =>
            {
                entity.ToTable("ProjectSubMemberASGMT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Awarded).HasMaxLength(1);

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.HasOne(d => d.ProjectSubProjectTl)
                    .WithMany(p => p.ProjectSubMemberAsgmts)
                    .HasForeignKey(d => d.ProjectSubProjectTlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubMemberASGMT_ProjectSubProjectTL");
            });

            modelBuilder.Entity<ProjectSubProjectTl>(entity =>
            {
                entity.ToTable("ProjectSubProjectTL");

                entity.HasIndex(e => new { e.ProjectSubRunNo, e.ProjectSubName }, "UK_ProjectSubProjectTL")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateDated).HasColumnType("date");

                entity.Property(e => e.PlanFinishDate).HasColumnType("date");

                entity.Property(e => e.PlanStartDate).HasColumnType("date");

                entity.Property(e => e.ProjectHdid).HasColumnName("ProjectHDID");

                entity.Property(e => e.ProjectSubName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProjectSubRunNo)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.ProjectSubStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ProjectHd)
                    .WithMany(p => p.ProjectSubProjectTls)
                    .HasForeignKey(d => d.ProjectHdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubProjectTL_ProjectHD");
            });

            modelBuilder.Entity<ProjectSubProjectTlhistory>(entity =>
            {
                entity.ToTable("ProjectSubProjectTLHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.Property(e => e.Remark).IsRequired();

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.ProjectSubProjectTl)
                    .WithMany(p => p.ProjectSubProjectTlhistories)
                    .HasForeignKey(d => d.ProjectSubProjectTlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubProjectTLHistory_ProjectSubProjectTL");
            });

            modelBuilder.Entity<RatypeMaster>(entity =>
            {
                entity.ToTable("RATypeMaster");

                entity.HasIndex(e => e.Name, "UK_RATypeMaster")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
