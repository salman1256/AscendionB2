drop database Day2Db

create database Day2Db
use Day2Db
create table Cust(Id int primary key, Fname nvarchar(50))
select * from dbo.Cust
create schema mySchema
create table Cust(Id int primary key, Fname nvarchar(50),Lname nvarchar(50))
create table mySchema.Cust(Id int primary key, Fname nvarchar(50),Lname nvarchar(50))
CREATE TYPE nametype FROM nvarchar(50) NOT NULL

create table Customer
(Id  int primary key,
 Fname nametype,
 Lname nametype,
 ODLimit float)
 insert into Customer values (1,'Arsh','Maan',550000.50)
 insert into Customer (Id,Lname) values (2,'Singh')
 create table mySchema.Customer
(Id  int primary key,
 Fname nametype,
 Lname nametype,
 ODLimit float,
 SSDate date)

 insert into mySchema.Customer values (1,'Arsh','Maan',550000.50,'12/12/2023')
 --------------------------------------------------------------------
 --join
 --Syntax
-- SELECT <ColumnName1>, <ColumnName2>...<ColumnNameN> FROM
--Table_A AS Table_Alias_A INNER JOIN
--Table_B AS Table_Alias_B ON
--Table_Alias_A.<CommonColumn> = Table_Alias_B.<CommonColumn>
create table Dept
(DId int primary key,
 DName nvarchar(50) not null unique)
 insert into Dept values (1,'App-Development')
 insert into Dept values (2,'Web-Development')
 insert into Dept values (3,'Agile-Scrum')
 insert into Dept values (4,'It')
 insert into Dept values (5,'HR')
insert into Dept values (6,'Account')
select * from Dept order by DId
create table Emps
(Id int primary key,
Fname nvarchar(50) not null,
Lname nvarchar(50) not null,
Designation nvarchar(50),
Salary float,
Department int 
)
insert into Emps values (1,'Suresh','Kumar','Developer',65000.50,2)
insert into Emps(Id,Fname,Lname,Salary) values (2,'Raj','Kiran',54000.50)
insert into Emps values (5,'Anuj','Rawat','Developer',65000.50,2)
insert into Emps values (6,'Vini','Kumari','Admin',65000.50,4)
insert into Emps values (7,'Deep','Das','Accountant',65000.50,6)
insert into Emps(Id,Fname,Lname,Salary) values (10,'Deep','Das',55000.50)
insert into Emps values (11,'Aditi','Verma','Designer',75000.50,2)
select * from Emps
select count(Id) from Emps
select count(DId) from Dept

select * from Emps join Dept on Emps.Department=Dept.DId

select * from Emps e join Dept d on e.Department=d.DId
select * from Emps e inner join Dept d on e.Department=d.DId

select e.Id,e.Fname,e.Lname, e.Designation,d.DId 'Department Id',d.DName 'Department Name'
from Emps e inner join Dept d on e.Department=d.DId

insert into Emps values (12,'Neeraj','Gaur','Developer',65000.50,1)
insert into Emps values (4,'Namita','Bansal','Developer',65000.50,1)
--inner join gives you mataching records 
select e.Id,e.Fname,e.Lname, e.Designation,d.DId 'Department Id',d.DName 'Department Name'
from Emps e inner join Dept d on e.Department=d.DId

--outer
--left outer join
select e.Id,e.Fname,e.Lname, e.Designation,d.DId 'Department Id',d.DName 'Department Name'
from Emps e left outer join Dept d on e.Department=d.DId

--right outer join
select e.Id,e.Fname,e.Lname, e.Designation,d.DId 'Department Id',d.DName 'Department Name'
from Emps e right outer join Dept d on e.Department=d.DId

--full outer join
select e.Id,e.Fname,e.Lname, e.Designation,d.DId 'Department Id',d.DName 'Department Name'
from Emps e full outer join Dept d on e.Department=d.DId

--------------------------------------------------------------------------------------------------
--self Join
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName NVARCHAR(100),
    ManagerID INT
)

INSERT INTO Employees (EmployeeID, EmployeeName, ManagerID)
VALUES 
(1, 'Sam', NULL),      
(2, 'Raj', 1),        
(3, 'Rohan', 1),    
(4, 'Vikas', 2),        
(5, 'Dev', 2),    
(6, 'Rishi', 3)     


SELECT 
    e.EmployeeName Employee,
    m.EmployeeName  Manager
FROM 
    Employees e
LEFT  JOIN 
    Employees m ON e.ManagerID = m.EmployeeID
	-------------------------------------------
	--cross join
	create table Colors
	(CId int primary Key,
	Color nvarchar(50) not null unique)

	insert into Colors values (1,'Red'),(2,'Blue'),(3,'Brown'),(4,'Green')
	select * from Colors order by CId
	select count (CId) 'No of Rows in Colors' from Colors

	create table Sizes
	(Id int primary Key,
	Size nvarchar(50) not null unique)

	insert into Sizes values (1,'Small'),(2,'Medium'),(3,'Large')
	select * from Sizes order by Id
	select count (Id) 'No of Rows in Sizes' from Sizes
	select Color,Size from Colors cross join Sizes order by Color
	-----------
	insert into Colors values (5,'Pink')
	select count (CId) 'No of Rows in Colors' from Colors
	select count (Id) 'No of Rows in Sizes' from Sizes
	select Color,Size from Colors cross join Sizes order by Color

	insert into Sizes values (4,'Extra Large')

	select count (CId) 'No of Rows in Colors' from Colors
	select count (Id) 'No of Rows in Sizes' from Sizes
	select Color,Size from Colors cross join Sizes order by Color