SET IDENTITY_INSERT [dbo].[BundleItems] ON
INSERT INTO [dbo].[BundleItems] ([Id], [ProductID], [Category], [Name], [Price], [BundlesId]) VALUES (1, 2, N'Electronic', N'Camera', CAST(50.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[BundleItems] ([Id], [ProductID], [Category], [Name], [Price], [BundlesId]) VALUES (2, 6, N'Accessories', N'Strap', CAST(10.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[BundleItems] ([Id], [ProductID], [Category], [Name], [Price], [BundlesId]) VALUES (3, 1, N'Electronic', N'TV', CAST(100.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[BundleItems] ([Id], [ProductID], [Category], [Name], [Price], [BundlesId]) VALUES (4, 5, N'Furniture', N'Chair', CAST(40.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[BundleItems] ([Id], [ProductID], [Category], [Name], [Price], [BundlesId]) VALUES (5, 4, N'Furniture', N'Stand', CAST(50.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[BundleItems] OFF
