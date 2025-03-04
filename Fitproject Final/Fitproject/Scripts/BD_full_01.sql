USE [master]
GO
/****** Object:  Database [taller2]    Script Date: 26/10/2017 17:18:39 ******/
CREATE DATABASE [taller2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'taller2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\taller2.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'taller2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\taller2_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [taller2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [taller2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [taller2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [taller2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [taller2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [taller2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [taller2] SET ARITHABORT OFF 
GO
ALTER DATABASE [taller2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [taller2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [taller2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [taller2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [taller2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [taller2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [taller2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [taller2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [taller2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [taller2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [taller2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [taller2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [taller2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [taller2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [taller2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [taller2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [taller2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [taller2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [taller2] SET  MULTI_USER 
GO
ALTER DATABASE [taller2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [taller2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [taller2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [taller2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [taller2] SET DELAYED_DURABILITY = DISABLED 
GO
USE [taller2]
GO
/****** Object:  Table [dbo].[actividades]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[actividades](
	[id_actividad] [int] IDENTITY(1,1) NOT NULL,
	[de_actividad] [varchar](30) NULL,
	[duracion] [int] NULL,
	[pr_actividad] [decimal](10, 2) NULL,
	[sn_activo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empresa]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empresa](
	[id_empresa] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[direccion] [varchar](30) NULL,
	[telefono] [bigint] NULL,
	[us_login] [varchar](30) NULL,
	[us_pass] [varchar](30) NULL,
	[id_cuit] [varchar](30) NULL,
	[localidad] [varchar](30) NULL,
	[provincia] [varchar](30) NULL,
	[web] [varchar](30) NULL,
	[email] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[entrenadores]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[entrenadores](
	[id_entrenador] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[telefono] [bigint] NULL,
	[direccion] [varchar](30) NULL,
	[email] [varchar](50) NULL,
	[fe_nacimiento] [date] NULL,
	[sexo] [char](1) NULL,
	[sn_activo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_entrenador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[entrenadorxactividad]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entrenadorxactividad](
	[id_entrenador] [int] NOT NULL,
	[id_actividad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_entrenador] ASC,
	[id_actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[factura]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_socio] [int] NULL,
	[fe_factura] [date] NULL,
	[fe_vencimiento] [date] NULL,
	[id_tipo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[factura_detalle]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[factura_detalle](
	[id_factura] [int] NOT NULL,
	[id_facturadetalle] [int] IDENTITY(1,1) NOT NULL,
	[id_actividad] [int] NULL,
	[observacion] [varchar](50) NULL,
	[descuento] [decimal](7, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC,
	[id_facturadetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[socios]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[socios](
	[id_socio] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[telefono] [bigint] NULL,
	[direccion] [varchar](30) NULL,
	[email] [varchar](50) NULL,
	[fe_nacimiento] [date] NULL,
	[sexo] [char](1) NULL,
	[imagen] [image] NULL,
	[sn_activo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_socio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[socioxactividad]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[socioxactividad](
	[id_socio] [int] NOT NULL,
	[id_actividad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_socio] ASC,
	[id_actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_pago]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_pago](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[us_login] [varchar](30) NOT NULL,
	[us_pass] [varchar](30) NOT NULL,
	[us_tipo] [char](1) NOT NULL,
	[us_descrip] [varchar](20) NULL,
	[dni] [bigint] NULL,
	[apellido] [varchar](30) NULL,
	[nombre] [varchar](30) NULL,
	[telefono] [varchar](30) NULL,
	[direccion] [varchar](30) NULL,
	[email] [varchar](30) NULL,
	[sn_activo] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[pagos]    Script Date: 26/10/2017 17:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[pagos]
AS
SELECT        dbo.factura.id_factura, dbo.socios.dni, dbo.socios.apellido, dbo.socios.nombre, dbo.tipo_pago.descripcion, SUM(dbo.actividades.pr_actividad) AS importe, dbo.factura.fe_factura, dbo.factura.fe_vencimiento
FROM            dbo.factura INNER JOIN
                         dbo.factura_detalle ON dbo.factura.id_factura = dbo.factura_detalle.id_factura INNER JOIN
                         dbo.socios ON dbo.factura.id_socio = dbo.socios.id_socio INNER JOIN
                         dbo.actividades ON dbo.factura_detalle.id_actividad = dbo.actividades.id_actividad INNER JOIN
                         dbo.tipo_pago ON dbo.factura.id_tipo = dbo.tipo_pago.id_tipo
GROUP BY dbo.factura.id_factura, dbo.socios.dni, dbo.socios.apellido, dbo.socios.nombre, dbo.factura.fe_factura, dbo.factura.fe_vencimiento, dbo.tipo_pago.descripcion



GO
ALTER TABLE [dbo].[entrenadorxactividad]  WITH CHECK ADD FOREIGN KEY([id_actividad])
REFERENCES [dbo].[actividades] ([id_actividad])
GO
ALTER TABLE [dbo].[entrenadorxactividad]  WITH CHECK ADD FOREIGN KEY([id_entrenador])
REFERENCES [dbo].[entrenadores] ([id_entrenador])
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([id_socio])
REFERENCES [dbo].[socios] ([id_socio])
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipo_pago] ([id_tipo])
GO
ALTER TABLE [dbo].[factura_detalle]  WITH CHECK ADD FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([id_factura])
GO
ALTER TABLE [dbo].[socioxactividad]  WITH CHECK ADD FOREIGN KEY([id_actividad])
REFERENCES [dbo].[actividades] ([id_actividad])
GO
ALTER TABLE [dbo].[socioxactividad]  WITH CHECK ADD FOREIGN KEY([id_socio])
REFERENCES [dbo].[socios] ([id_socio])
GO
USE [master]
GO
ALTER DATABASE [taller2] SET  READ_WRITE 
GO
