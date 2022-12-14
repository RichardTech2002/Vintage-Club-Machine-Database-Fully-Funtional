CREATE TABLE [dbo].[General_Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Machine_Type] VARCHAR(50) NULL, 
    [Year_Built] DECIMAL NULL, 
    [Original_Owner] VARCHAR(100) NULL, 
    [Date_Acquired] VARCHAR(50) NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [Image] IMAGE NULL, 
    [Model] VARCHAR(25) NULL, 
    [Machine_Location] VARCHAR(50) NULL, 
    [Restoration_Status] VARCHAR(50) NULL, 
    [Link_to_TractorData] VARCHAR(MAX) NULL, 
    [Donated_Or_Loaned] VARCHAR(30) NULL, 
    [Make] NCHAR(50) NULL, 
    [SecondImage] IMAGE NULL, 
    [Other_Notes] VARCHAR(MAX) NULL, 
    [IfSold] VARCHAR(10) NULL, 
    [Maintenence_Information] VARCHAR(MAX) NULL,
    [FileLocation1] VARCHAR(MAX) NULL,
    [FileLocation2] VARCHAR(MAX) NULL
)
