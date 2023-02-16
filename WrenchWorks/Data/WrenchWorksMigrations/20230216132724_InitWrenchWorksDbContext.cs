﻿#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace WrenchWorks.Data.WrenchWorksMigrations
{
    /// <inheritdoc />
    public partial class InitWrenchWorksDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    addressID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    region = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    city = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    street = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    buildingNo = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    flatNo = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    postCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses_personID_addressID", x => x.addressID);
                });

            migrationBuilder.CreateTable(
                name: "bodyColors",
                columns: table => new
                {
                    bodyColor = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bodyColors_bodyColor", x => x.bodyColor);
                });

            migrationBuilder.CreateTable(
                name: "fuelTypes",
                columns: table => new
                {
                    fuelType = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fuelTypes_fuelType", x => x.fuelType);
                });

            migrationBuilder.CreateTable(
                name: "parts",
                columns: table => new
                {
                    partID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    manufacturer = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    manufacturerArtNo = table.Column<long>(type: "bigint", nullable: true),
                    partName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    category = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parts_partID", x => x.partID);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    positionID = table.Column<short>(type: "smallint", nullable: false),
                    supervisorID = table.Column<short>(type: "smallint", nullable: true),
                    positionName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions_position", x => x.positionID);
                    table.UniqueConstraint("AK_positions_positionName", x => x.positionName);
                    table.ForeignKey(
                        name: "isSupervisor",
                        column: x => x.supervisorID,
                        principalTable: "positions",
                        principalColumn: "positionID");
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    personID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    telephoneNumber = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    addressID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons_personID", x => x.personID);
                    table.ForeignKey(
                        name: "definesPersonsAddress",
                        column: x => x.addressID,
                        principalTable: "addresses",
                        principalColumn: "addressID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "powerSources",
                columns: table => new
                {
                    VIN = table.Column<string>(type: "char(17)", unicode: false, fixedLength: true, maxLength: 17, nullable: false),
                    mainPowerSourceType = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    hybrid = table.Column<bool>(type: "bit", nullable: false),
                    biofuel = table.Column<bool>(type: "bit", nullable: false),
                    LPG = table.Column<bool>(type: "bit", nullable: false),
                    CNG = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_powerSources_VIN", x => x.VIN);
                    table.ForeignKey(
                        name: "powerSourceType",
                        column: x => x.mainPowerSourceType,
                        principalTable: "fuelTypes",
                        principalColumn: "fuelType");
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customerID = table.Column<long>(type: "bigint", nullable: false),
                    totalDue = table.Column<decimal>(type: "money", nullable: false),
                    NIP = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers_customerID", x => x.customerID);
                    table.ForeignKey(
                        name: "personIsCustomer",
                        column: x => x.customerID,
                        principalTable: "persons",
                        principalColumn: "personID");
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employeeID = table.Column<long>(type: "bigint", nullable: false),
                    dateOfEmployment = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    positionName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees_employeeID", x => x.employeeID);
                    table.ForeignKey(
                        name: "employeeWorksOnPosition",
                        column: x => x.positionName,
                        principalTable: "positions",
                        principalColumn: "positionName");
                    table.ForeignKey(
                        name: "personIsEmployee",
                        column: x => x.employeeID,
                        principalTable: "persons",
                        principalColumn: "personID");
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    VIN = table.Column<string>(type: "char(17)", unicode: false, fixedLength: true, maxLength: 17, nullable: false),
                    maker = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    model = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    yearOfProduction = table.Column<DateTime>(type: "date", nullable: false),
                    engineCapacity = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    powerSource = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    engineNo = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    bodyColor = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    personID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles_VIN", x => x.VIN);
                    table.ForeignKey(
                        name: "personHasVehicle",
                        column: x => x.personID,
                        principalTable: "persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "vehicleHasBodyColor",
                        column: x => x.bodyColor,
                        principalTable: "bodyColors",
                        principalColumn: "bodyColor");
                    table.ForeignKey(
                        name: "vehicleHasPowerSources",
                        column: x => x.VIN,
                        principalTable: "powerSources",
                        principalColumn: "VIN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    serviceID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VIN = table.Column<string>(type: "char(17)", unicode: false, fixedLength: true, maxLength: 17, nullable: true),
                    totalCost = table.Column<decimal>(type: "smallmoney", nullable: true, defaultValueSql: "((0))"),
                    serviceStartDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    serviceEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    customerID = table.Column<long>(type: "bigint", nullable: true),
                    employeeID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services_serviceID", x => x.serviceID);
                    table.ForeignKey(
                        name: "customerOrdersService",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "customerID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "empResponsibleForService",
                        column: x => x.employeeID,
                        principalTable: "employees",
                        principalColumn: "employeeID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "serviceAssignedToVehicle",
                        column: x => x.VIN,
                        principalTable: "vehicles",
                        principalColumn: "VIN",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    taskID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    executionTime = table.Column<float>(type: "real", nullable: false),
                    partsCost = table.Column<decimal>(type: "smallmoney", nullable: false),
                    serviceID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks_taskID", x => x.taskID);
                    table.ForeignKey(
                        name: "serviceConsistsOfTasks",
                        column: x => x.serviceID,
                        principalTable: "services",
                        principalColumn: "serviceID");
                });

            migrationBuilder.CreateTable(
                name: "tasks_employees",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false),
                    TaskId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks_employees", x => new { x.EmployeeId, x.TaskId });
                    table.ForeignKey(
                        name: "definesEmployeeTask",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "employeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "definesTaskEmployee",
                        column: x => x.TaskId,
                        principalTable: "tasks",
                        principalColumn: "taskID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tasks_parts",
                columns: table => new
                {
                    PartId = table.Column<long>(type: "bigint", nullable: false),
                    TaskId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks_parts", x => new { x.PartId, x.TaskId });
                    table.ForeignKey(
                        name: "definesPartTask",
                        column: x => x.PartId,
                        principalTable: "parts",
                        principalColumn: "partID");
                    table.ForeignKey(
                        name: "definesTaskPart",
                        column: x => x.TaskId,
                        principalTable: "tasks",
                        principalColumn: "taskID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_positionName",
                table: "employees",
                column: "positionName");

            migrationBuilder.CreateIndex(
                name: "UNIQ_part",
                table: "parts",
                columns: new[] { "manufacturer", "manufacturerArtNo" },
                unique: true,
                filter: "[manufacturerArtNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_persons_addressID",
                table: "persons",
                column: "addressID");

            migrationBuilder.CreateIndex(
                name: "IX_positions_supervisorID",
                table: "positions",
                column: "supervisorID");

            migrationBuilder.CreateIndex(
                name: "UNIQ_position",
                table: "positions",
                column: "positionName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_powerSources_mainPowerSourceType",
                table: "powerSources",
                column: "mainPowerSourceType");

            migrationBuilder.CreateIndex(
                name: "IX_services_customerID",
                table: "services",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_services_employeeID",
                table: "services",
                column: "employeeID");

            migrationBuilder.CreateIndex(
                name: "IX_services_VIN",
                table: "services",
                column: "VIN");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_serviceID",
                table: "tasks",
                column: "serviceID");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_employees_TaskId",
                table: "tasks_employees",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_tasks_parts_TaskId",
                table: "tasks_parts",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_bodyColor",
                table: "vehicles",
                column: "bodyColor");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_personID",
                table: "vehicles",
                column: "personID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tasks_employees");

            migrationBuilder.DropTable(
                name: "tasks_parts");

            migrationBuilder.DropTable(
                name: "parts");

            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "bodyColors");

            migrationBuilder.DropTable(
                name: "powerSources");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "fuelTypes");
        }
    }
}
