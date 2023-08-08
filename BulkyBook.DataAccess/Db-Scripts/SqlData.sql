USE [BulkyBook]
GO


DELETE FROM [dbo].[Products]
GO

DELETE FROM [dbo].[Categories]
GO

DELETE FROM [dbo].[CoverTypes]
GO

SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder], [CreatedDateTime]) VALUES (6, N'Historical Fiction', 1, CAST(N'2023-08-08T21:17:36.2586786' AS DateTime2))
GO
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder], [CreatedDateTime]) VALUES (7, N'Horror', 2, CAST(N'2023-08-08T21:17:43.1225513' AS DateTime2))
GO
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder], [CreatedDateTime]) VALUES (8, N'Mystery', 3, CAST(N'2023-08-08T21:17:53.7937535' AS DateTime2))
GO
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder], [CreatedDateTime]) VALUES (9, N'Fiction', 4, CAST(N'2023-08-08T21:19:14.8658764' AS DateTime2))
GO
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder], [CreatedDateTime]) VALUES (10, N'Poetry', 5, CAST(N'2023-08-08T21:19:21.9976921' AS DateTime2))
GO
INSERT [dbo].[Categories] ([Id], [Name], [DisplayOrder], [CreatedDateTime]) VALUES (11, N'Biography', 6, CAST(N'2023-08-08T21:19:30.1070350' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[CoverTypes] ON 
GO
INSERT [dbo].[CoverTypes] ([Id], [Name]) VALUES (4, N'Paperback')
GO
INSERT [dbo].[CoverTypes] ([Id], [Name]) VALUES (5, N'Hardcover Case Wrap')
GO
INSERT [dbo].[CoverTypes] ([Id], [Name]) VALUES (6, N'Hardcover Dust Jacket')
GO
SET IDENTITY_INSERT [dbo].[CoverTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (4, N'Pride and Prejudice', N'<p>Pride and Prejudice is an 1813 novel of manners by Jane Austen. The novel follows the character development of Elizabeth Bennet, the protagonist of the book, who learns about the repercussions of hasty judgments and comes to appreciate the difference between superficial goodness and actual goodness.</p>', N'1992', N'Jane Austen', 1500, 1500, 1250, 1100, N'\images\products\bd01c2a2-27a7-4d00-a407-a213dff05e7a.jpg', 10, 4)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (5, N'To Kill a Mockingbird', N'<p>Harper Lee''s&nbsp;<em>To Kill a Mockingbird</em>&nbsp;upends the quiet solitude of a segregated Southern town with a story of innocence and virtue, bigotry and hate,</p>', N'1991', N'Harper Lee', 2000, 2000, 1800, 1500, N'\images\products\4eda8e88-23f9-46ae-984f-cbc0f8e81dc3.jpg', 6, 4)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (6, N'The Great Gatsby', N'<p>The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway''s interactions with mysterious millionaire Jay Gatsby and Gatsby''s obsession to reunite with his former lover, Daisy Buchanan.</p>', N'1993', N'F. Scott Fitzgerald', 5000, 5000, 4600, 4200, N'\images\products\99c5fe1a-d648-49a6-ba66-3d621b12658c.jpg', 8, 5)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (7, N'Catch-22', N'<p>Catch-22 is a satirical war novel by American author Joseph Heller. He began writing it in 1953; the novel was first published in 1961.</p>', N'1994', N'Joseph Heller', 1800, 1800, 1600, 1500, N'\images\products\4acef11b-b063-442b-ba51-696dc458a445.jpg', 11, 6)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (8, N'Wuthering Heights', N'<p>Wuthering Heights is an 1847 novel by Emily Bront&euml;, initially published under her pen name "Ellis Bell". It concerns two families of the landed gentry living on the West Yorkshire moors, the Earnshaws and the Lintons, and their turbulent relationships with the Earnshaws'' foster son, Heathcliff.</p>', N'1995', N'Emily Brontë', 10000, 10000, 8500, 7200, N'\images\products\bcbc2bdb-6412-4f8c-a0fb-11224f28a00f.jpg', 8, 6)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (9, N'Beloved', N'<p><em>Beloved</em>&nbsp;(1987) is a Pulitzer Prize-winning novel by Nobel laureate Toni Morrison. The novel, her fifth, is loosely based on the life and legal case of the slav</p>', N'1998', N'Toni Morrison', 9500, 9500, 8700, 8000, N'\images\products\e77d5f44-ecf6-4ec7-b364-c7597795abdd.jpg', 9, 6)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (10, N'The Catcher in the Rye', N'<p><em>The Catcher in the Rye</em>&nbsp;by JD Salinger (1951). JD Salinger''s study of teenage rebellion remains one of the most controversial and best-loved American novels</p>', N'820', N' J. D. Salinger', 8200, 8200, 7800, 7000, N'\images\products\3a6e2c0f-635f-4c2c-92c6-371f9720dc99.jpg', 11, 5)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (11, N'One Hundred Years of Solitude', N'<p>One Hundred Years of Solitude is a 1967 novel by Colombian author Gabriel Garc&iacute;a M&aacute;rquez that tells the multi-generational story of the Buend&iacute;a family, whose patriarch, Jos&eacute; Arcadio Buend&iacute;a, founded the fictitious town of Macondo. The novel is often cited as one of the supreme achievements in world literature.</p>', N'1697', N'Gabriel García Márquez', 5500, 5500, 4500, 3000, N'\images\products\bb9b500b-16eb-44b3-ad4d-b294c7215a1b.jpg', 11, 6)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (12, N'Crime and Punishment', N'<p>Crime and Punishment is a novel by the Russian author Fyodor Dostoevsky. It was first published in the literary journal The Russian Messenger in twelve monthly installments during 1866. It was later published in a single volume.</p>', N'1866', N'Fyodor Dostoevsky', 8900, 8900, 8520, 8220, N'\images\products\3725c831-ebc7-45a3-90ea-7f292cf7c749.jpg', 6, 6)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (13, N'Jane Eyre', N'<p>Jane Eyre is a novel by the English writer Charlotte Bront&euml;. It was published under her pen name "Currer Bell" on 19 October 1847 by Smith, Elder &amp; Co. of London. The first American edition was published the following year by Harper &amp; Brothers of New York.</p>', N'8569', N'Charlotte Brontë', 950, 950, 900, 800, N'\images\products\093d6b7f-2213-4afe-bae7-f4ac821056f8.jpg', 11, 4)
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [ISBN], [Author], [ListPrice], [Price], [Price50], [Price100], [ImageUrl], [CategoryId], [CoverTypeId]) VALUES (14, N'Things Fall Apart', N'<p>Things Fall Apart is the debut novel by Nigerian author Chinua Achebe, first published in 1958. It depicts pre-colonial life in the southeastern part of Nigeria and the invasion by Europeans during the late 19th century.</p>', N'8597', N'Chinua Achebe', 900, 900, 860, 820, N'\images\products\12e40ec2-8155-491d-a247-84aadae5e61c.jpg', 7, 4)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
