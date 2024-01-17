--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA ADMINS
CREATE TABLE ADMINS(
ID_card VARCHAR2(11),
first_name VARCHAR2(10) NOT NULL,
second_name VARCHAR2(10),
last_name VARCHAR2(10) NOT NULL,
second_last_name VARCHAR2(10),
pasword VARCHAR2(15) NOT NULL); 
ALTER TABLE ADMINS ADD CONSTRAINT PK_ADMINS_ID_card PRIMARY KEY (ID_card);

CREATE OR REPLACE PROCEDURE insert_manager (
A_ID_card ADMINS.ID_card%TYPE,
A_first_name ADMINS.first_name%TYPE,
A_second_name ADMINS.second_name%TYPE,
A_last_name ADMINS.last_name%TYPE,
A_second_last_name ADMINS.second_last_name%TYPE,
A_pasword ADMINS.pasword%TYPE)
IS
BEGIN
    INSERT INTO ADMINS(ID_card, first_name, second_name, last_name, second_last_name, pasword) 
    VALUES (A_ID_card, A_first_name, A_second_name, A_last_name, A_second_last_name, A_pasword);
END;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA EMPLEADOS
CREATE TABLE EMPLOYEES(
ID_card_manager VARCHAR2(11), --Cedula de Manager / Foranea
ID_card VARCHAR2(11), --Cedula de empleado / Primaria
first_name VARCHAR2(10) NOT NULL,
second_name VARCHAR2(10),   
last_name VARCHAR2(10) NOT NULL,
second_last_name VARCHAR2(10),
date_start DATE DEFAULT SYSDATE); 
ALTER TABLE EMPLOYEES ADD CONSTRAINT PK_EMPLEADOS_ID_card PRIMARY KEY (ID_card);
ALTER TABLE EMPLOYEES ADD CONSTRAINT FK_EMPLEADOS_ID_card_manager FOREIGN KEY(ID_card_manager) REFERENCES ADMINS(ID_card);

CREATE OR REPLACE PROCEDURE insert_employee ( --Procedimiento para insertar a un empleado
E_ID_card_manager ADMINS.ID_card%TYPE,
E_ID_card EMPLOYEES.ID_card%TYPE,
E_first_name EMPLOYEES.first_name%TYPE,
E_second_name EMPLOYEES.second_name%TYPE,
E_last_name EMPLOYEES.last_name%TYPE,
E_second_last_name EMPLOYEES.second_last_name%TYPE)
IS
BEGIN
    INSERT INTO EMPLOYEES(ID_card_manager, ID_card, first_name, second_name, last_name, second_last_name) 
    VALUES (E_ID_card_manager, E_ID_card, E_first_name, E_second_name, E_last_name, E_second_last_name);
END;

CREATE OR REPLACE PROCEDURE change_employee(
E_ID_card EMPLOYEES.ID_card%TYPE,
E_first_name EMPLOYEES.first_name%TYPE,
E_second_name EMPLOYEES.second_name%TYPE,
E_last_name EMPLOYEES.last_name%TYPE,
E_second_last_name EMPLOYEES.second_last_name%TYPE)
IS
BEGIN
    UPDATE EMPLOYEES
    SET first_name = E_first_name, second_name = E_second_name, last_name = E_last_name, second_last_name = E_second_last_name 
    WHERE EMPLOYEES.ID_card = E_ID_card;
END;

CREATE OR REPLACE PROCEDURE delete_employee(E_ID_card EMPLOYEES.ID_card%TYPE)
IS
BEGIN
    DELETE 
    FROM EMPLOYEES
    WHERE  EMPLOYEES.ID_card = E_ID_card;
END;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA NOMINAS
CREATE TABLE NOMINAS(
id_nomina VARCHAR2(3),
cedula_empleado VARCHAR2(11),
cedula_admin VARCHAR2(11),
nombre VARCHAR2(10),
apellido VARCHAR2(10),
total_kilos NUMBER(8,3),
total_pedidos NUMBER(6,0), 
salario_base NUMBER(10,2),
total_pagar NUMBER(10,2),
fecha DATE); 
ALTER TABLE NOMINAS ADD CONSTRAINT PK_NOMINAS_id_nomina PRIMARY KEY (id_nomina);
ALTER TABLE NOMINAS ADD CONSTRAINT FK_NOMINAS_cedula_admin FOREIGN KEY(cedula_admin) REFERENCES ADMINS(cedula);
ALTER TABLE NOMINAS ADD CONSTRAINT FK_NOMINAS_cedula_empleado FOREIGN KEY(cedula_empleado) REFERENCES EMPLEADOS(cedula);

CREATE SEQUENCE iinsertar_seque  START WITH 1;

CREATE OR REPLACE TRIGGER insertar_id_nomina
BEFORE INSERT ON NOMINAS
FOR EACH ROW
DECLARE 
BEGIN
SELECT  iinsertar_seque.NEXTVAL INTO :NEW.id_nomina FROM DUAL;
END;

