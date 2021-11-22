USE [DemoDataContext]
GO

/****** Object: Table [dbo].[Basket] Script Date: 2021/11/22 09:58:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Basket] (
    [Id]    INT             IDENTITY (1, 1) NOT NULL,
    [Total] DECIMAL (18, 2) NOT NULL
);


