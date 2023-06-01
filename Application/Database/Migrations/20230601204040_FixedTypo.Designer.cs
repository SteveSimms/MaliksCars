﻿// <auto-generated />
using System;
using MaliksCars.Application.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaliksCars.Application.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230601204040_FixedTypo")]
    partial class FixedTypo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("MaliksCars.Application.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("BasePrice")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("base_price");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("color");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("Emoji")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("emoji");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("image_url");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_at");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("year");

                    b.HasKey("Id")
                        .HasName("pk_cars");

                    b.ToTable("cars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = "35000",
                            Color = "Green",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7730),
                            Description = "Overview The Best Just Got Better Get ready to redefine your epic. Introducing the all-new Tacoma. Reengineered from the ground up, this legendary machine continues to deliver, but is now more powerful, more capable and more connected to you than ever before.",
                            Emoji = "🚗",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIF.jHCsX8G6XIsB6sWTzxMGVQ%26pid%3DApi&f=1&ipt=90740f75f58e2a407838cefafd8a431a2c8fc6252157f1897d68b78deea8956b&ipo=images",
                            Model = "Tacoma",
                            Name = "Toyota",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7770),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = "38760",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780),
                            Description = "Among the new 2024 Toyota Tacoma's advances in design, interior styling, and tech, its new hybrid powertrain stands out as one of the more compelling aspects of the new midsize truck. The hybrid is optional on mid-level Tacomas and standard on higher trim levels such as the TRD Pro and new Trailhunter trim, and effectively replaces last year's optional 3.5-liter V-6 engine. Here's everything we know about the new i-Force MAX hybrid engine:",
                            Emoji = "🚗",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.XmOg8PhCahJUz07uEns77gHaFH%26pid%3DApi&f=1&ipt=e94a6c1bdeeb0e009909b8256b90ef7a028895bfc0bada1b7826029b2f892923&ipo=images",
                            Model = "Tundra",
                            Name = "Toyota",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = "28000",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780),
                            Description = "The current Toyota Camry is coming due for replacement, not coincidentally soon after its crosstown rival the Honda Accord received a major redesign for 2023. Normally, news of an impending new Camry might elicit yawns, or sheer indifference. After all, amongst midsize sedans, a typically stuffy, practical bunch, the Toyota has long been the safe, boring choice. Well, it has been, until recently—today's Camry is easily the most adventurously styled, sportily tuned of the breed, a trend we think will continue into the next-generation Camry due for 2024 or 2025.",
                            Emoji = "🚗",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.GtK1ltI9wHx-tcCL-_qoFwHaEK%26pid%3DApi&f=1&ipt=b4c69901d9c3c85331eb45eca35d8c4d2690b6c8ec962b6d123f79daed3f9655&ipo=images",
                            Model = "Camry",
                            Name = "Toyota",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 4,
                            BasePrice = "29000",
                            Color = "Red",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780),
                            Description = "The 2024 Toyota Prius Prime boasts an eye-catching and aerodynamic exterior design that sets it apart from the crowd. With its sleek lines, modern features, and innovative styling, the Prius Prime not only delivers on fuel efficiency but also makes a statement on the road. ",
                            Emoji = "🚗",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.C_2sFBoGvVHfTsPM0VNrAgHaE1%26pid%3DApi&f=1&ipt=7cd184f404a07613be15cabf0961e51bb4996f0368750237170ebe40fd906602&ipo=images",
                            Model = "Prius",
                            Name = "Toyota",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 5,
                            BasePrice = "26000",
                            Color = "Black",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790),
                            Description = "Model Preview With the Honda Civic being introduced as a fully redesigned compact car in 2022, the vehicle remains a fresh option in the segment. We expect the upcoming 2024 Honda Civic to arrive as a carryover model since the redesign wasn't too long ago. The 2024 Civic should retain the same exterior design as the current model that's on sale",
                            Emoji = "🚗",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.BMbAY-bBAvMTlwZZ9xaaugHaEi%26pid%3DApi&f=1&ipt=750a1b0b4d62f8b2e0fcb9250155f047686c407726d84b9c021a475d8b50d213&ipo=images",
                            Model = "Civic",
                            Name = "Honda",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 6,
                            BasePrice = "30000",
                            Color = "Red",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790),
                            Description = "2024 Honda CR-V Price & Trims. The Currently available 2023 Honda CR-V is offered in four trims including hybrid variants- EX, Sport Hybrid, EX-L, and Sport Touring Hybrid. in which its base trim price starts at $31,610 which goes up to $39,100. we hope that the Honda will follow the same trim structure for the next Honda CR-V. so here we have given its estimated price on the basis of the 2023",
                            Emoji = "🚗",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.HHrg6eoCvLmEe0mhVMn4RQHaE7%26pid%3DApi&f=1&ipt=b5578073716e6072d8b2d829b70e665f1a90e3f5933571542dbd7709b8324e1e&ipo=images",
                            Model = "Crv",
                            Name = "Honda",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 7,
                            BasePrice = "29000",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790),
                            Description = "The 2024 Honda Civic is making waves in the automotive industry as a stylish, fuel-efficient, fun-to-drive small car. The Civic offers versatility with its entry-level models featuring a 158-hp 2.0-liter four-cylinder engine and more powerful options like the 180-hp turbocharged 1.5-liter engine and hybrid powertrain to suit different driving .",
                            Emoji = "🚗",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.HHrg6eoCvLmEe0mhVMn4RQHaE7%26pid%3DApi&f=1&ipt=b5578073716e6072d8b2d829b70e665f1a90e3f5933571542dbd7709b8324e1e&ipo=images",
                            Model = "Hrv",
                            Name = "Honda",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 8,
                            BasePrice = "49850",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800),
                            Description = "2024 Acura MDX Features | Premium SUV with Supercar Handling Be ready for any drive with a V-6 engine with 290-HP and available Super Handling All-Wheel Drive™ (SH-AWD). Check out all the features. We noticed you're using Internet Explorer 11, which is no longer supported on this site. Please switch to a different browser to continue.",
                            Emoji = "🚗",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.9rwnieNXC26jHnEAWYohNAHaEU%26pid%3DApi&f=1&ipt=6e03e3cd649e37137ad95283442df9885a4b7caafd1fa944bad6781943dcb3da&ipo=images",
                            Model = "Mdx",
                            Name = "Acura",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 9,
                            BasePrice = "41363",
                            Color = "Blue",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800),
                            Description = "2024 Acura Integra. 31,500 - 36,500 MSRP. Find Best Price. Find Best Price. More than 280,000 car shoppers have purchased or leased a car through the U.S. News Best Price Program. Our pricing beats the national average 86% of the time with shoppers receiving average savings of $1,824 off MSRP across vehicles.",
                            Emoji = "🚙",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.B6n53WhZYberj0nM8scsQwHaEA%26pid%3DApi&f=1&ipt=b7d4d5bc048f5b114f58fd1eafea7d20ade8fb7e04b0fa4faecbfa2a9a086bff&ipo=images",
                            Model = "Integra",
                            Name = "Acura",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 10,
                            BasePrice = "235000",
                            Color = "Orange",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800),
                            Description = "Lamborghini Urus is the first Super Sport Utility Vehicle in the world, merging the soul of a super sports car with the practical functionality of an SUV. Powered by Lamborghini's 4.0-liter twin-turbo V8 engine, the Urus is all about a performance mindset that brings together fun-to-drive and astounding vehicle capabilities.",
                            Emoji = "🏎️",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.bdgzMTcR8UoNi-vrAWLq7QHaDx%26pid%3DApi&f=1&ipt=978e0d72ae8978b9a704a125c801da31ef9ad7c7c9725708a66a354ec037fb8b&ipo=images",
                            Model = "Urus",
                            Name = "Lamborghini",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 11,
                            BasePrice = "126995",
                            Color = "Orange",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810),
                            Description = "Strikingly Beautiful Exterior The exterior of the 2024 Audi Q8 will be refreshed, and the new SUV is looking more aggressive than ever. Basically, the manufacturer makes a few small changes to the front end. First of all, the hexagonal grille looks more aggressive, and Audi added more muscular body lines.",
                            Emoji = "🏎️",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.hDcEW53-AZm77uctufGo2wHaEK%26pid%3DApi&f=1&ipt=dc20fa660cd6fe81893b2b807038f1e565732571ff14ad25ae729e56ff3ae0d6&ipo=images",
                            Model = "RSQ8",
                            Name = "Audi",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810),
                            Year = "2023"
                        },
                        new
                        {
                            Id = 12,
                            BasePrice = "22000",
                            Color = "White",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810),
                            Description = "The 2024 Kia Soul EX price may surprise you as it may be around $22,665. The new mini crossover offers a redesigned look and is priced to compete with other small SUVs like the Honda Element and Nissan Cube. The Soul's dimensions are similar to those of a popular SUV, but with the added power of a turbocharged engine.",
                            Emoji = "🏎️",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.RLM2iRt-V-9CCXlfMHGFUgHaE6%26pid%3DApi&f=1&ipt=2b50cf296d1cb4fbc9cbf36ea642b4fab923dc79c7d31c978601e391c5d5cff2&ipo=images",
                            Model = "Soul",
                            Name = "Kia",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810),
                            Year = "2024"
                        },
                        new
                        {
                            Id = 13,
                            BasePrice = "139000",
                            Color = "Black",
                            CreatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810),
                            Description = "There's nothing else on the road that's quite like the 2023 Mercedes-Benz G-Class. The original G-wagen was an icon, a military vehicle with the interior of an S-Class, and it remained on sale for what seems like forever. The redesigned second-generation version of the SUV arrived in 2019, retaining all of the looks, panache and capability of the original but with a more refined interior and better in-car tech and driver aids. That said, it's far from the most comfortable or best-driving luxury SUV on the road. The G-Class wins on charm more than anything else.",
                            Emoji = "🏎️",
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.ytimg.com%2Fvi%2FRjocMccyxqc%2Fmaxresdefault.jpg&f=1&nofb=1&ipt=7a67a15ccdd6b6b846bcbf15deabdadd61b67d25476b47339ab0680a6f124805&ipo=images",
                            Model = "Amg G63",
                            Name = "Mercedes",
                            UpdatedAt = new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810),
                            Year = "2023"
                        });
                });

            modelBuilder.Entity("MaliksCars.Application.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_roles_name");

                    b.ToTable("roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("MaliksCars.Application.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<DateTime?>("EmailVerifiedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("email_verified_at");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("password");

                    b.Property<string>("RememberToken")
                        .HasColumnType("TEXT")
                        .HasColumnName("remember_token");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_users_email");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("MaliksCars.Application.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("user_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_user_roles");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_user_roles_role_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_user_roles_user_id");

                    b.ToTable("user_roles", (string)null);
                });

            modelBuilder.Entity("MaliksCars.Application.Models.UserRole", b =>
                {
                    b.HasOne("MaliksCars.Application.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_roles_roles_role_id");

                    b.HasOne("MaliksCars.Application.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_roles_users_user_id");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MaliksCars.Application.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("MaliksCars.Application.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}