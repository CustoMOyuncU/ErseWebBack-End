USE [ErseWeb]
GO

/****** Object: Table [dbo].[Clothes] Script Date: 1.09.2021 12:41:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clothes] (
    [ClotheId]   INT IDENTITY (1, 1) NOT NULL,
    [ColorId]    INT NOT NULL,
    [CategoryId] INT NOT NULL
);


