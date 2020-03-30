CREATE PROCEDURE [dbo].[spMenu_GetMenuItemsByType]
	@RequestedType nvarchar(50)
AS
	SELECT *
	FROM dbo.Menu
	WHERE ItemType = @RequestedType;
RETURN 0
