USE [DemoDataContext]
GO

/****** Object: Table [dbo].[Order] Script Date: 2021/11/22 09:57:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Order] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT NOT NULL,
    [BasketId]   INT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Order_BasketId]
    ON [dbo].[Order]([BasketId] ASC);


GO
ALTER TABLE [dbo].[Order]
    ADD CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Order]
    ADD CONSTRAINT [FK_Order_Basket_BasketId] FOREIGN KEY ([BasketId]) REFERENCES [dbo].[Basket] ([Id]);


