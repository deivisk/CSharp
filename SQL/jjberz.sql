Create table Customers (
	ClientID INT Primary Key Auto_Increment,
ClientType int,
FirstName VarChar(20) Not Null,
LastName VarChar(20) Not Null,
PhoneNum Int,
Email VarChar (30) Not Null
);

Create Table Employees (
	EmployeeID  INT Primary Key Auto_Increment,
EmployeeName VarChar(20) not null,
EmployeeLName VarChar(20) not null,
EmployeeEmail VarChar(30) not Null
);

Create Table Departments (
	DepartmentID INT Primary Key Auto_Increment,
DepHR VarChar(20) not null,
DepAccounting VarChar(20) not null,
DepSales VarChar (20) not null
);

Drop Table Employees;


Insert Into Customers (FirstName, LastName, PhoneNum, Email, ClientType)
Values ('Janis', 'Berzins', 29293982, 'jjberzins@gmail.com', 1),
		('Juris', 'Berzins', 29293982, 'jjberzins@gmail.com', 2),
        ('Janchuks', 'Berzins', 29293982, 'jjberzins@gmail.com', 2),
        ('Jecis', 'Bierzins', 29293982, 'jjbierzins@gmail.com', 1),
        ('Jekabs', 'Bierins', 29293982, 'jjbierins@gmail.com', 3);
        
        
Insert Into Employees (EmployeeName, EmployeeLName, EmployeeEmail)
Values ('Davis', 'Kalnins', 'davis.kal@outlook.com'),
		('Peteris', 'Tapete', 'PTapete@outlook.com'),
        ('Laura', 'Tapete', 'asdq@asd.com'),
        ('Marta', 'Panna', 'asdq@jaa.com'),
        ('Endija', 'Eglīte', 'EEglite@gmail.com'),
        ('Dwight', 'Schrute', 'Dshrute@office.com'),
        ('Jim', 'Halpert', 'JHalper@office.com'),
        ('Michael', 'Scott', 'MScott@office.com');
        
ALTER TABLE Customers
 ADD COLUMN EmployeeID INT;

 ALTER TABLE Customers
 ADD FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID);
 
 ALTER TABLE Employees
 ADD COLUMN DepartmentID INT;
 
  ALTER TABLE Employees
 ADD FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID);
 
 SELECT Customers.FirstName, Customers.LastName, Employees.EmployeeName, Employees.EmployeeLName
FROM Customers, Employees
WHERE Customers.EmployeeID = Employees.EmployeeID;

 SELECT Customers.FirstName, Customers.LastName, Employees.EmployeeName, Employees.EmployeeLName
FROM Employees, Departments
WHERE Employees.DepartmentID = Departments.DepartmentID;

delete from Employees
Where EmployeeID = 1;

Select * From Customers;

Select * From Employees;

Select Customers
Where ClientType = 2;