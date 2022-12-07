drop database panesito
use master
create database panesito
use panesito
CREATE TABLE ESTADO
(
	es_id_estado int primary key,
	es_descrpcion varchar(50) not null
)

create table MUNICIPIO
(
mu_id_municipio int primary key,
mu_descripcion varchar (100) not null,
mu_id_estado int not null foreign key references estado(es_id_estado)
)

--Nueva (Mayoreo/Menudeo)
create table TIPO_CLIENTE
(
tc_id int primary key,
tc_descripcion varchar(100)
)

--Modificada
create table CLIENTE
(
cl_id_cliente int primary key,
cl_nombre varchar (50) not null,
cl_apellido_pat varchar (100) not null,
cl_apellido_mat varchar (50) null,
cl_telefono varchar (15) not null,
cl_calle varchar (50) not null,
cl_num_interior varchar (10) not null,
cl_num_exterior varchar (10) null,
cl_colonia varchar (50) not null,
cl_id_municipio int not null foreign key references municipio(mu_id_municipio),
cl_id_tipocl int not null foreign key references TIPO_CLIENTE(tc_id),
cl_status char(1) not null
)

CREATE TABLE ROL
(
	r_id int primary key identity(1,1),
	r_tipo varchar (50) NOT NULL
)

CREATE table EMPLEADO
(
	em_id_empleado int primary key identity NOT NULL,
	em_usuario varchar(30) NOT NULL,
	em_contraseña varbinary(max) NOT NULL, 
	em_apellido_paterno varchar(30) NOT NULL,
	em_apellido_materno varchar(30)NULL,
	em_telefono varchar(10) NOT NULL,
	em_calle varchar(60) NOT NULL,
	em_num_interior int NOT NULL,
	em_num_exterior int NOT NULL,
	em_colonia varchar(30) NOT NULL,
	em_id_municipio int  NOT NULL foreign key references municipio(mu_id_municipio),
	em_r_id int NOT NULL foreign key references ROL(r_id),
	em_status char(1) NOT NULL
)

Create table PEDIDO
(
	pe_id_pedido int primary key identity(1,1),
	pe_id_cliente int not null foreign key references CLIENTE(cl_id_cliente),
	pe_id_empleado int not null foreign key references EMPLEADO(em_id_empleado),
	pe_estatus_pedido bit not null
)

--SE CANCELA
create table PEDIDO_DETALLE_TEMPORAL
(
	pdt_id_pedido int not null foreign key references PEDIDO(pe_id_pedido),
	pdt_producto varchar not null,
	pdt_precio float not null,
	pdt_cantidad int not null
)

create table PEDIDO_DETALLE
(
	pd_id_pedido int not null foreign key references PEDIDO(pe_id_pedido),
	pd_producto varchar not null,
	pd_precio float not null,
	pd_cantidad int not null
)

create table CATEGORIA 
(
	ca_id int primary key identity(1,1),
	ca_descripcion varchar(50) not null
)


create table UNIDAD
(
un_id_unidad int primary key not null,
un_descripcion varchar(20) not null
)

create table PRODUCTO
(
	pr_id_producto int primary key identity NOT NULL, 
	pr_nombre varchar(20) NOT NULL,
	pr_descripcion varchar(30) NOT NULL,
	pr_id_categoria int  NOT NULL foreign key references CATEGORIA(ca_id),
	pr_precio float NOT NULL,
	pr_id_unidad int not null foreign key references UNIDAD(un_id_unidad),
	pr_status char(1) not null,
)
CREATE TABLE ALMACEN_PRODUCTO
(
	ap_id int primary key not null,
	ap_nombre varchar(50) not null,
)
Create table INSUMO
(
	in_id_insumo int primary key,
	in_nombre varchar (50) not null,
	in_costo float not null,
	in_id_unidad int not null foreign key references UNIDAD(un_id_unidad),
	in_status char(1) not null
)

