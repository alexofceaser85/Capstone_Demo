CREATE TABLE [dbo].[Grades]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Subject] NVARCHAR(50) NOT NULL, 
    [GradeAmount] DECIMAL(3, 2) NOT NULL
)
