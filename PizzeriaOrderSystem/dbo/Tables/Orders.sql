CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL  IDENTITY, 
    [UserID] INT NOT NULL, 
    [OrderItems] NVARCHAR(MAX) NOT NULL, 
    [OrderComments] NVARCHAR(250) NULL, 
    PRIMARY KEY ([Id])
)
