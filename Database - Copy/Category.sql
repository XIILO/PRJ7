CREATE TABLE Category (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(255) UNIQUE NOT NULL
);


drop table Category
drop proc CategorySerch
--View
CREATE PROCEDURE CategoryView
AS
BEGIN
    SELECT * FROM Category;
END;
--add
CREATE PROCEDURE CategoryAdd
    @CategoryName VARCHAR(255)
AS
BEGIN
    INSERT INTO Category (CategoryName)
    VALUES (@CategoryName);
END;

--update
CREATE PROCEDURE CategoryUpdate
    @CategoryID VARCHAR(255),
    @NewCategoryName VARCHAR(255)
AS
BEGIN
    UPDATE Category
    SET CategoryName = @NewCategoryName
    WHERE CategoryID = @CategoryID;
END;

--Delete
CREATE PROCEDURE CategoryDelete
    @CategoryID VARCHAR(255)
AS
BEGIN
    DELETE FROM Category
    WHERE CategoryID = @CategoryID;
END;






CREATE PROCEDURE CategoryVerify
    @CategoryName VARCHAR(255)
AS	
BEGIN
    DECLARE @Result INT;

    IF EXISTS (SELECT 1 FROM Category WHERE CategoryName = @CategoryName)
    BEGIN
        SET @Result = 1;
    END
    ELSE
    BEGIN
        SET @Result = 0;
    END;

    SELECT @Result AS Result;
END;

CREATE PROCEDURE CategoryVerifyID
    @CategoryID INT
AS	
BEGIN
    DECLARE @Result INT;

    IF EXISTS (SELECT 1 FROM Category WHERE CategoryID = @CategoryID)
    BEGIN
        SET @Result = 1;
    END
    ELSE
    BEGIN
        SET @Result = 0;
    END;

    SELECT @Result AS Result;
END;




CREATE PROCEDURE CategorySerch
    @SearchTerm NVARCHAR(255)
AS
BEGIN
    DECLARE @IsNumeric BIT;
    SET @IsNumeric = 0;

    -- Kiểm tra xem @SearchTerm có phải là một số không
    IF ISNUMERIC(@SearchTerm) = 1
        SET @IsNumeric = 1;

    -- Nếu là số, tìm theo CategoryID, ngược lại tìm theo CategoryName
    IF @IsNumeric = 1
        SELECT *
        FROM Category
        WHERE CategoryID = CONVERT(INT, @SearchTerm);
    ELSE
        SELECT *
        FROM Category
        WHERE CategoryName LIKE '%' + @SearchTerm + '%';
END;
