CREATE TABLE [dbo].[General Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MachineName] NCHAR(25) NULL, 
    [YearBuilt] INT NULL, 
    [DonatedBy] NCHAR(25) NULL, 
    [DonationDate] INT NULL, 
    [Description] VARCHAR(1500) NULL, 
    [Image] IMAGE NULL
)
