create database project
go

use project
go


--Product table

create table Product_table(
prodid int identity(1,1),
prodname varchar(20),
price money,
date_of_manufacture date default getdate(),
expirydate date default getdate()
constraint c_Prod primary key(prodid)
)
select*from Product_table


--CustomerTable
create table Customer_table(
custid int identity(100,1),
name varchar(20),
gender varchar(10),
DOB date,
contactno varchar(20),
emailid varchar(20),
city varchar(20),
constraint chk_g check(gender in ('male','female')),
constraint chk_c check(city in ('chennai','mumbai','pune','hyderabad')),
constraint c_cust primary key(custid)
)

select * from Customer_table

--PurChase Table

create table Purchase_table(
billno int identity(1,1),
custid int,
prodid int,
quantity int,
totalamount int ,
purchasedate date default getdate()
constraint c_pur primary key(billno),
Constraint C_customer foreign key(custid) references Customer_table(custid),
Constraint C_proc foreign key(prodid) references Product_table(prodid)
)

select * from Purchase_table

insert Product_table (prodname,price,date_of_manufacture,expirydate) values('cookies',40,getdate(),DATEADD(m,24,getdate()))
insert Product_table (prodname,price,date_of_manufacture,expirydate) values('chocos',50,getdate(),DATEADD(m,24,getdate()))
insert Product_table (prodname,price,date_of_manufacture,expirydate) values('nuts',100,getdate(),DATEADD(m,24,getdate()))
insert Product_table (prodname,price,date_of_manufacture,expirydate) values('drinks',60,getdate(),DATEADD(m,24,getdate()))




insert Customer_table(name,gender,DOB,contactno,emailid,city) values('swetha','female','2000-05-14','6382325571','swepc14@gmail.com','Chennai')
insert Customer_table(name,gender,DOB,contactno,emailid,city) values('nikshi','female','2001-06-14','6382387571','nikpc14@gmail.com','pune')
insert Customer_table(name,gender,DOB,contactno,emailid,city) values('yoga','female','2000-06-12','7382325571','yognpc14@gmail.com','Chennai')
insert Customer_table(name,gender,DOB,contactno,emailid,city) values('gloriya','female','2000-08-13','8382325571','glopc14@gmail.com','mumbai')
insert Customer_table(name,gender,DOB,contactno,emailid,city) values('devi','female','2001-04-09','6389325572','devpc14@gmail.com','pune')




select *from Purchase_table

select  ptt.prodid,custid,quantity,prodname,ptt.totalamount
from Product_table pt
join Purchase_table ptt
on pt.prodid=ptt.prodid
go



 


 
