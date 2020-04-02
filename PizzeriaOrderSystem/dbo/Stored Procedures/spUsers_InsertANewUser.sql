CREATE PROCEDURE [dbo].[spUsers_InsertANewUser]
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@UserEmail nvarchar(100),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Street nvarchar(50),
	@City nvarchar(50),
	@PostCode nvarchar(50)
AS
	INSERT INTO dbo.Users(UserName, Password, EMail, FirstName, LastName, Street, City, PostCode)
	VALUES (@UserName, @Password, @UserEmail, @FirstName, @LastName, @Street, @City, @PostCode);
RETURN 0
