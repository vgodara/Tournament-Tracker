CREATE PROCEDURE spPeople_SavePerson
	@InputJson NVARCHAR(MAX),
	@OutputJson NVARCHAR(MAX) OUTPUT

AS
BEGIN
	SET NOCOUNT ON
	DECLARE @PersonId INT
	DECLARE @FirstName NVARCHAR(50)
	DECLARE @LastName NVARCHAR(50) 
	DECLARE @EmailAdress NVARCHAR(200)
	DECLARE @CellPphoneNumber NVARCHAR(50)
	IF(ISJSON(@InputJson)!=1)
		THROW 400, N'Invalid Json' ,1;
	
	SET @FirstName= JSON_VALUE(@InputJson, '$.FirstName')
	SET @LastName =  JSON_VALUE(@InputJson, '$.LastName')
	SET @EmailAdress =  JSON_VALUE(@InputJson, '$.EmailAddress')
	SET @CellPphoneNumber = JSON_VALUE(@InputJson, '$.CellPhoneNumber')
		

	INSERT  
	INTO People(FirstName,
				LastName, 
				EmailAddress,
				CellPhoneNumber)
	VALUES (@FirstName,
			@LastName,
			@EmailAdress,
			@CellPphoneNumber)

	
	SET @personId = SCOPE_IDENTITY()
	EXEC spPeopel_GetPersonById @PersonId = @PersonId, @OutputJson = @OutputJson OUTPUT
END
