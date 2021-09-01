USE [ErseWeb]
GO

/****** Object: Table [dbo].[Colors] Script Date: 1.09.2021 12:42:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Colors] (
    [ColorId]   INT          IDENTITY (1, 1) NOT NULL,
    [ColorName] VARCHAR (20) NOT NULL
);