CREATE OR REPLACE PROCEDURE insertar_nomina(
N_cedula_empleado NOMINAS.cedula_empleado%TYPE,
N_salario_base NOMINAS.salario_base%TYPE,
N_fecha NOMINAS.fecha%TYPE)
IS
Total_Kilos NUMBER;
Total_Pedidos NUMBER;
SALARIO NUMBER;
Nombre EMPLEADOS.nombre%TYPE;
Apellido EMPLEADOS.apellido%TYPE;
Admins EMPLEADOS.cedula_admin%TYPE;
BEGIN
    SELECT cedula_admin,nombre,apellido INTO admins,Nombre,Apellido FROM empleados
    WHERE N_cedula_empleado = cedula;
    
    SELECT SUM(cantidad) INTO Total_Kilos FROM regescogidos
    WHERE N_cedula_empleado = cedula_empleado;
    
    SELECT SUM(f.total) INTO Total_Pedidos FROM FACTURA_PEDIDOS f
    JOIN DETALLE_PEDIDOS d on (f.id_pedido = d.id_pedido)
    WHERE N_cedula_empleado = d.cedula_empleado;
    
    SALARIO := (Total_Kilos * N_salario_base ) - Total_Pedidos;
    
    INSERT INTO NOMINAS (cedula_empleado,cedula_admin ,nombre ,apellido ,total_kilos ,total_pedidos,salario_base,total_pagar,fecha)
    VALUES(N_cedula_empleado,admins,Nombre,Apellido,Total_Kilos,Total_Pedidos,N_salario_base,SALARIO,N_fecha );
END;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA FACTURA_VENTAS
CREATE TABLE FACTURA_VENTAS(
id_venta VARCHAR2(3),
nombre_empresa VARCHAR(20),
nombre_jefe VARCHAR2(10),
apellido_jefe VARCHAR2(10),
grano_cafe VARCHAR2(15),
tipo_cafe VARCHAR(15),
subtotal NUMBER(10,2),
total NUMBER(10,2),
fecha DATE);
ALTER TABLE FACTURA_VENTAS ADD CONSTRAINT PK_VENTAS_id_venta PRIMARY KEY (id_venta);

CREATE OR REPLACE PROCEDURE insertar_venta(FV_id_venta FACTURA_VENTAS.id_venta%TYPE,
FV_nombre_empresa FACTURA_VENTAS.nombre_empresa%TYPE,
FV_fecha FACTURA_VENTAS.fecha%TYPE)
IS
BEGIN
    INSERT INTO FACTURA_VENTAS (id_venta, nombre_empresa, fecha) 
    VALUES(FV_id_venta, FV_nombre_empresa, FV_fecha) ;
END;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA DETALLE_FACTURA_VENTA
CREATE TABLE DETALLE_FACTURA_VENTAS(
id_detalle_venta VARCHAR2(3),
cedula_admin VARCHAR2(11),
id_venta VARCHAR2(3),
id_cafe VARCHAR2(2),
id_tipoC VARCHAR2(2),
factor VARCHAR2(10),
kilos_netos NUMBER(8,3),
valor_Kilo NUMBER(10,2),
valor_baseKilo NUMBER(10,2));
ALTER TABLE DETALLE_FACTURA_VENTAS ADD CONSTRAINT FK_FACTURA_VENTAS_id_venta FOREIGN KEY(id_venta) REFERENCES FACTURA_VENTAS(id_venta);
ALTER TABLE DETALLE_FACTURA_VENTAS ADD CONSTRAINT FK_ADMINS_cedula_admin FOREIGN KEY(cedula_admin) REFERENCES ADMINS(cedula);
ALTER TABLE DETALLE_FACTURA_VENTAS ADD CONSTRAINT FK_TIPOCAFE_tipo_cafe FOREIGN KEY(id_tipoC) REFERENCES TIPOS_CAFES(id_tipocafe);
ALTER TABLE DETALLE_FACTURA_VENTAS ADD CONSTRAINT FK_CAFES_id_cafe FOREIGN KEY(id_cafe) REFERENCES CAFES(id_cafe);

CREATE SEQUENCE seq_id_detalleV START WITH 1;

CREATE OR REPLACE TRIGGER trigger_id_detalleV
BEFORE INSERT ON DETALLE_FACTURA_VENTAS
FOR EACH ROW
DECLARE
BEGIN
    SELECT seq_id_detalleV.NEXTVAL INTO :NEW.id_detalle_venta FROM DUAL;
END;

