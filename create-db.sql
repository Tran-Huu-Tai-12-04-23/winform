-- drop 

-- Tạo bảng TaiKhoan
CREATE DATABASE QUANLYKHOHANG2
go
USE QUANLYKHOHANG2
go
-- Create the TaiKhoan table
CREATE TABLE TaiKhoan (
    idTaiKhoan varchar(255) PRIMARY KEY,
    tenTaiKhoan nvarchar(255),
    matKhau nvarchar(255),
    email nvarchar(255),
    soDienThoai nvarchar(255),
    chucvu int
);

-- Create the PhanQuyen table
CREATE TABLE PhanQuyen (
    idPhanQuyen varchar(255) PRIMARY KEY,
    idTaiKhoan varchar(255),
    ngayBatDau DATE,
    ngayKetThuc DATE,
    quyenSua bit,
    quyenThem bit,
    quyenXoa bit,
    loaiQuyen INT,
    FOREIGN KEY (idTaiKhoan) REFERENCES TaiKhoan(idTaiKhoan)
);


go

-- Create the KhachHang table
CREATE TABLE KhachHang (
    idKhachHang varchar(255) PRIMARY KEY,
    tenKhachHang nvarchar(255),
    diaChi nvarchar(255),
    sdt varchar(11),
    hien bit DEFAULT 1
);



-- Create the LoaiBanh table
CREATE TABLE LoaiBanh (
    idLoaiBanh varchar(255) PRIMARY KEY,
    tenLoaiBanh nvarchar(255)
);


-- Create the Banh table
CREATE TABLE Banh (
    idBanh varchar(255) PRIMARY KEY,
    idLoaiBanh varchar(255),
    tenBanh nvarchar(255),
    giaTien float,
    hien bit,
    sl int,
    donVi nvarchar(255),
    FOREIGN KEY (idLoaiBanh) REFERENCES LoaiBanh(idLoaiBanh)
);

go 
Create table loaiHoaDon (
    idLoaiHoaDon varchar(255) PRIMARY KEY,
    tenLoaiHoaDon nvarchar(255)
);



go
-- Create the HoaDon table
CREATE TABLE HoaDon (
    idHoaDon VARCHAR(255) PRIMARY Key,
    idTaiKhoan varchar(255),
    idBoPhanXuat varchar(255) null,
    idKhachHang varchar(255) null, 
    idLoaiHoaDon VARCHAR(255),
    ngayXuat DATE,
    tongTien FLOAT default 0,
    soLuong int,
    FOREIGN KEY (idLoaiHoaDon) REFERENCES loaiHoaDon(idLoaiHoaDon),
    FOREIGN KEY (idBoPhanXuat) REFERENCES bophanxuat(idBoPhanXuat), 
    FOREIGN KEY (idKhachHang) REFERENCES KhachHang(idKhachHang), 
    FOREIGN KEY (idTaiKhoan) REFERENCES TaiKhoan(idTaiKhoan)

);


go


-- Create the HoaDoXuatNguyenLieu table
CREATE TABLE HoaDonXuatNguyenLieu (
    id VARCHAR(255) PRIMARY KEY,
    idNguyenLieu VARCHAR(255),
    idHoaDon VARCHAR(255),
    sl INT,
    tongTien FLOAT DEFAULT 0,
    UniqueId AS 'HD' + RIGHT('00000' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
    FOREIGN KEY (idNguyenLieu) REFERENCES NguyenLieu(idNguyenLieu),
    FOREIGN KEY (idHoaDon) REFERENCES HoaDon(idHoaDon)
);

go

-- Create the HoaDonXuatBanh table
CREATE TABLE HoaDonXuatBanh (
    id varchar(255),
    idHoaDon VARCHAR(255),
    sl INT,
    tongTien FLOAT DEFAULT 0,
    UniqueId AS 'HD' + RIGHT('00000' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
    idBanh varchar(255),
    FOREIGN KEY (idBanh) REFERENCES Banh(idBanh),
    FOREIGN KEY (idHoaDon) REFERENCES HoaDon(idHoaDon),
);


-- Create the HoaDonNhapNguyenLieu table
CREATE TABLE HoaDonNhapNguyenLieu (
    idNguyenLieu varchar(255),
    idTaiKhoan varchar(255),
    idKhachHang varchar(255),
    idHoaDon VARCHAR(255),
    sl INT,
    tongTien float,
    nhapTrong bit,
    FOREIGN KEY (idNguyenLieu) REFERENCES NguyenLieu(idNguyenLieu),
    FOREIGN KEY (idTaiKhoan) REFERENCES TaiKhoan(idTaiKhoan),
    FOREIGN KEY (idKhachHang) REFERENCES KhachHang(idKhachHang),
    FOREIGN Key (idHoaDon) REFERENCES HoaDon(idHoaDon)
);


-- Create the HoaDonNhapBanh table
CREATE TABLE HoaDonNhapBanh (
    idBanh varchar(255),
    idTaiKhoan varchar(255),
    idKhachHang varchar(255),
    idHoaDon varchar (255),
    soLuong INT,
    nhapTrong bit,
    tongTien float,
    FOREIGN KEY (idBanh) REFERENCES Banh(idBanh),
    FOREIGN KEY (idTaiKhoan) REFERENCES TaiKhoan(idTaiKhoan),
    FOREIGN KEY (idKhachHang) REFERENCES KhachHang(idKhachHang),
    FOREIGN Key (idHoaDon) REFERENCES HoaDon(idHoaDon)
);

-- Create the LoaiNguyenLieu table
CREATE TABLE LoaiNguyenLieu (
    idLoaiNguyenLieu varchar(255) PRIMARY KEY,
    tenLoaiNguyenLieu nvarchar(255)
);

-- Create the NguyenLieu table
CREATE TABLE NguyenLieu (
    idNguyenLieu varchar(255) PRIMARY KEY,
    idLoaiNguyenLieu varchar(255),
    tenNguyenLieu nvarchar(255),
    giaTien float,
    donVi nvarchar(255),
    hien bit,
    sl int,
    FOREIGN KEY (idLoaiNguyenLieu) REFERENCES LoaiNguyenLieu(idLoaiNguyenLieu)
);


-- Create the BoPhanXuat table
CREATE TABLE BoPhanXuat (
    idBoPhanXuat varchar(255) PRIMARY KEY,
    tenBoPhanXuat nvarchar(255)
);
go 

-- add morte tabloe 
-- CREATE TABLE TonKhoBanh (
--     idBanh varchar(255),
--     soluong INT,
--     FOREIGN KEY (idBanh) REFERENCES Banh(idBanh)
-- );

-- CREATE TABLE TonKhoNguyenLieu (
--     idNguyenLieu varchar(255) ,
--     soluong INT,
--     FOREIGN KEY (idNguyenLieu) REFERENCES NguyenLieu(idNguyenLieu)
-- );

