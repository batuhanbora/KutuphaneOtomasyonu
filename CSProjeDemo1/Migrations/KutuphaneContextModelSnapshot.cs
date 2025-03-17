﻿// <auto-generated />
using CSProjeDemo1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSProjeDemo1.Migrations
{
    [DbContext(typeof(KutuphaneContext))]
    partial class KutuphaneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CSProjeDemo1.Entities.Uye", b =>
                {
                    b.Property<int>("UyeNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UyeNo"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UyeNo");

                    b.ToTable("Uyeler");
                });

            modelBuilder.Entity("CSProjeDemo1.Interfaces.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("KitapDurumu")
                        .HasColumnType("int");

                    b.Property<int?>("UyeNo")
                        .HasColumnType("int");

                    b.Property<int>("YayinYili")
                        .HasColumnType("int");

                    b.Property<string>("Yazar")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("UyeNo");

                    b.ToTable("Kitap");

                    b.HasDiscriminator().HasValue("Kitap");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CSProjeDemo1.Entities.KitapBilim", b =>
                {
                    b.HasBaseType("CSProjeDemo1.Interfaces.Kitap");

                    b.HasDiscriminator().HasValue("KitapBilim");
                });

            modelBuilder.Entity("CSProjeDemo1.Entities.KitapRoman", b =>
                {
                    b.HasBaseType("CSProjeDemo1.Interfaces.Kitap");

                    b.HasDiscriminator().HasValue("KitapRoman");
                });

            modelBuilder.Entity("CSProjeDemo1.Entities.KitapTarih", b =>
                {
                    b.HasBaseType("CSProjeDemo1.Interfaces.Kitap");

                    b.HasDiscriminator().HasValue("KitapTarih");
                });

            modelBuilder.Entity("CSProjeDemo1.Interfaces.Kitap", b =>
                {
                    b.HasOne("CSProjeDemo1.Entities.Uye", "Uye")
                        .WithMany("OduncAlinanKitaplar")
                        .HasForeignKey("UyeNo");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("CSProjeDemo1.Entities.Uye", b =>
                {
                    b.Navigation("OduncAlinanKitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
