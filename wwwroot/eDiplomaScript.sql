DELETE FROM IF EXISTS ContactsInfos;
DELETE FROM IF EXISTS Courses;
DELETE FROM IF EXISTS Diplomas;
DELETE FROM IF EXISTS Schools;
DELETE FROM IF EXISTS Users;

INSERT INTO Users(Id, Username, Password, Email, Age, PhoneNumber, CreatedDate, FirstName, LastName)
VALUES
('1','IsarD00','placeholder1','isardadi0@gmail.com','21','615-2358','08/22/2020','Ísar Daði','Pálsson'),
('2','EvaB00','placeholder2','evabjorg0@gmail.com','28','9090334','07/24/2020','Eva Björg','Hilmarsdóttir'),
('3','StebbiK00','placeholder3','stefankari@gmail.com','16','6547453','09/22/2021','Stefán Kári','Albertsson');

INSERT INTO Schools(Id, Name, Location, ContactInfo)
VALUES
('1','Háskólinn í Reykjavík','Reykjavík', '1'),
('2','Háskóli Íslands','Ísland','2'),
('3','University of Harvard','Ameríka','3')

INSERT INTO ContactsInfos(Id, Email, PhoneNumber)
VALUES
('1',"td@ru.is",'6765465'),
('2','rd@hi.is','090-2344'),
('3','csd@hrvd.com','123-4567');

INSERT INTO Diplomas(Id, Degree, Units, DateStarted, DateEnded, Grade, Other, UserId, SchoolId)
VALUES
('1','BS.C','186','18/06/2020','16/05/2023','9.23','Deans List x1','1','1'),
('2','MS.C','186','18/06/2021','','9.67','','2','2'),
('3','PH.D','130','18/06/2019','16/05/2022','8.52','','3','3');

INSERT INTO Courses(Id, Grade, Teacher, CourseStarted, CourseEnded, DiplomaId)
VALUES
('1','9.5','Kári K','08/08/2020','12/11/2020','1'),
('2','10.0','Arnar L','08/08/2020','12/11/2020','1'),
('3','9.0','Arnar L','10/01/2021','06/05/2020','1'),
('4','8.5','Alexandre N','10/01/2019','06/05/2019','2'),
('5','7.5','Hans P','08/08/2021','12/11/2021','2'),
('6','9.0','Taarmo U','10/01/2029','06/05/2020','3');