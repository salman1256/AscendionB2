create database OurDb
use OurDb
--create table <tableName>
--(ColumnName DataType [Constraint],
 --ColumnName DataType [Constraint],
 -----)
 create table Emps
 (Eid int primary key,
 Fname nvarchar(50) not null,
 Lname nvarchar(50),
 Salary float,
 Doj date)

 select * from Emps
 --insert into <tableName> values (........)
 --insert into <tableName>(Column1, Column2...) values (.....)
 insert into Emps values(1,'Sam','Dicosta',99000.45,'12/02/2021')
  insert into Emps(Eid,Fname,Lname,Salary) values(2,'Sam','Dicosta',99000.45)
   insert into Emps values(3,'Ruhee','Nazeer',56000.45,'01/24/2024')
   select * from Emps
    insert into Emps values(1,'Deep','Das',67000.45,'03/24/2021')
	--Violation of PRIMARY KEY constraint 'PK__Emps__C1971B53442012BC'. Cannot insert duplicate key in object 'dbo.Emps'. The duplicate key value is (1).
	insert into Emps(Eid,Lname,Salary) values(8,'Gupta',99000.45)
	--Cannot insert the value NULL into column 'Fname', table 'OurDb.dbo.Emps'; column does not allow nulls. INSERT fails.
--not null
--primary key
--unique
--check
--identity
--default
-----------------------------------------------------------------
create table Customers
(Id int identity(1000,5) primary key,
Fname nvarchar(50),
Lname nvarchar(50) not null,
Email nvarchar(100) unique not null,
Mobile bigint unique not null check
(Mobile like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
City nvarchar(50) default 'Delhi',
Salary float  not null check (Salary >=10000 and Salary<=150000),
Company nvarchar(50) check (Company in ('Panamoure','CoforgeTech','SOTI','CTS'))
)

insert into Customers values ('Sam','John','sam_j@gmail.com','9876543210','Mumbai',90000,'CTS')
insert into Customers values ('Ravi','Dixit','rd@gmail.com','8976543290','Mumbai',90000,'CTS')
select * from Customers
insert into Customers values ('Neha','Garg','neha@gmail.com','9996543290','Pune',90000,'SOTI')
truncate table Customers
select * from Customers
insert into Customers values ('Neha','Garg','neha@gmail.com','9996543290','Pune',90000,'Ascendion')
delete from Customers

create table Stud_Reg
(Roll int primary key,
Fname nvarchar(50),
Lname nvarchar(50),
Age int not null)


Create table Stud_Fee
 (Roll int not null foreign key references Stud_Reg(Roll),
 FMonth int not null,
 FYear int not null,
 FAmount float not null,
 constraint Fee_PK primary key(Roll,FMonth,FYear)
 )

 insert into Stud_Reg values(1,'Sam','Dicosta',10)
 insert into Stud_Reg values(5,'Naina','Mitra',6)
 insert into Stud_Reg values(7,'Disha','Verma',9)
 insert into Stud_Reg values(8,'Shruti','Sharma',8)
 select * from Stud_Reg
 insert into Stud_Fee values (5,2,2023,8000)
  insert into Stud_Fee values (5,2,2024,8000)