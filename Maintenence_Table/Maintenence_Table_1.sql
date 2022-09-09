CREATE TABLE [dbo].[Maintenence_Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ID_Grabber] INT NULL, 
    [Date] VARCHAR(MAX) NULL, 
    [Who_By] VARCHAR(MAX) NULL, 
    [Maintenence_Information] VARCHAR(MAX) NULL, 
    [Basic_Title] VARCHAR(100) NULL, 
    [AutoManual] NCHAR(10) NULL
)
