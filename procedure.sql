

--Tạo Tài Khoản
GO
CREATE PROCEDURE CreateNewAccount(
    @tenTaiKhoan VARCHAR(255),
    @matKhau VARCHAR(255),
    @email VARCHAR(255),
    @soDienThoai VARCHAR(255))
AS
BEGIN
    DECLARE @maxStt INT;
    DECLARE @idTaiKhoan NVARCHAR(255);

    DECLARE @hien bit;
    SET @hien = 1;

    SELECT @maxStt = ISNULL(CAST(MAX(idTaiKhoan) as int), 0) FROM TaiKhoan ;
    IF (@maxStt >= 100 )
        SET @idTaiKhoan = CAST(@maxStt + 1 AS NVARCHAR(4));
    ELSE IF (@maxStt >= 9 and @maxStt < 99)
        SET @idTaiKhoan = '0' + CAST((@maxStt + 1) AS NVARCHAR(3));
    ELSE
        SET @idTaiKhoan = '00' + CAST(@maxStt + 1 AS NVARCHAR(2));

    INSERT INTO TaiKhoan (idTaiKhoan, tenTaiKhoan, matKhau, email, soDienThoai, chucvu)
    VALUES (@idTaiKhoan, @tenTaiKhoan, @matKhau, @email, @soDienThoai, 0);
END


go

CREATE PROCEDURE CreateNewPhanQuyen(
    @ngayBatDau DATE,
    @ngayKetThuc DATE,
    @quyenSua BIT,
    @quyenThem BIT,
    @quyenXoa BIT,
    @idTaiKhoan varchar(255)
   )
AS
BEGIN
    DECLARE @maxStt INT;
    DECLARE @idPhanQuyen NVARCHAR(255);

    DECLARE @hien bit;
    SET @hien = 1;

    SELECT @maxStt = ISNULL(CAST(MAX(idPhanQuyen) as int), 0) FROM PhanQuyen ;
    IF (@maxStt >= 100 )
        SET @idPhanQuyen = CAST(@maxStt + 1 AS NVARCHAR(4));
    ELSE IF (@maxStt >= 9 and @maxStt < 99)
        SET @idPhanQuyen = '0' + CAST((@maxStt + 1) AS NVARCHAR(3));
    ELSE
        SET @idPhanQuyen = '00' + CAST(@maxStt + 1 AS NVARCHAR(2));

    INSERT INTO PhanQuyen (idPhanQuyen, ngayBatDau, ngayKetThuc, quyenSua, quyenThem, quyenXoa, loaiQuyen)
    VALUES (@idTaiKhoan, @ngayBatDau, @ngayKetThuc, @quyenSua, @quyenThem, @quyenXoa, 0);
END
go



go
CREATE PROCEDURE UpdateDecentralization(
    @idPhanQuyen varchar(255),
    @ngayBatDau Date,
    @ngayKetThuc Date,
    @quyenThem bit,
    @quyenSua bit,
    @quyenXoa bit )
AS
BEGIN

    UPDATE PhanQuyen
    SET ngayBatDau = @ngayBatDau,
        ngayKetThuc = @ngayKetThuc,
        quyenThem = @quyenThem,
        quyenSua = @quyenSua,
        quyenXoa = @quyenXoa
    WHERE idPhanQuyen = @idPhanQuyen
    
END
GO
CREATE PROCEDURE CreateNewCustomer
    @tenKhachHang NVARCHAR(255),
    @diachi NVARCHAR(255),
    @soDienThoai VARCHAR(255),
    @newCustomerID VARCHAR(255) OUTPUT
AS
BEGIN
    DECLARE @maxStt INT;
    DECLARE @idKhachHang VARCHAR(255);
    DECLARE @hien BIT;
    SET @hien = 1;

    -- Calculate the next available customer ID
    SELECT @maxStt = ISNULL(MAX(CAST(SUBSTRING(idKhachHang, LEN('KH') + 1, LEN(idKhachHang)) AS INT)), 0)
    FROM KhachHang
    WHERE idKhachHang LIKE 'KH%';

    -- Generate the new customer ID
    SET @idKhachHang = 'KH' + RIGHT('0000' + CAST(@maxStt + 1 AS VARCHAR(5)), 5);

    -- Insert the new customer record into the KhachHang table
    INSERT INTO KhachHang (idKhachHang, tenKhachHang, diaChi, sdt, hien)
    VALUES (@idKhachHang, @tenKhachHang, @diachi, @soDienThoai, @hien);

    -- Set the @newCustomerID output parameter to the ID of the newly created customer
    SET @newCustomerID = @idKhachHang;