CREATE OR REPLACE PROCEDURE insertar_detalleV(
DFV_cedula_admin DETALLE_FACTURA_VENTAS.cedula_admin%TYPE,
DFV_id_venta DETALLE_FACTURA_VENTAS.id_venta%TYPE,
DFV_id_cafe DETALLE_FACTURA_VENTAS.id_cafe%TYPE,
DFV_id_tipoC DETALLE_FACTURA_VENTAS.id_tipoC%TYPE,
DFV_factor DETALLE_FACTURA_VENTAS.factor%TYPE,
DFV_kilos_netos DETALLE_FACTURA_VENTAS.kilos_netos%TYPE,
DFV_valor_Kilo DETALLE_FACTURA_VENTAS.valor_Kilo%TYPE,
DFV_valor_baseKilo DETALLE_FACTURA_VENTAS.valor_baseKilo%TYPE)
IS
BEGIN
    INSERT INTO DETALLE_FACTURA_VENTAS(cedula_admin, id_venta,id_cafe, id_tipoC, factor, kilos_netos, valor_Kilo, valor_baseKilo) 
    VALUES (DFV_cedula_admin, DFV_id_venta, DFV_id_cafe, DFV_id_tipoC, DFV_factor, DFV_kilos_netos, DFV_valor_Kilo, DFV_valor_baseKilo);
END;

CREATE OR REPLACE TRIGGER insert_facturaV
AFTER INSERT ON DETALLE_FACTURA_VENTAS 
FOR EACH ROW
DECLARE
totalV FACTURA_VENTAS.total%TYPE;
subtotalV FACTURA_VENTAS.subtotal%TYPE;
nombreJ ADMINS.nombre%TYPE;
apellidoJ ADMINS.apellido%TYPE;
nombreTC TIPOS_CAFES.nombre_tipocafe%TYPE;
nombreC CAFES.nombre_cafe%TYPE;
BEGIN
    SELECT nombre, apellido INTO nombreJ, apellidoJ FROM ADMINS WHERE cedula = :NEW.cedula_admin;
    SELECT nombre_tipocafe INTO nombreTC FROM TIPOS_CAFES WHERE id_tipocafe = :NEW.id_tipoC;
    SELECT nombre_cafe INTO nombreC FROM CAFES WHERE id_cafe = :NEW.id_cafe;
    
    totalV :=  :NEW.KILOS_NETOS  * :NEW.VALOR_KILO;
    subtotalV := :NEW.KILOS_NETOS  * :NEW.VALOR_KILO;
    
    UPDATE FACTURA_VENTAS
    SET nombre_jefe = nombreJ, apellido_jefe = apellidoJ, grano_cafe = nombreC, tipo_cafe = nombreTC, total = totalV, subtotal = subtotalV
    WHERE id_venta = :NEW.id_venta;
END;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA FACTURA_PEDIDOS
CREATE TABLE FACTURA_PEDIDOS(
id_pedido VARCHAR2(3),
nombre_producto VARCHAR2(20),
nombre_empleado  VARCHAR2(10),
apellido_empleado VARCHAR2(10),
total NUMBER(10,2),
fecha DATE);
ALTER TABLE FACTURA_PEDIDOS ADD CONSTRAINT PK_PEDIDOS_id_pedido PRIMARY KEY (id_pedido); 

CREATE OR REPLACE PROCEDURE insertar_pedido(FP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
FP_fecha  FACTURA_PEDIDOS.fecha%TYPE)
IS
BEGIN
    INSERT INTO FACTURA_PEDIDOS(id_pedido, fecha) 
    VALUES (FP_id_pedido, FP_fecha);
END;

CREATE OR REPLACE PROCEDURE modificar_pedido(FP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
FP_fecha  FACTURA_PEDIDOS.fecha%TYPE)
IS
BEGIN
    UPDATE FACTURA_PEDIDOS
    SET fecha = FP_fecha
    WHERE id_pedido = FP_id_pedido;
END;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA DETALLE_PEDIDOS
CREATE TABLE DETALLE_PEDIDOS(
id_detalle_pedido VARCHAR2(3),
id_pedido VARCHAR2(3),
id_producto VARCHAR(2),
cedula_empleado VARCHAR2(11),
cantidad NUMBER(4,0));
ALTER TABLE DETALLE_PEDIDOS ADD CONSTRAINT FK_EMPLEADO_PEDIDOS_id_pedido FOREIGN KEY(id_pedido) REFERENCES FACTURA_PEDIDOS(id_pedido);
ALTER TABLE DETALLE_PEDIDOS ADD CONSTRAINT FK_EMPLEADO_PEDIDOS_cedula_empleado FOREIGN KEY(cedula_empleado) REFERENCES EMPLEADOS(cedula);
ALTER TABLE DETALLE_PEDIDOS ADD CONSTRAINT FK_PRODUCTOS_PEDIDOS_id_producto FOREIGN KEY(id_producto) REFERENCES PRODUCTOS(id_producto);

CREATE SEQUENCE seq_id_detalleP START WITH 1;

