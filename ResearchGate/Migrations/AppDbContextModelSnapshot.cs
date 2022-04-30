﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResearchGate.Data;

namespace ResearchGate.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ResearchGate.Models.Auther", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Dept")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("Mobile")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uni")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authers");
                });

            modelBuilder.Entity("ResearchGate.Models.Auther_Paper", b =>
                {
                    b.Property<int>("AutherId")
                        .HasColumnType("int");

                    b.Property<int>("PaperId")
                        .HasColumnType("int");

                    b.HasKey("AutherId", "PaperId");

                    b.HasIndex("PaperId");

                    b.ToTable("Authers_Papers");
                });

            modelBuilder.Entity("ResearchGate.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ResearchGate.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("ResearchGate.Models.Paper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LikeId")
                        .HasColumnType("int");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("LikeId");

                    b.ToTable("Papers");
                });

            modelBuilder.Entity("ResearchGate.Models.Auther_Paper", b =>
                {
                    b.HasOne("ResearchGate.Models.Auther", "Auther")
                        .WithMany("Authers_Papers")
                        .HasForeignKey("AutherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResearchGate.Models.Paper", "Paper")
                        .WithMany("Authers_Papers")
                        .HasForeignKey("PaperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auther");

                    b.Navigation("Paper");
                });

            modelBuilder.Entity("ResearchGate.Models.Paper", b =>
                {
                    b.HasOne("ResearchGate.Models.Comment", "Comment")
                        .WithMany("Papers")
                        .HasForeignKey("CommentId");

                    b.HasOne("ResearchGate.Models.Like", "Like")
                        .WithMany("Papers")
                        .HasForeignKey("LikeId");

                    b.Navigation("Comment");

                    b.Navigation("Like");
                });

            modelBuilder.Entity("ResearchGate.Models.Auther", b =>
                {
                    b.Navigation("Authers_Papers");
                });

            modelBuilder.Entity("ResearchGate.Models.Comment", b =>
                {
                    b.Navigation("Papers");
                });

            modelBuilder.Entity("ResearchGate.Models.Like", b =>
                {
                    b.Navigation("Papers");
                });

            modelBuilder.Entity("ResearchGate.Models.Paper", b =>
                {
                    b.Navigation("Authers_Papers");
                });
#pragma warning restore 612, 618
        }
    }
}
