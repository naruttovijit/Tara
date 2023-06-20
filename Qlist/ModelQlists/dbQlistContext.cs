using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class dbQlistContext : DbContext
    {
        public dbQlistContext()
        {
        }

        public dbQlistContext(DbContextOptions<dbQlistContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QlContact> QlContacts { get; set; }
        public virtual DbSet<QlCustomer> QlCustomers { get; set; }
        public virtual DbSet<QlEvent> QlEvents { get; set; }
        public virtual DbSet<QlMemberAsgmtawardedHistory> QlMemberAsgmtawardedHistories { get; set; }
        public virtual DbSet<QlProjectDocument> QlProjectDocuments { get; set; }
        public virtual DbSet<QlProjectHd> QlProjectHds { get; set; }
        public virtual DbSet<QlProjectHdcontact> QlProjectHdcontacts { get; set; }
        public virtual DbSet<QlProjectHdhistory> QlProjectHdhistories { get; set; }
        public virtual DbSet<QlProjectRatypeTl> QlProjectRatypeTls { get; set; }
        public virtual DbSet<QlProjectRunNo> QlProjectRunNos { get; set; }
        public virtual DbSet<QlProjectSubContact> QlProjectSubContacts { get; set; }
        public virtual DbSet<QlProjectSubMemberAsgmt> QlProjectSubMemberAsgmts { get; set; }
        public virtual DbSet<QlProjectSubProjectTl> QlProjectSubProjectTls { get; set; }
        public virtual DbSet<QlProjectSubProjectTlhistory> QlProjectSubProjectTlhistories { get; set; }
        public virtual DbSet<QlRatypeMaster> QlRatypeMasters { get; set; }
        public virtual DbSet<QlTicket> QlTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=119.59.105.70;Initial Catalog=Tara_Qlist;Persist Security Info=False;User ID=sa;Password=P@55w0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QlContact>(entity =>
            {
                entity.ToTable("QL_Contact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.IsSi).HasColumnName("IsSI");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.QlContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_Customer");
            });

            modelBuilder.Entity<QlCustomer>(entity =>
            {
                entity.ToTable("QL_Customer");

                entity.HasIndex(e => e.CompanyName, "UK_Customer")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Facebook).HasMaxLength(150);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Telephone).HasMaxLength(20);

                entity.Property(e => e.Website).HasMaxLength(150);
            });

            modelBuilder.Entity<QlEvent>(entity =>
            {
                entity.ToTable("QL_Event");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TargetDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QlMemberAsgmtawardedHistory>(entity =>
            {
                entity.ToTable("QL_MemberASGMTAwardedHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DateAwarded).HasColumnType("datetime");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemberAssignmentId).HasColumnName("MemberAssignmentID");

                entity.HasOne(d => d.MemberAssignment)
                    .WithMany(p => p.QlMemberAsgmtawardedHistories)
                    .HasForeignKey(d => d.MemberAssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberASGMTAwardedHistory_ProjectSubMemberASGMT");
            });

            modelBuilder.Entity<QlProjectDocument>(entity =>
            {
                entity.ToTable("QL_ProjectDocument");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DocumentPath).IsRequired();

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.HasOne(d => d.ProjectSubProjectTl)
                    .WithMany(p => p.QlProjectDocuments)
                    .HasForeignKey(d => d.ProjectSubProjectTlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectDocument_ProjectSubProjectTL");
            });

            modelBuilder.Entity<QlProjectHd>(entity =>
            {
                entity.ToTable("QL_ProjectHD");

                entity.HasIndex(e => new { e.ProjectHdrunNo, e.ProjectName }, "UK_ProjectHD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateDated)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

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

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.QlProjectHds)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ProjectHD_Customer");
            });

            modelBuilder.Entity<QlProjectHdcontact>(entity =>
            {
                entity.ToTable("QL_ProjectHDContact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.ProjectHdid).HasColumnName("ProjectHDID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.QlProjectHdcontacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectHDContact_Contact");

                entity.HasOne(d => d.ProjectHd)
                    .WithMany(p => p.QlProjectHdcontacts)
                    .HasForeignKey(d => d.ProjectHdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectHDContact_ProjectHD");
            });

            modelBuilder.Entity<QlProjectHdhistory>(entity =>
            {
                entity.ToTable("QL_ProjectHDHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.ProjectHdid).HasColumnName("ProjectHDID");

                entity.Property(e => e.Remark).IsRequired();

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProjectHd)
                    .WithMany(p => p.QlProjectHdhistories)
                    .HasForeignKey(d => d.ProjectHdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectHDHistory_ProjectHD");
            });

            modelBuilder.Entity<QlProjectRatypeTl>(entity =>
            {
                entity.ToTable("QL_ProjectRATypeTL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.Property(e => e.RatypeMasterId).HasColumnName("RATypeMasterID");

                entity.HasOne(d => d.ProjectSubProjectTl)
                    .WithMany(p => p.QlProjectRatypeTls)
                    .HasForeignKey(d => d.ProjectSubProjectTlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRATypeTL_ProjectSubProjectTL");

                entity.HasOne(d => d.RatypeMaster)
                    .WithMany(p => p.QlProjectRatypeTls)
                    .HasForeignKey(d => d.RatypeMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRATypeTL_RATypeMaster");
            });

            modelBuilder.Entity<QlProjectRunNo>(entity =>
            {
                entity.ToTable("QL_ProjectRunNo");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<QlProjectSubContact>(entity =>
            {
                entity.ToTable("QL_ProjectSubContact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.ProjectSubId).HasColumnName("ProjectSubID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.QlProjectSubContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubContact_Contact");

                entity.HasOne(d => d.ProjectSub)
                    .WithMany(p => p.QlProjectSubContacts)
                    .HasForeignKey(d => d.ProjectSubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubContact_ProjectSubProjectTL");
            });

            modelBuilder.Entity<QlProjectSubMemberAsgmt>(entity =>
            {
                entity.ToTable("QL_ProjectSubMemberASGMT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Awarded).HasMaxLength(1);

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.HasOne(d => d.ProjectSubProjectTl)
                    .WithMany(p => p.QlProjectSubMemberAsgmts)
                    .HasForeignKey(d => d.ProjectSubProjectTlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubMemberASGMT_ProjectSubProjectTL");
            });

            modelBuilder.Entity<QlProjectSubProjectTl>(entity =>
            {
                entity.ToTable("QL_ProjectSubProjectTL");

                entity.HasIndex(e => new { e.ProjectSubRunNo, e.ProjectSubName }, "UK_ProjectSubProjectTL")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateDated)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

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
                    .WithMany(p => p.QlProjectSubProjectTls)
                    .HasForeignKey(d => d.ProjectHdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubProjectTL_ProjectHD");
            });

            modelBuilder.Entity<QlProjectSubProjectTlhistory>(entity =>
            {
                entity.ToTable("QL_ProjectSubProjectTLHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.ProjectSubProjectTlid).HasColumnName("ProjectSubProjectTLID");

                entity.Property(e => e.Remark).IsRequired();

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProjectSubProjectTl)
                    .WithMany(p => p.QlProjectSubProjectTlhistories)
                    .HasForeignKey(d => d.ProjectSubProjectTlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSubProjectTLHistory_ProjectSubProjectTL");
            });

            modelBuilder.Entity<QlRatypeMaster>(entity =>
            {
                entity.ToTable("QL_RATypeMaster");

                entity.HasIndex(e => e.Name, "UK_RATypeMaster")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<QlTicket>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_Ticket");

                entity.ToTable("QL_Ticket");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedId).HasColumnName("CreatedID");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.ResolvedId).HasColumnName("ResolvedID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TargetDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
