CREATE TABLE [dbo].[EpisodeTable]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [Title] VARCHAR(50) NULL, 
    [Season ] INT NULL, 
    [Episode] INT NULL, 
    [Description] VARCHAR(MAX) NULL 
)
