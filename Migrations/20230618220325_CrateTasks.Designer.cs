﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazor_19c.Data.Models;

#nullable disable

namespace blazor_19c.Migrations
{
    [DbContext(typeof(SawmillGruszkaDBContext))]
    [Migration("20230618220325_CrateTasks")]
    partial class CrateTasks
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PricePerKilo")
                        .HasColumnType("real");

                    b.HasKey("Id");

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
                            Id = "49bb638f-8e95-4338-8b11-cd51e52fd1b6",
                            CreatedAt = new DateTime(2023, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4641),
                            FinishDate = new DateTime(2023, 6, 20, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4644),
                            State = "New"
                        },
                        new
                        {
                            Id = "6819d699-52db-4137-afe5-497990dcb19e",
                            CreatedAt = new DateTime(2023, 6, 21, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4653),
                            FinishDate = new DateTime(2023, 6, 22, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4655),
                            State = "New"
                        },
                        new
                        {
                            Id = "453dd610-ea58-4b24-8e2d-5fdcce065bc1",
                            CreatedAt = new DateTime(2023, 6, 23, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4660),
                            FinishDate = new DateTime(2023, 6, 24, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4662),
                            State = "New"
                        },
                        new
                        {
                            Id = "924bf26b-12af-4d6d-8c34-3c78715bcc25",
                            CreatedAt = new DateTime(2023, 6, 25, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4666),
                            FinishDate = new DateTime(2023, 6, 26, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4668),
                            State = "New"
                        },
                        new
                        {
                            Id = "6550ee68-bd91-40a2-a849-c7b18927a02d",
                            CreatedAt = new DateTime(2023, 6, 27, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4673),
                            FinishDate = new DateTime(2023, 6, 28, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4674),
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
                            Id = "e7336361-7c3d-40d1-8fb0-7afd49cf9c77",
                            Birthdate = new DateTime(2003, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4460),
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Pesel = "12345678901",
                            Salary = 1000f,
                            Seniority = 10
                        },
                        new
                        {
                            Id = "36caef2e-e26a-4771-a69b-d6f167e61113",
                            Birthdate = new DateTime(1998, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4507),
                            FirstName = "Anna",
                            LastName = "Nowak",
                            Pesel = "23456789012",
                            Salary = 1200f,
                            Seniority = 5
                        },
                        new
                        {
                            Id = "058c09e2-14c8-44b5-a014-56206deed0af",
                            Birthdate = new DateTime(1993, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4512),
                            FirstName = "John",
                            LastName = "Smith",
                            Pesel = "34567890123",
                            Salary = 1100f,
                            Seniority = 8
                        },
                        new
                        {
                            Id = "049d04df-06b9-4901-95f3-961239fdc2e3",
                            Birthdate = new DateTime(1995, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4517),
                            FirstName = "Maria",
                            LastName = "Garcia",
                            Pesel = "45678901234",
                            Salary = 1300f,
                            Seniority = 3
                        },
                        new
                        {
                            Id = "75e6d8df-27df-4647-8423-0c52039e0eba",
                            Birthdate = new DateTime(1991, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4521),
                            FirstName = "Li",
                            LastName = "Chen",
                            Pesel = "56789012345",
                            Salary = 1050f,
                            Seniority = 6
                        },
                        new
                        {
                            Id = "5c29d98c-da51-44d2-a080-106367df70e1",
                            Birthdate = new DateTime(1999, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4528),
                            FirstName = "Hans",
                            LastName = "Müller",
                            Pesel = "67890123456",
                            Salary = 1150f,
                            Seniority = 9
                        },
                        new
                        {
                            Id = "82c1ba5c-8c46-4076-9fd3-2207a977e840",
                            Birthdate = new DateTime(1996, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4533),
                            FirstName = "Carlos",
                            LastName = "Ramos",
                            Pesel = "78901234567",
                            Salary = 1250f,
                            Seniority = 4
                        },
                        new
                        {
                            Id = "18c1fdf6-7d2b-4799-a361-62633b1fbf59",
                            Birthdate = new DateTime(1994, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4548),
                            FirstName = "Akiko",
                            LastName = "Yamamoto",
                            Pesel = "89012345678",
                            Salary = 1350f,
                            Seniority = 7
                        },
                        new
                        {
                            Id = "7d4e4fb2-8fb2-4023-a440-fdde21183ee7",
                            Birthdate = new DateTime(1997, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4552),
                            FirstName = "Élise",
                            LastName = "Dubois",
                            Pesel = "90123456789",
                            Salary = 1400f,
                            Seniority = 2
                        },
                        new
                        {
                            Id = "507fa4c1-5ecc-40de-af4c-c0c5dad36c26",
                            Birthdate = new DateTime(1992, 6, 19, 0, 3, 25, 86, DateTimeKind.Local).AddTicks(4558),
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