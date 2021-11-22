USE [DemoDataContext]
GO

/****** Object: Table [dbo].[BasketItems] Script Date: 2021/11/22 09:58:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BasketItems] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [ProductId] INT             NOT NULL,
    [Category]  NVARCHAR (100)  NOT NULL,
    [Name]      NVARCHAR (100)  NOT NULL,
    [Price]     DECIMAL (18, 2) NOT NULL,
    [BasketId]  INT             NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_BasketItems_BasketId]
    ON [dbo].[BasketItems]([BasketId] ASC);


GO
ALTER TABLE [dbo].[BasketItems]
    ADD CONSTRAINT [PK_BasketItems] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[BasketItems]
    ADD CONSTRAINT [FK_BasketItems_Basket_BasketId] FOREIGN KEY ([BasketId]) REFERENCES [dbo].[Basket] ([Id]);


