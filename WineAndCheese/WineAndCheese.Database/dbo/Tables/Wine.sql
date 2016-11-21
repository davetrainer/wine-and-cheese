CREATE TABLE [dbo].[Wine]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [GrapeId] INT NOT NULL, 
    [CountryId] INT NOT NULL
)
