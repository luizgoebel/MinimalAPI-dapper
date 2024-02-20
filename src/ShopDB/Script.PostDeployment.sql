if not exists (SELECT 1 FROM dbo.Customer)
begin
	INSERT INTO dbo.Customer(FirstName, LastName)
	VALUES ('Daniel' , 'Jesus'),
	('Renato', 'Groofe'),
	('Thiago', 'Adriano'),
	('Ray', 'Carneiro'),
	('Luiz', 'Eduardo'),
	('Benjamin', 'Mafra')
end