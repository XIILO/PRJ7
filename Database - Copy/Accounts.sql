
-- Tạo bảng AccountDetail
CREATE TABLE Accounts (
    AccountID VARCHAR(255),
    Username VARCHAR(255),
    Password VARCHAR(255),
	Email VARCHAR(255),
    PRIMARY KEY (AccountID)
);



-- Verify account Procs
CREATE PROCEDURE AccountVerify
	@Username VARCHAR(50),
	@Password VARCHAR(50)

AS	
BEGIN
	DECLARE @Result INT;

	IF EXISTS (SELECT 1 FROM Accounts WHERE Username = @Username AND Password = @Password)
	BEGIN
		SET @Result = 1;
	END
	ELSE
	BEGIN
		SET @Result = 0;
	END;
		
	SELECT @Result AS Result;
END;


-- Verify AccountID Proc
CREATE PROCEDURE AccountVerifyID
	@Username VARCHAR(50),
	@Password VARCHAR(50)

AS	
BEGIN
	DECLARE @Result INT;

	IF EXISTS (SELECT AccountID
	FROM Accounts
	WHERE Username = @Username AND Password = @Password)
	BEGIN
		SET @Result = 
			CASE 
				WHEN (SELECT AccountID FROM Accounts WHERE Username = @Username AND Password = @Password) = 'Manager' THEN 1
				WHEN (SELECT AccountID FROM Accounts WHERE Username = @Username AND Password = @Password) = 'Employee' THEN 0
				ELSE -1
			END
	END
	ELSE
	BEGIN
		SET @Result = -1;
	END;
		
	SELECT @Result AS Result;
END;

