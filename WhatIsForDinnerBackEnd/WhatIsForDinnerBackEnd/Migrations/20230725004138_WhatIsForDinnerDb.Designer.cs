﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhatIsForDinnerBackEnd.Models;

#nullable disable

namespace WhatIsForDinnerBackEnd.Migrations
{
    [DbContext(typeof(WhatIsForDinnerDbContext))]
    [Migration("20230725004138_WhatIsForDinnerDb")]
    partial class WhatIsForDinnerDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WhatIsForDinnerBackEnd.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id")
                        .HasName("PK__Accounts__3214EC07E37313EC");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WhatIsForDinnerBackEnd.Models.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("accountId");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipeId");

                    b.HasKey("Id")
                        .HasName("PK__Favorite__3213E83F7DBFF375");

                    b.HasIndex("AccountId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("WhatIsForDinnerBackEnd.Models.SavedRecipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnalizedInstructions")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("analizedInstructions");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("image");

                    b.Property<string>("Ingredients")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("ingredients");

                    b.Property<int?>("ReadyInMinutes")
                        .HasColumnType("int")
                        .HasColumnName("readyInMinutes");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipeId");

                    b.Property<int?>("Servings")
                        .HasColumnType("int")
                        .HasColumnName("servings");

                    b.Property<string>("Title")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("PK__SavedRec__3213E83F3C6A1A49");

                    b.ToTable("SavedRecipe", (string)null);
                });

            modelBuilder.Entity("WhatIsForDinnerBackEnd.Models.Favorite", b =>
                {
                    b.HasOne("WhatIsForDinnerBackEnd.Models.Account", "Account")
                        .WithMany("Favorites")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("FK__Favorites__accou__68487DD7");

                    b.HasOne("WhatIsForDinnerBackEnd.Models.SavedRecipe", "Recipe")
                        .WithMany("Favorites")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Favorites__recip__693CA210");

                    b.Navigation("Account");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("WhatIsForDinnerBackEnd.Models.Account", b =>
                {
                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("WhatIsForDinnerBackEnd.Models.SavedRecipe", b =>
                {
                    b.Navigation("Favorites");
                });
#pragma warning restore 612, 618
        }
    }
}
