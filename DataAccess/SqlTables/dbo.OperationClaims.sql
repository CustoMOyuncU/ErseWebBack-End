USE [ErseWeb]
GO

/****** Object: Table [dbo].[OperationClaims] Script Date: 1.09.2021 12:42:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL
);


