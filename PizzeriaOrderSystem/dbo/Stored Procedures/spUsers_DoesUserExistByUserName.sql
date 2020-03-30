CREATE PROCEDURE [dbo].[spUsers_DoesUserExistByUserName]
	@UserName nvarchar(50)
AS
	SELECT *
	FROM dbo.Users
	Where UserName = @UserName
RETURN 0
