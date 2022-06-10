create database  if not exists db_mutualista;

create table administradores(id int auto_increment not null ,nombres varchar(100),
	apellidos varchar(100),correo varchar(120),contrasenia varchar(50), primary key(id));

create table clientes(id int auto_increment not null ,nombres varchar(100),
	apellidos varchar(100),correo varchar(120), telefono varchar(25),fecha varchar(100),monto decimal,
    periodo varchar(50),plazo int,interes decimal,pago_fijo decimal,total decimal, primary key(id));


