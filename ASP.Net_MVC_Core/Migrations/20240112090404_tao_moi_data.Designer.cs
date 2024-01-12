﻿// <auto-generated />
using System;
using ASP.Net_MVC_Core.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.Net_MVC_Core.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20240112090404_tao_moi_data")]
    partial class tao_moi_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.Net_MVC_Core.Models.Address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("district_id")
                        .HasColumnType("int");

                    b.Property<string>("district_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("province_id")
                        .HasColumnType("int");

                    b.Property<string>("province_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("ward_id")
                        .HasColumnType("int");

                    b.Property<string>("ward_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("D_ADDRESS");
                });

            modelBuilder.Entity("ASP.Net_MVC_Core.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("address_id")
                        .HasColumnType("int");

                    b.Property<int?>("addressid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("cccd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("student_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("addressid");

                    b.ToTable("D_STUDENT");
                });

            modelBuilder.Entity("ASP.Net_MVC_Core.Models.StudentMark", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("mark")
                        .HasColumnType("decimal(2,2)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studentid")
                        .HasColumnType("int");

                    b.Property<string>("subject_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("subjectid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("studentid");

                    b.HasIndex("subjectid");

                    b.ToTable("D_STUDENT_MARK");
                });

            modelBuilder.Entity("ASP.Net_MVC_Core.Models.Subject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("updated_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("D_SUBJECT");
                });

            modelBuilder.Entity("ASP.Net_MVC_Core.Models.Student", b =>
                {
                    b.HasOne("ASP.Net_MVC_Core.Models.Address", "address")
                        .WithMany()
                        .HasForeignKey("addressid");

                    b.Navigation("address");
                });

            modelBuilder.Entity("ASP.Net_MVC_Core.Models.StudentMark", b =>
                {
                    b.HasOne("ASP.Net_MVC_Core.Models.Student", "student")
                        .WithMany("StudentMarks")
                        .HasForeignKey("studentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.Net_MVC_Core.Models.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectid");

                    b.Navigation("student");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("ASP.Net_MVC_Core.Models.Student", b =>
                {
                    b.Navigation("StudentMarks");
                });
#pragma warning restore 612, 618
        }
    }
}