CREATE TABLE RECETA
(
	r_id_receta int primary key,
	r_nombre varchar(50) not null,
	r_grupo varchar(50) not null
)

CREATE TABLE RECETA_DETALLE
(
	rd_id_receta int not null foreign key references RECETA(r_id_receta),
	rd_id_insumo int not null foreign key references INSUMO(in_id_insumo),
	rd_cantidad int not null,
	rd_costo float not null
)

--MODIFICADA
CREATE TABLE VENTA
(
	vta_id_venta int primary key,
	vta_id_empleado int not null foreign key references EMPLEADO(em_id_empleado),
	vta_id_cliente int not null foreign key references CLIENTE(cl_id_cliente),
	--(Pedido o no: vta_tipo)
	vta_tipo bit not null,
	vta_fecha date not null,
	vta_total float not null
)

--MODIFICADA
CREATE TABLE DETALLE_VENTA_TEMPORAL
(
	dvt_id_venta int not null foreign key references VENTA(vta_id_venta),
	dvt_id_cliente int not null foreign key references CLIENTE(cl_id_cliente),
	--dvt_id_pedido int null foreign key references PEDIDO(pe_id_pedido),
	dvt_id_producto int not null foreign key references PRODUCTO(pr_id_producto),
	dvt_precio float not null,
	dvt_cantidad int not null
)

--MODIFICADA
CREATE TABLE DETALLE_VENTA
(
	dv_id_venta int not null foreign key references VENTA(vta_id_venta),
	dv_id_pedido int null foreign key references PEDIDO(pe_id_pedido),
	dv_id_producto int not null foreign key references PRODUCTO(pr_id_producto),
	dv_precio float not null,
	dv_cantidad int not null
)


CREATE TABLE TIPO_MOV
(
	tm_id int primary key,
	tm_tipo varchar (40) not null
)

CREATE TABLE PRODUCCION
(
	p_id int primary key,
	p_id_insumo int not null foreign key references INSUMO(in_id_insumo),
	p_id_receta int not null foreign key references RECETA(r_id_receta),
	p_id_producto int not null foreign key references PRODUCTO(pr_id_producto),
	p_tm_id int not null foreign key references TIPO_MOV(tm_id)
)

CREATE TABLE REGIMEN
(
	rg_id int primary key,
	rg_descripcion varchar(500) not null
)

CREATE TABLE PROVEEDOR
(
	pdr_id int primary key,
	pdr_nombre varchar (50) null,
	pdr_apellido_pat varchar (100)null,
	pdr_apellido_mat varchar (50) null,
	pdr_regimen int not null foreign key references REGIMEN(rg_id),
	pdr_RFC varchar (13) not null,  
	pdr_rason_social varchar (100) not null,
	pdr_telefono varchar (15) not null,
	pdr_calle varchar (50) not null,
	pdr_num_interior varchar (10) not null,
	pdr_num_exterior varchar (10) null,
	pdr_colonia varchar (50) not null,
	pdr_id_municipio int not null foreign key references municipio(mu_id_municipio),
	pdr_status char(1) not null
)

CREATE TABLE MOV_INV
(
	m_id_mov int primary key,
	m_fecha date not null,
	m_tm_id int not null foreign key references TIPO_MOV(tm_id),
	m_id_prov int not null foreign key references PROVEEDOR(pdr_id),
	m_ap_id int not null foreign key references AlMACEN_PRODUCTO(ap_id)
)

CREATE TABLE MOV_INV_DET
(
	mid_id_mov int not null foreign key references MOV_INV(M_id_mov),
	mid_id_insumo int not null foreign key references INSUMO(in_id_insumo),
	mid_id_producto int not null foreign key references PRODUCTO(pr_id_producto),
	mid_id_venta int null foreign key references VENTA(vta_id_venta),
	mid_cantidad int not null,
	mid_precio float not null
)


/*
	RECETA
	INVENTARIO
*/