CREATE TABLE customers
(
    CustomerId int not null IDENTITY(1,1),
    constraint pk_customers PRIMARY KEY (CustomerId)
);

ALTER TABLE Orders
    DROP COLUMN Customer;

ALTER TABLE Orders    
    ADD CustomerId int;

ALTER TABLE Orders
    ADD CONSTRAINT fk_Customers FOREIGN key (CustomerId) REFERENCES customers(CustomerId)

ALTER TABLE OrderDetails
    ADD Line_Total money;