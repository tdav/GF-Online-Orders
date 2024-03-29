﻿

CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    migration_id character varying(150) NOT NULL,
    product_version character varying(32) NOT NULL,
    CONSTRAINT pk___ef_migrations_history PRIMARY KEY (migration_id)
);

CREATE TABLE sp_access_lists (
    id integer NOT NULL,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(100) NOT NULL,
    CONSTRAINT pk_sp_access_lists PRIMARY KEY (id)
);

CREATE TABLE sp_countries (
    id integer NOT NULL,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(200) NOT NULL,
    CONSTRAINT pk_sp_countries PRIMARY KEY (id)
);

CREATE TABLE sp_drug_categories (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(200) NOT NULL,
    CONSTRAINT pk_sp_drug_categories PRIMARY KEY (id)
);

CREATE TABLE sp_languages (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(100) NOT NULL,
    CONSTRAINT pk_sp_languages PRIMARY KEY (id)
);

CREATE TABLE sp_order_status (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(200) NOT NULL,
    CONSTRAINT pk_sp_order_status PRIMARY KEY (id)
);

CREATE TABLE sp_payments (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(100) NOT NULL,
    CONSTRAINT pk_sp_payments PRIMARY KEY (id)
);

CREATE TABLE sp_pharm_groups (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(200) NOT NULL,
    description character varying(200) NULL,
    CONSTRAINT pk_sp_pharm_groups PRIMARY KEY (id)
);

CREATE TABLE sp_regions (
    id integer NOT NULL,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(200) NOT NULL,
    CONSTRAINT pk_sp_regions PRIMARY KEY (id)
);

CREATE TABLE sp_roles (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(100) NOT NULL,
    user_access text NULL,
    CONSTRAINT pk_sp_roles PRIMARY KEY (id)
);

CREATE TABLE sp_units (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(200) NOT NULL,
    server_id integer NULL,
    impartible integer NOT NULL,
    CONSTRAINT pk_sp_units PRIMARY KEY (id)
);

CREATE TABLE sp_user_agents (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(100) NOT NULL,
    CONSTRAINT pk_sp_user_agents PRIMARY KEY (id)
);

CREATE TABLE tb_images (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    main_id integer NOT NULL,
    file_name text NULL,
    data bytea NULL,
    CONSTRAINT pk_tb_images PRIMARY KEY (id)
);

CREATE TABLE tb_product_headers (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    summa numeric NOT NULL,
    item_qty integer NOT NULL,
    document_no character varying(20) NULL,
    CONSTRAINT pk_tb_product_headers PRIMARY KEY (id)
);

CREATE TABLE tb_setups (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    CONSTRAINT pk_tb_setups PRIMARY KEY (id)
);

CREATE TABLE sp_manufacturers (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(255) NOT NULL,
    country_id integer NOT NULL,
    CONSTRAINT pk_sp_manufacturers PRIMARY KEY (id),
    CONSTRAINT fk_sp_manufacturers_sp_countries_country_id FOREIGN KEY (country_id) REFERENCES sp_countries (id) ON DELETE CASCADE
);

CREATE TABLE sp_districts (
    id integer NOT NULL,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(200) NOT NULL,
    region_id integer NOT NULL,
    CONSTRAINT pk_sp_districts PRIMARY KEY (id),
    CONSTRAINT fk_sp_districts_sp_regions_region_id FOREIGN KEY (region_id) REFERENCES sp_regions (id) ON DELETE CASCADE
);

CREATE TABLE tb_user (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    first_name character varying(100) NULL,
    last_name character varying(100) NULL,
    username character varying(20) NOT NULL,
    password character varying(100) NOT NULL,
    phone character varying(20) NULL,
    role_id integer NOT NULL,
    CONSTRAINT pk_tb_user PRIMARY KEY (id),
    CONSTRAINT fk_tb_user_sp_roles_role_id FOREIGN KEY (role_id) REFERENCES sp_roles (id) ON DELETE CASCADE
);

