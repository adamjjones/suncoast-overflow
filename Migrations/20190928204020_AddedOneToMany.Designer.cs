﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using suncoast_overflow;

namespace sdgreacttemplate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190928204020_AddedOneToMany")]
    partial class AddedOneToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("suncoast_overflow.Models.Answers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuestionId");

                    b.Property<int?>("Questionsid");

                    b.Property<string>("author");

                    b.Property<string>("content");

                    b.Property<DateTime>("date");

                    b.Property<int>("downvote");

                    b.Property<string>("title");

                    b.Property<int>("upvote");

                    b.HasKey("id");

                    b.HasIndex("Questionsid");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("suncoast_overflow.Models.Questions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.Property<string>("UserName");

                    b.Property<int>("downvote");

                    b.Property<int>("upvote");

                    b.HasKey("id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("suncoast_overflow.Models.Answers", b =>
                {
                    b.HasOne("suncoast_overflow.Models.Questions", "Questions")
                        .WithMany("Answers")
                        .HasForeignKey("Questionsid");
                });
#pragma warning restore 612, 618
        }
    }
}
