CREATE PROCEDURE [dbo].[spUsers_DoesUserExistByEMail]
	@UserEMail nvarchar(100)
AS
	SELECT *
	FROM dbo.Users
	Where EMail = @UserEMail
RETURN 0
