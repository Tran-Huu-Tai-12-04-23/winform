--- trigger 
go
CREATE TRIGGER CreateDefaultPermission
ON TaiKhoan
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert default permission settings for the new account into PhanQuyen table
    INSERT INTO PhanQuyen (idPhanQuyen, idTaiKhoan, ngayBatDau, ngayKetThuc, quyenSua, quyenThem, quyenXoa, loaiQuyen)
    SELECT
        NEWID(), -- Generate a new unique identifier for idPhanQuyen
        i.idTaiKhoan, -- idTaiKhoan from the newly inserted account
        GETDATE(), -- Current date as ngayBatDau
        NULL, -- You can set an appropriate value for ngayKetThuc
        0, -- Default value for quyenSua (false)
        0, -- Default value for quyenThem (false)
        0, -- Default value for quyenXoa (false)
        1 -- Set the appropriate value for loaiQuyen
    FROM inserted i;
END;


go
-- Trigger for HoaDonNhapBanh
CREATE TRIGGER updateTonKhoBanhNhap
ON HoaDonNhapBanh
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE tkb
    SET tkb.soluong = tkb.soluong + i.soLuong
    FROM TonKhoBanh tkb
    INNER JOIN inserted i ON tkb.maBanh = i.idBanh;
END;
go
-- Trigger for HoaDonXuatBanh
CREATE TRIGGER updateTonKhoBanhXuat
ON HoaDonXuatBanh
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE TonKhoBanh
    SET soluong = soluong - i.sl
    FROM TonKhoBanh tkb
    INNER JOIN inserted i ON tkb.maBanh = i.idBanh;
END;
go
-- Trigger for HoaDonNhapNguyenLieu
CREATE TRIGGER updateTonKhoNguyenLieuNhap
ON HoaDonNhapNguyenLieu
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE TonKhoNguyenLieu
    SET soluong = soluong + i.sl
    FROM TonKhoNguyenLieu tknl
    INNER JOIN inserted i ON tknl.maNguyenLieu = i.idNguyenLieu;
END;
go
-- Trigger for HoaDonXuatNguyenLieu
CREATE TRIGGER updateTonKhoNguyenLieuXuat
ON HoaDonXuatNguyenLieu
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE TonKhoNguyenLieu
    SET soluong = soluong - i.sl
    FROM TonKhoNguyenLieu tknl
    INNER JOIN inserted i ON tknl.maNguyenLieu = i.idNguyenLieu;
END;


-- description  auto add permission when add account

go
-- Create the INSTEAD OF DELETE trigger
CREATE TRIGGER trg_DeleteRelatedHoaDonXuatNguyenLieu
ON HoaDon
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete related records from HoaDonXuatNguyenLieu
    DELETE FROM HoaDonXuatNguyenLieu
    WHERE idHoaDon IN (SELECT idHoaDon FROM deleted);

    -- Delete records from HoaDon
    DELETE FROM HoaDon
    WHERE idHoaDon IN (SELECT idHoaDon FROM deleted);
END;



go 


CREATE TRIGGER trg_UpdateTonKhoNguyenLieu
ON HoaDonXuatNguyenLieu
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE NguyenLieu
    SET sl = CASE 
                    WHEN (nl.sl - i.sl) <= 0 THEN 0
                    ELSE (nl.sl - i.sl)
                 END
    FROM NguyenLieu nl
    JOIN inserted i ON nl.idNguyenLieu = i.idNguyenLieu
    WHERE nl.idNguyenLieu = i.idNguyenLieu;
END;


go 

-- Trigger for adding quantity on DELETE
CREATE TRIGGER trg_UpdateSlHoaDonRmTonKhoNguyenLieu_Delete
ON HoaDonXuatNguyenLieu
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE NguyenLieu
    SET sl = nl.sl + d.sl
    FROM NguyenLieu nl
    JOIN deleted d ON nl.idNguyenLieu = d.idNguyenLieu
    WHERE nl.idNguyenLieu = d.idNguyenLieu;
END;

