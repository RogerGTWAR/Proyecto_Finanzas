CREATE DATABASE FinanzasDB;
	Use FinanzasDB
	--Balance General
	Create table Clasificaciones(
	ID_Clasificacion INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVarchar(100));
	
	Create table DatosBalance(
	ID_DatosBalance int identity(1,1) primary key,
	NombreBG Nvarchar(250),
	FechaInicio DateTime,
	Fechafin DateTime)

   CREATE TABLE Activos(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ID_DatosBalance INT,
	ID_Clasificacion INt,
    NombreCuenta NVARCHAR(255) NOT NULL, 
    Monto DECIMAL(18, 2) NOT NULL ,
	Total Decimal (18,2),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificaciones(ID_Clasificacion),
    FOREIGN KEY (ID_DatosBalance) REFERENCES DatosBalance(ID_DatosBalance));

    CREATE TABLE Pasivos_Capital(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ID_DatosBalance INT,
	ID_Clasificacion INt,
    NombreCuenta NVARCHAR(255) NOT NULL, 
    Monto DECIMAL(18, 2) NOT NULL ,
	Total Decimal (18,2),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificaciones(ID_Clasificacion),
	FOREIGN KEY (ID_DatosBalance) REFERENCES DatosBalance(ID_DatosBalance));

	--Estado de Resultado
Create table DatosERx(
    ID_DatosER int identity (1,1) Primary key,
	NombreER Nvarchar(250),
	FechaInicio DateTime,
	Fechafin DateTime);
CREATE TABLE IngresosER
(
    ID_Ingresos INT IDENTITY(1,1) PRIMARY KEY,      
    ID_DatosER INT Not NULL,               
    ID_Clasificacion INT NOT NULL,                   
    NombreDeCuenta NVARCHAR(255) NULL,              
    Monto DECIMAL(18,2) NOT NULL,             
    Total DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificaciones(ID_Clasificacion),
    FOREIGN KEY (ID_DatosER) REFERENCES DatosERx(ID_DatosER)
);
