CREATE TABLE [dbo].[General Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Machine Type] NCHAR(25) NULL, 
    [Year Built] INT NULL, 
    [Donated By] NCHAR(100) NULL, 
    [Donation Date] DATE NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [Image] IMAGE NULL, 
    [Maintenence Information] VARCHAR(MAX) NULL, 
    [Model] NCHAR(25) NULL, 
    [Horse Power] NCHAR(50) NULL, 
    [Machine Location] NVARCHAR(MAX) NULL, 
    [Restoration Status] NCHAR(50) NULL, 
    [Link to TractorData] NVARCHAR(MAX) NULL
)
