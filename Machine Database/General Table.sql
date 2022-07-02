CREATE TABLE [dbo].[General Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Machine Name] NCHAR(25) NULL, 
    [Year Built] INT NULL, 
    [Donated By] NCHAR(25) NULL, 
    [Donation Date] INT NULL, 
    [Description] VARCHAR(2500) NULL, 
    [Image] IMAGE NULL, 
    [Maintenence Information] VARCHAR(5000) NULL
)
