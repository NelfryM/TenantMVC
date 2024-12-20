USE [TenantDB]
GO
/****** Object:  Table [dbo].[Apartments]    Script Date: 19/11/2024 2:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apartments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ElectricityConsumptions]    Script Date: 19/11/2024 2:01:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElectricityConsumptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdApartamento] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[CantidadKw] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ElectricityConsumptions]  WITH CHECK ADD  CONSTRAINT [FK_ElectricityConsumptions_Apartments] FOREIGN KEY([IdApartamento])
REFERENCES [dbo].[Apartments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ElectricityConsumptions] CHECK CONSTRAINT [FK_ElectricityConsumptions_Apartments]
GO
