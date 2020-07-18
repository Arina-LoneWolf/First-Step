/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

--tạo database
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLNS')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLNS') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLNS]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLNS]
GO

--tạo bảng tblBaoCaoCongNo
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBaoCaoCongNo]    Script Date: 01/06/2018 2:40:07 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBaoCaoCongNo](
	[maBaoCaoCongNo] [int] NOT NULL,
	[thang] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblBaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[maBaoCaoCongNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO








--tạo bảng tblBaoCaoTon
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBaoCaoTon]    Script Date: 01/06/2018 2:41:11 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBaoCaoTon](
	[maBaoCaoTon] [int] NOT NULL,
	[thang] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[maBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




--tạo bảng tblChiTietBaoCaoCongNo
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblChiTietBaoCaoCongNo]    Script Date: 01/06/2018 2:41:59 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietBaoCaoCongNo](
	[maChiTietBaoCaoCongNo] [int] NOT NULL,
	[maKH] [int] NOT NULL,
	[maBaoCaoCongNo] [int] NOT NULL,
	[noDau] [text] NOT NULL,
	[noPhatSinh] [text] NOT NULL,
	[noCuoi] [text] NOT NULL,
 CONSTRAINT [PK_tblChiTietBaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[maChiTietBaoCaoCongNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoCongNo]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietBaoCaoCongNo_tblBaoCaoCongNo] FOREIGN KEY([maBaoCaoCongNo])
REFERENCES [dbo].[tblBaoCaoCongNo] ([maBaoCaoCongNo])
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoCongNo] CHECK CONSTRAINT [FK_tblChiTietBaoCaoCongNo_tblBaoCaoCongNo]
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoCongNo]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietBaoCaoCongNo_tblKhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[tblKhachHang] ([maKH])
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoCongNo] CHECK CONSTRAINT [FK_tblChiTietBaoCaoCongNo_tblKhachHang]
GO





--tạo bảng tblChiTietBaoCaoTon
UUSE [QLNS]
GO

