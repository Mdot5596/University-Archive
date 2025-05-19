USE ISAD251_<EDIT THIS>;
GO

ALTER TABLE OrderDetails
    ADD CONSTRAINT FK_Products FOREIGN KEY (ProductId) REFERENCES Products(ProductId);
GO

CREATE PROCEDURE Delete_Products(@ProductId as INT) AS
BEGIN

    BEGIN TRANSACTION
        DECLARE @Error NVARCHAR(Max);

        BEGIN TRY
        
            DELETE FROM Products
            WHERE ProductId = @ProductId;

            IF @@TRANCOUNT > 0 COMMIT;
        END TRY
        BEGIN CATCH
            SET @Error = 'An error was encountered : Delete could not happen';
            IF @@TRANCOUNT > 0
                ROLLBACK TRANSACTION;
            RAISERROR(@Error, 1, 0);
        END CATCH; 
END;
GO

CREATE VIEW Sales AS
SELECT sum(OrderDetails.Quantity * Products.Price) as TotalCost,
 Orders.OrderId, Customer.Customer_Name
 FROM OrderDetails, Products, Orders, Customers
 WHERE orders.OrderId = OrderDetails.OrderId
 AND OrderDetails.ProductId = Products.ProductId
 AND Customers.customerId = Orders.customerId 
 GROUP BY orders.OrderId;

GO

CREATE TRIGGER ChangeStock ON OrderDetails
AFTER INSERT
AS
BEGIN
    UPDATE Products
    SET Products.Quantity = Products.Quantity - inserted.Quantity
    FROM inserted
    WHERE Products.ProductId = inserted.ProductId
END;

GO

CREATE PROCEDURE FindProduct(@ProductID as INT) AS
BEGIN 
    SELECT Product_Details, Price, Quantity
    FROM Products
    WHERE ProductId = @ProductID
END;


EXEC Delete_Products 2;
GO
SELECT * FROM Products;
GO
