USE [Bai3]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 22/10/2020 12:20:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[URL] [nvarchar](500) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 22/10/2020 12:20:23 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ParentID] [int] NULL,
	[SortOrder] [int] NULL,
	[Alias] [varchar](max) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Banner] ON 

INSERT [dbo].[Banner] ([ID], [Name], [URL]) VALUES (1, N'Header', N'https://www.hutech.edu.vn/images/logo/HUTECH25.png')
INSERT [dbo].[Banner] ([ID], [Name], [URL]) VALUES (2, N'Left', N'https://chungcudep.net/wp-content/uploads/2018/07/banner-right-vinhomes-gallery.png')
INSERT [dbo].[Banner] ([ID], [Name], [URL]) VALUES (3, N'Right', N'https://chungcudep.net/wp-content/uploads/2018/07/banner-right-vinhomes-gallery.png')
SET IDENTITY_INSERT [dbo].[Banner] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (1, N'Điện Thoại ', NULL, 1, NULL)
INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (2, N'Máy Tính Bảng', NULL, 2, NULL)
INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (3, N'Laptop', NULL, 3, NULL)
INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (4, N'Iphone', 1, 1, NULL)
INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (5, N'SamSung', 1, 2, NULL)
INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (6, N'Nokia', 1, 3, NULL)
INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (7, N'IphoneX', 4, 1, NULL)
INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (8, N'Iphone8', 4, 2, NULL)
INSERT [dbo].[Menu] ([ID], [Name], [ParentID], [SortOrder], [Alias]) VALUES (9, N'Iphone9', 4, 3, NULL)
SET IDENTITY_INSERT [dbo].[Menu] OFF
