USE [GamePlatform]
GO
/****** Object:  Table [dbo].[Order_ExtraPackage]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_ExtraPackage](
	[PurchaseID] [int] IDENTITY(1,11000) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[CouponID] [int] NULL,
	[OrderExtraPackageID] [int] NOT NULL,
	[PaymentDate] [date] NOT NULL,
	[UploadOnDesktop] [char](3) NOT NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Order_ExtraPackage] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC,
	[CustomerID] ASC,
	[OrderExtraPackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[BuyTable]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BuyTable]
AS
SELECT *
FROM Order_ExtraPackage
GO
/****** Object:  Table [dbo].[LanguageSupport_Audio]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageSupport_Audio](
	[AudioLanguageID] [int] NOT NULL,
	[GameID] [int] NOT NULL,
 CONSTRAINT [PK_LanguageSupport_Audio] PRIMARY KEY CLUSTERED 
(
	[AudioLanguageID] ASC,
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LanguageSupport_Texts]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageSupport_Texts](
	[TextLanguageID] [int] NOT NULL,
	[GameID] [int] NOT NULL,
 CONSTRAINT [PK_LanguageSupport_Texts] PRIMARY KEY CLUSTERED 
(
	[TextLanguageID] ASC,
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[LanguagesSupports]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LanguagesSupports]
AS
SELECT la.GameID,la.AudioLanguageID, lt.TextLanguageID
FROM LanguageSupport_Audio la, LanguageSupport_Texts lt
where lt.GameID=la.GameID
GO
/****** Object:  Table [dbo].[Registration_Game]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration_Game](
	[GameID] [int] IDENTITY(1,1) NOT NULL,
	[GameName] [varchar](50) NOT NULL,
	[ReleaseDate] [date] NULL,
	[AgeLimit] [int] NULL,
	[DeveloperID] [int] NOT NULL,
	[PublisherID] [int] NOT NULL,
	[Explanation] [varchar](400) NULL,
	[AvaragePoint] [float] NULL,
	[OprSystem] [varchar](50) NULL,
	[CPU] [varchar](50) NULL,
	[Storage] [varchar](10) NULL,
	[Graphics] [varchar](50) NULL,
	[Memory] [varchar](10) NULL,
 CONSTRAINT [PK_Registration_Game] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Language]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Language](
	[LanguageID] [int] IDENTITY(6000,1) NOT NULL,
	[LanguageName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Type_Language] PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[LanguagesS]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LanguagesS]
AS
SELECT la.GameID, rg.GameName, la.AudioLanguageID, tl.LanguageName
FROM LanguageSupport_Audio la, LanguageSupport_Texts lt, Registration_Game rg, Type_Language tl
where lt.GameID=la.GameID and rg.GameID=la.GameID and tl.LanguageID=la.AudioLanguageID and lt.TextLanguageID = tl.LanguageID
GO
/****** Object:  Table [dbo].[Game_Genres]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game_Genres](
	[GameID] [int] NOT NULL,
	[GenreID] [int] NOT NULL,
 CONSTRAINT [PK_Game_Genres] PRIMARY KEY CLUSTERED 
(
	[GameID] ASC,
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Genres]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Genres](
	[GenreID] [int] IDENTITY(1000,1) NOT NULL,
	[GrenreType] [varchar](20) NULL,
 CONSTRAINT [PK_Type_Genres] PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GameAndItsGenres]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[GameAndItsGenres]
AS
SELECT gg.GameID, tg.GrenreType, gg.GenreID
FROM Type_Genres tg
INNER JOIN Game_Genres gg
ON tg.GenreID= gg.GenreID
GO
/****** Object:  Table [dbo].[Buy_ExtraPackage]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buy_ExtraPackage](
	[OrderID] [int] IDENTITY(5000,1) NOT NULL,
	[GameID] [int] NOT NULL,
	[ExtraPackageName] [char](40) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Order_ExtraPackage_1] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buy_Game]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buy_Game](
	[OrderID] [int] IDENTITY(4000,1) NOT NULL,
	[GameID] [int] NOT NULL,
	[PackageID] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Order_Game] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Wishlist]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Wishlist](
	[CustomerID] [int] NOT NULL,
	[OrderExtraPackageID] [int] NULL,
	[OrderGameID] [int] NOT NULL,
 CONSTRAINT [PK_Customer_Wishlist_1] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC,
	[OrderGameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Game]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Game](
	[PurchaseID] [int] IDENTITY(12000,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[CouponID] [int] NULL,
	[OrderGameID] [int] NOT NULL,
	[PaymentDate] [date] NOT NULL,
	[UploadOnDesktop] [char](1) NOT NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Customer_Purchase_1] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC,
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration_Company]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration_Company](
	[CompanyID] [int] IDENTITY(10000,1) NOT NULL,
	[CompanyName] [varchar](30) NOT NULL,
	[Location] [varchar](10) NULL,
 CONSTRAINT [PK_Registration_Company_1] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration_Coupon]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration_Coupon](
	[CouponID] [int] IDENTITY(3000,1) NOT NULL,
	[CouponName] [char](20) NOT NULL,
	[DiscountPercentage] [int] NULL,
	[DiscountFee] [money] NULL,
	[Explanation] [char](50) NULL,
 CONSTRAINT [PK_Registration_Coupon] PRIMARY KEY CLUSTERED 
(
	[CouponID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration_Customer]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration_Customer](
	[CustomerID] [int] IDENTITY(2000,1) NOT NULL,
	[CustomerNickname] [varchar](20) NOT NULL,
	[NameSurname] [varchar](30) NOT NULL,
	[Age] [int] NOT NULL,
	[RegisterDate] [date] NULL,
	[Email] [varchar](40) NULL,
	[Password] [varchar](20) NOT NULL,
	[Location] [varchar](10) NULL,
	[Address] [varchar](35) NULL,
	[TelNumber] [varchar](15) NULL,
 CONSTRAINT [PK_Registration_Customer_1] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Package]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Package](
	[PackageID] [int] IDENTITY(9000,1) NOT NULL,
	[PackageName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Type_Package] PRIMARY KEY CLUSTERED 
(
	[PackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_Player]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_Player](
	[PlayerTypeID] [int] IDENTITY(8000,1) NOT NULL,
	[GameID] [int] NOT NULL,
	[Single] [varchar](3) NOT NULL,
	[Multiplayer] [varchar](3) NOT NULL,
	[Controller] [varchar](3) NOT NULL,
	[Co-Op] [varchar](3) NOT NULL,
	[VR] [varchar](3) NOT NULL,
 CONSTRAINT [PK_Type_Player] PRIMARY KEY CLUSTERED 
(
	[PlayerTypeID] ASC,
	[GameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Buy_ExtraPackage] ON 

INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5000, 4, N'Standart Edition                        ', 150.0000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5001, 3, N'Extraordinary Package                   ', 399.9900)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5002, 7, N'Now Facetime                            ', 99.9900)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5003, 4, N'Support                                 ', 59.9900)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5004, 3, N'Championship                            ', 199.9900)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5005, 8, N'Verdun Supporter Edition                ', 10.5000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5006, 11, N'Season Pass                             ', 209.0000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5007, 11, N'Legacy of the First Blade               ', 128.9900)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5008, 11, N'The Fate Of Atlantis                    ', 128.9900)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5009, 15, N'Werewolf Pack                           ', 153.3100)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5010, 15, N'Road Hog XL Starter Pack                ', 38.2700)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5011, 15, N'x Monstercat Vol. 7                     ', 38.2700)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5012, 16, N'Airship Skins                           ', 3.0000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5013, 16, N'Polus Skins                             ', 3.0000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5014, 16, N'Mini CrewMate Bundle                    ', 5.0000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5015, 18, N'Game of the Year Upgrade                ', 71.0000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5016, 19, N'Seven Deadly Sins Act 5: Gluttony       ', 14.0000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5017, 19, N'Seven Deadly Sins Act 4: Lust           ', 14.0000)
INSERT [dbo].[Buy_ExtraPackage] ([OrderID], [GameID], [ExtraPackageName], [Price]) VALUES (5018, 19, N'Seven Deadly Sins Act 3: Sloth          ', 14.0000)
SET IDENTITY_INSERT [dbo].[Buy_ExtraPackage] OFF
GO
SET IDENTITY_INSERT [dbo].[Buy_Game] ON 

INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4000, 4, 9000, 299.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4001, 3, 9003, 399.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4002, 7, 9000, 289.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4003, 5, 9001, 199.9900)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4004, 4, 9003, 449.9900)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4005, 8, 9005, 169.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4006, 9, 9000, 32.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4007, 10, 9000, 50.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4008, 11, 9000, 75.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4009, 12, 9000, 269.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4010, 12, 9003, 335.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4011, 12, 9004, 509.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4012, 12, 9006, 589.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4014, 15, 9000, 289.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4015, 15, 9004, 429.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4016, 15, 9003, 359.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4017, 15, 9006, 539.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4019, 16, 9000, 249.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4020, 17, 9000, 0.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4021, 18, 9000, 8.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4022, 18, 9007, 28.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4023, 18, 9008, 17.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4024, 19, 9000, 419.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4026, 19, 9004, 599.9900)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4027, 19, 9006, 799.9900)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4028, 20, 9000, 260.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4029, 21, 9000, 260.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4030, 21, 9003, 390.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4033, 22, 9000, 49.0000)
INSERT [dbo].[Buy_Game] ([OrderID], [GameID], [PackageID], [Price]) VALUES (4037, 24, 9000, 49.0000)
SET IDENTITY_INSERT [dbo].[Buy_Game] OFF
GO
INSERT [dbo].[Customer_Wishlist] ([CustomerID], [OrderExtraPackageID], [OrderGameID]) VALUES (2006, 5006, 4015)
GO
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (3, 1001)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (3, 1003)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (4, 1001)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (4, 1002)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (4, 1012)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (4, 1025)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (5, 1002)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (5, 1003)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (5, 1007)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (5, 1009)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (6, 1003)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (7, 1020)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (7, 1021)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (8, 1004)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (9, 1009)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (9, 1010)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (9, 1011)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (10, 1013)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (10, 1017)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (11, 1001)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (12, 1005)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (12, 1006)
INSERT [dbo].[Game_Genres] ([GameID], [GenreID]) VALUES (12, 1007)
GO
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 6)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 7)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 9)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 10)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 15)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 16)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 17)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 18)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 19)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 20)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6000, 24)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6001, 7)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6001, 9)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6001, 12)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6001, 15)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6001, 16)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6001, 17)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6002, 9)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6003, 9)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6004, 9)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6004, 11)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6005, 12)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6007, 4)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6007, 22)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6008, 8)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6008, 9)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6009, 8)
INSERT [dbo].[LanguageSupport_Audio] ([AudioLanguageID], [GameID]) VALUES (6009, 21)
GO
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 3)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 4)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 6)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 7)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 9)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 10)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 11)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 12)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 15)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 16)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 17)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 18)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 19)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 20)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 21)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 22)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6000, 24)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6001, 3)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6001, 4)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6001, 7)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6001, 9)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6001, 12)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6001, 15)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6001, 16)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6001, 17)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6002, 3)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6002, 9)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6003, 3)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6003, 9)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6004, 9)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6007, 4)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6008, 8)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6008, 9)
INSERT [dbo].[LanguageSupport_Texts] ([TextLanguageID], [GameID]) VALUES (6009, 8)
GO
SET IDENTITY_INSERT [dbo].[Order_ExtraPackage] ON 

INSERT [dbo].[Order_ExtraPackage] ([PurchaseID], [CustomerID], [CouponID], [OrderExtraPackageID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (11001, 2006, NULL, 5001, CAST(N'2021-09-09' AS Date), N'N  ', 20.0000)
INSERT [dbo].[Order_ExtraPackage] ([PurchaseID], [CustomerID], [CouponID], [OrderExtraPackageID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (22001, 2009, NULL, 5007, CAST(N'2021-08-30' AS Date), N'Y  ', 20.0000)
INSERT [dbo].[Order_ExtraPackage] ([PurchaseID], [CustomerID], [CouponID], [OrderExtraPackageID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (44001, 2007, 3000, 5012, CAST(N'2021-08-30' AS Date), N'N  ', 50.0000)
INSERT [dbo].[Order_ExtraPackage] ([PurchaseID], [CustomerID], [CouponID], [OrderExtraPackageID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (55001, 2010, 3002, 5010, CAST(N'2020-09-30' AS Date), N'N  ', 60.0000)
INSERT [dbo].[Order_ExtraPackage] ([PurchaseID], [CustomerID], [CouponID], [OrderExtraPackageID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (66001, 2006, NULL, 5007, CAST(N'2021-09-14' AS Date), N'N  ', 68.9900)
INSERT [dbo].[Order_ExtraPackage] ([PurchaseID], [CustomerID], [CouponID], [OrderExtraPackageID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (77001, 2006, 3000, 5008, CAST(N'2021-09-14' AS Date), N'N  ', 64.4950)
SET IDENTITY_INSERT [dbo].[Order_ExtraPackage] OFF
GO
SET IDENTITY_INSERT [dbo].[Order_Game] ON 

INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12000, 2006, NULL, 4000, CAST(N'2021-09-08' AS Date), N'N', 50.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12001, 2006, 3000, 4015, CAST(N'2021-08-06' AS Date), N'Y', 500.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12002, 2007, NULL, 4000, CAST(N'2020-09-10' AS Date), N'Y', 380.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12005, 2008, 3002, 4024, CAST(N'2020-03-18' AS Date), N'Y', 400.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12010, 2009, NULL, 4016, CAST(N'2020-12-22' AS Date), N'N', 200.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12012, 2009, 3000, 4009, CAST(N'2021-01-01' AS Date), N'N', 400.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12013, 2009, NULL, 4000, CAST(N'2021-01-01' AS Date), N'Y', 150.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12014, 2009, NULL, 4019, CAST(N'2020-05-28' AS Date), N'N', 70.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12015, 2013, NULL, 4015, CAST(N'2021-09-08' AS Date), N'N', 120.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12016, 2012, 3003, 4006, CAST(N'2021-10-05' AS Date), N'N', 260.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12017, 2010, 3000, 4007, CAST(N'2020-12-08' AS Date), N'Y', 170.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12018, 2010, 3002, 4020, CAST(N'2020-12-08' AS Date), N'N', 25.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12019, 2006, NULL, 4008, CAST(N'2021-09-13' AS Date), N'N', 75.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12020, 2006, NULL, 4009, CAST(N'2021-09-13' AS Date), N'N', 269.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12021, 2006, NULL, 4002, CAST(N'2021-09-13' AS Date), N'N', 229.0000)
INSERT [dbo].[Order_Game] ([PurchaseID], [CustomerID], [CouponID], [OrderGameID], [PaymentDate], [UploadOnDesktop], [Price]) VALUES (12022, 2006, 3002, 4009, CAST(N'2021-09-14' AS Date), N'N', 209.0000)
SET IDENTITY_INSERT [dbo].[Order_Game] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration_Company] ON 

INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10000, N'Electronic Arts               ', N'USA')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10001, N'Deep Silver Volition          ', N'USA')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10002, N'Pysonix LLC                   ', N'ENGLAND')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10003, N'UbiSoft                       ', N'GERMANY')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10004, N'Peak Games                    ', N'GERMANY')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10005, N'Rockstar Games                ', N'GERMANY')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10006, N'M2H                           ', N'USA')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10007, N'Blackmill Games               ', N'TURKEY')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10008, N'Hinterland Studio Inc.        ', N'INDIA')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10009, N'CD PROJEKT RED                ', N'CHINA')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10010, N'Innersloth                    ', N'USA')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10011, N'DICE                          ', N'JAPAN')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10012, N'IO Interactive A/S            ', N'RUSSIA')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10013, N'Hangar 13                     ', N'RUSSIA')
INSERT [dbo].[Registration_Company] ([CompanyID], [CompanyName], [Location]) VALUES (10014, N'2K                            ', N'USA')
SET IDENTITY_INSERT [dbo].[Registration_Company] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration_Coupon] ON 

INSERT [dbo].[Registration_Coupon] ([CouponID], [CouponName], [DiscountPercentage], [DiscountFee], [Explanation]) VALUES (3000, N'Special Friday      ', 50, NULL, N'Cuma indirim                                      ')
INSERT [dbo].[Registration_Coupon] ([CouponID], [CouponName], [DiscountPercentage], [DiscountFee], [Explanation]) VALUES (3002, N'Special Month       ', NULL, 60.0000, N'Bu ay 100 tl üzeri alışverişlerde geçerli         ')
INSERT [dbo].[Registration_Coupon] ([CouponID], [CouponName], [DiscountPercentage], [DiscountFee], [Explanation]) VALUES (3003, N'Welcome             ', 30, NULL, N'İlk oyunda indirim                                ')
SET IDENTITY_INSERT [dbo].[Registration_Coupon] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration_Customer] ON 

INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2006, N'seyma', N'Şeyma Aydın', 22, CAST(N'2020-01-06' AS Date), N'ba@gmail.com                            ', N'1', N'USA       ', N'1th street                         ', N'(123)555-0101  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2007, N'gracatocant         ', N'Gratacos Solsona Antonio      ', 41, CAST(N'2017-05-21' AS Date), N'gas@hotmail.com                         ', N'5550100gsa          ', N'England   ', N'101 Candy Rd.                      ', N'(010)805-0468  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2008, N'garretvargas        ', N'Garrett Vargas                ', 10, CAST(N'2021-10-10' AS Date), N'garrettvar@yahoo.com                    ', N'12345garrett        ', N'Brasil    ', N'1061 Burskrik Avenue               ', N'(000)0856-4588 ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2009, N'reuben123           ', N'Reuben D''sa                   ', 19, CAST(N'2020-09-27' AS Date), N'reuben123@gmail.com                     ', N'reubenreuben        ', N'India     ', N'1064 Slow Creek Road               ', N'(001)057-8965  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2010, N'karankhanna1        ', N'Karan Khanna                  ', 17, CAST(N'2019-12-25' AS Date), N'karankara@hotmail.com                   ', N'karankarakara       ', N'England   ', N'1144 Paradise Dt.                  ', N'(010)555-0107  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2011, N'symydn              ', N'Seyma Aydın                   ', 22, CAST(N'2018-02-14' AS Date), N'symydnnn@gmail.com                      ', N'symydn1234          ', N'Turkey    ', N'Tatlıkuyu mah. Kocaeli Gebze       ', N'(539)877-4174  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2012, N'fransooo            ', N'François Ajenstat             ', 24, CAST(N'2015-05-30' AS Date), N'frn@yahoo.com                           ', N'12378952            ', N'USA       ', N'108 Lakeside Court                 ', N'(123)589-4584  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2013, N'mcbayhan            ', N'Mehmet Cemil Bayhan           ', 20, CAST(N'2021-09-08' AS Date), N'byhncemil@hotmail.com                   ', N'1254879by           ', N'Turkey    ', N'1332 sok. İstanbul                 ', N'(537)227-5246  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2017, N'bsry                ', N'Busra Aydın                   ', 22, CAST(N'2020-10-13' AS Date), N'bsrydn@gmail.com                        ', N'erguavn1223556      ', N'Turkey    ', N'Tatlıkuyu mah. Kocaeli Gebze       ', N'(539)877-4256  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2018, N'nckcn               ', N'Nick Rimando                  ', 34, CAST(N'2018-09-08' AS Date), N'NickRimando@hotmail.com                 ', N'1234252nick         ', N'India     ', N'Abc street                         ', N'(001)789-8546  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2019, N'braddavis           ', N'Brad Davis                    ', 32, CAST(N'2017-11-26' AS Date), N'brad@yahoo.com                          ', N'hsadhfksdj          ', N'Germany   ', N'Deutchland street                  ', N'(009)788-6648  ')
INSERT [dbo].[Registration_Customer] ([CustomerID], [CustomerNickname], [NameSurname], [Age], [RegisterDate], [Email], [Password], [Location], [Address], [TelNumber]) VALUES (2021, N'sym', N'Seyma Aksu', 22, CAST(N'2020-01-06' AS Date), N'sym@yahoo.com', N'1', N'Turkey', N'1th street                         ', N'(059) 022-3556')
SET IDENTITY_INSERT [dbo].[Registration_Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration_Game] ON 

INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (3, N'FIFA21                                  ', CAST(N'2012-02-11' AS Date), 13, 10000, 10000, N'Harika futbolcularla yeni maceralara katıl. Mükemel takımını hemen oluştur.                                                                                                                                                                                                                                 ', 89, N'Windows 7 64-bit, Windows 8.1 64-bit or Windows 10', N'Intel i5-3550 @ 3.40GHz or AMD FX 8150 @ 3.6GHz   ', N'50 GB     ', N'NVIDIA GeForce GTX 670 or AMD Radeon R9 270X      ', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (4, N'NBA 2K21                                ', CAST(N'2020-12-19' AS Date), 13, 10001, 10001, N'Basketbolun yıldızlarıyla muhteşem bir oyun!                                                                                                                                                                                                                                                                ', 90, N'Windows 7 64-bit, Windows 8.1 64-bit or Windows 10', N'Intel® Core™ i5-4430 @ 3 GHz / AMD FX-8370 @ 3.4 G', N'110 GB    ', N'NVIDIA® GeForce® GTX 770 2GB / AMD® Radeon™ R9 270', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (5, N'Sherlock Holmes: The Devil''s Daughter   ', CAST(N'2016-07-10' AS Date), 15, 10002, 10002, N'Sherlock Holmes: The Devil’s Daughter is a fantastic adventure with unique gameplay that blends investigation, action and exploration for an extraordinary experience that will test the limits of your nerves and intelligence.                                                                            ', 79, N'Windows 7 64 Bit / Windows 8.1 64 Bit / Windows 10', N'INTEL Core i5 2100 3.1 GHZ / AMD A8-7600 3.1 GHz  ', N'20 GB     ', N'2048MB 100% DirectX 11 compatible ATI R9 270X / NV', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (6, N'A Plague Tale: Innocence                ', CAST(N'2019-05-14' AS Date), 18, 10002, 10002, N'Follow the grim tale of young Amicia and her little brother Hugo, in a heartrending journey through the darkest hours of history. Hunted by Inquisition soldiers and surrounded by unstoppable swarms of rats, they will come to know and trust each other.                                                 ', 85, N'Windows 7/8/10 (64 bits)                          ', N'Intel Core i5-4690 (3.5 GHz)/AMD FX-8300 (3.3 GHz)', N'50 GB     ', N'4 GB, GeForce GTX 970/Radeon RX 480               ', N'16 GB     ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (7, N'Grand Theft Auto 5                      ', CAST(N'2013-08-17' AS Date), 18, 10005, 10005, N' GTAV story, Grand Theft Auto Online and all existing gameplay upgrades and content. You’ll also get the Criminal Enterprise Starter Pack, the fastest way to jumpstart your criminal empire in GTA Online.                                                                                                 ', 97, N'Windows 7/8/10  (64 Bits)                         ', N'Intel Core i5 3470 @ 3.2GHZ (4 CPUs) / AMD X8 FX-8', N'90 GB     ', N'NVIDIA GTX 660 2GB / AMD HD7870 2GB               ', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (8, N'Verdun                                  ', CAST(N'2015-04-28' AS Date), 13, 10007, 10006, N'The game takes place on the Western Front between 1914 and 1918, in one of the bloodiest conflicts in world history - inspired by the infamous Battle of Verdun in 1916.                                                                                                                                    ', 57, N'Windows 8/10                                      ', N'Intel CPU Core i5-2500K 3.3GHz, AMD CPU Phenom II ', N'12 GB     ', N'Geforce GTX 960M / Radeon HD 7750 or higher, 4GB v', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (9, N'The Long Dark                           ', CAST(N'2014-08-22' AS Date), 16, 10008, 10008, N'A thoughtful, exploration-survival experience that challenges solo players to think for themselves as they explore an expansive frozen wilderness in the aftermath of a geomagnetic disaster. Only you, the cold, and all the threats Mother Nature can muster.                                             ', 74, N'Windows 10/7                                      ', N'Intel i7 CPU @ 2.6GHz or higher                   ', N'8 GB      ', N'Intel 4xxx Series w/ 512MB VRAM or better         ', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (10, N'The Witcher 3: Wild Hunt                ', CAST(N'2015-05-12' AS Date), 18, 10009, 10009, N'As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world.                                                                                                                ', 96, N'Windows 7/8/10                                    ', N'Intel CPU Core i7 3770 3.4 GHz / AMD CPU AMD FX-83', N'77 GB     ', N'Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 787', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (11, N'Assassins Creed Odyssey                 ', CAST(N'2018-01-05' AS Date), 18, 10003, 10003, N'From outcast to living legend, embark on an odyssey to uncover the secrets of your past and change the fate of Ancient Greece                                                                                                                                                                               ', 84, N'Windows 7/8/10 (64 bit only)                      ', N'AMD FX-8350 @ 4.0 GHz | Ryzen 5 - 1400 | Intel Cor', N'46 GB     ', N'AMD Radeon R9 285 | NVIDIA GeForce GTX 660 | 2GB V', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (12, N'Assassin''s Creed Valhalla               ', CAST(N'2020-12-11' AS Date), 18, 10003, 10003, N'Become a legendary Viking on a quest for glory. Raid your enemies, grow your settlement, and build your political power.                                                                                                                                                                                    ', 92, N'Windows 10 (64 bit)                               ', N'Ryzen 3 1200 - 3.1 Ghz / i5-4460 - 3.2 Ghz        ', N'50 GB     ', N'AMD R9 380 - 4GB / GeForce GTX 960 4GB            ', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (15, N'Cyberpunk 2077                          ', CAST(N'2020-11-10' AS Date), 18, 10009, 10009, N'Cyberpunk 2077 is an open-world, action-adventure story set in Night City, a megalopolis obsessed with power, glamour and body modification. You play as V, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality.                                                          ', 64, N'Windows 10/7                                      ', N'Intel Core i5-3570K or AMD FX-8310                ', N'70 GB     ', N'NVIDIA GeForce GTX 780 or AMD Radeon RX 470       ', N'12 GB     ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (16, N'Rocket League                           ', CAST(N'2020-07-24' AS Date), 13, 10002, 10002, N'Rocket League is a high-powered hybrid of arcade-style soccer and vehicular mayhem with easy-to-understand controls and fluid, physics-driven competition.                                                                                                                                                  ', 93, N'Windows 7 (64 bit)                                ', N'2.5 GHz Dual core                                 ', N'20 GB     ', N'NVIDIA GeForce 760, AMD Radeon R7 270X, or better ', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (17, N'Among Us                                ', CAST(N'2020-01-01' AS Date), 7, 10010, 10010, N'Play with 4-15 players online or via local WiFi as you attempt to prepare your spaceship for departure, but beware as one or more random players among the Crew are Impostors bent on killing everyone!                                                                                                     ', 0, N'Windows 7                                         ', N'SSE2 instruction set support                      ', N'250 MB    ', N'NVIDIA GeForce 760, AMD Radeon R7 270X, or better ', N'1 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (18, N'Battlefield 2042                        ', CAST(N'2021-01-22' AS Date), 13, 10011, 10000, N'Battlefield™ 2042 is a first-person shooter that marks the return to the iconic all-out warfare of the franchise. Adapt and overcome in a near-future world transformed by disorder.                                                                                                                        ', 0, N'Windows 7 (64 bit)                                ', N'SSE2 instruction set support                      ', N'250 MB    ', N'NVIDIA GeForce 760, AMD Radeon R7 270X, or better ', N'1 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (19, N'Hitman                                  ', CAST(N'2022-01-01' AS Date), 18, 10012, 10012, N'Experiment and have fun in the ultimate playground as Agent 47 to become the master assassin. Travel around the globe to exotic locations and eliminate your targets with everything from a katana or a sniper rifle to an exploding golf ball or some expired spaghetti sauce.                             ', 92, N'Windows 7/8/10                                    ', N'Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II', N'50 GB     ', N'NVIDIA GeForce GTX 660 / Radeon HD 7870           ', N'8 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (20, N'Hitman 3                                ', CAST(N'2021-01-20' AS Date), 18, 10012, 10012, N'Death Awaits. Agent 47 returns in HITMAN 3, the dramatic conclusion to the World of Assassination trilogy.                                                                                                                                                                                                  ', 93, N'Windows 10 (64 bit)                               ', N'Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II', N'80 GB     ', N'NVIDIA GeForce GTX 660 / Radeon HD 7870           ', N'16 GB     ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (21, N'Assassin''s Creed Unity                  ', CAST(N'2014-11-11' AS Date), 18, 10003, 10003, N'Assassin’s Creed Unity tells the story of Arno who embarks upon an extraordinary journey to expose the true powers behind the French Revolution.                                                                                                                                                            ', 35, N'Windows 7/8/8.1 (64 bit)                          ', N'Intel Core i5-2500K / 3.3 GHz or AMD FX-8350 / 4.0', N'50 GB     ', N'NVIDIA GeForce GTX 680 or AMD Radeon HD 7970 (2 GB', N'6 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (22, N'Mafia 3                                 ', CAST(N'2020-01-01' AS Date), 18, 10013, 10014, N'After Lincoln Clay''s surrogate family, the black mob, is betrayed and killed by the Italian Mafia, Lincoln builds a new family and blazes a path of revenge through the Mafioso responsible.                                                                                                                ', 0, N'Windows 7 (64 bit)                                ', N'Intel CPU: I5-2500K AMD CPU: AMD FX-8120          ', N'60 GB     ', N'AMD GPU: Radeon HD7870 NVIDIA GPU: GeForce GTX 660', N'6 GB      ')
INSERT [dbo].[Registration_Game] ([GameID], [GameName], [ReleaseDate], [AgeLimit], [DeveloperID], [PublisherID], [Explanation], [AvaragePoint], [OprSystem], [CPU], [Storage], [Graphics], [Memory]) VALUES (24, N'Mafia 2                                 ', CAST(N'2020-01-02' AS Date), 18, 10014, 10014, N'War hero Vito Scaletta becomes entangled with the mob in hopes of paying his father’s debts. Vito works to prove himself, climbing the family ladder with crimes of larger reward and consequence.                                                                                                          ', 25, N'Windows 7/8/8.1                                   ', N'Intel CPU: I5-2500K AMD CPU: AMD FX-8120          ', N'50 GB     ', N'50 GB                                             ', N'6 GB      ')
SET IDENTITY_INSERT [dbo].[Registration_Game] OFF
GO
SET IDENTITY_INSERT [dbo].[Type_Genres] ON 

INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1000, N'Action              ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1001, N'Advanture           ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1002, N'Indie               ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1003, N'RGP                 ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1004, N'Strategy            ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1005, N'Open World          ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1006, N'Shooter             ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1007, N'Puzzle              ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1008, N'First Person        ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1009, N'Narration           ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1010, N'Simulation          ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1011, N'Casual              ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1012, N'Turn-Based          ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1013, N'Exploration         ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1014, N'Horror              ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1015, N'Platformer          ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1016, N'Party               ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1017, N'Survival            ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1018, N'Trivia              ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1019, N'City Builder        ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1020, N'Strealth            ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1021, N'Fighting            ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1022, N'Comedy              ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1023, N'Action-Advanture    ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1024, N'Racing              ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1025, N'Rogue-Life          ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1026, N'Card Game           ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1027, N'Sports              ')
INSERT [dbo].[Type_Genres] ([GenreID], [GrenreType]) VALUES (1028, N'Dungeon Crawler     ')
SET IDENTITY_INSERT [dbo].[Type_Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[Type_Language] ON 

INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6000, N'TURKISH             ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6001, N'ENGLISH             ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6002, N'GERMAN              ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6003, N'ITALIAN             ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6004, N'FRECNH              ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6005, N'CHINESE             ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6006, N'JAPANESE            ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6007, N'KOREAN              ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6008, N'RUSSIAN             ')
INSERT [dbo].[Type_Language] ([LanguageID], [LanguageName]) VALUES (6009, N'ARABIC              ')
SET IDENTITY_INSERT [dbo].[Type_Language] OFF
GO
SET IDENTITY_INSERT [dbo].[Type_Package] ON 

INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9000, N'BASE                                    ')
INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9001, N'DEMO                                    ')
INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9002, N'FULL                                    ')
INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9003, N'DELUXE                                  ')
INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9004, N'GOLD                                    ')
INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9005, N'PREMIUM                                 ')
INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9006, N'ULTIMATE                                ')
INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9007, N'ALL-IN-ONE                              ')
INSERT [dbo].[Type_Package] ([PackageID], [PackageName]) VALUES (9008, N'STARTER                                 ')
SET IDENTITY_INSERT [dbo].[Type_Package] OFF
GO
SET IDENTITY_INSERT [dbo].[Type_Player] ON 

INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8001, 3, N'Y  ', N'N  ', N'Y  ', N'N  ', N'N  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8002, 4, N'Y  ', N'Y  ', N'Y  ', N'N  ', N'N  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8003, 5, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8004, 6, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8005, 7, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8006, 8, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8007, 9, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8008, 10, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8009, 11, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8010, 12, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8013, 15, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8014, 16, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8015, 17, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8016, 18, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8017, 19, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8018, 20, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8019, 21, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8020, 22, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
INSERT [dbo].[Type_Player] ([PlayerTypeID], [GameID], [Single], [Multiplayer], [Controller], [Co-Op], [VR]) VALUES (8023, 24, N'Y  ', N'Y  ', N'Y  ', N'Y  ', N'Y  ')
SET IDENTITY_INSERT [dbo].[Type_Player] OFF
GO
/****** Object:  Index [IX_Customer_Purchase_1]    Script Date: 14.09.2021 14:04:26 ******/
ALTER TABLE [dbo].[Order_Game] ADD  CONSTRAINT [IX_Customer_Purchase_1] UNIQUE NONCLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Registration_Company]    Script Date: 14.09.2021 14:04:26 ******/
ALTER TABLE [dbo].[Registration_Company] ADD  CONSTRAINT [IX_Registration_Company] UNIQUE NONCLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Buy_ExtraPackage]  WITH CHECK ADD  CONSTRAINT [FK_Order_ExtraPackage_Registration_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Registration_Game] ([GameID])
GO
ALTER TABLE [dbo].[Buy_ExtraPackage] CHECK CONSTRAINT [FK_Order_ExtraPackage_Registration_Game]
GO
ALTER TABLE [dbo].[Buy_Game]  WITH CHECK ADD  CONSTRAINT [FK_Order_Game_Registration_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Registration_Game] ([GameID])
GO
ALTER TABLE [dbo].[Buy_Game] CHECK CONSTRAINT [FK_Order_Game_Registration_Game]
GO
ALTER TABLE [dbo].[Buy_Game]  WITH CHECK ADD  CONSTRAINT [FK_Order_Game_Type_Package] FOREIGN KEY([PackageID])
REFERENCES [dbo].[Type_Package] ([PackageID])
GO
ALTER TABLE [dbo].[Buy_Game] CHECK CONSTRAINT [FK_Order_Game_Type_Package]
GO
ALTER TABLE [dbo].[Customer_Wishlist]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Wishlist_Order_ExtraPackage] FOREIGN KEY([OrderExtraPackageID])
REFERENCES [dbo].[Buy_ExtraPackage] ([OrderID])
GO
ALTER TABLE [dbo].[Customer_Wishlist] CHECK CONSTRAINT [FK_Customer_Wishlist_Order_ExtraPackage]
GO
ALTER TABLE [dbo].[Customer_Wishlist]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Wishlist_Order_Game] FOREIGN KEY([OrderGameID])
REFERENCES [dbo].[Buy_Game] ([OrderID])
GO
ALTER TABLE [dbo].[Customer_Wishlist] CHECK CONSTRAINT [FK_Customer_Wishlist_Order_Game]
GO
ALTER TABLE [dbo].[Customer_Wishlist]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Wishlist_Registration_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Registration_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Customer_Wishlist] CHECK CONSTRAINT [FK_Customer_Wishlist_Registration_Customer]
GO
ALTER TABLE [dbo].[Game_Genres]  WITH CHECK ADD  CONSTRAINT [FK_Game_Genres_Registration_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Registration_Game] ([GameID])
GO
ALTER TABLE [dbo].[Game_Genres] CHECK CONSTRAINT [FK_Game_Genres_Registration_Game]
GO
ALTER TABLE [dbo].[Game_Genres]  WITH CHECK ADD  CONSTRAINT [FK_Game_Genres_Type_Genres] FOREIGN KEY([GenreID])
REFERENCES [dbo].[Type_Genres] ([GenreID])
GO
ALTER TABLE [dbo].[Game_Genres] CHECK CONSTRAINT [FK_Game_Genres_Type_Genres]
GO
ALTER TABLE [dbo].[LanguageSupport_Audio]  WITH CHECK ADD  CONSTRAINT [FK_LanguageSupport_Audio_Registration_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Registration_Game] ([GameID])
GO
ALTER TABLE [dbo].[LanguageSupport_Audio] CHECK CONSTRAINT [FK_LanguageSupport_Audio_Registration_Game]
GO
ALTER TABLE [dbo].[LanguageSupport_Audio]  WITH CHECK ADD  CONSTRAINT [FK_LanguageSupport_Audio_Type_Language] FOREIGN KEY([AudioLanguageID])
REFERENCES [dbo].[Type_Language] ([LanguageID])
GO
ALTER TABLE [dbo].[LanguageSupport_Audio] CHECK CONSTRAINT [FK_LanguageSupport_Audio_Type_Language]
GO
ALTER TABLE [dbo].[LanguageSupport_Texts]  WITH CHECK ADD  CONSTRAINT [FK_LanguageSupport_Texts_Registration_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Registration_Game] ([GameID])
GO
ALTER TABLE [dbo].[LanguageSupport_Texts] CHECK CONSTRAINT [FK_LanguageSupport_Texts_Registration_Game]
GO
ALTER TABLE [dbo].[LanguageSupport_Texts]  WITH CHECK ADD  CONSTRAINT [FK_LanguageSupport_Texts_Type_Language] FOREIGN KEY([TextLanguageID])
REFERENCES [dbo].[Type_Language] ([LanguageID])
GO
ALTER TABLE [dbo].[LanguageSupport_Texts] CHECK CONSTRAINT [FK_LanguageSupport_Texts_Type_Language]
GO
ALTER TABLE [dbo].[Order_ExtraPackage]  WITH CHECK ADD  CONSTRAINT [FK_Order_ExtraPackage_Buy_ExtraPackage] FOREIGN KEY([OrderExtraPackageID])
REFERENCES [dbo].[Buy_ExtraPackage] ([OrderID])
GO
ALTER TABLE [dbo].[Order_ExtraPackage] CHECK CONSTRAINT [FK_Order_ExtraPackage_Buy_ExtraPackage]
GO
ALTER TABLE [dbo].[Order_ExtraPackage]  WITH CHECK ADD  CONSTRAINT [FK_Order_ExtraPackage_Registration_Coupon] FOREIGN KEY([CouponID])
REFERENCES [dbo].[Registration_Coupon] ([CouponID])
GO
ALTER TABLE [dbo].[Order_ExtraPackage] CHECK CONSTRAINT [FK_Order_ExtraPackage_Registration_Coupon]
GO
ALTER TABLE [dbo].[Order_ExtraPackage]  WITH CHECK ADD  CONSTRAINT [FK_Order_ExtraPackage_Registration_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Registration_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Order_ExtraPackage] CHECK CONSTRAINT [FK_Order_ExtraPackage_Registration_Customer]
GO
ALTER TABLE [dbo].[Order_Game]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Purchase_Order_Game1] FOREIGN KEY([OrderGameID])
REFERENCES [dbo].[Buy_Game] ([OrderID])
GO
ALTER TABLE [dbo].[Order_Game] CHECK CONSTRAINT [FK_Customer_Purchase_Order_Game1]
GO
ALTER TABLE [dbo].[Order_Game]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Purchase_Registration_Coupon] FOREIGN KEY([CouponID])
REFERENCES [dbo].[Registration_Coupon] ([CouponID])
GO
ALTER TABLE [dbo].[Order_Game] CHECK CONSTRAINT [FK_Customer_Purchase_Registration_Coupon]
GO
ALTER TABLE [dbo].[Order_Game]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Purchase_Registration_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Registration_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Order_Game] CHECK CONSTRAINT [FK_Customer_Purchase_Registration_Customer]
GO
ALTER TABLE [dbo].[Registration_Game]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Game_Registration_Company] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Registration_Company] ([CompanyID])
GO
ALTER TABLE [dbo].[Registration_Game] CHECK CONSTRAINT [FK_Registration_Game_Registration_Company]
GO
ALTER TABLE [dbo].[Registration_Game]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Game_Registration_Company1] FOREIGN KEY([DeveloperID])
REFERENCES [dbo].[Registration_Company] ([CompanyID])
GO
ALTER TABLE [dbo].[Registration_Game] CHECK CONSTRAINT [FK_Registration_Game_Registration_Company1]
GO
ALTER TABLE [dbo].[Type_Player]  WITH CHECK ADD  CONSTRAINT [FK_Type_Player_Registration_Game] FOREIGN KEY([GameID])
REFERENCES [dbo].[Registration_Game] ([GameID])
GO
ALTER TABLE [dbo].[Type_Player] CHECK CONSTRAINT [FK_Type_Player_Registration_Game]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetBuyExtra]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetBuyExtra] 
AS 
BEGIN 
SELECT be.OrderID, rg.GameName, be.ExtraPackageName, rg.GameID,be.Price FROM dbo.Buy_ExtraPackage be, dbo.Registration_Game rg
WHERE be.GameID = rg.GameID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetBuyGame]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetBuyGame] 
AS 
BEGIN 
SELECT bg.OrderID, rg.GameID, rg.GameName, tp.PackageName,bg.Price FROM dbo.Buy_Game bg, dbo.Registration_Game rg, Type_Package tp
WHERE rg.GameID=bg.GameID and bg.PackageID=tp.PackageID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetGames]    Script Date: 14.09.2021 14:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_GetGames]
As
Select 
	RG.*,
	R1.CompanyName PublisherCompanyName,
	R2.CompanyName DeveloperCompanyName
From Registration_Game RG
Join Registration_Company R1 On RG.PublisherID = R1.CompanyID
Join Registration_Company R2 On RG.DeveloperID = R2.CompanyID
GO
