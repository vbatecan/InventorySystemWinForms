CREATE TABLE Users (
  UserId int PRIMARY KEY AUTO_INCREMENT,
  Username varchar(50) UNIQUE NOT NULL,
  Password varchar(255) NOT NULL,
  FullName varchar(120) NOT NULL,
  UserRole ENUM ('Admin', 'Staff') NOT NULL DEFAULT 'Staff',
  IsActive boolean NOT NULL DEFAULT true,
  CreatedAt datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP)
);

CREATE TABLE Categories (
  CategoryId int PRIMARY KEY AUTO_INCREMENT,
  CategoryName varchar(100) UNIQUE NOT NULL,
  Description varchar(255),
  IsActive boolean NOT NULL DEFAULT true
);

CREATE TABLE Units (
  UnitId smallint PRIMARY KEY AUTO_INCREMENT,
  UnitName varchar(50) UNIQUE NOT NULL,
  UnitSymbol varchar(15) UNIQUE NOT NULL,
  AllowsFraction boolean NOT NULL DEFAULT false
);

CREATE TABLE Suppliers (
  SupplierId int PRIMARY KEY AUTO_INCREMENT,
  SupplierName varchar(150) NOT NULL,
  ContactPerson varchar(120),
  Phone varchar(35),
  Email varchar(150),
  Address varchar(255),
  IsActive boolean NOT NULL DEFAULT true
);

CREATE TABLE Products (
  ProductId bigint PRIMARY KEY AUTO_INCREMENT,
  Sku varchar(50) UNIQUE NOT NULL,
  ProductName varchar(150) NOT NULL,
  Description varchar(500),
  CategoryId int NOT NULL,
  UnitId smallint NOT NULL,
  SupplierId int,
  CostPrice decimal(12,2) NOT NULL DEFAULT 0 COMMENT 'CHECK CostPrice >= 0',
  SellingPrice decimal(12,2) NOT NULL DEFAULT 0 COMMENT 'CHECK SellingPrice >= 0',
  ReorderLevel decimal(12,3) NOT NULL DEFAULT 0 COMMENT 'CHECK ReorderLevel >= 0',
  IsActive boolean NOT NULL DEFAULT true,
  CreatedAt datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP),
  UpdatedAt datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP) COMMENT 'MySQL ON UPDATE CURRENT_TIMESTAMP'
);

CREATE TABLE StockMovements (
  MovementId bigint PRIMARY KEY AUTO_INCREMENT,
  ProductId bigint NOT NULL,
  MovementType ENUM ('In', 'Out', 'AdjustIn', 'AdjustOut') NOT NULL,
  Quantity decimal(12,3) NOT NULL COMMENT 'CHECK Quantity > 0',
  StorageLocation varchar(60),
  ReferenceNo varchar(60),
  Remarks varchar(255),
  CreatedBy int,
  CreatedAt datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP)
);

CREATE TABLE AuditLogs (
  AuditId bigint PRIMARY KEY AUTO_INCREMENT,
  ActorUserId int,
  ActionType varchar(30) NOT NULL,
  EntityName varchar(60) NOT NULL,
  EntityId bigint,
  OldData json,
  NewData json,
  LoggedAt datetime NOT NULL DEFAULT (CURRENT_TIMESTAMP)
);

CREATE INDEX IdxSuppliersName ON Suppliers (SupplierName);

CREATE INDEX IdxProductsName ON Products (ProductName);

CREATE INDEX IdxProductsCategory ON Products (CategoryId);

CREATE INDEX IdxProductsSupplier ON Products (SupplierId);

CREATE INDEX IdxMovementProductTime ON StockMovements (ProductId, CreatedAt);

CREATE INDEX IdxMovementReference ON StockMovements (ReferenceNo);

CREATE INDEX IdxMovementTime ON StockMovements (CreatedAt);

CREATE INDEX IdxAuditDate ON AuditLogs (LoggedAt);

CREATE INDEX IdxAuditEntity ON AuditLogs (EntityName, EntityId);

CREATE INDEX IdxAuditActor ON AuditLogs (ActorUserId);

ALTER TABLE Products ADD FOREIGN KEY (CategoryId) REFERENCES Categories (CategoryId) ON DELETE RESTRICT;

ALTER TABLE Products ADD FOREIGN KEY (UnitId) REFERENCES Units (UnitId) ON DELETE RESTRICT;

ALTER TABLE Products ADD FOREIGN KEY (SupplierId) REFERENCES Suppliers (SupplierId) ON DELETE SET NULL;

ALTER TABLE StockMovements ADD FOREIGN KEY (ProductId) REFERENCES Products (ProductId) ON DELETE RESTRICT;

ALTER TABLE StockMovements ADD FOREIGN KEY (CreatedBy) REFERENCES Users (UserId) ON DELETE SET NULL;

ALTER TABLE AuditLogs ADD FOREIGN KEY (ActorUserId) REFERENCES Users (UserId) ON DELETE SET NULL;

DELIMITER //

CREATE FUNCTION GetCurrentStock(p_product_id BIGINT)
RETURNS DECIMAL(12,3)
READS SQL DATA
BEGIN
    RETURN (
        SELECT
            COALESCE(SUM(CASE WHEN MovementType IN ('In', 'AdjustIn') THEN Quantity ELSE 0 END), 0)
            - COALESCE(SUM(CASE WHEN MovementType IN ('Out', 'AdjustOut') THEN Quantity ELSE 0 END), 0)
        FROM StockMovements
        WHERE ProductId = p_product_id
    );
END //

DELIMITER ;