END

go
CREATE PROCEDURE CreateNewBake(
    @tenBanh VARCHAR(255),
    @sl INT,
    @giaTien FLOAT,
    @donVi VARCHAR(255),
	@idLoaiBanh VARCHAR(255),
	@idBanhOutput VARCHAR(255) OUTPUT)
AS
BEGIN
    DECLARE @maxStt INT;
    DECLARE @idBanh NVARCHAR(255);
    DECLARE @hien BIT;
    SET @hien = 1;

    -- Get the tenLoaiBanh based on the idLoaiBanh parameter
    DECLARE @tenLoaiBanh NVARCHAR(255);
    SELECT @tenLoaiBanh = tenLoaiBanh FROM LoaiBanh WHERE idLoaiBanh = @idLoaiBanh;

    -- Calculate the next available idBanh
    SELECT @maxStt = ISNULL(MAX(CAST(SUBSTRING(idBanh, LEN(@tenLoaiBanh) + 2, LEN(idBanh)) AS INT)), 0)
    FROM Banh
    WHERE idBanh LIKE @tenLoaiBanh + '-%';

    -- Increment the maxStt value
    SET @maxStt = @maxStt + 1;

    -- Generate the new idBanh
    SET @idBanh =
        CASE
            WHEN @maxStt < 10 THEN @tenLoaiBanh + '-' + RIGHT('00000' + CAST(@maxStt AS NVARCHAR(5)), 5)
            WHEN @maxStt < 100 THEN @tenLoaiBanh + '-' + RIGHT('0000' + CAST(@maxStt AS NVARCHAR(5)), 4)
            WHEN @maxStt < 1000 THEN @tenLoaiBanh + '-' + RIGHT('000' + CAST(@maxStt AS NVARCHAR(5)), 3)
            WHEN @maxStt < 10000 THEN @tenLoaiBanh + '-' + RIGHT('00' + CAST(@maxStt AS NVARCHAR(5)), 2)
            WHEN @maxStt < 100000 THEN @tenLoaiBanh + '-' + RIGHT('0' + CAST(@maxStt AS NVARCHAR(5)), 1)
            ELSE @tenLoaiBanh + '-' + CAST(@maxStt AS NVARCHAR(5))
        END;

    -- Insert the new Banh record into the Banh table
    INSERT INTO Banh (idBanh, idLoaiBanh, tenBanh, sl, giaTien, donVi, hien)
    VALUES (@idBanh, @idLoaiBanh, @tenBanh, @sl, @giaTien, @donVi, @hien);

    -- Set the output parameter to the generated idBanh
    SET @idBanhOutput = @idBanh;
END


GO
CREATE PROCEDURE nameTypeOfBake(@idLoaiBanh VARCHAR(255), @tenLoaiBanh VARCHAR(255) OUTPUT)
AS
BEGIN
    SET @tenLoaiBanh = (SELECT tenLoaiBanh FROM LoaiBanh WHERE idLoaiBanh = @idLoaiBanh)
END

go
CREATE PROCEDURE ActiveBake(
	@idBanh VARCHAR(255),
	@hien bit)
AS
BEGIN
	if(@hien=1)
		UPDATE Banh
		SET hien = 0
		WHERE idBanh = @idBanh;
	else
		UPDATE Banh
		SET hien = 1
		WHERE idBanh = @idBanh;
END
go


CREATE PROCEDURE SearchBake
    @key varchar(255)
AS
BEGIN
    SELECT Distinct *
    FROM Banh
    WHERE
        idLoaiBanh LIKE ('%' + @key + '%')
    UNION
    SELECT *
    FROM Banh
    WHERE
        tenBanh LIKE  ('%' + @key + '%')
    UNION
    SELECT *
    FROM Banh
    WHERE
        idLoaiBanh in(Select idLoaiBanh from LoaiBanh	where tenLoaiBanh	like  ('%' + @key + '%'))
    UNION
    SELECT *
    FROM Banh
    WHERE idLoaiBanh LIKE  ('%' + @key + '%');
END;
go

CREATE PROC UpdateBake(
    @idBanh varchar(255),
    @idLoaiBanh varchar(255),
    @tenBanh NVARCHAR(255),
    @sl int,
    @giaTien float,
    @donVi NVARCHAR(255))
AS
BEGIN
    UPDATE Banh
    SET tenBanh = @tenBanh, sl = @sl, giaTien = @giaTien,donvi =@donVi,idLoaiBanh =@idLoaiBanh
    WHERE idBanh = @idBanh;
