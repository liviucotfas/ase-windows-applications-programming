CREATE TABLE [dbo].[Participant]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] NVARCHAR(50) NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [BirthDate] DATE NULL,
    [RaceId] INT NOT NULL, 
)