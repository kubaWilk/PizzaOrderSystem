CREATE PROCEDURE [dbo].[SpOrders_GetLastOrderID]
AS
	SELECT MAX(ID)
	FROM dbo.Orders
RETURN 0
