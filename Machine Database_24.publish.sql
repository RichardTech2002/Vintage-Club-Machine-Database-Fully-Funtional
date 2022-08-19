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
PRINT N'The following operation was generated from a refactoring log file 37e64cfe-3231-4a2d-a9c9-2de11a08e3c6';

PRINT N'Rename [dbo].[General_Table].[Second_Image] to SecondImage';


GO
EXECUTE sp_rename @objname = N'[dbo].[General_Table].[Second_Image]', @newname = N'SecondImage', @objtype = N'COLUMN';


GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '37e64cfe-3231-4a2d-a9c9-2de11a08e3c6')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('37e64cfe-3231-4a2d-a9c9-2de11a08e3c6')

GO

GO
PRINT N'Update complete.';


GO