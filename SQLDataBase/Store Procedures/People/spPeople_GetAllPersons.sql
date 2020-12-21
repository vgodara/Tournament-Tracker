CREATE PROCEDURE spPeople_GetAllPersons
	@json NVARCHAR(MAX) OUTPUT
	
AS
BEGIN 
	SET NOCOUNT ON
	SET @json  =(SELECT Id, FirstName, LastName, EmailAddress, CellPhoneNumber
	FROM People 
	FOR JSON AUTO, INCLUDE_NULL_VALUES)
end
