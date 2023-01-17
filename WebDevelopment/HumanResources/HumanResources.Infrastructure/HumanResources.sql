
create table Employee
(
	Id int,
	Name nvarchar(200),
	Address nvarchar(300),
	Gender char(1),
	Dob datetime
)

drop table Employee
create table Employee
(
	Id int not null identity primary key,
	Name nvarchar(200) not null,
	Address nvarchar(300),
	Gender char(1) not null,
	Dob datetime
)

insert into Employee
values ('Ashesh Shrestha', 'Kathmandu', 'M', '1988/12/12')

select * from Employee

--update Employee set Name = 'Sita Neupane', Gender = 'F'
--where Id=2

delete from Employee where Id=1002

