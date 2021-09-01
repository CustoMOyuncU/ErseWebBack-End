USE [ErseWeb]
GO

/****** Object: Table [dbo].[Users] Script Date: 1.09.2021 12:42:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50)   NOT NULL,
    [LastName]     NVARCHAR (50)   NOT NULL,
    [Email]        NVARCHAR (50)   NOT NULL,
    [PasswordSalt] VARBINARY (MAX) NOT NULL,
    [PasswordHash] VARBINARY (MAX) NOT NULL,
    [Status]       BIT             NOT NULL
);


