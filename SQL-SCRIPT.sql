USE [master]
GO

CREATE DATABASE [TechTalk]
GO

USE [TechTalk]
GO 

CREATE TABLE [dbo].[Speakers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](25) NOT NULL,
	[LastName] [nvarchar](25) NOT NULL, 
	PRIMARY KEY ([Id])
)
GO

CREATE TABLE [dbo].[Events](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[StartAt] [datetime] NOT NULL,
	[EndAt] [datetime] NOT NULL,
	[SpeakerId] [int] NOT NULL,
	PRIMARY KEY ([Id]),
	FOREIGN KEY([SpeakerId]) REFERENCES [dbo].[Speakers] ([Id])
)
GO

SET IDENTITY_INSERT [dbo].[Speakers] ON 
GO
INSERT [dbo].[Speakers] ([Id], [FirstName], [LastName]) VALUES (1, N'John', N'Smith')
GO
INSERT [dbo].[Speakers] ([Id], [FirstName], [LastName]) VALUES (2, N'Peter', N'Kios')
GO
SET IDENTITY_INSERT [dbo].[Speakers] OFF
GO

SET IDENTITY_INSERT [dbo].[Events] ON 
GO
INSERT [dbo].[Events] ([Id], [Title], [StartAt], [EndAt], [SpeakerId]) VALUES (1, N'The power of Software', CAST(N'2023-01-10T10:00:00.000' AS DateTime), CAST(N'2023-01-10T11:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Events] ([Id], [Title], [StartAt], [EndAt], [SpeakerId]) VALUES (2, N'The Rumour''s weapon', CAST(N'2023-01-10T12:00:00.000' AS DateTime), CAST(N'2023-01-10T13:00:00.000' AS DateTime), 2)
GO
SET IDENTITY_INSERT [dbo].[Events] OFF

GO


