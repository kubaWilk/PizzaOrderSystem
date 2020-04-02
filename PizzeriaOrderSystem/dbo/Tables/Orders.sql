CREATE TABLE [dbo].[Orders]
(
	[ID] INT NOT NULL  IDENTITY, 
    [UserID] INT NOT NULL, 
    [OrderItems] NVARCHAR(MAX) NOT NULL, 
    [OrderComments] NVARCHAR(250) NULL, 
    PRIMARY KEY ([ID])
)
