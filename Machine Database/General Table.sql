CREATE TABLE [dbo].[General_Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Machine_Type] NCHAR(25) NULL, 
    [Year_Built] INT NULL, 
    [Original_Owner] NCHAR(100) NULL, 
    [Data_Acquired] DATE NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [Image] IMAGE NULL, 
    [Maintenence_Information] VARCHAR(MAX) NULL, 
    [Model] NCHAR(25) NULL, 
    [Horse_Power] NCHAR(50) NULL, 
    [Machine Location] NVARCHAR(MAX) NULL, 
    [Restoration_Status] NCHAR(50) NULL, 
    [Link_to_TractorData] NVARCHAR(MAX) NULL
)
