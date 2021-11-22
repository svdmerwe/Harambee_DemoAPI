SET IDENTITY_INSERT [dbo].[BasketItems] ON
INSERT INTO [dbo].[BasketItems] ([Id], [ProductId], [Category], [Name], [Price], [BasketId]) VALUES (1, 2, N'Electronic', N'Camera', CAST(50.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[BasketItems] ([Id], [ProductId], [Category], [Name], [Price], [BasketId]) VALUES (2, 6, N'Accessories', N'Strap', CAST(10.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[BasketItems] OFF
