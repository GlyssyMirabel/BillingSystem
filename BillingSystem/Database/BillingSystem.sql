USE BillingDB;
 
CREATE TABLE IF NOT EXISTS Billing (
    BillingID       INT           NOT NULL AUTO_INCREMENT,
    CustomerID      INT           NOT NULL,
    BillingMonth    VARCHAR(20)   NOT NULL,
    PreviousReading INT           NOT NULL DEFAULT 0,
    PresentReading  INT           NOT NULL DEFAULT 0,
    Consumption     INT           NOT NULL DEFAULT 0,
    RatePerCubic    DECIMAL(10,2) NOT NULL DEFAULT 18.50,
    TotalAmount     DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Status          VARCHAR(20)   NOT NULL DEFAULT 'Unpaid',
    BillingDate     DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT pk_Billing  PRIMARY KEY (BillingID),
    CONSTRAINT fk_Customer FOREIGN KEY (CustomerID)
               REFERENCES Customers(CustomerID)
               ON DELETE CASCADE ON UPDATE CASCADE
);

