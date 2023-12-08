CREATE PROCEDURE InsertHoaDonXuatBanh
    @idBanh VARCHAR(255),
    @idHoaDon VARCHAR(255),
    @sl INT,
    @tongTien FLOAT
AS
BEGIN
    INSERT INTO HoaDonXuatBanh( idBanh, idHoaDon, sl, tongTien)
    VALUES ( @idBanh, @idHoaDon, @sl, @tongTien);
	Update HoaDon SET soLuong =(Select sum(sl) from HoaDonXuatBanh  where idHoaDon = @idHoaDon),tongTien=(select sum(tongTien) from HoaDonXuatBanh where idHoaDon =@idHoaDon) where idHoaDon =@idHoaDon
END;
go
CREATE PROCEDURE InsertHoaDonNhapBanhNgoai
    @idBanh VARCHAR(255),
    @idHoaDon VARCHAR(255),
	@idKhachHang varchar(255),
    @sl INT,
    @tongTien FLOAT
AS
BEGIN
    INSERT INTO HoaDonNhapBanh( idBanh,idKhachHang, idHoaDon, soLuong, tongTien,nhapTrong)
    VALUES ( @idBanh,@idKhachHang, @idHoaDon, @sl, @tongTien,0);

    -- Cập nhật thông tin trong bảng HoaDon
    UPDATE HoaDon
    SET soLuong = (SELECT SUM(soLuong) FROM HoaDonNhapBanh WHERE idHoaDon = @idHoaDon),
        tongTien = (SELECT SUM(tongTien) FROM HoaDonNhapBanh WHERE idHoaDon = @idHoaDon)
    WHERE idHoaDon = @idHoaDon;
END;


EXEC InsertHoaDonNhapBanhNgoai '1','0008','1',2,90
select * from HoaDonXuatBanh
go
CREATE PROCEDURE GetHoaDonXuatBanh
    @idHoaDon VARCHAR(255)
AS
BEGIN
	Select * from HoaDonXuatBanh where idHoaDon = @idHoaDon
END;
go
CREATE PROCEDURE GetHoaDonNhapBanh
    @idHoaDon VARCHAR(255),
	@trong bit
AS
BEGIN
	Select * from HoaDonNhapBanh where idHoaDon = @idHoaDon and nhapTrong=@trong
END;
EXEC GetHoaDonNhapBanh '0003',0

go
CREATE PROCEDURE GetHoaDon
    @idHoaDon VARCHAR(255)
AS
BEGIN
	Select * from HoaDon where idHoaDon = @idHoaDon
END;
go
EXEC GetBakeById '1'
go
CREATE PROCEDURE GetBakeById
    @idBanh VARCHAR(255)
AS
BEGIN
	Select * from Banh where idBanh = @idBanh
END;
go
CREATE PROCEDURE nameTypeOfBake(@idLoaiBanh VARCHAR(255), @tenLoaiBanh VARCHAR(255) OUTPUT)
AS
BEGIN
    SET @tenLoaiBanh = (SELECT tenLoaiBanh FROM LoaiBanh WHERE idLoaiBanh = @idLoaiBanh)
END

go
Create Procedure idTypeOfBake(@tenLoaiBanh varchar(255),@idLoaiBanh varchar(255) Output)
As
Begin	
	Set @idLoaiBanh =(Select idLoaiBanh from LoaiBanh where tenLoaiBanh = @tenLoaiBanh )
End
go 

CREATE PROCEDURE DeleteHoaDon
    @idHoaDon VARCHAR(255)
AS
BEGIN
		Delete from HoaDonXuatBanh where idHoaDon=@idHoaDon
		Delete from HoaDonNhapBanh where idHoaDon=@idHoaDon
		Delete from HoaDon where idHoaDon=@idHoaDon
END;
go
CREATE PROCEDURE DeleteDetailBillByIdBillAndIdBake
    @idHoaDon VARCHAR(255),
	@idBanh Varchar(255),
	@table varchar(255)
AS
BEGIN
		if @table ='HoaDonXuatBanh'
			Begin
				UPDATE Banh SET  sl =sl+ (Select sl from HoaDonXuatBanh  where idHoaDon = @idHoaDon and idBanh = @idBanh) WHERE idBanh = @idBanh;
				Delete from HoaDonXuatBanh where idHoaDon = @idHoaDon and idBanh = @idBanh
				--Update HoaDon SET soLuong =0,tongTien=0 where idHoaDon = @idHoaDon
				if (select count(*) from HoaDonXuatBanh where idHoaDon =@idHoaDon)>0
					Update HoaDon SET soLuong =soLuong- (Select sl from HoaDonXuatBanh  where idHoaDon = @idHoaDon and idBanh = @idBanh),tongTien=tongTien-(select tongTien from HoaDonXuatBanh where idHoaDon =@idHoaDon and idBanh = @idBanh) where idHoaDon =@idHoaDon
				else
					Update HoaDon SET soLuong=0,tongTien=0  where idHoaDon =@idHoaDon
			end
		else if @table ='HoaDonNhapBanh'
			begin
				UPDATE Banh SET  sl =sl- (Select soLuong from HoaDonNhapBanh  where idHoaDon = @idHoaDon and idBanh = @idBanh) WHERE idBanh = @idBanh;
				Delete from HoaDonNhapBanh where idHoaDon = @idHoaDon and idBanh = @idBanh
				--Update HoaDon SET soLuong =0,tongTien=0 where idHoaDon = @idHoaDon
				if (select count(*) from HoaDonNhapBanh where idHoaDon =@idHoaDon)>0
					Update HoaDon SET soLuong =soLuong- (Select soLuong from HoaDonNhapBanh  where idHoaDon = @idHoaDon and idBanh = @idBanh),tongTien=tongTien-(select tongTien from HoaDonNhapBanh where idHoaDon =@idHoaDon and idBanh = @idBanh) where idHoaDon =@idHoaDon
				else
					Update HoaDon SET soLuong=0,tongTien=0  where idHoaDon =@idHoaDon
			end
