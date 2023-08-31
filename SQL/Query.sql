/*
Product M <-> M Category
Product(pk ID) <-> (fk ProductId)ProductCategory(fk CategoryId) <-> (pk ID)Category
*/

/*
CREATE TABLE Product 
( 
    ID          NVARCHAR(4000), 
    Name        NVARCHAR(200), 
); 

CREATE TABLE ProductCategory 
( 
    ID          NVARCHAR(4000), 
    ProductId   NVARCHAR(200), 
    CategoryId  NVARCHAR(200) 
); 

CREATE TABLE Category 
( 
    ID          NVARCHAR(4000), 
    Name        NVARCHAR(200), 
); 

INSERT INTO Product (ID, Name) VALUES ('1', 'ap');
INSERT INTO Product (ID, Name) VALUES ('2', 'bp');
INSERT INTO Product (ID, Name) VALUES ('3', 'cp');
INSERT INTO Product (ID, Name) VALUES ('5', 'dp');

INSERT INTO Category (ID, Name) VALUES ('1', 'ac');
INSERT INTO Category (ID, Name) VALUES ('2', 'bc');
INSERT INTO Category (ID, Name) VALUES ('3', 'cc');

INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('1', Null, '1');
INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('2', '1', '2');
INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('3', '1', '3');
INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('4', '2', Null);
INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('5', '2', 1);
INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('6', Null, Null);
INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('7', '4', Null);
INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('8', '3', '4');
INSERT INTO ProductCategory (ID, ProductId, CategoryId) VALUES ('9', '3', '3');
*/

SELECT P.Name as ProductName, C.Name as CategoryName
FROM Product P
LEFT JOIN ProductCategory PC ON PC.ProductId = P.ID AND PC.CategoryId IS NOT NULL
LEFT JOIN Category C ON C.ID = PC.CategoryId 
ORDER BY ProductName