CREATE TABLE sp_drugs (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    barcode character varying(255) NULL,
    name character varying(255) NOT NULL,
    description character varying(255) NOT NULL,
    international_name character varying(255) NULL,
    dose character varying(255) NULL,
    manufacturer_id integer NULL,
    drug_category_id integer NULL,
    pharm_group_id integer NULL,
    piece integer NOT NULL,
    unit_id uuid NOT NULL,
    unit_id1 integer NULL,
    special integer NULL,
    photo character varying(255) NULL,
    vat_rate numeric NOT NULL,
    drug_recomendation character varying(2000) NULL,
    real_id uuid NULL,
    CONSTRAINT pk_sp_drugs PRIMARY KEY (id),
    CONSTRAINT fk_sp_drugs_sp_drug_categories_drug_category_id FOREIGN KEY (drug_category_id) REFERENCES sp_drug_categories (id) ON DELETE RESTRICT,
    CONSTRAINT fk_sp_drugs_sp_manufacturers_manufacturer_id FOREIGN KEY (manufacturer_id) REFERENCES sp_manufacturers (id) ON DELETE RESTRICT,
    CONSTRAINT fk_sp_drugs_sp_pharm_groups_pharm_group_id FOREIGN KEY (pharm_group_id) REFERENCES sp_pharm_groups (id) ON DELETE RESTRICT,
    CONSTRAINT fk_sp_drugs_sp_units_unit_id1 FOREIGN KEY (unit_id1) REFERENCES sp_units (id) ON DELETE RESTRICT
);

CREATE TABLE sp_drug_stores (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    name character varying(200) NOT NULL,
    phone character varying(200) NULL,
    region_id integer NOT NULL,
    district_id integer NOT NULL,
    address character varying(200) NULL,
    latitude numeric NOT NULL,
    longitude numeric NOT NULL,
    CONSTRAINT pk_sp_drug_stores PRIMARY KEY (id),
    CONSTRAINT fk_sp_drug_stores_sp_districts_district_id FOREIGN KEY (district_id) REFERENCES sp_districts (id) ON DELETE CASCADE,
    CONSTRAINT fk_sp_drug_stores_sp_regions_region_id FOREIGN KEY (region_id) REFERENCES sp_regions (id) ON DELETE CASCADE
);

CREATE TABLE tb_product_details (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    product_header_id integer NOT NULL,
    drug_id integer NOT NULL,
    series_no character varying(50) NULL,
    qty integer NOT NULL,
    cur_qty integer NOT NULL,
    price numeric NOT NULL,
    vat numeric NOT NULL,
    expiry_date timestamp without time zone NOT NULL,
    base_price numeric NULL,
    incoming_price numeric NOT NULL,
    extra_charge numeric NOT NULL,
    total_amount numeric NOT NULL,
    CONSTRAINT pk_tb_product_details PRIMARY KEY (id),
    CONSTRAINT fk_tb_product_details_sp_drugs_drug_id FOREIGN KEY (drug_id) REFERENCES sp_drugs (id) ON DELETE CASCADE,
    CONSTRAINT fk_tb_product_details_tb_product_headers_product_header_id FOREIGN KEY (product_header_id) REFERENCES tb_product_headers (id) ON DELETE CASCADE
);

CREATE TABLE tb_orders (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    drug_store_id integer NOT NULL,
    region_id integer NULL,
    district_id integer NULL,
    address character varying(500) NULL,
    latitude numeric NOT NULL,
    longitude numeric NOT NULL,
    description character varying(200) NULL,
    delivery_time timestamp without time zone NOT NULL,
    order_status_id integer NOT NULL,
    payment_id integer NOT NULL,
    user_agent_id integer NOT NULL,
    item_qty integer NOT NULL,
    summa numeric NOT NULL,
    CONSTRAINT pk_tb_orders PRIMARY KEY (id),
    CONSTRAINT fk_tb_orders_sp_drug_stores_drug_store_id FOREIGN KEY (drug_store_id) REFERENCES sp_drug_stores (id) ON DELETE CASCADE,
    CONSTRAINT fk_tb_orders_sp_order_status_order_status_id FOREIGN KEY (order_status_id) REFERENCES sp_order_status (id) ON DELETE CASCADE,
    CONSTRAINT fk_tb_orders_sp_payments_payment_id FOREIGN KEY (payment_id) REFERENCES sp_payments (id) ON DELETE CASCADE,
    CONSTRAINT fk_tb_orders_sp_user_agents_user_agent_id FOREIGN KEY (user_agent_id) REFERENCES sp_user_agents (id) ON DELETE CASCADE
);

