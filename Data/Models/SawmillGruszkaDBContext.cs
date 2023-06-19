using blazor_19c.Migrations;
using Microsoft.EntityFrameworkCore;

namespace blazor_19c.Data.Models
{
    public class SawmillGruszkaDBContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<WorkersGroup> WorkersGroup { get; set; }
        public SawmillGruszkaDBContext(DbContextOptions<SawmillGruszkaDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Material>().HasMany(e => e.MaterialsDeliveries).WithMany(e => e.Materials);
            modelBuilder.Entity<Material>().HasMany(e => e.Tasks).WithMany(e => e.Materials);
            modelBuilder.Entity<Client>().HasMany(e => e.Orders).WithOne(e => e.Client);
            modelBuilder.Entity<Order>().HasMany(e => e.WorkOnOrders).WithOne(e => e.Order);
            modelBuilder.Entity<Task>().HasMany(e => e.WorkersGroups).WithMany(e => e.Tasks);
            modelBuilder.Entity<Task>().HasMany(e => e.Reports).WithMany(e => e.Tasks);
            modelBuilder.Entity<WorkersGroup>().HasMany(e => e.SawmillWorkers).WithMany(e => e.WorkersGroups);
            modelBuilder.Entity<WorkersGroup>().HasMany(e => e.Tasks).WithMany(e => e.WorkersGroups);
            modelBuilder.Entity<ShiftSupervisor>().HasMany(e => e.TaskReports).WithOne(e => e.ShiftSupervisor);

            var sawmillWorkers = new List<SawmillWorker>
{
    new SawmillWorker
    {
        LastName = "Kowalski",
        FirstName = "Jan",
        Birthdate = DateTime.Now.AddYears(-20),
        Pesel = "12345678901",
        Seniority = 10,
        Salary = 1000
    },
    new SawmillWorker
    {
        LastName = "Nowak",
        FirstName = "Anna",
        Birthdate = DateTime.Now.AddYears(-25),
        Pesel = "23456789012",
        Seniority = 5,
        Salary = 1200
    },
    new SawmillWorker
    {
        LastName = "Smith",
        FirstName = "John",
        Birthdate = DateTime.Now.AddYears(-30),
        Pesel = "34567890123",
        Seniority = 8,
        Salary = 1100
    },
    new SawmillWorker
    {
        LastName = "Garcia",
        FirstName = "Maria",
        Birthdate = DateTime.Now.AddYears(-28),
        Pesel = "45678901234",
        Seniority = 3,
        Salary = 1300
    },
    new SawmillWorker
    {
        LastName = "Chen",
        FirstName = "Li",
        Birthdate = DateTime.Now.AddYears(-32),
        Pesel = "56789012345",
        Seniority = 6,
        Salary = 1050
    },
    new SawmillWorker
    {
        LastName = "Müller",
        FirstName = "Hans",
        Birthdate = DateTime.Now.AddYears(-24),
        Pesel = "67890123456",
        Seniority = 9,
        Salary = 1150
    },
    new SawmillWorker
    {
        LastName = "Ramos",
        FirstName = "Carlos",
        Birthdate = DateTime.Now.AddYears(-27),
        Pesel = "78901234567",
        Seniority = 4,
        Salary = 1250
    },
    new SawmillWorker
    {
        LastName = "Yamamoto",
        FirstName = "Akiko",
        Birthdate = DateTime.Now.AddYears(-29),
        Pesel = "89012345678",
        Seniority = 7,
        Salary = 1350
    },
    new SawmillWorker
    {
        LastName = "Dubois",
        FirstName = "Élise",
        Birthdate = DateTime.Now.AddYears(-26),
        Pesel = "90123456789",
        Seniority = 2,
        Salary = 1400
    },
    new SawmillWorker
    {
        LastName = "Petrov",
        FirstName = "Ivan",
        Birthdate = DateTime.Now.AddYears(-31),
        Pesel = "01234567890",
        Seniority = 5,
        Salary = 1020
    }
};
            modelBuilder.Entity<SawmillWorker>().HasData(sawmillWorkers);

            var tasks = new List<Task>
{
    new Task
    {
        State = TaskState.New.ToString(),
        CreatedAt = DateTime.Now,
        FinishDate = DateTime.Now.AddDays(1),
    },
    new Task
    {
        State = TaskState.New.ToString(),
        CreatedAt = DateTime.Now.AddDays(2),
        FinishDate = DateTime.Now.AddDays(3),
    },
    new Task
    {
        State = TaskState.New.ToString(),
        CreatedAt = DateTime.Now.AddDays(4),
        FinishDate = DateTime.Now.AddDays(5),
    },
    new Task
    {
        State = TaskState.New.ToString(),
        CreatedAt = DateTime.Now.AddDays(6),
        FinishDate = DateTime.Now.AddDays(7),
    },
    new Task
    {
        State = TaskState.New.ToString(),
        CreatedAt = DateTime.Now.AddDays(8),
        FinishDate = DateTime.Now.AddDays(9),
    }
};
            modelBuilder.Entity<Task>().HasData(tasks);

            var workersGroups = new List<WorkersGroup>
            {
                new WorkersGroup
                {
                    Specialization = "Sawing",
                },
                new WorkersGroup
                {
                    Specialization = "Drying",
                },
                new WorkersGroup
                {
                    Specialization = "Planing",
                },
                new WorkersGroup
                {
                    Specialization = "Packing",
                },
                new WorkersGroup
                {
                    Specialization = "Loading",
                },
                new WorkersGroup
                {
                    Specialization = "Wood"
                },
                new WorkersGroup
                {
                    Specialization = "Metal"
                }
            };
            modelBuilder.Entity<WorkersGroup>().HasData(workersGroups);



            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("PersonType");
        }
    }
}
