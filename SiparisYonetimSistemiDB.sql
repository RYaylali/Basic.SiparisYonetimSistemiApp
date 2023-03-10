USE [SiparisYonetimDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20.02.2023 12:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 20.02.2023 12:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[ID] [uniqueidentifier] NOT NULL,
	[CompanyName] [nvarchar](max) NOT NULL,
	[ApprovalStatus] [int] NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 20.02.2023 12:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [uniqueidentifier] NOT NULL,
	[CustomerName] [nvarchar](max) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[ProductID] [uniqueidentifier] NULL,
	[CompanyID] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20.02.2023 12:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [uniqueidentifier] NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[Quantity] [smallint] NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[CompanyID] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230218182902_mig_1', N'6.0.13')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230219200254_mig_2', N'6.0.13')
GO
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'b0622a80-fb2f-4a5a-3ecc-08db12b8e335', N'YAYLALI', 2, CAST(N'08:30:00' AS Time), CAST(N'23:59:00' AS Time), CAST(N'2023-02-19T23:35:48.3777914' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'7a7daff5-8888-4ac0-a23c-08db12b98943', N'YANKAYIŞ', 3, CAST(N'16:30:00' AS Time), CAST(N'23:59:00' AS Time), CAST(N'2023-02-19T23:40:28.3415628' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'3e444ff9-81c4-4b8e-a23d-08db12b98943', N'RAMAZAN', 1, CAST(N'08:30:00' AS Time), CAST(N'23:59:00' AS Time), CAST(N'2023-02-19T23:42:23.5562113' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'5019b603-d9c6-4337-a23e-08db12b98943', N'FATİH', 2, CAST(N'16:30:00' AS Time), CAST(N'20:00:00' AS Time), CAST(N'2023-02-19T23:43:08.3077341' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'5c37381a-b86c-4f6b-a23f-08db12b98943', N'AHMET', 1, CAST(N'08:30:00' AS Time), CAST(N'20:00:00' AS Time), CAST(N'2023-02-19T23:43:29.2979338' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'a36b346b-f49a-41c2-a240-08db12b98943', N'EMRE', 3, CAST(N'08:30:00' AS Time), CAST(N'23:59:00' AS Time), CAST(N'2023-02-19T23:44:08.2551605' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'0b9692f0-16fd-46d9-a09f-08db13201b9d', N'Hatice', 1, CAST(N'08:30:00' AS Time), CAST(N'16:30:00' AS Time), CAST(N'2023-02-20T11:54:42.4883755' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'f228702a-b5be-4e97-d98d-08db13247f2d', N'İlhan', 3, CAST(N'09:10:00' AS Time), CAST(N'16:30:00' AS Time), CAST(N'2023-02-20T12:26:05.2821094' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Companies] ([ID], [CompanyName], [ApprovalStatus], [StartTime], [EndTime], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'1b58b793-37f4-487f-af01-08db1325abf2', N'Emine', 2, CAST(N'06:00:00' AS Time), CAST(N'16:00:00' AS Time), CAST(N'2023-02-20T12:34:30.6157661' AS DateTime2), NULL, NULL, 0)
GO
INSERT [dbo].[Orders] ([ID], [CustomerName], [OrderDate], [ProductID], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'042cd0ce-0826-4f70-788a-08db12bb502d', N'emre', CAST(N'2023-02-19T23:53:08.3228879' AS DateTime2), N'fffbdbcc-3554-4482-b5dd-08db12ba6859', NULL, CAST(N'2023-02-19T23:53:11.6044817' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Orders] ([ID], [CustomerName], [OrderDate], [ProductID], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'25c41aaf-57c5-4686-3c5f-08db13210bab', N'İsa', CAST(N'2023-02-20T12:01:25.1799363' AS DateTime2), N'f2275b2e-39da-40c0-e55b-08db1320e1c2', NULL, CAST(N'2023-02-20T12:01:25.3628508' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Orders] ([ID], [CustomerName], [OrderDate], [ProductID], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'02829049-38c1-44fd-1fba-08db13264f6c', N'Hazel', CAST(N'2023-02-20T12:39:06.4505662' AS DateTime2), N'a98d2ca7-b696-44ba-d6b0-08db13261b1f', NULL, CAST(N'2023-02-20T12:39:06.5140569' AS DateTime2), NULL, NULL, 0)
GO
INSERT [dbo].[Products] ([ID], [ProductName], [Quantity], [Price], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'77f2145a-c0e2-4178-b5db-08db12ba6859', N'Telefon', 1000, CAST(5000.00 AS Decimal(18, 2)), N'b0622a80-fb2f-4a5a-3ecc-08db12b8e335', CAST(N'2023-02-19T23:46:42.6939569' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Products] ([ID], [ProductName], [Quantity], [Price], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'2d5e2744-2563-4350-b5dc-08db12ba6859', N'Araba', 500, CAST(50000.00 AS Decimal(18, 2)), N'7a7daff5-8888-4ac0-a23c-08db12b98943', CAST(N'2023-02-19T23:47:18.9350159' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Products] ([ID], [ProductName], [Quantity], [Price], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'fffbdbcc-3554-4482-b5dd-08db12ba6859', N'Ev', 10, CAST(500000.00 AS Decimal(18, 2)), N'3e444ff9-81c4-4b8e-a23d-08db12b98943', CAST(N'2023-02-19T23:48:07.3324780' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Products] ([ID], [ProductName], [Quantity], [Price], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'f868fe6a-5047-4342-e709-08db12bc5fdc', N'Bilgisayar', 550, CAST(50.00 AS Decimal(18, 2)), N'5c37381a-b86c-4f6b-a23f-08db12b98943', CAST(N'2023-02-20T00:00:47.3575200' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Products] ([ID], [ProductName], [Quantity], [Price], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'f2275b2e-39da-40c0-e55b-08db1320e1c2', N'Kırtasiye', 5020, CAST(230.00 AS Decimal(18, 2)), N'0b9692f0-16fd-46d9-a09f-08db13201b9d', CAST(N'2023-02-20T12:00:15.0540805' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Products] ([ID], [ProductName], [Quantity], [Price], [CompanyID], [CreatedDate], [UpdatedDate], [DeletedDate], [Status]) VALUES (N'a98d2ca7-b696-44ba-d6b0-08db13261b1f', N'Meyve', 789, CAST(230.00 AS Decimal(18, 2)), N'5c37381a-b86c-4f6b-a23f-08db12b98943', CAST(N'2023-02-20T12:37:38.7754381' AS DateTime2), NULL, NULL, 0)
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [CompanyID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Companies_CompanyID] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Companies_CompanyID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products_ProductID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Companies_CompanyID] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Companies_CompanyID]
GO
