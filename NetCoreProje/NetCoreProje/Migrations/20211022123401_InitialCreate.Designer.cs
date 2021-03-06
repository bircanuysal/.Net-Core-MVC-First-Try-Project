// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreProje.Contexts;

namespace NetCoreProje.Migrations
{
    [DbContext(typeof(NetCoreProjeContexts))]
    [Migration("20211022123401_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreProje.Entities.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("NetCoreProje.Entities.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("NetCoreProje.Entities.UrunKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.HasIndex("KategoriId", "UrunId")
                        .IsUnique();

                    b.ToTable("UrunKategori");
                });

            modelBuilder.Entity("NetCoreProje.Entities.UrunKategori", b =>
                {
                    b.HasOne("NetCoreProje.Entities.Kategori", "Kategori")
                        .WithMany("UrunKategoriler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetCoreProje.Entities.Urun", "Urun")
                        .WithMany("UrunKategoriler")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("NetCoreProje.Entities.Kategori", b =>
                {
                    b.Navigation("UrunKategoriler");
                });

            modelBuilder.Entity("NetCoreProje.Entities.Urun", b =>
                {
                    b.Navigation("UrunKategoriler");
                });
#pragma warning restore 612, 618
        }
    }
}