END
go





CREATE PROC UpdateAccount(
    @idTaiKhoan varchar(255),
    @tenTaiKhoan VARCHAR(255),
    @matKhau VARCHAR(255),
    @email VARCHAR(255),
    @soDienThoai VARCHAR(255))
AS
BEGIN
    UPDATE TaiKhoan
    SET tenTaiKhoan = @tenTaiKhoan, matKhau = @matKhau, email = @email,soDienThoai = @soDienThoai
    WHERE idTaiKhoan = @idTaiKhoan;
END
go
--Update NguyenLiêu
CREATE PROC UpdateNguyenLieu(
    @idLoaiNguyenLieu VARCHAR(255),
    @tenNguyenLieu VARCHAR(255),
    @sl int,
    @giaTien float,
    @donVi VARCHAR(255),
    @hien bit)
AS
BEGIN
    UPDATE NguyenLieu
    SET tenNguyenLieu = @tenNguyenLieu, sl = @sl, giaTien = @giaTien,donVi = @donVi,hien =@hien
    WHERE idNguyenLieu = @idLoaiNguyenLieu;
END
go

CREATE PROC UpdateCustomer(
    @idKhacHang varchar(255),
    @tenKhachHang VARCHAR(255),
    @diachi VARCHAR(255),
    @soDienThoai VARCHAR(255),
    @hien bit)
AS
BEGIN
    UPDATE KhachHang
    SET tenKhachHang = @tenKhachHang, diaChi = @diachi, sdt = @soDienThoai, hien = @hien
    WHERE idKhachHang = @idKhacHang;

    -- Trả về thông tin khách hàng sau khi cập nhật
    SELECT * FROM KhachHang WHERE idKhachHang = @idKhacHang;
END
GO
CREATE PROCEDURE SearchCustomer
    @key varchar(255)
AS
BEGIN
    SELECT Distinct *
    FROM KhachHang
    WHERE
        idKhachHang LIKE ('%' + @key + '%')
    UNION
    SELECT *
    FROM KhachHang
    WHERE
        tenKhachHang LIKE  ('%' + @key + '%')
    UNION
    SELECT *
    FROM KhachHang
    WHERE
        diaChi LIKE  ('%' + @key + '%')
    UNION
    SELECT *
    FROM KhachHang
    WHERE
        sdt LIKE  ('%' + @key + '%');
END;

go 
Create Procedure idTypeOfBake(@tenLoaiBanh varchar(255),@idLoaiBanh varchar(255) Output)
As
Begin	
	Set @idLoaiBanh =(Select idLoaiBanh from LoaiBanh where tenLoaiBanh = @tenLoaiBanh )
End
go 

go
CREATE PROCEDURE DeleteById(
    @id varchar(255),
    @tableName VARCHAR(255))
AS
BEGIN
    DECLARE @realId VARCHAR(255);
    Set @realId = 'id'+@tableName
    DECLARE @sql NVARCHAR(MAX);
    SET @sql = N'DELETE FROM ' + QUOTENAME(@tableName) + ' WHERE ' + QUOTENAME(@realId) + ' = @id;';
    EXEC sp_executesql @sql, N'@id VARCHAR(255)', @id;
END;

-- Tạo Hóa Đơn Nhập Bánh
GO
-- Tính Tổng Doanh Thu theo thời gian cụ thể
go

--tính tồn kho sản phẩm
Create PROC TonKho(@idSanpham varchar(255))
AS
BEGIN
    SELECT sl AS TonKho
    FROM NguyenLieu
    WHERE idNguyenLieu = @idSanpham AND sl IS NOT NULL

    UNION

    SELECT sl AS TonKho
    FROM Banh
    WHERE idBanh = @idSanpham AND sl IS NOT NULL;
    
END
go
--thongtin sản phẩm
Create PROC InforProduct(@idSanpham varchar(255))
AS
BEGIN
    IF EXISTS (SELECT 1 FROM NguyenLieu WHERE idNguyenLieu = @idSanpham)
    BEGIN
        SELECT *
        FROM NguyenLieu
        WHERE idNguyenLieu = @idSanpham;
    END
    ELSE IF EXISTS (SELECT 1 FROM Banh WHERE idBanh = @idSanpham)
    BEGIN
        SELECT *
        FROM Banh
        WHERE idBanh = @idSanpham;
    END
    
