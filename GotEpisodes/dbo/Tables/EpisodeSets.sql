CREATE TABLE [dbo].[EpisodeSets] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [EpisodeTitle]  NVARCHAR (MAX) NULL,
    [Season]        INT            NOT NULL,
    [EpisodeNumber] INT            NOT NULL,
    [Description]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.EpisodeSets] PRIMARY KEY CLUSTERED ([Id] ASC)
);

