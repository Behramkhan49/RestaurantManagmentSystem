using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant_Managment_System.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Cust_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cust_Name = table.Column<string>(type: "varchar(15)", nullable: true),
                    Cust_NIC = table.Column<string>(type: "varchar(15)", nullable: true),
                    Cust_Email = table.Column<string>(type: "varchar(20)", nullable: true),
                    Cust_Password = table.Column<string>(type: "varchar(15)", nullable: true),
                    Cust_Contact = table.Column<string>(type: "varchar(15)", nullable: true),
                    Cust_Address = table.Column<string>(type: "varchar(15)", nullable: true),
                    Cust_City = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Cust_Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount_Types",
                columns: table => new
                {
                    Dis_Type_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dis_Type_Name = table.Column<string>(type: "varchar(15)", nullable: true),
                    Dis_Type_Desc = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount_Types", x => x.Dis_Type_Id);
                });

            migrationBuilder.CreateTable(
                name: "Food_Categories",
                columns: table => new
                {
                    Cat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food_Categories", x => x.Cat_Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Loc_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Loc_Name = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Loc_Id);
                });

            migrationBuilder.CreateTable(
                name: "Measurement_Units",
                columns: table => new
                {
                    UOM_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UOM_Desc = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurement_Units", x => x.UOM_Id);
                });

            migrationBuilder.CreateTable(
                name: "Opening_Hours",
                columns: table => new
                {
                    Opn_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "varchar(15)", nullable: true),
                    From_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To_Time = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opening_Hours", x => x.Opn_Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment_Types",
                columns: table => new
                {
                    Pay_Type_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pay_Type_Desc = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Types", x => x.Pay_Type_Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant_Details",
                columns: table => new
                {
                    Res_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Res_Name = table.Column<string>(type: "varchar(15)", nullable: true),
                    Res_Area = table.Column<string>(type: "varchar(15)", nullable: true),
                    Res_Address = table.Column<string>(type: "varchar(50)", nullable: true),
                    Res_Email = table.Column<string>(type: "varchar(15)", nullable: true),
                    Res_Contact = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant_Details", x => x.Res_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Role_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Role_Id);
                });

            migrationBuilder.CreateTable(
                name: "Order_Masters",
                columns: table => new
                {
                    Order_No = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Book_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Party_Size = table.Column<int>(type: "int", nullable: false),
                    Start_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order_Status = table.Column<string>(type: "varchar(15)", nullable: true),
                    Cus_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Masters", x => x.Order_No);
                    table.ForeignKey(
                        name: "FK_Order_Masters_Customers_Cus_Id",
                        column: x => x.Cus_Id,
                        principalTable: "Customers",
                        principalColumn: "Cust_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Dis_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dis_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dis_Type_Id = table.Column<int>(type: "int", nullable: false),
                    From_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    From_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discount_Value = table.Column<double>(type: "float", nullable: false),
                    Min_Purchase = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Dis_Id);
                    table.ForeignKey(
                        name: "FK_Discounts_Discount_Types_Dis_Type_Id",
                        column: x => x.Dis_Type_Id,
                        principalTable: "Discount_Types",
                        principalColumn: "Dis_Type_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Table_No = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Table_Name = table.Column<string>(type: "varchar(15)", nullable: true),
                    seat = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<string>(type: "varchar(10)", nullable: true),
                    Occupied = table.Column<int>(type: "int", nullable: false),
                    Loc_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Table_No);
                    table.ForeignKey(
                        name: "FK_Tables_Locations_Loc_Id",
                        column: x => x.Loc_Id,
                        principalTable: "Locations",
                        principalColumn: "Loc_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Id = table.Column<int>(type: "int", nullable: false),
                    Emp_Name = table.Column<string>(type: "varchar (15)", nullable: true),
                    Emp_Email = table.Column<string>(type: "varchar (25)", nullable: true),
                    Emp_Password = table.Column<string>(type: "varchar (15)", nullable: true),
                    Emp_contact = table.Column<string>(type: "varchar (15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Emp_Id);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "Roles",
                        principalColumn: "Role_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deal_Masters",
                columns: table => new
                {
                    Deal_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deal_Name = table.Column<string>(type: "varchar(15)", nullable: true),
                    Deal_Desc = table.Column<string>(type: "varchar(50)", nullable: true),
                    Price_current = table.Column<double>(type: "float", nullable: false),
                    Person_Serve = table.Column<int>(type: "int", nullable: false),
                    Dis_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal_Masters", x => x.Deal_Id);
                    table.ForeignKey(
                        name: "FK_Deal_Masters_Discounts_Dis_Id",
                        column: x => x.Dis_Id,
                        principalTable: "Discounts",
                        principalColumn: "Dis_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Food_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Food_Name = table.Column<string>(type: "varchar(15)", nullable: true),
                    Food_Desc = table.Column<string>(type: "varchar(50)", nullable: true),
                    Price_current = table.Column<double>(type: "float", nullable: false),
                    Person_Serve = table.Column<int>(type: "int", nullable: false),
                    UOM_Id = table.Column<int>(type: "int", nullable: false),
                    Cat_Id = table.Column<int>(type: "int", nullable: false),
                    Dis_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Food_Id);
                    table.ForeignKey(
                        name: "FK_Foods_Discounts_Dis_Id",
                        column: x => x.Dis_Id,
                        principalTable: "Discounts",
                        principalColumn: "Dis_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Food_Categories_Cat_Id",
                        column: x => x.Cat_Id,
                        principalTable: "Food_Categories",
                        principalColumn: "Cat_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Measurement_Units_UOM_Id",
                        column: x => x.UOM_Id,
                        principalTable: "Measurement_Units",
                        principalColumn: "UOM_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Receipt_No = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_No = table.Column<int>(type: "int", nullable: false),
                    Pay_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pay_Type_Id = table.Column<int>(type: "int", nullable: false),
                    Dis_Id = table.Column<int>(type: "int", nullable: false),
                    Dis_Amount = table.Column<double>(type: "float", nullable: false),
                    Ammount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Receipt_No);
                    table.ForeignKey(
                        name: "FK_Payments_Discounts_Dis_Id",
                        column: x => x.Dis_Id,
                        principalTable: "Discounts",
                        principalColumn: "Dis_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Order_Masters_Order_No",
                        column: x => x.Order_No,
                        principalTable: "Order_Masters",
                        principalColumn: "Order_No",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Payment_Types_Pay_Type_Id",
                        column: x => x.Pay_Type_Id,
                        principalTable: "Payment_Types",
                        principalColumn: "Pay_Type_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Tables",
                columns: table => new
                {
                    Order_No = table.Column<int>(type: "int", nullable: false),
                    Table_No = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Tables", x => new { x.Order_No, x.Table_No });
                    table.ForeignKey(
                        name: "FK_Order_Tables_Order_Masters_Order_No",
                        column: x => x.Order_No,
                        principalTable: "Order_Masters",
                        principalColumn: "Order_No",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Tables_Tables_Table_No",
                        column: x => x.Table_No,
                        principalTable: "Tables",
                        principalColumn: "Table_No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Deal_Details",
                columns: table => new
                {
                    Order_No = table.Column<int>(type: "int", nullable: false),
                    Deal_Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Deal_Details", x => new { x.Order_No, x.Deal_Id });
                    table.ForeignKey(
                        name: "FK_Order_Deal_Details_Deal_Masters_Deal_Id",
                        column: x => x.Deal_Id,
                        principalTable: "Deal_Masters",
                        principalColumn: "Deal_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Deal_Details_Order_Masters_Order_No",
                        column: x => x.Order_No,
                        principalTable: "Order_Masters",
                        principalColumn: "Order_No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deal_Details",
                columns: table => new
                {
                    Deal_Id = table.Column<int>(type: "int", nullable: false),
                    Food_Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UOM_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal_Details", x => new { x.Deal_Id, x.Food_Id });
                    table.ForeignKey(
                        name: "FK_Deal_Details_Deal_Masters_Deal_Id",
                        column: x => x.Deal_Id,
                        principalTable: "Deal_Masters",
                        principalColumn: "Deal_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deal_Details_Foods_Food_Id",
                        column: x => x.Food_Id,
                        principalTable: "Foods",
                        principalColumn: "Food_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deal_Details_Measurement_Units_UOM_Id",
                        column: x => x.UOM_Id,
                        principalTable: "Measurement_Units",
                        principalColumn: "UOM_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Image_Url = table.Column<byte[]>(type: "varbinary(900)", nullable: false),
                    Food_Id = table.Column<int>(type: "int", nullable: false),
                    Deal_Id = table.Column<int>(type: "int", nullable: false),
                    Loc_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Image_Url);
                    table.ForeignKey(
                        name: "FK_Images_Deal_Masters_Deal_Id",
                        column: x => x.Deal_Id,
                        principalTable: "Deal_Masters",
                        principalColumn: "Deal_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_Foods_Food_Id",
                        column: x => x.Food_Id,
                        principalTable: "Foods",
                        principalColumn: "Food_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_Locations_Loc_Id",
                        column: x => x.Loc_Id,
                        principalTable: "Locations",
                        principalColumn: "Loc_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Food_Details",
                columns: table => new
                {
                    Order_No = table.Column<int>(type: "int", nullable: false),
                    Food_Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Food_Details", x => new { x.Order_No, x.Food_Id });
                    table.ForeignKey(
                        name: "FK_Order_Food_Details_Foods_Food_Id",
                        column: x => x.Food_Id,
                        principalTable: "Foods",
                        principalColumn: "Food_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Food_Details_Order_Masters_Order_No",
                        column: x => x.Order_No,
                        principalTable: "Order_Masters",
                        principalColumn: "Order_No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Order_No = table.Column<int>(type: "int", nullable: false),
                    Food_Id = table.Column<int>(type: "int", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => new { x.Order_No, x.Food_Id });
                    table.ForeignKey(
                        name: "FK_Ratings_Foods_Food_Id",
                        column: x => x.Food_Id,
                        principalTable: "Foods",
                        principalColumn: "Food_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Order_Masters_Order_No",
                        column: x => x.Order_No,
                        principalTable: "Order_Masters",
                        principalColumn: "Order_No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deal_Details_Food_Id",
                table: "Deal_Details",
                column: "Food_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_Details_UOM_Id",
                table: "Deal_Details",
                column: "UOM_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_Masters_Dis_Id",
                table: "Deal_Masters",
                column: "Dis_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_Dis_Type_Id",
                table: "Discounts",
                column: "Dis_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Role_Id",
                table: "Employees",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Cat_Id",
                table: "Foods",
                column: "Cat_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Dis_Id",
                table: "Foods",
                column: "Dis_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UOM_Id",
                table: "Foods",
                column: "UOM_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Deal_Id",
                table: "Images",
                column: "Deal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Food_Id",
                table: "Images",
                column: "Food_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Loc_Id",
                table: "Images",
                column: "Loc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Deal_Details_Deal_Id",
                table: "Order_Deal_Details",
                column: "Deal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Food_Details_Food_Id",
                table: "Order_Food_Details",
                column: "Food_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Masters_Cus_Id",
                table: "Order_Masters",
                column: "Cus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Tables_Table_No",
                table: "Order_Tables",
                column: "Table_No");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Dis_Id",
                table: "Payments",
                column: "Dis_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Order_No",
                table: "Payments",
                column: "Order_No");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Pay_Type_Id",
                table: "Payments",
                column: "Pay_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_Food_Id",
                table: "Ratings",
                column: "Food_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_Loc_Id",
                table: "Tables",
                column: "Loc_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deal_Details");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Opening_Hours");

            migrationBuilder.DropTable(
                name: "Order_Deal_Details");

            migrationBuilder.DropTable(
                name: "Order_Food_Details");

            migrationBuilder.DropTable(
                name: "Order_Tables");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Restaurant_Details");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Deal_Masters");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Payment_Types");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Order_Masters");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Food_Categories");

            migrationBuilder.DropTable(
                name: "Measurement_Units");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Discount_Types");
        }
    }
}
