create database Day4Db
use Day4Db
create table Student 
(SId int  primary key, 
SName nvarchar(50) not null, 
SEmail nvarchar(100),
SContact nvarchar(10) not null unique check (SContact 
like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
create table Fee 
(SId int  not null foreign key references Student(SId), 
 SFee float not null,
 SMonth int not null,
 SYear int not null,
 constraint fee_pk primary key (SId,SMonth,SYear)
)
insert into Student values (1,'Sam','sam@yahoo.com','9876543210')
insert into Student values (2,'arsh','arsh_neveronlin@gmail.com','9876543234')
insert into Student values (3,'deep','deep_pp@yahoo.com','9876543289')
insert into Fee values (1,70000,2,2024)
insert into Fee values (1,70000,3,2024)
insert into Fee values (1,79000,3,2025)
insert into Fee values (2,79000,2,2025)

select * from Student 
select * from Fee
delete from Student where SId= 2
update Student set SName='New Name' where SId=2
update Student set SId=12 where SName='New Name'
----------------------------------------------------------
drop database Day4Db
create database Day4Db
use Day4Db
create table Student 
(SId int  primary key, 
SName nvarchar(50) not null, 
SEmail nvarchar(100),
SContact nvarchar(10) not null unique check (SContact 
like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
create table Fee 
(SId int  not null foreign key references Student(SId) on delete cascade on update cascade, 
 SFee float not null,
 SMonth int not null,
 SYear int not null,
 constraint fee_pk primary key (SId,SMonth,SYear)
)
insert into Student values (1,'Sam','sam@yahoo.com','9876543210')
insert into Student values (2,'arsh','arsh_neveronlin@gmail.com','9876543234')
insert into Student values (3,'deep','deep_pp@yahoo.com','9876543289')
insert into Fee values (1,70000,2,2024)
insert into Fee values (1,70000,3,2024)
insert into Fee values (1,79000,3,2025)
insert into Fee values (2,79000,2,2025)
insert into Fee values (2,79000,1,2025)

select * from Student 
select * from Fee
delete from Student where SId= 2
update Student set SName='New Name' where SId=2
update Student set SId=16 where SName='Sam'
delete from Student where SId= 16
select * from Student 
select * from Fee

---Exercise Solution
create table Student 
(SId int  primary key, 
SName nvarchar(50) not null, 
SEmail nvarchar(100),
SContact nvarchar(10) not null unique check (SContact 
like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
create table Fee 
(SId int  not null foreign key references Student(SId) on delete cascade on update cascade, 
 SFee float not null,
 SMonth int not null,
 SYear int not null,
 constraint fee_pk primary key (SId,SMonth,SYear)
)
insert into Student values (1,'Sam','sam@yahoo.com','9876543210')
insert into Student values (2,'arsh','arsh_neveronlin@gmail.com','9876543234')
insert into Student values (3,'deep','deep_pp@yahoo.com','9876543289')

create table PayConfirmation
(SId int, 
SName nvarchar(50), 
SEmail nvarchar(100),	
Fee float,
PaidOnDate datetime
)
-------------------------------------------
create trigger trgPayConfirmation
on Fee
after insert
as
declare @id int
declare @name nvarchar(50)
declare @email nvarchar(100)
declare @fee float

select @id=SId,@fee=SFee from inserted
select @name=SName, @email=SEmail from Student where SId=@id
insert into PayConfirmation(SId,SName,SEmail,Fee,PaidOnDate)
values
(@id,@name,@email,@fee,getdate())

print 'Fee Submition Success'
--------------------------------------
insert into Fee values (1,70000,2,2024)
insert into Fee values (1,70000,3,2024)
insert into Fee values (1,79000,3,2025)
insert into Fee values (2,79000,2,2025)
insert into Fee values (2,79000,1,2025)
--------------------------------------------
select * from Fee
select * from PayConfirmation
use Day3Db
exec sp_tables
select * from Customer
select * from Customer_Log
insert into Customer values (5,'Rohit','Kumar',566,'12/12/2023','12/12/2025')
update Customer set Fname='Raj' where Id=3
delete from customer where Id=1
alter table Customer disable trigger all

insert into Customer values (5,'Rohit','Kumar',566,'01/01/2020','03/02/2021')
update Customer set Fname='Raj' where Id=5
delete from customer where Id=5

select * from Customer
select * from Customer_Log

alter table Customer enable trigger all
insert into Customer values (8,'Rohit','Kumar',566,'01/01/2020','03/02/2021')
update Customer set Fname='Raj' where Id=8
delete from customer where Id=5

drop trigger trgAfterCustDelete
---------------------------------------------------------------------
create trigger trgAll 
on Customer 
After delete,insert,update 

as  
begin
print 'Insert or update or delete'
end

update Customer set Fname='Mohan' where Id=8
delete from Customer where Id=8
use Day4Db
create table Emps
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50) not null)

alter table Emps drop column Fname 

drop table Emps
-----------------------------------------
--
----DDL Trigger
--CREATE TRIGGER <trigger_name> ON { ALL SERVER | DATABASE } 
 ---[WITH ENCRYPTION]
--{ FOR | AFTER } 
---{ <event_type> } 
---AS <sql_statement>

create  trigger trgStopDrop
on database
after Drop_Table
as
print 'You can not drop the table'
print 'To Drop delete or disable trgStopDrop'
rollback;
------------------------------------------------------------------
create table Emps
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50) not null)

drop table Emps



use Day3Db
exec sp_tables
drop table Player

create  trigger trgStopAllDDLTable
on database
after Create_Table, Alter_Table, Drop_Table
as
print 'You can not create alter or drop the table'
print 'To create,alter,or drop table first drop trgStopAllDDL'
rollback;

create table Player
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50) not null)

