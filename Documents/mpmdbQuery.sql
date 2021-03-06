USE [mpmdb]
GO

--------------Create Database Tables--------------

CREATE TABLE [dbo].[AuthenticationTypes](
	[AuthenticationTypeID] [nvarchar](5) NOT NULL,
	[AuthenticationTypeName] [nvarchar](15) NOT NULL,
	PRIMARY KEY(AuthenticationTypeID)
) 

CREATE TABLE [dbo].[Genders](
	[GenderID] [nvarchar](5) NOT NULL,
	[GenderName] [nvarchar](10) NOT NULL,
	PRIMARY KEY (GenderID)
)

CREATE TABLE [dbo].[Groups](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[Lowercase] [char](1) NOT NULL,
	[Uppercase] [char](1) NOT NULL,
	PRIMARY KEY (GroupID)
)

CREATE TABLE [dbo].[Roles](
	[RoleID] [nvarchar](5) NOT NULL,
	[RoleName] [nvarchar](15) NOT NULL,
	PRIMARY KEY (RoleID)
)

CREATE TABLE [dbo].[UserTypes](
	[UserTypeID] [nvarchar](5) NOT NULL,
	[UserTypeName] [nvarchar](15) NOT NULL,
	PRIMARY KEY(UserTypeID)
)

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[GroupID] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Avatar] [nvarchar](max) NOT NULL,
	[UserTypeID] [nvarchar](5) NOT NULL,
	[GenderID] [nvarchar](5) NOT NULL,
	[AuthenticationTypeID] [nvarchar](5) NOT NULL,
	PRIMARY KEY (UserID),
	FOREIGN KEY (GroupID) REFERENCES Groups(GroupID),
	FOREIGN KEY (UserTypeID) REFERENCES UserTypes(UserTypeID),
	FOREIGN KEY (GenderID) REFERENCES Genders(GenderID),
	FOREIGN KEY (AuthenticationTypeID) REFERENCES AuthenticationTypes(AuthenticationTypeID)
)


CREATE TABLE [dbo].[Projects](
	[ProjectID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[OwnerUser] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	PRIMARY KEY (ProjectID),
	FOREIGN KEY (OwnerUser) REFERENCES Users(UserID)
)

CREATE TABLE [dbo].[States](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](15) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[ProjectID] [int] NOT NULL,
	[NextState] int NULL,
	[StartDate] [datetime] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	PRIMARY KEY (StateID),
	FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
)

CREATE TABLE [dbo].[Tasks](
	[TaskID] [int] IDENTITY(1,1) NOT NULL,
	[TaskName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
	[StateID] [int] NOT NULL,
	[ProjectID] [int] NOT NULL,
	[Comments] [int] NULL,
	[Status] [nvarchar](10) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	PRIMARY KEY (TaskID),
	FOREIGN KEY (StateID) REFERENCES States(StateID),
	FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
)

CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](100) NOT NULL,
	[UserID] [int] NOT NULL,
	[TaskID] int NOT NULL,
	PRIMARY KEY (CommentID),
	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	FOREIGN KEY (TaskID) REFERENCES Tasks(TaskID)
)

CREATE TABLE [dbo].[JoinProjects](
	[JoinProjectID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[RoleID] [nvarchar](5),
	PRIMARY KEY (JoinProjectID),
	FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID),
	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
)

CREATE TABLE [dbo].[Contacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[User01] [int] NOT NULL,
	[User02] [int] NOT NULL,
	PRIMARY KEY (ContactID),
	FOREIGN KEY (User01) REFERENCES Users(UserID),
	FOREIGN KEY (User02) REFERENCES Users(UserID)
)

CREATE TABLE [dbo].[TaskAssignments](
	[TaskAssignmentID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[TaskID] [int] NOT NULL,
	PRIMARY KEY (TaskAssignmentID),
	FOREIGN KEY (UserID) REFERENCES Users(UserID),
	FOREIGN KEY (TaskID) REFERENCES Tasks(TaskID)
)

CREATE TABLE [dbo].[Logs](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	Time [datetime] NOT NULL,
	[TAG] [nvarchar](30) NOT NULL,
	[Method] [nvarchar](15) NOT NULL,
	[Type] [nvarchar](10) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	PRIMARY KEY (LogID),
)

CREATE TABLE [dbo].[Notifications](
	[NotificationID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Content] [nvarchar](150) NOT NULL,
	PRIMARY KEY (NotificationID),
	FOREIGN KEY (UserID) REFERENCES Users(UserID)
)

CREATE TABLE [dbo].[Messages](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[Sender] [int] NOT NULL,
	[Receiver] [int] NOT NULL,
	[Content] [nvarchar](150) NOT NULL,
	PRIMARY KEY (MessageID),
	FOREIGN KEY (Sender) REFERENCES Users(UserID),
	FOREIGN KEY (Receiver) REFERENCES Users(UserID)
)

-----------------Insert Data-----------------

--AuthenticationTypes Table
INSERT INTO AuthenticationTypes VALUES('MPM','System Account')
INSERT INTO AuthenticationTypes VALUES('FB','FaceBook')
INSERT INTO AuthenticationTypes VALUES('GM','Gmail')
INSERT INTO AuthenticationTypes VALUES('HM','Hotmail')
INSERT INTO AuthenticationTypes VALUES('YH','Yahoo')

--Genders Table
INSERT INTO Genders VALUES('M','Male')
INSERT INTO Genders VALUES('F','Female')

--Groups Table
INSERT INTO Groups VALUES('a','A')
INSERT INTO Groups VALUES('b','B')
INSERT INTO Groups VALUES('c','C')
INSERT INTO Groups VALUES('d','D')
INSERT INTO Groups VALUES('e','E')
INSERT INTO Groups VALUES('f','F')
INSERT INTO Groups VALUES('g','G')
INSERT INTO Groups VALUES('h','H')
INSERT INTO Groups VALUES('i','I')
INSERT INTO Groups VALUES('j','J')
INSERT INTO Groups VALUES('k','K')
INSERT INTO Groups VALUES('l','L')
INSERT INTO Groups VALUES('m','M')
INSERT INTO Groups VALUES('n','N')
INSERT INTO Groups VALUES('o','O')
INSERT INTO Groups VALUES('p','P')
INSERT INTO Groups VALUES('q','Q')
INSERT INTO Groups VALUES('r','R')
INSERT INTO Groups VALUES('s','S')
INSERT INTO Groups VALUES('t','T')
INSERT INTO Groups VALUES('u','U')
INSERT INTO Groups VALUES('v','V')
INSERT INTO Groups VALUES('w','W')
INSERT INTO Groups VALUES('x','X')
INSERT INTO Groups VALUES('y','Y')
INSERT INTO Groups VALUES('z','Z')
INSERT INTO Groups VALUES('','')

--Notifications Table

--Roles Table
INSERT INTO Roles VALUES('BA','Business Admin')
INSERT INTO Roles VALUES('PM','Project Manager')
INSERT INTO Roles VALUES('ME','Project Member')

--UserTypes Table
INSERT INTO UserTypes VALUES('FU','Free User')
INSERT INTO UserTypes VALUES('PU', 'Premium User')

-----------------SQL Views-----------------
-----------------SQL Procedures-----------------

