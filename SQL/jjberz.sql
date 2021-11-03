Create table Customers (
	ClientID INT Primary Key Auto_Increment,
ClientType int,
FirstName VarChar(20) Not Null,
LastName VarChar(20) Not Null,
PhoneNum Int,
Email VarChar (30) Not Null
);

Drop Table Customers;


Insert Into Customers (FirstName, LastName, PhoneNum, Email, ClientType)
Values ('Janis', 'Berzins', 29293982, 'jjberzins@gmail.com', 1),
		('Juris', 'Berzins', 29293982, 'jjberzins@gmail.com', 2),
        ('Janchuks', 'Berzins', 29293982, 'jjberzins@gmail.com', 2),
        ('Jecis', 'Bierzins', 29293982, 'jjbierzins@gmail.com', 1),
        ('Jekabs', 'Bierins', 29293982, 'jjbierins@gmail.com', 3);
        
Select * From Customers;

Select Customers
Where ClientType = 2;