USE [Sport]
GO

/****** Object:  Table [dbo].[Persone]    Script Date: 30/01/2026 10:51:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Persone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Cognome] [nvarchar](100) NOT NULL,
	[CodiceFiscale] [nvarchar](20) NOT NULL,
	[DataNascita] [datetime] NOT NULL,
	[IdSport] [int] NULL,
	[InfoContatto] [nvarchar](50) NULL,
 CONSTRAINT [PK_Persone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Persone]  WITH CHECK ADD  CONSTRAINT [FK_Persone_Sport] FOREIGN KEY([IdSport])
REFERENCES [dbo].[Sport] ([Id])
GO

ALTER TABLE [dbo].[Persone] CHECK CONSTRAINT [FK_Persone_Sport]
GO
