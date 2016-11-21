CREATE TABLE [dbo].[Cheese]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(100) NOT NULL, 
    [CountryId] INT NOT NULL, 
    CONSTRAINT [FK_Cheese_Country] FOREIGN KEY ([CountryId]) REFERENCES [Country]([Id])
)

GO

CREATE INDEX [IX_Cheese_Country] ON [dbo].[Cheese] ([CountryId])
