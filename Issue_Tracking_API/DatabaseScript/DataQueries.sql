SET IDENTITY_INSERT [dbo].[IssueDetails] ON
INSERT INTO [dbo].[IssueDetails] ([Id], [Issue_Description], [Issue_Reporter_Name], [Issue_Reported_Date], [Issue_Assignee_Name]) VALUES (1, N'Monitor is not working', N'Ranjodh Singh', N'2021-03-21 12:00:00', N'James Hong')
INSERT INTO [dbo].[IssueDetails] ([Id], [Issue_Description], [Issue_Reporter_Name], [Issue_Reported_Date], [Issue_Assignee_Name]) VALUES (2, N'Laptop hard disk crashed', N'Lessa li', N'2021-03-20 14:02:00', N'Amr Adel')
SET IDENTITY_INSERT [dbo].[IssueDetails] OFF
