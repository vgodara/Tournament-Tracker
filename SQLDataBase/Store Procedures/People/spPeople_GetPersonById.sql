CREATE PROCEDURE spPeopel_GetPersonById
	@PersonId INT,
	@OutputJson NVARCHAR(MAX) OUTPUT

AS
BEGIN
	SET NOCOUNT ON
    SET @OutputJson = (SELECT Id, FirstName, LastName, EmailAddress, CellPhoneNumber
	FROM People 
	WHERE Id = @PersonId
	FOR JSON AUTO, INCLUDE_NULL_VALUES,WITHOUT_ARRAY_WRAPPER)
END
