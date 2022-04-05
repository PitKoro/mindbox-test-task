CREATE TABLE dbo.Product (
    ProductId    INT PRIMARY KEY IDENTITY (1, 1),
    ProductName  NVARCHAR (255)
);


CREATE TABLE dbo.Category (
    CategoryId    INT PRIMARY KEY IDENTITY (1, 1),
    CategoryName  NVARCHAR (255)
);




CREATE TABLE dbo.ProductCategories (
    ProductId INT,
    CategoryId INT,

    UNIQUE (ProductId, CategoryId),
    CONSTRAINT fk_product_id
    FOREIGN KEY (ProductId)
    REFERENCES dbo.Product (ProductId)
    ON DELETE SET NULL,

    CONSTRAINT fk_category_id
    FOREIGN KEY (CategoryId)
    REFERENCES dbo.Category (CategoryId)
    ON DELETE SET NULL,

);


-- Заполним таблицу Product данными.
SET IDENTITY_INSERT dbo.Product ON
insert into dbo.Product(ProductId, ProductName) values (1, N'First Product')
insert into dbo.Product(ProductId, ProductName) values (2, N'Second Product')
insert into dbo.Product(ProductId, ProductName) values (3, N'Third Product')
SET IDENTITY_INSERT dbo.Product OFF

-- Заполним таблицу Category данными.
SET IDENTITY_INSERT dbo.Category ON
insert into dbo.Category(CategoryId, CategoryName) values (1, N'First Category')
insert into dbo.Category(CategoryId, CategoryName) values (2, N'Second Category')
insert into dbo.Category(CategoryId, CategoryName) values (3, N'Third Category')
SET IDENTITY_INSERT dbo.Category OFF

-- Заполним таблицу ProductCategories данными.
insert into dbo.ProductCategories(ProductId, CategoryId) values (1, 1)
insert into dbo.ProductCategories(ProductId, CategoryId) values (1, 2)
insert into dbo.ProductCategories(ProductId, CategoryId) values (2, 3)
insert into dbo.ProductCategories(ProductId, CategoryId) values (3, 3)


SELECT Product.ProductName, Category.CategoryName
FROM Product
LEFT JOIN ProductCategories ON ProductCategories.ProductId = Product.ProductId
LEFT JOIN Category ON Category.CategoryId = ProductCategories.CategoryId;