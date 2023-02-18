using Microsoft.EntityFrameworkCore;
using WrenchWorks.Models;

namespace WrenchWorks.SeedData;

public class BruteForceSeed
{
	public static void bfSeedData(ModelBuilder modelBuilder)
	{
		#region FuelType
		modelBuilder.Entity<FuelType>().HasData(
			new FuelType { Fuel = "Petrol" },
			new FuelType { Fuel = "Diesel" },
			new FuelType { Fuel = "Electric" },
			new FuelType { Fuel = "Hydrogen" },
			new FuelType { Fuel = "Nuclear" }
		);
		#endregion
		
		#region BodyColor
		modelBuilder.Entity<BodyColor>().HasData(
			new BodyColor { Color = "Red" },
			new BodyColor { Color = "Blue" },
			new BodyColor { Color = "Green" },
			new BodyColor { Color = "Yellow" },
			new BodyColor { Color = "Orange" },
			new BodyColor { Color = "Black" },
			new BodyColor { Color = "White" },
			new BodyColor { Color = "Silver" },
			new BodyColor { Color = "Gray" },
			new BodyColor { Color = "Gold" },
			new BodyColor { Color = "Brown" },
			new BodyColor { Color = "Purple" },
			new BodyColor { Color = "Bronze" },
			new BodyColor { Color = "Pink" },
			new BodyColor { Color = "Beige" },
			new BodyColor { Color = "CUSTOM" }
		);
		#endregion
		
		#region Position
		modelBuilder.Entity<Position>().HasData(
			new Position { PositionId = 9, SupervisorId = 3, PositionName = "Trainee", ServiceHourRate = (decimal)0.0 },
			new Position
			{
				PositionId = 7, SupervisorId = 4, PositionName = "Assistant Diagonostic Specialist",
				ServiceHourRate = (decimal)0.3
			},
			new Position
			{
				PositionId = 8, SupervisorId = 6, PositionName = "Assistant Automotive Specialist",
				ServiceHourRate = (decimal)0.3
			},
			new Position
			{
				PositionId = 6, SupervisorId = 3, PositionName = "Automotive Specialist", ServiceHourRate = (decimal)0.6
			},
			new Position
			{
				PositionId = 4, SupervisorId = 3, PositionName = "Diagonostic Specialist",
				ServiceHourRate = (decimal)0.6
			},
			new Position
			{
				PositionId = 5, SupervisorId = 1, PositionName = "Quality Specialist", ServiceHourRate = (decimal)0.6
			},
			new Position { PositionId = 3, SupervisorId = 0, PositionName = "Workshop Manager", ServiceHourRate = 1 },
			new Position { PositionId = 2, SupervisorId = 0, PositionName = "Parts Manager", ServiceHourRate = 1 },
			new Position { PositionId = 1, SupervisorId = 0, PositionName = "Quality Engineer", ServiceHourRate = 1 },
			new Position { PositionId = 0, SupervisorId = null, PositionName = "Owner", ServiceHourRate = 1 }
		);
		#endregion
		
		#region Person
		modelBuilder.Entity<Person>().HasData(
			new Person
			{
				PersonId = 1, FirstName = "Konrad", LastName = "Dabrowski", TelephoneNumber = "555-555-1212",
				Email = "konrad.dabrowski@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 2, FirstName = "Jane", LastName = "Doe", TelephoneNumber = "555-555-1213",
				Email = "jane.doe@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 3, FirstName = "Bob", LastName = "Smith", TelephoneNumber = "555-555-1214",
				Email = "bob.smith@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 4, FirstName = "Emily", LastName = "Johnson", TelephoneNumber = "555-555-1215",
				Email = "emily.johnson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 5, FirstName = "DavPersonId", LastName = "Lee", TelephoneNumber = "555-555-1216",
				Email = "davPersonId.lee@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 6, FirstName = "Sarah", LastName = "Kim", TelephoneNumber = "555-555-1217",
				Email = "sarah.kim@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 7, FirstName = "Michael", LastName = "Miller", TelephoneNumber = "555-555-1218",
				Email = "michael.miller@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 8, FirstName = "Ashley", LastName = "Anderson", TelephoneNumber = "555-555-1219",
				Email = "ashley.anderson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 9, FirstName = "Daniel", LastName = "Martin", TelephoneNumber = "555-555-1220",
				Email = "daniel.martin@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 10, FirstName = "Jessica", LastName = "Taylor", TelephoneNumber = "555-555-1221",
				Email = "jessica.taylor@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 11, FirstName = "Richard", LastName = "Jackson", TelephoneNumber = "555-555-1222",
				Email = "richard.jackson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 12, FirstName = "Laura", LastName = "Lopez", TelephoneNumber = "555-555-1223",
				Email = "laura.lopez@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 13, FirstName = "Kevin", LastName = "Clark", TelephoneNumber = "555-555-1224",
				Email = "kevin.clark@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 14, FirstName = "Karen", LastName = "Harris", TelephoneNumber = "555-555-1225",
				Email = "karen.harris@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 15, FirstName = "Matthew", LastName = "Lewis", TelephoneNumber = "555-555-1226",
				Email = "matthew.lewis@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 16, FirstName = "Cynthia", LastName = "Allen", TelephoneNumber = "555-555-1227",
				Email = "cynthia.allen@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 17, FirstName = "Thomas", LastName = "Young", TelephoneNumber = "555-555-1228",
				Email = "thomas.young@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 18, FirstName = "Rachel", LastName = "Hall", TelephoneNumber = "555-555-1229",
				Email = "rachel.hall@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 19, FirstName = "Eric", LastName = "Ramirez", TelephoneNumber = "555-555-1230",
				Email = "eric.ramirez@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 20, FirstName = "Nancy", LastName = "Scott", TelephoneNumber = "555-555-1231",
				Email = "nancy.scott@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 21, FirstName = "Maria", LastName = "Wright", TelephoneNumber = "555-555-1232",
				Email = "maria.wright@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 22, FirstName = "Patrick", LastName = "King", TelephoneNumber = "555-555-1233",
				Email = "patrick.king@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 23, FirstName = "Michelle", LastName = "Lee", TelephoneNumber = "555-555-1234",
				Email = "michelle.lee@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 24, FirstName = "Scott", LastName = "Baker", TelephoneNumber = "555-555-1235",
				Email = "scott.baker@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 25, FirstName = "Amy", LastName = "Gonzalez", TelephoneNumber = "555-555-1236",
				Email = "amy.gonzalez@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 26, FirstName = "Timothy", LastName = "Nelson", TelephoneNumber = "555-555-1237",
				Email = "timothy.nelson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 27, FirstName = "Rebecca", LastName = "Carter", TelephoneNumber = "555-555-1238",
				Email = "rebecca.carter@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 28, FirstName = "Adam", LastName = "Morris", TelephoneNumber = "555-555-1239",
				Email = "adam.morris@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 29, FirstName = "Stephanie", LastName = "Murphy", TelephoneNumber = "555-555-1240",
				Email = "stephanie.murphy@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 30, FirstName = "Jason", LastName = "Parker", TelephoneNumber = "555-555-1241",
				Email = "jason.parker@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 31, FirstName = "Amanda", LastName = "Cooper", TelephoneNumber = "555-555-1242",
				Email = "amanda.cooper@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 32, FirstName = "Jeffrey", LastName = "Reed", TelephoneNumber = "555-555-1243",
				Email = "jeffrey.reed@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 33, FirstName = "Angela", LastName = "Phillips", TelephoneNumber = "555-555-1244",
				Email = "angela.phillips@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 34, FirstName = "Keith", LastName = "Campbell", TelephoneNumber = "555-555-1245",
				Email = "keith.campbell@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 35, FirstName = "Melissa", LastName = "Bailey", TelephoneNumber = "555-555-1246",
				Email = "melissa.bailey@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 36, FirstName = "Joshua", LastName = "Flores", TelephoneNumber = "555-555-1247",
				Email = "joshua.flores@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 37, FirstName = "Derek", LastName = "Cox", TelephoneNumber = "555-555-1249",
				Email = "derek.cox@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 38, FirstName = "Sara", LastName = "Adams", TelephoneNumber = "555-555-1250",
				Email = "sara.adams@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 39, FirstName = "Justin", LastName = "Green", TelephoneNumber = "555-555-1251",
				Email = "justin.green@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 40, FirstName = "John", LastName = "Anderson", TelephoneNumber = "555-555-1252",
				Email = "john.anderson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 41, FirstName = "Samantha", LastName = "Johnson", TelephoneNumber = "555-555-1253",
				Email = "samantha.johnson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 42, FirstName = "Andrew", LastName = "Smith", TelephoneNumber = "555-555-1254",
				Email = "andrew.smith@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 43, FirstName = "Olivia", LastName = "Johnson", TelephoneNumber = "555-555-1255",
				Email = "olivia.johnson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 44, FirstName = "Megan", LastName = "Davis", TelephoneNumber = "555-555-1256",
				Email = "megan.davis@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 45, FirstName = "Ethan", LastName = "Brown", TelephoneNumber = "555-555-1257",
				Email = "ethan.brown@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 46, FirstName = "Lauren", LastName = "Johnson", TelephoneNumber = "555-555-1258",
				Email = "lauren.johnson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 47, FirstName = "Anthony", LastName = "Williams", TelephoneNumber = "555-555-1259",
				Email = "anthony.williams@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 48, FirstName = "Victoria", LastName = "Smith", TelephoneNumber = "555-555-1260",
				Email = "victoria.smith@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 49, FirstName = "Brian", LastName = "Jackson", TelephoneNumber = "555-555-1261",
				Email = "brian.jackson@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 50, FirstName = "Elizabeth", LastName = "Jones", TelephoneNumber = "555-555-1262",
				Email = "elizabeth.jones@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 51, FirstName = "Christopher", LastName = "Smith", TelephoneNumber = "555-555-1263",
				Email = "christopher.smith@WrenchWorksEmail.com"
			},
			new Person
			{
				PersonId = 52, FirstName = "Kelly", LastName = "Taylor", TelephoneNumber = "555-555-1264",
				Email = "kelly.taylor@WrenchWorksEmail.com"
			}
		);
		#endregion
		
		#region Address
		modelBuilder.Entity<Address>().HasData(
			new Address{ AddressId=1,Region="Washington",City="Seattle",Street="1st Ave N",BuildingNo="89",FlatNo=null,PostCode="98109"},
			new Address{ AddressId=2,Region="New York",City="New York",Street="5th Ave",BuildingNo="7A",FlatNo=null,PostCode="10001"},
			new Address{ AddressId=3,Region="Illinois",City="Chicago",Street="W Madison St",BuildingNo="57",FlatNo="10A",PostCode="60606"},
			new Address{ AddressId=4,Region="California",City="Los Angeles",Street="S Figueroa St",BuildingNo="22",FlatNo="7B",PostCode="90015"},
			new Address{ AddressId=5,Region="Florida",City="Miami",Street="Collins Ave",BuildingNo="99",FlatNo=null,PostCode="33140"},
			new Address{ AddressId=6,Region="Michigan",City="Detroit",Street="Grand River Ave",BuildingNo="75",FlatNo="5C",PostCode="48227"},
			new Address{ AddressId=7,Region="California",City="San Francisco",Street="Mission St",BuildingNo="18",FlatNo="2B",PostCode="94103"},
			new Address{ AddressId=8,Region="Massachusetts",City="Boston",Street="Beacon St",BuildingNo="42",FlatNo="12A",PostCode="2108"},
			new Address{ AddressId=9,Region="Texas",City="Dallas",Street="Main St",BuildingNo="12",FlatNo="1A",PostCode="75201"},
			new Address{ AddressId=10,Region="Pennsylvania",City="Philadelphia",Street="S Broad St",BuildingNo="38",FlatNo="3C",PostCode="19102"},
			new Address{ AddressId=11,Region="Missouri",City="St. Louis",Street="Market St",BuildingNo="8",FlatNo="4A",PostCode="63101"},
			new Address{ AddressId=12,Region="Georgia",City="Atlanta",Street="Peachtree St",BuildingNo="54",FlatNo="9B",PostCode="30309"},
			new Address{ AddressId=13,Region="Oregon",City="Portland",Street="SW 6th Ave",BuildingNo="95",FlatNo="8C",PostCode="97204"},
			new Address{ AddressId=14,Region="Florida",City="Orlando",Street="International Dr",BuildingNo="7",FlatNo=null,PostCode="32819"},
			new Address{ AddressId=15,Region="Colorado",City="Denver",Street="16th St Mall",BuildingNo="31",FlatNo="3B",PostCode="80202"},
			new Address{ AddressId=16,Region="Minnesota",City="Minneapolis",Street="Hennepin Ave",BuildingNo="41",FlatNo="5C",PostCode="55403"},
			new Address{ AddressId=17,Region="Tennessee",City="Nashville",Street="Broadway",BuildingNo="64",FlatNo="1B",PostCode="37203"},
			new Address{ AddressId=18,Region="New Jersey",City="Newark",Street="Market St",BuildingNo="31",FlatNo="6A",PostCode="7102"},
			new Address{ AddressId=19,Region="Missouri",City="Kansas City",Street="Main St",BuildingNo="96",FlatNo="9C",PostCode="64105"},
			new Address{ AddressId=20,Region="Texas",City="Houston",Street="Main St",BuildingNo="71",FlatNo="4A",PostCode="77002"},
			new Address{ AddressId=21,Region="Arizona",City="Phoenix",Street="W Van Buren St",BuildingNo="10",FlatNo="8B",PostCode="85003"},
			new Address{ AddressId=22,Region="Pennsylvania",City="Pittsburgh",Street="Forbes Ave",BuildingNo="13",FlatNo=null,PostCode="15222"},
			new Address{ AddressId=23,Region="North Carolina",City="Raleigh",Street="Wilmington St",BuildingNo="37",FlatNo="6A",PostCode="27601"},
			new Address{ AddressId=24,Region="Indiana",City="Indianapolis",Street="Meridian St",BuildingNo="33",FlatNo="2B",PostCode="46204"},
			new Address{ AddressId=25,Region="Washington",City="Spokane",Street="Riverside Ave",BuildingNo="28",FlatNo="3C",PostCode="99201"},
			new Address{ AddressId=26,Region="Texas",City="Austin",Street="S Congress Ave",BuildingNo="47",FlatNo="7B",PostCode="78704"},
			new Address{ AddressId=27,Region="Oregon",City="Portland",Street="NW 23rd Ave",BuildingNo="79",FlatNo="4B",PostCode="97210"},
			new Address{ AddressId=28,Region="New Jersey",City="Jersey City",Street="Newark Ave",BuildingNo="23",FlatNo=null,PostCode="7302"},
			new Address{ AddressId=29,Region="Wisconsin",City="Milwaukee",Street="E Wisconsin Ave",BuildingNo="18",FlatNo="6C",PostCode="53202"},
			new Address{ AddressId=30,Region="Florida",City="Jacksonville",Street="Monroe St",BuildingNo="36",FlatNo="10B",PostCode="32202"},
			new Address{ AddressId=31,Region="California",City="Sacramento",Street="K St",BuildingNo="84",FlatNo="5A",PostCode="95814"},
			new Address{ AddressId=32,Region="Maryland",City="Baltimore",Street="E Lombard St",BuildingNo="31",FlatNo=null,PostCode="21202"},
			new Address{ AddressId=33,Region="Florida",City="Tampa",Street="Channelside Dr",BuildingNo="32",FlatNo="8A",PostCode="33602"},
			new Address{ AddressId=34,Region="Ohio",City="Cleveland",Street="Public Square",BuildingNo="10",FlatNo="10C",PostCode="44113"},
			new Address{ AddressId=35,Region="Idaho",City="Boise",Street="8th St",BuildingNo="46",FlatNo="5B",PostCode="83702"},
			new Address{ AddressId=36,Region="New Mexico",City="Albuquerque",Street="Central Ave",BuildingNo="85",FlatNo="7C",PostCode="87102"},
			new Address{ AddressId=37,Region="Washington",City="Seattle",Street="Pike St",BuildingNo="45",FlatNo="2C",PostCode="98101"},
			new Address{ AddressId=38,Region="District of Columbia",City="Washington",Street="Constitution Ave NW",BuildingNo="2",FlatNo="11A",PostCode="20500"},
			new Address{ AddressId=39,Region="Florida",City="Miami",Street="Biscayne Blvd",BuildingNo="56",FlatNo="9C",PostCode="33132"},
			new Address{ AddressId=40,Region="New York",City="New York",Street=" 5th Ave",BuildingNo=" 8B",FlatNo=null,PostCode="10001"}
		);
			#endregion

		#region Employee
		modelBuilder.Entity<Employee>().HasData(
			new Employee { EmployeeId = 1, DateOfEmployment = new DateTime(2010, 4, 20), PositionName = "Owner" },
			new Employee
				{ EmployeeId = 2, DateOfEmployment = new DateTime(2012, 5, 20), PositionName = "Workshop Manager" },
			new Employee
			{
				EmployeeId = 3, DateOfEmployment = new DateTime(2013, 3, 14), PositionName = "Automotive Specialist"
			},
			new Employee
				{ EmployeeId = 4, DateOfEmployment = new DateTime(2014, 4, 16), PositionName = "Parts Manager" },
			new Employee
			{
				EmployeeId = 5, DateOfEmployment = new DateTime(2015, 1, 10), PositionName = "Diagonostic Specialist"
			},
			new Employee
				{ EmployeeId = 6, DateOfEmployment = new DateTime(2015, 10, 6), PositionName = "Quality Engineer" },
			new Employee
				{ EmployeeId = 7, DateOfEmployment = new DateTime(2016, 7, 1), PositionName = "Quality Specialist" },
			new Employee
			{
				EmployeeId = 8, DateOfEmployment = new DateTime(2017, 3, 27), PositionName = "Automotive Specialist"
			},
			new Employee
			{
				EmployeeId = 9, DateOfEmployment = new DateTime(2017, 12, 21), PositionName = "Automotive Specialist"
			},
			new Employee
				{ EmployeeId = 10, DateOfEmployment = new DateTime(2018, 9, 16), PositionName = "Quality Specialist" },
			new Employee
			{
				EmployeeId = 11, DateOfEmployment = new DateTime(2019, 6, 12), PositionName = "Diagonostic Specialist"
			},
			new Employee
			{
				EmployeeId = 12, DateOfEmployment = new DateTime(2020, 3, 7),
				PositionName = "Assistant Automotive Specialist"
			},
			new Employee
			{
				EmployeeId = 13, DateOfEmployment = new DateTime(2020, 12, 1),
				PositionName = "Assistant Diagonostic Specialist"
			},
			new Employee { EmployeeId = 14, DateOfEmployment = new DateTime(2021, 8, 27), PositionName = "Trainee" }
		);
		#endregion
		
		#region Customer
		modelBuilder.Entity<Customer>().HasData(
			new Customer { CustomerId = 1, Nip = "123456789" },
			new Customer { CustomerId = 6, Nip = "987654321" },
			new Customer { CustomerId = 7, Nip = null },
			new Customer { CustomerId = 9, Nip = null },
			new Customer { CustomerId = 10, Nip = null },
			new Customer { CustomerId = 14, Nip = "876543219" },
			new Customer { CustomerId = 15, Nip = "456789123" },
			new Customer { CustomerId = 16, Nip = "912345678" },
			new Customer { CustomerId = 17, Nip = null },
			new Customer { CustomerId = 18, Nip = null },
			new Customer { CustomerId = 19, Nip = null },
			new Customer { CustomerId = 20, Nip = null },
			new Customer { CustomerId = 21, Nip = null },
			new Customer { CustomerId = 22, Nip = null },
			new Customer { CustomerId = 23, Nip = "202481772" },
			new Customer { CustomerId = 24, Nip = "203720552" },
			new Customer { CustomerId = 25, Nip = "204959332" },
			new Customer { CustomerId = 26, Nip = "206198112" },
			new Customer { CustomerId = 27, Nip = null },
			new Customer { CustomerId = 28, Nip = null },
			new Customer { CustomerId = 29, Nip = null },
			new Customer { CustomerId = 30, Nip = null },
			new Customer { CustomerId = 31, Nip = null },
			new Customer { CustomerId = 32, Nip = "213630792" },
			new Customer { CustomerId = 33, Nip = "214869572" },
			new Customer { CustomerId = 34, Nip = "216108352" },
			new Customer { CustomerId = 35, Nip = "217347132" },
			new Customer { CustomerId = 36, Nip = "218585912" },
			new Customer { CustomerId = 37, Nip = "219824692" },
			new Customer { CustomerId = 38, Nip = null },
			new Customer { CustomerId = 39, Nip = "222302252" },
			new Customer { CustomerId = 40, Nip = "223541032" },
			new Customer { CustomerId = 41, Nip = "224779812" },
			new Customer { CustomerId = 42, Nip = "226018592" },
			new Customer { CustomerId = 43, Nip = "227257372" },
			new Customer { CustomerId = 44, Nip = "228496152" },
			new Customer { CustomerId = 45, Nip = null },
			new Customer { CustomerId = 46, Nip = null },
			new Customer { CustomerId = 47, Nip = null },
			new Customer { CustomerId = 48, Nip = null },
			new Customer { CustomerId = 49, Nip = null },
			new Customer { CustomerId = 50, Nip = "235928832" },
			new Customer { CustomerId = 51, Nip = "237167612" },
			new Customer { CustomerId = 52, Nip = "238406392" }
			);
		#endregion
		
		#region Vehicle
		modelBuilder.Entity<Vehicle>().HasData(
			new Vehicle { Vin = "3FNRLW2BT3VWLLT7W",Maker="Renault",Model="Laguna",YearOfProduction= new DateTime(2008,01,01),EngineCapacity=2.0m,PowerSource="Diesel",EngineNo=null,BodyColor="Black",PersonId=1},
			new Vehicle { Vin = "37D2AJLFEK7G6194W",Maker="Fiat",Model="126p",YearOfProduction= new DateTime(1954,01,01),EngineCapacity=null,PowerSource="Nuclear",EngineNo=null,BodyColor="Gold",PersonId=1},
			new Vehicle { Vin = "1G4EC11C4JB901987",Maker="Bugatti",Model="Veyron",YearOfProduction= new DateTime(2015,01,06),EngineCapacity=7.0m,PowerSource="Petrol",EngineNo="VB-101",BodyColor="Black",PersonId=1},
			new Vehicle { Vin = "1G4EC11C4JB901988",Maker="Pagani",Model="Huayra",YearOfProduction= new DateTime(2020,01,01),EngineCapacity=6.0m,PowerSource="Petrol",EngineNo="PH-101",BodyColor="Silver",PersonId=1},
			new Vehicle { Vin = "1G4EC11C4JB901989",Maker="McLaren",Model="P1",YearOfProduction= new DateTime(2017,01,07),EngineCapacity=null,PowerSource="Electric",EngineNo="MP-101",BodyColor="Red",PersonId=1},
			new Vehicle { Vin = "1G4EC11C4JB901990",Maker="Koenigsegg",Model="Agera",YearOfProduction= new DateTime(2019,01,11),EngineCapacity=4.2m,PowerSource="Petrol",EngineNo="KK-101",BodyColor="CUSTOM",PersonId=1},
			new Vehicle { Vin = "1G4EC11C4JB901991",Maker="Rimac",Model="C_Two",YearOfProduction= new DateTime(2022,01,05),EngineCapacity=null,PowerSource="Electric",EngineNo="RC-101",BodyColor="Orange",PersonId=1},
			new Vehicle { Vin = "2HNYD2H31DH501112",Maker="Acura",Model="MDX",YearOfProduction= new DateTime(2020,01,01),EngineCapacity=3.5m,PowerSource="Petrol",EngineNo="2ZQYF1111P5397859",BodyColor="Red",PersonId=6},
			new Vehicle { Vin = "WBAJB0C51BC532336",Maker="BMW",Model="535i",YearOfProduction= new DateTime(2018,01,01),EngineCapacity=3.0m,PowerSource="Petrol",EngineNo="W9D0W1111T4302306",BodyColor="Silver",PersonId=6},
			new Vehicle { Vin = "1FT7W2BT3DEB02692",Maker="Ford",Model="F-250",YearOfProduction= new DateTime(2021,01,01),EngineCapacity=6.7m,PowerSource="Diesel",EngineNo="6PXYB1111W9725625",BodyColor="Gray",PersonId=7},
			new Vehicle { Vin = "5J6RM4H33EL032008",Maker="Honda",Model="CR-V",YearOfProduction= new DateTime(2022,01,01),EngineCapacity=null,PowerSource="Electric",EngineNo="3YVBH1111V0791189",BodyColor="Silver",PersonId=7},
			new Vehicle { Vin = "5FNRL6H94JB058408",Maker="Honda",Model="Odyssey",YearOfProduction= new DateTime(2018,01,01),EngineCapacity=3.5m,PowerSource="Petrol",EngineNo="2MYKG1111B2611752",BodyColor="White",PersonId=6},
			new Vehicle { Vin = "1C4SDHCT2EC518481",Maker="Dodge",Model="Durango",YearOfProduction= new DateTime(2022,01,01),EngineCapacity=5.7m,PowerSource="Petrol",EngineNo="1JGYK1111V0214294",BodyColor="Yellow",PersonId=7},
			new Vehicle { Vin = "4T1BD1FK3FU060871",Maker="Toyota",Model="Camry",YearOfProduction= new DateTime(2019,01,01),EngineCapacity=2.5m,PowerSource="Petrol",EngineNo="4BCCX1111P5876452",BodyColor="Gray",PersonId=9},
			new Vehicle { Vin = "2C3CDXHG1EH218905",Maker="Dodge",Model="Charger",YearOfProduction= new DateTime(2020,01,01),EngineCapacity=3.6m,PowerSource="Petrol",EngineNo="9MPVD1111P0385937",BodyColor="Blue",PersonId=9},
			new Vehicle { Vin = "2GNAXTEV8J6252726",Maker="Chevrolet",Model="Equinox",YearOfProduction= new DateTime(2021,01,01),EngineCapacity=2.0m,PowerSource="Petrol",EngineNo="5SMPG1111S2985843",BodyColor="Red",PersonId=10},
			new Vehicle { Vin = "WBAVA375X9NL06323",Maker="BMW",Model="328i",YearOfProduction= new DateTime(2018,01,01),EngineCapacity=3.0m,PowerSource="Petrol",EngineNo="2HBKM1111P5848492",BodyColor="Black",PersonId=14},
			new Vehicle { Vin = "1FTFW1ET0DFC21909",Maker="Ford",Model="F-150",YearOfProduction= new DateTime(2019,01,01),EngineCapacity=3.5m,PowerSource="Petrol",EngineNo="5ZKDK1111P1182258",BodyColor="Green",PersonId=14},
			new Vehicle { Vin = "1HGCV1F34JA033044",Maker="Honda",Model="Accord",YearOfProduction= new DateTime(2022,01,01),EngineCapacity=2.0m,PowerSource="Petrol",EngineNo="P5BYF1111V4546335",BodyColor="Red",PersonId=14},
			new Vehicle { Vin = "1GYS4CKJ4GR228491",Maker="Cadillac",Model="Escalade",YearOfProduction= new DateTime(2018,01,01),EngineCapacity=6.2m,PowerSource="Petrol",EngineNo="8FZJX1111V0240869",BodyColor="Gold",PersonId=15},
			new Vehicle { Vin = "2GTEK19B571125541",Maker="GMC",Model="Sierra 1500",YearOfProduction= new DateTime(2022,01,01),EngineCapacity=5.3m,PowerSource="Petrol",EngineNo="8MCJH1111V7826965",BodyColor="Blue",PersonId=15},
			new Vehicle { Vin = "3VWLL7AJ3BM029633",Maker="Volkswagen",Model="Jetta",YearOfProduction= new DateTime(2018,01,01),EngineCapacity=2.0m,PowerSource="Petrol",EngineNo="8MYRY1111W1564311",BodyColor="White",PersonId=15},
			new Vehicle { Vin = "1GKS1CE04BR207052",Maker="GMC",Model="Yukon",YearOfProduction= new DateTime(2020,01,01),EngineCapacity=5.0m,PowerSource="Petrol",EngineNo="8MCJH132142269653",BodyColor="CUSTOM",PersonId=16},
			new Vehicle { Vin = "EHV2T37F7T7VJVC26",Maker="Porsche",Model="911 GT3",YearOfProduction= new DateTime(2022,01,06),EngineCapacity=4.0m,PowerSource="Petrol",EngineNo="26KJGF2876KJDJKS1",BodyColor="Yellow",PersonId=16},
			new Vehicle { Vin = "5G5JZ18N8SL872546",Maker="Toyota",Model="Supra",YearOfProduction= new DateTime(2022,01,10),EngineCapacity=3.0m,PowerSource="Petrol",EngineNo="0ZLKJ89375KNKJ239",BodyColor="Red",PersonId=17},
			new Vehicle { Vin = "3K3NT53X9XN433870",Maker="BMW",Model="530e",YearOfProduction= new DateTime(2021,01,09),EngineCapacity=2.0m,PowerSource="Electric",EngineNo="45JH9NB789JK8HJ22",BodyColor="White",PersonId=18},
			new Vehicle { Vin = "2T3WFREV3GW293769",Maker="Nissan",Model="GT-R",YearOfProduction= new DateTime(2023,01,02),EngineCapacity=3.8m,PowerSource="Petrol",EngineNo="982LKJHKJH8JHKL18",BodyColor="Gray",PersonId=19},
			new Vehicle { Vin = "2C4RC1BG6LR224413",Maker="Ford",Model="Mustang GT",YearOfProduction= new DateTime(2023,01,01),EngineCapacity=5.0m,PowerSource="Petrol",EngineNo="6YHJB7868NBHJ4564",BodyColor="White",PersonId=20},
			new Vehicle { Vin = "4JGDA5JB7HA946036",Maker="Lexus",Model="GX 460",YearOfProduction= new DateTime(2023,01,01),EngineCapacity=4.6m,PowerSource="Petrol",EngineNo="8IKJH7865HJKL9876",BodyColor="White",PersonId=21},
			new Vehicle { Vin = "WDDWJ8KB2KF684794",Maker="Mercedes-Benz",Model="S 63 AMG",YearOfProduction= new DateTime(2023,01,01),EngineCapacity=4.0m,PowerSource="Petrol",EngineNo="56GJH879NBV5432RT",BodyColor="Blue",PersonId=22},
			new Vehicle { Vin = "2C4RC1BG7JR215755",Maker="Chevrolet",Model="Camaro ZL1",YearOfProduction= new DateTime(2023,01,02),EngineCapacity=6.2m,PowerSource="Petrol",EngineNo="7HJ7865LKJHJ7865K",BodyColor="Black",PersonId=23},
			new Vehicle { Vin = "2GNFLFEK7G6194764",Maker="Audi",Model="RS7",YearOfProduction= new DateTime(2022,01,08),EngineCapacity=4.0m,PowerSource="Petrol",EngineNo="4HJK56LKJH98KJH11",BodyColor="Silver",PersonId=24},
			new Vehicle { Vin = "WAUA2AFD2DN019030",Maker="Dodge",Model="Viper SRT",YearOfProduction= new DateTime(2023,01,02),EngineCapacity=8.4m,PowerSource="Petrol",EngineNo="9NB7865HJKL9087KJ",BodyColor="Red",PersonId=25},
			new Vehicle { Vin = "JTHBK1GG7D2027441",Maker="Lamborghini",Model="Huracan",YearOfProduction= new DateTime(2021,01,10),EngineCapacity=5.2m,PowerSource="Petrol",EngineNo="65HJK87LKJHJ9087G",BodyColor="Yellow",PersonId=26},
			new Vehicle { Vin = "4USBT33534LS49963",Maker="Volkswagen",Model="Golf GTI",YearOfProduction= new DateTime(2023,01,01),EngineCapacity=2.0m,PowerSource="Petrol",EngineNo="87LKJHJ9087G65HJK",BodyColor="Gray",PersonId=27},
			new Vehicle { Vin = "JTHBW1GG7D2000178",Maker="McLaren",Model="765LT",YearOfProduction= new DateTime(2023,01,02),EngineCapacity=4.0m,PowerSource="Petrol",EngineNo="786LKJH9087GHJ987",BodyColor="Orange",PersonId=27},
			new Vehicle { Vin = "4T1BF1FK7CU510635",Maker="Subaru",Model="WRX STI",YearOfProduction= new DateTime(2023,01,01),EngineCapacity=2.5m,PowerSource="Petrol",EngineNo="67LKJHJ9087G65HJK",BodyColor="White",PersonId=28},
			new Vehicle { Vin = "3VW447AU5FM042417",Maker="Tesla",Model="Model S",YearOfProduction= new DateTime(2023,01,01),EngineCapacity=0.0m,PowerSource="Electric",EngineNo="456LKJH9087GHJ987",BodyColor="CUSTOM",PersonId=29},
			new Vehicle { Vin = "JTHBK1EG8C2417764",Maker="Lexus",Model="ES",YearOfProduction= new DateTime(2020,11,07),EngineCapacity=null,PowerSource="Electric",EngineNo="5X6B1C6U4Z4L1A8B",BodyColor="Gray",PersonId=30},
			new Vehicle { Vin = "2GTEK19J441270429",Maker="GMC",Model="Sierra",YearOfProduction= new DateTime(2021,08,08),EngineCapacity=5.3m,PowerSource="Diesel",EngineNo="6E2G6C3U3A5H8D9L",BodyColor="Green",PersonId=30},
			new Vehicle { Vin = "1ZVFT80N055185407",Maker="Ford",Model="Mustang",YearOfProduction= new DateTime(2022,01,02),EngineCapacity=4.0m,PowerSource="Petrol",EngineNo="4U6C4U4C2U8D2H6N",BodyColor="Red",PersonId=31},
			new Vehicle { Vin = "JM1NC2MF9E0234389",Maker="Mazda",Model="MX-5 Miata",YearOfProduction= new DateTime(2023,01,05),EngineCapacity=null,PowerSource="Hydrogen",EngineNo="1N6F1N8B9X9X2P3G",BodyColor="Blue",PersonId=32},
			new Vehicle { Vin = "KMHDN46D04U643031",Maker="Hyundai",Model="Elantra",YearOfProduction= new DateTime(2020,01,09),EngineCapacity=2.0m,PowerSource="Diesel",EngineNo="9T8W8C8J3V7R7J1K",BodyColor="Silver",PersonId=null},
			new Vehicle { Vin = "1J8GR48K47C155348",Maker="Jeep",Model="Grand Cherokee",YearOfProduction= new DateTime(2023,01,03),EngineCapacity=null,PowerSource="Nuclear",EngineNo="3V7W8X9F9V7D7R1N",BodyColor="Bronze",PersonId=null},
			new Vehicle { Vin = "1N4BL4BV4KC183758",Maker="Nissan",Model="Altima",YearOfProduction= new DateTime(2022,01,09),EngineCapacity=2.5m,PowerSource="Petrol",EngineNo="5L6E5S6H5S6S5E6U",BodyColor="Green",PersonId=null},
			new Vehicle { Vin = "1FMZU77K74UB33195",Maker="Ford",Model="Explorer",YearOfProduction= new DateTime(2022,01,06),EngineCapacity=null,PowerSource="Diesel",EngineNo="6W8V7B2D2U2V7B4F",BodyColor="Black",PersonId=null},
			new Vehicle { Vin = "1N4AL3AP9EC215201",Maker="Nissan",Model="Altima",YearOfProduction= new DateTime(2023,01,01),EngineCapacity=null,PowerSource="Electric",EngineNo="2J2W8R8J4D6E1A7M",BodyColor="Yellow",PersonId=35},
			new Vehicle { Vin = "1FTEW1E53MKE12935",Maker="Ford",Model="F-150",YearOfProduction= new DateTime(2021,01,11),EngineCapacity=3.5m,PowerSource="Petrol",EngineNo="1J8A2E2Z2A7P5K5C",BodyColor="Silver",PersonId=36},
			new Vehicle { Vin = "1G1PC5SB8E7182468",Maker="Chevrolet",Model="Volt",YearOfProduction= new DateTime(2021,01,02),EngineCapacity=null,PowerSource="Hydrogen",EngineNo="8G2C2G9X7J2D2B8R",BodyColor="Yellow",PersonId=37},
			new Vehicle { Vin = "1N4AA5AP3AC805981",Maker="Nissan",Model="Maxima",YearOfProduction= new DateTime(2023,03,01),EngineCapacity=3.5m,PowerSource="Petrol",EngineNo="4S5E5N5F5R5S2S5G",BodyColor="Purple",PersonId=38},
			new Vehicle { Vin = "1G1JE6SB1C4183312",Maker="Chevrolet",Model="Volt",YearOfProduction= new DateTime(2020,05,11),EngineCapacity=null,PowerSource="Nuclear",EngineNo="9L9F1D1G8H8D8N8C",BodyColor="Brown",PersonId=39},
			new Vehicle { Vin = "1J8GR48K47C828206",Maker="Jeep",Model="Grand Cherokee",YearOfProduction= new DateTime(2022,02,05),EngineCapacity=3.0m,PowerSource="Diesel",EngineNo="1C6E3W8V3C3H9X7V",BodyColor="Green",PersonId=40},
			new Vehicle { Vin = "2HGFG4A50CH701101",Maker="Honda",Model="Accord",YearOfProduction= new DateTime(2021,01,08),EngineCapacity=null,PowerSource="Petrol",EngineNo="3D68H7G59E56A8R7V",BodyColor="Red",PersonId=41},
			new Vehicle { Vin = "1HGCM66594A098237",Maker="Honda",Model="Accord",YearOfProduction= new DateTime(2017,01,04),EngineCapacity=null,PowerSource="Petrol",EngineNo="4G65Y4H98C78B4J1N",BodyColor="Blue",PersonId=42},
			new Vehicle { Vin = "3D7JB1EP3BG707058",Maker="Dodge",Model="Ram",YearOfProduction= new DateTime(2022,01,02),EngineCapacity=null,PowerSource="Diesel",EngineNo="6T09F9R13B97D2L1F",BodyColor="Gray",PersonId=43},
			new Vehicle { Vin = "JH4DB7663RS001474",Maker="Acura",Model="Legend",YearOfProduction= new DateTime(1994,01,01),EngineCapacity=2.5m,PowerSource="Petrol",EngineNo="5C36J1Y43A06D5H2P",BodyColor="Green",PersonId=44},
			new Vehicle { Vin = "2HGES165X9H533726",Maker="Honda",Model="Civic",YearOfProduction= new DateTime(2009,01,10),EngineCapacity=null,PowerSource="Petrol",EngineNo="8H65E5L79F57R9J8C",BodyColor="Black",PersonId=45},
			new Vehicle { Vin = "1FTFW1R62EFC81935",Maker="Ford",Model="F-150",YearOfProduction= new DateTime(2014,01,05),EngineCapacity=3.5m,PowerSource="Petrol",EngineNo="6G90T6P24D82F3R6T",BodyColor="Silver",PersonId=46},
			new Vehicle { Vin = "JN1CA21D1XT804210",Maker="Nissan",Model="Maxima",YearOfProduction= new DateTime(1999,01,03),EngineCapacity=3.0m,PowerSource="Petrol",EngineNo="7E08G1M16H28K6U0Y",BodyColor="White",PersonId=47},
			new Vehicle { Vin = "JTHBJ46G992339151",Maker="Lexus",Model="IS",YearOfProduction= new DateTime(2012,01,06),EngineCapacity=null,PowerSource="Petrol",EngineNo="2P85H6L91F24G2E3W",BodyColor="Gray",PersonId=48},
			new Vehicle { Vin = "2G1WT58K979277802",Maker="Chevrolet",Model="Impala",YearOfProduction= new DateTime(2007,01,01),EngineCapacity=3.5m,PowerSource="Petrol",EngineNo="5B17R5E64D34J5G9K",BodyColor="Red",PersonId=49},
			new Vehicle { Vin = "1C3CDFBB5FD333450",Maker="Dodge",Model="Dart",YearOfProduction= new DateTime(2015,01,09),EngineCapacity=2.4m,PowerSource="Petrol",EngineNo="8R16C9T67G94H3L1S",BodyColor="Blue",PersonId=50},
			new Vehicle { Vin = "JH4DA9447HS009086",Maker="Acura",Model="Legend",YearOfProduction= new DateTime(1987,01,11),EngineCapacity=2.7m,PowerSource="Petrol",EngineNo="1L20T6J82E79S4H6K",BodyColor="White",PersonId=51},
			new Vehicle { Vin = "2C4RDGCG4ER147255",Maker="Chrysler",Model="Town & Country",YearOfProduction= new DateTime(2014,01,10),EngineCapacity=null,PowerSource="Petrol",EngineNo="9R38A9G04H71K1L5E",BodyColor="Gray",PersonId=52},
			new Vehicle { Vin = "1FTWW33F62EA44809",Maker="Ford",Model="F-350",YearOfProduction= new DateTime(2002,01,09),EngineCapacity=7.3m,PowerSource="Diesel",EngineNo="2P98D2K57G42L7N1J",BodyColor="Black",PersonId=52},
			new Vehicle { Vin = "1G1BE5SM5H7248785",Maker="Chevrolet",Model="Cruze",YearOfProduction= new DateTime(2017,01,03),EngineCapacity=1.4m,PowerSource="Petrol",EngineNo="4E86D4K75G68L2M4F",BodyColor="Black",PersonId=52},
			new Vehicle { Vin = "1FMCU0DG0BKA06849",Maker="Ford",Model="Escape",YearOfProduction= new DateTime(2011,01,12),EngineCapacity=3.0m,PowerSource="Petrol",EngineNo="7R21K3G87L90B6H3F",BodyColor="Silver",PersonId=52}
		);
		#endregion
		
		#region PowerSource
		modelBuilder.Entity<PowerSource>().HasData(
			new PowerSource { Vin= "3FNRLW2BT3VWLLT7W",MainPowerSourceType= "Diesel",Hybrid=false,Biofuel=false,Lpg=false,Cng=false },
			new PowerSource { Vin="37D2AJLFEK7G6194W",MainPowerSourceType="Nuclear",Hybrid=false,Biofuel=false,Lpg=true,Cng=false },
			new PowerSource { Vin="1G4EC11C4JB901987",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=true,Cng=false},
			new PowerSource { Vin="1G4EC11C4JB901988",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=true},
			new PowerSource { Vin="1G4EC11C4JB901989",MainPowerSourceType="Electric",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1G4EC11C4JB901990",MainPowerSourceType="Petrol",Hybrid=true,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1G4EC11C4JB901991",MainPowerSourceType="Electric",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2HNYD2H31DH501112",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="WBAJB0C51BC532336",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1FT7W2BT3DEB02692",MainPowerSourceType="Diesel",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="5J6RM4H33EL032008",MainPowerSourceType="Electric",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="5FNRL6H94JB058408",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1C4SDHCT2EC518481",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="4T1BD1FK3FU060871",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2C3CDXHG1EH218905",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2GNAXTEV8J6252726",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="WBAVA375X9NL06323",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1FTFW1ET0DFC21909",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1HGCV1F34JA033044",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1GYS4CKJ4GR228491",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2GTEK19B571125541",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="3VWLL7AJ3BM029633",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1GKS1CE04BR207052",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="EHV2T37F7T7VJVC26",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="5G5JZ18N8SL872546",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="3K3NT53X9XN433870",MainPowerSourceType="Electric",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2T3WFREV3GW293769",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2C4RC1BG6LR224413",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="4JGDA5JB7HA946036",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="WDDWJ8KB2KF684794",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2C4RC1BG7JR215755",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2GNFLFEK7G6194764",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="WAUA2AFD2DN019030",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="JTHBK1GG7D2027441",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="4USBT33534LS49963",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="JTHBW1GG7D2000178",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="4T1BF1FK7CU510635",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=true,Cng=false},
			new PowerSource { Vin="3VW447AU5FM042417",MainPowerSourceType="Electric",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="JTHBK1EG8C2417764",MainPowerSourceType="Electric",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2GTEK19J441270429",MainPowerSourceType="Diesel",Hybrid=false,Biofuel=true,Lpg=false,Cng=false},
			new PowerSource { Vin="1ZVFT80N055185407",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="JM1NC2MF9E0234389",MainPowerSourceType="Hydrogen",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="KMHDN46D04U643031",MainPowerSourceType="Diesel",Hybrid=false,Biofuel=false,Lpg=false,Cng=true},
			new PowerSource { Vin="1J8GR48K47C155348",MainPowerSourceType="Nuclear",Hybrid=false,Biofuel=true,Lpg=false,Cng=false},
			new PowerSource { Vin="1N4BL4BV4KC183758",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1FMZU77K74UB33195",MainPowerSourceType="Diesel",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1N4AL3AP9EC215201",MainPowerSourceType="Electric",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1FTEW1E53MKE12935",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=true,Lpg=false,Cng=false},
			new PowerSource { Vin="1G1PC5SB8E7182468",MainPowerSourceType="Hydrogen",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1N4AA5AP3AC805981",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=true,Cng=false},
			new PowerSource { Vin="1G1JE6SB1C4183312",MainPowerSourceType="Nuclear",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1J8GR48K47C828206",MainPowerSourceType="Diesel",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2HGFG4A50CH701101",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=true,Cng=false},
			new PowerSource { Vin="1HGCM66594A098237",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=true,Cng=false},
			new PowerSource { Vin="3D7JB1EP3BG707058",MainPowerSourceType="Diesel",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="JH4DB7663RS001474",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2HGES165X9H533726",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=true,Cng=false},
			new PowerSource { Vin="1FTFW1R62EFC81935",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=true,Cng=false},
			new PowerSource { Vin="JN1CA21D1XT804210",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="JTHBJ46G992339151",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2G1WT58K979277802",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1C3CDFBB5FD333450",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="JH4DA9447HS009086",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="2C4RDGCG4ER147255",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1FTWW33F62EA44809",MainPowerSourceType="Diesel",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1G1BE5SM5H7248785",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false},
			new PowerSource { Vin="1FMCU0DG0BKA06849",MainPowerSourceType="Petrol",Hybrid=false,Biofuel=false,Lpg=false,Cng=false}
		);
		#endregion

		#region Service
		modelBuilder.Entity<Service>().HasData(
			new Service { ServiceId=1,Vin="3FNRLW2BT3VWLLT7W",PaidOff=true,ServiceStartDate= new DateTime(2020,09,28),ServiceEndDate= new DateTime(2020,10,10),CustomerId=1,EmployeeId=2},
			new Service { ServiceId=2,Vin="37D2AJLFEK7G6194W",PaidOff=true,ServiceStartDate= new DateTime(2021,06,03),ServiceEndDate= new DateTime(2021,06,11),CustomerId=1,EmployeeId=2},
			new Service { ServiceId=3,Vin="1G4EC11C4JB901987",PaidOff=true,ServiceStartDate= new DateTime(2015,07,05),ServiceEndDate= new DateTime(2015,07,19),CustomerId=1,EmployeeId=2},
			new Service { ServiceId=4,Vin="1G4EC11C4JB901988",PaidOff=true,ServiceStartDate= new DateTime(2020,01,21),ServiceEndDate= new DateTime(2020,01,26),CustomerId=1,EmployeeId=2},
			new Service { ServiceId=5,Vin="1G4EC11C4JB901989",PaidOff=true,ServiceStartDate= new DateTime(2017,08,11),ServiceEndDate= new DateTime(2017,08,25),CustomerId=1,EmployeeId=2},
			new Service { ServiceId=6,Vin="1G4EC11C4JB901990",PaidOff=true,ServiceStartDate= new DateTime(2019,12,01),ServiceEndDate= new DateTime(2019,12,11),CustomerId=1,EmployeeId=2},	
			new Service { ServiceId=7,Vin="1G4EC11C4JB901991",PaidOff=true,ServiceStartDate= new DateTime(2022,06,01),ServiceEndDate= new DateTime(2022,06,13),CustomerId=1,EmployeeId=2},	
			new Service { ServiceId=8,Vin="2HNYD2H31DH501112",PaidOff=true,ServiceStartDate= new DateTime(2020,01,21),ServiceEndDate= new DateTime(2020,02,05),CustomerId=6,EmployeeId=2},	
			new Service { ServiceId=9,Vin="WBAJB0C51BC532336",PaidOff=true,ServiceStartDate= new DateTime(2018,11,01),ServiceEndDate= new DateTime(2018,11,06),CustomerId=6,EmployeeId=2},	
			new Service { ServiceId=10,Vin="1FT7W2BT3DEB02692",PaidOff=true,ServiceStartDate= new DateTime(2021,01,21),ServiceEndDate= new DateTime(2021,02,03),CustomerId=7,EmployeeId=2},	
			new Service { ServiceId=11,Vin="5J6RM4H33EL032008",PaidOff=true,ServiceStartDate= new DateTime(2022,01,21),ServiceEndDate= new DateTime(2022,01,29),CustomerId=7,EmployeeId=3},	
			new Service { ServiceId=12,Vin="5FNRL6H94JB058408",PaidOff=true,ServiceStartDate= new DateTime(2021,09,11),ServiceEndDate= new DateTime(2021,09,26),CustomerId=6,EmployeeId=5},	
			new Service { ServiceId=13,Vin="1C4SDHCT2EC518481",PaidOff=true,ServiceStartDate= new DateTime(2022,01,21),ServiceEndDate= new DateTime(2022,02,10),CustomerId=7,EmployeeId=3},	
			new Service { ServiceId=14,Vin="4T1BD1FK3FU060871",PaidOff=true,ServiceStartDate= new DateTime(2019,02,21),ServiceEndDate= new DateTime(2019,03,12),CustomerId=9,EmployeeId=3},	
			new Service { ServiceId=15,Vin="2C3CDXHG1EH218905",PaidOff=true,ServiceStartDate= new DateTime(2020,01,21),ServiceEndDate= new DateTime(2020,01,31),CustomerId=9,EmployeeId=5},	
			new Service { ServiceId=16,Vin="2GNAXTEV8J6252726",PaidOff=true,ServiceStartDate= new DateTime(2021,01,21),ServiceEndDate= new DateTime(2021,01,27),CustomerId=10,EmployeeId=5}, 
			new Service { ServiceId=17,Vin="WBAVA375X9NL06323",PaidOff=true,ServiceStartDate= new DateTime(2018,01,21),ServiceEndDate= new DateTime(2018,02,03),CustomerId=14,EmployeeId=5},
			new Service { ServiceId=18,Vin="1FTFW1ET0DFC21909",PaidOff=true,ServiceStartDate= new DateTime(2019,03,21),ServiceEndDate= new DateTime(2019,04,01),CustomerId=14,EmployeeId=5},
			new Service { ServiceId=19,Vin="1HGCV1F34JA033044",PaidOff=true,ServiceStartDate= new DateTime(2022,01,21),ServiceEndDate= new DateTime(2022,01,30),CustomerId=14,EmployeeId=5},
			new Service { ServiceId=20,Vin="1GYS4CKJ4GR228491",PaidOff=true,ServiceStartDate= new DateTime(2018,05,21),ServiceEndDate= new DateTime(2018,06,03),CustomerId=15,EmployeeId=5},
			new Service { ServiceId=21,Vin="2GTEK19B571125541",PaidOff=true,ServiceStartDate= new DateTime(2022,01,21),ServiceEndDate= new DateTime(2022,02,02),CustomerId=15,EmployeeId=5},
			new Service { ServiceId=22,Vin="3VWLL7AJ3BM029633",PaidOff=true,ServiceStartDate= new DateTime(2018,04,21),ServiceEndDate= new DateTime(2018,05,05),CustomerId=15,EmployeeId=2},
			new Service { ServiceId=23,Vin="1GKS1CE04BR207052",PaidOff=true,ServiceStartDate= new DateTime(2020,01,21),ServiceEndDate= new DateTime(2020,01,27),CustomerId=16,EmployeeId=2},
			new Service { ServiceId=24,Vin="EHV2T37F7T7VJVC26",PaidOff=true,ServiceStartDate= new DateTime(2022,07,20),ServiceEndDate= new DateTime(2022,07,25),CustomerId=16,EmployeeId=5},
			new Service { ServiceId=25,Vin="5G5JZ18N8SL872546",PaidOff=true,ServiceStartDate= new DateTime(2022,10,21),ServiceEndDate= new DateTime(2022,10,26),CustomerId=17,EmployeeId=5},
			new Service { ServiceId=26,Vin="3K3NT53X9XN433870",PaidOff=true,ServiceStartDate= new DateTime(2021,09,21),ServiceEndDate= new DateTime(2021,10,09),CustomerId=18,EmployeeId=2},
			new Service { ServiceId=27,Vin="2T3WFREV3GW293769",PaidOff=true,ServiceStartDate= new DateTime(2021,02,21),ServiceEndDate= new DateTime(2021,03,09),CustomerId=19,EmployeeId=6},
			new Service { ServiceId=28,Vin="2C4RC1BG6LR224413",PaidOff=true,ServiceStartDate= new DateTime(2023,01,21),ServiceEndDate= new DateTime(2023,02,02),CustomerId=20,EmployeeId=5},
			new Service { ServiceId=29,Vin="4JGDA5JB7HA946036",PaidOff=true,ServiceStartDate= new DateTime(2023,01,21),ServiceEndDate= new DateTime(2023,02,08),CustomerId=21,EmployeeId=5},
			new Service { ServiceId=30,Vin="WDDWJ8KB2KF684794",PaidOff=true,ServiceStartDate= new DateTime(2023,01,21),ServiceEndDate= new DateTime(2023,02,06),CustomerId=22,EmployeeId=8},
			new Service { ServiceId=31,Vin="2C4RC1BG7JR215755",PaidOff=true,ServiceStartDate= new DateTime(2022,02,21),ServiceEndDate= new DateTime(2022,03,08),CustomerId=23,EmployeeId=8},
			new Service { ServiceId=32,Vin="2GNFLFEK7G6194764",PaidOff=true,ServiceStartDate= new DateTime(2022,08,21),ServiceEndDate= new DateTime(2022,09,05),CustomerId=24,EmployeeId=8},
			new Service { ServiceId=33,Vin="WAUA2AFD2DN019030",PaidOff=true,ServiceStartDate= new DateTime(2022,02,21),ServiceEndDate= new DateTime(2022,03,01),CustomerId=25,EmployeeId=8},
			new Service { ServiceId=34,Vin="JTHBK1GG7D2027441",PaidOff=true,ServiceStartDate= new DateTime(2021,10,21),ServiceEndDate= new DateTime(2021,11,03),CustomerId=26,EmployeeId=9},
			new Service { ServiceId=35,Vin="4USBT33534LS49963",PaidOff=true,ServiceStartDate= new DateTime(2023,01,21),ServiceEndDate= new DateTime(2023,01,31),CustomerId=27,EmployeeId=9},
			new Service { ServiceId=36,Vin="JTHBW1GG7D2000178",PaidOff=true,ServiceStartDate= new DateTime(2022,02,21),ServiceEndDate= new DateTime(2022,02,28),CustomerId=27,EmployeeId=8},
			new Service { ServiceId=37,Vin="4T1BF1FK7CU510635",PaidOff=true,ServiceStartDate= new DateTime(2023,01,21),ServiceEndDate= new DateTime(2023,02,04),CustomerId=28,EmployeeId=9},
			new Service { ServiceId=38,Vin="3VW447AU5FM042417",PaidOff=true,ServiceStartDate= new DateTime(2023,01,21),ServiceEndDate= new DateTime(2023,01,27),CustomerId=29,EmployeeId=8},
			new Service { ServiceId=39,Vin="JTHBK1EG8C2417764",PaidOff=true,ServiceStartDate= new DateTime(2020,07,31),ServiceEndDate= new DateTime(2020,08,13),CustomerId=30,EmployeeId=8},
			new Service { ServiceId=40,Vin="2GTEK19J441270429",PaidOff=true,ServiceStartDate= new DateTime(2021,08,28),ServiceEndDate= new DateTime(2021,09,09),CustomerId=30,EmployeeId=9},
			new Service { ServiceId=41,Vin="1ZVFT80N055185407",PaidOff=true,ServiceStartDate= new DateTime(2022,03,15),ServiceEndDate= new DateTime(2022,03,25),CustomerId=31,EmployeeId=5},
			new Service { ServiceId=42,Vin="JM1NC2MF9E0234389",PaidOff=true,ServiceStartDate= new DateTime(2022,02,04),ServiceEndDate= new DateTime(2023,02,12),CustomerId=32,EmployeeId=2},
			new Service { ServiceId=43,Vin="KMHDN46D04U643031",PaidOff=true,ServiceStartDate= new DateTime(2020,10,11),ServiceEndDate= new DateTime(2020,10,28),CustomerId=null,EmployeeId=6},
			new Service { ServiceId=44,Vin="1J8GR48K47C155348",PaidOff=true,ServiceStartDate= new DateTime(2022,03,21),ServiceEndDate= new DateTime(2022,03,26),CustomerId=null,EmployeeId=2},
			new Service { ServiceId=45,Vin="1N4BL4BV4KC183758",PaidOff=true,ServiceStartDate= new DateTime(2022,09,23),ServiceEndDate= new DateTime(2022,10,10),CustomerId=null,EmployeeId=9},
			new Service { ServiceId=46,Vin="1FMZU77K74UB33195",PaidOff=true,ServiceStartDate= new DateTime(2022,06,27),ServiceEndDate= new DateTime(2022,07,04),CustomerId=null,EmployeeId=5},
			new Service { ServiceId=47,Vin="1N4AL3AP9EC215201",PaidOff=true,ServiceStartDate= new DateTime(2022,02,08),ServiceEndDate= new DateTime(2022,02,25),CustomerId=35,EmployeeId=6},
			new Service { ServiceId=48,Vin="1FTEW1E53MKE12935",PaidOff=true,ServiceStartDate= new DateTime(2021,12,03),ServiceEndDate= new DateTime(2021,12,23),CustomerId=36,EmployeeId=9},
			new Service { ServiceId=49,Vin="1G1PC5SB8E7182468",PaidOff=true,ServiceStartDate= new DateTime(2021,03,17),ServiceEndDate= new DateTime(2021,03,23),CustomerId=37,EmployeeId=5},
			new Service { ServiceId=50,Vin="1N4AA5AP3AC805981",PaidOff=true,ServiceStartDate= new DateTime(2023,01,23),ServiceEndDate= new DateTime(2023,02,05),CustomerId=38,EmployeeId=5},
			new Service { ServiceId=51,Vin="1G1JE6SB1C4183312",PaidOff=true,ServiceStartDate= new DateTime(2020,11,25),ServiceEndDate= new DateTime(2020,12,10),CustomerId=39,EmployeeId=5},
			new Service { ServiceId=52,Vin="1J8GR48K47C828206",PaidOff=true,ServiceStartDate= new DateTime(2022,06,11),ServiceEndDate= new DateTime(2022,06,19),CustomerId=40,EmployeeId=5},
			new Service { ServiceId=53,Vin="2HGFG4A50CH701101",PaidOff=true,ServiceStartDate= new DateTime(2023,01,04),ServiceEndDate= new DateTime(2023,01,20),CustomerId=41,EmployeeId=8},
			new Service { ServiceId=54,Vin="1HGCM66594A098237",PaidOff=true,ServiceStartDate= new DateTime(2023,01,13),ServiceEndDate= new DateTime(2023,02,02),CustomerId=42,EmployeeId=8},
			new Service { ServiceId=55,Vin="3D7JB1EP3BG707058",PaidOff=true,ServiceStartDate= new DateTime(2023,01,08),ServiceEndDate= new DateTime(2023,01,25),CustomerId=43,EmployeeId=9},
			new Service { ServiceId=56,Vin="JH4DB7663RS001474",PaidOff=true,ServiceStartDate= new DateTime(2023,01,19),ServiceEndDate= new DateTime(2023,01,28),CustomerId=44,EmployeeId=8},
			new Service { ServiceId=57,Vin="2HGES165X9H533726",PaidOff=true,ServiceStartDate= new DateTime(2023,01,02),ServiceEndDate= new DateTime(2023,01,19),CustomerId=45,EmployeeId=9},
			new Service { ServiceId=58,Vin="1FTFW1R62EFC81935",PaidOff=true,ServiceStartDate= new DateTime(2023,01,22),ServiceEndDate= new DateTime(2023,01,31),CustomerId=46,EmployeeId=8},
			new Service { ServiceId=59,Vin="JN1CA21D1XT804210",PaidOff=true,ServiceStartDate= new DateTime(2023,01,06),ServiceEndDate= new DateTime(2023,01,13),CustomerId=47,EmployeeId=5},
			new Service { ServiceId=60,Vin="JTHBJ46G992339151",PaidOff=true,ServiceStartDate= new DateTime(2023,01,11),ServiceEndDate= new DateTime(2023,01,17),CustomerId=48,EmployeeId=5},
			new Service { ServiceId=61,Vin="2G1WT58K979277802",PaidOff=false,ServiceStartDate= new DateTime(2023,01,15),ServiceEndDate= new DateTime(2023,02,03),CustomerId=49,EmployeeId=8},
			new Service { ServiceId=62,Vin="1C3CDFBB5FD333450",PaidOff=false,ServiceStartDate= new DateTime(2023,01,18),ServiceEndDate= new DateTime(2023,01,24),CustomerId=50,EmployeeId=9},
			new Service { ServiceId=63,Vin="JH4DA9447HS009086",PaidOff=false,ServiceStartDate= new DateTime(2023,02,14),ServiceEndDate= null,CustomerId=51,EmployeeId=9},
			new Service { ServiceId=64,Vin="2C4RDGCG4ER147255",PaidOff=false,ServiceStartDate= new DateTime(2023,02,15),ServiceEndDate= null,CustomerId=52,EmployeeId=5},
			new Service { ServiceId=65,Vin="1FTWW33F62EA44809",PaidOff=false,ServiceStartDate= new DateTime(2023,02,16),ServiceEndDate= null,CustomerId=52,EmployeeId=3},
			new Service { ServiceId=66,Vin="1G1BE5SM5H7248785",PaidOff=false,ServiceStartDate= new DateTime(2023,02,13),ServiceEndDate= null,CustomerId=52,EmployeeId=5},
			new Service { ServiceId=67,Vin="1FMCU0DG0BKA06849",PaidOff=false,ServiceStartDate= new DateTime(2023,02,14),ServiceEndDate= null,CustomerId=52,EmployeeId=8}
		);
		#endregion

		#region Task
		modelBuilder.Entity<Models.Task>().HasData(
			new Models.Task { Name="Changing springs",Description="Improving handling and suspension performance",ExecutionTime=1.0m,ServiceId=1,TaskId=1},
			new Models.Task { Name="Head replacement",Description="Repairing damage to the cylinder head",ExecutionTime=5.0m,ServiceId=2,TaskId=2},
			new Models.Task { Name="Brake pad replacement",Description="Replacing worn-out brake pads to ensure safe stopping",ExecutionTime=1.0m,ServiceId=3,TaskId=3},
			new Models.Task { Name="Oil change",Description="Maintaining engine lubrication and preventing damage",ExecutionTime=0.5m,ServiceId=4,TaskId=4},
			new Models.Task { Name="Suspension repair",Description="Repairing worn-out or damaged suspension components for improved handling and comfort",ExecutionTime=3.0m,ServiceId=5,TaskId=5},
			new Models.Task { Name="Spark plug replacement",Description="Ensuring proper ignition and fuel economy",ExecutionTime=1.0m,ServiceId=5,TaskId=6},
			new Models.Task { Name="Radiator flush",Description="Removing buildup and improving cooling efficiency",ExecutionTime=1.0m,ServiceId=6,TaskId=7},
			new Models.Task { Name="Wheel alignment",Description="Improving tire wear and handling performance",ExecutionTime=1.0m,ServiceId=7,TaskId=8},
			new Models.Task { Name="Transmission fluid change",Description="Maintaining transmission lubrication and preventing damage",ExecutionTime=2.0m,ServiceId=8,TaskId=9},
			new Models.Task { Name="Timing belt replacement",Description="Preventing engine damage from belt failure",ExecutionTime=4.0m,ServiceId=9,TaskId=10},
			new Models.Task { Name="Exhaust system repair",Description="Fixing leaks and improving engine performance",ExecutionTime=1.0m,ServiceId=10,TaskId=11},
			new Models.Task { Name="Battery replacement",Description="Ensuring proper starting and electrical system function",ExecutionTime=0.5m,ServiceId=10,TaskId=12},
			new Models.Task { Name="Fuel filter replacement",Description="Preventing engine damage from fuel contaminants",ExecutionTime=1.0m,ServiceId=11,TaskId=13},
			new Models.Task { Name="Engine tune-up",Description="Improving engine performance and fuel economy",ExecutionTime=2.0m,ServiceId=12,TaskId=14},
			new Models.Task { Name="Air filter replacement",Description="Ensuring proper airflow and preventing engine damage",ExecutionTime=0.5m,ServiceId=13,TaskId=15},
			new Models.Task { Name="Ignition system repair",Description="Fixing issues with spark plugs and coils for proper ignition",ExecutionTime=3.0m,ServiceId=14,TaskId=16},
			new Models.Task { Name="Tire rotation",Description="Improving tire wear and handling performance",ExecutionTime=1.0m,ServiceId=15,TaskId=17},
			new Models.Task { Name="Alternator replacement",Description="Ensuring proper electrical system function",ExecutionTime=1.0m,ServiceId=15,TaskId=18},
			new Models.Task { Name="Power steering fluid change",Description="Maintaining proper power steering function and preventing damage",ExecutionTime=2.0m,ServiceId=16,TaskId=19},
			new Models.Task { Name="Clutch repair",Description="Fixing issues with clutch engagement and disengagement",ExecutionTime=0.5m,ServiceId=17,TaskId=20},
			new Models.Task { Name="Brake line repair",Description="Repairing damaged brake lines for safe stopping",ExecutionTime=3.0m,ServiceId=18,TaskId=21},
			new Models.Task { Name="Fuel injector cleaning",Description="Improving fuel efficiency and engine performance",ExecutionTime=5.0m,ServiceId=19,TaskId=22},
			new Models.Task { Name="AC system repair",Description="Fixing issues with cooling and comfort in the cabin",ExecutionTime=1.0m,ServiceId=20,TaskId=23},
			new Models.Task { Name="Wheel bearing replacement",Description="Preventing wheel damage and improving handling",ExecutionTime=0.5m,ServiceId=20,TaskId=24},
			new Models.Task { Name="Serpentine belt replacement",Description="Preventing engine damage from belt failure",ExecutionTime=3.0m,ServiceId=21,TaskId=25},
			new Models.Task { Name="Transmission rebuild",Description="Repairing internal transmission components for proper function",ExecutionTime=0.5m,ServiceId=22,TaskId=26},
			new Models.Task { Name="Shock absorber replacement",Description="Improving handling and comfort",ExecutionTime=3.0m,ServiceId=23,TaskId=27},
			new Models.Task { Name="Brake caliper replacement",Description="Ensuring proper brake function and safe stopping",ExecutionTime=1.0m,ServiceId=24,TaskId=28},
			new Models.Task { Name="Head gasket replacement",Description="Preventing engine damage from coolant leaks",ExecutionTime=1.0m,ServiceId=25,TaskId=29},
			new Models.Task { Name="Catalytic converter replacement",Description="Ensuring proper emissions control and engine performance",ExecutionTime=2.0m,ServiceId=25,TaskId=30},
			new Models.Task { Name="Radiator replacement",Description="Ensuring proper cooling function and preventing engine damage",ExecutionTime=0.5m,ServiceId=26,TaskId=31},
			new Models.Task { Name="Brake rotor replacement",Description="Ensuring safe stopping and improving brake function",ExecutionTime=3.0m,ServiceId=27,TaskId=32},
			new Models.Task { Name="Water pump replacement",Description="Preventing engine damage from coolant leaks and improving cooling function",ExecutionTime=5.0m,ServiceId=28,TaskId=33},
			new Models.Task { Name="Distributor replacement",Description="Ensuring proper ignition and fuel economy",ExecutionTime=1.0m,ServiceId=29,TaskId=34},
			new Models.Task { Name="Fuel pump replacement",Description="Ensuring proper fuel delivery and preventing engine damage",ExecutionTime=1.0m,ServiceId=30,TaskId=35},
			new Models.Task { Name="Tie rod end replacement",Description="Improving steering function and handling",ExecutionTime=1.0m,ServiceId=30,TaskId=36},
			new Models.Task { Name="Drive shaft replacement",Description="Preventing drivetrain damage and improving performance",ExecutionTime=1.0m,ServiceId=31,TaskId=37},
			new Models.Task { Name="Valve cover gasket replacement",Description="Preventing oil leaks and ensuring proper lubrication",ExecutionTime=2.0m,ServiceId=32,TaskId=38},
			new Models.Task { Name="Camshaft position sensor replacement",Description="Ensuring proper engine timing and fuel economy",ExecutionTime=4.0m,ServiceId=33,TaskId=39},
			new Models.Task { Name="Starter motor replacement",Description="Ensuring proper starting function",ExecutionTime=5.0m,ServiceId=34,TaskId=40},
			new Models.Task { Name="Oxygen sensor replacement",Description="Ensuring proper fuel economy and emissions control",ExecutionTime=1.0m,ServiceId=35,TaskId=41},
			new Models.Task { Name="Throttle body cleaning",Description="Improving throttle response and fuel economy",ExecutionTime=0.5m,ServiceId=35,TaskId=42},
			new Models.Task { Name="Intake manifold gasket replacement",Description="Preventing vacuum leaks and improving engine performance",ExecutionTime=3.0m,ServiceId=36,TaskId=43},
			new Models.Task { Name="Brake booster replacement",Description="Improving brake function and safety",ExecutionTime=1.0m,ServiceId=37,TaskId=44},
			new Models.Task { Name="EGR valve replacement",Description="Ensuring proper emissions control and engine performance",ExecutionTime=1.0m,ServiceId=38,TaskId=45},
			new Models.Task { Name="Heater core replacement",Description="Improving cabin heating function and comfort",ExecutionTime=1.0m,ServiceId=39,TaskId=46},
			new Models.Task { Name="Control arm replacement",Description="Improving handling and suspension performance",ExecutionTime=2.0m,ServiceId=40,TaskId=47},
			new Models.Task { Name="Mass airflow sensor replacement",Description="Ensuring proper fuel economy and engine performance",ExecutionTime=4.0m,ServiceId=40,TaskId=48},
			new Models.Task { Name="Engine mount replacement",Description="Improving engine stability and reducing vibration",ExecutionTime=2.0m,ServiceId=41,TaskId=49},
			new Models.Task { Name="Drive belt replacement",Description="Preventing engine damage from belt failure",ExecutionTime=1.0m,ServiceId=42,TaskId=50},
			new Models.Task { Name="Shock mount replacement",Description="Improving handling and comfort",ExecutionTime=5.0m,ServiceId=43,TaskId=51},
			new Models.Task { Name="Exhaust manifold replacement",Description="Fixing leaks and improving engine performance",ExecutionTime=3.0m,ServiceId=44,TaskId=52},
			new Models.Task { Name="Brake line flush",Description="Removing air and contaminants from the brake lines for improved function",ExecutionTime=5.0m,ServiceId=44,TaskId=53},
			new Models.Task { Name="Engine oil leak repair",Description="Preventing oil loss and ensuring proper lubrication",ExecutionTime=3.0m,ServiceId=44,TaskId=54},
			new Models.Task { Name="Sway bar link replacement",Description="Improving handling and suspension performance",ExecutionTime=2.0m,ServiceId=45,TaskId=55},
			new Models.Task { Name="Power window motor replacement",Description="Ensuring proper window function",ExecutionTime=0.5m,ServiceId=45,TaskId=56},
			new Models.Task { Name="Ignition coil replacement",Description="Ensuring proper ignition and fuel economy",ExecutionTime=0.5m,ServiceId=45,TaskId=57},
			new Models.Task { Name="Fuel pump relay replacement",Description=" faulty relay causing fuel pump to fail",ExecutionTime=1.0m,ServiceId=46,TaskId=58},
			new Models.Task { Name="Throttle position sensor replacement",Description=" worn out or damaged sensor affecting engine performance",ExecutionTime=2.0m,ServiceId=46,TaskId=59},
			new Models.Task { Name="Ignition switch replacement",Description=" worn or damaged switch causing engine to not start",ExecutionTime=4.0m,ServiceId=47,TaskId=60},
			new Models.Task { Name="Wheel hub assembly replacement",Description=" worn or damaged hub assembly causing wheel to wobble",ExecutionTime=4.0m,ServiceId=47,TaskId=61},
			new Models.Task { Name="Brake drum replacement",Description=" worn or damaged drum affecting braking performance",ExecutionTime=2.0m,ServiceId=48,TaskId=62},
			new Models.Task { Name="Valve stem seal replacement",Description=" worn out or damaged seals causing oil leakage and smoke from the exhaust",ExecutionTime=4.0m,ServiceId=49,TaskId=63},
			new Models.Task { Name="Tie rod boot replacement",Description=" torn or damaged boot causing dirt and debris to enter the tie rod",ExecutionTime=0.5m,ServiceId=50,TaskId=64},
			new Models.Task { Name="Drive belt tensioner replacement",Description=" worn out or damaged tensioner affecting the performance of the drive belt",ExecutionTime=0.5m,ServiceId=50,TaskId=65},
			new Models.Task { Name="Oil pressure sensor replacement",Description=" faulty sensor causing inaccurate oil pressure readings",ExecutionTime=1.0m,ServiceId=51,TaskId=66},
			new Models.Task { Name="Engine control module replacement",Description=" malfunctioning module affecting various engine functions",ExecutionTime=2.0m,ServiceId=51,TaskId=67},
			new Models.Task { Name="Radiator fan motor replacement",Description=" worn out or damaged fan motor causing overheating",ExecutionTime=4.0m,ServiceId=51,TaskId=68},
			new Models.Task { Name="Idle air control valve replacement",Description=" faulty valve affecting engine idle speed",ExecutionTime=0.5m,ServiceId=52,TaskId=69},
			new Models.Task { Name="Heater blower motor replacement",Description=" worn out or damaged blower motor causing lack of heat or A/C",ExecutionTime=0.5m,ServiceId=52,TaskId=70},
			new Models.Task { Name="Fuel tank replacement",Description=" rust or damage to the fuel tank causing leaks or reduced fuel capacity",ExecutionTime=1.0m,ServiceId=52,TaskId=71},
			new Models.Task { Name="Brake master cylinder replacement",Description=" worn out or damaged cylinder affecting brake performance",ExecutionTime=2.0m,ServiceId=53,TaskId=72},
			new Models.Task { Name="A/C compressor replacement",Description=" worn out or damaged compressor affecting A/C performance",ExecutionTime=4.0m,ServiceId=53,TaskId=73},
			new Models.Task { Name="CV joint replacement",Description=" worn out or damaged joint causing clicking or popping noise when turning",ExecutionTime=2.0m,ServiceId=53,TaskId=74},
			new Models.Task { Name="Timing chain replacement",Description=" worn out or damaged chain affecting engine performance and timing",ExecutionTime=4.0m,ServiceId=54,TaskId=75},
			new Models.Task { Name="Engine coolant temperature sensor replacement",Description=" faulty sensor affecting accurate temperature readings and engine performance",ExecutionTime=0.5m,ServiceId=55,TaskId=76},
			new Models.Task { Name="Ignition distributor cap and rotor replacement",Description=" worn out or damaged cap and rotor affecting ignition and engine performance",ExecutionTime=0.5m,ServiceId=55,TaskId=77},
			new Models.Task { Name="Window regulator replacement",Description=" worn out or damaged regulator affecting window movement",ExecutionTime=0.5m,ServiceId=56,TaskId=78},
			new Models.Task { Name="Mass air flow sensor cleaning",Description=" dirty sensor affecting engine performance and fuel economy",ExecutionTime=0.5m,ServiceId=57,TaskId=79},
			new Models.Task { Name="Brake bleeder screw replacement",Description=" worn out or damaged screw affecting brake bleeding and maintenance",ExecutionTime=1.0m,ServiceId=58,TaskId=80},
			new Models.Task { Name="Intake air temperature sensor replacement",Description=" faulty sensor affecting engine performance and fuel economy",ExecutionTime=2.0m,ServiceId=59,TaskId=81},
			new Models.Task { Name="Brake proportioning valve replacement",Description=" worn out or damaged valve affecting brake balance and performance",ExecutionTime=4.0m,ServiceId=59,TaskId=82},
			new Models.Task { Name="Oil pump replacement",Description=" worn out or damaged pump affecting engine lubrication and performance",ExecutionTime=0.5m,ServiceId=59,TaskId=83},
			new Models.Task { Name="Camshaft sensor replacement",Description=" faulty sensor affecting accurate camshaft position readings and engine performance",ExecutionTime=0.5m,ServiceId=60,TaskId=84},
			new Models.Task { Name="Fuel pressure regulator replacement",Description=" faulty regulator affecting fuel pressure and engine performance",ExecutionTime=1.0m,ServiceId=60,TaskId=85},
			new Models.Task { Name="Transmission mount replacement",Description=" worn out or damaged mount affecting transmission stability and performance",ExecutionTime=2.0m,ServiceId=60,TaskId=86},
			new Models.Task { Name="Drive belt pulley replacement",Description=" worn out or damaged pulley affecting drive belt performance and engine accessories",ExecutionTime=4.0m,ServiceId=60,TaskId=87},
			new Models.Task { Name="Ignition control module replacement",Description=" worn out or damaged module affecting ignition and engine performance",ExecutionTime=2.0m,ServiceId=61,TaskId=88},
			new Models.Task { Name="Wheel speed sensor replacement",Description=" worn out or damaged sensor affecting accurate speed readings and ABS performance",ExecutionTime=4.0m,ServiceId=62,TaskId=89},
			new Models.Task { Name="PCV valve replacement",Description=" worn out or clogged valve affecting engine performance and emissions",ExecutionTime=0.5m,ServiceId=63,TaskId=90},
			new Models.Task { Name="Brake line fitting replacement",Description=" worn out or damaged fitting affecting brake performance and safety",ExecutionTime=0.5m,ServiceId=64,TaskId=91},
			new Models.Task { Name="Valve cover replacement",Description=" worn out or damaged cover causing oil leaks and engine damage",ExecutionTime=1.0m,ServiceId=64,TaskId=92},
			new Models.Task { Name="AC condenser replacement",Description=" worn out or damaged condenser affecting A/C performance",ExecutionTime=2.0m,ServiceId=64,TaskId=93},
			new Models.Task { Name="Brake rotor resurfacing",Description=" worn out or damaged rotor affecting braking performance",ExecutionTime=4.0m,ServiceId=65,TaskId=94},
			new Models.Task { Name="Fuel tank filler neck replacement",Description=" rust or damage to the filler neck causing fuel leaks or difficulty filling up",ExecutionTime=0.5m,ServiceId=65,TaskId=95},
			new Models.Task { Name="Idle speed control motor replacement",Description=" worn out or damaged motor affecting engine idle speed and performance",ExecutionTime=2.0m,ServiceId=65,TaskId=96},
			new Models.Task { Name="Transmission cooler line replacement",Description=" worn out or damaged line affecting transmission cooling and performance",ExecutionTime=3.0m,ServiceId=66,TaskId=97},
			new Models.Task { Name="Catalytic converter heat shield replacement",Description=" worn out or damaged shield affecting exhaust system performance and safety.",ExecutionTime=1.0m,ServiceId=67,TaskId=98}
		);
		#endregion

		#region Part
		modelBuilder.Entity<Part>().HasData(
			new Part { PartId=1,Manufacturer="Eibach",ManufacturerArtNo="E10-15-011-01-22",PartName="Rear Springs",Category="Suspension",Price=150.00m},
			new Part { PartId=2,Manufacturer="Eibach",ManufacturerArtNo="E10-15-011-01-23",PartName="Front Springs",Category="Suspension",Price=200.00m},
			new Part { PartId=3,Manufacturer="Fel-Pro",ManufacturerArtNo="26176 PT",PartName="Head Gasket",Category="Engine",Price=300.00m},
			new Part { PartId=4,Manufacturer="PowerStop",ManufacturerArtNo="Z36-1392",PartName="Brake Pad",Category="Brakes",Price=80.00m},
			new Part { PartId=5,Manufacturer="PowerStop",ManufacturerArtNo="Z36-1423",PartName="Brake Rotor",Category="Brakes",Price=120.00m},
			new Part { PartId=6,Manufacturer="Mobil 1",ManufacturerArtNo="120760",PartName="Oil",Category="Engine",Price=50.00m},
			new Part { PartId=7,Manufacturer="EGK",ManufacturerArtNo="423252",PartName="Oil Filter",Category="Engine",Price=10.00m},
			new Part { PartId=8,Manufacturer="Bilstein",ManufacturerArtNo="24-186674",PartName="Suspension",Category="Suspension",Price=1200.00m},
			new Part { PartId=9,Manufacturer="NGK",ManufacturerArtNo="5464",PartName="Spark Plug",Category="Engine",Price=30.00m},
			new Part { PartId=10,Manufacturer="Prestone",ManufacturerArtNo="AF2100",PartName="Radiator Flush",Category="Cooling System",Price=20.00m},
			new Part { PartId=11,Manufacturer="Prestone",ManufacturerArtNo="AF2222",PartName="Radiator Flush",Category="Cooling System",Price=20.00m},
			new Part { PartId=12,Manufacturer="Hunter Engineering",ManufacturerArtNo="WA100",PartName="Wheel Alignment",Category="Alignment",Price=100.00m},
			new Part { PartId=13,Manufacturer="Valvoline",ManufacturerArtNo="804751",PartName="Transmission Fluid",Category="Transmission",Price=80.00m},
			new Part { PartId=14,Manufacturer="Gates",ManufacturerArtNo="TCKWP331",PartName="Timing Belt",Category="Engine",Price=250.00m},
			new Part { PartId=15,Manufacturer="Walker",ManufacturerArtNo="54431",PartName="Exhaust System",Category="Exhaust",Price=100.00m},
			new Part { PartId=16,Manufacturer="Optima",ManufacturerArtNo="8025-160",PartName="Battery",Category="Electrical",Price=200.00m},
			new Part { PartId=17,Manufacturer="Bosch",ManufacturerArtNo="8025-160",PartName="Alternator",Category="Electrical",Price=150.00m},
			new Part { PartId=18,Manufacturer="WIX",ManufacturerArtNo="33003",PartName="Fuel Filter",Category="Fuel System",Price=20.00m},
			new Part { PartId=19,Manufacturer="K&N",ManufacturerArtNo="33-2300",PartName="Air Filter",Category="Fuel System",Price=130.00m},
			new Part { PartId=20,Manufacturer="Bosch",ManufacturerArtNo="0986AG1214",PartName="Engine Tune-up",Category="Engine",Price=150.00m},
			new Part { PartId=21,Manufacturer="K&N",ManufacturerArtNo="33-2304",PartName="Air Filter",Category="Engine",Price=50.00m},
			new Part { PartId=22,Manufacturer="Denso",ManufacturerArtNo="671-8110",PartName="Ignition System",Category="Electrical",Price=200.00m},
			new Part { PartId=23,Manufacturer="Michelin",ManufacturerArtNo="421323",PartName="Tire",Category="Tires",Price=150.00m},
			new Part { PartId=24,Manufacturer="Bosch",ManufacturerArtNo="AL8807X",PartName="Alternator",Category="Electrical",Price=300.00m},
			new Part { PartId=25,Manufacturer="Prestone",ManufacturerArtNo="AS263",PartName="Power Steering Fluid",Category="Steering",Price=20.00m},
			new Part { PartId=26,Manufacturer="Luk",ManufacturerArtNo="17-050",PartName="Clutch",Category="Transmission",Price=500.00m},
			new Part { PartId=27,Manufacturer="Dorman",ManufacturerArtNo="919-170",PartName="Brake Line",Category="Brakes",Price=50.00m},
			new Part { PartId=28,Manufacturer="BG Products",ManufacturerArtNo="44K",PartName="Fuel Injector",Category="Fuel System",Price=100.00m},
			new Part { PartId=29,Manufacturer="UAC",ManufacturerArtNo="CO 29002C",PartName="AC System",Category="HVAC",Price=150.00m},
			new Part { PartId=30,Manufacturer="Timken",ManufacturerArtNo="510070",PartName="Wheel Bearing",Category="Suspension",Price=50.00m},
			new Part { PartId=31,Manufacturer="Gates",ManufacturerArtNo="K060925",PartName="Serpentine Belt",Category="Engine",Price=40.00m},
			new Part { PartId=32,Manufacturer="Monroe",ManufacturerArtNo="58620",PartName="Shock Absorber",Category="Suspension",Price=100.00m},
			new Part { PartId=33,Manufacturer="ACDelco",ManufacturerArtNo="18FR2696",PartName="Brake Caliper",Category="Brakes",Price=150.00m},
			new Part { PartId=34,Manufacturer="Fel-Pro",ManufacturerArtNo="HS26223PT",PartName="Head Gasket",Category="Engine",Price=500.00m},
			new Part { PartId=35,Manufacturer="MagnaFlow",ManufacturerArtNo="545006",PartName="Catalytic Converter",Category="Exhaust",Price=500.00m},
			new Part { PartId=36,Manufacturer="CSF",ManufacturerArtNo="3470",PartName="Radiator",Category="Cooling System",Price=200.00m},
			new Part { PartId=37,Manufacturer="PowerStop",ManufacturerArtNo="AR8360XPR",PartName="Brake Rotor",Category="Brakes",Price=100.00m},
			new Part { PartId=38,Manufacturer="Gates",ManufacturerArtNo="43526",PartName="Water Pump",Category="Engine",Price=100.00m},
			new Part { PartId=39,Manufacturer="ACDelco",ManufacturerArtNo="88961867",PartName="Distributor",Category="Electrical",Price=150.00m},
			new Part { PartId=40,Manufacturer="Airtex",ManufacturerArtNo="E3614M",PartName="Fuel Pump",Category="Fuel System",Price=200.00m},
			new Part { PartId=41,Manufacturer="Moog",ManufacturerArtNo="ES3488",PartName="Tie Rod End",Category="Steering",Price=50.00m},
			new Part { PartId=42,Manufacturer="Dorman",ManufacturerArtNo="936-588",PartName="Drive Shaft",Category="Drivetrain",Price=300.00m},
			new Part { PartId=43,Manufacturer="Fel-Pro",ManufacturerArtNo="VS50504R",PartName="Valve Cover Gasket",Category="Engine",Price=50.00m},
			new Part { PartId=44,Manufacturer="Bosch",ManufacturerArtNo="0232103020",PartName="Camshaft position sensor",Category="Engine Sensors",Price=38.99m},
			new Part { PartId=45,Manufacturer="Denso",ManufacturerArtNo="2800194",PartName="Starter motor",Category="Starters",Price=178.99m},
			new Part { PartId=46,Manufacturer="NGK",ManufacturerArtNo="24642",PartName="Oxygen sensor",Category="Engine Sensors",Price=59.99m},
			new Part { PartId=47,Manufacturer="CRC",ManufacturerArtNo="05078",PartName="Throttle body",Category="Fuel Additives",Price=7.99m},
			new Part { PartId=48,Manufacturer="Fel-Pro",ManufacturerArtNo="MS98016T",PartName="Intake manifold gasket",Category="Gaskets",Price=23.99m},
			new Part { PartId=49,Manufacturer="ACDelco",ManufacturerArtNo="178-0861",PartName="Brake booster",Category="Brake Parts",Price=164.99m},
			new Part { PartId=50,Manufacturer="Standard Motor Products",ManufacturerArtNo="EGV1025",PartName="EGR valve",Category="EGR Valves",Price=108.99m},
			new Part { PartId=51,Manufacturer="Spectra Premium",ManufacturerArtNo="99306",PartName="Heater core",Category="Heating and Cooling",Price=64.99m},
			new Part { PartId=52,Manufacturer="Moog",ManufacturerArtNo="RK620900",PartName="Control arm",Category="Suspension and Steering",Price=76.99m},
			new Part { PartId=53,Manufacturer="Delphi",ManufacturerArtNo="AF10141",PartName="Mass airflow sensor",Category="Engine Sensors",Price=87.99m},
			new Part { PartId=54,Manufacturer="Anchor",ManufacturerArtNo="9129",PartName="Engine mount",Category="Engine Parts",Price=39.99m},
			new Part { PartId=55,Manufacturer="Gates",ManufacturerArtNo="K070683",PartName="Drive belt",Category="Belts and Hoses",Price=19.99m},
			new Part { PartId=56,Manufacturer="Monroe",ManufacturerArtNo="902910",PartName="Shock mount",Category="Suspension and Steering",Price=32.99m},
			new Part { PartId=57,Manufacturer="Dorman",ManufacturerArtNo="674-536",PartName="Exhaust manifold",Category="Exhaust Systems",Price=149.99m},
			new Part { PartId=58,Manufacturer="Prestone",ManufacturerArtNo="AS401",PartName="Brake line",Category="Brake Fluids",Price=7.99m},
			new Part { PartId=59,Manufacturer="BlueDevil",ManufacturerArtNo="00234",PartName="Engine Doctor",Category="Engine Additives",Price=17.99m},
			new Part { PartId=60,Manufacturer="Mevotech",ManufacturerArtNo="MK90660",PartName="Sway bar link",Category="Suspension and Steering",Price=34.99m},
			new Part { PartId=61,Manufacturer="Dorman",ManufacturerArtNo="742-251",PartName="Power window motor",Category="Electrical and Lighting",Price=49.99m},
			new Part { PartId=62,Manufacturer="Bosch",ManufacturerArtNo="0221604010",PartName="Ignition coil",Category="Ignition Systems",Price=47.99m},
			new Part { PartId=63,Manufacturer="Standard Motor Products",ManufacturerArtNo="RY116T",PartName="Fuel pump relay",Category="Fuel System",Price=7.99m},
			new Part { PartId=64,Manufacturer="Delphi",ManufacturerArtNo="SS10382",PartName="Throttle position sensor",Category="Engine Sensors",Price=74.99m},
			new Part { PartId=65,Manufacturer="ACDelco",ManufacturerArtNo="D1499A",PartName="Ignition switch",Category="Ignition Systems",Price=41.99m},
			new Part { PartId=66,Manufacturer="Timken",ManufacturerArtNo="SP580310",PartName="Wheel hub assembly",Category="Wheel Bearings",Price=153.99m},
			new Part { PartId=67,Manufacturer="Raybestos",ManufacturerArtNo="9628R",PartName="Brake drum",Category="Brake Parts",Price=38.99m},
			new Part { PartId=68,Manufacturer="Fel-Pro",ManufacturerArtNo="SS72643",PartName="Valve stem seal",Category="Gaskets",Price=24.99m},
			new Part { PartId=69,Manufacturer="Moog",ManufacturerArtNo="ES3172",PartName="Tie rod boot",Category="Suspension and Steering",Price=11.99m},
			new Part { PartId=70,Manufacturer="Gates",ManufacturerArtNo="38270",PartName="Drive belt tensioner",Category="Belts and Hoses",Price=58.99m},
			new Part { PartId=71,Manufacturer="ACDelco",ManufacturerArtNo="12677836",PartName="Oil pressure sensor",Category="Engine Sensors",Price=29.99m},
			new Part { PartId=72,Manufacturer="ACDelco",ManufacturerArtNo="12612384",PartName="Engine control module",Category="Engine Parts",Price=289.99m},
			new Part { PartId=73,Manufacturer="Four Seasons",ManufacturerArtNo="35123",PartName="Radiator fan motor",Category="Heating and Cooling",Price=64.99m},
			new Part { PartId=74,Manufacturer="Standard Motor Products",ManufacturerArtNo="AC27T",PartName="Idle air control valve",Category="Fuel System",Price=71.99m},
			new Part { PartId=75,Manufacturer="TYC",ManufacturerArtNo="700070",PartName="Heater blower motor",Category="Electrical and Lighting",Price=38.99m},
			new Part { PartId=76,Manufacturer="Spectra Premium",ManufacturerArtNo="GM43C",PartName="Fuel tank",Category="Fuel System",Price=153.99m},
			new Part { PartId=77,Manufacturer="ACDelco",ManufacturerArtNo="18M1052",PartName="Brake master cylinder",Category="Brake Parts",Price=65.99m},
			new Part { PartId=78,Manufacturer="Spectra Premium",ManufacturerArtNo="636801",PartName="A/C compressor",Category="A/C and Heating",Price=200.00m},
			new Part { PartId=79,Manufacturer="ACDelco",ManufacturerArtNo="45D1000",PartName="CV joint",Category="Drivetrain",Price=120.00m},
			new Part { PartId=80,Manufacturer="Gates",ManufacturerArtNo="TCKWP295A",PartName="Timing chain",Category="Engine",Price=150.00m},
			new Part { PartId=81,Manufacturer="Standard Motor Products",ManufacturerArtNo="TX18",PartName="Engine coolant temperature sensor",Category="Cooling System",Price=30.00m},
			new Part { PartId=82,Manufacturer="Borg Warner",ManufacturerArtNo="DR471",PartName="Ignition distributor cap and rotor",Category="Engine",Price=35.00m},
			new Part { PartId=83,Manufacturer="Dorman",ManufacturerArtNo="741-644",PartName="Window regulator",Category="Body",Price=60.00m},
			new Part { PartId=84,Manufacturer="Bosch",ManufacturerArtNo="2421654165",PartName="Mass air flow sensor",Category="Engine",Price=25.00m},
			new Part { PartId=85,Manufacturer="Dorman",ManufacturerArtNo="13949",PartName="Brake bleeder screw",Category="Brakes",Price=5.00m},
			new Part { PartId=86,Manufacturer="Bosch",ManufacturerArtNo="0261230099",PartName="Intake air temperature sensor",Category="Engine",Price=40.00m},
			new Part { PartId=87,Manufacturer="ACDelco",ManufacturerArtNo="172-2386",PartName="Brake proportioning valve",Category="Brakes",Price=120.00m},
			new Part { PartId=88,Manufacturer="Melling",ManufacturerArtNo="M295",PartName="Oil pump",Category="Engine",Price=75.00m},
			new Part { PartId=89,Manufacturer="Standard Motor Products",ManufacturerArtNo="PC232",PartName="Camshaft sensor",Category="Engine",Price=50.00m},
			new Part { PartId=90,Manufacturer="Bosch",ManufacturerArtNo="0280160557",PartName="Fuel pressure regulator",Category="Engine",Price=60.00m},
			new Part { PartId=91,Manufacturer="Anchor",ManufacturerArtNo="2710",PartName="Transmission mount",Category="Transmission",Price=40.00m},
			new Part { PartId=92,Manufacturer="Dorman",ManufacturerArtNo="300-202",PartName="Drive belt pulley",Category="Engine",Price=25.00m},
			new Part { PartId=93,Manufacturer="ACDelco",ManufacturerArtNo="D1977A",PartName="Ignition control module",Category="Engine",Price=60.00m},
			new Part { PartId=94,Manufacturer="Standard Motor Products",ManufacturerArtNo="ALS1761",PartName="Wheel speed sensor",Category="Brakes",Price=60.00m},
			new Part { PartId=95,Manufacturer="ACDelco",ManufacturerArtNo="214-2296",PartName="PCV valve",Category="Engine",Price=10.00m},
			new Part { PartId=96,Manufacturer="Dorman",ManufacturerArtNo="785-437",PartName="Brake line fitting",Category="Brakes",Price=5.00m},
			new Part { PartId=97,Manufacturer="Dorman",ManufacturerArtNo="264-911",PartName="Valve cover",Category="Engine",Price=40.00m},
			new Part { PartId=98,Manufacturer="Spectra Premium",ManufacturerArtNo="7-3644",PartName="AC condenser",Category="A/C and Heating",Price=100.00m},
			new Part { PartId=99,Manufacturer="Brembo",ManufacturerArtNo="5213213",PartName="Brake Rotor",Category="Brakes",Price=50.00m},
			new Part { PartId=100,Manufacturer="Dorman",ManufacturerArtNo="577-915",PartName="Fuel tank filler neck",Category="Fuel System",Price=70.00m},
			new Part { PartId=101,Manufacturer="Standard Motor Products",ManufacturerArtNo="AC27",PartName="Idle speed control motor",Category="Engine",Price=50.00m},
			new Part { PartId=102,Manufacturer="Dorman",ManufacturerArtNo="624-117",PartName="Transmission cooler line",Category="Transmission",Price=30.00m},
			new Part { PartId=103,Manufacturer="Dorman",ManufacturerArtNo="936-011",PartName="Catalytic converter heat shield",Category="Exhaust System",Price=25.00m}
		);
		#endregion
		
		#region TasksPart
		modelBuilder.Entity<TasksPart>().HasData(
			new TasksPart { PartId=1,TaskId=1},
			new TasksPart { PartId=2,TaskId=1},
			new TasksPart { PartId=3,TaskId=2},
			new TasksPart { PartId=4,TaskId=3},
			new TasksPart { PartId=5,TaskId=3},
			new TasksPart { PartId=6,TaskId=4},
			new TasksPart { PartId=7,TaskId=4},
			new TasksPart { PartId=8,TaskId=5},
			new TasksPart { PartId=9,TaskId=6},
			new TasksPart { PartId=10,TaskId=7},
			new TasksPart { PartId=11,TaskId=7},
			new TasksPart { PartId=12,TaskId=8},
			new TasksPart { PartId=13,TaskId=9},
			new TasksPart { PartId=14,TaskId=10},
			new TasksPart { PartId=15,TaskId=11},
			new TasksPart { PartId=16,TaskId=12},
			new TasksPart { PartId=17,TaskId=12},
			new TasksPart { PartId=18,TaskId=13},
			new TasksPart { PartId=19,TaskId=13},
			new TasksPart { PartId=20,TaskId=14},
			new TasksPart { PartId=21,TaskId=15},
			new TasksPart { PartId=22,TaskId=16},
			new TasksPart { PartId=23,TaskId=17},
			new TasksPart { PartId=24,TaskId=18},
			new TasksPart { PartId=25,TaskId=19},
			new TasksPart { PartId=26,TaskId=20},
			new TasksPart { PartId=27,TaskId=21},
			new TasksPart { PartId=28,TaskId=22},
			new TasksPart { PartId=29,TaskId=23},
			new TasksPart { PartId=30,TaskId=24},
			new TasksPart { PartId=31,TaskId=25},
			new TasksPart { PartId=32,TaskId=27},
			new TasksPart { PartId=33,TaskId=28},
			new TasksPart { PartId=34,TaskId=29},
			new TasksPart { PartId=35,TaskId=30},
			new TasksPart { PartId=36,TaskId=31},
			new TasksPart { PartId=37,TaskId=32},
			new TasksPart { PartId=38,TaskId=33},
			new TasksPart { PartId=39,TaskId=34},
			new TasksPart { PartId=40,TaskId=35},
			new TasksPart { PartId=41,TaskId=36},
			new TasksPart { PartId=42,TaskId=37},
			new TasksPart { PartId=43,TaskId=38},
			new TasksPart { PartId=44,TaskId=39},
			new TasksPart { PartId=45,TaskId=40},
			new TasksPart { PartId=46,TaskId=41},
			new TasksPart { PartId=47,TaskId=42},
			new TasksPart { PartId=48,TaskId=43},
			new TasksPart { PartId=49,TaskId=44},
			new TasksPart { PartId=50,TaskId=45},
			new TasksPart { PartId=51,TaskId=46},
			new TasksPart { PartId=52,TaskId=47},
			new TasksPart { PartId=53,TaskId=48},
			new TasksPart { PartId=54,TaskId=49},
			new TasksPart { PartId=55,TaskId=50},
			new TasksPart { PartId=56,TaskId=51},
			new TasksPart { PartId=57,TaskId=52},
			new TasksPart { PartId=58,TaskId=53},
			new TasksPart { PartId=59,TaskId=54},
			new TasksPart { PartId=60,TaskId=55},
			new TasksPart { PartId=61,TaskId=56},
			new TasksPart { PartId=62,TaskId=57},
			new TasksPart { PartId=63,TaskId=58},
			new TasksPart { PartId=64,TaskId=59},
			new TasksPart { PartId=65,TaskId=60},
			new TasksPart { PartId=66,TaskId=61},
			new TasksPart { PartId=67,TaskId=62},
			new TasksPart { PartId=68,TaskId=63},
			new TasksPart { PartId=69,TaskId=64},
			new TasksPart { PartId=70,TaskId=65},
			new TasksPart { PartId=71,TaskId=66},
			new TasksPart { PartId=72,TaskId=67},
			new TasksPart { PartId=73,TaskId=68},
			new TasksPart { PartId=74,TaskId=69},
			new TasksPart { PartId=75,TaskId=70},
			new TasksPart { PartId=76,TaskId=71},
			new TasksPart { PartId=77,TaskId=72},
			new TasksPart { PartId=78,TaskId=73},
			new TasksPart { PartId=79,TaskId=74},
			new TasksPart { PartId=80,TaskId=75},
			new TasksPart { PartId=81,TaskId=76},
			new TasksPart { PartId=82,TaskId=77},
			new TasksPart { PartId=83,TaskId=78},
			new TasksPart { PartId=84,TaskId=79},
			new TasksPart { PartId=85,TaskId=80},
			new TasksPart { PartId=86,TaskId=81},
			new TasksPart { PartId=87,TaskId=82},
			new TasksPart { PartId=88,TaskId=83},
			new TasksPart { PartId=89,TaskId=84},
			new TasksPart { PartId=90,TaskId=85},
			new TasksPart { PartId=91,TaskId=86},
			new TasksPart { PartId=92,TaskId=87},
			new TasksPart { PartId=93,TaskId=88},
			new TasksPart { PartId=94,TaskId=89},
			new TasksPart { PartId=95,TaskId=90},
			new TasksPart { PartId=96,TaskId=91},
			new TasksPart { PartId=97,TaskId=92},
			new TasksPart { PartId=98,TaskId=93},
			new TasksPart { PartId=99,TaskId=94},
			new TasksPart { PartId=100,TaskId=95},
			new TasksPart { PartId=101,TaskId=96},
			new TasksPart { PartId=102,TaskId=97},
			new TasksPart { PartId=103,TaskId=98}
		);
		#endregion
		
		#region TasksEmployee
		modelBuilder.Entity<TasksEmployee>().HasData(
			new TasksEmployee { EmployeeId=1,TaskId=1},
			new TasksEmployee { EmployeeId=1,TaskId=2},
			new TasksEmployee { EmployeeId=1,TaskId=3},
			new TasksEmployee { EmployeeId=2,TaskId=4},
			new TasksEmployee { EmployeeId=2,TaskId=5},
			new TasksEmployee { EmployeeId=2,TaskId=6},
			new TasksEmployee { EmployeeId=2,TaskId=7},
			new TasksEmployee { EmployeeId=2,TaskId=8},
			new TasksEmployee { EmployeeId=2,TaskId=9},
			new TasksEmployee { EmployeeId=2,TaskId=10},
			new TasksEmployee { EmployeeId=2,TaskId=11},
			new TasksEmployee { EmployeeId=2,TaskId=12},
			new TasksEmployee { EmployeeId=3,TaskId=13},
			new TasksEmployee { EmployeeId=5,TaskId=14},
			new TasksEmployee { EmployeeId=3,TaskId=15},
			new TasksEmployee { EmployeeId=3,TaskId=16},
			new TasksEmployee { EmployeeId=5,TaskId=17},
			new TasksEmployee { EmployeeId=5,TaskId=18},
			new TasksEmployee { EmployeeId=5,TaskId=19},
			new TasksEmployee { EmployeeId=5,TaskId=20},
			new TasksEmployee { EmployeeId=5,TaskId=21},
			new TasksEmployee { EmployeeId=5,TaskId=22},
			new TasksEmployee { EmployeeId=5,TaskId=23},
			new TasksEmployee { EmployeeId=5,TaskId=24},
			new TasksEmployee { EmployeeId=5,TaskId=25},
			new TasksEmployee { EmployeeId=2,TaskId=26},
			new TasksEmployee { EmployeeId=2,TaskId=27},
			new TasksEmployee { EmployeeId=5,TaskId=28},
			new TasksEmployee { EmployeeId=5,TaskId=29},
			new TasksEmployee { EmployeeId=5,TaskId=30},
			new TasksEmployee { EmployeeId=2,TaskId=31},
			new TasksEmployee { EmployeeId=6,TaskId=32},
			new TasksEmployee { EmployeeId=5,TaskId=33},
			new TasksEmployee { EmployeeId=5,TaskId=34},
			new TasksEmployee { EmployeeId=8,TaskId=35},
			new TasksEmployee { EmployeeId=8,TaskId=36},
			new TasksEmployee { EmployeeId=8,TaskId=37},
			new TasksEmployee { EmployeeId=8,TaskId=38},
			new TasksEmployee { EmployeeId=8,TaskId=39},
			new TasksEmployee { EmployeeId=9,TaskId=40},
			new TasksEmployee { EmployeeId=9,TaskId=41},
			new TasksEmployee { EmployeeId=9,TaskId=42},
			new TasksEmployee { EmployeeId=8,TaskId=43},
			new TasksEmployee { EmployeeId=9,TaskId=44},
			new TasksEmployee { EmployeeId=8,TaskId=45},
			new TasksEmployee { EmployeeId=8,TaskId=46},
			new TasksEmployee { EmployeeId=9,TaskId=47},
			new TasksEmployee { EmployeeId=9,TaskId=48},
			new TasksEmployee { EmployeeId=5,TaskId=49},
			new TasksEmployee { EmployeeId=2,TaskId=50},
			new TasksEmployee { EmployeeId=6,TaskId=51},
			new TasksEmployee { EmployeeId=2,TaskId=52},
			new TasksEmployee { EmployeeId=2,TaskId=53},
			new TasksEmployee { EmployeeId=2,TaskId=54},
			new TasksEmployee { EmployeeId=9,TaskId=55},
			new TasksEmployee { EmployeeId=9,TaskId=56},
			new TasksEmployee { EmployeeId=9,TaskId=57},
			new TasksEmployee { EmployeeId=5,TaskId=58},
			new TasksEmployee { EmployeeId=5,TaskId=59},
			new TasksEmployee { EmployeeId=6,TaskId=60},
			new TasksEmployee { EmployeeId=6,TaskId=61},
			new TasksEmployee { EmployeeId=9,TaskId=62},
			new TasksEmployee { EmployeeId=5,TaskId=63},
			new TasksEmployee { EmployeeId=5,TaskId=64},
			new TasksEmployee { EmployeeId=5,TaskId=65},
			new TasksEmployee { EmployeeId=5,TaskId=66},
			new TasksEmployee { EmployeeId=5,TaskId=67},
			new TasksEmployee { EmployeeId=5,TaskId=68},
			new TasksEmployee { EmployeeId=5,TaskId=69},
			new TasksEmployee { EmployeeId=5,TaskId=70},
			new TasksEmployee { EmployeeId=5,TaskId=71},
			new TasksEmployee { EmployeeId=8,TaskId=72},
			new TasksEmployee { EmployeeId=8,TaskId=73},
			new TasksEmployee { EmployeeId=8,TaskId=74},
			new TasksEmployee { EmployeeId=8,TaskId=75},
			new TasksEmployee { EmployeeId=9,TaskId=76},
			new TasksEmployee { EmployeeId=9,TaskId=77},
			new TasksEmployee { EmployeeId=8,TaskId=78},
			new TasksEmployee { EmployeeId=9,TaskId=79},
			new TasksEmployee { EmployeeId=8,TaskId=80},
			new TasksEmployee { EmployeeId=5,TaskId=81},
			new TasksEmployee { EmployeeId=5,TaskId=82},
			new TasksEmployee { EmployeeId=5,TaskId=83},
			new TasksEmployee { EmployeeId=5,TaskId=84},
			new TasksEmployee { EmployeeId=5,TaskId=85},
			new TasksEmployee { EmployeeId=5,TaskId=86},
			new TasksEmployee { EmployeeId=5,TaskId=87},
			new TasksEmployee { EmployeeId=8,TaskId=88},
			new TasksEmployee { EmployeeId=9,TaskId=89},
			new TasksEmployee { EmployeeId=9,TaskId=90},
			new TasksEmployee { EmployeeId=5,TaskId=91},
			new TasksEmployee { EmployeeId=5,TaskId=92},
			new TasksEmployee { EmployeeId=5,TaskId=93},
			new TasksEmployee { EmployeeId=3,TaskId=94},
			new TasksEmployee { EmployeeId=3,TaskId=95},
			new TasksEmployee { EmployeeId=3,TaskId=96},
			new TasksEmployee { EmployeeId=5,TaskId=97},
			new TasksEmployee { EmployeeId=8,TaskId=98}
		);
		#endregion
		
		#region PersonsAddress
		modelBuilder.Entity<PersonsAddress>().HasData(
			new PersonsAddress { PersonId=1,AddressId=1},
			new PersonsAddress { PersonId=2,AddressId=2},
			new PersonsAddress { PersonId=3,AddressId=2},
			new PersonsAddress { PersonId=4,AddressId=3},
			new PersonsAddress { PersonId=5,AddressId=4},
			new PersonsAddress { PersonId=6,AddressId=4},
			new PersonsAddress { PersonId=7,AddressId=5},
			new PersonsAddress { PersonId=8,AddressId=6},
			new PersonsAddress { PersonId=9,AddressId=7},
			new PersonsAddress { PersonId=10,AddressId=8},
			new PersonsAddress { PersonId=11,AddressId=8},
			new PersonsAddress { PersonId=12,AddressId=9},
			new PersonsAddress { PersonId=13,AddressId=9},
			new PersonsAddress { PersonId=14,AddressId=10},
			new PersonsAddress { PersonId=15,AddressId=11},
			new PersonsAddress { PersonId=16,AddressId=11},
			new PersonsAddress { PersonId=17,AddressId=12},
			new PersonsAddress { PersonId=18,AddressId=13},
			new PersonsAddress { PersonId=19,AddressId=14},
			new PersonsAddress { PersonId=20,AddressId=15},
			new PersonsAddress { PersonId=21,AddressId=15},
			new PersonsAddress { PersonId=22,AddressId=16},
			new PersonsAddress { PersonId=23,AddressId=17},
			new PersonsAddress { PersonId=24,AddressId=16},
			new PersonsAddress { PersonId=25,AddressId=17},
			new PersonsAddress { PersonId=26,AddressId=18},
			new PersonsAddress { PersonId=27,AddressId=18},
			new PersonsAddress { PersonId=28,AddressId=19},
			new PersonsAddress { PersonId=29,AddressId=20},
			new PersonsAddress { PersonId=30,AddressId=20},
			new PersonsAddress { PersonId=31,AddressId=21},
			new PersonsAddress { PersonId=32,AddressId=22},
			new PersonsAddress { PersonId=33,AddressId=23},
			new PersonsAddress { PersonId=34,AddressId=24},
			new PersonsAddress { PersonId=35,AddressId=25},
			new PersonsAddress { PersonId=36,AddressId=26},
			new PersonsAddress { PersonId=37,AddressId=27},
			new PersonsAddress { PersonId=38,AddressId=28},
			new PersonsAddress { PersonId=39,AddressId=29},
			new PersonsAddress { PersonId=40,AddressId=29},
			new PersonsAddress { PersonId=41,AddressId=30},
			new PersonsAddress { PersonId=42,AddressId=31},
			new PersonsAddress { PersonId=43,AddressId=32},
			new PersonsAddress { PersonId=44,AddressId=33},
			new PersonsAddress { PersonId=45,AddressId=34},
			new PersonsAddress { PersonId=46,AddressId=35},
			new PersonsAddress { PersonId=47,AddressId=36},
			new PersonsAddress { PersonId=48,AddressId=37},
			new PersonsAddress { PersonId=49,AddressId=38},
			new PersonsAddress { PersonId=50,AddressId=39},
			new PersonsAddress { PersonId=51,AddressId=40},
			new PersonsAddress { PersonId=52,AddressId=40}
		);
		#endregion
	}

}