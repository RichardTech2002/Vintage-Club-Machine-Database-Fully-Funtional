CREATE TABLE [dbo].[General Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Machine Name] NCHAR(25) NULL, 
    [Year Built] INT NULL, 
    [Donated By] NCHAR(100) NULL, 
    [Donation Date] INT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [Image] IMAGE NULL, 
    [Maintenence Information] VARCHAR(MAX) NULL, 
    [Model] NCHAR(25) NULL, 
    [Horse Power] NCHAR(50) NULL
)