END
go
--thongtin khacHang
Create PROC InforCustomer(@idKhacHang varchar(255))
AS
BEGIN
    SELECT *
    FROM KhachHang
    WHERE idKhachHang = @idKhacHang
    
END

go 
CREATE PROCEDURE GetPaginatedDataHien
    @table NVARCHAR(128),
    @page INT = 0,
    @size INT = 10
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @offset INT = @page * @size;
    
    SET @sql = N'SELECT * FROM ' + QUOTENAME(@table) +   N' WHERE hien = 1' +
               N' ORDER BY (SELECT NULL) OFFSET ' + CAST(@offset AS NVARCHAR(10)) + ' ROWS FETCH NEXT ' + CAST(@size AS NVARCHAR(10)) + ' ROWS ONLY' 
    
    EXEC sp_executesql @sql;
END;

GO

CREATE PROCEDURE GetPaginatedDataAn
    @table NVARCHAR(128),
    @page INT = 0,
    @size INT = 10
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @offset INT = @page * @size;
    
    SET @sql = N'SELECT * FROM ' + QUOTENAME(@table) +   N' WHERE hien = 0' +
               N' ORDER BY (SELECT NULL) OFFSET ' + CAST(@offset AS NVARCHAR(10)) + ' ROWS FETCH NEXT ' + CAST(@size AS NVARCHAR(10)) + ' ROWS ONLY' 
    
    EXEC sp_executesql @sql;
END;

go
CREATE PROCEDURE ActivateKhachHang
    @idKhachHang varchar(255)
AS
BEGIN
    UPDATE KhachHang
    SET hien = 1
    WHERE idKhachHang = @idKhachHang;
END;

go
CREATE PROCEDURE DeactivateKhachHang
    @idKhachHang varchar(255)
AS
BEGIN
    UPDATE KhachHang
    SET hien = 0
    WHERE idKhachHang = @idKhachHang;
END;


GO
CREATE PROCEDURE CreateNewMaterial(
    @tenNguyenLieu NVARCHAR(255),
    @sl int,
    @giaTien float,
    @donVi NVARCHAR(255),
    @tenLoaiNguyenLieu Nvarchar(255),
	@idLoaiNguyenLieuOutput VARCHAR(255) OUTPUT,
    @idNguyenLieuOutput VARCHAR(255) OUTPUT)
AS
BEGIN
    DECLARE @maxStt INT;
    DECLARE @idNguyenLieu NVARCHAR(255);
    DECLARE @hien bit;
    set @hien = 1;
    SET @idNguyenLieu = dbo.RemoveSpaces(dbo.GetUnsignString(@tenLoaiNguyenLieu));
	DEclare	@idLoaiNguyenLieu varchar(255)
	set @idLoaiNguyenLieu=(Select idLoaiNguyenLieu from LoaiNguyenLieu where @tenLoaiNguyenLieu = tenLoaiNguyenLieu)		
    SELECT @maxStt = ISNULL(MAX(CAST(SUBSTRING(idNguyenLieu, LEN(@idNguyenLieu) + 2, LEN(idNguyenLieu)) AS INT)), 0)
    FROM NguyenLieu
    WHERE idNguyenLieu LIKE @idNguyenLieu + '-%';    
    if(@maxStt<10)
        SET @idNguyenLieu = @idNguyenLieu + '-' + RIGHT('00000' + CAST(@maxStt + 1 AS NVARCHAR(5)), 6);
    ELSE IF(@maxStt>=10 and @maxStt<100)
        SET @idNguyenLieu = @idNguyenLieu+ '-' + RIGHT('0000' + CAST(@maxStt + 1 AS NVARCHAR(5)), 6);
    ELSE IF(@maxStt>=100 and @maxStt<1000)
        SET @idNguyenLieu = @idNguyenLieu+ '-' + RIGHT('000' + CAST(@maxStt + 1 AS NVARCHAR(5)), 6);       
    ELSE IF(@maxStt>=1000 and @maxStt<10000)
        SET @idNguyenLieu = @idNguyenLieu+ '-' + RIGHT('00' + CAST(@maxStt + 1 AS NVARCHAR(5)), 6);
    ELSE IF(@maxStt>=10000 and @maxStt<100000)
        SET @idNguyenLieu = @idNguyenLieu+ '-' + RIGHT('0' + CAST(@maxStt + 1 AS NVARCHAR(5)), 6);
    ELSE
        SET @idNguyenLieu = @idNguyenLieu + '-' + CAST(@maxStt + 1 AS NVARCHAR(5));

    INSERT INTO NguyenLieu (idNguyenLieu,idLoaiNguyenLieu, tenNguyenLieu, sl, giaTien, donVi,hien)
    VALUES (@idNguyenLieu,@idLoaiNguyenLieu,@tenNguyenLieu, @sl, @giaTien, @donVi,@hien);
	set  @idLoaiNguyenLieuOutput = @idLoaiNguyenLieu
	set @idNguyenLieuOutput= @idNguyenLieu 

