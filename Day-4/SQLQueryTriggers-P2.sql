create database Day60Db
use Day60Db
select * from Emps
truncate table Emps
create table Emps
(
Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50),
Salary float,
Designation nvarchar(50),
DOJ date
)
create table Emps_LogInfo
(LogId int primary key identity,
Id int,
Fname nvarchar(50),
Lname nvarchar(50),
Salary float,
Designation nvarchar(50),
DOJ date,
Log_Action nvarchar(100),
Action_Time date)

select * from Emps
select * from Emps_LogInfo
--syntax to create DML trigger
--CREATE TRIGGER [schema_name.] trigger_name
--ON [schema_name.] table_name [WITH ENCRYPTION]
--{FOR INSERT} AS
--[IF UPDATE (column_name)...]
--[{AND | OR} UPDATE (column_name)...]
--<sql_statements>

--insert
create trigger trgAInsert
on Emps
After insert
as
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @sal nvarchar(50)
declare @desg nvarchar(50)
declare @doj date
declare @action nvarchar(100)
select @id=Id,@fn=Fname,@ln=Lname,@sal=Salary,@desg=Designation,@doj=DOJ from inserted
select @action='AfterInsert: Record Inserted'
insert into Emps_LogInfo(Id,Fname,Lname,Salary,Designation,DOJ,Log_Action,Action_Time)
values
(@id,@fn,@ln,@sal,@desg,@doj,@action,getdate())

print 'After Trigger Says: Record Inserted & Your action has captured in Log_InfoTable'
---before
create trigger trgFInsert
on Emps
for insert
as
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @sal nvarchar(50)
declare @desg nvarchar(50)
declare @doj date
declare @action nvarchar(100)
select @id=Id,@fn=Fname,@ln=Lname,@sal=Salary,@desg=Designation,@doj=DOJ from inserted
select @action='For: Record Inserted'
insert into Emps_LogInfo(Id,Fname,Lname,Salary,Designation,DOJ,Log_Action,Action_Time)
values
(@id,@fn,@ln,@sal,@desg,@doj,@action,getdate())

print 'For Trigger Says: Record Inserted & Your action has captured in Log_InfoTable'




select * from Emps
select * from Emps_LogInfo

insert into Emps values (11,'Anuj','Rawat',10000.54,'Tester','03/12/2020')
insert into Emps values (15,'Ruhi','N.',60000.54,'Developer','03/23/2022')



----------------------------------------------------------------
update Emps set Fname='Sandeep' where Id=109
delete from Emps where Id=1
---------------------------------------------------------------
---instead of trigger
create trigger trgInsDel
on Emps
Instead of delete
as
declare @id int
declare @fn nvarchar(50)
declare @ln nvarchar(50)
declare @sal float
declare @desg nvarchar(50)
declare @doj date
declare @action nvarchar(100)
select @id=Id, @fn=Fname,@ln=Lname,@sal=Salary,@desg=Designation,@doj=DOJ from deleted;
if(@sal>=50000)
begin
raiserror('You can not delete this record',16,1)
end
else
begin
delete from Emps where Id=@id
select @action='Instead of Trigger :Record Deleted'
insert into Emps_LogInfo(Id,Fname,Lname,Salary,Designation,DOJ,Log_Action,Action_Time)
values(@id,@fn,@ln,@sal,@desg,@doj,@action,getdate())
if(@@ROWCOUNT=1)
print 'Instead of Trigger Says: Record Deleted & Your action has captured in Log_InfoTable'
end


delete from Emps where Id=15
select * from Emps

delete from Emps where Id=11