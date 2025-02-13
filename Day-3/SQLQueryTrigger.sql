use Day3Db
exec sp_tables
--trigger
--1. DML
--a: after or For:after  insert , after update ,after delete
--b:instead of insert, instead of delete, instead of update
--I) inserted: insert,update
-- II) deleted: delete
-----------------------------------------------
--Syntax
--CREATE TRIGGER [schema_name.] trigger_name
--ON [schema_name.] table_name 
--[WITH ENCRYPTION]
--{FOR|after|instead of ACTION(e.g. Insert,Update, Delete)} 
--AS
--<sql_statements>

---------------------------------------------------------
create table Customer
(Id int primary key,
Fname nvarchar(50) not null,
Lname nvarchar(50) not null,
SPlan float not null,
SDate date not null,
SEDate date not null
)
create table Customer_Log
(LogId int primary key identity,
Id int ,
Fname nvarchar(50),
Lname nvarchar(50),
SPlan float ,
SDate date ,
SEDate date,
ActionTaken nvarchar(100),
ActionTime datetime default getdate()
)
select * from Customer
select * from Customer_Log

create trigger trgAfterCustInsert
on
Customer
after insert 
as
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @plan float
declare @sdate date
declare @edate date
select @id=Id,@fn=Fname,@ln=Lname,@plan=SPlan,@sdate=SDate,@edate=SEDate from inserted
insert into Customer_Log(Id,Fname,Lname,SPlan,SDate,SEDate,ActionTaken)
values (@id,@fn,@ln,@plan,@sdate,@edate,'Record Inserted')
print 'Record Inserted and Action Captured in Customer_Log'

insert into Customer values (1,'Sam','Dicosta',950.50,'02/03/2024','03/10/2024')
insert into Customer values 

(12,'Sen','Riya',950.50,'11/25/2024','12/25/2024')