END


go

CREATE PROCEDURE UpdateMaterial(
	@idNguyenLieu VARCHAR(255),
    @idLoaiNguyenLieu VARCHAR(255),
    @tenNguyenLieu NVARCHAR(255),
    @sl int,
    @giaTien float,
    @donVi VARCHAR(255))
AS
BEGIN
    UPDATE NguyenLieu
    SET tenNguyenLieu = @tenNguyenLieu,idLoaiNguyenLieu=@idLoaiNguyenLieu , sl = @sl, giaTien = @giaTien,donVi = @donVi
    WHERE idNguyenLieu = @idNguyenLieu;
END
go

go
CREATE PROCEDURE ActiveMaterial(
	@idNguyenLieu VARCHAR(255),
	@hien bit)
AS
BEGIN
	if(@hien=1)
		UPDATE NguyenLieu
		SET hien = 0
		WHERE idNguyenLieu = @idNguyenLieu;
	else
		UPDATE NguyenLieu
		SET hien = 1
		WHERE idNguyenLieu = @idNguyenLieu;
END
go
CREATE PROCEDURE GetPaginatedData
    @table NVARCHAR(128),
    @page INT = 0 ,
    @size INT =10
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @offset INT = @page * @size;
    
    SET @sql = N'SELECT * FROM ' + QUOTENAME(@table) + 
               N' ORDER BY (SELECT NULL) OFFSET ' + CAST(@offset AS NVARCHAR(10)) + ' ROWS FETCH NEXT ' + CAST(@size AS NVARCHAR(10)) + ' ROWS ONLY';
    
    EXEC sp_executesql @sql;
END;
go
CREATE PROCEDURE DeleteById(
    @id varchar(255),
    @tableName VARCHAR(255))
AS
BEGIN
    DECLARE @realId VARCHAR(255);
    Set @realId = 'id'+@tableName
    DECLARE @sql NVARCHAR(MAX);
    SET @sql = N'DELETE FROM ' + QUOTENAME(@tableName) + ' WHERE ' + QUOTENAME(@realId) + ' = @id;';
    EXEC sp_executesql @sql, N'@id VARCHAR(255)', @id;
END;

GO 
CREATE PROCEDURE nameTypeOfMaterial(@idLoaiNguyenLieu VARCHAR(255), @tenLoaiNguyenLieu VARCHAR(255) OUTPUT)
AS
BEGIN
    SET @tenLoaiNguyenLieu = (SELECT tenLoaiNguyenLieu FROM LoaiNguyenLieu WHERE idLoaiNguyenLieu = @idLoaiNguyenLieu)
END

go
Create Procedure idTypeOfMaterial(@tenLoaiNguyenLieu varchar(255),@idLoaiNguyenLieu varchar(255) Output)
As
Begin	
	Set @idLoaiNguyenLieu =(Select idLoaiNguyenLieu from LoaiNguyenLieu where tenLoaiNguyenLieu = @tenLoaiNguyenLieu )
End
go 
DECLARE @idLoaiNguyenLieu NVARCHAR(255);
EXECUTE dbo.idTypeOfMaterial 'BotMi', @idLoaiNguyenLieu OUTPUT;
PRINT @idLoaiNguyenLieu; -- In giá trị ra màn hình để kiểm tra
go
CREATE PROCEDURE SearchMaterial
    @key VARCHAR(255)
AS
BEGIN
    SELECT DISTINCT *
    FROM NguyenLieu
    WHERE
        (idLoaiNguyenLieu LIKE '%' + @key + '%' OR tenNguyenLieu LIKE '%' + @key + '%')
        AND hien = 1
        OR idLoaiNguyenLieu IN (SELECT idLoaiNguyenLieu FROM LoaiNguyenLieu WHERE tenLoaiNguyenLieu LIKE '%' + @key + '%') AND hien = 1;
END;





-- DECLARE @counter INT = 1;

