using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Apteka.Postgres.Migrations
{
    public partial class t1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sp_access_lists",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
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
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_discount_types",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    dp_info = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_discount_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_distributors",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    organization_name = table.Column<string>(maxLength: 200, nullable: false),
                    person_name = table.Column<string>(maxLength: 200, nullable: true),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    inn = table.Column<string>(maxLength: 100, nullable: true),
                    mfo = table.Column<string>(maxLength: 100, nullable: true),
                    okonh = table.Column<string>(maxLength: 100, nullable: true),
                    bank_name = table.Column<string>(maxLength: 200, nullable: true),
                    settlement_account = table.Column<string>(maxLength: 200, nullable: true),
                    region_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    location = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_distributors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_drug_additional_infoes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drug_additional_infoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_drug_categories",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drug_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_drug_recomendations",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    server_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drug_recomendations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_insurances",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    dp_info = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_insurances", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_online_payments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_online_payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_operation_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_operation_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_order_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_order_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_pharm_groups",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
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
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_roles",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    user_access = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_table_infoes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    version = table.Column<long>(nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    json = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_table_infoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_type_of_payments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_type_of_payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_units",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    impartible = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_units", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_buy_on_credits",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    cur_credit_summa = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    credit_summa = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    customer_id = table.Column<Guid>(nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false),
                    doc_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_buy_on_credits", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_change_histories",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    entity_id = table.Column<Guid>(nullable: false),
                    dp_info = table.Column<string>(maxLength: 500, nullable: true),
                    operation_type_id = table.Column<int>(nullable: false),
                    piece = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    qty_old = table.Column<int>(nullable: false),
                    price_old = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    qty_change = table.Column<int>(nullable: false),
                    price_change = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    qty_cur = table.Column<int>(nullable: false),
                    price_cur = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_change_histories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_customers",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    phone = table.Column<string>(maxLength: 100, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    surname = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    name = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    patronymic = table.Column<string>(maxLength: 200, nullable: true),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_inventories",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    drug_store_id = table.Column<Guid>(nullable: false),
                    dp_info = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_inventories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_inventory_current_lists",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    expiry_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    incoming_price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    cur_qty = table.Column<int>(nullable: false),
                    document_id = table.Column<Guid>(nullable: false),
                    operation_type_id = table.Column<int>(nullable: false),
                    drug_name = table.Column<string>(nullable: true),
                    barcode = table.Column<string>(nullable: true),
                    piece = table.Column<int>(nullable: false),
                    manufacturer_id = table.Column<Guid>(nullable: true),
                    drug_id = table.Column<Guid>(nullable: false),
                    unit_id = table.Column<Guid>(nullable: true),
                    manufacture = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    unit = table.Column<string>(nullable: true),
                    drug_category = table.Column<string>(nullable: true),
                    fact_qty = table.Column<int>(nullable: false),
                    nedastach_qty = table.Column<int>(nullable: false),
                    izlishk_qty = table.Column<int>(nullable: false),
                    kassa_fact_qty = table.Column<int>(nullable: false),
                    kassa_change = table.Column<int>(nullable: false),
                    inventory_doc_id = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_inventory_current_lists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_log",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    txt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_log", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_losses",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    descriptin = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_losses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_monitor_syncs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    table_name = table.Column<string>(nullable: true),
                    client_ip = table.Column<string>(nullable: true),
                    client_mac = table.Column<string>(nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    ins_count = table.Column<int>(nullable: false),
                    upd_count = table.Column<int>(nullable: false),
                    send_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_monitor_syncs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_online_pay_systems",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    doc_id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    online_payment_id = table.Column<int>(nullable: false),
                    pay_summa = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    dp_info = table.Column<string>(maxLength: 100, nullable: true),
                    drug_store_id = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_online_pay_systems", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_orders",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    delivery_time = table.Column<DateTime>(type: "timestamp", nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_return_of_products",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    coming_product_id = table.Column<Guid>(nullable: true),
                    qty = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_return_of_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_revaluation_of_drugs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    coming_product_id = table.Column<Guid>(nullable: true),
                    cur_qty = table.Column<int>(nullable: false),
                    incoming_price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    extra_charge = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    old_price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    new_extra_charge = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    new_price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_revaluation_of_drugs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_setups",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    json_global_system_config = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_setups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_smenas",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false),
                    begin = table.Column<DateTime>(type: "timestamp", nullable: false),
                    end = table.Column<DateTime>(type: "timestamp", nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    dp_info = table.Column<string>(nullable: true),
                    payment_by_card = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    payment_by_cash = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    expenses = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_smenas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_write_offs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    coming_product_id = table.Column<Guid>(nullable: true),
                    cur_qty = table.Column<int>(nullable: false),
                    write_off_qty = table.Column<int>(nullable: false),
                    comment = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_write_offs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_manufacturers",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    country_id = table.Column<int>(nullable: false),
                    real_id = table.Column<Guid>(nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_manufacturers", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.spManufacturers_dbo.spCountries_CountryId",
                        column: x => x.country_id,
                        principalTable: "sp_countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_discounts",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    value = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    validity_to = table.Column<DateTime>(type: "timestamp", nullable: false),
                    discount_type_id = table.Column<Guid>(nullable: false),
                    dp_info = table.Column<string>(maxLength: 200, nullable: true),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_discounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbDiscounts_dbo.spDiscountTypes_DiscountTypeId",
                        column: x => x.discount_type_id,
                        principalTable: "sp_discount_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_price_docs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    distributor_id = table.Column<Guid>(nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: false),
                    price_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_price_docs", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbPriceDocs_dbo.spDistributors_DistributorId",
                        column: x => x.distributor_id,
                        principalTable: "sp_distributors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_drug_additional_infoes",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    info_type_id = table.Column<int>(nullable: false),
                    data = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_drug_additional_infoes", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbDrugAdditionalInfoes_dbo.spDrugAdditionalInfoes_InfoTypeId",
                        column: x => x.info_type_id,
                        principalTable: "sp_drug_additional_infoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_medical_insurances",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    doc_id = table.Column<Guid>(nullable: false),
                    insurance_id = table.Column<Guid>(nullable: false),
                    surname = table.Column<string>(maxLength: 200, nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    patronymic = table.Column<string>(maxLength: 200, nullable: true),
                    insurance_category = table.Column<string>(maxLength: 200, nullable: true),
                    drug_store_id = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_medical_insurances", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbMedicalInsurances_dbo.spInsurances_InsuranceId",
                        column: x => x.insurance_id,
                        principalTable: "sp_insurances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sp_districts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    region_id = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_districts", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.spDistricts_dbo.spRegions_RegionId",
                        column: x => x.region_id,
                        principalTable: "sp_regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_users",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    last_name = table.Column<string>(maxLength: 100, nullable: false),
                    first_name = table.Column<string>(maxLength: 100, nullable: false),
                    father_name = table.Column<string>(maxLength: 100, nullable: false),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    login = table.Column<string>(maxLength: 100, nullable: false),
                    password = table.Column<string>(maxLength: 200, nullable: false),
                    role_id = table.Column<Guid>(nullable: false),
                    card_number = table.Column<string>(maxLength: 10, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbUsers_dbo.spRoles_RoleId",
                        column: x => x.role_id,
                        principalTable: "sp_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_order_items",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    order_id = table.Column<Guid>(nullable: false),
                    drug_name = table.Column<string>(maxLength: 200, nullable: false),
                    qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_order_items", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbOrderItems_dbo.tbOrders_OrderId",
                        column: x => x.order_id,
                        principalTable: "tb_orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sp_drugs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    barcode = table.Column<string>(maxLength: 255, nullable: true),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    description = table.Column<string>(maxLength: 255, nullable: false),
                    international_name = table.Column<string>(maxLength: 255, nullable: true),
                    dose = table.Column<string>(maxLength: 255, nullable: true),
                    manufacturer_id = table.Column<Guid>(nullable: true),
                    drug_category_id = table.Column<Guid>(nullable: true),
                    pharm_group_id = table.Column<Guid>(nullable: true),
                    piece = table.Column<int>(nullable: false),
                    unit_id = table.Column<Guid>(nullable: false),
                    special = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    photo = table.Column<string>(maxLength: 255, nullable: true),
                    vat_rate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    drug_recomendation = table.Column<string>(maxLength: 2000, nullable: true),
                    real_id = table.Column<Guid>(nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drugs", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.spDrugs_dbo.spDrugCategories_DrugCategoryId",
                        column: x => x.drug_category_id,
                        principalTable: "sp_drug_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.spDrugs_dbo.spManufacturers_ManufacturerId",
                        column: x => x.manufacturer_id,
                        principalTable: "sp_manufacturers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.spDrugs_dbo.spPharmGroups_PharmGroupId",
                        column: x => x.pharm_group_id,
                        principalTable: "sp_pharm_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.spDrugs_dbo.spUnits_UnitId",
                        column: x => x.unit_id,
                        principalTable: "sp_units",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_cards",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    card_no = table.Column<string>(maxLength: 200, nullable: false),
                    discount_id = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    customer_id = table.Column<Guid>(nullable: false),
                    dp_info = table.Column<string>(maxLength: 200, nullable: true),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_cards", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbCards_dbo.tbCustomers_CustomerId",
                        column: x => x.customer_id,
                        principalTable: "tb_customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbCards_dbo.tbDiscounts_DiscountId",
                        column: x => x.discount_id,
                        principalTable: "tb_discounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_docs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    total_drugs = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    document_no = table.Column<string>(maxLength: 20, nullable: true),
                    distributor_id = table.Column<Guid>(nullable: true),
                    payment_by_card = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    payment_by_cash = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    discount_percentage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    total_amount_without_discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    discount_id = table.Column<Guid>(nullable: true),
                    discriminator = table.Column<string>(maxLength: 128, nullable: false),
                    type_of_payments = table.Column<int>(nullable: true),
                    online_payments = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_docs", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbDocs_dbo.tbDiscounts_DiscountId",
                        column: x => x.discount_id,
                        principalTable: "tb_discounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbDocs_dbo.spDistributors_DistributorId",
                        column: x => x.distributor_id,
                        principalTable: "sp_distributors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_price_items",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    price_doc_id = table.Column<Guid>(nullable: false),
                    drug_id = table.Column<Guid>(nullable: false),
                    vendor_drug_name = table.Column<string>(maxLength: 200, nullable: false),
                    base_price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    extra_charge = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    piece = table.Column<int>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    vat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    rating = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, defaultValueSql: "((1))"),
                    series_no = table.Column<string>(maxLength: 50, nullable: true),
                    expiry_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    manufacturer_id = table.Column<Guid>(nullable: true),
                    vendor_manufacturer = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_price_items", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbPriceItems_dbo.tbPriceDocs_PriceDocId",
                        column: x => x.price_doc_id,
                        principalTable: "tb_price_docs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sp_drug_stores",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    phone = table.Column<string>(maxLength: 200, nullable: true),
                    fax = table.Column<string>(maxLength: 200, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    inn = table.Column<string>(maxLength: 100, nullable: true),
                    mfo = table.Column<string>(maxLength: 100, nullable: true),
                    okonh = table.Column<string>(maxLength: 100, nullable: true),
                    bank_name = table.Column<string>(maxLength: 200, nullable: true),
                    settlement_account = table.Column<string>(maxLength: 200, nullable: true),
                    region_id = table.Column<int>(nullable: false),
                    district_id = table.Column<int>(nullable: false),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    address_check = table.Column<string>(maxLength: 60, nullable: true),
                    extra_charge_default = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, defaultValueSql: "((5))"),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drug_stores", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.spDrugStores_dbo.spDistricts_DistrictId",
                        column: x => x.district_id,
                        principalTable: "sp_districts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.spDrugStores_dbo.spRegions_RegionId",
                        column: x => x.region_id,
                        principalTable: "sp_regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_cash_expenses",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    user_id = table.Column<Guid>(nullable: false),
                    dp_info = table.Column<string>(maxLength: 200, nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_cash_expenses", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbCashExpenses_dbo.tbUsers_UserId",
                        column: x => x.user_id,
                        principalTable: "tb_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_encashments",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    user_id = table.Column<Guid>(nullable: false),
                    dp_info = table.Column<string>(maxLength: 200, nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_encashments", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbEncashments_dbo.tbUsers_UserId",
                        column: x => x.user_id,
                        principalTable: "tb_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_defectures",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    order_status_id = table.Column<int>(nullable: true),
                    drug_store_id = table.Column<Guid>(nullable: false),
                    drug_id = table.Column<Guid>(nullable: false),
                    query_count = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_defectures", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbDefectures_dbo.spDrugs_DrugId",
                        column: x => x.drug_id,
                        principalTable: "sp_drugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbDefectures_dbo.spOrderStatus_OrderStatusId",
                        column: x => x.order_status_id,
                        principalTable: "sp_order_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_debt_repayments",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    summa = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    buy_on_credit_id = table.Column<Guid>(nullable: false),
                    cash_voucher_id = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_debt_repayments", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbDebtRepayments_dbo.tbBuyOnCredits_BuyOnCreditId",
                        column: x => x.buy_on_credit_id,
                        principalTable: "tb_buy_on_credits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbDebtRepayments_dbo.tbDocs_CashVoucherId",
                        column: x => x.cash_voucher_id,
                        principalTable: "tb_docs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_doc_items",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    document_id = table.Column<Guid>(nullable: false),
                    drug_id = table.Column<Guid>(nullable: false),
                    series_no = table.Column<string>(maxLength: 50, nullable: true),
                    qty = table.Column<int>(nullable: false),
                    cur_qty = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    vat = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    expiry_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    operation_type_id = table.Column<int>(nullable: false),
                    coming_product_id = table.Column<Guid>(nullable: true),
                    base_price = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    incoming_price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    extra_charge = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    total_amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    additional_info_id = table.Column<Guid>(nullable: true),
                    dp_info = table.Column<string>(maxLength: 200, nullable: true),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    row_version = table.Column<byte[]>(rowVersion: true, nullable: false),
                    discriminator = table.Column<string>(maxLength: 128, nullable: false),
                    booking_customer_name = table.Column<string>(nullable: true),
                    booking_time_to = table.Column<DateTime>(type: "timestamp", nullable: true),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_doc_items", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbDocItems_dbo.tbDrugAdditionalInfoes_AdditionalInfoId",
                        column: x => x.additional_info_id,
                        principalTable: "tb_drug_additional_infoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbDocItems_dbo.tbDocs_DocumentId",
                        column: x => x.document_id,
                        principalTable: "tb_docs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbDocItems_dbo.spDrugs_DrugId",
                        column: x => x.drug_id,
                        principalTable: "sp_drugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbDocItems_dbo.spOperationTypes_OperationTypeId",
                        column: x => x.operation_type_id,
                        principalTable: "sp_operation_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_receipts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    server_id = table.Column<int>(nullable: true),
                    docs_id = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_receipts", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbReceipts_dbo.tbDocs_DocsId",
                        column: x => x.docs_id,
                        principalTable: "tb_docs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_mandatory_drugs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    drug_id = table.Column<Guid>(nullable: false),
                    price_item_id = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_mandatory_drugs", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbMandatoryDrugs_dbo.spDrugs_DrugId",
                        column: x => x.drug_id,
                        principalTable: "sp_drugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbMandatoryDrugs_dbo.tbPriceItems_PriceItemId",
                        column: x => x.price_item_id,
                        principalTable: "tb_price_items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_turnovers",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    current_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    drug_id = table.Column<Guid>(nullable: false),
                    series_no = table.Column<string>(maxLength: 200, nullable: true),
                    drug_stor_id = table.Column<Guid>(nullable: false),
                    balance_start = table.Column<int>(nullable: false),
                    coming = table.Column<int>(nullable: false),
                    write_off = table.Column<int>(nullable: false),
                    sale = table.Column<int>(nullable: false),
                    back = table.Column<int>(nullable: false),
                    balance_end = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_turnovers", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbTurnovers_dbo.spDrugs_DrugId",
                        column: x => x.drug_id,
                        principalTable: "sp_drugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbTurnovers_dbo.spDrugStores_DrugStore_Id",
                        column: x => x.drug_store_id,
                        principalTable: "sp_drug_stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_inventory_items",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    inventoryt_id = table.Column<Guid>(nullable: false),
                    coming_products_item_id = table.Column<Guid>(nullable: false),
                    drug_id = table.Column<Guid>(nullable: false),
                    cur_qty = table.Column<int>(nullable: false),
                    fact_qty = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_inventory_items", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbInventoryItems_dbo.tbDocItems_ComingProductsItemId",
                        column: x => x.coming_products_item_id,
                        principalTable: "tb_doc_items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbInventoryItems_dbo.spDrugs_DrugId",
                        column: x => x.drug_id,
                        principalTable: "sp_drugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.tbInventoryItems_dbo.tbInventories_InventorytId",
                        column: x => x.inventoryt_id,
                        principalTable: "tb_inventories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_sdachis",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    server_id = table.Column<int>(nullable: true),
                    drug_id = table.Column<Guid>(nullable: false),
                    drug_store_id = table.Column<Guid>(nullable: false),
                    doc_item_id = table.Column<Guid>(nullable: false),
                    price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    create_date = table.Column<DateTime>(type: "timestamp", nullable: false),
                    update_date = table.Column<DateTime>(type: "timestamp", nullable: true),
                    create_user = table.Column<Guid>(nullable: false),
                    update_user = table.Column<Guid>(nullable: true),
                    send = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_sdachis", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbo.tbSdachis_dbo.tbDocItems_DocItemId",
                        column: x => x.doc_item_id,
                        principalTable: "tb_doc_items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            /*
            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_access_lists",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_access_lists",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_access_lists",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_countries",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_countries",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_countries",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_discount_types",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_discount_types",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_discount_types",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_distributors",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_distributors",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_distributors",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_districts",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_RegionId",
                table: "sp_districts",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_districts",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_districts",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_drug_additional_infoes",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_drug_additional_infoes",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_drug_additional_infoes",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_drug_categories",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_drug_categories",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_drug_categories",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_drug_recomendations",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_drug_recomendations",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_drug_recomendations",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_drug_stores",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DistrictId",
                table: "sp_drug_stores",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_RegionId",
                table: "sp_drug_stores",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_drug_stores",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_drug_stores",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_drugs",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Description",
                table: "sp_drugs",
                column: "description");

            migrationBuilder.CreateIndex(
                name: "IX_DrugCategoryId",
                table: "sp_drugs",
                column: "drug_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerId",
                table: "sp_drugs",
                column: "manufacturer_id");

            migrationBuilder.CreateIndex(
                name: "IX_PharmGroupId",
                table: "sp_drugs",
                column: "pharm_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_ServerId",
                table: "sp_drugs",
                column: "server_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_drugs",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UnitId",
                table: "sp_drugs",
                column: "unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_drugs",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_insurances",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_insurances",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_insurances",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CountryId",
                table: "sp_manufacturers",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_manufacturers",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Name",
                table: "sp_manufacturers",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_manufacturers",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_manufacturers",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_online_payments",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_online_payments",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_online_payments",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_operation_types",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_operation_types",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_operation_types",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_order_status",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_order_status",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_order_status",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_pharm_groups",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_pharm_groups",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_pharm_groups",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_regions",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_regions",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_regions",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_roles",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_roles",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_roles",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_status",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_status",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_status",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_type_of_payments",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_type_of_payments",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_type_of_payments",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "sp_units",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "sp_units",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "sp_units",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_buy_on_credits",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_buy_on_credits",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_buy_on_credits",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_cards",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerId",
                table: "tb_cards",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountId",
                table: "tb_cards",
                column: "discount_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_cards",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_cards",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_cash_expenses",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_cash_expenses",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_cash_expenses",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "tb_cash_expenses",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_change_histories",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_change_histories",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_change_histories",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_customers",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_customers",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_customers",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_BuyOnCreditId",
                table: "tb_debt_repayments",
                column: "buy_on_credit_id");

            migrationBuilder.CreateIndex(
                name: "IX_CashVoucherId",
                table: "tb_debt_repayments",
                column: "cash_voucher_id");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_debt_repayments",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_debt_repayments",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_debt_repayments",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_defectures",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DrugId",
                table: "tb_defectures",
                column: "drug_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatusId",
                table: "tb_defectures",
                column: "order_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_QueryCount",
                table: "tb_defectures",
                column: "query_count");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_defectures",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_defectures",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_discounts",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountTypeId",
                table: "tb_discounts",
                column: "discount_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_discounts",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_discounts",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInfoId",
                table: "tb_doc_items",
                column: "additional_info_id");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_doc_items",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_CurQty",
                table: "tb_doc_items",
                column: "cur_qty");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentId",
                table: "tb_doc_items",
                column: "document_id");

            migrationBuilder.CreateIndex(
                name: "IX_DrugId",
                table: "tb_doc_items",
                column: "drug_id");

            migrationBuilder.CreateIndex(
                name: "IX_ExpiryDate",
                table: "tb_doc_items",
                column: "expiry_date");

            migrationBuilder.CreateIndex(
                name: "IX_OperationTypeId",
                table: "tb_doc_items",
                column: "operation_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_doc_items",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_doc_items",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IDX_tbDocItems_OperationTypeId",
                table: "tb_doc_items",
                columns: new[] { "drug_id", "cur_qty", "operation_type_id" });

            migrationBuilder.CreateIndex(
                name: "IDX_tbDocItems",
                table: "tb_doc_items",
                columns: new[] { "drug_id", "operation_type_id", "create_date" });

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_docs",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountId",
                table: "tb_docs",
                column: "discount_id");

            migrationBuilder.CreateIndex(
                name: "IX_DistributorId",
                table: "tb_docs",
                column: "distributor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_docs",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_docs",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_drug_additional_infoes",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_InfoTypeId",
                table: "tb_drug_additional_infoes",
                column: "info_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_drug_additional_infoes",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_drug_additional_infoes",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_encashments",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_encashments",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_encashments",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "tb_encashments",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_inventories",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DpInfo",
                table: "tb_inventories",
                column: "dp_info");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_inventories",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_inventories",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_inventory_current_lists",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_inventory_current_lists",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_inventory_current_lists",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_ComingProductsItemId",
                table: "tb_inventory_items",
                column: "coming_products_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_inventory_items",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DrugId",
                table: "tb_inventory_items",
                column: "drug_id");

            migrationBuilder.CreateIndex(
                name: "IX_InventorytId",
                table: "tb_inventory_items",
                column: "inventoryt_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_inventory_items",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_inventory_items",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_losses",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_losses",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_losses",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_mandatory_drugs",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DrugId",
                table: "tb_mandatory_drugs",
                column: "drug_id");

            migrationBuilder.CreateIndex(
                name: "IX_PriceItemId",
                table: "tb_mandatory_drugs",
                column: "price_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_mandatory_drugs",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_mandatory_drugs",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_medical_insurances",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceId",
                table: "tb_medical_insurances",
                column: "insurance_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_medical_insurances",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_medical_insurances",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_online_pay_systems",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_online_pay_systems",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_online_pay_systems",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_order_items",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_OrderId",
                table: "tb_order_items",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_order_items",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_order_items",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_orders",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_orders",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_orders",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_price_docs",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DistributorId",
                table: "tb_price_docs",
                column: "distributor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_price_docs",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_price_docs",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_price_items",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_PriceDocId",
                table: "tb_price_items",
                column: "price_doc_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_price_items",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_price_items",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_receipts",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DocsId",
                table: "tb_receipts",
                column: "docs_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_receipts",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_receipts",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_return_of_products",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_return_of_products",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_return_of_products",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_revaluation_of_drugs",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_revaluation_of_drugs",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_revaluation_of_drugs",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_sdachis",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DocItemId",
                table: "tb_sdachis",
                column: "doc_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbSdachi",
                table: "tb_sdachis",
                column: "drug_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_sdachis",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_sdachis",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_setups",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_setups",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_setups",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_smenas",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_smenas",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_smenas",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_turnovers",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_DrugId",
                table: "tb_turnovers",
                column: "drug_id");

            migrationBuilder.CreateIndex(
                name: "IX_DrugStoreId",
                table: "tb_turnovers",
                column: "drug_store_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_turnovers",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_turnovers",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_users",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_RoleId",
                table: "tb_users",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_users",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_users",
                column: "update_date");

            migrationBuilder.CreateIndex(
                name: "IX_CreateDate",
                table: "tb_write_offs",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "IX_Status",
                table: "tb_write_offs",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateDate",
                table: "tb_write_offs",
                column: "update_date");
                */
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sp_access_lists");

            migrationBuilder.DropTable(
                name: "sp_drug_recomendations");

            migrationBuilder.DropTable(
                name: "sp_online_payments");

            migrationBuilder.DropTable(
                name: "sp_status");

            migrationBuilder.DropTable(
                name: "sp_table_infoes");

            migrationBuilder.DropTable(
                name: "sp_type_of_payments");

            migrationBuilder.DropTable(
                name: "tb_cards");

            migrationBuilder.DropTable(
                name: "tb_cash_expenses");

            migrationBuilder.DropTable(
                name: "tb_change_histories");

            migrationBuilder.DropTable(
                name: "tb_debt_repayments");

            migrationBuilder.DropTable(
                name: "tb_defectures");

            migrationBuilder.DropTable(
                name: "tb_encashments");

            migrationBuilder.DropTable(
                name: "tb_inventory_current_lists");

            migrationBuilder.DropTable(
                name: "tb_inventory_items");

            migrationBuilder.DropTable(
                name: "tb_log");

            migrationBuilder.DropTable(
                name: "tb_losses");

            migrationBuilder.DropTable(
                name: "tb_mandatory_drugs");

            migrationBuilder.DropTable(
                name: "tb_medical_insurances");

            migrationBuilder.DropTable(
                name: "tb_monitor_syncs");

            migrationBuilder.DropTable(
                name: "tb_online_pay_systems");

            migrationBuilder.DropTable(
                name: "tb_order_items");

            migrationBuilder.DropTable(
                name: "tb_receipts");

            migrationBuilder.DropTable(
                name: "tb_return_of_products");

            migrationBuilder.DropTable(
                name: "tb_revaluation_of_drugs");

            migrationBuilder.DropTable(
                name: "tb_sdachis");

            migrationBuilder.DropTable(
                name: "tb_setups");

            migrationBuilder.DropTable(
                name: "tb_smenas");

            migrationBuilder.DropTable(
                name: "tb_turnovers");

            migrationBuilder.DropTable(
                name: "tb_write_offs");

            migrationBuilder.DropTable(
                name: "tb_customers");

            migrationBuilder.DropTable(
                name: "tb_buy_on_credits");

            migrationBuilder.DropTable(
                name: "sp_order_status");

            migrationBuilder.DropTable(
                name: "tb_users");

            migrationBuilder.DropTable(
                name: "tb_inventories");

            migrationBuilder.DropTable(
                name: "tb_price_items");

            migrationBuilder.DropTable(
                name: "sp_insurances");

            migrationBuilder.DropTable(
                name: "tb_orders");

            migrationBuilder.DropTable(
                name: "tb_doc_items");

            migrationBuilder.DropTable(
                name: "sp_drug_stores");

            migrationBuilder.DropTable(
                name: "sp_roles");

            migrationBuilder.DropTable(
                name: "tb_price_docs");

            migrationBuilder.DropTable(
                name: "tb_drug_additional_infoes");

            migrationBuilder.DropTable(
                name: "tb_docs");

            migrationBuilder.DropTable(
                name: "sp_drugs");

            migrationBuilder.DropTable(
                name: "sp_operation_types");

            migrationBuilder.DropTable(
                name: "sp_districts");

            migrationBuilder.DropTable(
                name: "sp_drug_additional_infoes");

            migrationBuilder.DropTable(
                name: "tb_discounts");

            migrationBuilder.DropTable(
                name: "sp_distributors");

            migrationBuilder.DropTable(
                name: "sp_drug_categories");

            migrationBuilder.DropTable(
                name: "sp_manufacturers");

            migrationBuilder.DropTable(
                name: "sp_pharm_groups");

            migrationBuilder.DropTable(
                name: "sp_units");

            migrationBuilder.DropTable(
                name: "sp_regions");

            migrationBuilder.DropTable(
                name: "sp_discount_types");

            migrationBuilder.DropTable(
                name: "sp_countries");
        }
    }
}
