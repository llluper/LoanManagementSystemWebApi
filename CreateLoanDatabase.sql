USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'LoanDB'
)
CREATE DATABASE [LoanDB]
GO
USE LoanDB
GO
CREATE TABLE LoanList 
(
    id INT, 
    balance DECIMAL, 
    interest DECIMAL, 
    earlyPaymentFee DECIMAL, 
    payout DECIMAL
)
GO
INSERT INTO LoanList VALUES (1, 2000, 200, 50, 2250); 
INSERT INTO LoanList VALUES (2, 5000, 500, 70, 5570);
INSERT INTO LoanList VALUES (3, 8000, 800, 100, 8900);
GO