-- WHILE @counter <= 10
-- BEGIN
--     -- Generate fake values or replace them with your own logic
--     DECLARE @tenNguyenLieu VARCHAR(255) = 'FakeMaterial' + CONVERT(VARCHAR, @counter);
--     DECLARE @sl INT = ROUND(RAND() * 100, 0); -- Random quantity between 0 and 100
--     DECLARE @giaTien FLOAT = ROUND(RAND() * 100, 2); -- Random price between 0 and 100 with 2 decimal places
--     DECLARE @donVi VARCHAR(255) = 'FakeUnit';
--     DECLARE @tenLoaiNguyenLieu VARCHAR(255) = 'FakeType' + CONVERT(VARCHAR, @counter);

--     -- Declare output variables
--     DECLARE @idLoaiNguyenLieuOutput VARCHAR(255);
--     DECLARE @idNguyenLieuOutput NVARCHAR(255);

--     -- Execute the stored procedure for each fake entry
--     EXEC CreateNewMaterial
--         @tenNguyenLieu,
--         @sl,
--         @giaTien,
--         @donVi,
--         @tenLoaiNguyenLieu,
--         @idLoaiNguyenLieuOutput OUTPUT,
--         @idNguyenLieuOutput OUTPUT;

--     -- Increment counter
--     SET @counter = @counter + 1;
-- END;




-- material

go
CREATE PROCEDURE GetAllMaterial(
    @hien bit)
AS
BEGIN
	SELECT *, NguyenLieu.sl as soLuongNguyenLieu
FROM NguyenLieu
LEFT JOIN loaiNguyenLieu ON NguyenLieu.idLoaiNguyenLieu = loaiNguyenLieu.idLoaiNguyenLieu
WHERE NguyenLieu.hien = @hien;

END


go
CREATE PROCEDURE GetAllMaterialByType(
	@key Nvarchar(255),
    @hien bit)
AS
BEGIN
	    SELECT *
        FROM NguyenLieu
        WHERE hien =@hien and idLoaiNguyenLieu= (
        SELECT LN.idLoaiNguyenLieu
        FROM LoaiNguyenLieu AS LN
        WHERE  LN.tenLoaiNguyenLieu = @key)
END;
go


-- ///hoa don PROCEDURE

CREATE PROCEDURE InsertHoaDon
    @idBoPhanXuat VARCHAR(255),
    @idLoaiHoaDon VARCHAR(255),
    @ngayXuat DATE,
    @idTaiKhoan VARCHAR(255),
    @tongtien FLOAT,
    @soLuong INT,
    @idHoaDon VARCHAR(255) OUTPUT
AS
BEGIN
    DECLARE @maxStt INT;
    DECLARE @newIdHoaDon VARCHAR(255);

    DECLARE @hien bit;
    SET @hien = 1;

    SELECT @maxStt = ISNULL(CAST(MAX(idHoaDon) as int), 0) FROM HoaDon ;
    IF (@maxStt >= 1000 )
        SET @newIdHoaDon = CAST(@maxStt + 1 AS NVARCHAR(4));
    ELSE IF (@maxStt >= 100 )
        SET @newIdHoaDon = '0' + CAST(@maxStt + 1 AS NVARCHAR(4));
    ELSE IF (@maxStt >= 9 and @maxStt < 99)
        SET @newIdHoaDon = '00' + CAST((@maxStt + 1) AS NVARCHAR(3));
    ELSE
        SET @newIdHoaDon = '000' + CAST(@maxStt + 1 AS NVARCHAR(2));

    -- Insert into HoaDon
    INSERT INTO HoaDon (idHoaDon, idBoPhanXuat, idLoaiHoaDon, ngayXuat, idTaiKhoan, tongTien, soLuong)
    VALUES (@newIdHoaDon, @idBoPhanXuat, @idLoaiHoaDon, @ngayXuat, @idTaiKhoan, @tongtien, @soLuong);

    -- Set the OUTPUT parameter to the new idHoaDon
    SET @idHoaDon = @newIdHoaDon;
END;

go
CREATE PROCEDURE InsertHoaDonXuatNguyenLieu
    @idNguyenLieu VARCHAR(255),
    @idHoaDon VARCHAR(255),
    @sl INT,
    @tongTien FLOAT
AS
BEGIN
    DECLARE @newId VARCHAR(255);
    -- Generate a new id
    SET @newId = 'hdxnl' + RIGHT('00000' + CAST(ISNULL((SELECT MAX(CONVERT(INT, RIGHT(id, 5))) + 1 FROM HoaDonXuatNguyenLieu), 1) AS VARCHAR(5)), 5);

    -- Insert into HoaDonXuatNguyenLieu
    INSERT INTO HoaDonXuatNguyenLieu (id, idNguyenLieu, idHoaDon, sl, tongTien)
    VALUES (@newId, @idNguyenLieu, @idHoaDon, @sl, @tongTien);
