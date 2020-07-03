using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    ShipingAmount = table.Column<decimal>(nullable: false),
                    MinShipingAmountForFree = table.Column<decimal>(nullable: false),
                    IsNeedAddress = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
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
                name: "ShopingBagItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    OrderDetailId = table.Column<int>(nullable: true),
                    OrderDetail_Id = table.Column<int>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    MaxCount = table.Column<int>(nullable: false),
                    ObjectId = table.Column<int>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    AllowCountGiftUseUser = table.Column<int>(nullable: false),
                    GiftId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopingBagItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopingBagItems_OrderDetails_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ContactTypeId = table.Column<int>(nullable: true),
                    ContactType_Id = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: true),
                    Persion_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_ContactTypes_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "ContactTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Dm = table.Column<DateTime>(nullable: false),
                    Create_Ds = table.Column<string>(nullable: true),
                    LastUpdate_Dm = table.Column<DateTime>(nullable: true),
                    LastUpdate_Ds = table.Column<string>(nullable: true),
                    SenderId = table.Column<int>(nullable: true),
                    Sender_Id = table.Column<int>(nullable: true),
                    Provider_code = table.Column<string>(nullable: true),
                    Payment_type = table.Column<int>(nullable: false),
                    Receiver_comment = table.Column<string>(nullable: true),
                    Pickup_date_Dm = table.Column<DateTime>(nullable: false),
                    Pickup_date_Ds = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Option_id = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_People_SenderId",
                        column: x => x.SenderId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
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
                    OrderId = table.Column<int>(nullable: true),
                    Order_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parcels_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactTypeId",
                table: "Contacts",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PersonId",
                table: "Contacts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SenderId",
                table: "Orders",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcels_OrderId",
                table: "Parcels",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopingBagItems_OrderDetailId",
                table: "ShopingBagItems",
                column: "OrderDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "ShopingBagItems");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