CREATE OR REPLACE TRIGGER trigger_id_detalleP
BEFORE INSERT ON DETALLE_PEDIDOS
FOR EACH ROW
DECLARE
BEGIN
    SELECT seq_id_detalleP.NEXTVAL INTO :NEW.id_detalle_pedido FROM DUAL;
END;

CREATE OR REPLACE PROCEDURE insertar_detalleP (
DP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
DP_id_producto PRODUCTOS.id_producto%TYPE,
DP_cedula_empleado EMPLEADOS.cedula%TYPE,
DP_cantidad DETALLE_PEDIDOS.cantidad%TYPE)
IS
BEGIN
    INSERT INTO DETALLE_PEDIDOS(id_pedido, id_producto, cedula_empleado, cantidad) 
    VALUES (DP_id_pedido, DP_id_producto, DP_cedula_empleado, DP_cantidad);
END;

CREATE OR REPLACE TRIGGER insert_facturaP
AFTER INSERT ON DETALLE_PEDIDOS
FOR EACH ROW
DECLARE
    nombreE EMPLEADOS.nombre%TYPE;
    apellidoE EMPLEADOS.apellido%TYPE;
    nombreP PRODUCTOS.nombre_producto%TYPE;
    precioP PRODUCTOS.precio_producto%TYPE;
    totalP FACTURA_PEDIDOS.total%TYPE;
BEGIN
    SELECT precio_producto INTO precioP FROM PRODUCTOS WHERE id_producto = :NEW.id_producto;
    totalP := precioP * :NEW.cantidad;
    SELECT nombre, apellido INTO nombreE, apellidoE FROM EMPLEADOS WHERE cedula = :NEW.cedula_empleado;
    SELECT nombre_producto INTO nombreP FROM PRODUCTOS WHERE id_producto = :NEW.id_producto;
    
    UPDATE FACTURA_PEDIDOS SET total = totalP, nombre_empleado = nombreE, apellido_empleado = apellidoE, nombre_producto = nombreP 
    WHERE id_pedido = :NEW.id_pedido;
END;
------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA REGCAFES
CREATE TABLE REGCAFES(
id_rcafe VARCHAR2(3),
cedula_admin VARCHAR2(11),
cereza_kilos NUMBER(8,3),
secos_kilos NUMBER(8,3),
fecha DATE DEFAULT SYSDATE); 
ALTER TABLE REGCAFES ADD CONSTRAINT PK_CAFES_id_rcafe PRIMARY KEY (id_rcafe);
ALTER TABLE REGCAFES ADD CONSTRAINT FK_REGCAFES_cedula_admin FOREIGN KEY(cedula_admin) REFERENCES ADMINS(cedula);

CREATE SEQUENCE seq_id_regcafe START WITH 1;

CREATE OR REPLACE TRIGGER trigger_id_regcafe
BEFORE INSERT ON REGCAFES
FOR EACH ROW
DECLARE
BEGIN
    SELECT  seq_id_regcafe.NEXTVAL 
    INTO :NEW.id_rcafe  
    FROM DUAL;
END;

CREATE OR REPLACE PROCEDURE insertar_regcafes(
RC_cedula_admin ADMINS.cedula%TYPE,
RC_cereza_kilos REGCAFES.cereza_kilos%TYPE,
RC_secos_kilos REGCAFES.secos_kilos%TYPE)
IS
BEGIN
    INSERT INTO REGCAFES (cedula_admin, cereza_kilos, secos_kilos) VALUES (RC_cedula_admin, RC_cereza_kilos, RC_secos_kilos);
END;

CREATE OR REPLACE PROCEDURE modificar_regcafes(
RC_id_rcafe REGCAFES.id_rcafe%TYPE,
RC_cereza_kilos REGCAFES.cereza_kilos%TYPE,
RC_secos_kilos REGCAFES.secos_kilos%TYPE,
RC_fecha REGCAFES.fecha%TYPE)
IS
BEGIN
    UPDATE REGCAFES
    SET cereza_kilos = RC_cereza_kilos, secos_kilos = RC_secos_kilos
    WHERE id_rcafe = RC_id_rcafe;
END;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA REGESCOGIDOS
CREATE TABLE REGESCOGIDOS(
id_escogido VARCHAR2(3),
cedula_admin VARCHAR2(11),
cedula_empleado VARCHAR2(11),
cantidad VARCHAR2(3),
fecha DATE);
ALTER TABLE REGESCOGIDOS ADD CONSTRAINT FK_REGESCOGIDOS_cedula_admin FOREIGN KEY(cedula_admin) REFERENCES ADMINS(cedula);
ALTER TABLE REGESCOGIDOS ADD CONSTRAINT FK_REGESCOGIDOS_cedula_empleado FOREIGN KEY(cedula_empleado) REFERENCES EMPLEADOS(cedula);

CREATE SEQUENCE seq_id_escogido START WITH 1;

