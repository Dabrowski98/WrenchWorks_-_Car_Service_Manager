using System.Globalization;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using WrenchWorks.Models;

namespace WrenchWorks.Services;

public class CSVSeed
{
    public static void addSeedData(string fileName, ModelBuilder modelBuilder)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null,
            MissingFieldFound = null
        };
        string filePath = $"SeedData/{fileName}";
        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvHelper.CsvReader(reader, config))
        {
            switch (fileName)
            {
                case "filePersons.csv":

                    var filePersonsRecords = csv.GetRecords<Person>().ToList();
                    modelBuilder.Entity<Person>().HasData(filePersonsRecords);

                    break;

                case "fileAddresses.csv":

                    var fileAddressesRecords = csv.GetRecords<Address>().ToList();
                    modelBuilder.Entity<Address>().HasData(fileAddressesRecords);

                    break;

                case "fileEmployees":
                    var fileEmployeesRecords = csv.GetRecords<Employee>().ToList();
                    modelBuilder.Entity<Employee>().HasData(fileEmployeesRecords);
                    break;

                case "fileCustomers":
                    var fileCustomersRecords = csv.GetRecords<Customer>().ToList();
                    modelBuilder.Entity<Customer>().HasData(fileCustomersRecords);
                    break;

                case "fileVehicles":
                    var fileVehiclesRecords = csv.GetRecords<Vehicle>().ToList();
                    modelBuilder.Entity<Vehicle>().HasData(fileVehiclesRecords);
                    break;

                case "filePowerSources":
                    var filePowerSourcesRecords = csv.GetRecords<PowerSource>().ToList();
                    modelBuilder.Entity<PowerSource>().HasData(filePowerSourcesRecords);
                    break;

                case "fileServices":
                    var fileServicesRecords = csv.GetRecords<Service>().ToList();
                    modelBuilder.Entity<Service>().HasData(fileServicesRecords);
                    break;

                case "fileTasks":
                    var fileTasksRecords = csv.GetRecords<Models.Task>().ToList();
                    modelBuilder.Entity<Models.Task>().HasData(fileTasksRecords);
                    break;

                case "fileParts":
                    var filePartsRecords = csv.GetRecords<Part>().ToList();
                    modelBuilder.Entity<Part>().HasData(filePartsRecords);
                    break;
            }
            // CSVSeed.addSeedData("fileAddresses.csv",modelBuilder);
            // CSVSeed.addSeedData("filePersons.csv",modelBuilder);
            //CSVSeed.addSeedData();
            
            
        }
    }
}