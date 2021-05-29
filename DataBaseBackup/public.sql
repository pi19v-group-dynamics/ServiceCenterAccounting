/*
 Navicat Premium Data Transfer

 Source Server         : Kursach
 Source Server Type    : PostgreSQL
 Source Server Version : 130002
 Source Host           : localhost:5432
 Source Catalog        : SCA_GD
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 130002
 File Encoding         : 65001

 Date: 29/05/2021 23:50:27
*/


-- ----------------------------
-- Sequence structure for  and monoblocks_id_laptop_or_monoblock_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"." and monoblocks_id_laptop_or_monoblock_seq";
CREATE SEQUENCE "public"." and monoblocks_id_laptop_or_monoblock_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for client_id_client_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."client_id_client_seq";
CREATE SEQUENCE "public"."client_id_client_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for components_or_other_devices_id_component_or_other_devices_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."components_or_other_devices_id_component_or_other_devices_seq";
CREATE SEQUENCE "public"."components_or_other_devices_id_component_or_other_devices_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for orders_and_devices_id_order_and_device_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."orders_and_devices_id_order_and_device_seq";
CREATE SEQUENCE "public"."orders_and_devices_id_order_and_device_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for orders_id_orders_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."orders_id_orders_seq";
CREATE SEQUENCE "public"."orders_id_orders_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for smartphones_id_smartphone_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."smartphones_id_smartphone_seq";
CREATE SEQUENCE "public"."smartphones_id_smartphone_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for stages _of_execution_id_stage_of_execution_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."stages _of_execution_id_stage_of_execution_seq";
CREATE SEQUENCE "public"."stages _of_execution_id_stage_of_execution_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for stationary_computers_id_stationary computer_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."stationary_computers_id_stationary computer_seq";
CREATE SEQUENCE "public"."stationary_computers_id_stationary computer_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for types_of_device_id_type_of_device_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."types_of_device_id_type_of_device_seq";
CREATE SEQUENCE "public"."types_of_device_id_type_of_device_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for workers_id_worker_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."workers_id_worker_seq";
CREATE SEQUENCE "public"."workers_id_worker_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for сomponent_types_id_component type_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."сomponent_types_id_component type_seq";
CREATE SEQUENCE "public"."сomponent_types_id_component type_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Table structure for clients
-- ----------------------------
DROP TABLE IF EXISTS "public"."clients";
CREATE TABLE "public"."clients" (
  "id_client" int4 NOT NULL DEFAULT nextval('client_id_client_seq'::regclass),
  "last_name_client" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "first_name_client" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "middle_name_client" varchar(255) COLLATE "pg_catalog"."default",
  "passport_series" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "phone" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for component_or_other_device_types
-- ----------------------------
DROP TABLE IF EXISTS "public"."component_or_other_device_types";
CREATE TABLE "public"."component_or_other_device_types" (
  "id_component_or_other_device_type" int4 NOT NULL DEFAULT nextval('"сomponent_types_id_component type_seq"'::regclass),
  "name_component_or_other_device_type" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for components_or_other_devices
-- ----------------------------
DROP TABLE IF EXISTS "public"."components_or_other_devices";
CREATE TABLE "public"."components_or_other_devices" (
  "id_component_or_other_devices" int4 NOT NULL DEFAULT nextval('components_or_other_devices_id_component_or_other_devices_seq'::regclass),
  "id_component_type" int4 NOT NULL,
  "brand" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "model" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for laptops_and_monoblocks
-- ----------------------------
DROP TABLE IF EXISTS "public"."laptops_and_monoblocks";
CREATE TABLE "public"."laptops_and_monoblocks" (
  "id_laptop_or_monoblock" int4 NOT NULL DEFAULT nextval('" and monoblocks_id_laptop_or_monoblock_seq"'::regclass),
  "manufacturer" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "model" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "cpu" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "ram" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "ram_capacity" int4 NOT NULL,
  "number_of_drives" int4 NOT NULL,
  "total_drives_capacity" int4 NOT NULL
)
;

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS "public"."orders";
CREATE TABLE "public"."orders" (
  "id_orders" int4 NOT NULL DEFAULT nextval('orders_id_orders_seq'::regclass),
  "id_client" int4 NOT NULL,
  "id_worker" int4 NOT NULL,
  "date_of_adoption" date NOT NULL,
  "date_of_completion" date NOT NULL,
  "date_of_issue" date NOT NULL,
  "customer_comment" text COLLATE "pg_catalog"."default",
  "id_stage_of_execution" int4 NOT NULL
)
;

-- ----------------------------
-- Table structure for orders_and_devices
-- ----------------------------
DROP TABLE IF EXISTS "public"."orders_and_devices";
CREATE TABLE "public"."orders_and_devices" (
  "id_order_and_device" int4 NOT NULL DEFAULT nextval('orders_and_devices_id_order_and_device_seq'::regclass),
  "id_order" int4 NOT NULL,
  "id_type_of_device" int4 NOT NULL,
  "id_specific_device" int4 NOT NULL
)
;

-- ----------------------------
-- Table structure for smartphones
-- ----------------------------
DROP TABLE IF EXISTS "public"."smartphones";
CREATE TABLE "public"."smartphones" (
  "id_smartphone" int4 NOT NULL DEFAULT nextval('smartphones_id_smartphone_seq'::regclass),
  "manufacturer" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "model" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "imei" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for stages _of_execution
-- ----------------------------
DROP TABLE IF EXISTS "public"."stages _of_execution";
CREATE TABLE "public"."stages _of_execution" (
  "id_stage_of_execution" int4 NOT NULL DEFAULT nextval('"stages _of_execution_id_stage_of_execution_seq"'::regclass),
  "name_stage_of_execution" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for stationary_computers
-- ----------------------------
DROP TABLE IF EXISTS "public"."stationary_computers";
CREATE TABLE "public"."stationary_computers" (
  "id_stationary computer" int4 NOT NULL DEFAULT nextval('"stationary_computers_id_stationary computer_seq"'::regclass),
  "motherboard" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "cpu" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "gpu" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "power_supply" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "number_of_drives" int4 NOT NULL,
  "total_drives_capacity" int4 NOT NULL,
  "cpu cooling" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "additional_devices" text COLLATE "pg_catalog"."default",
  "ram" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "ram_capacity" int4 NOT NULL
)
;

-- ----------------------------
-- Table structure for types_of_device
-- ----------------------------
DROP TABLE IF EXISTS "public"."types_of_device";
CREATE TABLE "public"."types_of_device" (
  "id_type_of_device" int4 NOT NULL DEFAULT nextval('types_of_device_id_type_of_device_seq'::regclass),
  "type_of_device" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "name_table" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for workers
-- ----------------------------
DROP TABLE IF EXISTS "public"."workers";
CREATE TABLE "public"."workers" (
  "id_worker" int4 NOT NULL DEFAULT nextval('workers_id_worker_seq'::regclass),
  "last_name_worker" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "first_name_worker" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "middle_name_worker" varchar(255) COLLATE "pg_catalog"."default",
  "interest_rate" int4 NOT NULL,
  "employment" bool NOT NULL,
  "date_of_brth" date NOT NULL
)
;

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"." and monoblocks_id_laptop_or_monoblock_seq"
OWNED BY "public"."laptops_and_monoblocks"."id_laptop_or_monoblock";
SELECT setval('"public"." and monoblocks_id_laptop_or_monoblock_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."client_id_client_seq"
OWNED BY "public"."clients"."id_client";
SELECT setval('"public"."client_id_client_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."components_or_other_devices_id_component_or_other_devices_seq"
OWNED BY "public"."components_or_other_devices"."id_component_or_other_devices";
SELECT setval('"public"."components_or_other_devices_id_component_or_other_devices_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."orders_and_devices_id_order_and_device_seq"
OWNED BY "public"."orders_and_devices"."id_order_and_device";
SELECT setval('"public"."orders_and_devices_id_order_and_device_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."orders_id_orders_seq"
OWNED BY "public"."orders"."id_orders";
SELECT setval('"public"."orders_id_orders_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."smartphones_id_smartphone_seq"
OWNED BY "public"."smartphones"."id_smartphone";
SELECT setval('"public"."smartphones_id_smartphone_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."stages _of_execution_id_stage_of_execution_seq"
OWNED BY "public"."stages _of_execution"."id_stage_of_execution";
SELECT setval('"public"."stages _of_execution_id_stage_of_execution_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."stationary_computers_id_stationary computer_seq"
OWNED BY "public"."stationary_computers"."id_stationary computer";
SELECT setval('"public"."stationary_computers_id_stationary computer_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."types_of_device_id_type_of_device_seq"
OWNED BY "public"."types_of_device"."id_type_of_device";
SELECT setval('"public"."types_of_device_id_type_of_device_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."workers_id_worker_seq"
OWNED BY "public"."workers"."id_worker";
SELECT setval('"public"."workers_id_worker_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."сomponent_types_id_component type_seq"
OWNED BY "public"."component_or_other_device_types"."id_component_or_other_device_type";
SELECT setval('"public"."сomponent_types_id_component type_seq"', 2, false);

-- ----------------------------
-- Uniques structure for table clients
-- ----------------------------
ALTER TABLE "public"."clients" ADD CONSTRAINT "clients_id_client_key" UNIQUE ("id_client");
ALTER TABLE "public"."clients" ADD CONSTRAINT "clients_passport_series_key" UNIQUE ("passport_series");

-- ----------------------------
-- Primary Key structure for table clients
-- ----------------------------
ALTER TABLE "public"."clients" ADD CONSTRAINT "clients_pkey" PRIMARY KEY ("id_client");

-- ----------------------------
-- Uniques structure for table component_or_other_device_types
-- ----------------------------
ALTER TABLE "public"."component_or_other_device_types" ADD CONSTRAINT "component_types_id_component_type_key" UNIQUE ("id_component_or_other_device_type");
ALTER TABLE "public"."component_or_other_device_types" ADD CONSTRAINT "component_types_name_component_type_key" UNIQUE ("name_component_or_other_device_type");

-- ----------------------------
-- Primary Key structure for table component_or_other_device_types
-- ----------------------------
ALTER TABLE "public"."component_or_other_device_types" ADD CONSTRAINT "component_types_pkey" PRIMARY KEY ("id_component_or_other_device_type");

-- ----------------------------
-- Uniques structure for table components_or_other_devices
-- ----------------------------
ALTER TABLE "public"."components_or_other_devices" ADD CONSTRAINT "components_or_other_devices_id_component_or_other_devices_key" UNIQUE ("id_component_or_other_devices");

-- ----------------------------
-- Primary Key structure for table components_or_other_devices
-- ----------------------------
ALTER TABLE "public"."components_or_other_devices" ADD CONSTRAINT "components_or_other_devices_pkey" PRIMARY KEY ("id_component_or_other_devices");

-- ----------------------------
-- Primary Key structure for table laptops_and_monoblocks
-- ----------------------------
ALTER TABLE "public"."laptops_and_monoblocks" ADD CONSTRAINT "laptops_and_monoblocks_pkey" PRIMARY KEY ("id_laptop_or_monoblock");

-- ----------------------------
-- Primary Key structure for table orders
-- ----------------------------
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_pkey" PRIMARY KEY ("id_orders");

-- ----------------------------
-- Primary Key structure for table orders_and_devices
-- ----------------------------
ALTER TABLE "public"."orders_and_devices" ADD CONSTRAINT "orders_and_devices_pkey" PRIMARY KEY ("id_order_and_device");

-- ----------------------------
-- Uniques structure for table smartphones
-- ----------------------------
ALTER TABLE "public"."smartphones" ADD CONSTRAINT "smartphones_imei_key" UNIQUE ("imei");

-- ----------------------------
-- Primary Key structure for table smartphones
-- ----------------------------
ALTER TABLE "public"."smartphones" ADD CONSTRAINT "smartphones_pkey" PRIMARY KEY ("id_smartphone");

-- ----------------------------
-- Uniques structure for table stages _of_execution
-- ----------------------------
ALTER TABLE "public"."stages _of_execution" ADD CONSTRAINT "stages _of_execution_id_stage_of_execution_key" UNIQUE ("id_stage_of_execution");
ALTER TABLE "public"."stages _of_execution" ADD CONSTRAINT "stages _of_execution_name_stage_of_execution_key" UNIQUE ("name_stage_of_execution");

-- ----------------------------
-- Primary Key structure for table stages _of_execution
-- ----------------------------
ALTER TABLE "public"."stages _of_execution" ADD CONSTRAINT "stages _of_execution_pkey" PRIMARY KEY ("id_stage_of_execution");

-- ----------------------------
-- Primary Key structure for table stationary_computers
-- ----------------------------
ALTER TABLE "public"."stationary_computers" ADD CONSTRAINT "stationary_computers_pkey" PRIMARY KEY ("id_stationary computer");

-- ----------------------------
-- Uniques structure for table types_of_device
-- ----------------------------
ALTER TABLE "public"."types_of_device" ADD CONSTRAINT "types_of_device_id_type_of_device_key" UNIQUE ("id_type_of_device");
ALTER TABLE "public"."types_of_device" ADD CONSTRAINT "types_of_device_type_of_device_key" UNIQUE ("type_of_device");
ALTER TABLE "public"."types_of_device" ADD CONSTRAINT "types_of_device_name_table_key" UNIQUE ("name_table");

-- ----------------------------
-- Primary Key structure for table types_of_device
-- ----------------------------
ALTER TABLE "public"."types_of_device" ADD CONSTRAINT "types_of_device_pkey" PRIMARY KEY ("id_type_of_device");

-- ----------------------------
-- Uniques structure for table workers
-- ----------------------------
ALTER TABLE "public"."workers" ADD CONSTRAINT "workers_date_of_brth_key" UNIQUE ("date_of_brth");
ALTER TABLE "public"."workers" ADD CONSTRAINT "workers_id_worker_key" UNIQUE ("id_worker");

-- ----------------------------
-- Primary Key structure for table workers
-- ----------------------------
ALTER TABLE "public"."workers" ADD CONSTRAINT "workers_pkey" PRIMARY KEY ("id_worker");

-- ----------------------------
-- Foreign Keys structure for table components_or_other_devices
-- ----------------------------
ALTER TABLE "public"."components_or_other_devices" ADD CONSTRAINT "components_or_other_devices_id_component_type_fkey" FOREIGN KEY ("id_component_type") REFERENCES "public"."component_or_other_device_types" ("id_component_or_other_device_type") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table orders
-- ----------------------------
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_id_client_fkey" FOREIGN KEY ("id_client") REFERENCES "public"."clients" ("id_client") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_id_stage_of_execution_fkey" FOREIGN KEY ("id_stage_of_execution") REFERENCES "public"."stages _of_execution" ("id_stage_of_execution") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_id_worker_fkey" FOREIGN KEY ("id_worker") REFERENCES "public"."workers" ("id_worker") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table orders_and_devices
-- ----------------------------
ALTER TABLE "public"."orders_and_devices" ADD CONSTRAINT "orders_and_devices_id_order_fkey" FOREIGN KEY ("id_order") REFERENCES "public"."orders" ("id_orders") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."orders_and_devices" ADD CONSTRAINT "orders_and_devices_id_type_of_device_fkey" FOREIGN KEY ("id_type_of_device") REFERENCES "public"."types_of_device" ("id_type_of_device") ON DELETE CASCADE ON UPDATE NO ACTION;
