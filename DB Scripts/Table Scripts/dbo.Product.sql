USE [DemoDataContext]
GO

/****** Object: Table [dbo].[Product] Script Date: 2021/11/22 09:57:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (100)  NOT NULL,
    [Category] NVARCHAR (100)  NOT NULL,
    [Price]    DECIMAL (18, 2) NOT NULL
);