CREATE OR REPLACE TRIGGER trigger_id_escogido
BEFORE INSERT ON REGESCOGIDOS
FOR EACH ROW
DECLARE
BEGIN
    SELECT seq_id_escogido.NEXTVAL 
    INTO :NEW.id_escogido 
    FROM DUAL;
END;

CREATE OR REPLACE PROCEDURE insertar_escogidos (
RE_cedula_admin ADMINS.cedula%TYPE,
RE_cedula_empleado EMPLEADOS.cedula%TYPE,
RE_cantidad REGESCOGIDOS.cantidad%TYPE,
RE_fecha REGESCOGIDOS.fecha%TYPE)
IS
BEGIN
    INSERT INTO REGESCOGIDOS(cedula_admin, cedula_empleado, cantidad, fecha)
    VALUES (RE_cedula_admin, RE_cedula_empleado, RE_cantidad, RE_fecha);
END;

CREATE OR REPLACE PROCEDURE modificar_escogidos (
RE_id_escogido REGESCOGIDOS.id_escogido%TYPE,
RE_cedula_empleado EMPLEADOS.cedula%TYPE,
RE_cantidad REGESCOGIDOS.cantidad%TYPE,
RE_fecha REGESCOGIDOS.fecha%TYPE)
IS
BEGIN   
    UPDATE REGESCOGIDOS
    SET cedula_empleado = RE_cedula_empleado, cantidad = RE_cantidad, fecha = RE_fecha
    WHERE id_escogido = RE_id_escogido;
END;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA TIPO DE CAFE
CREATE TABLE CAFES(id_cafe VARCHAR2(2),
nombre_cafe VARCHAR2(15));
ALTER TABLE CAFES ADD CONSTRAINT PK_CAFES_id_cafe PRIMARY KEY (id_cafe);
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA TIPO DE CAFE
CREATE TABLE TIPOS_CAFES(
id_cafe VARCHAR2(2),
id_tipocafe VARCHAR2(2),
nombre_tipocafe VARCHAR2(15));
ALTER TABLE TIPOS_CAFES ADD CONSTRAINT PK_TIPOS_CAFES_id_tipoCafe PRIMARY KEY (id_tipoCafe);
ALTER TABLE TIPOS_CAFES ADD CONSTRAINT FK_REGCAFES_id_cafe FOREIGN KEY(id_cafe) REFERENCES CAFES(id_cafe);
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA LA TABLA PRODUCTOS
CREATE TABLE PRODUCTOS (
id_producto VARCHAR2(2),
nombre_producto VARCHAR2(15),
precio_producto NUMBER(10,2));
ALTER TABLE PRODUCTOS ADD CONSTRAINT PK_PRODUCTOS_id_producto PRIMARY KEY (id_producto); 
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DEL ADMINISTRADORES
CREATE OR REPLACE PACKAGE PK_proce_administrador
AS
PROCEDURE insertar_administrador (
A_cedula ADMINS.cedula%TYPE,
A_nombre ADMINS.nombre%TYPE,
A_nombre2 ADMINS.nombre2%TYPE,
A_apellido ADMINS.apellido%TYPE,
A_apellido2 ADMINS.apellido2%TYPE,
A_contrase�a ADMINS.contrase�a%TYPE);
END PK_proce_administrador;

CREATE OR REPLACE PACKAGE BODY  PK_proce_administrador
AS
PROCEDURE insertar_administrador (
A_cedula ADMINS.cedula%TYPE,
A_nombre ADMINS.nombre%TYPE,
A_nombre2 ADMINS.nombre2%TYPE,
A_apellido ADMINS.apellido%TYPE,
A_apellido2 ADMINS.apellido2%TYPE,
A_contrase�a ADMINS.contrase�a%TYPE)
IS
BEGIN
    INSERT INTO ADMINS(cedula, nombre, nombre2, apellido, apellido2, contrase�a) 
    VALUES (A_cedula, A_nombre, A_nombre2, A_apellido, A_apellido2, A_contrase�a);
END;
END  PK_proce_administrador;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DEL EMPLEADOS
CREATE OR REPLACE PACKAGE PK_proce_empleado
AS
PROCEDURE insertar_empleado (
E_cedula_A ADMINS.cedula%TYPE,
E_cedula EMPLEADOS.cedula%TYPE,
E_nombre EMPLEADOS.nombre%TYPE,
E_nombre2 EMPLEADOS.nombre2%TYPE,
E_apellido EMPLEADOS.apellido%TYPE,
E_apellido2 EMPLEADOS.apellido2%TYPE);

PROCEDURE modificar_empleado(
E_cedula EMPLEADOS.cedula%TYPE,
E_nombre EMPLEADOS.nombre%TYPE,
E_nombre2 EMPLEADOS.nombre2%TYPE,
E_apellido EMPLEADOS.apellido%TYPE,
E_apellido2 EMPLEADOS.apellido2%TYPE);

