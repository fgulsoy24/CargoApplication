USE [master]
GO

/****** Object:  Database [Cargo]    Script Date: 14.11.2021 18:10:37 ******/
CREATE DATABASE [Cargo];
GO
USE [Cargo]
GO

CREATE TABLE [dbo].[PriceDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NULL,
	[FromDimension] [int] NULL,
	[ToDimension] [int] NULL,
	[FromWeight] [int] NULL,
	[ToWeight] [int] NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (1, N'Cargo 4 You', 1000, 2001, NULL, NULL, 20)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (2, N'Cargo 4 You', 0, 1001, NULL, NULL, 10)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (3, N'Cargo 4 You', NULL, NULL, 2, 16, 18)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (4, N'Cargo 4 You', NULL, NULL, 0, 3, 15)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (5, N'Cargo 4 You', NULL, NULL, 15, 21, 35)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (6, N'Ship Faster', 0, 1001, NULL, NULL, 11.99)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (7, N'Ship Faster', 1000, 1701, NULL, NULL, 21.99)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (8, N'Ship Faster', NULL, NULL, 10, 16, 16.5)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (9, N'Ship Faster', NULL, NULL, 15, 26, 36.5)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (10, N'Malta Ship', 0, 1001, NULL, NULL, 9.5)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (11, N'Malta Ship', 1000, 2001, NULL, NULL, 19.5)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (12, N'Malta Ship', 2000, 5001, NULL, NULL, 48.5)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (13, N'Malta Ship', 5000, 9999999, NULL, NULL, 147.5)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (14, N'Malta Ship', NULL, NULL, 10, 21, 16.99)
GO
INSERT [dbo].[PriceDetails] ([Id], [CompanyName], [FromDimension], [ToDimension], [FromWeight], [ToWeight], [Price]) VALUES (15, N'Malta Ship', NULL, NULL, 20, 31, 33.99)
GO

