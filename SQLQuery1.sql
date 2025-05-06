CREATE TABLE People (
	Id INT IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50)
);

INSERT INTO People (FirstName, LastName)
VALUES ('Akbar', 'Denardo'), ('Beenish', 'Farooqi');