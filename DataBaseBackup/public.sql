/*
 Navicat Premium Data Transfer

 Source Server         : Kursach
 Source Server Type    : PostgreSQL
 Source Server Version : 130002
 Source Host           : localhost:5432
 Source Catalog        : vxvc
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 130002
 File Encoding         : 65001

 Date: 04/06/2021 02:12:12
*/


-- ----------------------------
-- Sequence structure for clients_id_client_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."clients_id_client_seq";
CREATE SEQUENCE "public"."clients_id_client_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for component_or_other_device_typ_id_component_or_other_device__seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."component_or_other_device_typ_id_component_or_other_device__seq";
CREATE SEQUENCE "public"."component_or_other_device_typ_id_component_or_other_device__seq" 
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
-- Sequence structure for laptops_and_monoblocks_id_laptop_or_monoblock_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."laptops_and_monoblocks_id_laptop_or_monoblock_seq";
CREATE SEQUENCE "public"."laptops_and_monoblocks_id_laptop_or_monoblock_seq" 
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
-- Sequence structure for stages_of_execution_id_stage_of_execution_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."stages_of_execution_id_stage_of_execution_seq";
CREATE SEQUENCE "public"."stages_of_execution_id_stage_of_execution_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for stationary_computers_id_stationary_computer_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."stationary_computers_id_stationary_computer_seq";
CREATE SEQUENCE "public"."stationary_computers_id_stationary_computer_seq" 
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
-- Sequence structure for types_of_service_id_type_of_service_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."types_of_service_id_type_of_service_seq";
CREATE SEQUENCE "public"."types_of_service_id_type_of_service_seq" 
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
-- Table structure for clients
-- ----------------------------
DROP TABLE IF EXISTS "public"."clients";
CREATE TABLE "public"."clients" (
  "id_client" int4 NOT NULL DEFAULT nextval('clients_id_client_seq'::regclass),
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
  "id_component_or_other_device_type" int4 NOT NULL DEFAULT nextval('component_or_other_device_typ_id_component_or_other_device__seq'::regclass),
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
  "manufacturer" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "model" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for laptops_and_monoblocks
-- ----------------------------
DROP TABLE IF EXISTS "public"."laptops_and_monoblocks";
CREATE TABLE "public"."laptops_and_monoblocks" (
  "id_laptop_or_monoblock" int4 NOT NULL DEFAULT nextval('laptops_and_monoblocks_id_laptop_or_monoblock_seq'::regclass),
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
-- Table structure for logging
-- ----------------------------
DROP TABLE IF EXISTS "public"."logging";
CREATE TABLE "public"."logging" (
  "date_and_time_of_action" timestamp(0) NOT NULL,
  "name_of_action" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "role_of_action" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS "public"."orders";
CREATE TABLE "public"."orders" (
  "id_orders" int4 NOT NULL DEFAULT nextval('orders_id_orders_seq'::regclass),
  "id_client" int4 NOT NULL,
  "id_worker" int4,
  "date_of_adoption" date NOT NULL,
  "date_of_completion" date,
  "customer_comment" text COLLATE "pg_catalog"."default",
  "id_stage_of_execution" int4 NOT NULL,
  "id_type_of_service" int4 NOT NULL,
  "cost_of_parts" float4,
  "price" float4
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
-- Table structure for stages_of_execution
-- ----------------------------
DROP TABLE IF EXISTS "public"."stages_of_execution";
CREATE TABLE "public"."stages_of_execution" (
  "id_stage_of_execution" int4 NOT NULL DEFAULT nextval('stages_of_execution_id_stage_of_execution_seq'::regclass),
  "name_stage_of_execution" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Table structure for stationary_computers
-- ----------------------------
DROP TABLE IF EXISTS "public"."stationary_computers";
CREATE TABLE "public"."stationary_computers" (
  "id_stationary_computer" int4 NOT NULL DEFAULT nextval('stationary_computers_id_stationary_computer_seq'::regclass),
  "motherboard" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "cpu" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "gpu" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "power_supply" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "number_of_drives" int4 NOT NULL,
  "total_drives_capacity" int4 NOT NULL,
  "cpu_cooling" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
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
-- Table structure for types_of_service
-- ----------------------------
DROP TABLE IF EXISTS "public"."types_of_service";
CREATE TABLE "public"."types_of_service" (
  "id_type_of_service" int4 NOT NULL DEFAULT nextval('types_of_service_id_type_of_service_seq'::regclass),
  "name_type_of_service" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "cost_of_service" float4 NOT NULL
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
  "employment" bool NOT NULL
)
;

-- ----------------------------
-- Function structure for f_update_orders
-- ----------------------------
DROP FUNCTION IF EXISTS "public"."f_update_orders"();
CREATE OR REPLACE FUNCTION "public"."f_update_orders"()
  RETURNS "pg_catalog"."trigger" AS $BODY$ BEGIN IF(NEW.id_stage_of_execution = 3) THEN NEW.price := (SELECT types_of_service.cost_of_service FROM types_of_service WHERE types_of_service.id_type_of_service = OLD.id_type_of_service) +OLD.cost_of_parts; END IF; RETURN NEW; END $BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;

-- ----------------------------
-- Function structure for insert_into_logging
-- ----------------------------
DROP FUNCTION IF EXISTS "public"."insert_into_logging"();
CREATE OR REPLACE FUNCTION "public"."insert_into_logging"()
  RETURNS "pg_catalog"."trigger" AS $BODY$ BEGIN IF TG_OP = 'INSERT' THEN INSERT INTO logging(date_and_time_of_action, name_of_action, role_of_action) VALUES(CURRENT_TIMESTAMP, TG_OP, CURRENT_USER); RETURN NEW; ELSIF TG_OP = 'UPDATE' THEN INSERT INTO logging(date_and_time_of_action, name_of_action, role_of_action) VALUES(CURRENT_TIMESTAMP, TG_OP, CURRENT_USER); RETURN NEW; ELSIF TG_OP = 'DELETE' THEN INSERT INTO logging(date_and_time_of_action, name_of_action, role_of_action) VALUES(CURRENT_TIMESTAMP, TG_OP, CURRENT_USER); RETURN OLD; END IF; END $BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."clients_id_client_seq"
OWNED BY "public"."clients"."id_client";
SELECT setval('"public"."clients_id_client_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."component_or_other_device_typ_id_component_or_other_device__seq"
OWNED BY "public"."component_or_other_device_types"."id_component_or_other_device_type";
SELECT setval('"public"."component_or_other_device_typ_id_component_or_other_device__seq"', 2, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."components_or_other_devices_id_component_or_other_devices_seq"
OWNED BY "public"."components_or_other_devices"."id_component_or_other_devices";
SELECT setval('"public"."components_or_other_devices_id_component_or_other_devices_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."laptops_and_monoblocks_id_laptop_or_monoblock_seq"
OWNED BY "public"."laptops_and_monoblocks"."id_laptop_or_monoblock";
SELECT setval('"public"."laptops_and_monoblocks_id_laptop_or_monoblock_seq"', 2, false);

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
ALTER SEQUENCE "public"."stages_of_execution_id_stage_of_execution_seq"
OWNED BY "public"."stages_of_execution"."id_stage_of_execution";
SELECT setval('"public"."stages_of_execution_id_stage_of_execution_seq"', 4, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."stationary_computers_id_stationary_computer_seq"
OWNED BY "public"."stationary_computers"."id_stationary_computer";
SELECT setval('"public"."stationary_computers_id_stationary_computer_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."types_of_device_id_type_of_device_seq"
OWNED BY "public"."types_of_device"."id_type_of_device";
SELECT setval('"public"."types_of_device_id_type_of_device_seq"', 5, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."types_of_service_id_type_of_service_seq"
OWNED BY "public"."types_of_service"."id_type_of_service";
SELECT setval('"public"."types_of_service_id_type_of_service_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."workers_id_worker_seq"
OWNED BY "public"."workers"."id_worker";
SELECT setval('"public"."workers_id_worker_seq"', 2, false);

-- ----------------------------
-- Triggers structure for table clients
-- ----------------------------
CREATE TRIGGER "t_client" AFTER INSERT OR UPDATE OR DELETE ON "public"."clients"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

-- ----------------------------
-- Uniques structure for table clients
-- ----------------------------
ALTER TABLE "public"."clients" ADD CONSTRAINT "clients_passport_series_key" UNIQUE ("passport_series");
ALTER TABLE "public"."clients" ADD CONSTRAINT "clients_phone_key" UNIQUE ("phone");

-- ----------------------------
-- Primary Key structure for table clients
-- ----------------------------
ALTER TABLE "public"."clients" ADD CONSTRAINT "clients_pkey" PRIMARY KEY ("id_client");

-- ----------------------------
-- Triggers structure for table component_or_other_device_types
-- ----------------------------
CREATE TRIGGER "t_component_or_other_device_types" AFTER INSERT OR UPDATE OR DELETE ON "public"."component_or_other_device_types"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

-- ----------------------------
-- Uniques structure for table component_or_other_device_types
-- ----------------------------
ALTER TABLE "public"."component_or_other_device_types" ADD CONSTRAINT "component_types_name_component_type_key" UNIQUE ("name_component_or_other_device_type");

-- ----------------------------
-- Primary Key structure for table component_or_other_device_types
-- ----------------------------
ALTER TABLE "public"."component_or_other_device_types" ADD CONSTRAINT "component_types_pkey" PRIMARY KEY ("id_component_or_other_device_type");

-- ----------------------------
-- Triggers structure for table components_or_other_devices
-- ----------------------------
CREATE TRIGGER "t_components_or_other_devices" AFTER INSERT OR UPDATE OR DELETE ON "public"."components_or_other_devices"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

-- ----------------------------
-- Primary Key structure for table components_or_other_devices
-- ----------------------------
ALTER TABLE "public"."components_or_other_devices" ADD CONSTRAINT "components_or_other_devices_pkey" PRIMARY KEY ("id_component_or_other_devices");

-- ----------------------------
-- Triggers structure for table laptops_and_monoblocks
-- ----------------------------
CREATE TRIGGER "t_laptops_and_monoblocks" AFTER INSERT OR UPDATE OR DELETE ON "public"."laptops_and_monoblocks"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

-- ----------------------------
-- Primary Key structure for table laptops_and_monoblocks
-- ----------------------------
ALTER TABLE "public"."laptops_and_monoblocks" ADD CONSTRAINT "laptops_and_monoblocks_pkey" PRIMARY KEY ("id_laptop_or_monoblock");

-- ----------------------------
-- Triggers structure for table orders
-- ----------------------------
CREATE TRIGGER "t_orders" AFTER INSERT OR UPDATE OR DELETE ON "public"."orders"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();
CREATE TRIGGER "t_update_orders" BEFORE UPDATE OF "id_stage_of_execution" ON "public"."orders"
FOR EACH ROW
EXECUTE PROCEDURE "public"."f_update_orders"();

-- ----------------------------
-- Primary Key structure for table orders
-- ----------------------------
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_pkey" PRIMARY KEY ("id_orders");

-- ----------------------------
-- Triggers structure for table orders_and_devices
-- ----------------------------
CREATE TRIGGER "t_orders_and_devices" AFTER INSERT OR UPDATE OR DELETE ON "public"."orders_and_devices"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

-- ----------------------------
-- Primary Key structure for table orders_and_devices
-- ----------------------------
ALTER TABLE "public"."orders_and_devices" ADD CONSTRAINT "orders_and_devices_pkey" PRIMARY KEY ("id_order_and_device");

-- ----------------------------
-- Triggers structure for table smartphones
-- ----------------------------
CREATE TRIGGER "t_smartphones" AFTER INSERT OR UPDATE OR DELETE ON "public"."smartphones"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

-- ----------------------------
-- Uniques structure for table smartphones
-- ----------------------------
ALTER TABLE "public"."smartphones" ADD CONSTRAINT "smartphones_imei_key" UNIQUE ("imei");

-- ----------------------------
-- Primary Key structure for table smartphones
-- ----------------------------
ALTER TABLE "public"."smartphones" ADD CONSTRAINT "smartphones_pkey" PRIMARY KEY ("id_smartphone");

-- ----------------------------
-- Uniques structure for table stages_of_execution
-- ----------------------------
ALTER TABLE "public"."stages_of_execution" ADD CONSTRAINT "stages _of_execution_name_stage_of_execution_key" UNIQUE ("name_stage_of_execution");

-- ----------------------------
-- Primary Key structure for table stages_of_execution
-- ----------------------------
ALTER TABLE "public"."stages_of_execution" ADD CONSTRAINT "stages _of_execution_pkey" PRIMARY KEY ("id_stage_of_execution");

-- ----------------------------
-- Triggers structure for table stationary_computers
-- ----------------------------
CREATE TRIGGER "t_stationary_computers" AFTER INSERT OR UPDATE OR DELETE ON "public"."stationary_computers"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

-- ----------------------------
-- Primary Key structure for table stationary_computers
-- ----------------------------
ALTER TABLE "public"."stationary_computers" ADD CONSTRAINT "stationary_computers_pkey" PRIMARY KEY ("id_stationary_computer");

-- ----------------------------
-- Uniques structure for table types_of_device
-- ----------------------------
ALTER TABLE "public"."types_of_device" ADD CONSTRAINT "types_of_device_name_table_key" UNIQUE ("name_table");
ALTER TABLE "public"."types_of_device" ADD CONSTRAINT "types_of_device_type_of_device_key" UNIQUE ("type_of_device");

-- ----------------------------
-- Primary Key structure for table types_of_device
-- ----------------------------
ALTER TABLE "public"."types_of_device" ADD CONSTRAINT "types_of_device_pkey" PRIMARY KEY ("id_type_of_device");

-- ----------------------------
-- Triggers structure for table types_of_service
-- ----------------------------
CREATE TRIGGER "t_types_of_service" AFTER INSERT OR UPDATE OR DELETE ON "public"."types_of_service"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

-- ----------------------------
-- Uniques structure for table types_of_service
-- ----------------------------
ALTER TABLE "public"."types_of_service" ADD CONSTRAINT "types_of_service_name_type_of_service_key" UNIQUE ("name_type_of_service");

-- ----------------------------
-- Primary Key structure for table types_of_service
-- ----------------------------
ALTER TABLE "public"."types_of_service" ADD CONSTRAINT "types_of_service_pkey" PRIMARY KEY ("id_type_of_service");

-- ----------------------------
-- Triggers structure for table workers
-- ----------------------------
CREATE TRIGGER "workers" AFTER INSERT OR UPDATE OR DELETE ON "public"."workers"
FOR EACH ROW
EXECUTE PROCEDURE "public"."insert_into_logging"();

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
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_id_client_fkey" FOREIGN KEY ("id_client") REFERENCES "public"."clients" ("id_client") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_id_stage_of_execution_fkey" FOREIGN KEY ("id_stage_of_execution") REFERENCES "public"."stages_of_execution" ("id_stage_of_execution") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_id_type_of_service_fkey" FOREIGN KEY ("id_type_of_service") REFERENCES "public"."types_of_service" ("id_type_of_service") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."orders" ADD CONSTRAINT "orders_id_worker_fkey" FOREIGN KEY ("id_worker") REFERENCES "public"."workers" ("id_worker") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table orders_and_devices
-- ----------------------------
ALTER TABLE "public"."orders_and_devices" ADD CONSTRAINT "orders_and_devices_id_order_fkey" FOREIGN KEY ("id_order") REFERENCES "public"."orders" ("id_orders") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."orders_and_devices" ADD CONSTRAINT "orders_and_devices_id_type_of_device_fkey" FOREIGN KEY ("id_type_of_device") REFERENCES "public"."types_of_device" ("id_type_of_device") ON DELETE CASCADE ON UPDATE NO ACTION;
