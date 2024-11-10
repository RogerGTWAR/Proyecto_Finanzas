CREATE DATABASE FinanzasDB;
	Use FinanzasDB
	--Balance General
	Create table Clasificaciones(
	ID_Clasificacion INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVarchar(150));
	
	Create table DatosBalance(
	ID_DatosBalance int identity(1,1) primary key,
	NombreBG Nvarchar(150),
	FechaInicio DateTime,
	Fechafin DateTime)

   CREATE TABLE Activos(
    ID_Activo INT IDENTITY(1,1) PRIMARY KEY,
    ID_DatosBalance INT,
	ID_Clasificacion INt,
    NombreCuenta NVARCHAR(150) NOT NULL, 
    Monto DECIMAL(18, 2) NOT NULL ,
	Total Decimal (18,2),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificaciones(ID_Clasificacion),
    FOREIGN KEY (ID_DatosBalance) REFERENCES DatosBalance(ID_DatosBalance));

    CREATE TABLE Pasivos_Capital(
    ID_Pasivo_Capital INT IDENTITY(1,1) PRIMARY KEY,
    ID_DatosBalance INT,
	ID_Clasificacion INt,
    NombreCuenta NVARCHAR(150) NOT NULL, 
    Monto DECIMAL(18, 2) NOT NULL ,
	Total Decimal (18,2),
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificaciones(ID_Clasificacion),
	FOREIGN KEY (ID_DatosBalance) REFERENCES DatosBalance(ID_DatosBalance));

	--Estado de Resultado
    Create table DatosERx(
    ID_DatosER int identity (1,1) Primary key,
	NombreER Nvarchar(150),
	FechaInicio DateTime,
	Fechafin DateTime);

	CREATE TABLE IngresosER
(
    ID_Ingresos INT IDENTITY(1,1) PRIMARY KEY,      
    ID_DatosER INT Not NULL,               
    ID_Clasificacion INT NOT NULL,                   
    NombreDeCuenta NVARCHAR(150) NULL,              
    Monto DECIMAL(18,2) NOT NULL,             
    Total DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (ID_Clasificacion) REFERENCES Clasificaciones(ID_Clasificacion),
    FOREIGN KEY (ID_DatosER) REFERENCES DatosERx(ID_DatosER)
);

--Razones Financieras
CREATE TABLE CuentasRazones (
    ID_CuentasDeRazones INT IDENTITY(1,1) PRIMARY KEY,
    NombreDeLaEmpresa NVARCHAR(255) NOT NULL,
    ActivoCirculante DECIMAL(18,2) NOT NULL,
    PasivoCirculante DECIMAL(18,2) NOT NULL,
    Inventario DECIMAL(18,2) NOT NULL,
    ActivoTotal DECIMAL(18,2) NOT NULL,
    PasivoTotal DECIMAL(18,2) NOT NULL,
    CapitalContable DECIMAL(18,2) NOT NULL,
    ActivoFijo DECIMAL(18,2) NOT NULL,
    InteresesPagados DECIMAL(18,2) NOT NULL,
    CuentasPorCobrar DECIMAL(18,2) NOT NULL,
    UtilidadOperativa DECIMAL(18,2) NOT NULL,
    VentasNetas DECIMAL(18,2) NOT NULL,
    CostoVentas DECIMAL(18,2) NOT NULL,
    VentasAnuales DECIMAL(18,2) NOT NULL,
    UtilidadAntesDeImpuestos DECIMAL(18,2) NOT NULL,
    UtilidadNeta DECIMAL(18,2) NOT NULL
);
CREATE TABLE RazonesFinancieras (
    ID_RazonesFinancieras INT IDENTITY(1,1) PRIMARY KEY,
    ID_CuentasDeRazones INT NOT NULL,
	ID_DatosER INT,
	ID_DatosBalance INT,
    CapitalTrabajoNeto DECIMAL(18,2),
    RazonCirculante DECIMAL(18,2),
    PruebaAcida DECIMAL(18,2),
    RotacionInventario DECIMAL(18,2),
    RotacionCuentasPorCobrar DECIMAL(18,2),
    PeriodoPromedioCobro DECIMAL(18,2),
    RotacionActivosFijos DECIMAL(18,2),
    RotacionActivosTotales DECIMAL(18,2),
    RazonDeudaTotal DECIMAL(18,2),
    RazonPasivoCapital DECIMAL(18,2),
    RazonRotacionInteresUtilidad DECIMAL(18,2),
    MUB DECIMAL(18,2),
    MUO DECIMAL(18,2),
    MUN DECIMAL(18,2),
    FOREIGN KEY (ID_CuentasDeRazones) REFERENCES CuentasRazones(ID_CuentasDeRazones),
    FOREIGN KEY (ID_DatosER) REFERENCES DatosERx(ID_DatosER),
    FOREIGN KEY (ID_DatosBalance) REFERENCES DatosBalance(ID_DatosBalance)
);


