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

CREATE TABLE [dbo].[States](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](15) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[ProjectID] [int] NOT NULL,
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
	[Layer] [nvarchar](30) NOT NULL,
	[Actor] [nvarchar](15) NOT NULL,
	[Method] [nvarchar](15) NOT NULL,
	[Type] [nvarchar](10) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	PRIMARY KEY (LogID),
)

CREATE TABLE [dbo].[Notifications](
	[NotificationID] [nvarchar](5) NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
	PRIMARY KEY (NotificationID)
)

CREATE TABLE [dbo].[OfflineNotifications](
	[OfflineNotificationID] [int] IDENTITY(1,1) NOT NULL,
	[NotificationID] [nvarchar](5) NOT NULL,
	[UserID] [int] NOT NULL,
	PRIMARY KEY (OfflineNotificationID),
	FOREIGN KEY (NotificationID) REFERENCES Notifications(NotificationID),
	FOREIGN KEY (UserID) REFERENCES Users(UserID)
)

CREATE TABLE [dbo].[OfflineMessages](
	[OfflineMessageID] [int] IDENTITY(1,1) NOT NULL,
	[Sender] [int] NOT NULL,
	[Receiver] [int] NOT NULL,
	[Content] [nvarchar](150) NOT NULL,
	PRIMARY KEY (OfflineMessageID),
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

--Notifications Table

--Roles Table
INSERT INTO Roles VALUES('ME','Project Member')
INSERT INTO Roles VALUES('PM','Project Manager')

--UserTypes Table
INSERT INTO UserTypes VALUES('CU','Consumer')
INSERT INTO UserTypes VALUES('BA', 'Business Admin')

-----------------SQL Views-----------------
CREATE VIEW vi_commentbyTask AS
SELECT A.Content, B.Name, C.TaskName  FROM Comments AS A, Tasks AS B, Users AS C
WHERE A.UserID = C.UserID AND A.TaskID = B.TaskID
-----------------SQL Procedures-----------------