PROCEDURE eliminar_empleado(E_cedula EMPLEADOS.cedula%TYPE);
END PK_proce_empleado;
 
CREATE OR REPLACE PACKAGE BODY PK_proce_empleado
AS
PROCEDURE insertar_empleado (
E_cedula_A ADMINS.cedula%TYPE,
E_cedula EMPLEADOS.cedula%TYPE,
E_nombre EMPLEADOS.nombre%TYPE,
E_nombre2 EMPLEADOS.nombre2%TYPE,
E_apellido EMPLEADOS.apellido%TYPE,
E_apellido2 EMPLEADOS.apellido2%TYPE)
IS
BEGIN
    INSERT INTO EMPLEADOS(cedula_admin, cedula, nombre, nombre2, apellido, apellido2) 
    VALUES (E_cedula_A, E_cedula, E_nombre, E_nombre2, E_apellido, E_apellido2);
END;

PROCEDURE modificar_empleado(
E_cedula EMPLEADOS.cedula%TYPE,
E_nombre EMPLEADOS.nombre%TYPE,
E_nombre2 EMPLEADOS.nombre2%TYPE,
E_apellido EMPLEADOS.apellido%TYPE,
E_apellido2 EMPLEADOS.apellido2%TYPE)
IS
BEGIN
    UPDATE EMPLEADOS
    SET nombre = E_nombre, nombre2 = E_nombre2, apellido = E_apellido2, apellido2 = E_apellido2 
    WHERE EMPLEADOS.cedula = E_cedula;
END;

PROCEDURE eliminar_empleado(E_cedula EMPLEADOS.cedula%TYPE)
IS
BEGIN
    DELETE 
    FROM EMPLEADOS
    WHERE  EMPLEADOS.cedula = E_cedula;
END;
END PK_proce_empleado;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DE LA NOMINAS
CREATE OR REPLACE PACKAGE PK_proce_nomina
AS
PROCEDURE insertar_nomina(
N_cedula_empleado NOMINAS.cedula_empleado%TYPE,
N_salario_base NOMINAS.salario_base%TYPE,
N_fecha NOMINAS.fecha%TYPE);
END PK_proce_nomina;

CREATE OR REPLACE PACKAGE BODY PK_proce_nomina
AS
PROCEDURE insertar_nomina(
N_cedula_empleado NOMINAS.cedula_empleado%TYPE,
N_salario_base NOMINAS.salario_base%TYPE,
N_fecha NOMINAS.fecha%TYPE)
IS
Total_Kilos NUMBER;
Total_Pedidos NUMBER;
SALARIO NUMBER;
Nombre EMPLEADOS.nombre%TYPE;
Apellido EMPLEADOS.apellido%TYPE;
Admins EMPLEADOS.cedula_admin%TYPE;
BEGIN
    SELECT cedula_admin,nombre,apellido INTO admins,Nombre,Apellido FROM empleados
    WHERE N_cedula_empleado = cedula;
    
    SELECT SUM(cantidad) INTO Total_Kilos FROM regescogidos
    WHERE N_cedula_empleado = cedula_empleado;
    
    SELECT SUM(f.total) INTO Total_Pedidos FROM FACTURA_PEDIDOS f
    JOIN DETALLE_PEDIDOS d on (f.id_pedido = d.id_pedido)
    WHERE N_cedula_empleado = d.cedula_empleado;
    
    SALARIO := (Total_Kilos * N_salario_base ) - Total_Pedidos;
    
    INSERT INTO NOMINAS (cedula_empleado,cedula_admin ,nombre ,apellido ,total_kilos ,total_pedidos,salario_base,total_pagar,fecha)
    VALUES(N_cedula_empleado,admins,Nombre,Apellido,Total_Kilos,Total_Pedidos,N_salario_base,SALARIO,N_fecha );
END;
END  PK_proce_nomina;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DE FACTURA_VENTAS
CREATE OR REPLACE PACKAGE PK_proce_Fventa
AS
PROCEDURE insertar_venta(FV_id_venta FACTURA_VENTAS.id_venta%TYPE,
FV_nombre_empresa FACTURA_VENTAS.nombre_empresa%TYPE,
FV_fecha FACTURA_VENTAS.fecha%TYPE);
END PK_proce_Fventa; 

CREATE OR REPLACE PACKAGE BODY  PK_proce_Fventa
AS
PROCEDURE insertar_venta(FV_id_venta FACTURA_VENTAS.id_venta%TYPE,
FV_nombre_empresa FACTURA_VENTAS.nombre_empresa%TYPE,
FV_fecha FACTURA_VENTAS.fecha%TYPE)
IS
BEGIN
    INSERT INTO FACTURA_VENTAS (id_venta, nombre_empresa, fecha) 
    VALUES(FV_id_venta, FV_nombre_empresa, FV_fecha) ;
