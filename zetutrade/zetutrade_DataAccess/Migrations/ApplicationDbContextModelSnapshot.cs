﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zetutrade_DataAccess.Data;

namespace zetutrade_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("zetutrade_Model.Models.Blog", b =>
                {
                    b.Property<int>("blogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("blogPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("blogviews")
                        .HasColumnType("int");

                    b.Property<DateTime>("releasetime")
                        .HasColumnType("datetime2");

                    b.HasKey("blogID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("zetutrade_Model.Models.BlogText", b =>
                {
                    b.Property<int>("BlogTextID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blogDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("blogID")
                        .HasColumnType("int");

                    b.Property<string>("blogSpotText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogTextID");

                    b.HasIndex("blogID");

                    b.ToTable("BlogTexts");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Category", b =>
                {
                    b.Property<int>("categoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createtime")
                        .HasColumnType("datetime2");

                    b.HasKey("categoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("zetutrade_Model.Models.CategoryText", b =>
                {
                    b.Property<int>("categoryTextID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoryTextID");

                    b.HasIndex("categoryID");

                    b.ToTable("categoryTexts");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Contact", b =>
                {
                    b.Property<int>("contactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Offer", b =>
                {
                    b.Property<int>("offerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("discount")
                        .HasColumnType("float");

                    b.Property<double>("offerTotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("orderID")
                        .HasColumnType("int");

                    b.Property<double>("productPrice")
                        .HasColumnType("float");

                    b.Property<double>("productTotalPrice")
                        .HasColumnType("float");

                    b.Property<double>("shippingPrice")
                        .HasColumnType("float");

                    b.Property<int>("statusID")
                        .HasColumnType("int");

                    b.HasKey("offerID");

                    b.HasIndex("orderID");

                    b.HasIndex("statusID");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Order", b =>
                {
                    b.Property<int>("orderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("orderAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderNameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("orderNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ordertime")
                        .HasColumnType("datetime2");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("orderID");

                    b.HasIndex("productID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Product", b =>
                {
                    b.Property<int>("productID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("createtime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isinstock")
                        .HasColumnType("bit");

                    b.Property<string>("productPhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatetime")
                        .HasColumnType("datetime2");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("productID");

                    b.HasIndex("categoryID");

                    b.HasIndex("userID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("zetutrade_Model.Models.ProductText", b =>
                {
                    b.Property<int>("productTextID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productTextID");

                    b.HasIndex("productID");

                    b.ToTable("ProductTexts");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Status", b =>
                {
                    b.Property<int>("statusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("statusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusID");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Subscriber", b =>
                {
                    b.Property<int>("subsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("subsEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("subsID");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("zetutrade_Model.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("userEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userRoleID")
                        .HasColumnType("int");

                    b.Property<string>("userSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.HasIndex("userRoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("zetutrade_Model.Models.UserRole", b =>
                {
                    b.Property<int>("userRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("roleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userRoleID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("zetutrade_Model.Models.BlogText", b =>
                {
                    b.HasOne("zetutrade_Model.Models.Blog", "blog")
                        .WithMany("BlogTexts")
                        .HasForeignKey("blogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blog");
                });

            modelBuilder.Entity("zetutrade_Model.Models.CategoryText", b =>
                {
                    b.HasOne("zetutrade_Model.Models.Category", "category")
                        .WithMany("CategoryTexts")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Offer", b =>
                {
                    b.HasOne("zetutrade_Model.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zetutrade_Model.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("statusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Order", b =>
                {
                    b.HasOne("zetutrade_Model.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Product", b =>
                {
                    b.HasOne("zetutrade_Model.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zetutrade_Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("zetutrade_Model.Models.ProductText", b =>
                {
                    b.HasOne("zetutrade_Model.Models.Product", "product")
                        .WithMany("ProductTexts")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("zetutrade_Model.Models.User", b =>
                {
                    b.HasOne("zetutrade_Model.Models.UserRole", "userRole")
                        .WithMany()
                        .HasForeignKey("userRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userRole");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Blog", b =>
                {
                    b.Navigation("BlogTexts");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Category", b =>
                {
                    b.Navigation("CategoryTexts");
                });

            modelBuilder.Entity("zetutrade_Model.Models.Product", b =>
                {
                    b.Navigation("ProductTexts");
                });
#pragma warning restore 612, 618
        }
    }
}