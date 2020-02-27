create database Code;

use Code;

create table Students(
	Student_ID int identity,
	S_Name nvarchar(100) ,
	S_Surname nvarchar(100) ,
	S_Age int not null,
	Gpa int ,
)

insert into Students values('Adil','Abdurrazzakli',20,89);
insert into Students values('Baba','Semedli',23,NULL);
insert into Students values('Fatima','Nasibova',21,85);
insert into Students values('Emin','Alizade',22,NULL);
insert into Students values('Rauf','Rafizade',21,87);

--it will add new column with special length
alter table Students
add Student_Adress varchar(50);


--it will rename name of column
exec sp_rename 'Students.Student_ID','Telebe_nomresi';


--it will change size of column
ALTER TABLE Students
ALTER COLUMN S_Surname nvarchar(25) Null

--it will drop column
alter table Students drop column Student_Adress

--it will change name of table
exec sp_rename 'Students','Telebeler'



--it will update column in table
--it will change Emin's name to 21
update Telebeler
set S_Age=21 where S_Name = 'Emin'

select * from Telebeler;


-- it will delete row
DELETE FROM Telebeler
WHERE S_Name = 'Rauf';


-- it will delete table
drop table Telebeler;


-- Group functions task
CREATE TABLE employeess( 
e_role nvarchar(20), 
e_name nvarchar(20), 
e_building nvarchar(20), 
e_years_employed int 
)

insert into employeess values
('Engineer','Dan B.','1e',2),
('Engineer','Sharon F.','1e',6),
('Engineer','Dan M.','1e',4),
('Engineer','Malcom S.','1e',1),
('Artist','Tylar S.','2w',2),
('Artist','Sherman D.','2w',8),
('Artist','Jakob J.','2w',6),
('Artist','Lillia A.','2w',7),
('Artist','Brandon J.','2w',7)


select * from employeess
--a
select e_role, min(e_years_employed) from employeess
group by e_role

--b
select e_building, COUNT(e_name) from employeess
group by e_building

--c
select count(e_name) from employeess
where e_role = 'Artist'

--d
select e_role, COUNT(e_name) from employeess
group by e_role
 
--e
select sum(e_years_employed) from employeess
where e_role = 'Engineer'

--f
select e_role, avg(e_years_employed) from employeess
group by e_role

--g
select e_role, max(e_years_employed) - min(e_years_employed) from employeess
group by e_role

