Create database DBCajeroConsola
Use DBCajeroConsola
Go

Create table TblCliente
(
idCliente int identity(1,1) primary key,
NombreCliente Varchar(50) not null,
Dni Varchar(50) not null,
Telefono Varchar(50) not null,
Direccion Varchar(50) not null,
)

Create table TblProducto
(
CodProducto Varchar(50) primary Key,
NombreProducto  Varchar(50) not null,
PrecioP	Decimal not null
)

