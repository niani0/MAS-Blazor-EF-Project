﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazor_19c.Data.Models;

#nullable disable

namespace blazor_19c.Migrations
{
    [DbContext(typeof(SawmillGruszkaDBContext))]
    partial class SawmillGruszkaDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MaterialMaterialsDelivery", b =>
                {
                    b.Property<string>("MaterialsDeliveriesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaterialsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MaterialsDeliveriesId", "MaterialsId");

                    b.HasIndex("MaterialsId");

                    b.ToTable("MaterialMaterialsDelivery");
                });

            modelBuilder.Entity("MaterialTask", b =>
                {
                    b.Property<string>("MaterialsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TasksId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MaterialsId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("MaterialTask");
                });

            modelBuilder.Entity("SawmillWorkerWorkersGroup", b =>
                {
                    b.Property<string>("SawmillWorkersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkersGroupsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SawmillWorkersId", "WorkersGroupsId");

                    b.HasIndex("WorkersGroupsId");

                    b.ToTable("SawmillWorkerWorkersGroup");
                });

            modelBuilder.Entity("TaskTaskReport", b =>
                {
                    b.Property<string>("ReportsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TasksId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ReportsId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("TaskTaskReport");
                });

            modelBuilder.Entity("TaskWorkOnOrder", b =>
                {
                    b.Property<string>("TasksId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkOnOrdersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TasksId", "WorkOnOrdersId");

                    b.HasIndex("WorkOnOrdersId");

                    b.ToTable("TaskWorkOnOrder");
                });

            modelBuilder.Entity("TaskWorkersGroup", b =>
                {
                    b.Property<string>("TasksId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkersGroupsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TasksId", "WorkersGroupsId");

                    b.HasIndex("WorkersGroupsId");

                    b.ToTable("TaskWorkersGroup");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.Material", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("PricePerKilo")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Material");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.MaterialsDelivery", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DeliveryCompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MaterialsDelivery");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("OrderPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("PersonType").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("blazor_19c.Data.Models.Task", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Task");

                    b.HasData(
                        new
                        {
                            Id = "5690f7b2-2d72-4820-967e-c862097704b6",
                            CreatedAt = new DateTime(2023, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1069),
                            FinishDate = new DateTime(2023, 6, 22, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1072),
                            State = "New"
                        },
                        new
                        {
                            Id = "f5489292-fa7a-4eb2-aec9-943cd9928257",
                            CreatedAt = new DateTime(2023, 6, 23, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1082),
                            FinishDate = new DateTime(2023, 6, 24, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1084),
                            State = "New"
                        },
                        new
                        {
                            Id = "35503c15-c2d9-45ca-aacf-3003b230ca9f",
                            CreatedAt = new DateTime(2023, 6, 25, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1090),
                            FinishDate = new DateTime(2023, 6, 26, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1092),
                            State = "New"
                        },
                        new
                        {
                            Id = "b32d3219-9a98-4b87-bb3c-536c37a0ac44",
                            CreatedAt = new DateTime(2023, 6, 27, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1101),
                            FinishDate = new DateTime(2023, 6, 28, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1102),
                            State = "New"
                        },
                        new
                        {
                            Id = "752c251a-21c4-45a3-a939-e21549f5b21b",
                            CreatedAt = new DateTime(2023, 6, 29, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1107),
                            FinishDate = new DateTime(2023, 6, 30, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1109),
                            State = "New"
                        });
                });

            modelBuilder.Entity("blazor_19c.Data.Models.TaskReport", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShiftSupervisorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TaskDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShiftSupervisorId");

                    b.ToTable("TaskReport");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.WorkOnOrder", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("WorkEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("WorkOnOrder");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.WorkersGroup", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkersGroup");

                    b.HasData(
                        new
                        {
                            Id = "1e91a95c-f5c0-4527-b3ac-5978e58ef40d",
                            Specialization = "Wood"
                        },
                        new
                        {
                            Id = "0978f6a0-c149-4e75-9f84-decd19c284f1",
                            Specialization = "Wood"
                        },
                        new
                        {
                            Id = "59239a0d-e0c3-423a-8d27-13dadf9348ec",
                            Specialization = "Planing"
                        },
                        new
                        {
                            Id = "82c7b484-0cb9-4d95-ae02-d1e9a32b1c5b",
                            Specialization = "Packing"
                        },
                        new
                        {
                            Id = "1ca188cf-01cd-4f8a-9850-22b9830f458b",
                            Specialization = "Loading"
                        },
                        new
                        {
                            Id = "e60d36d8-cce3-4190-a55a-4681d3e4d21e",
                            Specialization = "Wood"
                        },
                        new
                        {
                            Id = "52036687-412c-4bd5-9cde-2a244cc475dc",
                            Specialization = "Metal"
                        });
                });

            modelBuilder.Entity("blazor_19c.Data.Models.Client", b =>
                {
                    b.HasBaseType("blazor_19c.Data.Models.Person");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.SawmillWorker", b =>
                {
                    b.HasBaseType("blazor_19c.Data.Models.Person");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<int>("Seniority")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("SawmillWorker");

                    b.HasData(
                        new
                        {
                            Id = "61d331fa-dfc4-4f4c-818c-e9e423fa028e",
                            Birthdate = new DateTime(2003, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(886),
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Pesel = "12345678901",
                            Salary = 1000f,
                            Seniority = 10
                        },
                        new
                        {
                            Id = "ac3eaf10-be6b-490e-aa75-e61cdc4f2df5",
                            Birthdate = new DateTime(1998, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(945),
                            FirstName = "Anna",
                            LastName = "Nowak",
                            Pesel = "23456789012",
                            Salary = 1200f,
                            Seniority = 5
                        },
                        new
                        {
                            Id = "ed9f905c-31b5-4ff6-b6a7-664c3abf7316",
                            Birthdate = new DateTime(1993, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(952),
                            FirstName = "John",
                            LastName = "Smith",
                            Pesel = "34567890123",
                            Salary = 1100f,
                            Seniority = 8
                        },
                        new
                        {
                            Id = "e1edbaa3-ee91-477c-984b-b31fd9e96054",
                            Birthdate = new DateTime(1995, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(958),
                            FirstName = "Maria",
                            LastName = "Garcia",
                            Pesel = "45678901234",
                            Salary = 1300f,
                            Seniority = 3
                        },
                        new
                        {
                            Id = "32232c76-5a3c-4791-891c-ed1e47b52084",
                            Birthdate = new DateTime(1991, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(963),
                            FirstName = "Li",
                            LastName = "Chen",
                            Pesel = "56789012345",
                            Salary = 1050f,
                            Seniority = 6
                        },
                        new
                        {
                            Id = "c3bf523f-222f-4923-a810-9a173a488fcd",
                            Birthdate = new DateTime(1999, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(987),
                            FirstName = "Hans",
                            LastName = "Müller",
                            Pesel = "67890123456",
                            Salary = 1150f,
                            Seniority = 9
                        },
                        new
                        {
                            Id = "1e2f7823-63ec-491c-9607-8f38a7dea02a",
                            Birthdate = new DateTime(1996, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(992),
                            FirstName = "Carlos",
                            LastName = "Ramos",
                            Pesel = "78901234567",
                            Salary = 1250f,
                            Seniority = 4
                        },
                        new
                        {
                            Id = "ddddab79-2cc5-4476-84ab-e47e9499a611",
                            Birthdate = new DateTime(1994, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(998),
                            FirstName = "Akiko",
                            LastName = "Yamamoto",
                            Pesel = "89012345678",
                            Salary = 1350f,
                            Seniority = 7
                        },
                        new
                        {
                            Id = "ffe6242e-e69b-4112-a23a-30fa3e6a608b",
                            Birthdate = new DateTime(1997, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1003),
                            FirstName = "Élise",
                            LastName = "Dubois",
                            Pesel = "90123456789",
                            Salary = 1400f,
                            Seniority = 2
                        },
                        new
                        {
                            Id = "ca690b00-c9bd-41db-b45a-2cd99aa21cd1",
                            Birthdate = new DateTime(1992, 6, 21, 12, 18, 20, 320, DateTimeKind.Local).AddTicks(1010),
                            FirstName = "Ivan",
                            LastName = "Petrov",
                            Pesel = "01234567890",
                            Salary = 1020f,
                            Seniority = 5
                        });
                });

            modelBuilder.Entity("blazor_19c.Data.Models.ShiftSupervisor", b =>
                {
                    b.HasBaseType("blazor_19c.Data.Models.SawmillWorker");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Person", t =>
                        {
                            t.Property("PhoneNumber")
                                .HasColumnName("ShiftSupervisor_PhoneNumber");
                        });

                    b.HasDiscriminator().HasValue("ShiftSupervisor");
                });

            modelBuilder.Entity("MaterialMaterialsDelivery", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.MaterialsDelivery", null)
                        .WithMany()
                        .HasForeignKey("MaterialsDeliveriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_19c.Data.Models.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MaterialTask", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_19c.Data.Models.Task", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SawmillWorkerWorkersGroup", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.SawmillWorker", null)
                        .WithMany()
                        .HasForeignKey("SawmillWorkersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_19c.Data.Models.WorkersGroup", null)
                        .WithMany()
                        .HasForeignKey("WorkersGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskTaskReport", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.TaskReport", null)
                        .WithMany()
                        .HasForeignKey("ReportsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_19c.Data.Models.Task", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskWorkOnOrder", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.Task", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_19c.Data.Models.WorkOnOrder", null)
                        .WithMany()
                        .HasForeignKey("WorkOnOrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskWorkersGroup", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.Task", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazor_19c.Data.Models.WorkersGroup", null)
                        .WithMany()
                        .HasForeignKey("WorkersGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("blazor_19c.Data.Models.Order", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.TaskReport", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.ShiftSupervisor", "ShiftSupervisor")
                        .WithMany("TaskReports")
                        .HasForeignKey("ShiftSupervisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShiftSupervisor");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.WorkOnOrder", b =>
                {
                    b.HasOne("blazor_19c.Data.Models.Order", "Order")
                        .WithMany("WorkOnOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.Order", b =>
                {
                    b.Navigation("WorkOnOrders");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("blazor_19c.Data.Models.ShiftSupervisor", b =>
                {
                    b.Navigation("TaskReports");
                });
#pragma warning restore 612, 618
        }
    }
}
