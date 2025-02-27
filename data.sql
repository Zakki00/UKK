USE [list]
GO
/****** Object:  Table [dbo].[Tugas]    Script Date: 18/02/2025 09:10:41 ******/
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
