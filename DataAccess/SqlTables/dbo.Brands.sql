USE [ErseWeb]
GO

/****** Object: Table [dbo].[Brands] Script Date: 1.09.2021 12:41:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT          IDENTITY (1, 1) NOT NULL,
    [BrandName] VARCHAR (30) NOT NULL
);


