USE [master]
GO
/****** Object:  Database [parque]    Script Date: 27/04/2024 09:46:03 ******/
CREATE DATABASE [parque]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'parque', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\parque.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'parque_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\parque_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [parque] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [parque].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [parque] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [parque] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [parque] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [parque] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [parque] SET ARITHABORT OFF 
GO
ALTER DATABASE [parque] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [parque] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [parque] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [parque] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [parque] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [parque] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [parque] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [parque] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [parque] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [parque] SET  ENABLE_BROKER 
GO
ALTER DATABASE [parque] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [parque] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [parque] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [parque] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [parque] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [parque] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [parque] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [parque] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [parque] SET  MULTI_USER 
GO
ALTER DATABASE [parque] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [parque] SET DB_CHAINING OFF 
GO
ALTER DATABASE [parque] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [parque] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [parque] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [parque] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [parque] SET QUERY_STORE = ON
GO
ALTER DATABASE [parque] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [parque]
GO
/****** Object:  Table [dbo].[avaliacao]    Script Date: 27/04/2024 09:46:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[avaliacao](
	[id_avaliacao] [int] IDENTITY(1,1) NOT NULL,
	[data_visita] [date] NULL,
	[acompanhado] [bit] NULL,
	[jaVisitouPT] [bit] NULL,
	[quantas] [varchar](2) NULL,
	[jaVisitouOutros] [bit] NULL,
	[atendimento] [varchar](7) NULL,
	[indicar] [varchar](2) NULL,
	[agendado] [bit] NULL,
	[salaExpo] [varchar](7) NULL,
	[video] [varchar](7) NULL,
	[palestra] [varchar](7) NULL,
	[trilhaPas] [varchar](7) NULL,
	[caminhosGra] [varchar](7) NULL,
	[refugioVale] [varchar](7) NULL,
	[passadorMata] [varchar](7) NULL,
	[passeioBel] [varchar](7) NULL,
	[trilhoTei] [varchar](7) NULL,
	[estacionamento] [varchar](11) NULL,
	[limpezaCentro] [varchar](11) NULL,
	[atendEspacoConv] [varchar](11) NULL,
	[tranquPass] [varchar](11) NULL,
	[condicaoTrilhas] [varchar](11) NULL,
	[conservacao] [varchar](11) NULL,
	[Guia] [varchar](11) NULL,
	[FariaVoltar] [varchar](200) NULL,
	[id_monitor] [int] NULL,
 CONSTRAINT [PK_id_avaliacao] PRIMARY KEY CLUSTERED 
(
	[id_avaliacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cidade]    Script Date: 27/04/2024 09:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cidade](
	[id] [int] NOT NULL,
	[nome] [varchar](120) NULL,
	[uf] [int] NULL,
	[ibge] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 27/04/2024 09:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[id] [int] NOT NULL,
	[nome] [varchar](75) NULL,
	[uf] [varchar](2) NULL,
	[ibge] [int] NULL,
	[pais] [int] NULL,
	[ddd] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monitor]    Script Date: 27/04/2024 09:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monitor](
	[id_monitor] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[email] [varchar](100) NULL,
	[telefone] [varchar](20) NULL,
 CONSTRAINT [PK_id_monitor] PRIMARY KEY CLUSTERED 
(
	[id_monitor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pais]    Script Date: 27/04/2024 09:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pais](
	[id] [int] NOT NULL,
	[nome] [varchar](60) NULL,
	[nome_pt] [varchar](60) NULL,
	[sigla] [varchar](2) NULL,
	[bacen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 27/04/2024 09:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[nome_user] [varchar](50) NOT NULL,
	[senha_user] [varchar](50) NOT NULL,
 CONSTRAINT [PK_id_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visita]    Script Date: 27/04/2024 09:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visita](
	[id_visita] [int] IDENTITY(1,1) NOT NULL,
	[data_visita] [date] NOT NULL,
	[turno] [varchar](10) NOT NULL,
	[neces_esp] [bit] NULL,
	[transporte] [varchar](50) NULL,
	[perfil_grupo] [varchar](50) NULL,
	[agendado] [bit] NULL,
	[responsavel_grupo] [varchar](100) NOT NULL,
	[objetivo] [varchar](100) NULL,
	[id_monitor] [int] NULL,
 CONSTRAINT [PK_id_visita] PRIMARY KEY CLUSTERED 
(
	[id_visita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visitacao]    Script Date: 27/04/2024 09:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visitacao](
	[id_visitacao] [int] IDENTITY(1,1) NOT NULL,
	[id_visita] [int] NOT NULL,
	[id_visitante] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visitante]    Script Date: 27/04/2024 09:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visitante](
	[id_visitante] [int] IDENTITY(1,1) NOT NULL,
	[nome_vis] [varchar](50) NOT NULL,
	[data_nasc] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[telefone] [varchar](20) NULL,
	[como_soube] [varchar](100) NULL,
	[id_cidade] [int] NULL,
	[id_pais] [int] NULL,
 CONSTRAINT [PK_id_visitante] PRIMARY KEY CLUSTERED 
(
	[id_visitante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cidade] ADD  DEFAULT (NULL) FOR [nome]
GO
ALTER TABLE [dbo].[cidade] ADD  DEFAULT (NULL) FOR [uf]
GO
ALTER TABLE [dbo].[cidade] ADD  DEFAULT (NULL) FOR [ibge]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [nome]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [uf]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [ibge]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [pais]
GO
ALTER TABLE [dbo].[estado] ADD  DEFAULT (NULL) FOR [ddd]
GO
ALTER TABLE [dbo].[pais] ADD  DEFAULT (NULL) FOR [nome]
GO
ALTER TABLE [dbo].[pais] ADD  DEFAULT (NULL) FOR [nome_pt]
GO
ALTER TABLE [dbo].[pais] ADD  DEFAULT (NULL) FOR [sigla]
GO
ALTER TABLE [dbo].[pais] ADD  DEFAULT (NULL) FOR [bacen]
GO
ALTER TABLE [dbo].[avaliacao]  WITH CHECK ADD  CONSTRAINT [FK_id_monitor] FOREIGN KEY([id_monitor])
REFERENCES [dbo].[monitor] ([id_monitor])
GO
ALTER TABLE [dbo].[avaliacao] CHECK CONSTRAINT [FK_id_monitor]
GO
ALTER TABLE [dbo].[visita]  WITH CHECK ADD  CONSTRAINT [FK_id_mon] FOREIGN KEY([id_monitor])
REFERENCES [dbo].[monitor] ([id_monitor])
GO
ALTER TABLE [dbo].[visita] CHECK CONSTRAINT [FK_id_mon]
GO
ALTER TABLE [dbo].[visitacao]  WITH CHECK ADD  CONSTRAINT [FK_id_visita] FOREIGN KEY([id_visita])
REFERENCES [dbo].[visita] ([id_visita])
GO
ALTER TABLE [dbo].[visitacao] CHECK CONSTRAINT [FK_id_visita]
GO
ALTER TABLE [dbo].[visitacao]  WITH CHECK ADD  CONSTRAINT [FK_id_visitante] FOREIGN KEY([id_visitante])
REFERENCES [dbo].[visitante] ([id_visitante])
GO
ALTER TABLE [dbo].[visitacao] CHECK CONSTRAINT [FK_id_visitante]
GO
ALTER TABLE [dbo].[visitante]  WITH CHECK ADD  CONSTRAINT [FK_id_cidade] FOREIGN KEY([id_cidade])
REFERENCES [dbo].[cidade] ([id])
GO
ALTER TABLE [dbo].[visitante] CHECK CONSTRAINT [FK_id_cidade]
GO
ALTER TABLE [dbo].[visitante]  WITH CHECK ADD  CONSTRAINT [FK_id_pais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[pais] ([id])
GO
ALTER TABLE [dbo].[visitante] CHECK CONSTRAINT [FK_id_pais]
GO
USE [master]
GO
ALTER DATABASE [parque] SET  READ_WRITE 
GO
