create database bankApp_412459
go
use bankApp_412459
go

create table clientes(
dni int,
nombre varchar(50),
apellido varchar(50)
constraint pk_dni primary key (dni)
)

create table cuentas(
cbu varchar(50),
saldo decimal,
tipo_cuenta varchar(50),
ultimo_mov decimal,
id_cliente int
constraint pk_cbu primary key (cbu)
constraint fk_id_cliente foreign key (id_cliente)
references clientes (dni)
)