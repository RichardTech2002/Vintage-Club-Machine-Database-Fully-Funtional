﻿/*
Deployment script for Machine_Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Machine_Database"
:setvar DefaultFilePrefix "Machine_Database"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Starting rebuilding table [dbo].[General_Table]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_General_Table] (
    [Id]                      INT            IDENTITY (1, 1) NOT NULL,
    [Machine_Type]            NCHAR (25)     NULL,
    [Year_Built]              INT            NULL,
    [Original_Owner]          NCHAR (100)    NULL,
    [Date_Acquired]           DATE           NULL,
    [Description]             VARCHAR (MAX)  NULL,
    [Image]                   IMAGE          NULL,
    [Maintenence_Information] VARCHAR (MAX)  NULL,
    [Model]                   NCHAR (25)     NULL,
    [Horse_Power]             NCHAR (50)     NULL,
    [Machine_Location]        NCHAR (50)     NULL,
    [Restoration_Status]      NCHAR (50)     NULL,
    [Link_to_TractorData]     NVARCHAR (MAX) NULL,
    [Donated_Or_Loaned]       NCHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[General_Table])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_General_Table] ON;
        INSERT INTO [dbo].[tmp_ms_xx_General_Table] ([Id], [Machine_Type], [Year_Built], [Original_Owner], [Date_Acquired], [Description], [Image], [Maintenence_Information], [Model], [Horse_Power], [Machine_Location], [Restoration_Status], [Link_to_TractorData], [Donated_Or_Loaned])
        SELECT   [Id],
                 [Machine_Type],
                 [Year_Built],
                 [Original_Owner],
                 [Date_Acquired],
                 [Description],
                 [Image],
                 [Maintenence_Information],
                 [Model],
                 [Horse_Power],
                 [Machine_Location],
                 [Restoration_Status],
                 [Link_to_TractorData],
                 [Donated_Or_Loaned]
        FROM     [dbo].[General_Table]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_General_Table] OFF;
    END

DROP TABLE [dbo].[General_Table];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_General_Table]', N'General_Table';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Update complete.';


GO