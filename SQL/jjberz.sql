Create table Customers (
	ClientType INT Primary Key Auto_Increment,
FirstName VarChar(20) Not Null,
LastName VarChar(20) Not Null,
PhoneNum Int,
Email VarChar (30) Not Null
);

Insert Into Customers (ClientType, FirstName, LastName, PhoneNum, Email)
Values (1, 'Janis', 'Berzins', 29293982, 'jjberzins@gmail.com'),
		(2, 'Juris', 'Berzins', 29293982, 'jjberzins@gmail.com'),
        ('Janchuks', 'Berzins', 29293982, 'jjberzins@gmail.com'),
        ('Jecis', 'Bierzins', 29293982, 'jjbierzins@gmail.com'),
        ('Jekabs', 'Bierins', 29293982, 'jjbierins@gmail.com');
        
Select * From Customers;

Select Customers
Where ClientType = 2;