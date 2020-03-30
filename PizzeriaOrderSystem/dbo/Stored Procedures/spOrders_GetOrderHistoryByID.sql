CREATE PROCEDURE [dbo].[spOrders_GetOrderHistoryByID]
	@UserID int
AS
	SELECT *
	FROM dbo.Orders
	WHERE UserID = @UserID;
RETURN 0
