CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL,
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Street] NVARCHAR(250) NOT NULL, 
    [City] NVARCHAR(100) NOT NULL, 
    [PostCode] NVARCHAR(50) NOT NULL, 
    
)
