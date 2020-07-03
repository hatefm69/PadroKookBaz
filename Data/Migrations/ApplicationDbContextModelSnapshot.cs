﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNeedAddress")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdate_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdate_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MinShipingAmountForFree")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ShipingAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Entities.Padro.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ContactType_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdate_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdate_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Persion_Id")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entities.Padro.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdate_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdate_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactTypes");
                });

            modelBuilder.Entity("Entities.Padro.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdate_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdate_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Option_id")
                        .HasColumnType("int");

                    b.Property<int>("Payment_type")
                        .HasColumnType("int");

                    b.Property<DateTime>("Pickup_date_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pickup_date_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Receiver_comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.Property<int?>("Sender_Id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Entities.Padro.Parcel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdate_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdate_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Parcels");
                });

            modelBuilder.Entity("Entities.Padro.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate_Dm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthDate_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastLoginDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdate_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdate_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Entities.ShopingBagItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AllowCountGiftUseUser")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Create_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GiftId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdate_Dm")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdate_Ds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjectId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("OrderDetail_Id")
                        .HasColumnType("int");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderDetailId");

                    b.ToTable("ShopingBagItems");
                });

            modelBuilder.Entity("Entities.Padro.Contact", b =>
                {
                    b.HasOne("Entities.Padro.ContactType", "ContactType")
                        .WithMany("Contacts")
                        .HasForeignKey("ContactTypeId");

                    b.HasOne("Entities.Padro.Person", "Person")
                        .WithMany("Contacts")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Entities.Padro.Order", b =>
                {
                    b.HasOne("Entities.Padro.Person", "Sender")
                        .WithMany("Orders")
                        .HasForeignKey("SenderId");
                });

            modelBuilder.Entity("Entities.Padro.Parcel", b =>
                {
                    b.HasOne("Entities.Padro.Order", "Order")
                        .WithMany("Parcels")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Entities.ShopingBagItem", b =>
                {
                    b.HasOne("Entities.OrderDetail", "OrderDetail")
                        .WithMany("Items")
                        .HasForeignKey("OrderDetailId");
                });
#pragma warning restore 612, 618
        }
    }
}
