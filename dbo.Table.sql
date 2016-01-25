CREATE TABLE [dbo].[Candidate]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
	[Gender] NVARCHAR(50) NOT NULL,
    [BirthDate] DATE NOT NULL, 
    [Height] FLOAT NOT NULL, 
    [Ethnical] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [HighSchool] NVARCHAR(50) NOT NULL,
	[Service] NVARCHAR(50) NOT NULL, 
    [Employment] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Info] NVARCHAR(50) NOT NULL, 
    [ThirdParty] NVARCHAR(50) NOT NULL, 
    [Sector] NVARCHAR(50) NOT NULL, 
    [Hobbies] NVARCHAR(50) NOT NULL, 
    [LookingNature] NVARCHAR(50) NOT NULL, 
    [LookingAppearance] NVARCHAR(50) NOT NULL, 
	[AgeRange] NVARCHAR(50), 
    [More] NVARCHAR(50) NULL, 
    [Pic1] NVARCHAR(50) NOT NULL, 
    [Pic2] NVARCHAR(50) NOT NULL
)