drop table Fee
----------------------------------------------------------------
--View -
create table Emps
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50) not null)
insert into Emps values (1,'Sam','Dicosta')
insert into Emps values (2,'Raj','Kumar')
create view Emps_View
as
select * from Emps

select * from Emps_View
insert into Emps_View values (3,'Rohit','V')

select * from Emps

delete from Emps where Id=2
delete from Emps_View where Id=3
select * from Emps
select * from Emps_View
alter table Emps drop column Lname
drop table Emps
----------------------------------
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
select * from Dept

alter view view_EmpDepts
as
select e.Id 'EmployeeId',
e.Fname +' ' +e.Lname 'FullName',
e.Designation 'EmployeeDesignation',d.DId 'DepartmentId',d.DName 'DepartmentName'
from Emps e inner join Dept d 
on e.Department=d.DId
----------------------------------------------------

select * from view_EmpDepts
------------------------------------------
select * from view_EmpDepts where DepartmentId=2
----------------------------------------------------
select * from view_EmpDepts where DepartmentName='it'
------------------------------------------------------
exec sp_helptext view_EmpDepts

alter view view_EmpDepts
with encryption
as
select e.Id 'EmployeeId',
e.Fname +' ' +e.Lname 'FullName',
e.Designation 'EmployeeDesignation',d.DId 'DepartmentId',d.DName 'DepartmentName'
from Emps e inner join Dept d 
on e.Department=d.DId

exec sp_helptext view_EmpDepts

select * from view_EmpDepts where DepartmentId=2

create table Customer 
(CId nvarchar(5)  primary key, 
CName nvarchar(50) not null, 
Email nvarchar(100) not null unique,
Contact nvarchar(10) not null unique check (Contact 
like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
insert into Customer values ('C-010','Rohit Kumar','rohit_k@gmail.com','9876543210')
insert into Customer values ('C-011','Anu Sharma','as@gmail.com','9876543289')
insert into Customer values ('C-012','Vihan Vishu','vv@gmail.com','9876543278')
select * from Customer

create view cust_view
as
select CId 'CustomerId', CName 'CustomerName',Email 'CustomerEmail' 
from Customer

select * from cust_view

alter table Customer drop column Email 
alter table Customer drop constraint UQ__Customer__A9D10534BFE3FDA8
alter table Customer drop column Email
select * from Customer
select * from cust_view
---------------------------------schema binding view-------------------------------------
create schema bank
create table bank.Customer 
(CId nvarchar(5)  primary key, 
CName nvarchar(50) not null, 
Email nvarchar(100) not null unique,
Contact nvarchar(10) not null unique check (Contact 
like'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
insert into bank.Customer values ('C-010','Rohit Kumar','rohit_k@gmail.com','9876543210')
insert into bank.Customer values ('C-011','Anu Sharma','as@gmail.com','9876543289')
insert into bank.Customer values ('C-012','Vihan Vishu','vv@gmail.com','9876543278')
select * from bank.Customer

create view bank.cust_view
with schemabinding
as
select CId 'CustomerId', CName 'CustomerName',Email 'CustomerEmail' 
from bank.Customer

select * from bank.cust_view

alter table bank.Customer drop column Email 
alter table bank.Customer drop constraint UQ__Customer__A9D10534327BD234
alter table bank.Customer drop column Email
select * from Customer
select * from cust_view