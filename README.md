# **WrenchWorks - Car Service Manager**
![wrenchworks](https://github.com/Dabrowski98/WrenchWorks_-_Car_Service_Manager/assets/91785830/ed92474b-7517-4080-852b-46f7055fb7e8)

### A simple DB-First CRUD application for managing car service station built with ASP.NET Core MVC and SQL.
**Features**

- Create, read, update and delete car service records
- Store and retrieve data using SQL database
- User-friendly interface built with ASP.NET Core MVC
- Validation and error handling

**Requirements**

- .NET Core 3.1 or later
- SQL Server

### **Getting Started**

Clone the repository

```
git clone https://github.com/Dabrowski98/WrenchWorks_-_Car_Service_Manager.git
```
    
Navigate to the project directory
```
cd WrenchWorks_-_Car_Service_Manager
```
Restore packages and build the project
```
dotnet restore
dotnet build
```
Copy these connection strings and paste them in appsettings.json "ConnectionStrings" area.
```
"WrenchWorksIdentityDb": "Server=[INSERT YOUR LOCAL SQL SERVER NAME];Database=WrenchWorksIdentityDB;Trusted_Connection=true;Trust Server Certificate=true;",
"WrenchWorksDb": "Server=[INSERT YOUR LOCAL SQL SERVER NAME];Database=WrenchWorksDB;Trusted_Connection=true;Trust Server Certificate=true;"
```
Make sure you are currently on project directory
```
cd WrenchWorks
```

Create instances of databases
```
dotnet ef database update --context IdentityDbContext
dotnet ef database update --context WrenchWorksDbContext
```
Run the application (make sure that you have selected IIS Express configuration)

### **DB Diagram**
![FinalDBscheme](https://user-images.githubusercontent.com/91785830/219939229-c21f92dd-03f4-420d-be0d-5131030baf6b.png)

Contributions are welcome! Please fork the repository and submit a pull request.



