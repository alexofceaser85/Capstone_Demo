CREATE TABLE [dbo].[Grades] (
    [Id]          INT            NOT NULL IDENTITY(1,1),
    [Name]        NVARCHAR (50)  NOT NULL,
    [Subject]     NVARCHAR (50)  NOT NULL,
    [GradeAmount] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);