using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WrenchWorks.Migrations
{
    /// <inheritdoc />
    public partial class BruteForceSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "manufacturerArtNo",
                table: "parts",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "addressID", "buildingNo", "city", "flatNo", "postCode", "region", "street" },
                values: new object[,]
                {
                    { 1L, "89", "Seattle", null, "98109", "Washington", "1st Ave N" },
                    { 2L, "7A", "New York", null, "10001", "New York", "5th Ave" },
                    { 3L, "57", "Chicago", "10A", "60606", "Illinois", "W Madison St" },
                    { 4L, "22", "Los Angeles", "7B", "90015", "California", "S Figueroa St" },
                    { 5L, "99", "Miami", null, "33140", "Florida", "Collins Ave" },
                    { 6L, "75", "Detroit", "5C", "48227", "Michigan", "Grand River Ave" },
                    { 7L, "18", "San Francisco", "2B", "94103", "California", "Mission St" },
                    { 8L, "42", "Boston", "12A", "2108", "Massachusetts", "Beacon St" },
                    { 9L, "12", "Dallas", "1A", "75201", "Texas", "Main St" },
                    { 10L, "38", "Philadelphia", "3C", "19102", "Pennsylvania", "S Broad St" },
                    { 11L, "8", "St. Louis", "4A", "63101", "Missouri", "Market St" },
                    { 12L, "54", "Atlanta", "9B", "30309", "Georgia", "Peachtree St" },
                    { 13L, "95", "Portland", "8C", "97204", "Oregon", "SW 6th Ave" },
                    { 14L, "7", "Orlando", null, "32819", "Florida", "International Dr" },
                    { 15L, "31", "Denver", "3B", "80202", "Colorado", "16th St Mall" },
                    { 16L, "41", "Minneapolis", "5C", "55403", "Minnesota", "Hennepin Ave" },
                    { 17L, "64", "Nashville", "1B", "37203", "Tennessee", "Broadway" },
                    { 18L, "31", "Newark", "6A", "7102", "New Jersey", "Market St" },
                    { 19L, "96", "Kansas City", "9C", "64105", "Missouri", "Main St" },
                    { 20L, "71", "Houston", "4A", "77002", "Texas", "Main St" },
                    { 21L, "10", "Phoenix", "8B", "85003", "Arizona", "W Van Buren St" },
                    { 22L, "13", "Pittsburgh", null, "15222", "Pennsylvania", "Forbes Ave" },
                    { 23L, "37", "Raleigh", "6A", "27601", "North Carolina", "Wilmington St" },
                    { 24L, "33", "Indianapolis", "2B", "46204", "Indiana", "Meridian St" },
                    { 25L, "28", "Spokane", "3C", "99201", "Washington", "Riverside Ave" },
                    { 26L, "47", "Austin", "7B", "78704", "Texas", "S Congress Ave" },
                    { 27L, "79", "Portland", "4B", "97210", "Oregon", "NW 23rd Ave" },
                    { 28L, "23", "Jersey City", null, "7302", "New Jersey", "Newark Ave" },
                    { 29L, "18", "Milwaukee", "6C", "53202", "Wisconsin", "E Wisconsin Ave" },
                    { 30L, "36", "Jacksonville", "10B", "32202", "Florida", "Monroe St" },
                    { 31L, "84", "Sacramento", "5A", "95814", "California", "K St" },
                    { 32L, "31", "Baltimore", null, "21202", "Maryland", "E Lombard St" },
                    { 33L, "32", "Tampa", "8A", "33602", "Florida", "Channelside Dr" },
                    { 34L, "10", "Cleveland", "10C", "44113", "Ohio", "Public Square" },
                    { 35L, "46", "Boise", "5B", "83702", "Idaho", "8th St" },
                    { 36L, "85", "Albuquerque", "7C", "87102", "New Mexico", "Central Ave" },
                    { 37L, "45", "Seattle", "2C", "98101", "Washington", "Pike St" },
                    { 38L, "2", "Washington", "11A", "20500", "District of Columbia", "Constitution Ave NW" },
                    { 39L, "56", "Miami", "9C", "33132", "Florida", "Biscayne Blvd" },
                    { 40L, " 8B", "New York", null, "10001", "New York", " 5th Ave" }
                });

            migrationBuilder.InsertData(
                table: "parts",
                columns: new[] { "partID", "category", "manufacturer", "manufacturerArtNo", "partName", "price" },
                values: new object[,]
                {
                    { 1L, "Suspension", "Eibach", "E10-15-011-01-22", "Rear Springs", 150.00m },
                    { 2L, "Suspension", "Eibach", "E10-15-011-01-23", "Front Springs", 200.00m },
                    { 3L, "Engine", "Fel-Pro", "26176 PT", "Head Gasket", 300.00m },
                    { 4L, "Brakes", "PowerStop", "Z36-1392", "Brake Pad", 80.00m },
                    { 5L, "Brakes", "PowerStop", "Z36-1423", "Brake Rotor", 120.00m },
                    { 6L, "Engine", "Mobil 1", "120760", "Oil", 50.00m },
                    { 7L, "Engine", "EGK", "423252", "Oil Filter", 10.00m },
                    { 8L, "Suspension", "Bilstein", "24-186674", "Suspension", 1200.00m },
                    { 9L, "Engine", "NGK", "5464", "Spark Plug", 30.00m },
                    { 10L, "Cooling System", "Prestone", "AF2100", "Radiator Flush", 20.00m },
                    { 11L, "Cooling System", "Prestone", "AF2222", "Radiator Flush", 20.00m },
                    { 12L, "Alignment", "Hunter Engineering", "WA100", "Wheel Alignment", 100.00m },
                    { 13L, "Transmission", "Valvoline", "804751", "Transmission Fluid", 80.00m },
                    { 14L, "Engine", "Gates", "TCKWP331", "Timing Belt", 250.00m },
                    { 15L, "Exhaust", "Walker", "54431", "Exhaust System", 100.00m },
                    { 16L, "Electrical", "Optima", "8025-160", "Battery", 200.00m },
                    { 17L, "Electrical", "Bosch", "8025-160", "Alternator", 150.00m },
                    { 18L, "Fuel System", "WIX", "33003", "Fuel Filter", 20.00m },
                    { 19L, "Fuel System", "K&N", "33-2300", "Air Filter", 130.00m },
                    { 20L, "Engine", "Bosch", "0986AG1214", "Engine Tune-up", 150.00m },
                    { 21L, "Engine", "K&N", "33-2304", "Air Filter", 50.00m },
                    { 22L, "Electrical", "Denso", "671-8110", "Ignition System", 200.00m },
                    { 23L, "Tires", "Michelin", "421323", "Tire", 150.00m },
                    { 24L, "Electrical", "Bosch", "AL8807X", "Alternator", 300.00m },
                    { 25L, "Steering", "Prestone", "AS263", "Power Steering Fluid", 20.00m },
                    { 26L, "Transmission", "Luk", "17-050", "Clutch", 500.00m },
                    { 27L, "Brakes", "Dorman", "919-170", "Brake Line", 50.00m },
                    { 28L, "Fuel System", "BG Products", "44K", "Fuel Injector", 100.00m },
                    { 29L, "HVAC", "UAC", "CO 29002C", "AC System", 150.00m },
                    { 30L, "Suspension", "Timken", "510070", "Wheel Bearing", 50.00m },
                    { 31L, "Engine", "Gates", "K060925", "Serpentine Belt", 40.00m },
                    { 32L, "Suspension", "Monroe", "58620", "Shock Absorber", 100.00m },
                    { 33L, "Brakes", "ACDelco", "18FR2696", "Brake Caliper", 150.00m },
                    { 34L, "Engine", "Fel-Pro", "HS26223PT", "Head Gasket", 500.00m },
                    { 35L, "Exhaust", "MagnaFlow", "545006", "Catalytic Converter", 500.00m },
                    { 36L, "Cooling System", "CSF", "3470", "Radiator", 200.00m },
                    { 37L, "Brakes", "PowerStop", "AR8360XPR", "Brake Rotor", 100.00m },
                    { 38L, "Engine", "Gates", "43526", "Water Pump", 100.00m },
                    { 39L, "Electrical", "ACDelco", "88961867", "Distributor", 150.00m },
                    { 40L, "Fuel System", "Airtex", "E3614M", "Fuel Pump", 200.00m },
                    { 41L, "Steering", "Moog", "ES3488", "Tie Rod End", 50.00m },
                    { 42L, "Drivetrain", "Dorman", "936-588", "Drive Shaft", 300.00m },
                    { 43L, "Engine", "Fel-Pro", "VS50504R", "Valve Cover Gasket", 50.00m },
                    { 44L, "Engine Sensors", "Bosch", "0232103020", "Camshaft position sensor", 38.99m },
                    { 45L, "Starters", "Denso", "2800194", "Starter motor", 178.99m },
                    { 46L, "Engine Sensors", "NGK", "24642", "Oxygen sensor", 59.99m },
                    { 47L, "Fuel Additives", "CRC", "05078", "Throttle body", 7.99m },
                    { 48L, "Gaskets", "Fel-Pro", "MS98016T", "Intake manifold gasket", 23.99m },
                    { 49L, "Brake Parts", "ACDelco", "178-0861", "Brake booster", 164.99m },
                    { 50L, "EGR Valves", "Standard Motor Products", "EGV1025", "EGR valve", 108.99m },
                    { 51L, "Heating and Cooling", "Spectra Premium", "99306", "Heater core", 64.99m },
                    { 52L, "Suspension and Steering", "Moog", "RK620900", "Control arm", 76.99m },
                    { 53L, "Engine Sensors", "Delphi", "AF10141", "Mass airflow sensor", 87.99m },
                    { 54L, "Engine Parts", "Anchor", "9129", "Engine mount", 39.99m },
                    { 55L, "Belts and Hoses", "Gates", "K070683", "Drive belt", 19.99m },
                    { 56L, "Suspension and Steering", "Monroe", "902910", "Shock mount", 32.99m },
                    { 57L, "Exhaust Systems", "Dorman", "674-536", "Exhaust manifold", 149.99m },
                    { 58L, "Brake Fluids", "Prestone", "AS401", "Brake line", 7.99m },
                    { 59L, "Engine Additives", "BlueDevil", "00234", "Engine Doctor", 17.99m },
                    { 60L, "Suspension and Steering", "Mevotech", "MK90660", "Sway bar link", 34.99m },
                    { 61L, "Electrical and Lighting", "Dorman", "742-251", "Power window motor", 49.99m },
                    { 62L, "Ignition Systems", "Bosch", "0221604010", "Ignition coil", 47.99m },
                    { 63L, "Fuel System", "Standard Motor Products", "RY116T", "Fuel pump relay", 7.99m },
                    { 64L, "Engine Sensors", "Delphi", "SS10382", "Throttle position sensor", 74.99m },
                    { 65L, "Ignition Systems", "ACDelco", "D1499A", "Ignition switch", 41.99m },
                    { 66L, "Wheel Bearings", "Timken", "SP580310", "Wheel hub assembly", 153.99m },
                    { 67L, "Brake Parts", "Raybestos", "9628R", "Brake drum", 38.99m },
                    { 68L, "Gaskets", "Fel-Pro", "SS72643", "Valve stem seal", 24.99m },
                    { 69L, "Suspension and Steering", "Moog", "ES3172", "Tie rod boot", 11.99m },
                    { 70L, "Belts and Hoses", "Gates", "38270", "Drive belt tensioner", 58.99m },
                    { 71L, "Engine Sensors", "ACDelco", "12677836", "Oil pressure sensor", 29.99m },
                    { 72L, "Engine Parts", "ACDelco", "12612384", "Engine control module", 289.99m },
                    { 73L, "Heating and Cooling", "Four Seasons", "35123", "Radiator fan motor", 64.99m },
                    { 74L, "Fuel System", "Standard Motor Products", "AC27T", "Idle air control valve", 71.99m },
                    { 75L, "Electrical and Lighting", "TYC", "700070", "Heater blower motor", 38.99m },
                    { 76L, "Fuel System", "Spectra Premium", "GM43C", "Fuel tank", 153.99m },
                    { 77L, "Brake Parts", "ACDelco", "18M1052", "Brake master cylinder", 65.99m },
                    { 78L, "A/C and Heating", "Spectra Premium", "636801", "A/C compressor", 200.00m },
                    { 79L, "Drivetrain", "ACDelco", "45D1000", "CV joint", 120.00m },
                    { 80L, "Engine", "Gates", "TCKWP295A", "Timing chain", 150.00m },
                    { 81L, "Cooling System", "Standard Motor Products", "TX18", "Engine coolant temperature sensor", 30.00m },
                    { 82L, "Engine", "Borg Warner", "DR471", "Ignition distributor cap and rotor", 35.00m },
                    { 83L, "Body", "Dorman", "741-644", "Window regulator", 60.00m },
                    { 84L, "Engine", "Bosch", "2421654165", "Mass air flow sensor", 25.00m },
                    { 85L, "Brakes", "Dorman", "13949", "Brake bleeder screw", 5.00m },
                    { 86L, "Engine", "Bosch", "0261230099", "Intake air temperature sensor", 40.00m },
                    { 87L, "Brakes", "ACDelco", "172-2386", "Brake proportioning valve", 120.00m },
                    { 88L, "Engine", "Melling", "M295", "Oil pump", 75.00m },
                    { 89L, "Engine", "Standard Motor Products", "PC232", "Camshaft sensor", 50.00m },
                    { 90L, "Engine", "Bosch", "0280160557", "Fuel pressure regulator", 60.00m },
                    { 91L, "Transmission", "Anchor", "2710", "Transmission mount", 40.00m },
                    { 92L, "Engine", "Dorman", "300-202", "Drive belt pulley", 25.00m },
                    { 93L, "Engine", "ACDelco", "D1977A", "Ignition control module", 60.00m },
                    { 94L, "Brakes", "Standard Motor Products", "ALS1761", "Wheel speed sensor", 60.00m },
                    { 95L, "Engine", "ACDelco", "214-2296", "PCV valve", 10.00m },
                    { 96L, "Brakes", "Dorman", "785-437", "Brake line fitting", 5.00m },
                    { 97L, "Engine", "Dorman", "264-911", "Valve cover", 40.00m },
                    { 98L, "A/C and Heating", "Spectra Premium", "7-3644", "AC condenser", 100.00m },
                    { 99L, "Brakes", "Brembo", "5213213", "Brake Rotor", 50.00m },
                    { 100L, "Fuel System", "Dorman", "577-915", "Fuel tank filler neck", 70.00m },
                    { 101L, "Engine", "Standard Motor Products", "AC27", "Idle speed control motor", 50.00m },
                    { 102L, "Transmission", "Dorman", "624-117", "Transmission cooler line", 30.00m },
                    { 103L, "Exhaust System", "Dorman", "936-011", "Catalytic converter heat shield", 25.00m }
                });

            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "personID", "email", "firstName", "lastName", "telephoneNumber" },
                values: new object[,]
                {
                    { 1L, "konrad.dabrowski@WrenchWorksEmail.com", "Konrad", "Dabrowski", "555-555-1212" },
                    { 2L, "jane.doe@WrenchWorksEmail.com", "Jane", "Doe", "555-555-1213" },
                    { 3L, "bob.smith@WrenchWorksEmail.com", "Bob", "Smith", "555-555-1214" },
                    { 4L, "emily.johnson@WrenchWorksEmail.com", "Emily", "Johnson", "555-555-1215" },
                    { 5L, "davPersonId.lee@WrenchWorksEmail.com", "DavPersonId", "Lee", "555-555-1216" },
                    { 6L, "sarah.kim@WrenchWorksEmail.com", "Sarah", "Kim", "555-555-1217" },
                    { 7L, "michael.miller@WrenchWorksEmail.com", "Michael", "Miller", "555-555-1218" },
                    { 8L, "ashley.anderson@WrenchWorksEmail.com", "Ashley", "Anderson", "555-555-1219" },
                    { 9L, "daniel.martin@WrenchWorksEmail.com", "Daniel", "Martin", "555-555-1220" },
                    { 10L, "jessica.taylor@WrenchWorksEmail.com", "Jessica", "Taylor", "555-555-1221" },
                    { 11L, "richard.jackson@WrenchWorksEmail.com", "Richard", "Jackson", "555-555-1222" },
                    { 12L, "laura.lopez@WrenchWorksEmail.com", "Laura", "Lopez", "555-555-1223" },
                    { 13L, "kevin.clark@WrenchWorksEmail.com", "Kevin", "Clark", "555-555-1224" },
                    { 14L, "karen.harris@WrenchWorksEmail.com", "Karen", "Harris", "555-555-1225" },
                    { 15L, "matthew.lewis@WrenchWorksEmail.com", "Matthew", "Lewis", "555-555-1226" },
                    { 16L, "cynthia.allen@WrenchWorksEmail.com", "Cynthia", "Allen", "555-555-1227" },
                    { 17L, "thomas.young@WrenchWorksEmail.com", "Thomas", "Young", "555-555-1228" },
                    { 18L, "rachel.hall@WrenchWorksEmail.com", "Rachel", "Hall", "555-555-1229" },
                    { 19L, "eric.ramirez@WrenchWorksEmail.com", "Eric", "Ramirez", "555-555-1230" },
                    { 20L, "nancy.scott@WrenchWorksEmail.com", "Nancy", "Scott", "555-555-1231" },
                    { 21L, "maria.wright@WrenchWorksEmail.com", "Maria", "Wright", "555-555-1232" },
                    { 22L, "patrick.king@WrenchWorksEmail.com", "Patrick", "King", "555-555-1233" },
                    { 23L, "michelle.lee@WrenchWorksEmail.com", "Michelle", "Lee", "555-555-1234" },
                    { 24L, "scott.baker@WrenchWorksEmail.com", "Scott", "Baker", "555-555-1235" },
                    { 25L, "amy.gonzalez@WrenchWorksEmail.com", "Amy", "Gonzalez", "555-555-1236" },
                    { 26L, "timothy.nelson@WrenchWorksEmail.com", "Timothy", "Nelson", "555-555-1237" },
                    { 27L, "rebecca.carter@WrenchWorksEmail.com", "Rebecca", "Carter", "555-555-1238" },
                    { 28L, "adam.morris@WrenchWorksEmail.com", "Adam", "Morris", "555-555-1239" },
                    { 29L, "stephanie.murphy@WrenchWorksEmail.com", "Stephanie", "Murphy", "555-555-1240" },
                    { 30L, "jason.parker@WrenchWorksEmail.com", "Jason", "Parker", "555-555-1241" },
                    { 31L, "amanda.cooper@WrenchWorksEmail.com", "Amanda", "Cooper", "555-555-1242" },
                    { 32L, "jeffrey.reed@WrenchWorksEmail.com", "Jeffrey", "Reed", "555-555-1243" },
                    { 33L, "angela.phillips@WrenchWorksEmail.com", "Angela", "Phillips", "555-555-1244" },
                    { 34L, "keith.campbell@WrenchWorksEmail.com", "Keith", "Campbell", "555-555-1245" },
                    { 35L, "melissa.bailey@WrenchWorksEmail.com", "Melissa", "Bailey", "555-555-1246" },
                    { 36L, "joshua.flores@WrenchWorksEmail.com", "Joshua", "Flores", "555-555-1247" },
                    { 37L, "derek.cox@WrenchWorksEmail.com", "Derek", "Cox", "555-555-1249" },
                    { 38L, "sara.adams@WrenchWorksEmail.com", "Sara", "Adams", "555-555-1250" },
                    { 39L, "justin.green@WrenchWorksEmail.com", "Justin", "Green", "555-555-1251" },
                    { 40L, "john.anderson@WrenchWorksEmail.com", "John", "Anderson", "555-555-1252" },
                    { 41L, "samantha.johnson@WrenchWorksEmail.com", "Samantha", "Johnson", "555-555-1253" },
                    { 42L, "andrew.smith@WrenchWorksEmail.com", "Andrew", "Smith", "555-555-1254" },
                    { 43L, "olivia.johnson@WrenchWorksEmail.com", "Olivia", "Johnson", "555-555-1255" },
                    { 44L, "megan.davis@WrenchWorksEmail.com", "Megan", "Davis", "555-555-1256" },
                    { 45L, "ethan.brown@WrenchWorksEmail.com", "Ethan", "Brown", "555-555-1257" },
                    { 46L, "lauren.johnson@WrenchWorksEmail.com", "Lauren", "Johnson", "555-555-1258" },
                    { 47L, "anthony.williams@WrenchWorksEmail.com", "Anthony", "Williams", "555-555-1259" },
                    { 48L, "victoria.smith@WrenchWorksEmail.com", "Victoria", "Smith", "555-555-1260" },
                    { 49L, "brian.jackson@WrenchWorksEmail.com", "Brian", "Jackson", "555-555-1261" },
                    { 50L, "elizabeth.jones@WrenchWorksEmail.com", "Elizabeth", "Jones", "555-555-1262" },
                    { 51L, "christopher.smith@WrenchWorksEmail.com", "Christopher", "Smith", "555-555-1263" },
                    { 52L, "kelly.taylor@WrenchWorksEmail.com", "Kelly", "Taylor", "555-555-1264" }
                });

            migrationBuilder.InsertData(
                table: "powerSources",
                columns: new[] { "VIN", "biofuel", "CNG", "hybrid", "LPG", "mainPowerSourceType" },
                values: new object[,]
                {
                    { "1C3CDFBB5FD333450", false, false, false, false, "Petrol" },
                    { "1C4SDHCT2EC518481", false, false, false, false, "Petrol" },
                    { "1FMCU0DG0BKA06849", false, false, false, false, "Petrol" },
                    { "1FMZU77K74UB33195", false, false, false, false, "Diesel" },
                    { "1FT7W2BT3DEB02692", false, false, false, false, "Diesel" },
                    { "1FTEW1E53MKE12935", true, false, false, false, "Petrol" },
                    { "1FTFW1ET0DFC21909", false, false, false, false, "Petrol" },
                    { "1FTFW1R62EFC81935", false, false, false, true, "Petrol" },
                    { "1FTWW33F62EA44809", false, false, false, false, "Diesel" },
                    { "1G1BE5SM5H7248785", false, false, false, false, "Petrol" },
                    { "1G1JE6SB1C4183312", false, false, false, false, "Nuclear" },
                    { "1G1PC5SB8E7182468", false, false, false, false, "Hydrogen" },
                    { "1G4EC11C4JB901987", false, false, false, true, "Petrol" },
                    { "1G4EC11C4JB901988", false, true, false, false, "Petrol" },
                    { "1G4EC11C4JB901989", false, false, false, false, "Electric" },
                    { "1G4EC11C4JB901990", false, false, true, false, "Petrol" },
                    { "1G4EC11C4JB901991", false, false, false, false, "Electric" },
                    { "1GKS1CE04BR207052", false, false, false, false, "Petrol" },
                    { "1GYS4CKJ4GR228491", false, false, false, false, "Petrol" },
                    { "1HGCM66594A098237", false, false, false, true, "Petrol" },
                    { "1HGCV1F34JA033044", false, false, false, false, "Petrol" },
                    { "1J8GR48K47C155348", true, false, false, false, "Nuclear" },
                    { "1J8GR48K47C828206", false, false, false, false, "Diesel" },
                    { "1N4AA5AP3AC805981", false, false, false, true, "Petrol" },
                    { "1N4AL3AP9EC215201", false, false, false, false, "Electric" },
                    { "1N4BL4BV4KC183758", false, false, false, false, "Petrol" },
                    { "1ZVFT80N055185407", false, false, false, false, "Petrol" },
                    { "2C3CDXHG1EH218905", false, false, false, false, "Petrol" },
                    { "2C4RC1BG6LR224413", false, false, false, false, "Petrol" },
                    { "2C4RC1BG7JR215755", false, false, false, false, "Petrol" },
                    { "2C4RDGCG4ER147255", false, false, false, false, "Petrol" },
                    { "2G1WT58K979277802", false, false, false, false, "Petrol" },
                    { "2GNAXTEV8J6252726", false, false, false, false, "Petrol" },
                    { "2GNFLFEK7G6194764", false, false, false, false, "Petrol" },
                    { "2GTEK19B571125541", false, false, false, false, "Petrol" },
                    { "2GTEK19J441270429", true, false, false, false, "Diesel" },
                    { "2HGES165X9H533726", false, false, false, true, "Petrol" },
                    { "2HGFG4A50CH701101", false, false, false, true, "Petrol" },
                    { "2HNYD2H31DH501112", false, false, false, false, "Petrol" },
                    { "2T3WFREV3GW293769", false, false, false, false, "Petrol" },
                    { "37D2AJLFEK7G6194W", false, false, false, true, "Nuclear" },
                    { "3D7JB1EP3BG707058", false, false, false, false, "Diesel" },
                    { "3FNRLW2BT3VWLLT7W", false, false, false, false, "Diesel" },
                    { "3K3NT53X9XN433870", false, false, false, false, "Electric" },
                    { "3VW447AU5FM042417", false, false, false, false, "Electric" },
                    { "3VWLL7AJ3BM029633", false, false, false, false, "Petrol" },
                    { "4JGDA5JB7HA946036", false, false, false, false, "Petrol" },
                    { "4T1BD1FK3FU060871", false, false, false, false, "Petrol" },
                    { "4T1BF1FK7CU510635", false, false, false, true, "Petrol" },
                    { "4USBT33534LS49963", false, false, false, false, "Petrol" },
                    { "5FNRL6H94JB058408", false, false, false, false, "Petrol" },
                    { "5G5JZ18N8SL872546", false, false, false, false, "Petrol" },
                    { "5J6RM4H33EL032008", false, false, false, false, "Electric" },
                    { "EHV2T37F7T7VJVC26", false, false, false, false, "Petrol" },
                    { "JH4DA9447HS009086", false, false, false, false, "Petrol" },
                    { "JH4DB7663RS001474", false, false, false, false, "Petrol" },
                    { "JM1NC2MF9E0234389", false, false, false, false, "Hydrogen" },
                    { "JN1CA21D1XT804210", false, false, false, false, "Petrol" },
                    { "JTHBJ46G992339151", false, false, false, false, "Petrol" },
                    { "JTHBK1EG8C2417764", false, false, false, false, "Electric" },
                    { "JTHBK1GG7D2027441", false, false, false, false, "Petrol" },
                    { "JTHBW1GG7D2000178", false, false, false, false, "Petrol" },
                    { "KMHDN46D04U643031", false, true, false, false, "Diesel" },
                    { "WAUA2AFD2DN019030", false, false, false, false, "Petrol" },
                    { "WBAJB0C51BC532336", false, false, false, false, "Petrol" },
                    { "WBAVA375X9NL06323", false, false, false, false, "Petrol" },
                    { "WDDWJ8KB2KF684794", false, false, false, false, "Petrol" }
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "customerID", "NIP" },
                values: new object[,]
                {
                    { 1L, "123456789" },
                    { 6L, "987654321" },
                    { 7L, null },
                    { 9L, null },
                    { 10L, null },
                    { 14L, "876543219" },
                    { 15L, "456789123" },
                    { 16L, "912345678" },
                    { 17L, null },
                    { 18L, null },
                    { 19L, null },
                    { 20L, null },
                    { 21L, null },
                    { 22L, null },
                    { 23L, "202481772" },
                    { 24L, "203720552" },
                    { 25L, "204959332" },
                    { 26L, "206198112" },
                    { 27L, null },
                    { 28L, null },
                    { 29L, null },
                    { 30L, null },
                    { 31L, null },
                    { 32L, "213630792" },
                    { 33L, "214869572" },
                    { 34L, "216108352" },
                    { 35L, "217347132" },
                    { 36L, "218585912" },
                    { 37L, "219824692" },
                    { 38L, null },
                    { 39L, "222302252" },
                    { 40L, "223541032" },
                    { 41L, "224779812" },
                    { 42L, "226018592" },
                    { 43L, "227257372" },
                    { 44L, "228496152" },
                    { 45L, null },
                    { 46L, null },
                    { 47L, null },
                    { 48L, null },
                    { 49L, null },
                    { 50L, "235928832" },
                    { 51L, "237167612" },
                    { 52L, "238406392" }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "employeeID", "dateOfEmployment", "positionName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2010, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owner" },
                    { 2L, new DateTime(2012, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Workshop Manager" },
                    { 3L, new DateTime(2013, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automotive Specialist" },
                    { 4L, new DateTime(2014, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parts Manager" },
                    { 5L, new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diagonostic Specialist" },
                    { 6L, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality Engineer" },
                    { 7L, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality Specialist" },
                    { 8L, new DateTime(2017, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automotive Specialist" },
                    { 9L, new DateTime(2017, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automotive Specialist" },
                    { 10L, new DateTime(2018, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality Specialist" },
                    { 11L, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diagonostic Specialist" },
                    { 12L, new DateTime(2020, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assistant Automotive Specialist" },
                    { 13L, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assistant Diagonostic Specialist" },
                    { 14L, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trainee" }
                });

            migrationBuilder.InsertData(
                table: "persons_addresses",
                columns: new[] { "addressID", "personID" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 2L },
                    { 2L, 3L },
                    { 3L, 4L },
                    { 4L, 5L },
                    { 4L, 6L },
                    { 5L, 7L },
                    { 6L, 8L },
                    { 7L, 9L },
                    { 8L, 10L },
                    { 8L, 11L },
                    { 9L, 12L },
                    { 9L, 13L },
                    { 10L, 14L },
                    { 11L, 15L },
                    { 11L, 16L },
                    { 12L, 17L },
                    { 13L, 18L },
                    { 14L, 19L },
                    { 15L, 20L },
                    { 15L, 21L },
                    { 16L, 22L },
                    { 17L, 23L },
                    { 16L, 24L },
                    { 17L, 25L },
                    { 18L, 26L },
                    { 18L, 27L },
                    { 19L, 28L },
                    { 20L, 29L },
                    { 20L, 30L },
                    { 21L, 31L },
                    { 22L, 32L },
                    { 23L, 33L },
                    { 24L, 34L },
                    { 25L, 35L },
                    { 26L, 36L },
                    { 27L, 37L },
                    { 28L, 38L },
                    { 29L, 39L },
                    { 29L, 40L },
                    { 30L, 41L },
                    { 31L, 42L },
                    { 32L, 43L },
                    { 33L, 44L },
                    { 34L, 45L },
                    { 35L, 46L },
                    { 36L, 47L },
                    { 37L, 48L },
                    { 38L, 49L },
                    { 39L, 50L },
                    { 40L, 51L },
                    { 40L, 52L }
                });

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "VIN", "bodyColor", "engineCapacity", "engineNo", "maker", "model", "personID", "powerSource", "yearOfProduction" },
                values: new object[,]
                {
                    { "1C3CDFBB5FD333450", "Blue", 2.4m, "8R16C9T67G94H3L1S", "Dodge", "Dart", 50L, "Petrol", new DateTime(2015, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1C4SDHCT2EC518481", "Yellow", 5.7m, "1JGYK1111V0214294", "Dodge", "Durango", 7L, "Petrol", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1FMCU0DG0BKA06849", "Silver", 3.0m, "7R21K3G87L90B6H3F", "Ford", "Escape", 52L, "Petrol", new DateTime(2011, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1FMZU77K74UB33195", "Black", null, "6W8V7B2D2U2V7B4F", "Ford", "Explorer", null, "Diesel", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1FT7W2BT3DEB02692", "Gray", 6.7m, "6PXYB1111W9725625", "Ford", "F-250", 7L, "Diesel", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1FTEW1E53MKE12935", "Silver", 3.5m, "1J8A2E2Z2A7P5K5C", "Ford", "F-150", 36L, "Petrol", new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1FTFW1ET0DFC21909", "Green", 3.5m, "5ZKDK1111P1182258", "Ford", "F-150", 14L, "Petrol", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1FTFW1R62EFC81935", "Silver", 3.5m, "6G90T6P24D82F3R6T", "Ford", "F-150", 46L, "Petrol", new DateTime(2014, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1FTWW33F62EA44809", "Black", 7.3m, "2P98D2K57G42L7N1J", "Ford", "F-350", 52L, "Diesel", new DateTime(2002, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1G1BE5SM5H7248785", "Black", 1.4m, "4E86D4K75G68L2M4F", "Chevrolet", "Cruze", 52L, "Petrol", new DateTime(2017, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1G1JE6SB1C4183312", "Brown", null, "9L9F1D1G8H8D8N8C", "Chevrolet", "Volt", 39L, "Nuclear", new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1G1PC5SB8E7182468", "Yellow", null, "8G2C2G9X7J2D2B8R", "Chevrolet", "Volt", 37L, "Hydrogen", new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1G4EC11C4JB901987", "Black", 7.0m, "VB-101", "Bugatti", "Veyron", 1L, "Petrol", new DateTime(2015, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1G4EC11C4JB901988", "Silver", 6.0m, "PH-101", "Pagani", "Huayra", 1L, "Petrol", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1G4EC11C4JB901989", "Red", null, "MP-101", "McLaren", "P1", 1L, "Electric", new DateTime(2017, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1G4EC11C4JB901990", "CUSTOM", 4.2m, "KK-101", "Koenigsegg", "Agera", 1L, "Petrol", new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1G4EC11C4JB901991", "Orange", null, "RC-101", "Rimac", "C_Two", 1L, "Electric", new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1GKS1CE04BR207052", "CUSTOM", 5.0m, "8MCJH132142269653", "GMC", "Yukon", 16L, "Petrol", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1GYS4CKJ4GR228491", "Gold", 6.2m, "8FZJX1111V0240869", "Cadillac", "Escalade", 15L, "Petrol", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1HGCM66594A098237", "Blue", null, "4G65Y4H98C78B4J1N", "Honda", "Accord", 42L, "Petrol", new DateTime(2017, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1HGCV1F34JA033044", "Red", 2.0m, "P5BYF1111V4546335", "Honda", "Accord", 14L, "Petrol", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1J8GR48K47C155348", "Bronze", null, "3V7W8X9F9V7D7R1N", "Jeep", "Grand Cherokee", null, "Nuclear", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1J8GR48K47C828206", "Green", 3.0m, "1C6E3W8V3C3H9X7V", "Jeep", "Grand Cherokee", 40L, "Diesel", new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1N4AA5AP3AC805981", "Purple", 3.5m, "4S5E5N5F5R5S2S5G", "Nissan", "Maxima", 38L, "Petrol", new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1N4AL3AP9EC215201", "Yellow", null, "2J2W8R8J4D6E1A7M", "Nissan", "Altima", 35L, "Electric", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1N4BL4BV4KC183758", "Green", 2.5m, "5L6E5S6H5S6S5E6U", "Nissan", "Altima", null, "Petrol", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1ZVFT80N055185407", "Red", 4.0m, "4U6C4U4C2U8D2H6N", "Ford", "Mustang", 31L, "Petrol", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2C3CDXHG1EH218905", "Blue", 3.6m, "9MPVD1111P0385937", "Dodge", "Charger", 9L, "Petrol", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2C4RC1BG6LR224413", "White", 5.0m, "6YHJB7868NBHJ4564", "Ford", "Mustang GT", 20L, "Petrol", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2C4RC1BG7JR215755", "Black", 6.2m, "7HJ7865LKJHJ7865K", "Chevrolet", "Camaro ZL1", 23L, "Petrol", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2C4RDGCG4ER147255", "Gray", null, "9R38A9G04H71K1L5E", "Chrysler", "Town & Country", 52L, "Petrol", new DateTime(2014, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2G1WT58K979277802", "Red", 3.5m, "5B17R5E64D34J5G9K", "Chevrolet", "Impala", 49L, "Petrol", new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2GNAXTEV8J6252726", "Red", 2.0m, "5SMPG1111S2985843", "Chevrolet", "Equinox", 10L, "Petrol", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2GNFLFEK7G6194764", "Silver", 4.0m, "4HJK56LKJH98KJH11", "Audi", "RS7", 24L, "Petrol", new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2GTEK19B571125541", "Blue", 5.3m, "8MCJH1111V7826965", "GMC", "Sierra 1500", 15L, "Petrol", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2GTEK19J441270429", "Green", 5.3m, "6E2G6C3U3A5H8D9L", "GMC", "Sierra", 30L, "Diesel", new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2HGES165X9H533726", "Black", null, "8H65E5L79F57R9J8C", "Honda", "Civic", 45L, "Petrol", new DateTime(2009, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2HGFG4A50CH701101", "Red", null, "3D68H7G59E56A8R7V", "Honda", "Accord", 41L, "Petrol", new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2HNYD2H31DH501112", "Red", 3.5m, "2ZQYF1111P5397859", "Acura", "MDX", 6L, "Petrol", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2T3WFREV3GW293769", "Gray", 3.8m, "982LKJHKJH8JHKL18", "Nissan", "GT-R", 19L, "Petrol", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "37D2AJLFEK7G6194W", "Gold", null, null, "Fiat", "126p", 1L, "Nuclear", new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3D7JB1EP3BG707058", "Gray", null, "6T09F9R13B97D2L1F", "Dodge", "Ram", 43L, "Diesel", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3FNRLW2BT3VWLLT7W", "Black", 2.0m, null, "Renault", "Laguna", 1L, "Diesel", new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3K3NT53X9XN433870", "White", 2.0m, "45JH9NB789JK8HJ22", "BMW", "530e", 18L, "Electric", new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3VW447AU5FM042417", "CUSTOM", 0.0m, "456LKJH9087GHJ987", "Tesla", "Model S", 29L, "Electric", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3VWLL7AJ3BM029633", "White", 2.0m, "8MYRY1111W1564311", "Volkswagen", "Jetta", 15L, "Petrol", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4JGDA5JB7HA946036", "White", 4.6m, "8IKJH7865HJKL9876", "Lexus", "GX 460", 21L, "Petrol", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4T1BD1FK3FU060871", "Gray", 2.5m, "4BCCX1111P5876452", "Toyota", "Camry", 9L, "Petrol", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4T1BF1FK7CU510635", "White", 2.5m, "67LKJHJ9087G65HJK", "Subaru", "WRX STI", 28L, "Petrol", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4USBT33534LS49963", "Gray", 2.0m, "87LKJHJ9087G65HJK", "Volkswagen", "Golf GTI", 27L, "Petrol", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5FNRL6H94JB058408", "White", 3.5m, "2MYKG1111B2611752", "Honda", "Odyssey", 6L, "Petrol", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5G5JZ18N8SL872546", "Red", 3.0m, "0ZLKJ89375KNKJ239", "Toyota", "Supra", 17L, "Petrol", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5J6RM4H33EL032008", "Silver", null, "3YVBH1111V0791189", "Honda", "CR-V", 7L, "Electric", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "EHV2T37F7T7VJVC26", "Yellow", 4.0m, "26KJGF2876KJDJKS1", "Porsche", "911 GT3", 16L, "Petrol", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "JH4DA9447HS009086", "White", 2.7m, "1L20T6J82E79S4H6K", "Acura", "Legend", 51L, "Petrol", new DateTime(1987, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "JH4DB7663RS001474", "Green", 2.5m, "5C36J1Y43A06D5H2P", "Acura", "Legend", 44L, "Petrol", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "JM1NC2MF9E0234389", "Blue", null, "1N6F1N8B9X9X2P3G", "Mazda", "MX-5 Miata", 32L, "Hydrogen", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "JN1CA21D1XT804210", "White", 3.0m, "7E08G1M16H28K6U0Y", "Nissan", "Maxima", 47L, "Petrol", new DateTime(1999, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "JTHBJ46G992339151", "Gray", null, "2P85H6L91F24G2E3W", "Lexus", "IS", 48L, "Petrol", new DateTime(2012, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "JTHBK1EG8C2417764", "Gray", null, "5X6B1C6U4Z4L1A8B", "Lexus", "ES", 30L, "Electric", new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "JTHBK1GG7D2027441", "Yellow", 5.2m, "65HJK87LKJHJ9087G", "Lamborghini", "Huracan", 26L, "Petrol", new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "JTHBW1GG7D2000178", "Orange", 4.0m, "786LKJH9087GHJ987", "McLaren", "765LT", 27L, "Petrol", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "KMHDN46D04U643031", "Silver", 2.0m, "9T8W8C8J3V7R7J1K", "Hyundai", "Elantra", null, "Diesel", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "WAUA2AFD2DN019030", "Red", 8.4m, "9NB7865HJKL9087KJ", "Dodge", "Viper SRT", 25L, "Petrol", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "WBAJB0C51BC532336", "Silver", 3.0m, "W9D0W1111T4302306", "BMW", "535i", 6L, "Petrol", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "WBAVA375X9NL06323", "Black", 3.0m, "2HBKM1111P5848492", "BMW", "328i", 14L, "Petrol", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "WDDWJ8KB2KF684794", "Blue", 4.0m, "56GJH879NBV5432RT", "Mercedes-Benz", "S 63 AMG", 22L, "Petrol", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "services",
                columns: new[] { "serviceID", "customerID", "employeeID", "paidOff", "serviceEndDate", "serviceStartDate", "VIN" },
                values: new object[,]
                {
                    { 1L, 1L, 2L, true, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "3FNRLW2BT3VWLLT7W" },
                    { 2L, 1L, 2L, true, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "37D2AJLFEK7G6194W" },
                    { 3L, 1L, 2L, true, new DateTime(2015, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "1G4EC11C4JB901987" },
                    { 4L, 1L, 2L, true, new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1G4EC11C4JB901988" },
                    { 5L, 1L, 2L, true, new DateTime(2017, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "1G4EC11C4JB901989" },
                    { 6L, 1L, 2L, true, new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1G4EC11C4JB901990" },
                    { 7L, 1L, 2L, true, new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1G4EC11C4JB901991" },
                    { 8L, 6L, 2L, true, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2HNYD2H31DH501112" },
                    { 9L, 6L, 2L, true, new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WBAJB0C51BC532336" },
                    { 10L, 7L, 2L, true, new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1FT7W2BT3DEB02692" },
                    { 11L, 7L, 3L, true, new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "5J6RM4H33EL032008" },
                    { 12L, 6L, 5L, true, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "5FNRL6H94JB058408" },
                    { 13L, 7L, 3L, true, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1C4SDHCT2EC518481" },
                    { 14L, 9L, 3L, true, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "4T1BD1FK3FU060871" },
                    { 15L, 9L, 5L, true, new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2C3CDXHG1EH218905" },
                    { 16L, 10L, 5L, true, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2GNAXTEV8J6252726" },
                    { 17L, 14L, 5L, true, new DateTime(2018, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "WBAVA375X9NL06323" },
                    { 18L, 14L, 5L, true, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1FTFW1ET0DFC21909" },
                    { 19L, 14L, 5L, true, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1HGCV1F34JA033044" },
                    { 20L, 15L, 5L, true, new DateTime(2018, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1GYS4CKJ4GR228491" },
                    { 21L, 15L, 5L, true, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2GTEK19B571125541" },
                    { 22L, 15L, 2L, true, new DateTime(2018, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3VWLL7AJ3BM029633" },
                    { 23L, 16L, 2L, true, new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1GKS1CE04BR207052" },
                    { 24L, 16L, 5L, true, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "EHV2T37F7T7VJVC26" },
                    { 25L, 17L, 5L, true, new DateTime(2022, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "5G5JZ18N8SL872546" },
                    { 26L, 18L, 2L, true, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3K3NT53X9XN433870" },
                    { 27L, 19L, 6L, true, new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2T3WFREV3GW293769" },
                    { 28L, 20L, 5L, true, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2C4RC1BG6LR224413" },
                    { 29L, 21L, 5L, true, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "4JGDA5JB7HA946036" },
                    { 30L, 22L, 8L, true, new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "WDDWJ8KB2KF684794" },
                    { 31L, 23L, 8L, true, new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2C4RC1BG7JR215755" },
                    { 32L, 24L, 8L, true, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2GNFLFEK7G6194764" },
                    { 33L, 25L, 8L, true, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "WAUA2AFD2DN019030" },
                    { 34L, 26L, 9L, true, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "JTHBK1GG7D2027441" },
                    { 35L, 27L, 9L, true, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "4USBT33534LS49963" },
                    { 36L, 27L, 8L, true, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "JTHBW1GG7D2000178" },
                    { 37L, 28L, 9L, true, new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "4T1BF1FK7CU510635" },
                    { 38L, 29L, 8L, true, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3VW447AU5FM042417" },
                    { 39L, 30L, 8L, true, new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "JTHBK1EG8C2417764" },
                    { 40L, 30L, 9L, true, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "2GTEK19J441270429" },
                    { 41L, 31L, 5L, true, new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "1ZVFT80N055185407" },
                    { 42L, 32L, 2L, true, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "JM1NC2MF9E0234389" },
                    { 43L, null, 6L, true, new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "KMHDN46D04U643031" },
                    { 44L, null, 2L, true, new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "1J8GR48K47C155348" },
                    { 45L, null, 9L, true, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "1N4BL4BV4KC183758" },
                    { 46L, null, 5L, true, new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "1FMZU77K74UB33195" },
                    { 47L, 35L, 6L, true, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "1N4AL3AP9EC215201" },
                    { 48L, 36L, 9L, true, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "1FTEW1E53MKE12935" },
                    { 49L, 37L, 5L, true, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "1G1PC5SB8E7182468" },
                    { 50L, 38L, 5L, true, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "1N4AA5AP3AC805981" },
                    { 51L, 39L, 5L, true, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "1G1JE6SB1C4183312" },
                    { 52L, 40L, 5L, true, new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "1J8GR48K47C828206" },
                    { 53L, 41L, 8L, true, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2HGFG4A50CH701101" },
                    { 54L, 42L, 8L, true, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1HGCM66594A098237" },
                    { 55L, 43L, 9L, true, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "3D7JB1EP3BG707058" },
                    { 56L, 44L, 8L, true, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "JH4DB7663RS001474" },
                    { 57L, 45L, 9L, true, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2HGES165X9H533726" },
                    { 58L, 46L, 8L, true, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "1FTFW1R62EFC81935" },
                    { 59L, 47L, 5L, true, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "JN1CA21D1XT804210" },
                    { 60L, 48L, 5L, true, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "JTHBJ46G992339151" },
                    { 61L, 49L, 8L, false, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2G1WT58K979277802" },
                    { 62L, 50L, 9L, false, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "1C3CDFBB5FD333450" },
                    { 63L, 51L, 9L, false, null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "JH4DA9447HS009086" },
                    { 64L, 52L, 5L, false, null, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2C4RDGCG4ER147255" },
                    { 65L, 52L, 3L, false, null, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "1FTWW33F62EA44809" },
                    { 66L, 52L, 5L, false, null, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "1G1BE5SM5H7248785" },
                    { 67L, 52L, 8L, false, null, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "1FMCU0DG0BKA06849" }
                });

            migrationBuilder.InsertData(
                table: "tasks",
                columns: new[] { "taskID", "description", "executionTime", "name", "serviceID" },
                values: new object[,]
                {
                    { 1L, "Improving handling and suspension performance", 1.0m, "Changing springs", 1L },
                    { 2L, "Repairing damage to the cylinder head", 5.0m, "Head replacement", 2L },
                    { 3L, "Replacing worn-out brake pads to ensure safe stopping", 1.0m, "Brake pad replacement", 3L },
                    { 4L, "Maintaining engine lubrication and preventing damage", 0.5m, "Oil change", 4L },
                    { 5L, "Repairing worn-out or damaged suspension components for improved handling and comfort", 3.0m, "Suspension repair", 5L },
                    { 6L, "Ensuring proper ignition and fuel economy", 1.0m, "Spark plug replacement", 5L },
                    { 7L, "Removing buildup and improving cooling efficiency", 1.0m, "Radiator flush", 6L },
                    { 8L, "Improving tire wear and handling performance", 1.0m, "Wheel alignment", 7L },
                    { 9L, "Maintaining transmission lubrication and preventing damage", 2.0m, "Transmission fluid change", 8L },
                    { 10L, "Preventing engine damage from belt failure", 4.0m, "Timing belt replacement", 9L },
                    { 11L, "Fixing leaks and improving engine performance", 1.0m, "Exhaust system repair", 10L },
                    { 12L, "Ensuring proper starting and electrical system function", 0.5m, "Battery replacement", 10L },
                    { 13L, "Preventing engine damage from fuel contaminants", 1.0m, "Fuel filter replacement", 11L },
                    { 14L, "Improving engine performance and fuel economy", 2.0m, "Engine tune-up", 12L },
                    { 15L, "Ensuring proper airflow and preventing engine damage", 0.5m, "Air filter replacement", 13L },
                    { 16L, "Fixing issues with spark plugs and coils for proper ignition", 3.0m, "Ignition system repair", 14L },
                    { 17L, "Improving tire wear and handling performance", 1.0m, "Tire rotation", 15L },
                    { 18L, "Ensuring proper electrical system function", 1.0m, "Alternator replacement", 15L },
                    { 19L, "Maintaining proper power steering function and preventing damage", 2.0m, "Power steering fluid change", 16L },
                    { 20L, "Fixing issues with clutch engagement and disengagement", 0.5m, "Clutch repair", 17L },
                    { 21L, "Repairing damaged brake lines for safe stopping", 3.0m, "Brake line repair", 18L },
                    { 22L, "Improving fuel efficiency and engine performance", 5.0m, "Fuel injector cleaning", 19L },
                    { 23L, "Fixing issues with cooling and comfort in the cabin", 1.0m, "AC system repair", 20L },
                    { 24L, "Preventing wheel damage and improving handling", 0.5m, "Wheel bearing replacement", 20L },
                    { 25L, "Preventing engine damage from belt failure", 3.0m, "Serpentine belt replacement", 21L },
                    { 26L, "Repairing internal transmission components for proper function", 0.5m, "Transmission rebuild", 22L },
                    { 27L, "Improving handling and comfort", 3.0m, "Shock absorber replacement", 23L },
                    { 28L, "Ensuring proper brake function and safe stopping", 1.0m, "Brake caliper replacement", 24L },
                    { 29L, "Preventing engine damage from coolant leaks", 1.0m, "Head gasket replacement", 25L },
                    { 30L, "Ensuring proper emissions control and engine performance", 2.0m, "Catalytic converter replacement", 25L },
                    { 31L, "Ensuring proper cooling function and preventing engine damage", 0.5m, "Radiator replacement", 26L },
                    { 32L, "Ensuring safe stopping and improving brake function", 3.0m, "Brake rotor replacement", 27L },
                    { 33L, "Preventing engine damage from coolant leaks and improving cooling function", 5.0m, "Water pump replacement", 28L },
                    { 34L, "Ensuring proper ignition and fuel economy", 1.0m, "Distributor replacement", 29L },
                    { 35L, "Ensuring proper fuel delivery and preventing engine damage", 1.0m, "Fuel pump replacement", 30L },
                    { 36L, "Improving steering function and handling", 1.0m, "Tie rod end replacement", 30L },
                    { 37L, "Preventing drivetrain damage and improving performance", 1.0m, "Drive shaft replacement", 31L },
                    { 38L, "Preventing oil leaks and ensuring proper lubrication", 2.0m, "Valve cover gasket replacement", 32L },
                    { 39L, "Ensuring proper engine timing and fuel economy", 4.0m, "Camshaft position sensor replacement", 33L },
                    { 40L, "Ensuring proper starting function", 5.0m, "Starter motor replacement", 34L },
                    { 41L, "Ensuring proper fuel economy and emissions control", 1.0m, "Oxygen sensor replacement", 35L },
                    { 42L, "Improving throttle response and fuel economy", 0.5m, "Throttle body cleaning", 35L },
                    { 43L, "Preventing vacuum leaks and improving engine performance", 3.0m, "Intake manifold gasket replacement", 36L },
                    { 44L, "Improving brake function and safety", 1.0m, "Brake booster replacement", 37L },
                    { 45L, "Ensuring proper emissions control and engine performance", 1.0m, "EGR valve replacement", 38L },
                    { 46L, "Improving cabin heating function and comfort", 1.0m, "Heater core replacement", 39L },
                    { 47L, "Improving handling and suspension performance", 2.0m, "Control arm replacement", 40L },
                    { 48L, "Ensuring proper fuel economy and engine performance", 4.0m, "Mass airflow sensor replacement", 40L },
                    { 49L, "Improving engine stability and reducing vibration", 2.0m, "Engine mount replacement", 41L },
                    { 50L, "Preventing engine damage from belt failure", 1.0m, "Drive belt replacement", 42L },
                    { 51L, "Improving handling and comfort", 5.0m, "Shock mount replacement", 43L },
                    { 52L, "Fixing leaks and improving engine performance", 3.0m, "Exhaust manifold replacement", 44L },
                    { 53L, "Removing air and contaminants from the brake lines for improved function", 5.0m, "Brake line flush", 44L },
                    { 54L, "Preventing oil loss and ensuring proper lubrication", 3.0m, "Engine oil leak repair", 44L },
                    { 55L, "Improving handling and suspension performance", 2.0m, "Sway bar link replacement", 45L },
                    { 56L, "Ensuring proper window function", 0.5m, "Power window motor replacement", 45L },
                    { 57L, "Ensuring proper ignition and fuel economy", 0.5m, "Ignition coil replacement", 45L },
                    { 58L, " faulty relay causing fuel pump to fail", 1.0m, "Fuel pump relay replacement", 46L },
                    { 59L, " worn out or damaged sensor affecting engine performance", 2.0m, "Throttle position sensor replacement", 46L },
                    { 60L, " worn or damaged switch causing engine to not start", 4.0m, "Ignition switch replacement", 47L },
                    { 61L, " worn or damaged hub assembly causing wheel to wobble", 4.0m, "Wheel hub assembly replacement", 47L },
                    { 62L, " worn or damaged drum affecting braking performance", 2.0m, "Brake drum replacement", 48L },
                    { 63L, " worn out or damaged seals causing oil leakage and smoke from the exhaust", 4.0m, "Valve stem seal replacement", 49L },
                    { 64L, " torn or damaged boot causing dirt and debris to enter the tie rod", 0.5m, "Tie rod boot replacement", 50L },
                    { 65L, " worn out or damaged tensioner affecting the performance of the drive belt", 0.5m, "Drive belt tensioner replacement", 50L },
                    { 66L, " faulty sensor causing inaccurate oil pressure readings", 1.0m, "Oil pressure sensor replacement", 51L },
                    { 67L, " malfunctioning module affecting various engine functions", 2.0m, "Engine control module replacement", 51L },
                    { 68L, " worn out or damaged fan motor causing overheating", 4.0m, "Radiator fan motor replacement", 51L },
                    { 69L, " faulty valve affecting engine idle speed", 0.5m, "Idle air control valve replacement", 52L },
                    { 70L, " worn out or damaged blower motor causing lack of heat or A/C", 0.5m, "Heater blower motor replacement", 52L },
                    { 71L, " rust or damage to the fuel tank causing leaks or reduced fuel capacity", 1.0m, "Fuel tank replacement", 52L },
                    { 72L, " worn out or damaged cylinder affecting brake performance", 2.0m, "Brake master cylinder replacement", 53L },
                    { 73L, " worn out or damaged compressor affecting A/C performance", 4.0m, "A/C compressor replacement", 53L },
                    { 74L, " worn out or damaged joint causing clicking or popping noise when turning", 2.0m, "CV joint replacement", 53L },
                    { 75L, " worn out or damaged chain affecting engine performance and timing", 4.0m, "Timing chain replacement", 54L },
                    { 76L, " faulty sensor affecting accurate temperature readings and engine performance", 0.5m, "Engine coolant temperature sensor replacement", 55L },
                    { 77L, " worn out or damaged cap and rotor affecting ignition and engine performance", 0.5m, "Ignition distributor cap and rotor replacement", 55L },
                    { 78L, " worn out or damaged regulator affecting window movement", 0.5m, "Window regulator replacement", 56L },
                    { 79L, " dirty sensor affecting engine performance and fuel economy", 0.5m, "Mass air flow sensor cleaning", 57L },
                    { 80L, " worn out or damaged screw affecting brake bleeding and maintenance", 1.0m, "Brake bleeder screw replacement", 58L },
                    { 81L, " faulty sensor affecting engine performance and fuel economy", 2.0m, "Intake air temperature sensor replacement", 59L },
                    { 82L, " worn out or damaged valve affecting brake balance and performance", 4.0m, "Brake proportioning valve replacement", 59L },
                    { 83L, " worn out or damaged pump affecting engine lubrication and performance", 0.5m, "Oil pump replacement", 59L },
                    { 84L, " faulty sensor affecting accurate camshaft position readings and engine performance", 0.5m, "Camshaft sensor replacement", 60L },
                    { 85L, " faulty regulator affecting fuel pressure and engine performance", 1.0m, "Fuel pressure regulator replacement", 60L },
                    { 86L, " worn out or damaged mount affecting transmission stability and performance", 2.0m, "Transmission mount replacement", 60L },
                    { 87L, " worn out or damaged pulley affecting drive belt performance and engine accessories", 4.0m, "Drive belt pulley replacement", 60L },
                    { 88L, " worn out or damaged module affecting ignition and engine performance", 2.0m, "Ignition control module replacement", 61L },
                    { 89L, " worn out or damaged sensor affecting accurate speed readings and ABS performance", 4.0m, "Wheel speed sensor replacement", 62L },
                    { 90L, " worn out or clogged valve affecting engine performance and emissions", 0.5m, "PCV valve replacement", 63L },
                    { 91L, " worn out or damaged fitting affecting brake performance and safety", 0.5m, "Brake line fitting replacement", 64L },
                    { 92L, " worn out or damaged cover causing oil leaks and engine damage", 1.0m, "Valve cover replacement", 64L },
                    { 93L, " worn out or damaged condenser affecting A/C performance", 2.0m, "AC condenser replacement", 64L },
                    { 94L, " worn out or damaged rotor affecting braking performance", 4.0m, "Brake rotor resurfacing", 65L },
                    { 95L, " rust or damage to the filler neck causing fuel leaks or difficulty filling up", 0.5m, "Fuel tank filler neck replacement", 65L },
                    { 96L, " worn out or damaged motor affecting engine idle speed and performance", 2.0m, "Idle speed control motor replacement", 65L },
                    { 97L, " worn out or damaged line affecting transmission cooling and performance", 3.0m, "Transmission cooler line replacement", 66L },
                    { 98L, " worn out or damaged shield affecting exhaust system performance and safety.", 1.0m, "Catalytic converter heat shield replacement", 67L }
                });

            migrationBuilder.InsertData(
                table: "tasks_employees",
                columns: new[] { "employeeID", "taskID" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 1L, 2L },
                    { 1L, 3L },
                    { 2L, 4L },
                    { 2L, 5L },
                    { 2L, 6L },
                    { 2L, 7L },
                    { 2L, 8L },
                    { 2L, 9L },
                    { 2L, 10L },
                    { 2L, 11L },
                    { 2L, 12L },
                    { 2L, 26L },
                    { 2L, 27L },
                    { 2L, 31L },
                    { 2L, 50L },
                    { 2L, 52L },
                    { 2L, 53L },
                    { 2L, 54L },
                    { 3L, 13L },
                    { 3L, 15L },
                    { 3L, 16L },
                    { 3L, 94L },
                    { 3L, 95L },
                    { 3L, 96L },
                    { 5L, 14L },
                    { 5L, 17L },
                    { 5L, 18L },
                    { 5L, 19L },
                    { 5L, 20L },
                    { 5L, 21L },
                    { 5L, 22L },
                    { 5L, 23L },
                    { 5L, 24L },
                    { 5L, 25L },
                    { 5L, 28L },
                    { 5L, 29L },
                    { 5L, 30L },
                    { 5L, 33L },
                    { 5L, 34L },
                    { 5L, 49L },
                    { 5L, 58L },
                    { 5L, 59L },
                    { 5L, 63L },
                    { 5L, 64L },
                    { 5L, 65L },
                    { 5L, 66L },
                    { 5L, 67L },
                    { 5L, 68L },
                    { 5L, 69L },
                    { 5L, 70L },
                    { 5L, 71L },
                    { 5L, 81L },
                    { 5L, 82L },
                    { 5L, 83L },
                    { 5L, 84L },
                    { 5L, 85L },
                    { 5L, 86L },
                    { 5L, 87L },
                    { 5L, 91L },
                    { 5L, 92L },
                    { 5L, 93L },
                    { 5L, 97L },
                    { 6L, 32L },
                    { 6L, 51L },
                    { 6L, 60L },
                    { 6L, 61L },
                    { 8L, 35L },
                    { 8L, 36L },
                    { 8L, 37L },
                    { 8L, 38L },
                    { 8L, 39L },
                    { 8L, 43L },
                    { 8L, 45L },
                    { 8L, 46L },
                    { 8L, 72L },
                    { 8L, 73L },
                    { 8L, 74L },
                    { 8L, 75L },
                    { 8L, 78L },
                    { 8L, 80L },
                    { 8L, 88L },
                    { 8L, 98L },
                    { 9L, 40L },
                    { 9L, 41L },
                    { 9L, 42L },
                    { 9L, 44L },
                    { 9L, 47L },
                    { 9L, 48L },
                    { 9L, 55L },
                    { 9L, 56L },
                    { 9L, 57L },
                    { 9L, 62L },
                    { 9L, 76L },
                    { 9L, 77L },
                    { 9L, 79L },
                    { 9L, 89L },
                    { 9L, 90L }
                });

            migrationBuilder.InsertData(
                table: "tasks_parts",
                columns: new[] { "partID", "taskID" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 1L },
                    { 3L, 2L },
                    { 4L, 3L },
                    { 5L, 3L },
                    { 6L, 4L },
                    { 7L, 4L },
                    { 8L, 5L },
                    { 9L, 6L },
                    { 10L, 7L },
                    { 11L, 7L },
                    { 12L, 8L },
                    { 13L, 9L },
                    { 14L, 10L },
                    { 15L, 11L },
                    { 16L, 12L },
                    { 17L, 12L },
                    { 18L, 13L },
                    { 19L, 13L },
                    { 20L, 14L },
                    { 21L, 15L },
                    { 22L, 16L },
                    { 23L, 17L },
                    { 24L, 18L },
                    { 25L, 19L },
                    { 26L, 20L },
                    { 27L, 21L },
                    { 28L, 22L },
                    { 29L, 23L },
                    { 30L, 24L },
                    { 31L, 25L },
                    { 32L, 27L },
                    { 33L, 28L },
                    { 34L, 29L },
                    { 35L, 30L },
                    { 36L, 31L },
                    { 37L, 32L },
                    { 38L, 33L },
                    { 39L, 34L },
                    { 40L, 35L },
                    { 41L, 36L },
                    { 42L, 37L },
                    { 43L, 38L },
                    { 44L, 39L },
                    { 45L, 40L },
                    { 46L, 41L },
                    { 47L, 42L },
                    { 48L, 43L },
                    { 49L, 44L },
                    { 50L, 45L },
                    { 51L, 46L },
                    { 52L, 47L },
                    { 53L, 48L },
                    { 54L, 49L },
                    { 55L, 50L },
                    { 56L, 51L },
                    { 57L, 52L },
                    { 58L, 53L },
                    { 59L, 54L },
                    { 60L, 55L },
                    { 61L, 56L },
                    { 62L, 57L },
                    { 63L, 58L },
                    { 64L, 59L },
                    { 65L, 60L },
                    { 66L, 61L },
                    { 67L, 62L },
                    { 68L, 63L },
                    { 69L, 64L },
                    { 70L, 65L },
                    { 71L, 66L },
                    { 72L, 67L },
                    { 73L, 68L },
                    { 74L, 69L },
                    { 75L, 70L },
                    { 76L, 71L },
                    { 77L, 72L },
                    { 78L, 73L },
                    { 79L, 74L },
                    { 80L, 75L },
                    { 81L, 76L },
                    { 82L, 77L },
                    { 83L, 78L },
                    { 84L, 79L },
                    { 85L, 80L },
                    { 86L, 81L },
                    { 87L, 82L },
                    { 88L, 83L },
                    { 89L, 84L },
                    { 90L, 85L },
                    { 91L, 86L },
                    { 92L, 87L },
                    { 93L, 88L },
                    { 94L, 89L },
                    { 95L, 90L },
                    { 96L, 91L },
                    { 97L, 92L },
                    { 98L, 93L },
                    { 99L, 94L },
                    { 100L, 95L },
                    { 101L, 96L },
                    { 102L, 97L },
                    { 103L, 98L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 3L, 4L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 4L, 5L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 4L, 6L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 5L, 7L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 6L, 8L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 7L, 9L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 8L, 10L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 8L, 11L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 9L, 12L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 9L, 13L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 10L, 14L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 11L, 15L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 11L, 16L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 12L, 17L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 13L, 18L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 14L, 19L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 15L, 20L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 15L, 21L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 16L, 22L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 17L, 23L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 16L, 24L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 17L, 25L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 18L, 26L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 18L, 27L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 19L, 28L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 20L, 29L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 20L, 30L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 21L, 31L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 22L, 32L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 23L, 33L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 24L, 34L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 25L, 35L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 26L, 36L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 27L, 37L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 28L, 38L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 29L, 39L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 29L, 40L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 30L, 41L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 31L, 42L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 32L, 43L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 33L, 44L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 34L, 45L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 35L, 46L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 36L, 47L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 37L, 48L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 38L, 49L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 39L, 50L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 40L, 51L });

            migrationBuilder.DeleteData(
                table: "persons_addresses",
                keyColumns: new[] { "addressID", "personID" },
                keyValues: new object[] { 40L, 52L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 1L, 2L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 1L, 3L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 4L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 5L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 6L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 7L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 8L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 9L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 10L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 11L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 12L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 26L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 27L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 31L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 50L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 52L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 53L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 2L, 54L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 3L, 13L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 3L, 15L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 3L, 16L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 3L, 94L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 3L, 95L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 3L, 96L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 14L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 17L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 18L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 19L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 20L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 21L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 22L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 23L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 24L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 25L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 28L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 29L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 30L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 33L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 34L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 49L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 58L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 59L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 63L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 64L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 65L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 66L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 67L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 68L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 69L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 70L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 71L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 81L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 82L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 83L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 84L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 85L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 86L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 87L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 91L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 92L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 93L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 5L, 97L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 6L, 32L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 6L, 51L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 6L, 60L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 6L, 61L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 35L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 36L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 37L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 38L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 39L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 43L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 45L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 46L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 72L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 73L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 74L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 75L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 78L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 80L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 88L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 8L, 98L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 40L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 41L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 42L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 44L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 47L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 48L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 55L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 56L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 57L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 62L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 76L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 77L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 79L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 89L });

            migrationBuilder.DeleteData(
                table: "tasks_employees",
                keyColumns: new[] { "employeeID", "taskID" },
                keyValues: new object[] { 9L, 90L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 2L, 1L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 3L, 2L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 4L, 3L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 5L, 3L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 6L, 4L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 7L, 4L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 8L, 5L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 9L, 6L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 10L, 7L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 11L, 7L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 12L, 8L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 13L, 9L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 14L, 10L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 15L, 11L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 16L, 12L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 17L, 12L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 18L, 13L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 19L, 13L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 20L, 14L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 21L, 15L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 22L, 16L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 23L, 17L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 24L, 18L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 25L, 19L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 26L, 20L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 27L, 21L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 28L, 22L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 29L, 23L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 30L, 24L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 31L, 25L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 32L, 27L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 33L, 28L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 34L, 29L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 35L, 30L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 36L, 31L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 37L, 32L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 38L, 33L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 39L, 34L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 40L, 35L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 41L, 36L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 42L, 37L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 43L, 38L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 44L, 39L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 45L, 40L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 46L, 41L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 47L, 42L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 48L, 43L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 49L, 44L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 50L, 45L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 51L, 46L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 52L, 47L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 53L, 48L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 54L, 49L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 55L, 50L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 56L, 51L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 57L, 52L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 58L, 53L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 59L, 54L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 60L, 55L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 61L, 56L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 62L, 57L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 63L, 58L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 64L, 59L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 65L, 60L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 66L, 61L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 67L, 62L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 68L, 63L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 69L, 64L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 70L, 65L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 71L, 66L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 72L, 67L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 73L, 68L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 74L, 69L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 75L, 70L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 76L, 71L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 77L, 72L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 78L, 73L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 79L, 74L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 80L, 75L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 81L, 76L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 82L, 77L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 83L, 78L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 84L, 79L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 85L, 80L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 86L, 81L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 87L, 82L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 88L, 83L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 89L, 84L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 90L, 85L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 91L, 86L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 92L, 87L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 93L, 88L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 94L, 89L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 95L, 90L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 96L, 91L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 97L, 92L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 98L, 93L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 99L, 94L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 100L, 95L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 101L, 96L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 102L, 97L });

            migrationBuilder.DeleteData(
                table: "tasks_parts",
                keyColumns: new[] { "partID", "taskID" },
                keyValues: new object[] { 103L, 98L });

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "addressID",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "parts",
                keyColumn: "partID",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "tasks",
                keyColumn: "taskID",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "services",
                keyColumn: "serviceID",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customerID",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "employeeID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1C3CDFBB5FD333450");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1C4SDHCT2EC518481");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1FMCU0DG0BKA06849");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1FMZU77K74UB33195");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1FT7W2BT3DEB02692");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1FTEW1E53MKE12935");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1FTFW1ET0DFC21909");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1FTFW1R62EFC81935");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1FTWW33F62EA44809");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1G1BE5SM5H7248785");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1G1JE6SB1C4183312");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1G1PC5SB8E7182468");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901987");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901988");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901989");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901990");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901991");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1GKS1CE04BR207052");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1GYS4CKJ4GR228491");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1HGCM66594A098237");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1HGCV1F34JA033044");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1J8GR48K47C155348");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1J8GR48K47C828206");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1N4AA5AP3AC805981");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1N4AL3AP9EC215201");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1N4BL4BV4KC183758");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "1ZVFT80N055185407");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2C3CDXHG1EH218905");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2C4RC1BG6LR224413");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2C4RC1BG7JR215755");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2C4RDGCG4ER147255");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2G1WT58K979277802");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2GNAXTEV8J6252726");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2GNFLFEK7G6194764");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2GTEK19B571125541");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2GTEK19J441270429");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2HGES165X9H533726");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2HGFG4A50CH701101");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2HNYD2H31DH501112");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "2T3WFREV3GW293769");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "37D2AJLFEK7G6194W");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "3D7JB1EP3BG707058");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "3FNRLW2BT3VWLLT7W");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "3K3NT53X9XN433870");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "3VW447AU5FM042417");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "3VWLL7AJ3BM029633");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "4JGDA5JB7HA946036");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "4T1BD1FK3FU060871");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "4T1BF1FK7CU510635");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "4USBT33534LS49963");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "5FNRL6H94JB058408");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "5G5JZ18N8SL872546");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "5J6RM4H33EL032008");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "EHV2T37F7T7VJVC26");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "JH4DA9447HS009086");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "JH4DB7663RS001474");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "JM1NC2MF9E0234389");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "JN1CA21D1XT804210");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "JTHBJ46G992339151");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "JTHBK1EG8C2417764");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "JTHBK1GG7D2027441");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "JTHBW1GG7D2000178");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "KMHDN46D04U643031");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "WAUA2AFD2DN019030");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "WBAJB0C51BC532336");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "WBAVA375X9NL06323");

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "VIN",
                keyValue: "WDDWJ8KB2KF684794");

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "personID",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1C3CDFBB5FD333450");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1C4SDHCT2EC518481");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1FMCU0DG0BKA06849");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1FMZU77K74UB33195");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1FT7W2BT3DEB02692");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1FTEW1E53MKE12935");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1FTFW1ET0DFC21909");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1FTFW1R62EFC81935");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1FTWW33F62EA44809");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1G1BE5SM5H7248785");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1G1JE6SB1C4183312");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1G1PC5SB8E7182468");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901987");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901988");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901989");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901990");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1G4EC11C4JB901991");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1GKS1CE04BR207052");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1GYS4CKJ4GR228491");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1HGCM66594A098237");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1HGCV1F34JA033044");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1J8GR48K47C155348");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1J8GR48K47C828206");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1N4AA5AP3AC805981");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1N4AL3AP9EC215201");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1N4BL4BV4KC183758");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "1ZVFT80N055185407");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2C3CDXHG1EH218905");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2C4RC1BG6LR224413");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2C4RC1BG7JR215755");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2C4RDGCG4ER147255");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2G1WT58K979277802");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2GNAXTEV8J6252726");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2GNFLFEK7G6194764");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2GTEK19B571125541");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2GTEK19J441270429");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2HGES165X9H533726");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2HGFG4A50CH701101");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2HNYD2H31DH501112");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "2T3WFREV3GW293769");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "37D2AJLFEK7G6194W");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "3D7JB1EP3BG707058");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "3FNRLW2BT3VWLLT7W");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "3K3NT53X9XN433870");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "3VW447AU5FM042417");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "3VWLL7AJ3BM029633");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "4JGDA5JB7HA946036");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "4T1BD1FK3FU060871");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "4T1BF1FK7CU510635");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "4USBT33534LS49963");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "5FNRL6H94JB058408");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "5G5JZ18N8SL872546");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "5J6RM4H33EL032008");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "EHV2T37F7T7VJVC26");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "JH4DA9447HS009086");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "JH4DB7663RS001474");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "JM1NC2MF9E0234389");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "JN1CA21D1XT804210");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "JTHBJ46G992339151");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "JTHBK1EG8C2417764");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "JTHBK1GG7D2027441");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "JTHBW1GG7D2000178");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "KMHDN46D04U643031");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "WAUA2AFD2DN019030");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "WBAJB0C51BC532336");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "WBAVA375X9NL06323");

            migrationBuilder.DeleteData(
                table: "powerSources",
                keyColumn: "VIN",
                keyValue: "WDDWJ8KB2KF684794");

            migrationBuilder.AlterColumn<string>(
                name: "manufacturerArtNo",
                table: "parts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
