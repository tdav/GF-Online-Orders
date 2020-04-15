using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace UniPos.Models.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sp_access_lists",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_access_lists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_countries",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_drug_categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drug_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_languages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_order_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_order_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_payments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_pharm_groups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_pharm_groups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_regions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_roles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    user_access = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_units",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    impartible = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_units", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_user_agents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_user_agents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_images",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    main_id = table.Column<int>(nullable: false),
                    file_name = table.Column<string>(nullable: true),
                    data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_images", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_product_headers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    summa = table.Column<decimal>(nullable: false),
                    item_qty = table.Column<int>(nullable: false),
                    document_no = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_product_headers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_setups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_setups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_manufacturers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    country_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_manufacturers", x => x.id);
                    table.ForeignKey(
                        name: "fk_sp_manufacturers_sp_countries_country_id",
                        column: x => x.country_id,
                        principalTable: "sp_countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sp_districts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    region_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_districts", x => x.id);
                    table.ForeignKey(
                        name: "fk_sp_districts_sp_regions_region_id",
                        column: x => x.region_id,
                        principalTable: "sp_regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_user",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    first_name = table.Column<string>(maxLength: 100, nullable: true),
                    last_name = table.Column<string>(maxLength: 100, nullable: true),
                    username = table.Column<string>(maxLength: 20, nullable: false),
                    password = table.Column<string>(maxLength: 100, nullable: false),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    role_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_user", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_user_sp_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "sp_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sp_drugs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    barcode = table.Column<string>(maxLength: 255, nullable: true),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    description = table.Column<string>(maxLength: 255, nullable: false),
                    international_name = table.Column<string>(maxLength: 255, nullable: true),
                    dose = table.Column<string>(maxLength: 255, nullable: true),
                    manufacturer_id = table.Column<int>(nullable: true),
                    drug_category_id = table.Column<int>(nullable: true),
                    pharm_group_id = table.Column<int>(nullable: true),
                    piece = table.Column<int>(nullable: false),
                    unit_id = table.Column<Guid>(nullable: false),
                    unit_id1 = table.Column<int>(nullable: true),
                    special = table.Column<int>(nullable: true),
                    photo = table.Column<string>(maxLength: 255, nullable: true),
                    vat_rate = table.Column<decimal>(nullable: false),
                    drug_recomendation = table.Column<string>(maxLength: 2000, nullable: true),
                    real_id = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drugs", x => x.id);
                    table.ForeignKey(
                        name: "fk_sp_drugs_sp_drug_categories_drug_category_id",
                        column: x => x.drug_category_id,
                        principalTable: "sp_drug_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sp_drugs_sp_manufacturers_manufacturer_id",
                        column: x => x.manufacturer_id,
                        principalTable: "sp_manufacturers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sp_drugs_sp_pharm_groups_pharm_group_id",
                        column: x => x.pharm_group_id,
                        principalTable: "sp_pharm_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sp_drugs_sp_units_unit_id1",
                        column: x => x.unit_id1,
                        principalTable: "sp_units",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sp_drug_stores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    phone = table.Column<string>(maxLength: 200, nullable: true),
                    region_id = table.Column<int>(nullable: false),
                    district_id = table.Column<int>(nullable: false),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    latitude = table.Column<decimal>(nullable: false),
                    longitude = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drug_stores", x => x.id);
                    table.ForeignKey(
                        name: "fk_sp_drug_stores_sp_districts_district_id",
                        column: x => x.district_id,
                        principalTable: "sp_districts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sp_drug_stores_sp_regions_region_id",
                        column: x => x.region_id,
                        principalTable: "sp_regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_product_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    product_header_id = table.Column<int>(nullable: false),
                    drug_id = table.Column<int>(nullable: false),
                    series_no = table.Column<string>(maxLength: 50, nullable: true),
                    qty = table.Column<int>(nullable: false),
                    cur_qty = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(nullable: false),
                    vat = table.Column<decimal>(nullable: false),
                    expiry_date = table.Column<DateTime>(nullable: false),
                    base_price = table.Column<decimal>(nullable: true),
                    incoming_price = table.Column<decimal>(nullable: false),
                    extra_charge = table.Column<decimal>(nullable: false),
                    total_amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_product_details", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_product_details_sp_drugs_drug_id",
                        column: x => x.drug_id,
                        principalTable: "sp_drugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_product_details_tb_product_headers_product_header_id",
                        column: x => x.product_header_id,
                        principalTable: "tb_product_headers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_orders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    drug_store_id = table.Column<int>(nullable: false),
                    region_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    address = table.Column<string>(maxLength: 500, nullable: true),
                    latitude = table.Column<decimal>(nullable: false),
                    longitude = table.Column<decimal>(nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    delivery_time = table.Column<DateTime>(nullable: false),
                    order_status_id = table.Column<int>(nullable: false),
                    payment_id = table.Column<int>(nullable: false),
                    user_agent_id = table.Column<int>(nullable: false),
                    item_qty = table.Column<int>(nullable: false),
                    summa = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_orders", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_orders_sp_drug_stores_drug_store_id",
                        column: x => x.drug_store_id,
                        principalTable: "sp_drug_stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_orders_sp_order_status_order_status_id",
                        column: x => x.order_status_id,
                        principalTable: "sp_order_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_orders_sp_payments_payment_id",
                        column: x => x.payment_id,
                        principalTable: "sp_payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_orders_sp_user_agents_user_agent_id",
                        column: x => x.user_agent_id,
                        principalTable: "sp_user_agents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_order_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    qty = table.Column<int>(nullable: false),
                    drug_id = table.Column<int>(nullable: false),
                    tb_order_header_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_order_details", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_order_details_sp_drugs_drug_id",
                        column: x => x.drug_id,
                        principalTable: "sp_drugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tb_order_details_tb_orders_tb_order_header_id",
                        column: x => x.tb_order_header_id,
                        principalTable: "tb_orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_sp_access_lists_create_user",
                table: "sp_access_lists",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_access_lists_status",
                table: "sp_access_lists",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_countries_create_user",
                table: "sp_countries",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_countries_status",
                table: "sp_countries",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_districts_create_user",
                table: "sp_districts",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_districts_region_id",
                table: "sp_districts",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_districts_status",
                table: "sp_districts",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drug_categories_create_user",
                table: "sp_drug_categories",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drug_categories_status",
                table: "sp_drug_categories",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drug_stores_create_user",
                table: "sp_drug_stores",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drug_stores_district_id",
                table: "sp_drug_stores",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drug_stores_region_id",
                table: "sp_drug_stores",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drug_stores_status",
                table: "sp_drug_stores",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drugs_create_user",
                table: "sp_drugs",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drugs_description",
                table: "sp_drugs",
                column: "description");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drugs_drug_category_id",
                table: "sp_drugs",
                column: "drug_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drugs_manufacturer_id",
                table: "sp_drugs",
                column: "manufacturer_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drugs_pharm_group_id",
                table: "sp_drugs",
                column: "pharm_group_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drugs_status",
                table: "sp_drugs",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drugs_unit_id1",
                table: "sp_drugs",
                column: "unit_id1");

            migrationBuilder.CreateIndex(
                name: "ix_sp_languages_create_user",
                table: "sp_languages",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_languages_status",
                table: "sp_languages",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_manufacturers_country_id",
                table: "sp_manufacturers",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_manufacturers_create_user",
                table: "sp_manufacturers",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_manufacturers_name",
                table: "sp_manufacturers",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "ix_sp_manufacturers_status",
                table: "sp_manufacturers",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_order_status_create_user",
                table: "sp_order_status",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_order_status_status",
                table: "sp_order_status",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_payments_create_user",
                table: "sp_payments",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_payments_status",
                table: "sp_payments",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_pharm_groups_create_user",
                table: "sp_pharm_groups",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_pharm_groups_status",
                table: "sp_pharm_groups",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_regions_create_user",
                table: "sp_regions",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_regions_status",
                table: "sp_regions",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_roles_create_user",
                table: "sp_roles",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_roles_status",
                table: "sp_roles",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_units_create_user",
                table: "sp_units",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_units_status",
                table: "sp_units",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_sp_user_agents_create_user",
                table: "sp_user_agents",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_user_agents_status",
                table: "sp_user_agents",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_tb_images_create_user",
                table: "tb_images",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_images_status",
                table: "tb_images",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_tb_order_details_create_user",
                table: "tb_order_details",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_order_details_drug_id",
                table: "tb_order_details",
                column: "drug_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_order_details_status",
                table: "tb_order_details",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_tb_order_details_tb_order_header_id",
                table: "tb_order_details",
                column: "tb_order_header_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_create_user",
                table: "tb_orders",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_drug_store_id",
                table: "tb_orders",
                column: "drug_store_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_order_status_id",
                table: "tb_orders",
                column: "order_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_payment_id",
                table: "tb_orders",
                column: "payment_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_status",
                table: "tb_orders",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_user_agent_id",
                table: "tb_orders",
                column: "user_agent_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_details_create_user",
                table: "tb_product_details",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_details_cur_qty",
                table: "tb_product_details",
                column: "cur_qty");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_details_drug_id",
                table: "tb_product_details",
                column: "drug_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_details_expiry_date",
                table: "tb_product_details",
                column: "expiry_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_details_product_header_id",
                table: "tb_product_details",
                column: "product_header_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_details_status",
                table: "tb_product_details",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_headers_create_user",
                table: "tb_product_headers",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_headers_status",
                table: "tb_product_headers",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_tb_setups_create_user",
                table: "tb_setups",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_setups_status",
                table: "tb_setups",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "ix_tb_user_create_user",
                table: "tb_user",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_user_role_id",
                table: "tb_user",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_user_status",
                table: "tb_user",
                column: "status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sp_access_lists");

            migrationBuilder.DropTable(
                name: "sp_languages");

            migrationBuilder.DropTable(
                name: "tb_images");

            migrationBuilder.DropTable(
                name: "tb_order_details");

            migrationBuilder.DropTable(
                name: "tb_product_details");

            migrationBuilder.DropTable(
                name: "tb_setups");

            migrationBuilder.DropTable(
                name: "tb_user");

            migrationBuilder.DropTable(
                name: "tb_orders");

            migrationBuilder.DropTable(
                name: "sp_drugs");

            migrationBuilder.DropTable(
                name: "tb_product_headers");

            migrationBuilder.DropTable(
                name: "sp_roles");

            migrationBuilder.DropTable(
                name: "sp_drug_stores");

            migrationBuilder.DropTable(
                name: "sp_order_status");

            migrationBuilder.DropTable(
                name: "sp_payments");

            migrationBuilder.DropTable(
                name: "sp_user_agents");

            migrationBuilder.DropTable(
                name: "sp_drug_categories");

            migrationBuilder.DropTable(
                name: "sp_manufacturers");

            migrationBuilder.DropTable(
                name: "sp_pharm_groups");

            migrationBuilder.DropTable(
                name: "sp_units");

            migrationBuilder.DropTable(
                name: "sp_districts");

            migrationBuilder.DropTable(
                name: "sp_countries");

            migrationBuilder.DropTable(
                name: "sp_regions");
        }
    }
}
