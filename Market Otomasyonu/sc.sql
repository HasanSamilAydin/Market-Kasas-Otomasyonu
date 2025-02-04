
USE [kasa]
GO
/****** Object:  User [sas]    Script Date: 3.06.2024 11:50:58 ******/
CREATE USER [sas] FOR LOGIN [sas] WITH DEFAULT_SCHEMA=[sas]
GO
/****** Object:  Schema [sas]    Script Date: 3.06.2024 11:50:58 ******/
CREATE SCHEMA [sas]
GO
/****** Object:  Table [dbo].[tbliade]    Script Date: 3.06.2024 11:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbliade](
	[iadeID] [int] IDENTITY(1,1) NOT NULL,
	[iadeKim] [int] NOT NULL,
	[iadeNeKadar] [decimal](10, 2) NOT NULL,
	[iadeTarih] [datetime] NOT NULL,
	[iadeAciklamasi] [nvarchar](500) NOT NULL,
	[iadeNakit] [int] NOT NULL,
 CONSTRAINT [PK__tbliade__A794D235B3587E06] PRIMARY KEY CLUSTERED 
(
	[iadeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblkasiyer]    Script Date: 3.06.2024 11:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblkasiyer](
	[kasiyerID] [int] IDENTITY(1,1) NOT NULL,
	[kasiyerKullaniciAdi] [nvarchar](50) NOT NULL,
	[kasiyerSifre] [varchar](50) NOT NULL,
	[kasiyerAdSoyad] [varchar](50) NOT NULL,
	[kasiyerMail] [varchar](50) NOT NULL,
	[kasiyerPrim] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK__tblkasiy__48F5A184C33FB22C] PRIMARY KEY CLUSTERED 
(
	[kasiyerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblkategori]    Script Date: 3.06.2024 11:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblkategori](
	[kategoriID] [int] IDENTITY(1,1) NOT NULL,
	[kategoriAd] [varchar](45) NOT NULL,
 CONSTRAINT [PK__tblkateg__1D9181BD156DFFE1] PRIMARY KEY CLUSTERED 
(
	[kategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblmarka]    Script Date: 3.06.2024 11:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblmarka](
	[markaID] [int] IDENTITY(1,1) NOT NULL,
	[markaAd] [varchar](45) NOT NULL,
 CONSTRAINT [PK__tblmarka__60695969C9A3189D] PRIMARY KEY CLUSTERED 
(
	[markaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblnakitorkart]    Script Date: 3.06.2024 11:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblnakitorkart](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KartNakit] [varchar](5) NOT NULL,
 CONSTRAINT [PK__tblnakit__3214EC274698405D] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblsatis]    Script Date: 3.06.2024 11:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblsatis](
	[satisID] [int] IDENTITY(1,1) NOT NULL,
	[satisKim] [int] NOT NULL,
	[satisNeKadar] [decimal](10, 2) NOT NULL,
	[satisTarih] [datetime] NOT NULL,
	[satisAciklamasi] [nvarchar](500) NOT NULL,
	[satisNakit] [int] NOT NULL,
 CONSTRAINT [PK__tblsatis__E4F33F6195B341EA] PRIMARY KEY CLUSTERED 
(
	[satisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbluruns]    Script Date: 3.06.2024 11:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbluruns](
	[urunID] [int] IDENTITY(1,1) NOT NULL,
	[urunBarkod] [varchar](45) NOT NULL,
	[urrunKategori] [int] NOT NULL,
	[urunMarka] [int] NOT NULL,
	[urunAd] [varchar](20) NOT NULL,
	[urunFiyat] [decimal](10, 2) NOT NULL,
	[urunStok] [int] NOT NULL,
	[urunSorgusu] [bit] NOT NULL,
 CONSTRAINT [PK__tbluruns__30BE53A35EEBD3C2] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbliade] ON 

INSERT [dbo].[tbliade] ([iadeID], [iadeKim], [iadeNeKadar], [iadeTarih], [iadeAciklamasi], [iadeNakit]) VALUES (1, 1, CAST(100.00 AS Decimal(10, 2)), CAST(N'2024-05-31T22:23:29.113' AS DateTime), N'Ev Yaşam Ülker Top Adet=1 100', 1)
SET IDENTITY_INSERT [dbo].[tbliade] OFF
GO
SET IDENTITY_INSERT [dbo].[tblkasiyer] ON 

INSERT [dbo].[tblkasiyer] ([kasiyerID], [kasiyerKullaniciAdi], [kasiyerSifre], [kasiyerAdSoyad], [kasiyerMail], [kasiyerPrim]) VALUES (1, N'admin', N'admin123', N'hasan şamil aydın', N'hasan.samil.2009@hotmail.com', CAST(9.00 AS Decimal(10, 2)))
INSERT [dbo].[tblkasiyer] ([kasiyerID], [kasiyerKullaniciAdi], [kasiyerSifre], [kasiyerAdSoyad], [kasiyerMail], [kasiyerPrim]) VALUES (1004, N'ardahan', N'7575', N'hasan', N'hasan.samil.2009@hotmail.com', CAST(0.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[tblkasiyer] OFF
GO
SET IDENTITY_INSERT [dbo].[tblkategori] ON 

INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (1, N'Spor')
INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (2, N'Giyim')
INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (3, N'Ev Yaşam')
INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (4, N'Temizlik')
INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (5, N'Kişisel Bakım')
INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (6, N'İçecek')
INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (7, N'Yiyecek')
INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (8, N'Elektronik')
INSERT [dbo].[tblkategori] ([kategoriID], [kategoriAd]) VALUES (9, N'Eğelence')
SET IDENTITY_INSERT [dbo].[tblkategori] OFF
GO
SET IDENTITY_INSERT [dbo].[tblmarka] ON 

INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (1, N'Ülker')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (2, N'Eti')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (3, N'Nike')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (4, N'Samsung')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (5, N'Cif')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (6, N'Asus')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (7, N'Tarmak')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (8, N'Ikea')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (9, N'Lego')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (10, N'Kardeşler Kundura')
INSERT [dbo].[tblmarka] ([markaID], [markaAd]) VALUES (11, N'Halder Şalder')
SET IDENTITY_INSERT [dbo].[tblmarka] OFF
GO
SET IDENTITY_INSERT [dbo].[tblnakitorkart] ON 

INSERT [dbo].[tblnakitorkart] ([ID], [KartNakit]) VALUES (1, N'Kart')
INSERT [dbo].[tblnakitorkart] ([ID], [KartNakit]) VALUES (2, N'Nakit')
SET IDENTITY_INSERT [dbo].[tblnakitorkart] OFF
GO
SET IDENTITY_INSERT [dbo].[tblsatis] ON 

INSERT [dbo].[tblsatis] ([satisID], [satisKim], [satisNeKadar], [satisTarih], [satisAciklamasi], [satisNakit]) VALUES (1, 1, CAST(100.00 AS Decimal(10, 2)), CAST(N'2024-05-31T23:10:38.237' AS DateTime), N'Ev Yaşam Ülker Top Adet=1      100', 2)
INSERT [dbo].[tblsatis] ([satisID], [satisKim], [satisNeKadar], [satisTarih], [satisAciklamasi], [satisNakit]) VALUES (2, 1, CAST(100.00 AS Decimal(10, 2)), CAST(N'2024-05-31T23:13:47.287' AS DateTime), N'Ev Yaşam Ülker Top Adet=1      100', 2)
INSERT [dbo].[tblsatis] ([satisID], [satisKim], [satisNeKadar], [satisTarih], [satisAciklamasi], [satisNakit]) VALUES (3, 1, CAST(100.00 AS Decimal(10, 2)), CAST(N'2024-05-31T23:13:54.683' AS DateTime), N'Ev Yaşam Ülker Top Adet=1      100', 2)
INSERT [dbo].[tblsatis] ([satisID], [satisKim], [satisNeKadar], [satisTarih], [satisAciklamasi], [satisNakit]) VALUES (4, 1, CAST(300.00 AS Decimal(10, 2)), CAST(N'2024-05-31T23:24:57.663' AS DateTime), N'Ev Yaşam Ülker Top Adet=3      300', 2)
INSERT [dbo].[tblsatis] ([satisID], [satisKim], [satisNeKadar], [satisTarih], [satisAciklamasi], [satisNakit]) VALUES (5, 1, CAST(100.00 AS Decimal(10, 2)), CAST(N'2024-06-02T02:04:32.593' AS DateTime), N'Spor Nike Top Adet=1      100', 2)
INSERT [dbo].[tblsatis] ([satisID], [satisKim], [satisNeKadar], [satisTarih], [satisAciklamasi], [satisNakit]) VALUES (8, 1, CAST(100.00 AS Decimal(10, 2)), CAST(N'2024-06-02T02:04:32.593' AS DateTime), N's', 1)
INSERT [dbo].[tblsatis] ([satisID], [satisKim], [satisNeKadar], [satisTarih], [satisAciklamasi], [satisNakit]) VALUES (9, 1, CAST(200.00 AS Decimal(10, 2)), CAST(N'2024-06-03T11:37:05.217' AS DateTime), N'Spor Nike Top Adet=2      200Temizlik Cif temizlikbişeyleri Adet=1      100', 2)
INSERT [dbo].[tblsatis] ([satisID], [satisKim], [satisNeKadar], [satisTarih], [satisAciklamasi], [satisNakit]) VALUES (17, 1, CAST(0.00 AS Decimal(10, 2)), CAST(N'2024-06-03T11:42:47.030' AS DateTime), N'Spor Nike Top Adet=1      100', 2)
SET IDENTITY_INSERT [dbo].[tblsatis] OFF
GO
SET IDENTITY_INSERT [dbo].[tbluruns] ON 

INSERT [dbo].[tbluruns] ([urunID], [urunBarkod], [urrunKategori], [urunMarka], [urunAd], [urunFiyat], [urunStok], [urunSorgusu]) VALUES (1, N'1', 1, 3, N'Top', CAST(100.00 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[tbluruns] ([urunID], [urunBarkod], [urrunKategori], [urunMarka], [urunAd], [urunFiyat], [urunStok], [urunSorgusu]) VALUES (1007, N'2', 1, 3, N'Ayakkabı', CAST(2000.00 AS Decimal(10, 2)), 5, 1)
INSERT [dbo].[tbluruns] ([urunID], [urunBarkod], [urrunKategori], [urunMarka], [urunAd], [urunFiyat], [urunStok], [urunSorgusu]) VALUES (1008, N'8682241215911', 4, 5, N'temizlikbişeyleri', CAST(100.00 AS Decimal(10, 2)), 1, 1)
SET IDENTITY_INSERT [dbo].[tbluruns] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_kasiyerKullaniciAdi]    Script Date: 3.06.2024 11:50:59 ******/
ALTER TABLE [dbo].[tblkasiyer] ADD  CONSTRAINT [UC_kasiyerKullaniciAdi] UNIQUE NONCLUSTERED 
(
	[kasiyerKullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [urunBarkod]    Script Date: 3.06.2024 11:50:59 ******/
ALTER TABLE [dbo].[tbluruns] ADD  CONSTRAINT [urunBarkod] UNIQUE NONCLUSTERED 
(
	[urunBarkod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblkasiyer] ADD  CONSTRAINT [DF__tblkasiye__kasiy__38996AB5]  DEFAULT ('0.00') FOR [kasiyerPrim]
GO
ALTER TABLE [dbo].[tbliade]  WITH CHECK ADD  CONSTRAINT [FK_tbliade_tblkasiyer] FOREIGN KEY([iadeKim])
REFERENCES [dbo].[tblkasiyer] ([kasiyerID])
GO
ALTER TABLE [dbo].[tbliade] CHECK CONSTRAINT [FK_tbliade_tblkasiyer]
GO
ALTER TABLE [dbo].[tbliade]  WITH CHECK ADD  CONSTRAINT [FK_tbliade_tblnakitorkart] FOREIGN KEY([iadeNakit])
REFERENCES [dbo].[tblnakitorkart] ([ID])
GO
ALTER TABLE [dbo].[tbliade] CHECK CONSTRAINT [FK_tbliade_tblnakitorkart]
GO
ALTER TABLE [dbo].[tblsatis]  WITH CHECK ADD  CONSTRAINT [FK_tblsatis_tblkasiyer] FOREIGN KEY([satisKim])
REFERENCES [dbo].[tblkasiyer] ([kasiyerID])
GO
ALTER TABLE [dbo].[tblsatis] CHECK CONSTRAINT [FK_tblsatis_tblkasiyer]
GO
ALTER TABLE [dbo].[tblsatis]  WITH CHECK ADD  CONSTRAINT [FK_tblsatis_tblnakitorkart] FOREIGN KEY([satisNakit])
REFERENCES [dbo].[tblnakitorkart] ([ID])
GO
ALTER TABLE [dbo].[tblsatis] CHECK CONSTRAINT [FK_tblsatis_tblnakitorkart]
GO
ALTER TABLE [dbo].[tbluruns]  WITH CHECK ADD  CONSTRAINT [FK_tbluruns_tblkategori] FOREIGN KEY([urrunKategori])
REFERENCES [dbo].[tblkategori] ([kategoriID])
GO
ALTER TABLE [dbo].[tbluruns] CHECK CONSTRAINT [FK_tbluruns_tblkategori]
GO
ALTER TABLE [dbo].[tbluruns]  WITH CHECK ADD  CONSTRAINT [FK_tbluruns_tblmarka] FOREIGN KEY([urunMarka])
REFERENCES [dbo].[tblmarka] ([markaID])
GO
ALTER TABLE [dbo].[tbluruns] CHECK CONSTRAINT [FK_tbluruns_tblmarka]
GO
