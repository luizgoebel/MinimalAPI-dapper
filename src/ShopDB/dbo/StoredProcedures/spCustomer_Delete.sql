CREATE PROCEDURE [dbo].[spCustomer_Delete]
	@Id int
AS
Begin
	Delete FROM dbo.Customer WHERE Id = @Id;
End
