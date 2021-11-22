SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (1, N'TV', N'Electronic', CAST(100.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (2, N'Camera', N'Electronic', CAST(50.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (3, N'Radio', N'Electronic', CAST(20.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (4, N'Stand', N'Furniture', CAST(50.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (5, N'Chair', N'Furniture', CAST(40.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (6, N'Strap', N'Accessories', CAST(10.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (7, N'Lenses', N'Accessories', CAST(10.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Product] OFF
