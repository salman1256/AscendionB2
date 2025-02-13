create database Day2Db
drop database Day2Db
drop database SecondDb
CREATE DATABASE Day2Db
ON PRIMARY
( NAME ='Day2Db', FILENAME = 'D:\Ascendion-B2\Day-2\Day2Db.mdf')
LOG ON
( NAME ='Day2Db_log', FILENAME = 'D:\Ascendion-B2\Day-2\Day2Db_log.ldf')

CREATE DATABASE SecondDb
ON PRIMARY
( NAME ='SecondDb', FILENAME = 'D:\Ascendion-B2\Day-2\SecondDb.mdf', 
Size=16MB, MaxSize=32MB)
LOG ON
( NAME ='SecondDb_log', FILENAME = 'D:\Ascendion-B2\Day-2\SecondDb_log.ldf',
Size=8MB, MaxSize=12MB)
use Day2Db
create table SalaryCalc
(Grade varchar(1) primary key,
 BasicSalary float,
 HRA as BasicSalary*0.1 persisted,
 DA as BasicSalary*0.2 persisted,
 TA as BasicSalary *0.15 persisted
 )
 insert into SalaryCalc
 values ('A',60000)
 select * from SalaryCalc
  insert into SalaryCalc
 values ('B',40000)
  insert into SalaryCalc
 values ('C',30000)
  insert into SalaryCalc
 values ('D',15000)
 select * from SalaryCalc
 update SalaryCalc set BasicSalary=70000 where Grade='A'
 update SalaryCalc set HRA=20000 where Grade='A'
 --The column "HRA" cannot be modified because it is a computed column 
 --order by, group by
 --functions 
 --Built in , User defined function
 --Agg...sum,avg,max,min
 -- upper,lower,ltrim,rtrim,left, right
 --date:getdate,datepart,datediff...
 -- cast,convert...
 
 create table Emp
 (Id int primary key,
  Fname nvarchar(50) not null, 
  Lname nvarchar(50),
  Salary decimal(10,2) not null,
  DOJ date not null)
  truncate table Emp
  insert into Emp values (2,'Deep','Das',99000.30,'02/26/2022'),
 (3,'Vini','Verma',86000.90,'11/10/2023'),
 (5,'Neha','Niraj',66000.90,'07/12/2020'),
 (7,'Vikas','Dhingra',55000.90,'02/24/2021'),
 (9,'Vihan','K.',85000.90,'08/21/2020'),
 (10,'Garima','Garg',76000.50,'07/12/2019'),
 (8,'Aman','Mangal',66000.50,'06/08/2021')
 select * from Emp
 select avg(Salary)  'Average Salary' from Emp
  select max(Salary) as  'Maximum Salary' from Emp
    select min(Salary) as  'Minimum Salary' from Emp
	  select sum(Salary) as  'Total of Salary' from Emp
	  select UPPER('  India  ') as 'Upper'
	   select lower('  India  ') as 'Lower'
	    select ltrim('  India  ') as 'Ltrim'
		 select rtrim('  India  ') as 'Rtrim'
		  select trim('  India  ') as 'Trim'

		  select upper(fname) +' '+ upper(lname)  'Full Name' from Emp
		   select lower(fname) +' '+ lower(lname)  'Full Name' from Emp
	select fname,lname, left (fname,1) +' . '+LEFT(lname,1) +' .' as 'Initial' from Emp
	select getdate() 'Current Date'
	select DATEPART(YEAR,GETDATE()) 'Current Year'
	select DATEPART(MONTH,GETDATE()) 'Current Month'
	select DATEPART(DAY,GETDATE()) 'Current Day'
	select DATEPART(DAYOFYEAR,GETDATE()) 'Current Dayof Year'
	select DATEPART(WEEKDAY,GETDATE()) 'Current WeekDay'
	select DATEPART(WEEK,GETDATE()) 'Current Week'
	select DATEDIFF(Year,'12/12/2023','12/12/2026') 'Diff in Year'
	select Fname,Lname,DOJ,datediff(Year,DOJ,getdate()) as 'Year of Exp in Company' from Emp
	select Fname +'->'+Lname  from Emp

	select Fname +'->'+Lname+'->'+convert (nvarchar(50),Salary)  from Emp
	--------------------------------------------------------------------
	---index
	create table Customer
	(Id int,
	Fname nvarchar(50) not null,
	Lname nvarchar(50) not null,
	ODLimit float )
	insert into Customer values (1,'Sam','Dicosta',980000.50)
	insert into Customer values (5,'Rohit','Vemula',650000.30)
	insert into Customer values (3,'Vini','Guha',450000.20)
	insert into Customer values (8,'Gagan','Mir',650000.20)
	insert into Customer values (2,'Deepak','Mihir',750000.20)
	select * from Customer
	select * from Customer where Id=3
	select count(Id) from Customer
	--CREATE typeofIndex INDEX indexName  
   -- ON <tableName>(column);  

	create clustered index cust_index on Customer (Id) 
	
	create nonclustered index cust_NameIndex on Customer (Fname) 
	create  index cust_LnIndex on Customer (Lname) 

	select * from Customer where Fname='Sam'

	

		

	   
