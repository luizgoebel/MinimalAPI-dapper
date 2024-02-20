CREATE PROCEDURE [dbo].[spCustomer_GetAll]
AS
Begin
	SELECT * FROM dbo.Customer;
End