CREATE TABLE Employee (
    EmployeeID VARCHAR(255) PRIMARY KEY
);

CREATE TABLE EmployeesDetails (
    EmployeeID VARCHAR(255) REFERENCES Employee(EmployeeID),
    EmployeeName VARCHAR(255),
	EmployeeSalaryUnit FLOAT,
    EmployeeSalary FLOAT,	
    EmployeeEmail VARCHAR(255),
    EmployeePhoneContact FLOAT,
    FirstDateOfWork DATE NOT NULL,	
    LastDateOfWork DATE NULL
);
Drop table EmployeesDetails


CREATE PROCEDURE EmployeeDetailView
AS
BEGIN
    SELECT * FROM EmployeesDetails;
END;


CREATE PROCEDURE EmployeeDetailsAdd
    @EmployeeID VARCHAR(255),
    @EmployeeName VARCHAR(255),
    @EmployeeSalaryUnit FLOAT,
    @EmployeeSalary FLOAT,
    @EmployeeEmail VARCHAR(255),
    @EmployeePhoneContact FLOAT,
    @FirstDateOfWork DATE
AS
BEGIN
    INSERT INTO EmployeesDetails (EmployeeID, EmployeeName, EmployeeSalaryUnit, EmployeeSalary, EmployeeEmail, EmployeePhoneContact, FirstDateOfWork)
    VALUES (@EmployeeID, @EmployeeName, @EmployeeSalaryUnit, @EmployeeSalary, @EmployeeEmail, @EmployeePhoneContact, @FirstDateOfWork);
END;


CREATE PROCEDURE EmployeeDetailsUpdate
    @EmployeeID VARCHAR(255),
    @EmployeeName VARCHAR(255),
    @EmployeeSalaryUnit FLOAT,
    @EmployeeSalary FLOAT,
    @EmployeeEmail VARCHAR(255),
    @EmployeePhoneContact FLOAT,
    @FirstDateOfWork DATE,
    @LastDateOfWork DATE
AS
BEGIN
    UPDATE EmployeesDetails
    SET EmployeeName = @EmployeeName,
        EmployeeSalaryUnit = @EmployeeSalaryUnit,
        EmployeeSalary = @EmployeeSalary,
        EmployeeEmail = @EmployeeEmail,
        EmployeePhoneContact = @EmployeePhoneContact,
        FirstDateOfWork = @FirstDateOfWork,
        LastDateOfWork = @LastDateOfWork
    WHERE EmployeeID = @EmployeeID;
END;


CREATE PROCEDURE EmployeeDetailsDelete
	@EmployeeID VARCHAR(255),
	@EmployeeName VARCHAR(255)
AS
BEGIN
    DELETE FROM EmployeesDetails
    WHERE @EmployeeID = EmployeeID and @EmployeeName = EmployeeName
END;

Drop proc EmployeeDetailsDelete


