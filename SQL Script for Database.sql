USE [UserDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_EnrollDetail]    Script Date: 2/3/2024 4:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_EnrollDetail]
(
    @FirstName varchar(50) = NULL,
    @LastName varchar(50) = NULL,
    @Password nvarchar(30) = NULL,
    @Gender varchar(15) = NULL,
    @Email nvarchar(50) = NULL,
    @Phone varchar(15) = NULL,
    @status varchar(15)
)
AS
BEGIN
    IF @status = 'Insert'
    BEGIN
        INSERT INTO UserInfo(FirstName, LastName, Password, Gender, Email, Phone)
        VALUES (@FirstName, @LastName, @Password, @Gender, @Email, @Phone)
    END
END