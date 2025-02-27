USE [list]
GO
/****** Object:  Table [dbo].[Tugas]    Script Date: 18/02/2025 09:16:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tugas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama_tugas] [varchar](500) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[prioritas] [varchar](50) NOT NULL,
	[tanggal] [date] NOT NULL,
 CONSTRAINT [PK_Tugas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tugas] ON 

INSERT [dbo].[Tugas] ([id], [nama_tugas], [status], [prioritas], [tanggal]) VALUES (5, N'menyapu', N'Selesai', N'Sedang', CAST(N'2025-02-17' AS Date))
INSERT [dbo].[Tugas] ([id], [nama_tugas], [status], [prioritas], [tanggal]) VALUES (18, N'rre', N'Belum Selesai', N'Sedang', CAST(N'2025-02-18' AS Date))
SET IDENTITY_INSERT [dbo].[Tugas] OFF
GO
