CREATE PROCEDURE [dbo].[spOrders_InsertANewOrder]
	@UserID int,
	@OrderItems nvarchar(MAX),
	@OrderComments nvarchar(250)
AS
	INSERT INTO dbo.Orders(UserID, OrderItems, OrderComments)
	VALUES(@UserID, @OrderItems, @OrderComments);
RETURN 0
