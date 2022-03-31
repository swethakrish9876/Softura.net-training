use Trail
go

create table task_sql1
(
sno int, 
Firstname varchar(20),
lastname varchar(20),
age int constraint che_age check(age>=18),
gender char(1)constraint ch_gen check(gender in('f','m')),
contactno varchar(10),
boardeducation varchar(10)constraint ki_board check(boardeducation in ('state','CBSE')),
degree varchar(10)constraint key_deg check(degree in ('B.E','B.Sc','B.Tech')),
hscmarks int,
sslcmarks int,
dateofbirth varchar(20),
address varchar(50),
emailid varchar(40),
year_of_passing int constraint kk_year check(year_of_passing in('2022'))
constraint pk_task primary key(sno)
)


select*from task_sql1


insert into task_sql1 values(1,'swetha','boopa',18,'f','9344737119','state','B.E',1044,480,'10-07-2000','villupuram','swe@swe.com',2022)
insert into task_sql1 values(2,'krishna','vasudeva',24,'m','8056288732','CBSE','B.E',1200,500,'10-07-1994','Mathura','krish@swe.com',2022)