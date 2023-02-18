using System;
using System.Collections.Generic;
using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using WrenchWorks.Models;
using WrenchWorks.SeedData;
using WrenchWorks.Services;

namespace WrenchWorks.Data;

public partial class WrenchWorksDbContext : DbContext
{
    public WrenchWorksDbContext()
    {
    }

    public WrenchWorksDbContext(DbContextOptions<WrenchWorksDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<BodyColor> BodyColors { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<FuelType> FuelTypes { get; set; }

    public virtual DbSet<Part> Parts { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<PersonsAddress> PersonsAddresses { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<PowerSource> PowerSources { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Models.Task> Tasks { get; set; }

    public virtual DbSet<TasksEmployee> TasksEmployees { get; set; }

    public virtual DbSet<TasksPart> TasksParts { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK_addresses_addressID");

            entity.ToTable("addresses");

            entity.Property(e => e.AddressId).HasColumnName("addressID");
            entity.Property(e => e.BuildingNo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("buildingNo");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("city");
            entity.Property(e => e.FlatNo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("flatNo");
            entity.Property(e => e.PostCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("postCode");
            entity.Property(e => e.Region)
                .HasMaxLength(30)
                .HasColumnName("region");
            entity.Property(e => e.Street)
                .HasMaxLength(30)
                .HasColumnName("street");
        });

        modelBuilder.Entity<BodyColor>(entity =>
        {
            entity.HasKey(e => e.Color).HasName("PK_bodyColors_color");

            entity.ToTable("bodyColors");

            entity.Property(e => e.Color)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("color");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_customers_customerID");

            entity.ToTable("customers");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("customerID");
            entity.Property(e => e.Nip)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("NIP");

            entity.HasOne(d => d.CustomerNavigation).WithOne(p => p.Customer)
                .HasForeignKey<Customer>(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personIsCustomer");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK_employees_employeeID");

            entity.ToTable("employees");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("employeeID");
            entity.Property(e => e.DateOfEmployment)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("dateOfEmployment");
            entity.Property(e => e.PositionName)
                .HasMaxLength(35)
                .HasColumnName("positionName");

            entity.HasOne(d => d.EmployeeNavigation).WithOne(p => p.Employee)
                .HasForeignKey<Employee>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personIsEmployee");

            entity.HasOne(d => d.PositionNameNavigation).WithMany(p => p.Employees)
                .HasPrincipalKey(p => p.PositionName)
                .HasForeignKey(d => d.PositionName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("employeeWorksOnPosition");
        });

        modelBuilder.Entity<FuelType>(entity =>
        {
            entity.HasKey(e => e.Fuel).HasName("PK_fuelTypes_Fuel");

            entity.ToTable("fuelTypes");

            entity.Property(e => e.Fuel)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("fuel");
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.HasKey(e => e.PartId).HasName("PK_parts_partID");

            entity.ToTable("parts");

            entity.HasIndex(e => new { e.Manufacturer, e.ManufacturerArtNo }, "UNIQ_part").IsUnique();

            entity.Property(e => e.PartId).HasColumnName("partID");
            entity.Property(e => e.Category)
                .HasMaxLength(30)
                .HasColumnName("category");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(30)
                .HasColumnName("manufacturer");
            entity.Property(e => e.ManufacturerArtNo).HasColumnName("manufacturerArtNo")
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartName)
                .HasMaxLength(50)
                .HasColumnName("partName");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK_persons_personID");

            entity.ToTable("persons");

            entity.Property(e => e.PersonId).HasColumnName("personID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("lastName");
            entity.Property(e => e.TelephoneNumber)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telephoneNumber");
        });

        modelBuilder.Entity<PersonsAddress>(entity =>
        {
            entity.HasKey(e => new { e.PersonId, e.AddressId });

            entity.ToTable("persons_addresses");

            entity.Property(e => e.PersonId).HasColumnName("personID");
            entity.Property(e => e.AddressId).HasColumnName("addressID");

            entity.HasOne(d => d.Address).WithMany(p => p.PersonsAddresses)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("definesAddressesPerson");

            entity.HasOne(d => d.Person).WithMany(p => p.PersonsAddresses)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("definesPersonsAddress");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("PK_positions_position");

            entity.ToTable("positions");

            entity.HasIndex(e => e.PositionName, "UNIQ_position").IsUnique();

            entity.Property(e => e.PositionId)
                .ValueGeneratedNever()
                .HasColumnName("positionID");
            entity.Property(e => e.PositionName)
                .HasMaxLength(35)
                .HasColumnName("positionName");
            entity.Property(e => e.ServiceHourRate)
                .HasColumnType("decimal(10,2)")
                .HasColumnName("serviceHourRate");
            entity.Property(e => e.SupervisorId).HasColumnName("supervisorID");

            entity.HasOne(d => d.Supervisor).WithMany(p => p.InverseSupervisor)
                .HasForeignKey(d => d.SupervisorId)
                .HasConstraintName("isSupervisor");
        });

        modelBuilder.Entity<PowerSource>(entity =>
        {
            entity.HasKey(e => e.Vin).HasName("PK_powerSources_VIN");

            entity.ToTable("powerSources");

            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VIN");
            entity.Property(e => e.Biofuel).HasColumnName("biofuel");
            entity.Property(e => e.Cng).HasColumnName("CNG");
            entity.Property(e => e.Hybrid).HasColumnName("hybrid");
            entity.Property(e => e.Lpg).HasColumnName("LPG");
            entity.Property(e => e.MainPowerSourceType)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("mainPowerSourceType");

            entity.HasOne(d => d.MainPowerSourceTypeNavigation).WithMany(p => p.PowerSources)
                .HasForeignKey(d => d.MainPowerSourceType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("powerSourceType");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK_services_serviceID");

            entity.ToTable("services");

            entity.Property(e => e.ServiceId).HasColumnName("serviceID");
            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            entity.Property(e => e.PaidOff).HasColumnName("paidOff");
            entity.Property(e => e.ServiceEndDate)
                .HasColumnType("date")
                .HasColumnName("serviceEndDate");
            entity.Property(e => e.ServiceStartDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("serviceStartDate");
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VIN");

            entity.HasOne(d => d.Customer).WithMany(p => p.Services)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("customerOrdersService");

            entity.HasOne(d => d.Employee).WithMany(p => p.Services)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("empResponsibleForService");

            entity.HasOne(d => d.VinNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.Vin)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("serviceAssignedToVehicle");
        });

        modelBuilder.Entity<Models.Task>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK_tasks_taskID");

            entity.ToTable("tasks");

            entity.Property(e => e.TaskId).HasColumnName("taskID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.ExecutionTime)
                .HasColumnType("decimal(10,2)")
                .HasColumnName("executionTime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ServiceId).HasColumnName("serviceID");

            entity.HasOne(d => d.Service).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("serviceConsistsOfTasks");
        });

        modelBuilder.Entity<TasksEmployee>(entity =>
        {
            entity.HasKey(e => new { e.EmployeeId, e.TaskId });

            entity.ToTable("tasks_employees");

            entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            entity.Property(e => e.TaskId).HasColumnName("taskID");

            entity.HasOne(d => d.Employee).WithMany(p => p.TasksEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("definesEmployeeTask");

            entity.HasOne(d => d.Task).WithMany(p => p.TasksEmployees)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("definesTaskEmployee");
        });

        modelBuilder.Entity<TasksPart>(entity =>
        {
            entity.HasKey(e => new { e.PartId, e.TaskId });

            entity.ToTable("tasks_parts");

            entity.Property(e => e.PartId).HasColumnName("partID");
            entity.Property(e => e.TaskId).HasColumnName("taskID");

            entity.HasOne(d => d.Part).WithMany(p => p.TasksParts)
                .HasForeignKey(d => d.PartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("definesPartTask");

            entity.HasOne(d => d.Task).WithMany(p => p.TasksParts)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("definesTaskPart");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Vin).HasName("PK_vehicles_VIN");

            entity.ToTable("vehicles");

            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VIN");
            entity.Property(e => e.BodyColor)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("bodyColor");
            entity.Property(e => e.EngineCapacity)
                .HasColumnType("decimal(10,2)")
                .HasColumnName("engineCapacity");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("engineNo");
            entity.Property(e => e.Maker)
                .HasMaxLength(30)
                .HasColumnName("maker");
            entity.Property(e => e.Model)
                .HasMaxLength(30)
                .HasColumnName("model");
            entity.Property(e => e.PersonId).HasColumnName("personID");
            entity.Property(e => e.PowerSource)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("powerSource");
            entity.Property(e => e.YearOfProduction)
                .HasColumnType("date")
                .HasColumnName("yearOfProduction");

            entity.HasOne(d => d.BodyColorNavigation).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.BodyColor)
                .HasConstraintName("vehicleHasBodyColor");

            entity.HasOne(d => d.Person).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("personHasVehicle");

            entity.HasOne(d => d.VinNavigation).WithOne(p => p.Vehicle)
                .HasForeignKey<Vehicle>(d => d.Vin)
                .HasConstraintName("vehicleHasPowerSources");
        });
        
        
        
        
        BruteForceSeed.bfSeedData(modelBuilder);
        //TODO: SEED DATA FROM CSV
        //CSVSeed.addSeedData("fileAddresses.csv",modelBuilder);
        //CSVSeed.addSeedData("filePersons.csv",modelBuilder);
        
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}