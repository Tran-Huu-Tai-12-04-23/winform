-- view 
go

CREATE VIEW CountAccountWithEmail AS
SELECT email, COUNT(*) AS AccountCount
FROM TaiKhoan
GROUP BY email;


go

CREATE VIEW CountAccountWithPhoneNumber AS
SELECT soDienThoai , COUNT(*) AS AccountCount
FROM TaiKhoan
GROUP BY soDienThoai;

go 
CREATE VIEW CountAccountWithUserName AS
SELECT tenTaiKhoan , COUNT(*) AS AccountCount
FROM TaiKhoan
GROUP BY tenTaiKhoan;
go


CREATE VIEW View_GetAllKhachHang AS
SELECT *
FROM KhachHang

go


go
CREATE VIEW Count_Customer
AS
SELECT COUNT(*) AS TotalCustomers
FROM KhachHang ;
go
CREATE VIEW Count_Customer_Active
AS
SELECT COUNT(*) AS TotalCustomers
FROM KhachHang WHERE hien = 1;
go


CREATE VIEW KhachHangHien AS
SELECT * FROM KhachHang WHERE hien = 1;

go 
CREATE VIEW GetBoPhanXuat AS
SELECT * FROM BoPhanXuat;


go
---
CREATE VIEW PhanQuyenView AS
SELECT distinct PhanQuyen.*, TaiKhoan.tenTaiKhoan FROM PhanQuyen, TaiKhoan where PhanQuyen.idTaiKhoan = TaiKhoan.idTaiKhoan
go


CREATE PROCEDURE GetPaginatedData
    @table NVARCHAR(128),
    @page INT = 0,
    @size INT = 10
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @offset INT = @page * @size;
    
    SET @sql = N'SELECT * FROM ' + QUOTENAME(@table) + 
               N' ORDER BY (SELECT NULL) OFFSET ' + CAST(@offset AS NVARCHAR(10)) + ' ROWS FETCH NEXT ' + CAST(@size AS NVARCHAR(10)) + ' ROWS ONLY';
    
    EXEC sp_executesql @sql;
END;
GO


-- Create a view to retrieve information from the HoaDonXuatNguyenLieu table
CREATE VIEW View_HoaDonXuatNguyenLieuHuy AS
SELECT
distinct 
    D.idHoaDon,
    D.idLoaiHoaDon,
    D.ngayXuat,
    D.idTaiKhoan,
    D.tongTien AS tongTienHoaDon,
    D.soLuong AS soLuongHoaDon,
    B.tenBoPhanXuat
FROM
    HoaDon D
JOIN
    BoPhanXuat B ON D.idBoPhanXuat = B.idBoPhanXuat
JOIN
    LoaiHoaDon LH ON D.idLoaiHoaDon = '2';


go 

CREATE VIEW ViewTinhTonKhoBanh AS
SELECT SUM(sl) AS TonKho from banh

go 

CREATE VIEW ViewTinhTonKhoNguyenLieu AS
SELECT SUM(sl) AS TonKho from NguyenLieu

go 

SELECT HDXNL.idHoaDon, SUM(HDXNL.sl * NL.giaTien) AS TotalAmount
FROM HoaDonXuatNguyenLieu HDXNL
INNER JOIN NguyenLieu NL ON HDXNL.idNguyenLieu = NL.idNguyenLieu
INNER JOIN HoaDon HD ON HDXNL.idHoaDon = HD.idHoaDon
WHERE HD.ngayXuat BETWEEN @StartDate AND @EndDate
GROUP BY HDXNL.idHoaDon;

go 

SELECT HDXB.idHoaDon, SUM(HDXB.sl * B.giaTien) AS TotalAmount
FROM HoaDonXuatBanh HDXB
INNER JOIN Banh B ON HDXB.idBanh = B.idBanh
INNER JOIN HoaDon HD ON HDXB.idHoaDon = HD.idHoaDon
WHERE HD.ngayXuat BETWEEN @StartDate AND @EndDate
GROUP BY HDXB.idHoaDon;
