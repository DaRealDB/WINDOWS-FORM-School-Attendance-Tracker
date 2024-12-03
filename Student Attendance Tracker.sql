Create Database Student_Attendance_TrackerSystem;

Create Table User_table6
(
	USER_ID INT IDENTITY (1,1),
	User_name Varchar(150) UNIQUE,
	User_Pass Varchar(150),
	User_Pho Varchar(15),
	User_CNIC Varchar(15) UNIQUE,
	User_DOB Varchar(10),
	User_Gender Varchar(6),
	User_email Varchar(30),
	User_Role Varchar(5),
	User_Add Varchar(150),
	Constraint User_Table_PKmain5 PRIMARY KEY (USER_ID)

);

INSERT INTO User_table6 VALUES
	('user', '12345', '+63 927 5329149', '22-1952-149', '02/20/2004', 'male', 'USER.LAST@cit.edu', 'admin', 'Philippines'),
	('user1',  '12345678', '+63 927 5329449', '18-1932-159', '02/20/2003', 'female', 'USER.FIRST@cit.edu', 'User', 'CEBU');