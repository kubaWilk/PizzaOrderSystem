CREATE PROCEDURE [dbo].[spOrders_GetOrderHistory]
	@UserID int
AS
	SELECT *
	FROM dbo.Orders
	Where UserID = @UserID
RETURN 0
