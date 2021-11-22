USE [DemoDataContext]
GO

/****** Object: Table [dbo].[BundleItems] Script Date: 2021/11/22 09:57:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BundleItems] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [ProductID] INT             NOT NULL,
    [Category]  NVARCHAR (100)  NOT NULL,
    [Name]      NVARCHAR (100)  NOT NULL,
    [Price]     DECIMAL (18, 2) NOT NULL,
    [BundlesId] INT             NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_BundleItems_BundlesId]
    ON [dbo].[BundleItems]([BundlesId] ASC);


GO
ALTER TABLE [dbo].[BundleItems]
    ADD CONSTRAINT [PK_BundleItems] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[BundleItems]
    ADD CONSTRAINT [FK_BundleItems_Bundles_BundlesId] FOREIGN KEY ([BundlesId]) REFERENCES [dbo].[Bundles] ([Id]) ON DELETE CASCADE;


