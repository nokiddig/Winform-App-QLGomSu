/****** Object:  Table [dbo].[tChiTietHDB]    Script Date: 10/31/2022 18:12:09 ******/
CREATE DATABASE QLBanGomSu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChiTietHDB](
	[SoHDB] [varchar](10) NOT NULL,
	[MaHang] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[GiamGia] [float] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_ChiTietHDB] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChiTietHDN]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChiTietHDN](
	[SoHDN] [varchar](10) NOT NULL,
	[MaHang] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [money] NULL,
	[GiamGia] [float] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_ChiTietHDN] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tCongDung]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCongDung](
	[MaCongDung] [varchar](10) NOT NULL,
	[TenCongDung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CongDung] PRIMARY KEY CLUSTERED 
(
	[MaCongDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tCongViec]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCongViec](
	[MaCV] [varchar](10) NOT NULL,
	[TenCV] [nvarchar](20) NOT NULL,
	[MucLuong] [money] NULL,
 CONSTRAINT [PK_CongViec] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tHangHoa]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tHangHoa](
	[MaHang] [varchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[MaLoai] [varchar](10) NULL,
	[MaKichThuoc] [varchar](10) NULL,
	[MaCongDung] [varchar](10) NULL,
	[MaLoaiMen] [varchar](10) NULL,
	[MaHinhKhoi] [varchar](10) NULL,
	[MaHoaVan] [varchar](10) NULL,
	[MaMau] [varchar](10) NULL,
	[MaNuoc] [varchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [money] NULL,
	[DonGiaBan] [money] NULL,
	[ThoiGianBaoHanh] [int] NULL,
	[Anh] [text] NULL,
	[GhiChu] [text] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tHinhKhoi]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tHinhKhoi](
	[MaHinhKhoi] [varchar](10) NOT NULL,
	[TenHinhKhoi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HinhKhoi] PRIMARY KEY CLUSTERED 
(
	[MaHinhKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tHoaDonBan]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tHoaDonBan](
	[SoHDB] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[NgayBan] [datetime] NULL,
	[MaKhach] [varchar](10) NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDonBan] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tHoaDonNhap]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tHoaDonNhap](
	[SoHDN] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[NgayNhap] [datetime] NULL,
	[MaNCC] [varchar](10) NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tHoaVan]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tHoaVan](
	[MaHoaVan] [varchar](10) NOT NULL,
	[TenHoaVan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HoaVan] PRIMARY KEY CLUSTERED 
(
	[MaHoaVan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tKhachHang]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tKhachHang](
	[MaKhach] [varchar](10) NOT NULL,
	[TenKhach] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NULL,
 CONSTRAINT [PK_MaKhach] PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tKichThuoc]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tKichThuoc](
	[MaKichThuoc] [varchar](10) NOT NULL,
	[TenKichThuoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KichThuoc] PRIMARY KEY CLUSTERED 
(
	[MaKichThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tLoai]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tLoai](
	[MaLoai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tMauSac]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tMauSac](
	[MaMau] [varchar](10) NOT NULL,
	[TenMau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Mau] PRIMARY KEY CLUSTERED 
(
	[MaMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tMen]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tMen](
	[MaLoaiMen] [varchar](10) NOT NULL,
	[TenLoaiMen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Men] PRIMARY KEY CLUSTERED 
(
	[MaLoaiMen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tNhaCungCap]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tNhaCungCap](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tNhanVien]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tNhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[DienThoai] [varchar](20) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaCV] [varchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tNuocSanXuat]    Script Date: 10/31/2022 18:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tNuocSanXuat](
	[MaNuoc] [varchar](10) NOT NULL,
	[TenNuoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Nuoc] PRIMARY KEY CLUSTERED 
(
	[MaNuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD01', N'Đồ trang trí')
INSERT [dbo].[tCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD02', N'Đồ thờ cúng')
INSERT [dbo].[tCongDung] ([MaCongDung], [TenCongDung]) VALUES (N'CD03', N'Đồ gia dụng')
GO
INSERT [dbo].[tCongViec] ([MaCV], [TenCV], [MucLuong]) VALUES (N'NV', N'Nhân viên', NULL)
INSERT [dbo].[tCongViec] ([MaCV], [TenCV], [MucLuong]) VALUES (N'QL', N'Quản lý', NULL)
GO
INSERT [dbo].[tHangHoa] ([MaHang], [TenHang], [MaLoai], [MaKichThuoc], [MaCongDung], [MaLoaiMen], [MaHinhKhoi], [MaHoaVan], [MaMau], [MaNuoc], [SoLuong], [DonGiaNhap], [DonGiaBan], [ThoiGianBaoHanh], [Anh], [GhiChu]) VALUES (N'HH01', N'Bình Hoa Sơn Mài Khắc Phố Quê, Dáng Trụ, Có Tai', N'L02', N'KT02', N'CD01', N'MEN03', N'HK01', N'HV20', N'MAU05', N'N01', 100, 3500000.0000, 3800000.0000, 12, N'https://bizweb.dktcdn.net/thumb/large/100/435/747/products/thiet-ke-chua-co-ten-2-1665652077984.jpg?v=1665657678943', NULL)
INSERT [dbo].[tHangHoa] ([MaHang], [TenHang], [MaLoai], [MaKichThuoc], [MaCongDung], [MaLoaiMen], [MaHinhKhoi], [MaHoaVan], [MaMau], [MaNuoc], [SoLuong], [DonGiaNhap], [DonGiaBan], [ThoiGianBaoHanh], [Anh], [GhiChu]) VALUES (N'HH02', N'123', N'L01', N'KT01', N'CD01', N'MEN01', N'HK02', N'HV03', N'MAU02', N'N01', 123, 123.0000, 123.0000, 123, N'123', N'123')
INSERT [dbo].[tHangHoa] ([MaHang], [TenHang], [MaLoai], [MaKichThuoc], [MaCongDung], [MaLoaiMen], [MaHinhKhoi], [MaHoaVan], [MaMau], [MaNuoc], [SoLuong], [DonGiaNhap], [DonGiaBan], [ThoiGianBaoHanh], [Anh], [GhiChu]) VALUES (N'HH03', N'Bình Gốm Sơn Mài Cô Gái Đại Dương', N'L03', N'KT01', N'CD01', N'MEN03', N'HK01', N'HV18', N'MAU05', N'N01', 100, 3000000.0000, 3200000.0000, 6, N'https://bizweb.dktcdn.net/thumb/large/100/435/747/products/thiet-ke-chua-co-ten-2-1665636570679.jpg?v=1665653506480', N'123')
GO
INSERT [dbo].[tHinhKhoi] ([MaHinhKhoi], [TenHinhKhoi]) VALUES (N'HK01', N'Cơ bản')
INSERT [dbo].[tHinhKhoi] ([MaHinhKhoi], [TenHinhKhoi]) VALUES (N'HK02', N'Động vật')
INSERT [dbo].[tHinhKhoi] ([MaHinhKhoi], [TenHinhKhoi]) VALUES (N'HK03', N'Người')
INSERT [dbo].[tHinhKhoi] ([MaHinhKhoi], [TenHinhKhoi]) VALUES (N'HK04', N'Dân gian')
GO
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV01', N'Phù dung')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV02', N'Mây')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV03', N'Ngựa')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV04', N'Ong')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV05', N'Phật thủ')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV06', N'Đào')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV07', N'Phụng hoàng')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV08', N'Rồng')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV09', N'Rùa')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV10', N'Sách')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV11', N'Sen')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV12', N'Tam đa')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV13', N'Thất hiền')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV14', N'Thuỷ tiên')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV15', N'Trầu cau')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV16', N'Trúc')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV17', N'Ve sầu')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV18', N'Người')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV19', N'Cây cối')
INSERT [dbo].[tHoaVan] ([MaHoaVan], [TenHoaVan]) VALUES (N'HV20', N'Phố quê')
GO
INSERT [dbo].[tKichThuoc] ([MaKichThuoc], [TenKichThuoc]) VALUES (N'KT01', N'16x35')
INSERT [dbo].[tKichThuoc] ([MaKichThuoc], [TenKichThuoc]) VALUES (N'KT02', N'18x32')
GO
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L01', N'Đồ gốm đất nung')
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L02', N'Đồ gốm sành thô')
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L03', N'Đồ gốm sành mịn')
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L04', N'Đồ bán sứ')
INSERT [dbo].[tLoai] ([MaLoai], [TenLoai]) VALUES (N'L05', N'Đồ sứ')
GO
INSERT [dbo].[tMauSac] ([MaMau], [TenMau]) VALUES (N'MAU01', N'Xanh')
INSERT [dbo].[tMauSac] ([MaMau], [TenMau]) VALUES (N'MAU02', N'Đỏ')
INSERT [dbo].[tMauSac] ([MaMau], [TenMau]) VALUES (N'MAU03', N'Vàng')
INSERT [dbo].[tMauSac] ([MaMau], [TenMau]) VALUES (N'MAU04', N'Lục')
INSERT [dbo].[tMauSac] ([MaMau], [TenMau]) VALUES (N'MAU05', N'Lam')
INSERT [dbo].[tMauSac] ([MaMau], [TenMau]) VALUES (N'MAU06', N'Chàm')
INSERT [dbo].[tMauSac] ([MaMau], [TenMau]) VALUES (N'MAU07', N'Tím')
GO
INSERT [dbo].[tMen] ([MaLoaiMen], [TenLoaiMen]) VALUES (N'MEN01', N'Men chảy')
INSERT [dbo].[tMen] ([MaLoaiMen], [TenLoaiMen]) VALUES (N'MEN02', N'Men sần')
INSERT [dbo].[tMen] ([MaLoaiMen], [TenLoaiMen]) VALUES (N'MEN03', N'Men lam')
INSERT [dbo].[tMen] ([MaLoaiMen], [TenLoaiMen]) VALUES (N'MEN04', N'Men nâu')
INSERT [dbo].[tMen] ([MaLoaiMen], [TenLoaiMen]) VALUES (N'MEN05', N'Men rêu')
INSERT [dbo].[tMen] ([MaLoaiMen], [TenLoaiMen]) VALUES (N'MEN06', N'Men rạn')
INSERT [dbo].[tMen] ([MaLoaiMen], [TenLoaiMen]) VALUES (N'MEN07', N'Men ngọc')
GO
INSERT [dbo].[tNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaCV]) VALUES (N'NV01', N'Lê Xuân Quỳnh', 0, CAST(N'2002-09-23T00:00:00.000' AS DateTime), N'0906144873', N'Hà Nam', N'NV')
INSERT [dbo].[tNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaCV]) VALUES (N'NV02', N'Lê Văn Sỹ', 0, NULL, NULL, N'Nghệ An', N'QL')
INSERT [dbo].[tNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaCV]) VALUES (N'NV03', N'Lương Văn Duy', 0, NULL, NULL, N'Quảng Ninh', N'NV')
INSERT [dbo].[tNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaCV]) VALUES (N'NV04', N'Phạm Trung Hiếu', 0, NULL, NULL, N'Hà Nội', N'NV')
INSERT [dbo].[tNhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [MaCV]) VALUES (N'NV05', N'Nguyễn Minh Ngọc', 1, NULL, NULL, N'Hà Nội', N'QL')
GO
INSERT [dbo].[tNuocSanXuat] ([MaNuoc], [TenNuoc]) VALUES (N'N01', N'Việt Nam')
INSERT [dbo].[tNuocSanXuat] ([MaNuoc], [TenNuoc]) VALUES (N'N02', N'Trung Quốc')
INSERT [dbo].[tNuocSanXuat] ([MaNuoc], [TenNuoc]) VALUES (N'N03', N'Nhật Bản')
INSERT [dbo].[tNuocSanXuat] ([MaNuoc], [TenNuoc]) VALUES (N'N04', N'Thái Lan')
INSERT [dbo].[tNuocSanXuat] ([MaNuoc], [TenNuoc]) VALUES (N'N05', N'Nhật Bản')
GO
ALTER TABLE [dbo].[tNhanVien] ADD  DEFAULT ((0)) FOR [GioiTinh]
GO
ALTER TABLE [dbo].[tChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDB_MaHang] FOREIGN KEY([SoHDB])
REFERENCES [dbo].[tHangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[tChiTietHDB] CHECK CONSTRAINT [FK_ChiTietHDB_MaHang]
GO
ALTER TABLE [dbo].[tChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDB_SoHDB] FOREIGN KEY([SoHDB])
REFERENCES [dbo].[tHoaDonBan] ([SoHDB])
GO
ALTER TABLE [dbo].[tChiTietHDB] CHECK CONSTRAINT [FK_ChiTietHDB_SoHDB]
GO
ALTER TABLE [dbo].[tChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDN_MaHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[tHangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[tChiTietHDN] CHECK CONSTRAINT [FK_ChiTietHDN_MaHang]
GO
ALTER TABLE [dbo].[tChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDN_SoHDN] FOREIGN KEY([SoHDN])
REFERENCES [dbo].[tHoaDonNhap] ([SoHDN])
GO
ALTER TABLE [dbo].[tChiTietHDN] CHECK CONSTRAINT [FK_ChiTietHDN_SoHDN]
GO
ALTER TABLE [dbo].[tHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaCongDung] FOREIGN KEY([MaCongDung])
REFERENCES [dbo].[tCongDung] ([MaCongDung])
GO
ALTER TABLE [dbo].[tHangHoa] CHECK CONSTRAINT [FK_HangHoa_MaCongDung]
GO
ALTER TABLE [dbo].[tHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaHinhKhoi] FOREIGN KEY([MaHinhKhoi])
REFERENCES [dbo].[tHinhKhoi] ([MaHinhKhoi])
GO
ALTER TABLE [dbo].[tHangHoa] CHECK CONSTRAINT [FK_HangHoa_MaHinhKhoi]
GO
ALTER TABLE [dbo].[tHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaHoaVan] FOREIGN KEY([MaHoaVan])
REFERENCES [dbo].[tHoaVan] ([MaHoaVan])
GO
ALTER TABLE [dbo].[tHangHoa] CHECK CONSTRAINT [FK_HangHoa_MaHoaVan]
GO
ALTER TABLE [dbo].[tHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaKichThuoc] FOREIGN KEY([MaKichThuoc])
REFERENCES [dbo].[tKichThuoc] ([MaKichThuoc])
GO
ALTER TABLE [dbo].[tHangHoa] CHECK CONSTRAINT [FK_HangHoa_MaKichThuoc]
GO
ALTER TABLE [dbo].[tHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[tLoai] ([MaLoai])
GO
ALTER TABLE [dbo].[tHangHoa] CHECK CONSTRAINT [FK_HangHoa_MaLoai]
GO
ALTER TABLE [dbo].[tHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaLoaiMen] FOREIGN KEY([MaLoaiMen])
REFERENCES [dbo].[tMen] ([MaLoaiMen])
GO
ALTER TABLE [dbo].[tHangHoa] CHECK CONSTRAINT [FK_HangHoa_MaLoaiMen]
GO
ALTER TABLE [dbo].[tHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaMau] FOREIGN KEY([MaMau])
REFERENCES [dbo].[tMauSac] ([MaMau])
GO
ALTER TABLE [dbo].[tHangHoa] CHECK CONSTRAINT [FK_HangHoa_MaMau]
GO
ALTER TABLE [dbo].[tHangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaNuoc] FOREIGN KEY([MaNuoc])
REFERENCES [dbo].[tNuocSanXuat] ([MaNuoc])
GO
ALTER TABLE [dbo].[tHangHoa] CHECK CONSTRAINT [FK_HangHoa_MaNuoc]
GO
ALTER TABLE [dbo].[tHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan_MaKhach] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[tKhachHang] ([MaKhach])
GO
ALTER TABLE [dbo].[tHoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan_MaKhach]
GO
ALTER TABLE [dbo].[tHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tHoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan_MaNV]
GO
ALTER TABLE [dbo].[tHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_MaNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tHoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_MaNCC]
GO
ALTER TABLE [dbo].[tHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tHoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_MaNV]
GO
ALTER TABLE [dbo].[tNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_MaCV] FOREIGN KEY([MaCV])
REFERENCES [dbo].[tCongViec] ([MaCV])
GO
ALTER TABLE [dbo].[tNhanVien] CHECK CONSTRAINT [FK_NhanVien_MaCV]
GO
