// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagementApplication.Data;

#nullable disable

namespace SchoolManagementApplication.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolManagementApplication.Models.Module", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CodeSector")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.HasIndex("CodeSector");

                    b.ToTable("modules", (string)null);
                });

            modelBuilder.Entity("SchoolManagementApplication.Models.Sector", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("sectors", (string)null);
                });

            modelBuilder.Entity("SchoolManagementApplication.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CodeSector")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CodeSector");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("SchoolManagementApplication.Models.Module", b =>
                {
                    b.HasOne("SchoolManagementApplication.Models.Sector", "Sector")
                        .WithMany("Modules")
                        .HasForeignKey("CodeSector")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("SchoolManagementApplication.Models.Student", b =>
                {
                    b.HasOne("SchoolManagementApplication.Models.Sector", "Sector")
                        .WithMany("Students")
                        .HasForeignKey("CodeSector")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("SchoolManagementApplication.Models.Sector", b =>
                {
                    b.Navigation("Modules");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
