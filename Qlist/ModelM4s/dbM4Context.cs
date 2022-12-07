using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Qlist.ModelM4s
{
    public partial class dbM4Context : DbContext
    {
        public dbM4Context()
        {
        }

        public dbM4Context(DbContextOptions<dbM4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<BizBatchingTrn> BizBatchingTrns { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<CompanyImage> CompanyImages { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<MasterBizType> MasterBizTypes { get; set; }
        public virtual DbSet<MasterCapabilityCat> MasterCapabilityCats { get; set; }
        public virtual DbSet<MasterCapabilityCatSub> MasterCapabilityCatSubs { get; set; }
        public virtual DbSet<MasterCountry> MasterCountries { get; set; }
        public virtual DbSet<MasterDistrict> MasterDistricts { get; set; }
        public virtual DbSet<MasterProvince> MasterProvinces { get; set; }
        public virtual DbSet<MasterRole> MasterRoles { get; set; }
        public virtual DbSet<MasterTambon> MasterTambons { get; set; }
        public virtual DbSet<MemberAddress> MemberAddresses { get; set; }
        public virtual DbSet<MemberBizType> MemberBizTypes { get; set; }
        public virtual DbSet<MemberCategory> MemberCategories { get; set; }
        public virtual DbSet<MemberContactPerson> MemberContactPeople { get; set; }
        public virtual DbSet<MemberMaster> MemberMasters { get; set; }
        public virtual DbSet<MemberPaymentTrn> MemberPaymentTrns { get; set; }
        public virtual DbSet<MemberProductService> MemberProductServices { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<TbPosition> TbPositions { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=119.59.114.151,10433;Initial Catalog=Tara_member;Persist Security Info=False;User ID=sa;Password=P@ssw0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Application");

                entity.Property(e => e.Application1)
                    .HasMaxLength(255)
                    .HasColumnName("Application");
            });

            modelBuilder.Entity<BizBatchingTrn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.MemberNo).HasMaxLength(10);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BizBatchingTrns)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Tara_Biz_Matching_Trans_Tara_Customer");

                entity.HasOne(d => d.MemberNoNavigation)
                    .WithMany(p => p.BizBatchingTrns)
                    .HasForeignKey(d => d.MemberNo)
                    .HasConstraintName("FK_Tara_Biz_Matching_Trans_Tara_Member");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BizBatchingTrns)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_BizBatchingTrns_MemberProductService");
            });

            modelBuilder.Entity<Certification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Certification");

                entity.Property(e => e.Certification1)
                    .HasMaxLength(255)
                    .HasColumnName("Certification");
            });

            modelBuilder.Entity<CompanyImage>(entity =>
            {
                entity.ToTable("CompanyImage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Logoimage).HasColumnType("image");

                entity.Property(e => e.MemberNo).HasMaxLength(10);

                entity.HasOne(d => d.MemberNoNavigation)
                    .WithMany(p => p.CompanyImages)
                    .HasForeignKey(d => d.MemberNo)
                    .HasConstraintName("FK_Tara_Company_Image_Tara_Member");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(13)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LineId)
                    .HasMaxLength(20)
                    .HasColumnName("LineID");

                entity.Property(e => e.MemberNo).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(20);
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Industry");

                entity.Property(e => e.Industry1)
                    .HasMaxLength(255)
                    .HasColumnName("Industry");
            });

            modelBuilder.Entity<MasterBizType>(entity =>
            {
                entity.ToTable("MasterBizType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BusinessType).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<MasterCapabilityCat>(entity =>
            {
                entity.ToTable("MasterCapabilityCat");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryCat)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.LastUpd).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasterCapabilityCatSub>(entity =>
            {
                entity.ToTable("MasterCapabilityCatSub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryCatId).HasColumnName("CategoryCatID");

                entity.Property(e => e.CategoryCatSub)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.LastUpd).HasColumnType("datetime");

                entity.HasOne(d => d.CategoryCat)
                    .WithMany(p => p.MasterCapabilityCatSubs)
                    .HasForeignKey(d => d.CategoryCatId)
                    .HasConstraintName("FK_MasterCapabilityCatSub_MasterCapabilityCat");
            });

            modelBuilder.Entity<MasterCountry>(entity =>
            {
                entity.ToTable("MasterCountry");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Country).HasMaxLength(100);
            });

            modelBuilder.Entity<MasterDistrict>(entity =>
            {
                entity.ToTable("MasterDistrict");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(100)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameTh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name_th");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.MasterDistricts)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_MasterDistrict_MasterProvince");
            });

            modelBuilder.Entity<MasterProvince>(entity =>
            {
                entity.ToTable("MasterProvince");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.GeographyId).HasColumnName("geography_id");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(100)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameTh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name_th");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MasterProvinces)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_MasterProvince_MasterCountry");
            });

            modelBuilder.Entity<MasterRole>(entity =>
            {
                entity.ToTable("MasterRole");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleFunction).HasMaxLength(150);

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<MasterTambon>(entity =>
            {
                entity.ToTable("MasterTambon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmphureId).HasColumnName("amphure_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(50)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameTh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_th");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.ZipCode).HasColumnName("zip_code");

                entity.HasOne(d => d.Amphure)
                    .WithMany(p => p.MasterTambons)
                    .HasForeignKey(d => d.AmphureId)
                    .HasConstraintName("FK_MasterTambon_MasterDistrict");
            });

            modelBuilder.Entity<MemberAddress>(entity =>
            {
                entity.ToTable("MemberAddress");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressNo).HasMaxLength(250);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.MemberNo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Moo).HasMaxLength(20);

                entity.Property(e => e.PostCode).HasMaxLength(10);

                entity.Property(e => e.Road).HasMaxLength(50);

                entity.Property(e => e.Soi).HasMaxLength(50);

                entity.Property(e => e.TambonId).HasColumnName("TambonID");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.WebSite).HasMaxLength(50);

                entity.HasOne(d => d.MemberNoNavigation)
                    .WithMany(p => p.MemberAddresses)
                    .HasForeignKey(d => d.MemberNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tara_Member_Address_Tara_Member");

                entity.HasOne(d => d.Tambon)
                    .WithMany(p => p.MemberAddresses)
                    .HasForeignKey(d => d.TambonId)
                    .HasConstraintName("FK_MemberAddress_MasterTambon");
            });

            modelBuilder.Entity<MemberBizType>(entity =>
            {
                entity.ToTable("MemberBizType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MemberBizTypeId).HasColumnName("MemberBizTypeID");

                entity.Property(e => e.MemberNo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.MemberBizTypeNavigation)
                    .WithMany(p => p.MemberBizTypes)
                    .HasForeignKey(d => d.MemberBizTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tara_Member_Type_tb_Member_Type_Master");

                entity.HasOne(d => d.MemberNoNavigation)
                    .WithMany(p => p.MemberBizTypes)
                    .HasForeignKey(d => d.MemberNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberBizType_MemberMaster");
            });

            modelBuilder.Entity<MemberCategory>(entity =>
            {
                entity.ToTable("MemberCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategorySubId).HasColumnName("CategorySubID");

                entity.Property(e => e.MemberNo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.CategorySub)
                    .WithMany(p => p.MemberCategories)
                    .HasForeignKey(d => d.CategorySubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberCategory_MasterCapabilityCatSub");

                entity.HasOne(d => d.MemberNoNavigation)
                    .WithMany(p => p.MemberCategories)
                    .HasForeignKey(d => d.MemberNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberCategory_MemberMaster");
            });

            modelBuilder.Entity<MemberContactPerson>(entity =>
            {
                entity.ToTable("MemberContactPerson");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaceBook).HasMaxLength(50);

                entity.Property(e => e.FirstNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("FirstNameEN");

                entity.Property(e => e.FirstNameTh)
                    .HasMaxLength(50)
                    .HasColumnName("FirstNameTH");

                entity.Property(e => e.LastNameEn)
                    .HasMaxLength(50)
                    .HasColumnName("LastNameEN");

                entity.Property(e => e.LastNameTh)
                    .HasMaxLength(50)
                    .HasColumnName("LastNameTH");

                entity.Property(e => e.LineId)
                    .HasMaxLength(50)
                    .HasColumnName("LineID");

                entity.Property(e => e.Linkedin).HasMaxLength(50);

                entity.Property(e => e.MemberNo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.MemberNoNavigation)
                    .WithMany(p => p.MemberContactPeople)
                    .HasForeignKey(d => d.MemberNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tara_Contact_Person_Tara_Member");
            });

            modelBuilder.Entity<MemberMaster>(entity =>
            {
                entity.HasKey(e => e.MemberNo)
                    .HasName("PK_Tara_Member");

                entity.ToTable("MemberMaster");

                entity.Property(e => e.MemberNo).HasMaxLength(10);

                entity.Property(e => e.CompanyNameEn)
                    .HasMaxLength(100)
                    .HasColumnName("CompanyNameEN");

                entity.Property(e => e.CompanyNameTh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CompanyNameTH");

                entity.Property(e => e.CompanyRegistrationNo).HasMaxLength(13);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EstablishYear).HasMaxLength(10);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Facebook).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsBoi).HasColumnName("IsBOI");

                entity.Property(e => e.MemberStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Member_StartDate");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.WebSite).HasMaxLength(100);
            });

            modelBuilder.Entity<MemberPaymentTrn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.MemberNo).HasMaxLength(10);

                entity.Property(e => e.PaymentReference).HasMaxLength(50);

                entity.Property(e => e.PaymentTotal).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MemberNoNavigation)
                    .WithMany(p => p.MemberPaymentTrns)
                    .HasForeignKey(d => d.MemberNo)
                    .HasConstraintName("FK_Tara_Payment_trans_Tara_Member");
            });

            modelBuilder.Entity<MemberProductService>(entity =>
            {
                entity.ToTable("MemberProductService");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemberNo).HasMaxLength(10);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProuductDescription).HasMaxLength(200);

                entity.HasOne(d => d.MemberNoNavigation)
                    .WithMany(p => p.MemberProductServices)
                    .HasForeignKey(d => d.MemberNo)
                    .HasConstraintName("FK_MemberProductService_MemberMaster");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("ProductImage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.ProductServiceId).HasColumnName("ProductServiceID");

                entity.HasOne(d => d.ProductService)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tara_Product_Image_Tara_Memeber_Product1");
            });

            modelBuilder.Entity<TbPosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Position");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostionName)
                    .HasMaxLength(150)
                    .HasColumnName("Postion_Name");

                entity.Property(e => e.Remark).HasMaxLength(150);
            });

            modelBuilder.Entity<Technology>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Technology");

                entity.Property(e => e.Application).HasMaxLength(255);

                entity.Property(e => e.Technology1)
                    .HasMaxLength(255)
                    .HasColumnName("Technology");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERS");

                entity.Property(e => e.ContactId).HasColumnName("Contact_ID");

                entity.Property(e => e.FgForceChangePw).HasColumnName("FG_FORCE_CHANGE_PW");

                entity.Property(e => e.FgPwNeverExpire).HasColumnName("FG_PW_NEVER_EXPIRE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(50)
                    .HasColumnName("Login_Name");

                entity.Property(e => e.MemberNo).HasMaxLength(10);

                entity.Property(e => e.NameLastName)
                    .HasMaxLength(50)
                    .HasColumnName("Name_LastName");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PwExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PW_EXPIRE_DATE");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Visible).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
