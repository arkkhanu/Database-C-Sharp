# Database-C-Sharp
A short program about Database connection where Insert, Update, Delete and Select (Action) Perform using Stored Procedure and Parametrized Query

# Steps of Configuration

step 1. Create a Database of name 'Temp'.
create database Temp;

step 2. Create a Table of name 'usertable'.
create table usertable id int primary key identity, fname varchar(50) , lname varchar(50) , age int , address varchar(50);

step 3. Create Procedure 

create procedure updateTable
@id int,@fname varchar(50),@lname varchar(50),@age int,@address varchar(50)
as
begin
update usertable set fname=@fname,lname=@lname,age=@age,address=@address where id=@id
end
go

create procedure insertIntoTable
@fname varchar(50) , @lname varchar(50) , @age int , @address varchar(50)
as 
begin
insert into usertable (fname,lname,age,address) values (@fname,@lname,@age,@address)
end
go

create procedure getdataTable
as 
begin
select * from usertable
end
go

create procedure deleteTable
@id int
as
begin
delete usertable where id= @id
end
go

step 4. In the AppConfig of your project write your servername instead of servername
	