END;
END  PK_proce_Fventa;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DE DETALLE_FACTURA_VENTAS
CREATE OR REPLACE PACKAGE PK_proce_FDventa
AS
PROCEDURE insertar_detalleV(DFV_cedula_admin DETALLE_FACTURA_VENTAS.cedula_admin%TYPE,
DFV_id_venta DETALLE_FACTURA_VENTAS.id_venta%TYPE,
DFV_id_cafe DETALLE_FACTURA_VENTAS.id_cafe%TYPE,
DFV_id_tipoC DETALLE_FACTURA_VENTAS.id_tipoC%TYPE,
DFV_factor DETALLE_FACTURA_VENTAS.factor%TYPE,
DFV_kilos_netos DETALLE_FACTURA_VENTAS.kilos_netos%TYPE,
DFV_valor_Kilo DETALLE_FACTURA_VENTAS.valor_Kilo%TYPE,
DFV_valor_baseKilo DETALLE_FACTURA_VENTAS.valor_baseKilo%TYPE);
END PK_proce_FDventa;

CREATE OR REPLACE PACKAGE BODY PK_proce_FDventa
AS
PROCEDURE insertar_detalleV(DFV_cedula_admin DETALLE_FACTURA_VENTAS.cedula_admin%TYPE,
DFV_id_venta DETALLE_FACTURA_VENTAS.id_venta%TYPE,
DFV_id_cafe DETALLE_FACTURA_VENTAS.id_cafe%TYPE,
DFV_id_tipoC DETALLE_FACTURA_VENTAS.id_tipoC%TYPE,
DFV_factor DETALLE_FACTURA_VENTAS.factor%TYPE,
DFV_kilos_netos DETALLE_FACTURA_VENTAS.kilos_netos%TYPE,
DFV_valor_Kilo DETALLE_FACTURA_VENTAS.valor_Kilo%TYPE,
DFV_valor_baseKilo DETALLE_FACTURA_VENTAS.valor_baseKilo%TYPE)
IS
BEGIN
    INSERT INTO DETALLE_FACTURA_VENTAS(cedula_admin, id_venta,id_cafe, id_tipoC, factor, kilos_netos, valor_Kilo, valor_baseKilo) 
    VALUES (DFV_cedula_admin, DFV_id_venta, DFV_id_cafe, DFV_id_tipoC, DFV_factor, DFV_kilos_netos, DFV_valor_Kilo, DFV_valor_baseKilo);
END;
END PK_proce_FDventa;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DE PEDIDOS
CREATE OR REPLACE PACKAGE PK_proce_pedido
AS
PROCEDURE insertar_pedido(FP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
FP_fecha  FACTURA_PEDIDOS.fecha%TYPE);

PROCEDURE modificar_pedido(FP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
FP_fecha  FACTURA_PEDIDOS.fecha%TYPE);
END PK_proce_pedido;

CREATE OR REPLACE PACKAGE BODY PK_proce_pedido
AS
PROCEDURE insertar_pedido(FP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
FP_fecha  FACTURA_PEDIDOS.fecha%TYPE)
IS
BEGIN
    INSERT INTO FACTURA_PEDIDOS(id_pedido, fecha) 
    VALUES (FP_id_pedido, FP_fecha);
END;

PROCEDURE modificar_pedido(FP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
FP_fecha  FACTURA_PEDIDOS.fecha%TYPE)
IS
BEGIN
    UPDATE FACTURA_PEDIDOS
    SET fecha = FP_fecha
    WHERE id_pedido = FP_id_pedido;
END;
END  PK_proce_pedido;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DE DETALLES_PEDIDOS
CREATE OR REPLACE PACKAGE PK_proce_Dpedido
AS
PROCEDURE insertar_detalleP (DP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
DP_id_producto PRODUCTOS.id_producto%TYPE,
DP_cedula_empleado EMPLEADOS.cedula%TYPE,
DP_cantidad DETALLE_PEDIDOS.cantidad%TYPE);
END PK_proce_Dpedido;

CREATE OR REPLACE PACKAGE BODY PK_proce_Dpedido
AS
PROCEDURE insertar_detalleP (DP_id_pedido FACTURA_PEDIDOS.id_pedido%TYPE,
DP_id_producto PRODUCTOS.id_producto%TYPE,
DP_cedula_empleado EMPLEADOS.cedula%TYPE,
DP_cantidad DETALLE_PEDIDOS.cantidad%TYPE)
IS
BEGIN
    INSERT INTO DETALLE_PEDIDOS(id_pedido, id_producto, cedula_empleado, cantidad) 
    VALUES (DP_id_pedido, DP_id_producto, DP_cedula_empleado, DP_cantidad);
END;
END PK_proce_Dpedido;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DE REGCAFES
CREATE OR REPLACE PACKAGE PK_proce_regcafe
AS
PROCEDURE insertar_regcafes(RC_cedula_admin ADMINS.cedula%TYPE,
RC_cereza_kilos REGCAFES.cereza_kilos%TYPE,
RC_secos_kilos REGCAFES.secos_kilos%TYPE);

