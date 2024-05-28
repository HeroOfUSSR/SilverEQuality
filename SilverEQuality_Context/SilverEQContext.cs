using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SilverEQuality_Context.Models;

namespace SilverEQuality_Context
{
    public partial class SilverEQContext : DbContext
    {
        public SilverEQContext()
        {
        }

        public SilverEQContext(DbContextOptions<SilverEQContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Check> Checks { get; set; } = null!;
        public virtual DbSet<DecimalNumber> DecimalNumbers { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Norm> Norms { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Part> Parts { get; set; } = null!;
        public virtual DbSet<PartNecessary> PartNecessaries { get; set; } = null!;
        public virtual DbSet<Priority> Priorities { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<SilverRequest> SilverRequests { get; set; } = null!;
        public virtual DbSet<SilverType> SilverTypes { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;


        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DDO84UQ; Database=SilverEQ; User ID=ae; Password=ae");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Check>(entity =>
            {
                entity.HasKey(e => e.IdCheck);

                entity.ToTable("Check");

                entity.Property(e => e.IdCheck).HasColumnName("ID_Check");

                entity.Property(e => e.AmountCheck).HasColumnName("Amount_Check");

                entity.Property(e => e.CoverageCheck)
                    .HasColumnType("decimal(10, 5)")
                    .HasColumnName("Coverage_Check");

                entity.Property(e => e.DateCheck)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Check");

                entity.Property(e => e.DecimalCheck).HasColumnName("Decimal_Check");

                entity.Property(e => e.DepartmentCheck).HasColumnName("Department_Check");

                entity.Property(e => e.NormCheck)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("Norm_Check");

                entity.Property(e => e.NumberCheck)
                    .HasMaxLength(50)
                    .HasColumnName("Number_Check");

                entity.Property(e => e.OrderCheck).HasColumnName("Order_Check");

                entity.Property(e => e.SilverTypeCheck).HasColumnName("SilverType_Check");

                entity.HasOne(d => d.DecimalCheckNavigation)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => d.DecimalCheck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Check_DecimalNumber");

                entity.HasOne(d => d.OrderCheckNavigation)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => d.OrderCheck)
                    .HasConstraintName("FK_Check_Order");

                entity.HasOne(d => d.DecimalCheckNavigation)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => d.DepartmentCheck)
                    .HasConstraintName("FK_Check_Department");

                entity.HasOne(d => d.SilverTypeCheckNavigation)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => d.SilverTypeCheck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Check_SilverType");
            });

            modelBuilder.Entity<DecimalNumber>(entity =>
            {
                entity.HasKey(e => e.IdDecimal)
                    .HasName("PK_Norm");

                entity.ToTable("DecimalNumber");

                entity.Property(e => e.IdDecimal).HasColumnName("ID_Decimal");

                entity.Property(e => e.TitleDecimal)
                    .HasMaxLength(50)
                    .HasColumnName("Title_Decimal");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.CodeDepartment);

                entity.ToTable("Department");

                entity.Property(e => e.CodeDepartment)
                    .ValueGeneratedNever()
                    .HasColumnName("Code_Department");

                entity.Property(e => e.IsAtWorkDepartment).HasColumnName("IsAtWork_Department");
            });

            modelBuilder.Entity<Norm>(entity =>
            {
                entity.HasKey(e => e.IdNorm)
                    .HasName("PK_Norm_1");

                entity.ToTable("Norm");

                entity.Property(e => e.IdNorm)
                    .HasColumnName("ID_Norm");

                entity.Property(e => e.DecimalNorm).HasColumnName("Decimal_Norm");

                entity.Property(e => e.DepartmentNorm).HasColumnName("Department_Norm");

                entity.Property(e => e.SilverTypeNorm).HasColumnName("SilverType_Norm");

                entity.Property(e => e.TitleNorm)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("Title_Norm");

                entity.HasOne(d => d.DecimalNormNavigation)
                    .WithMany(p => p.Norms)
                    .HasForeignKey(d => d.DecimalNorm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Norm_DecimalNumber");

                entity.HasOne(d => d.SilverTypeNormNavigation)
                    .WithMany(p => p.Norms)
                    .HasForeignKey(d => d.SilverTypeNorm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Norm_SilverType");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("Order");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("ID_Order");

                entity.Property(e => e.AppointedOrder).HasColumnName("Appointed_Order");

                entity.Property(e => e.DateEndOrder)
                    .HasColumnType("datetime")
                    .HasColumnName("DateEnd_Order");

                entity.Property(e => e.DateOrder)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Order");

                entity.Property(e => e.DescOrder)
                    .HasMaxLength(50)
                    .HasColumnName("Desc_Order");

                entity.Property(e => e.ManufacturerOrder).HasColumnName("Manufacturer_Order");

                entity.Property(e => e.PaymentOrder)
                    .HasColumnType("money")
                    .HasColumnName("Payment_Order");

                entity.Property(e => e.PriorityOrder).HasColumnName("Priority_Order");

                entity.Property(e => e.StatusOrder).HasColumnName("Status_Order");

                entity.HasOne(d => d.AppointedOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AppointedOrder)
                    .HasConstraintName("FK_Order_User");

                entity.HasOne(d => d.PriorityOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PriorityOrder)
                    .HasConstraintName("FK_Order_Priority");

                entity.HasOne(d => d.StatusOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Status");

                entity.HasOne(d => d.ManufacturerOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ManufacturerOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Manufacturer");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasKey(e => e.IdPart);

                entity.ToTable("Part");

                entity.Property(e => e.IdPart)
                    .HasColumnName("ID_Part");

                entity.Property(e => e.CostPart)
                    .HasColumnType("money")
                    .HasColumnName("Cost_Part");

                entity.Property(e => e.DecimalPart).HasColumnName("Decimal_Part");

                entity.Property(e => e.ImagePart).HasColumnName("Image_Part");

                entity.Property(e => e.WeightPart)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("Weight_Part");

                entity.HasOne(d => d.DecimalPartNavigation)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.DecimalPart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Part_DecimalNumber");
            });

            modelBuilder.Entity<PartNecessary>(entity =>
            {
                entity.HasKey(e => e.IdNecessary);

                entity.ToTable("PartNecessary");

                entity.Property(e => e.IdNecessary)
                    .HasColumnName("ID_Necessary");

                entity.Property(e => e.AmountNecessary).HasColumnName("Amount_Necessary");

                entity.Property(e => e.OrderNecessary).HasColumnName("Order_Necessary");

                entity.Property(e => e.PartNecessary1).HasColumnName("Part_Necessary");

                entity.HasOne(d => d.OrderNecessaryNavigation)
                    .WithMany(p => p.PartNecessaries)
                    .HasForeignKey(d => d.OrderNecessary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartNecessary_Order");

                entity.HasOne(d => d.PartNecessary1Navigation)
                    .WithMany(p => p.PartNecessaries)
                    .HasForeignKey(d => d.PartNecessary1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartNecessary_Part");
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.HasKey(e => e.IdPriority);

                entity.ToTable("Priority");

                entity.Property(e => e.IdPriority)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Priority");

                entity.Property(e => e.TitlePriority)
                    .HasMaxLength(50)
                    .HasColumnName("Title_Priority");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(e => e.IdManufacturer);

                entity.ToTable("Manufacturer");

                entity.Property(e => e.IdManufacturer)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Manufacturer");

                entity.Property(e => e.NameManufacturer)
                    .HasMaxLength(80)
                    .HasColumnName("Name_Manufacturer");

                entity.Property(e => e.ImageManufacturer)
                    .HasColumnType("varbinary")
                    .HasColumnName("Image_Manufacturer");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("Role");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Role");

                entity.Property(e => e.TitleRole)
                    .HasMaxLength(50)
                    .HasColumnName("Title_Role");
            });

            modelBuilder.Entity<SilverRequest>(entity =>
            {
                entity.HasKey(e => e.IdRequest);

                entity.ToTable("SilverRequest");

                entity.Property(e => e.IdRequest)
                    .HasColumnName("ID_Request");

                entity.Property(e => e.AmountRequest).HasColumnName("Amount_Request");

                entity.Property(e => e.CostRequest)
                    .HasColumnType("money")
                    .HasColumnName("Cost_Request");

                entity.Property(e => e.PriorityRequest).HasColumnName("Priority_Request");

                entity.Property(e => e.SilverTypeRequest).HasColumnName("SilverType_Request");

                entity.Property(e => e.UserRequest).HasColumnName("User_Request");

                entity.HasOne(d => d.PriorityRequestNavigation)
                    .WithMany(p => p.SilverRequests)
                    .HasForeignKey(d => d.PriorityRequest)
                    .HasConstraintName("FK_SilverRequest_Priority");

                entity.HasOne(d => d.SilverTypeRequestNavigation)
                    .WithMany(p => p.SilverRequests)
                    .HasForeignKey(d => d.SilverTypeRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SilverRequest_SilverType");

                entity.HasOne(d => d.UserRequestNavigation)
                    .WithMany(p => p.SilverRequests)
                    .HasForeignKey(d => d.UserRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SilverRequest_User");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.IdComment);

                entity.ToTable("Comment");

                entity.Property(e => e.IdComment)
                    .HasColumnName("ID_Comment");

                entity.Property(e => e.TextComment)
                    .HasColumnName("Text_Comment")
                    .HasMaxLength(100);

                entity.Property(e => e.DateComment)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Comment");

                entity.Property(e => e.UserComment).HasColumnName("User_Comment");

                entity.Property(e => e.OrderComment).HasColumnName("Order_Comment");

                entity.HasOne(d => d.UserCommentNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserComment)
                    .HasConstraintName("FK_Comment_User");

                entity.HasOne(d => d.OrderCommentNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.OrderComment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Order");

            });

            modelBuilder.Entity<SilverType>(entity =>
            {
                entity.HasKey(e => e.CodeSilverType);

                entity.ToTable("SilverType");

                entity.Property(e => e.CodeSilverType).HasColumnName("Code_SilverType");

                entity.Property(e => e.AmountSilverType).HasColumnName("Amount_SilverType");

                entity.Property(e => e.CostPerKgSilverType)
                    .HasColumnType("money")
                    .HasColumnName("CostPerKG_SilverType");

                entity.Property(e => e.ImageSilverType)
                    .HasColumnType("varbinary")
                    .HasColumnName("Image_SilverType");
   
                entity.Property(e => e.TitleSilverType)
                    .HasMaxLength(60)
                    .HasColumnName("Title_SilverType");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.ToTable("Status");

                entity.Property(e => e.IdStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Status");

                entity.Property(e => e.TitleStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Title_Status");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_User");

                entity.Property(e => e.DateOfBirthUser)
                    .HasColumnType("date")
                    .HasColumnName("DateOfBirth_User");

                entity.Property(e => e.DepartmentUser).HasColumnName("Department_User");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(50)
                    .HasColumnName("Email_User");

                entity.Property(e => e.FullnameUser)
                    .HasMaxLength(80)
                    .HasColumnName("Fullname_User");

                entity.Property(e => e.LoginUser)
                    .HasMaxLength(50)
                    .HasColumnName("Login_User");

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(30)
                    .HasColumnName("Password_User");

                entity.Property(e => e.PhoneUser)
                    .HasMaxLength(12)
                    .HasColumnName("Phone_User"); 

                entity.Property(e => e.AvatarUser)
                    .HasColumnType("varbinary")
                    .HasColumnName("Avatar_User");

                entity.Property(e => e.RoleUser).HasColumnName("Role_User");

                entity.HasOne(d => d.DepartmentUserNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepartmentUser)
                    .HasConstraintName("FK_User_Department");

                entity.HasOne(d => d.RoleUserNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
