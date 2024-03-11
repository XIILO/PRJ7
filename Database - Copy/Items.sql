

CREATE TABLE Items (
    ItemName VARCHAR(255) NOT NULL,
    ItemsState VARCHAR(255),
    Numbers INT,
    ItemsUnit VARCHAR(255),
    PricePerUnit FLOAT,
    TotalPrices FLOAT,
    ItemsDateOfManufacture DATE,
    ItemsExpire DATE,
    CategoryName VARCHAR(255),
    FOREIGN KEY (CategoryName) REFERENCES Category(CategoryName) ON DELETE CASCADE
);

Drop table 

CREATE PROCEDURE ItemsView
AS
BEGIN
    SELECT 
        CategoryID,
        ItemName,
        ItemsState,
        Numbers,
        ItemsUnit,
        PricePerUnit,
        TotalPrices,
        ItemsDateOfManufacture,
        ItemsExpire
    FROM Items;
END;


CREATE PROCEDURE ItemsAdd
    @CategoryID VARCHAR(255),
    @ItemName VARCHAR(255),
    @ItemsState VARCHAR(255),
    @Numbers INT,
    @ItemsUnit VARCHAR(255),
    @PricePerUnit FLOAT,
    @TotalPrices FLOAT,
    @ItemsDateOfManufacture DATE,
    @ItemsExpire DATE
AS
BEGIN
    INSERT INTO Items (CategoryID, ItemName, ItemsState, Numbers, ItemsUnit, PricePerUnit, TotalPrices, ItemsDateOfManufacture, ItemsExpire)
    VALUES (@CategoryID, @ItemName, @ItemsState, @Numbers, @ItemsUnit, @PricePerUnit, @TotalPrices, @ItemsDateOfManufacture, @ItemsExpire);
END;

CREATE PROCEDURE ItemsUpdate
    @CategoryID VARCHAR(255),
    @ItemName VARCHAR(255),
    @NewItemsState VARCHAR(255),
    @NewNumbers INT,
    @NewItemsUnit VARCHAR(255),
    @NewPricePerUnit FLOAT,
    @NewTotalPrices FLOAT,
    @NewItemsDateOfManufacture DATE,
    @NewItemsExpire DATE
AS
BEGIN
    UPDATE Items
    SET ItemsState = @NewItemsState,
        Numbers = @NewNumbers,
        ItemsUnit = @NewItemsUnit,
        PricePerUnit = @NewPricePerUnit,
        TotalPrices = @NewTotalPrices,
        ItemsDateOfManufacture = @NewItemsDateOfManufacture,
        ItemsExpire = @NewItemsExpire
    WHERE CategoryID = @CategoryID AND ItemName = @ItemName;
END;




CREATE PROCEDURE ItemsDelete
    @ItemName VARCHAR(255)
AS
BEGIN
    DELETE FROM Items
    WHERE ItemName = @ItemName;
END;

