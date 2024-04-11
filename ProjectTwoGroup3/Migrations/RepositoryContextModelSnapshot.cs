﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace ProjectTwoGroup3.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Billing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BillingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("UserPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserPlanId");

                    b.ToTable("Billings");
                });

            modelBuilder.Entity("Entities.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("DeviceId");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Storage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"),
                            Color = "Black",
                            Manufacturer = "Apple",
                            Model = "iPhone 15 Plus",
                            Storage = "64GB"
                        },
                        new
                        {
                            Id = new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"),
                            Color = "Grey",
                            Manufacturer = "Samsung",
                            Model = "Galaxy S24 Ultra",
                            Storage = "128GB"
                        },
                        new
                        {
                            Id = new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"),
                            Color = "Blue",
                            Manufacturer = "Apple",
                            Model = "iPhone 15",
                            Storage = "256GB"
                        },
                        new
                        {
                            Id = new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"),
                            Color = "Mint Blue",
                            Manufacturer = "Google",
                            Model = "Pixel 8 Pro",
                            Storage = "128GB"
                        },
                        new
                        {
                            Id = new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"),
                            Color = "Violet",
                            Manufacturer = "Google",
                            Model = "Pixel 7",
                            Storage = "256GB"
                        },
                        new
                        {
                            Id = new Guid("88ca3741-b8f4-44f6-baef-059389a34907"),
                            Color = "White",
                            Manufacturer = "Apple",
                            Model = "iPhone 13",
                            Storage = "64GB"
                        },
                        new
                        {
                            Id = new Guid("6488bdee-e52c-442a-b754-8a8f6c0e5ce0"),
                            Color = "Red",
                            Manufacturer = "Motorola",
                            Model = "Razr Plus",
                            Storage = "128GB"
                        },
                        new
                        {
                            Id = new Guid("86a2e9d1-881f-4aba-ba25-e563b460a97a"),
                            Color = "Blue",
                            Manufacturer = "Samsung",
                            Model = "iPhone 15 Plus",
                            Storage = "128GB"
                        },
                        new
                        {
                            Id = new Guid("913cdb0e-2618-4c30-b760-0a78857eb0dd"),
                            Color = "Blue",
                            Manufacturer = "Apple",
                            Model = "iPhone 12",
                            Storage = "128GB"
                        },
                        new
                        {
                            Id = new Guid("baf6fd9a-ee78-4512-b298-03bd824f3fbd"),
                            Color = "Purple",
                            Manufacturer = "Samsung",
                            Model = "Galaxy S21+",
                            Storage = "512GB"
                        });
                });

            modelBuilder.Entity("Entities.PhonePlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PlanId");

                    b.Property<int>("DeviceLimit")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhonePlans");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc"),
                            DeviceLimit = 1,
                            Price = 29.99m,
                            Title = "Basic Plan"
                        },
                        new
                        {
                            Id = new Guid("23d7dc69-ff2f-42e9-92d5-20aebbb0747f"),
                            DeviceLimit = 3,
                            Price = 69.99m,
                            Title = "Premium Plan"
                        },
                        new
                        {
                            Id = new Guid("1d5cc690-684b-4dc4-b4ac-1bdf90c97839"),
                            DeviceLimit = 5,
                            Price = 99.99m,
                            Title = "Family Plan"
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "25f87c58-9061-4bb7-aa3a-4a05177481d2",
                            AccessFailedCount = 0,
                            Address = "123 Main St",
                            ConcurrencyStamp = "8d59c2d1-cfe1-4d73-86e9-3042212e567e",
                            Email = "john.doe@example.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            PasswordHash = "password1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "23476b19-8208-44d1-a912-cb419d28f39e",
                            TwoFactorEnabled = false,
                            UserName = "johndoe"
                        },
                        new
                        {
                            Id = "538091ec-802c-460d-a56e-8ce2414782b2",
                            AccessFailedCount = 0,
                            Address = "456 Elm St",
                            ConcurrencyStamp = "0a0dc04e-8217-43b8-8511-c13d1cc888ea",
                            Email = "jane.smith@example.com",
                            EmailConfirmed = false,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            PasswordHash = "password2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "739cd48c-1438-4311-9366-28b488f230de",
                            TwoFactorEnabled = false,
                            UserName = "janesmith"
                        },
                        new
                        {
                            Id = "3f86cc51-c688-42de-aa44-d35c5db73bc4",
                            AccessFailedCount = 0,
                            Address = "789 Loon St",
                            ConcurrencyStamp = "8c21d17f-4d5c-4425-ab97-0173975804cf",
                            Email = "elmer.fudd@example.com",
                            EmailConfirmed = false,
                            FirstName = "Elmer",
                            LastName = "Fudd",
                            LockoutEnabled = false,
                            PasswordHash = "password3",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "63ddf8e3-061a-44c9-a121-11f439e40dd9",
                            TwoFactorEnabled = false,
                            UserName = "elmerfudd"
                        });
                });

            modelBuilder.Entity("Entities.UserDevice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ActivationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeviceID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserPlanID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserPlanID");

                    b.ToTable("UserDevices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac3f3dc7-ebb4-4f8d-907b-c45f71a8d9a5"),
                            ActivationDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceID = new Guid("cde3cf86-46fb-40b3-bd45-e64171469e9b"),
                            PhoneNumber = "2629423847",
                            UserPlanID = new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5")
                        },
                        new
                        {
                            Id = new Guid("18d346f8-edcc-4700-ab34-4518cd044674"),
                            ActivationDate = new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceID = new Guid("7b483b60-90e2-4c89-836c-4ad8946b8aa7"),
                            PhoneNumber = "7187624769",
                            UserPlanID = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf")
                        },
                        new
                        {
                            Id = new Guid("022ae233-4d11-40d3-8170-1b034022eb57"),
                            ActivationDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceID = new Guid("f5222ea1-947e-45c1-a59a-a5a6e296b902"),
                            PhoneNumber = "3036313605",
                            UserPlanID = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf")
                        },
                        new
                        {
                            Id = new Guid("5c38b804-3093-4c05-95c9-79caae650e15"),
                            ActivationDate = new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceID = new Guid("97a612e4-13d6-43c0-805b-30fafa1ae05a"),
                            PhoneNumber = "8472898809",
                            UserPlanID = new Guid("f512ba58-cc89-49f5-8489-367865917a8b")
                        },
                        new
                        {
                            Id = new Guid("0cf43dcb-563d-4707-b2b3-7f6ff4d69f7f"),
                            ActivationDate = new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceID = new Guid("4f05e337-e657-4848-9efe-8b291bf18f1f"),
                            PhoneNumber = "2085544516",
                            UserPlanID = new Guid("f512ba58-cc89-49f5-8489-367865917a8b")
                        },
                        new
                        {
                            Id = new Guid("d80449d6-cabf-4bae-b7b8-1888ac1caab9"),
                            ActivationDate = new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeviceID = new Guid("88ca3741-b8f4-44f6-baef-059389a34907"),
                            PhoneNumber = "7712780071",
                            UserPlanID = new Guid("f512ba58-cc89-49f5-8489-367865917a8b")
                        });
                });

            modelBuilder.Entity("Entities.UserPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPlans");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93e289fa-ffa4-484b-b66e-7df8078f9ed5"),
                            PlanId = new Guid("f6daf5fa-75fc-485a-8b6d-388e4132cfcc"),
                            UserId = "25f87c58-9061-4bb7-aa3a-4a05177481d2"
                        },
                        new
                        {
                            Id = new Guid("d1e5f1d3-d768-403c-9431-564e9cbe84bf"),
                            PlanId = new Guid("23d7dc69-ff2f-42e9-92d5-20aebbb0747f"),
                            UserId = "538091ec-802c-460d-a56e-8ce2414782b2"
                        },
                        new
                        {
                            Id = new Guid("f512ba58-cc89-49f5-8489-367865917a8b"),
                            PlanId = new Guid("1d5cc690-684b-4dc4-b4ac-1bdf90c97839"),
                            UserId = "3f86cc51-c688-42de-aa44-d35c5db73bc4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "91e941cb-a6c3-4d59-81b6-81b9ce98774e",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5088b294-d760-47e5-9b12-07fb79bd3f4b",
                            Name = "Professor",
                            NormalizedName = "PROFESSOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.Billing", b =>
                {
                    b.HasOne("Entities.PhonePlan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Entities.UserPlan", null)
                        .WithMany("Bills")
                        .HasForeignKey("UserPlanId");

                    b.Navigation("Plan");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.UserDevice", b =>
                {
                    b.HasOne("Entities.UserPlan", null)
                        .WithMany("Devices")
                        .HasForeignKey("UserPlanID");
                });

            modelBuilder.Entity("Entities.UserPlan", b =>
                {
                    b.HasOne("Entities.PhonePlan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.User", "User")
                        .WithMany("UserPlans")
                        .HasForeignKey("UserId");

                    b.Navigation("Plan");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Navigation("UserPlans");
                });

            modelBuilder.Entity("Entities.UserPlan", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