END;
go
CREATE PROCEDURE TinhTongDoanhThu(
    @NgayBatDau DATE,
    @NgayKetThuc DATE)
AS
BEGIN
    SELECT SUM(HoaDonNhapNguyenLieu.tongTien + HoaDonXuatBanh.tongTien + HoaDonNhapBanh.tongTien +HoaDonXuatNguyenLieu.tongTien) AS TongDoanhThu
    FROM HoaDon
    INNER JOIN HoaDonNhapBanh ON HoaDon.idHoaDon = HoaDonNhapBanh.idHoaDon
    INNER JOIN HoaDonXuatBanh ON HoaDon.idHoaDon = HoaDonXuatBanh.idHoaDon
    INNER JOIN HoaDonNhapNguyenLieu ON HoaDon.idHoaDon = HoaDonNhapNguyenLieu.idHoaDon
    INNER JOIN HoaDonXuatNguyenLieu ON HoaDon.idHoaDon = HoaDonXuatNguyenLieu.idHoaDon
    WHERE HoaDon.ngayXuat BETWEEN @NgayBatDau AND @NgayKetThuc;
END;
go


CREATE PROCEDURE GetInvoiceGoByDate
    @dateOfInvoice DATE
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
        B.idBoPhanXuat
    FROM
        HoaDon D
    JOIN
        BoPhanXuat B ON D.idBoPhanXuat = B.idBoPhanXuat
    WHERE
        D.ngayXuat = @dateOfInvoice
        AND D.idLoaiHoaDon = '2';
END;

EXEC GetInvoiceGoByDate '2023-11-20'


go 
CREATE PROCEDURE GetInvoiceDetails
    @InputIdHoaDon VARCHAR(255)
AS
BEGIN
    SELECT
        HXNL.idNguyenLieu AS HXNL_idNguyenLieu,
        HXNL.*,
        HD.ngayxuat,
        HD.soluong AS tongSlHoaDon,
        NL.tenNguyenLieu,
        NL.sl AS tonKho,
        NL.donVi,
        NL.hien,
        NL.giaTien,
        NL.idLoaiNguyenLieu,
        LNL.tenLoaiNguyenlieu
    FROM
        hoadonxuatnguyenlieu HXNL
    JOIN
        hoadon HD ON HXNL.idHoaDon = HD.idHoaDon AND HD.idHoaDon = @InputIdHoaDon
    JOIN
        nguyenlieu NL ON HXNL.idNguyenLieu = NL.idNguyenLieu
    JOIN
        LoaiNguyenLieu LNL ON NL.idLoaiNguyenLieu = LNL.idLoaiNguyenLieu;
END;



select hoadonxuatnguyenlieu.*, hoadon.idLoaiHoaDon, hoadon.ngayxuat, hoadon.soluong as tongSlHoaDon , nguyenLieu.* 
from hoadon, hoadonxuatnguyenlieu, nguyenlieu  where hoadon.idHoaDon = hoadonxuatnguyenlieu.idHoaDon 
and nguyenlieu.idNguyenLieu = hoadonxuatnguyenlieu.idNguyenLieu




go
CREATE PROCEDURE GetPaginatedDataByType
    @table NVARCHAR(128),
    @page INT = 0,
    @size INT = 10,
    @key NVARCHAR(255),
	@hien bit
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @offset INT = @page * @size;

    SET @sql = N'
        SELECT *
        FROM ' + QUOTENAME(@table) + ' AS T
        WHERE hien =@hien and T.idLoaiNguyenLieu= (
            SELECT LN.idLoaiNguyenLieu
            FROM LoaiNguyenLieu AS LN
            WHERE LN.tenLoaiNguyenLieu = @key
        )
        ORDER BY (SELECT NULL)
        OFFSET ' + CAST(@offset AS NVARCHAR(10)) + ' ROWS FETCH NEXT ' + CAST(@size AS NVARCHAR(10)) + ' ROWS ONLY';

    EXEC sp_executesql @sql, N'@key NVARCHAR(255), @hien BIT', @key,@hien;
END;
go

CREATE PROCEDURE GetTotalRowOfMaterialByType
    @idLoaiNguyenLieu VARCHAR(255),
    @totalRow INT OUTPUT
AS
BEGIN
    SELECT @totalRow = COUNT(*)
    FROM nguyenlieu
    WHERE hien = 1 AND idLoaiNguyenLieu = @idLoaiNguyenLieu;
