USE [master]
GO
/****** Object:  Database [MuseoPictorico]    Script Date: 21/10/2021 21:35:29 ******/
CREATE DATABASE [MuseoPictorico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MuseoPictorico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MuseoPictorico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MuseoPictorico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MuseoPictorico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MuseoPictorico] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MuseoPictorico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MuseoPictorico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MuseoPictorico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MuseoPictorico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MuseoPictorico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MuseoPictorico] SET ARITHABORT OFF 
GO
ALTER DATABASE [MuseoPictorico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MuseoPictorico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MuseoPictorico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MuseoPictorico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MuseoPictorico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MuseoPictorico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MuseoPictorico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MuseoPictorico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MuseoPictorico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MuseoPictorico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MuseoPictorico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MuseoPictorico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MuseoPictorico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MuseoPictorico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MuseoPictorico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MuseoPictorico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MuseoPictorico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MuseoPictorico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MuseoPictorico] SET  MULTI_USER 
GO
ALTER DATABASE [MuseoPictorico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MuseoPictorico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MuseoPictorico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MuseoPictorico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MuseoPictorico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MuseoPictorico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MuseoPictorico] SET QUERY_STORE = OFF
GO
USE [MuseoPictorico]
GO
/****** Object:  Table [dbo].[DetalleExposicion]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleExposicion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdObra] [int] NULL,
	[LugarAsignado] [nvarchar](255) NULL,
	[IdExposicion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSede] [int] NULL,
	[Apellido] [nvarchar](255) NULL,
	[CodigoValidacion] [int] NULL,
	[Cuit] [float] NULL,
	[Dni] [float] NULL,
	[Domicilio] [nvarchar](255) NULL,
	[FechaIngreso] [datetime2](7) NULL,
	[FechaNacimiento] [datetime2](7) NULL,
	[Mail] [nvarchar](255) NULL,
	[NombreEmpleado] [nvarchar](255) NULL,
	[Sexo] [bit] NULL,
	[Telefono] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrada]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEntradaTarifa] [int] NULL,
	[IdSedeEntradaTarifa] [int] NULL,
	[FechaVenta] [datetime2](7) NULL,
	[HoraVenta] [bigint] NULL,
	[Monto] [float] NULL,
	[Numero] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exposicion]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exposicion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaFinReplanificada] [datetime2](7) NULL,
	[FechaHoraFin] [datetime2](7) NULL,
	[FechaInicioReplanificada] [datetime2](7) NULL,
	[HoraApertura] [datetime2](7) NULL,
	[HoraCierre] [datetime2](7) NULL,
	[Nombre] [nvarchar](255) NULL,
	[IdSede] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obra]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Alto] [float] NULL,
	[Ancho] [float] NULL,
	[CodigoSensor] [int] NULL,
	[Descripcion] [nvarchar](255) NULL,
	[DuracionExtendida] [int] NULL,
	[DuracionResumida] [int] NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[Nombre] [nvarchar](255) NULL,
	[Peso] [float] NULL,
	[Valuacion] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservaVisita]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaVisita](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleadoReservaVisita] [int] NULL,
	[IdSedeReservaVisita] [int] NULL,
	[CantidadAlumnos] [int] NULL,
	[CantidadAlumnosConfirmada] [int] NULL,
	[DuracionEstimada] [int] NULL,
	[FechaHoraCreacion] [datetime2](7) NULL,
	[FechaHoraReserva] [datetime2](7) NULL,
	[HoraFinReal] [datetime2](7) NULL,
	[HoraInicioReal] [datetime2](7) NULL,
	[NumeroReserva] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sede]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sede](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CantMaximaVisitantes] [int] NULL,
	[Domicilio] [nvarchar](255) NULL,
	[Horario] [datetime2](7) NULL,
	[Nombre] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sesion]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sesion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[FechaHoraFin] [datetime2](7) NULL,
	[FechaHoraInicio] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifa]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoDeEntrada] [int] NULL,
	[IdTipoVisita] [int] NULL,
	[FechaFinVigencia] [datetime2](7) NULL,
	[FechaInicioVigencia] [datetime2](7) NULL,
	[Monto] [float] NULL,
	[MontoAdicionalGuia] [float] NULL,
	[IdSede] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDeEntrada]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDeEntrada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoVisita]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVisita](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/10/2021 21:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NULL,
	[Caducidad] [datetime2](7) NULL,
	[Contraseña] [nvarchar](255) NOT NULL,
	[NombreUsuario] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleExposicion]  WITH CHECK ADD  CONSTRAINT [FK_F6A7C427] FOREIGN KEY([IdExposicion])
REFERENCES [dbo].[Exposicion] ([Id])
GO
ALTER TABLE [dbo].[DetalleExposicion] CHECK CONSTRAINT [FK_F6A7C427]
GO
ALTER TABLE [dbo].[DetalleExposicion]  WITH CHECK ADD  CONSTRAINT [FK_Obra] FOREIGN KEY([IdObra])
REFERENCES [dbo].[Obra] ([Id])
GO
ALTER TABLE [dbo].[DetalleExposicion] CHECK CONSTRAINT [FK_Obra]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Sede] FOREIGN KEY([IdSede])
REFERENCES [dbo].[Sede] ([Id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Sede]
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD  CONSTRAINT [FK_EntradaTarifa] FOREIGN KEY([IdEntradaTarifa])
REFERENCES [dbo].[Tarifa] ([Id])
GO
ALTER TABLE [dbo].[Entrada] CHECK CONSTRAINT [FK_EntradaTarifa]
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD  CONSTRAINT [FK_SedeEntradaTarifa] FOREIGN KEY([IdSedeEntradaTarifa])
REFERENCES [dbo].[Sede] ([Id])
GO
ALTER TABLE [dbo].[Entrada] CHECK CONSTRAINT [FK_SedeEntradaTarifa]
GO
ALTER TABLE [dbo].[Exposicion]  WITH CHECK ADD  CONSTRAINT [FK_ED1B4D21] FOREIGN KEY([IdSede])
REFERENCES [dbo].[Sede] ([Id])
GO
ALTER TABLE [dbo].[Exposicion] CHECK CONSTRAINT [FK_ED1B4D21]
GO
ALTER TABLE [dbo].[ReservaVisita]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoReservaVisita] FOREIGN KEY([IdEmpleadoReservaVisita])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[ReservaVisita] CHECK CONSTRAINT [FK_EmpleadoReservaVisita]
GO
ALTER TABLE [dbo].[ReservaVisita]  WITH CHECK ADD  CONSTRAINT [FK_SedeReservaVisita] FOREIGN KEY([IdSedeReservaVisita])
REFERENCES [dbo].[Sede] ([Id])
GO
ALTER TABLE [dbo].[ReservaVisita] CHECK CONSTRAINT [FK_SedeReservaVisita]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_Usuario]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_210AE93B] FOREIGN KEY([IdSede])
REFERENCES [dbo].[Sede] ([Id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_210AE93B]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_TipoDeEntrada] FOREIGN KEY([IdTipoDeEntrada])
REFERENCES [dbo].[TipoDeEntrada] ([Id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_TipoDeEntrada]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_TipoVisita] FOREIGN KEY([IdTipoVisita])
REFERENCES [dbo].[TipoVisita] ([Id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_TipoVisita]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Empleado]
GO
USE [master]
GO
ALTER DATABASE [MuseoPictorico] SET  READ_WRITE 
GO
