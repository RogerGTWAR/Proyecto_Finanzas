CREATE DATABASE FinanzasDB;
	Create table Clasificaciones(
	ID_Clasificacion INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVarchar(100));
CREATE TABLE Activos(
    ID INT IDENTITY(1,1) PRIMARY KEY,
	NumeroDeBalance INT,
	ID_Clasificacion INt,
    NombreCuenta NVARCHAR(255) NOT NULL, 
    Monto DECIMAL(18, 2) NOT NULL ,
	Total Decimal (18,2),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificaciones(ID_Clasificacion));
CREATE TABLE Pasivos_Capital(
    ID INT IDENTITY(1,1) PRIMARY KEY,
	NumeroDeBalance INT,
	ID_Clasificacion INt,
    NombreCuenta NVARCHAR(255) NOT NULL, 
    Monto DECIMAL(18, 2) NOT NULL ,
	Total Decimal (18,2),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificaciones(ID_Clasificacion));
	Create table NumerosDeBalance(
	ID int identity(1,1) primary key,
	NumeroDeBalance int)


	Select * From Cuentas
	SELECT * FROM Clasificaciones
