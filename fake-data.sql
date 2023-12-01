-- constanst loai hoa don

INSERT INTO loaiHoaDon (idLoaiHoaDon, tenLoaiHoaDon) VALUES
('1', N'Hóa đơn xuất nguyên liệu đi'),
('2', N'Hóa đơn xuất nguyên liệu hủy'),
('3', N'Hóa đơn xuất nguyên liệu trả'),
('4', N'Hóa đơn xuất nguyên liệu khác'),
('5', N'Hóa đơn nhập nguyên liệu mua ngoài'),
('6', N'Hóa đơn nhập nguyên liệu nội bộ'),
('7', N'Hóa đơn xuất bánh đi'),
('8', N'Hóa đơn xuất bánh liệu hủy'),
('9', N'Hóa đơn xuất bánh liệu trả'),
('10', N'Hóa đơn xuất bánh liệu khác'),
('11', N'Hóa đơn nhập bánh liệu mua ngoài'),
('12', N'Hóa đơn nhập bánh liệu nội bộ')

-- end 

insert into bophanxuat values('bpx-01', N'Phòng Kem')
insert into bophanxuat values('bpx-02', N'Quầy Hàng')
insert into bophanxuat values('bpx-03', N'Bộ Phận Sản Xuất')
insert into bophanxuat values('bpx-04', N'Tạp Vụ')

INSERT INTO LoaiNguyenLieu (idLoaiNguyenLieu, tenLoaiNguyenLieu) VALUES
('1', N'Bột'),
('2', N'Material Type 2'),
('3', N'Material Type 3'),
('4', N'Material Type 4'),
('5', N'Material Type 5');

INSERT INTO LoaiBanh (idLoaiBanh, tenLoaiBanh) VALUES
('1', N'Chocolate Cake'),
('2', N'Strawberry Cake'),
('3', N'Vanilla Cake'),
('4', N'Red Velvet Cake'),
('5', N'Coffee Cake');

INSERT INTO NguyenLieu (idNguyenLieu, idLoaiNguyenLieu, tenNguyenLieu, sl, giaTien, donVi, hien) VALUES
('1', '1', N'Bột 1', 100, 5.5, N'Kg', 1),
('2', '1', N'Bột 2', 150, 4.8, N'Kg', 1),
('3', '2', N'Material 3', 120, 7.2, N'Unit', 1),
('4', '3', N'Material 4', 80, 6.3, N'Piece', 1),
('9', '5', N'Material 9', 110, 4.2, N'Unit', 1),
('10', '1', N'Bột 3', 160, 5.0, N'Kg', 1),
('11', '2', N'Material 11', 120, 6.7, N'Piece', 1),
('12', '3', N'Material 12', 100, 7.9, N'Kg', 1),
('13', '4', N'Material 13', 70, 5.6, N'Unit', 1),
('14', '5', N'Material 14', 140, 8.2, N'Piece', 1),
('15', '1', N'Bột 4', 190, 4.5, N'Kg', 1),
('16', '2', N'Material 16', 110, 6.0, N'Unit', 1),
('17', '3', N'Material 17', 130, 7.5, N'Piece', 1),
('18', '4', N'Material 18', 80, 5.3, N'Kg', 1),
('19', '5', N'Material 19', 150, 6.8, N'Unit', 1),
('20', '5', N'Material 20', 0, 6.0, N'Piece', 1);

DECLARE @newCustomerID VARCHAR(255);

-- Thêm 20 khách hàng mới sử dụng stored procedure CreateNewCustomer
-- Mỗi khách hàng có thông tin giả lập
-- Lấy ID của khách hàng vừa được tạo và in ra màn hình
BEGIN
    DECLARE @i INT;
    SET @i = 21;

    WHILE @i <= 100 and @i >= 20
    BEGIN
        -- Thay thế thông tin giả lập bằng thông tin thực tế cho mỗi khách hàng
        DECLARE @tenKhachHang VARCHAR(255) = 'KhachHang' + CAST(@i AS VARCHAR(2));
        DECLARE @diaChi VARCHAR(255) = 'DiaChi' + CAST(@i AS VARCHAR(2));
        DECLARE @soDienThoai VARCHAR(255) = '0129' + CAST(@i AS VARCHAR(2));

        -- Gọi stored procedure để thêm khách hàng
        EXEC CreateNewCustomer
            @tenKhachHang,
            @diaChi,
            @soDienThoai,
            @newCustomerID OUTPUT;

        PRINT 'Thêm khách hàng mới với ID: ' + @newCustomerID;

        SET @i = @i + 1;
    END;
END;




DECLARE @i INT = 1;

WHILE @i <= 20
BEGIN
    DECLARE @tenBanh VARCHAR(255) = 'Banh' + CAST(@i AS VARCHAR(5));
    DECLARE @sl INT = 10 + @i;
    DECLARE @giaTien FLOAT = 25.5 + @i;
    DECLARE @donVi VARCHAR(255) = 'DonVi' + CAST(@i AS VARCHAR(5));
    DECLARE @idLoaiBanh VARCHAR(255) = '1';
    DECLARE @idBanhOutput VARCHAR(255); -- Assuming @idBanhOutput is of type VARCHAR(255)

    -- Execute the stored procedure
    EXEC CreateNewBake
        @tenBanh = @tenBanh,
        @sl = @sl,
        @giaTien = @giaTien,
        @donVi = @donVi,
        @idLoaiBanh = @idLoaiBanh,
        @idBanhOutput = @idBanhOutput OUTPUT;

    -- Output the generated idBanh
    PRINT 'Generated idBanh: ' + ISNULL(@idBanhOutput, 'NULL');

    SET @i = @i + 1;
END;

select * from Banh
