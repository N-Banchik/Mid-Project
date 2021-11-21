using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class InitalDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address_Employees",
                columns: table => new
                {
                    Address_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(name: "Employee Id", type: "int", nullable: false),
                    StreetName = table.Column<string>(name: "Street Name", type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(name: "House Number", type: "int", nullable: false),
                    ApartmentNumber = table.Column<int>(name: "Apartment Number", type: "int", nullable: false),
                    Zipcode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Address Id", x => x.Address_ID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(name: "Brand Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(name: "Brand Name", type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ManufacturingCountry = table.Column<string>(name: "Manufacturing Country", type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Category ID", x => x.Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Costumers",
                columns: table => new
                {
                    CostumerId = table.Column<int>(name: "Costumer Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First Name", type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(name: "Last Name", type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Email = table.Column<string>(type: "nvarchar", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phonenumber = table.Column<string>(name: "Phone number", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.CostumerId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer: Identity", "1000, 1"),
                    FirstName = table.Column<string>(name: "First Name", type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(name: "Last Name", type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    HireDate = table.Column<DateTime>(name: "Hire Date", type: "smalldatetime", nullable: false),
                    Phonenumber = table.Column<string>(name: "Phone number", type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Is_Manager = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_address_Employees_ID",
                        column: x => x.ID,
                        principalTable: "address_Employees",
                        principalColumn: "Address_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(name: "Item Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(name: "Item Name", type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(name: "Category Id", type: "int", nullable: false),
                    BrandId = table.Column<int>(name: "Brand Id", type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    UnitsIninventory = table.Column<int>(name: "Units In inventory", type: "int", nullable: false),
                    MinimumUnitsIninventory = table.Column<int>(name: "Minimum Units In inventory", type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Brands_Brand Id",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Brand Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Categories_Category Id",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address_Costumers",
                columns: table => new
                {
                    Address_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Costumer_ID = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(name: "Street Name", type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(name: "House Number", type: "int", nullable: false),
                    ApartmentNumber = table.Column<int>(name: "Apartment Number", type: "int", nullable: false),
                    Zipcode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address_Costumers", x => x.Address_ID);
                    table.ForeignKey(
                        name: "FK_Address_Costumers_Costumers_Costumer_ID",
                        column: x => x.Costumer_ID,
                        principalTable: "Costumers",
                        principalColumn: "Costumer Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(name: "Order Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100, 1"),
                    CostumerId = table.Column<int>(name: "Costumer Id", type: "int", nullable: false),
                    EmployeeId = table.Column<int>(name: "Employee Id", type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(name: "Order Date", type: "smalldatetime", nullable: false),
                    ShipDate = table.Column<DateTime>(name: "Ship Date", type: "smalldatetime", nullable: false),
                    TotalCost = table.Column<double>(name: "Total Cost", type: "float", nullable: false),
                    TotalWeight = table.Column<double>(name: "Total Weight", type: "float", nullable: false),
                    CostumerEmail = table.Column<string>(name: "Costumer E-mail", type: "Nvarchar(50)", maxLength: 50, nullable: true),
                    CostumerAddress = table.Column<string>(name: "Costumer Address", type: "Nvarchar(70)", maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Costumers_Costumer Id",
                        column: x => x.CostumerId,
                        principalTable: "Costumers",
                        principalColumn: "Costumer Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_Employee Id",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Shift_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_ID = table.Column<int>(type: "int", nullable: false),
                    Shiftendtime = table.Column<DateTime>(name: "Shift end time", type: "smalldatetime", nullable: false),
                    Shift_End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftTime = table.Column<double>(name: "Shift Time", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Shift_ID);
                    table.ForeignKey(
                        name: "FK_Shifts_Employees_Employee_ID",
                        column: x => x.Employee_ID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orderitems",
                columns: table => new
                {
                    Itme_Id = table.Column<int>(type: "int", nullable: false),
                    Order_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderitems", x => new { x.Order_id, x.Itme_Id });
                    table.ForeignKey(
                        name: "FK_Orderitems_Items_Itme_Id",
                        column: x => x.Itme_Id,
                        principalTable: "Items",
                        principalColumn: "Item Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orderitems_Orders_Order_id",
                        column: x => x.Order_id,
                        principalTable: "Orders",
                        principalColumn: "Order Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_Costumers_Costumer_ID",
                table: "Address_Costumers",
                column: "Costumer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Brand Id",
                table: "Items",
                column: "Brand Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Category Id",
                table: "Items",
                column: "Category Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orderitems_Itme_Id",
                table: "Orderitems",
                column: "Itme_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Costumer Id",
                table: "Orders",
                column: "Costumer Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Employee Id",
                table: "Orders",
                column: "Employee Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_Employee_ID",
                table: "Shifts",
                column: "Employee_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address_Costumers");

            migrationBuilder.DropTable(
                name: "Orderitems");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Costumers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "address_Employees");
        }
    }
}