/****** Object:  Table [dbo].[tblChiTietBaoCaoTon]    Script Date: 01/06/2018 2:44:23 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietBaoCaoTon](
	[maChiTietBaoCaoTon] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[maBaoCaoTon] [int] NOT NULL,
	[tonDau] [int] NOT NULL,
	[tonPhatSinh] [int] NOT NULL,
	[tonCuoi] [int] NOT NULL,
	[donGia] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[maChiTietBaoCaoTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoTon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietBaoCaoTon_tblBaoCaoTon] FOREIGN KEY([maBaoCaoTon])
REFERENCES [dbo].[tblBaoCaoTon] ([maBaoCaoTon])
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoTon] CHECK CONSTRAINT [FK_tblChiTietBaoCaoTon_tblBaoCaoTon]
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoTon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietBaoCaoTon_tblSach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tblSach] ([maSach])
GO

ALTER TABLE [dbo].[tblChiTietBaoCaoTon] CHECK CONSTRAINT [FK_tblChiTietBaoCaoTon_tblSach]
GO






--tạo bảng tblChiTietHoaDon
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblChiTietHoaDon]    Script Date: 01/06/2018 2:44:44 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietHoaDon](
	[maChiTietHoaDon] [int] NOT NULL,
	[maHoaDon] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[soLuongBan] [int] NOT NULL,
	[donGiaBan] [int] NOT NULL,
	[thanhTien] [int] NOT NULL,
 CONSTRAINT [PK_tblChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[maChiTietHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHoaDon_tblHoaDon] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[tblHoaDon] ([maHoaDon])
GO

ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_tblChiTietHoaDon_tblHoaDon]
GO

ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHoaDon_tblSach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tblSach] ([maSach])
GO

ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_tblChiTietHoaDon_tblSach]
GO





--tạo bảng tblChiTietPhieuNhap
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblChiTietPhieuNhap]    Script Date: 01/06/2018 2:45:14 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietPhieuNhap](
	[maChiTietPhieuNhap] [int] NOT NULL,
	[maPhieuNhap] [int] NOT NULL ,
	[maSach] [int] ,
	[tenSach] [nvarchar] (50)NOT NULL,
	[soLuongNhap] [nchar](10) NOT NULL,
	[tenLoaiSach] [nvarchar](50) NOT NULL,
	[tacgia] [nvarchar](50) NOT NULL,
	[dongia] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maChiTietPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuNhap_tblChiTietPhieuNhap] FOREIGN KEY([maPhieuNhap])
REFERENCES [dbo].[tblPhieuNhap] ([maPhieuNhap])
GO

ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK_tblChiTietPhieuNhap_tblChiTietPhieuNhap]
GO

ALTER TABLE [dbo].[tblChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuNhap_tblSach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tblSach] ([maSach])
GO

ALTER TABLE [dbo].[tblChiTietPhieuNhap] CHECK CONSTRAINT [FK_tblChiTietPhieuNhap_tblSach]
GO





USE [QLNS]
GO

/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 01/06/2018 2:45:29 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblHoaDon](
	[maHoaDon] [int] NOT NULL,
	[ngayHoaDon] [datetime2](7) NOT NULL,
	[maKH] [int] NOT NULL,
	[tongGiaTriHD] [int] NOT NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblKhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[tblKhachHang] ([maKH])
GO

ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblKhachHang]
GO






--tạo bảng tblKhachHang
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 01/06/2018 2:45:43 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblKhachHang](
	[maKH] [int] NOT NULL,
	[hoTenKH] [nvarchar](50) NOT NULL,
	[tienNoKH] [text] NOT NULL,
	[diaChi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[sdt] [text] NOT NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO





--tbl tạo bảng tblLoaiSach
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblLoaiSach]    Script Date: 01/06/2018 2:46:10 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiSach](
	[maLoaiSach] [int] NOT NULL,
	[tenLoaiSach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiSach] PRIMARY KEY CLUSTERED 
(
	[maLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO





--tạo bảng tblPhieuNhap
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 01/06/2018 2:46:45 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuNhap](
	[maPhieuNhap] [int] NOT NULL,
	[ngayNhap] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO





--tạo tblPhieuThuTien
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPhieuThuTien]    Script Date: 01/06/2018 2:47:02 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuThuTien](
	[maPhieuThu] [int] NOT NULL,
	[maKH] [int] NOT NULL,
	[ngayThuTien] [datetime2](7) NOT NULL,
	[soTienThu] [int] NOT NULL,
	[lyDoThu] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_tblPhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[maPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblPhieuThuTien]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuThuTien_tblKhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[tblKhachHang] ([maKH])
GO

ALTER TABLE [dbo].[tblPhieuThuTien] CHECK CONSTRAINT [FK_tblPhieuThuTien_tblKhachHang]
GO




--tạo tblQuyDinh
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblQuyDinh]    Script Date: 01/06/2018 2:47:26 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblQuyDinh](
	[id] [int] NOT NULL,
	[luongNhapToiThieu] [int] NOT NULL,
	[luongTonToiDa] [int] NOT NULL,
	[tienNoToiDa] [int] NOT NULL,
	[luongTonToiThieu] [int] NOT NULL,
	[apDung] [int] NOT NULL,
 CONSTRAINT [PK_tblQuyDinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




--tạo tblSach
USE [QLNS]
GO

/****** Object:  Table [dbo].[tblSach]    Script Date: 01/06/2018 2:47:40 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSach](
	[maSach] [int] NOT NULL,
	[tenSach] [nvarchar](50) NOT NULL,
	[maLoaiSach] [int] NOT NULL,
	[tacGia] [nvarchar](50) NOT NULL,
	[soLuongTon] [nchar](10) NOT NULL,
	[donGia] [int] NOT NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblLoaiSach] FOREIGN KEY([maLoaiSach])
REFERENCES [dbo].[tblLoaiSach] ([maLoaiSach])
GO

ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblLoaiSach]
GO





