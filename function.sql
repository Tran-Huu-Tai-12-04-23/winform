-- //hoa don function

CREATE FUNCTION RemoveHoaDon
(
    @idHoaDon INT
)
RETURNS INT
AS
BEGIN
    DECLARE @Result INT;

    BEGIN TRY
        -- Your delete statement here
        DELETE FROM HoaDon WHERE idHoaDon = @idHoaDon;

        SET @Result = 1; -- Success
    END TRY
    BEGIN CATCH
        -- Handle errors if necessary
        SET @Result = 0; -- Failure
    END CATCH

    RETURN @Result;
END;
