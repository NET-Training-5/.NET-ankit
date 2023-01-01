create table Employee
( 
Id int not null identity primary key,
Name nvarchar(200) not null,
Address nvarchar(300),
Gender char(1) not null,
Dob Datetime

)
insert into Employee
values('Ankit Dhungana','Kathmandu','M','1998/12/12')

insert into Employee
values('Sasmit Dhungana','Kathmandu','M','1998/12/12')




Select * from Employee