CREATE TABLE tb_order_details (
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
    status integer NOT NULL,
    create_date timestamp without time zone NOT NULL,
    update_date timestamp without time zone NULL,
    create_user integer NOT NULL,
    update_user integer NULL,
    qty integer NOT NULL,
    drug_id integer NOT NULL,
    tb_order_header_id integer NULL,
    CONSTRAINT pk_tb_order_details PRIMARY KEY (id),
    CONSTRAINT fk_tb_order_details_sp_drugs_drug_id FOREIGN KEY (drug_id) REFERENCES sp_drugs (id) ON DELETE CASCADE,
    CONSTRAINT fk_tb_order_details_tb_orders_tb_order_header_id FOREIGN KEY (tb_order_header_id) REFERENCES tb_orders (id) ON DELETE RESTRICT
);

CREATE INDEX ix_sp_access_lists_create_user ON sp_access_lists (create_user);

CREATE INDEX ix_sp_access_lists_status ON sp_access_lists (status);

CREATE INDEX ix_sp_countries_create_user ON sp_countries (create_user);

CREATE INDEX ix_sp_countries_status ON sp_countries (status);

CREATE INDEX ix_sp_districts_create_user ON sp_districts (create_user);

CREATE INDEX ix_sp_districts_region_id ON sp_districts (region_id);

CREATE INDEX ix_sp_districts_status ON sp_districts (status);

CREATE INDEX ix_sp_drug_categories_create_user ON sp_drug_categories (create_user);

CREATE INDEX ix_sp_drug_categories_status ON sp_drug_categories (status);

CREATE INDEX ix_sp_drug_stores_create_user ON sp_drug_stores (create_user);

CREATE INDEX ix_sp_drug_stores_district_id ON sp_drug_stores (district_id);

CREATE INDEX ix_sp_drug_stores_region_id ON sp_drug_stores (region_id);

CREATE INDEX ix_sp_drug_stores_status ON sp_drug_stores (status);

CREATE INDEX ix_sp_drugs_create_user ON sp_drugs (create_user);

CREATE INDEX ix_sp_drugs_description ON sp_drugs (description);

CREATE INDEX ix_sp_drugs_drug_category_id ON sp_drugs (drug_category_id);

CREATE INDEX ix_sp_drugs_manufacturer_id ON sp_drugs (manufacturer_id);

CREATE INDEX ix_sp_drugs_pharm_group_id ON sp_drugs (pharm_group_id);

CREATE INDEX ix_sp_drugs_status ON sp_drugs (status);

CREATE INDEX ix_sp_drugs_unit_id1 ON sp_drugs (unit_id1);

CREATE INDEX ix_sp_languages_create_user ON sp_languages (create_user);

CREATE INDEX ix_sp_languages_status ON sp_languages (status);

CREATE INDEX ix_sp_manufacturers_country_id ON sp_manufacturers (country_id);

CREATE INDEX ix_sp_manufacturers_create_user ON sp_manufacturers (create_user);

CREATE INDEX ix_sp_manufacturers_name ON sp_manufacturers (name);

CREATE INDEX ix_sp_manufacturers_status ON sp_manufacturers (status);

CREATE INDEX ix_sp_order_status_create_user ON sp_order_status (create_user);

CREATE INDEX ix_sp_order_status_status ON sp_order_status (status);

CREATE INDEX ix_sp_payments_create_user ON sp_payments (create_user);