END;

go

go

CREATE PROCEDURE GetTotalRowOfBakeByType
    @idLoaiBanh VARCHAR(255),
    @totalRow INT OUTPUT
AS
BEGIN
    SELECT @totalRow = COUNT(*)
    FROM banh
    WHERE hien = 1 AND idLoaiBanh = @idLoaiBanh;
END;

go


CREATE FUNCTION RemoveSpaces
    (@inputString NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
    DECLARE @outputString NVARCHAR(MAX) = @inputString;
    DECLARE @index INT = CHARINDEX(' ', @outputString);

    WHILE @index > 0
    BEGIN
        SET @outputString = STUFF(@outputString, @index, 1, ''); -- Thay thế khoảng trắng bằng chuỗi rỗng
        SET @index = CHARINDEX(' ', @outputString);
    END

    RETURN @outputString;
END;
GO


CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS VARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END
go


-- hoa don
CREATE PROCEDURE RemoveHoaDon
    @idHoaDon varchar(255),
    @Result INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Your delete statement here
        DELETE FROM HoaDon WHERE idHoaDon = @idHoaDon;

        SET @Result = 1; -- Success
    END TRY
    BEGIN CATCH
        -- Handle errors if necessary
        SET @Result = 0; -- Failure
    END CATCH
END;


go
-- hoa don
CREATE PROCEDURE RemoveHoaDonExportMaterial
    @idChiTietHoaDon varchar(255),
    @Result INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Your delete statement here
        DELETE FROM hoadonxuatnguyenlieu WHERE id = @idChiTietHoaDon;

        SET @Result = 1; -- Success
    END TRY
    BEGIN CATCH
        -- Handle errors if necessary
        SET @Result = 0; -- Failure
    END CATCH
END;

go 

CREATE PROCEDURE UpdateHoaDonExportMaterial
    @idChiTietHoaDon VARCHAR(255),
    @newSl INT,
    @newTongTien FLOAT,
    @idNguyenLieu varchar(255),
    @Result INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Your update statement here
        UPDATE HoaDonXuatNguyenLieu
        SET sl = @newSl,
            tongTien = @newTongTien,
            idNguyenLieu = @idNguyenLieu
        WHERE id = @idChiTietHoaDon;

        SET @Result = 1; -- Success
    END TRY
    BEGIN CATCH
        -- Handle errors if necessary
        SET @Result = 0; -- Failure
    END CATCH
END;




-- // nguy
go 

CREATE PROCEDURE GetTotalAmountForHoaDonXuatNguyenLieu
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT HDXNL.idHoaDon, SUM(HDXNL.sl * NL.giaTien) AS TotalAmount
    FROM HoaDonXuatNguyenLieu HDXNL
    INNER JOIN NguyenLieu NL ON HDXNL.idNguyenLieu = NL.idNguyenLieu
    INNER JOIN HoaDon HD ON HDXNL.idHoaDon = HD.idHoaDon
    WHERE HD.ngayXuat BETWEEN @StartDate AND @EndDate
    GROUP BY HDXNL.idHoaDon;
END;

go 
CREATE PROCEDURE GetTotalAmountForHoaDonXuatBanh
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT HDXB.idHoaDon, SUM(HDXB.sl * B.giaTien) AS TotalAmount
    FROM HoaDonXuatBanh HDXB
    INNER JOIN Banh B ON HDXB.idBanh = B.idBanh
    INNER JOIN HoaDon HD ON HDXB.idHoaDon = HD.idHoaDon
    WHERE HD.ngayXuat BETWEEN @StartDate AND @EndDate
    GROUP BY HDXB.idHoaDon;
END;

-- bake invoice 
go
CREATE PROCEDURE InsertHoaDonXuatBanh
    @idBanh VARCHAR(255),
    @idHoaDon VARCHAR(255),
    @sl INT,
    @tongTien FLOAT
AS
BEGIN
    DECLARE @newId VARCHAR(255);
    -- Generate a new id
    SET @newId = 'hdxnl' + RIGHT('00000' + CAST(ISNULL((SELECT MAX(CONVERT(INT, RIGHT(id, 5))) + 1 FROM HoaXuatBanh), 1) AS VARCHAR(5)), 5);

    INSERT INTO HoaXuatBanh (id, idNguyenLieu, idHoaDon, sl, tongTien)
    VALUES (@newId, @idBanh, @idHoaDon, @sl, @tongTien);
END;
go
