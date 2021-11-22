USE [DemoDataContext]
GO

/****** Object: Table [dbo].[Bundles] Script Date: 2021/11/22 09:57:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bundles] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [Discount] INT NOT NULL
);


