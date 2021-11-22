USE [DemoDataContext]
GO

/****** Object: Table [dbo].[Customer] Script Date: 2021/11/22 09:57:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50)  NOT NULL,
    [LastName] NVARCHAR (100) NOT NULL
);


