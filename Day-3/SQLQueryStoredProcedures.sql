create database Day3Db
use Day3Db
create table Player
(PId int primary key,
Pname nvarchar(50) not null,
PAvg float,
PTeam nvarchar(50) not null)
insert into Player values 
(1,'MSD',55.56,'India'),
(2,'Smriti M.',43.45,'India'),
(3,'Rashid Khan',34.56,'Afghanistan')
select * from Player
--create proc <procedureName>
--parameters
-- as
--begin                            --{
--SQl Statements
--end                                --}
create procedure usp_saPlayers
as
begin
select PId 'Player Id', Pname 'Player Name',PAvg 'Player Average', Pteam 'Player Team' from Player
end

--execute | exec <procedureName> parameters
exec usp_saPlayers

insert into Player values (4,'ABD',76.56,'South Africa')

exec usp_saPlayers

create proc usp_sPlayerById
@id int
as
begin
select * from Player where PId=@id
end

execute usp_sPlayerById @id=2
execute usp_sPlayerById 1

exec usp_sPlayerById 

alter proc usp_sPlayerById
@id int =1
as
begin
select * from Player where PId=@id
end
----
exec usp_sPlayerById 
----
exec usp_sPlayerById 3
--
exec usp_sPlayerById 11
---------------------------------
create proc usp_iPlayer
@id int,
@name nvarchar(50),
@avg float,
@team nvarchar(50)
as
begin
insert into Player(PId,Pname,PAvg,PTeam) values (@id,@name,@avg,@team)
if(@@ROWCOUNT<>0)
begin
print 'Record Inserted!!!'
end
end

exec sp_tables

exec sp_helptext usp_iPlayer
exec sp_helptext usp_sPlayerById
exec usp_iPlayer 5,'Rohit Sharma',53.01,'India'
exec usp_saPlayers
exec usp_iPlayer @id=6,@avg=34.56,@name='M.Siraj',@team='India'
----------------------------------------------------------
create proc usp_uPlayer
@id int,
@name nvarchar(50),
@avg float,
@team nvarchar(50)
as
begin
update Player set Pname=@name,PAvg=@avg,PTeam=@team where PId=@id
if(@@ROWCOUNT<>0)
begin
print 'Record Updated!!!'
end
end

exec usp_uPlayer 1,'MS Dhoni',56.75,'CSK'

exec usp_saPlayers
---------------------------------------------------------
create proc usp_delPlayer
@id int

as
begin
delete from Player where PId=@id
if(@@ROWCOUNT<>0)
begin
print 'Record Deleted!!!'
end
end

exec usp_delPlayer 3

exec usp_saPlayers
--------------------------------------------------------
exec sp_helptext usp_iPlayer
--------------------------------------------------------------------
alter proc usp_iPlayer  
@id int,  
@name nvarchar(50),  
@avg float,  
@team nvarchar(50)  
with encryption
as  
begin  
insert into Player(PId,Pname,PAvg,PTeam) values (@id,@name,@avg,@team)  
if(@@ROWCOUNT<>0)  
begin  
print 'Record Inserted!!!'  
end  
end
-------------------------------------
exec sp_helptext usp_iPlayer

use Day2Db
select * from Emps
---------------------------------------------------------------------------
create proc usp_salaryByDept
@did int,
@total float output
as
begin
select @total=sum(Salary) from Emps group by Department having Department=@did
end
----------------------------------------------------------

declare @sumSalary float
execute usp_salaryByDept 1,@sumSalary out
print @sumSalary
-------------------------------------------------
declare @sum float
execute usp_salaryByDept 2,@sum out
print 'Sum of Salaries : '+convert(nvarchar(50),@sum)
------------------------------------------------------------
create proc usp_nestPro
@did int
as
begin
declare @sum float
execute usp_salaryByDept @did,@sum out
if(@sum<>0)
begin
print 'Sum of Salaries of Department :'+convert(nvarchar(50),@did)+'is ='+convert(nvarchar(50),@sum) 
end
else
begin
print 'No Data available'
end
end
----------------
exec usp_nestPro 3

exec usp_nestPro 2

