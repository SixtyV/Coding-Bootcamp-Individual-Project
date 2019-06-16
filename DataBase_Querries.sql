

--DELETE DATABASE & TABLES
DROP DATABASE UserServer
DROP TABLE Users
DROP TABLE UserMessages



--CREATE DATABASE
CREATE DATABASE UserServer


--CREATE DATABASE TABLES
CREATE TABLE Users 
(
  Id INT NOT NULL PRIMARY KEY,
  UserName NVARCHAR(16) NOT NULL,
  UserPassword NVARCHAR(16) NOT NULL,
  UserRights NVARCHAR(30) NOT NULL,
  AccountDeleted BIT NOT NULL,
  LastSignIn NVARCHAR(30) NOT NULL,
  DateSignedUp NVARCHAR(30) NOT NULL,
  TimeSignedUp  NVARCHAR(30)NOT NULL

)


CREATE TABLE UserMessages
(
  Id INT NOT NULL PRIMARY KEY,
  SenderID NVARCHAR(30) NOT NULL,
  SenderName NVARCHAR(30) NOT NULL,
  ReceiverID NVARCHAR(30) NOT NULL,
  ReceiverName NVARCHAR(30) NOT NULL,
  DateOfSubmission NVARCHAR(30) NOT NULL,
  MessageData NVARCHAR(250) NOT NULL,
  MessageDeleted BIT NOT NULL,
)


--INSERT DATA INTO TABLES
INSERT INTO Users (ID, UserName, UserPassword, UserRights, AccountDeleted, LastSignIn, DateSignedUp, TimeSignedUp)
  VALUES (1, 'Thomas', '123456', 1, 0, 'Not Signed In', '2017-08-03', '10:29:01'),
		 (2, 'Batman', '123456', 2, 0, 'Not Signed In', '2017-08-03', '10:29:01'),
		 (3, 'Superman', '123456', 3, 0, 'Not Signed In', '2017-08-03', '10:29:01'),
		 (4, 'admin', 'admin', 4, 0, 'Not Signed In', '2018-07-03', '21:09:20'),
		 (5, 'Troll', '123456', 1, 1, 'Not Signed In', '2018-07-03', '21:09:20')




SELECT * FROM Users
SELECT * FROM userMessages
 
