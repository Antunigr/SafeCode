﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SafeCode.Models;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(ContextQuest))]
    [Migration("20230415100852_Voltando")]
    partial class Voltando
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SafeCode.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Android")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Api")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BancoDeDados")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cloud")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Csharp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Css")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Html")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Java")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Javascript")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kotlin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NodeJs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Php")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Python")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("React")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ruby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoriesModel");
                });

            modelBuilder.Entity("SafeCode.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuestionModel");
                });
#pragma warning restore 612, 618
        }
    }
}