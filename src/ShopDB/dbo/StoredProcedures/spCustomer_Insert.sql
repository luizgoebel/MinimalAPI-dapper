CREATE PROCEDURE [dbo].[spCustomer_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
Begin
	INSERT INTO dbo.Customer (FirstName, LastName) VALUES (@FirstName, @LastName);
End
