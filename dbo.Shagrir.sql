CREATE TABLE [dbo].[Shagrir]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Reputation] INT NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [Gender] NVARCHAR(50) NOT NULL
)
