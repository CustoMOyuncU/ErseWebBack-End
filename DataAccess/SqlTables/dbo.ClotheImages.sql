USE [ErseWeb]
GO

/****** Object: Table [dbo].[ClotheImages] Script Date: 1.09.2021 12:41:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClotheImages] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [ClotheId]  INT            NOT NULL,
    [ImagePath] NVARCHAR (MAX) NOT NULL,
    [Date]      DATETIME       NOT NULL
);


