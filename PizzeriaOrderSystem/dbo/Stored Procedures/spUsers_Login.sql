CREATE PROCEDURE [dbo].[spUsers_Login]
	@UserName nvarchar(50),
	@Password nvarchar(50)
AS
	SELECT *
	FROM dbo.Users
	WHERE UserName = @UserName
	AND Password = @Password;
RETURN 0
