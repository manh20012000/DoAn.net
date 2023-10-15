create database QLDatTour
go
use QLDatTour
create table TaiKhoan
(
MaUser int IDENTITY(1,1) primary key,
TenDangNhap nvarchar(50),
MatKhau nvarchar(50)
)
create table PhuongTien
(
MaPhuongTien varchar(200) primary key,
TenPhuongTien nvarchar(50),

)
create table KhachSan 
(
MaKhachSan int IDENTITY(1,1) primary key,
TenKhachSan nvarchar(50),
DiaChi nvarchar(50),
Gia float,

)
create table DiaDiem
(
MaDiaDiem int IDENTITY(1,1) primary key,
TenDiaDiem nvarchar(50),
DiaChi nvarchar(150)
)
create table TourDL
(
MaTour int IDENTITY(1,1) primary key,
Anh varchar(255),
TenTour nvarchar(50),
NgayKhoiHang date,
NgayKetThuc date,
DiemDon nvarchar(50),
Mota nvarchar(50),
MaDiaDiem int foreign key references DiaDiem(MaDiaDiem),
GiaTien float
)

create table TaoPhieuDangKy
(
MaPhieu int IDENTITY(1,1) primary key,

NgayDat date,
ThanhTien float,
MaTour int foreign key references TourDL(MaTour),
NgayTaoPhieu date,
MaPhuongTien varchar(200) foreign key references PhuongTien(MaPhuongTien),
MaKhachSan int foreign key references KhachSan(MaKhachSan),
HoTen nvarchar(50),
GioiTinh nvarchar(50),
SDT int,
QueQuan nvarchar(50),
NgaySinh date,
Email nvarchar(50),
)
create table NhanVien (
MaNhanVien int IDENTITY(1,1)  primary key ,
HoTen nvarchar(50),
GioiTinh nvarchar(50),
SDT int,
QueQuan nvarchar(50),
NgaySinh date,
Email nvarchar(50),
MaTour int foreign key references TourDL(MaTour),
MaPhieu int foreign key references TaoPhieuDangKy(MaPhieu)
)
create table ThongKe 
(
MaThongKe int IDENTITY(1,1) primary key,
NgayThongKe date,
SoPhieuDangKy int,
TongSoTienDatTour float,
MaPhieu int foreign key references TaoPhieuDangKy(MaPhieu)
)
create table Quanly 
(
MaQuanLy int IDENTITY(1,1) primary key,
HoTen nvarchar(50),
GioiTinh nvarchar(50),
Tuoi int,
SDT int,
QueQuan nvarchar(50),
NgaySinh date,
Email nvarchar(50),
MaThongKe int foreign key references ThongKe(MaThongKe)
)