PROCEDURE modificar_regcafes(RC_id_rcafe REGCAFES.id_rcafe%TYPE,
RC_cereza_kilos REGCAFES.cereza_kilos%TYPE,
RC_secos_kilos REGCAFES.secos_kilos%TYPE,
RC_fecha REGCAFES.fecha%TYPE);
END PK_proce_regcafe;

CREATE OR REPLACE PACKAGE BODY PK_proce_regcafe
AS
PROCEDURE insertar_regcafes(RC_cedula_admin ADMINS.cedula%TYPE,
RC_cereza_kilos REGCAFES.cereza_kilos%TYPE,
RC_secos_kilos REGCAFES.secos_kilos%TYPE)
IS
BEGIN
    INSERT INTO REGCAFES (cedula_admin, cereza_kilos, secos_kilos) VALUES (RC_cedula_admin, RC_cereza_kilos, RC_secos_kilos);
END;

PROCEDURE modificar_regcafes(RC_id_rcafe REGCAFES.id_rcafe%TYPE,
RC_cereza_kilos REGCAFES.cereza_kilos%TYPE,
RC_secos_kilos REGCAFES.secos_kilos%TYPE,
RC_fecha REGCAFES.fecha%TYPE)
IS
BEGIN
    UPDATE REGCAFES
    SET cereza_kilos = RC_cereza_kilos, secos_kilos = RC_secos_kilos
    WHERE id_rcafe = RC_id_rcafe;
END;
END PK_proce_regcafe;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--PAQUETE PARA PROCEDIMIENTOS DE REGESCOGIDOS
CREATE OR REPLACE PACKAGE PK_proce_regescogido
AS
PROCEDURE insertar_escogidos (RE_cedula_admin ADMINS.cedula%TYPE,
RE_cedula_empleado EMPLEADOS.cedula%TYPE,
RE_cantidad REGESCOGIDOS.cantidad%TYPE,
RE_fecha REGESCOGIDOS.fecha%TYPE);

PROCEDURE modificar_escogidos (RE_id_escogido REGESCOGIDOS.id_escogido%TYPE,
RE_cedula_empleado EMPLEADOS.cedula%TYPE,
RE_cantidad REGESCOGIDOS.cantidad%TYPE,
RE_fecha REGESCOGIDOS.fecha%TYPE);
END PK_proce_regescogido;

CREATE OR REPLACE PACKAGE BODY PK_proce_regescogido
AS
PROCEDURE insertar_escogidos (RE_cedula_admin ADMINS.cedula%TYPE,
RE_cedula_empleado EMPLEADOS.cedula%TYPE,
RE_cantidad REGESCOGIDOS.cantidad%TYPE,
RE_fecha REGESCOGIDOS.fecha%TYPE)
IS
BEGIN
    INSERT INTO REGESCOGIDOS(cedula_admin, cedula_empleado, cantidad, fecha)
    VALUES (RE_cedula_admin, RE_cedula_empleado, RE_cantidad, RE_fecha);
END;

PROCEDURE modificar_escogidos (RE_id_escogido REGESCOGIDOS.id_escogido%TYPE,
RE_cedula_empleado EMPLEADOS.cedula%TYPE,
RE_cantidad REGESCOGIDOS.cantidad%TYPE,
RE_fecha REGESCOGIDOS.fecha%TYPE)
IS
BEGIN   
    UPDATE REGESCOGIDOS
    SET cedula_empleado = RE_cedula_empleado, cantidad = RE_cantidad, fecha = RE_fecha
    WHERE id_escogido = RE_id_escogido;
END;
END PK_proce_regescogido;
--------------------------------------------------------------------------------


--------------------------------------------------------------------------------
--ESPACIO PARA USO DE LAS TABLAS
SELECT * FROM ADMINS;
SELECT * FROM EMPLEADOS;
SELECT * FROM NOMINAS;
SELECT * FROM FACTURA_VENTAS;
SELECT * FROM DETALLE_FACTURA_VENTAS;
SELECT * FROM FACTURA_PEDIDOS;
SELECT * FROM DETALLE_PEDIDOS;
SELECT * FROM REGCAFES;
SELECT * FROM REGESCOGIDOS;

DROP TABLE ADMINS;
DROP TABLE EMPLEADOS;
DROP TABLE NOMINAS;
DROP TABLE FACTURA_VENTAS;
DROP TABLE DETALLE_FACTURA_VENTAS;
DROP TABLE FACTURA_PEDIDOS;
DROP TABLE DETALLE_PEDIDOS;
DROP TABLE REGCAFES;
DROP TABLE REGESCOGIDOS;
DROP TABLE PRODUCTOS;
--------------------------------------------------------------------------------