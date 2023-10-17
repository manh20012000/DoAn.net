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
DiaChi nvarchar(50)
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
Mota nvarchar(50),
MaDiaDiem int foreign key references DiaDiem(MaDiaDiem),
GiaTien Money,
NgayKhoiHanh date,
NgayKetThuc date,
DiemDon nvarchar(50),
MaPhuongTien varchar(200) foreign key references PhuongTien(MaPhuongTien),
MaKhachSan int foreign key references KhachSan(MaKhachSan),
SoVe int 
)
create table NhanVien (
MaNhanVien int IDENTITY(1,1)  primary key ,
HoTen nvarchar(50),
GioiTinh nvarchar(50),
SDT varchar(20),
QueQuan nvarchar(50),
NgaySinh date,
Email nvarchar(50)
)
create table KhachHang 
(
MaKhachHang int IDENTITY(1,1)  primary key,
HoTen nvarchar(50),
GioiTinh nvarchar(50),
SDT varchar(20),
QueQuan nvarchar(50),
NgaySinh date
)
create table TaoPhieuDangKy
(
MaPhieu int IDENTITY(1,1) primary key,
ThanhTien float,
MaTour int foreign key references TourDL(MaTour),
NgayTaoPhieu date,
MaNhanVien int foreign key references NhanVien(MaNhanVien),
MaKhachHang int foreign key references KhachHang(MaKhachHang)
)

create table ThongKe 
(
MaThongKe int IDENTITY(1,1) primary key,
NgayThongKe date,
SoPhieuDangKy int,
TongSoTienDatTour float
)