CREATE INDEX ix_sp_payments_status ON sp_payments (status);

CREATE INDEX ix_sp_pharm_groups_create_user ON sp_pharm_groups (create_user);

CREATE INDEX ix_sp_pharm_groups_status ON sp_pharm_groups (status);

CREATE INDEX ix_sp_regions_create_user ON sp_regions (create_user);

CREATE INDEX ix_sp_regions_status ON sp_regions (status);

CREATE INDEX ix_sp_roles_create_user ON sp_roles (create_user);

CREATE INDEX ix_sp_roles_status ON sp_roles (status);

CREATE INDEX ix_sp_units_create_user ON sp_units (create_user);

CREATE INDEX ix_sp_units_status ON sp_units (status);

CREATE INDEX ix_sp_user_agents_create_user ON sp_user_agents (create_user);

CREATE INDEX ix_sp_user_agents_status ON sp_user_agents (status);

CREATE INDEX ix_tb_images_create_user ON tb_images (create_user);

CREATE INDEX ix_tb_images_status ON tb_images (status);

CREATE INDEX ix_tb_order_details_create_user ON tb_order_details (create_user);

CREATE INDEX ix_tb_order_details_drug_id ON tb_order_details (drug_id);

CREATE INDEX ix_tb_order_details_status ON tb_order_details (status);

CREATE INDEX ix_tb_order_details_tb_order_header_id ON tb_order_details (tb_order_header_id);

CREATE INDEX ix_tb_orders_create_user ON tb_orders (create_user);

CREATE INDEX ix_tb_orders_drug_store_id ON tb_orders (drug_store_id);

CREATE INDEX ix_tb_orders_order_status_id ON tb_orders (order_status_id);

CREATE INDEX ix_tb_orders_payment_id ON tb_orders (payment_id);

CREATE INDEX ix_tb_orders_status ON tb_orders (status);

CREATE INDEX ix_tb_orders_user_agent_id ON tb_orders (user_agent_id);

CREATE INDEX ix_tb_product_details_create_user ON tb_product_details (create_user);

CREATE INDEX ix_tb_product_details_cur_qty ON tb_product_details (cur_qty);

CREATE INDEX ix_tb_product_details_drug_id ON tb_product_details (drug_id);

CREATE INDEX ix_tb_product_details_expiry_date ON tb_product_details (expiry_date);

CREATE INDEX ix_tb_product_details_product_header_id ON tb_product_details (product_header_id);

CREATE INDEX ix_tb_product_details_status ON tb_product_details (status);

CREATE INDEX ix_tb_product_headers_create_user ON tb_product_headers (create_user);

CREATE INDEX ix_tb_product_headers_status ON tb_product_headers (status);

CREATE INDEX ix_tb_setups_create_user ON tb_setups (create_user);

CREATE INDEX ix_tb_setups_status ON tb_setups (status);

CREATE INDEX ix_tb_user_create_user ON tb_user (create_user);

CREATE INDEX ix_tb_user_role_id ON tb_user (role_id);

CREATE INDEX ix_tb_user_status ON tb_user (status);

INSERT INTO "__EFMigrationsHistory" (migration_id, product_version)
VALUES ('20200414224940_m1', '3.1.3');


INSERT INTO orders.public.sp_roles(id, status, create_date, update_date, create_user, update_user, name, user_access) VALUES
(1, 1, '14.04.2020 5:23:05.000000 AD', null, 1, null, E'admin', E'999;1;');

INSERT INTO orders.public.sp_access_lists(id, status, create_date, update_date, create_user, update_user, name) VALUES
(1, 1, '14.04.2020 5:22:28.000000 AD', null, 1, null, E'admin');


INSERT INTO orders.public.tb_user(id, status, create_date, update_date, create_user, update_user, first_name, last_name, username, password, role_id) VALUES
(1, 1, '14.04.2020 5:23:46.000000 AD', null, 1, null, E'admin', E'admin', E'admin', E'2010',  1);


