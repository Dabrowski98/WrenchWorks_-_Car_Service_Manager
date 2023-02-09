USE master
GO

DROP DATABASE IF EXISTS WrenchWorksDB
GO

CREATE DATABASE WrenchWorksDB
GO

USE WrenchWorksDB
GO
-- Query that builds a relational database consisting of [8] tables.

-- PERSONS TABLE
CREATE TABLE [persons](
[personID] BIGINT IDENTITY(1,1) NOT NULL,
[firstName] NVARCHAR(30) NOT NULL,
[lastName] NVARCHAR(30) NOT NULL,
[telephoneNumber] VARCHAR(12) NOT NULL,
[email] VARCHAR(50) NULL,

CONSTRAINT chk_email CHECK (email LIKE '%@%' AND email LIKE '%.%'),
CONSTRAINT PK_persons_personID PRIMARY KEY ([personID])
)

-- CUSTOMERS TABLE
CREATE TABLE [customers](
[customerID] BIGINT NOT NULL,
[totalDue] MONEY NOT NULL DEFAULT 0,
[NIP] VARCHAR(9) NULL,

CONSTRAINT chk_NIP CHECK (NIP LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
CONSTRAINT PK_customers_customerID PRIMARY KEY ([customerID])
)
GO

-- POSITIONS TABLE
CREATE TABLE [positions](
[position] NVARCHAR(20) NOT NULL,

CONSTRAINT PK_positions_position PRIMARY KEY ([position])
)


-- EMPLOYEES TABLE
CREATE TABLE [employees](
[employeeID] BIGINT NOT NULL,
[dateOfEmployment] DATE DEFAULT(GETDATE()) NOT NULL,
[position] NVARCHAR(20) NOT NULL,

CONSTRAINT chk_dateOfEmployment CHECK (dateOfEmployment <= GETDATE()),
CONSTRAINT PK_employees_employeeID PRIMARY KEY ([employeeID])
)
GO

 -- ADDRESSES TABLE
CREATE TABLE [addresses](
[addressID] BIGINT IDENTITY(1,1) NOT NULL,
[region] NVARCHAR(30) NOT NULL,
[city] NVARCHAR(30) NOT NULL,
[street] NVARCHAR(30) NULL,
[buildingNo] VARCHAR(6) NOT NULL,
[flatNo] VARCHAR(6) NULL,
[postCode] VARCHAR(10) NOT NULL,

CONSTRAINT PK_addresses_personID_addressID PRIMARY KEY ([addressID])
)
GO

 -- FUEL TYPES TABLE
CREATE TABLE [fuelTypes](
[fuelType] VARCHAR(16) NOT NULL,

CONSTRAINT PK_fuelTypes_fuelType PRIMARY KEY ([fuelType])
)


 -- BODY COLORS TABLE
CREATE TABLE [bodyColors](
[bodyColor] VARCHAR(16) NOT NULL,
CONSTRAINT PK_bodyColors_bodyColor PRIMARY KEY ([bodyColor])
)

 -- VEHICLES TABLE
CREATE TABLE [vehicles](
[VIN] CHAR(17) NOT NULL,
[maker] NVARCHAR(30) NOT NULL,
[model] NVARCHAR(30) NOT NULL,
[yearOfProduction] DATE NOT NULL,
[engineCapacity] NVARCHAR(5) NULL,
[fuelType] VARCHAR(16) NOT NULL,
[engineNo] VARCHAR(16) NULL,
[bodyColor] VARCHAR(16) NULL,
[personID] BIGINT NULL,

CONSTRAINT PK_vehicles_VIN PRIMARY KEY ([VIN]),
CONSTRAINT chk_VIN CHECK (VIN NOT LIKE '%I%' AND VIN NOT LIKE '%O%' AND VIN NOT LIKE '%Q%'),
CONSTRAINT chk_yearOfProduction CHECK (YEAR(yearOfProduction) <= YEAR(GETDATE()))
)
GO

-- SERVICES TABLE
CREATE TABLE [services](
[serviceID] BIGINT IDENTITY(1,1) NOT NULL,
[VIN] CHAR(17) NOT NULL,
[totalCost] SMALLMONEY DEFAULT 0 NULL,
[serviceStartDate] DATE DEFAULT(GETDATE()) NOT NULL,
[serviceEndDate] DATE NULL,
[customerID] BIGINT NOT NULL,
[employeeID] BIGINT NOT NULL,

CONSTRAINT PK_services_serviceID PRIMARY KEY ([serviceID]),
CONSTRAINT chk_serviceDates CHECK (serviceStartDate <= serviceEndDate or serviceEndDate = null),
CONSTRAINT chk_paymentAmount CHECK (totalCost >= 0)
)
GO

 -- TASKS TABLE
CREATE TABLE [tasks](
[taskID] BIGINT IDENTITY(1,1) NOT NULL,
[name] NVARCHAR(50) NOT NULL,
[description] NVARCHAR(255) NOT NULL,
[executionTime] FLOAT(4) NOT NULL,
[partsCost] SMALLMONEY DEFAULT 0 NOT NULL,
[serviceID] BIGINT NOT NULL,

CONSTRAINT PK_activities_activityID PRIMARY KEY ([taskID],[serviceID]),
CONSTRAINT chk_executionTime CHECK (executionTime >= 0)
)
GO

 -- PARTS TABLE
CREATE TABLE [parts](
[partID] BIGINT IDENTITY(1,1) NOT NULL,
[manufacturer] NVARCHAR(30) NOT NULL,
[manufacturerArtNo] BIGINT NULL,
[partName] NVARCHAR(30) NOT NULL,
[category] NVARCHAR(30) NOT NULL,
[price] MONEY NOT NULL,

CONSTRAINT PK_parts_partID PRIMARY KEY ([partID]),
CONSTRAINT UNIQ_part UNIQUE ([manufacturer],[manufacturerArtNo])
)
GO

 -- TASKS_PARTS TABLE
CREATE TABLE [tasks_parts](
[taskID] BIGINT NOT NULL,
[partID] BIGINT NOT NULL,
[serviceID] BIGINT NOT NULL,

CONSTRAINT PK_tasks_parts PRIMARY KEY ([partID],[taskID],[serviceID])
)
GO
 -- TASKS_EMPLOYEES TABLE
CREATE TABLE [tasks_employees](
[employeeID] BIGINT NOT NULL,
[taskID] BIGINT NOT NULL,
[serviceID] BIGINT NOT NULL

CONSTRAINT PK_tasks_employees PRIMARY KEY ([employeeID],[taskID],[serviceID])
)
GO

CREATE TABLE [persons_addresses](
[personID] BIGINT NOT NULL,
[addressID] BIGINT NOT NULL,
CONSTRAINT PK_persons_addresses_personID_addressID PRIMARY KEY ([personID],[addressID])
)
GO

 -- FOREIGN KEYS
ALTER TABLE [persons_addresses] ADD CONSTRAINT [definesPersonAddress] FOREIGN KEY ([personID])	-- JES GIT
REFERENCES [persons] ([personID]) ON DELETE NO ACTION ON UPDATE CASCADE							-- NIE RUSZEJ
GO

ALTER TABLE [persons_addresses] ADD CONSTRAINT [definesAddressPerson] FOREIGN KEY ([addressID])	-- JES GIT
REFERENCES [addresses] ([addressID]) ON DELETE CASCADE ON UPDATE CASCADE						-- NIE RUSZEJ!!!!!!!!!!!!!!!!
GO	

ALTER TABLE [employees] ADD CONSTRAINT [employeeWorksOnPosition] FOREIGN KEY ([position])		-- JES GIT
REFERENCES [positions] ([position]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

ALTER TABLE [vehicles] ADD CONSTRAINT [vehicleHasBodyColor] FOREIGN KEY ([bodyColor])			-- JES GIT
REFERENCES [bodyColors] ([bodyColor]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

ALTER TABLE [vehicles] ADD CONSTRAINT [vehicleFuelType] FOREIGN KEY ([fuelType])				-- JES GIT
REFERENCES [fuelTypes] ([fuelType]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

ALTER TABLE [vehicles] ADD CONSTRAINT [personHasVehicle] FOREIGN KEY ([personID])
REFERENCES [persons] ([personID]) ON DELETE SET NULL ON UPDATE CASCADE
GO

ALTER TABLE [services] ADD CONSTRAINT [customerOrdersService] FOREIGN KEY ([customerID])
REFERENCES [customers] ([customerID]) ON DELETE NO ACTION ON UPDATE CASCADE 
GO

ALTER TABLE [services] ADD CONSTRAINT [empResponsibleForService] FOREIGN KEY ([employeeID])
REFERENCES [employees] ([employeeID]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

ALTER TABLE [services] ADD CONSTRAINT [serviceAssignedToVehicle] FOREIGN KEY ([VIN])
REFERENCES [vehicles] ([VIN]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [tasks] ADD CONSTRAINT [serviceConsistsOfTasks] FOREIGN KEY ([serviceID])
REFERENCES [services] ([serviceID]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

ALTER TABLE [tasks_employees] ADD CONSTRAINT [definesEmployeeTask] FOREIGN KEY ([employeeID])			-- JES GIT
REFERENCES [employees] ([employeeID]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [tasks_employees] ADD CONSTRAINT [definesTaskEmployee] FOREIGN KEY ([taskID],[serviceID])	-- JES GIT
REFERENCES [tasks] ([taskID],[serviceID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [tasks_parts] ADD CONSTRAINT [definesPartTask] FOREIGN KEY ([partID])						-- JES GIT
REFERENCES [parts] ([partID]) ON DELETE NO ACTION ON UPDATE CASCADE
GO

ALTER TABLE [tasks_parts] ADD CONSTRAINT [definesTaskPart] FOREIGN KEY ([taskID],[serviceID])			-- JES GIT
REFERENCES [tasks] ([taskID],[serviceID]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [employees] ADD CONSTRAINT [personIsEmployee] FOREIGN KEY ([employeeID])
REFERENCES [persons] ([personID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [customers] ADD CONSTRAINT [personIsCustomer] FOREIGN KEY ([customerID])
REFERENCES [persons] ([personID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
