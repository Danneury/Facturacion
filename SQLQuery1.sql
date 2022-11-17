Create database SFBD;

Use SFBD;

CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contrasena] [varchar](50) NOT NULL,
	[Tipo_Usuario] [varchar](50) Not NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


Create Table Articulos(
	Id_Articulo int primary Key not null identity(1,1),
	Articulo varchar(50) not  null,
	Costo_unitario int not null,
	Precio_Unitario int not null,
	Estado varchar(50)
);

Insert into Articulos (Articulo, Costo_unitario, Precio_Unitario, Estado) values ('Televisor', 90,99, 'Televisores');

select * from Articulos
where [Precio Unitario] like '%%';


Create Table Clientes(
	Id_Cliente int primary Key not null identity(1,1),
	Nombre varchar(50) not  null,
	Rnc_Cedula varchar(50) not null,
	Estado varchar(50)
);

Create Table Condiciones_Pago(
	Id_Pago int primary Key not null identity(1,1),
	Descripcion varchar(50) not  null,
	Cantidad_de_Dias int,
	Estado varchar(50)
);

Create Table Vendedores(
	Id_Vendedor int primary Key not null identity(1,1),
	Nombre varchar(50) not  null,
	Porciento_Comisión int,
	Estado varchar(50)
);

