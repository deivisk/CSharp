Create Table Clients(
	ClientID int Auto_Increment primary key,
ClientName VarChar(20) not Null,
ClientLName VarChar(20) not Null,
ClientNum VarChar(10) not Null,
ClientMail VarChar(30) not Null
);

Create Table Employees(
	EmployeeID int Auto_Increment primary key,
EmployeeName VarChar(20) not Null,
EmployeeLName VarChar(20) not Null,
EmployeeMail VarChar(30) not Null
);

Create Table EmployeesClients(
	ClientID int not Null,
    EmployeeID int not Null,
Foreign Key (ClientID) References Clients(ClientID),
Foreign Key (EmployeeID) References Employees(EmployeeID)
);

Insert Into Clients(ClientName, ClientLName, ClientNum, ClientMail)
Values
	('PirName', 'PirLName', 'Pir232', 'PirMail'),
    ('OtrName', 'OtrLName', 'Otr123', 'OtrMail'),
	('TreName', 'TreLName', 'Tre232', 'TreMail'),
    ('CetName', 'CetLName', 'Cet123', 'CetMail'),
	('PieName', 'PieLName', 'Pie232', 'PieMail'),
    ('SesName', 'SesLName', 'Ses123', 'SesMail');
    
Select * From Clients;

Insert Into Employees(EmployeeName, EmployeeLName, EmployeeMail)
Values
	('Emp1Name', 'Emp1LName', 'Emp1Mail'),
    ('Emp2Name', 'Emp2LName', 'Emp2Mail');
    
Select * From Employees;

Insert Into EmployeesClients(EmployeeID, ClientID)
Values
	(1,1),
    (1,2),
    (2,3),
    (2,4),
    (1,5),
    (2,5),
    (1,6),
    (2,6);
    
    Drop Table EmployeesClients;
    
Select * From EmployeesClients;

SELECT Employees.EmployeeName, Employees.EmployeeLName, Clients.ClientName, Clients.ClientLName
FROM Employees
INNER JOIN EmployeesClients
ON Employees.EmployeeID = EmployeesClients.EmployeeID
INNER JOIN Clients
ON Clients.ClientID = EmployeesClients.ClientID;