END;
EXEC DeleteDetailBillByIdBillAndIdBake '0002','6','HoaDonNhapBanh'

select * from HoaDonNhapBanh
SELECT * FROM HoaDon
select * from TonKhoBanh
select * from Banh
delete from HoaDonXuatBanh
delete from HoaDon 

go
CREATE PROC UpdateHoaDon(
    @idHoaDon varchar(255),
    @tongTien float,
    @sl int)
AS
BEGIN
    UPDATE HoaDon
    SET tongTien = @tongTien, soLuong = @sl
    WHERE idHoaDon = @idHoaDon;
END

go
CREATE PROCEDURE GetAllBake(
    @hien bit)
AS
BEGIN
	SELECT * FROM Banh WHERE hien = @hien;

END
EXEC GetAllBake '1'
go
CREATE PROCEDURE GetBakeByName(
    @tenBanh nvarchar(255))
AS
BEGIN
	SELECT * FROM Banh WHERE tenBanh = @tenBanh;

END
EXEC GetBakeByName N'Bánh 1'
go
CREATE PROCEDURE nameTypeOfBake(@idLoaiBanh VARCHAR(255), @tenLoaiBanh VARCHAR(255) OUTPUT)
AS
BEGIN
    SET @tenLoaiBanh = (SELECT tenLoaiBanh FROM LoaiBanh WHERE idLoaiBanh = @idLoaiBanh)
END

go
Create Procedure idTypeOfBake(@tenLoaiBanh varchar(255),@idLoaiBanh varchar(255) Output)
As
Begin	
	Set @idLoaiBanh =(Select idLoaiBanh from LoaiBanh where tenLoaiBanh = @tenLoaiBanh )
End
GO
CREATE PROCEDURE GetInvoiceGoByDateCUATRUONG
    @dateOfInvoice DATE,
	@typeInvoice varchar(255)
AS
BEGIN
    SELECT DISTINCT
        D.idHoaDon,
        D.idLoaiHoaDon,
        D.ngayXuat,
        D.idTaiKhoan,
        D.tongTien AS tongTienHoaDon,
        D.soLuong AS soLuongHoaDon,
        B.tenBoPhanXuat,
		D.idBoPhanXuat
    FROM
        HoaDon D
    JOIN
        BoPhanXuat B ON D.idBoPhanXuat = B.idBoPhanXuat
    WHERE
        D.ngayXuat = @dateOfInvoice
        AND D.idLoaiHoaDon = @typeInvoice;
END;
EXEC GetInvoiceGoByDateCUATRUONG '2023-12-8','11'
INSERT INTO Banh(idBanh, idLoaiBanh, tenBanh, sl, giaTien, donVi, hien) VALUES
('1', '1', N'Bánh 1', 100, 45, N'Hộp', 1),
('2', '1', N'Bánh 2', 150, 45, N'Hộp', 1),
('3', '2', N'Bánh 3', 120, 45, N'Hộp', 1),
('4', '3', N'Bánh 4', 80, 45, N'Hộp', 1),
('5', '3', N'Bánh 5', 200, 45, N'Hộp', 1),
('6', '4', N'Bánh 6', 90, 45, N'Hộp', 1),
('7', '4', N'Bánh 7', 130, 45, N'Hộp', 1),
('8', '5', N'Bánh 8', 180, 45, N'Hộp', 1),
('9', '5', N'Bánh 9', 110, 45, N'Hộp', 1),
('10', '1', N'Bánh 10', 160, 45, N'Hộp', 1);
INSERT INTO KhachHang(idKhachHang, tenKhachHang, diaChi, sdt, hien) VALUES
('1',N'Khải',N'Quận 7','0935678345',1),
('2',N'Bùi',N'Quận 7','0935678346',1),
('3',N'Tài',N'Quận 7','0935678347',1),
('4',N'Trường',N'Quận 7','0935678348',1);

delete from HoaDonNhapBanh
select * from KhachHang
select * from HoaDonXuatBanh
SELECT * FROM HoaDon
select * from TonKhoBanh
select * from Banh
delete from HoaDonXuatBanh
delete from HoaDon 