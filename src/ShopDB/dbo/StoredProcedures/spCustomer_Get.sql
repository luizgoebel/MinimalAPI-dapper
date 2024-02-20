CREATE PROCEDURE [dbo].[spCustomer_Get]
	@id int
AS
Begin
	SELECT * FROM dbo.Customer WHERE Id = @id;
End
