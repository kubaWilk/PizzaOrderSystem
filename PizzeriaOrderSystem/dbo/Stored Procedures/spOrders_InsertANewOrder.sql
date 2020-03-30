CREATE PROCEDURE [dbo].[spOrders_InsertANewOrder]
	@UserID int,
	@OrderItems nvarchar(MAX),
	@Comments nvarchar(250)
AS
	INSERT INTO dbo.Orders(UserID, OrderItems, OrderComments)
	VALUES(@UserID, @OrderItems, @Comments);
RETURN 0
