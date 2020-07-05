using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "KookBaz");

            migrationBuilder.CreateTable(
                name: "ContactTypes",
                schema: "KookBaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    Value = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                schema: "KookBaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    BirthDate_Ds = table.Column<string>(nullable: true),
                    BirthDate_Dm = table.Column<string>(nullable: true),
                    LastLoginDate = table.Column<DateTimeOffset>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Cell = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                schema: "KookBaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    Value = table.Column<string>(maxLength: 100, nullable: false),
                    ContactType_Id = table.Column<int>(nullable: false),
                    Persion_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_ContactTypes_ContactType_Id",
                        column: x => x.ContactType_Id,
                        principalSchema: "KookBaz",
                        principalTable: "ContactTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_People_Persion_Id",
                        column: x => x.Persion_Id,
                        principalSchema: "KookBaz",
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "KookBaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    Receiver_Id = table.Column<int>(nullable: true),
                    SenderId = table.Column<int>(nullable: true),
                    Sender_Id = table.Column<int>(nullable: true),
                    Provider_code = table.Column<string>(nullable: true),
                    Payment_type = table.Column<int>(nullable: false),
                    Receiver_comment = table.Column<string>(nullable: true),
                    Pickup_date_Dm = table.Column<DateTime>(nullable: false),
                    Pickup_date_Ds = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Option_id = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Order_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_People_Receiver_Id",
                        column: x => x.Receiver_Id,
                        principalSchema: "KookBaz",
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_People_SenderId",
                        column: x => x.SenderId,
                        principalSchema: "KookBaz",
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                schema: "KookBaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    Order_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parcels_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalSchema: "KookBaz",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactType_Id",
                schema: "KookBaz",
                table: "Contacts",
                column: "ContactType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Persion_Id",
                schema: "KookBaz",
                table: "Contacts",
                column: "Persion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Receiver_Id",
                schema: "KookBaz",
                table: "Orders",
                column: "Receiver_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SenderId",
                schema: "KookBaz",
                table: "Orders",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_Order_Id",
                schema: "KookBaz",
                table: "Parcels",
                column: "Order_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts",
                schema: "KookBaz");

            migrationBuilder.DropTable(
                name: "Parcels",
                schema: "KookBaz");

            migrationBuilder.DropTable(
                name: "ContactTypes",
                schema: "KookBaz");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "KookBaz");

            migrationBuilder.DropTable(
                name: "People",
                schema: "KookBaz");
        }
    }
}
