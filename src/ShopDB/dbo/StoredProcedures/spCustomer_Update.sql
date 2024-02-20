CREATE PROCEDURE [dbo].[spCustomer_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
Begin
	UPDATE dbo.Customer SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id;
End
