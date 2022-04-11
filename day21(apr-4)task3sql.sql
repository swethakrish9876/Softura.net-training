use AdventureWorks2019
go
--Task1


select  COUNT(ProductDescriptionID) Totalnoofrows
from [Production].[ProductDescription]


--SUM()
select SUM(StandardCost) SumCost
from [Production].[ProductCostHistory]


--DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]


--ADDDATE()
SELECT DATEADD(year, 1,'2009-01-29 00:00:00:000')  Date_Add

--select DATEADD(year,1,'2009-01-07 00:00:00:000') modified_data


--CONVERT()
SELECT CONVERT(float,88);


--LEFT()
SELECT LEFT('VETTEL', 3) AS ExtractString;


--LEN()
select LEN('MAX')


--REVERSE()
select REVERSE('MAX STEVENS')



--Task2
go

--create function fn_RupeesC(@amount as Nvarchar(50))
--returns Nvarchar(50)
--as 
--begin
--return (N'₹'+@amount)
--end
--select BusinessEntityID,dbo.fn_RupeesC(rate) as Dollar 
--from HumanResources.EmployeePayHistory


select ModifiedDate,'$'+convert(varchar,EndOfDayRate) as PaymentAmount
from Sales.CurrencyRate


--Task3
--droptable tbl_student

create table tbl_student1
(
Sno int,
StuName varchar(20),
StuAge int
)
alter table tbl_student1
add Gender char(1)
select * from tbl_student1
alter table tbl_student1
add MobileNO int
insert into tbl_student1 values(1,'kamesh',19,'M',867843)
alter table tbl_student1
alter column MobileNO char(10)
select * from tbl_student1
go
create view vw_ss1
as
select [Sno],[StuName],[StuAge]
from [dbo].[tbl_student1]
go
select *from vw_ss1
insert into tbl_student1 values(2,'ERIK',19,'M',856485)



--Task4
use Trail
go
select * from dbo.tbl_just
create proc taskIns_sp
@age int,
@gender char(1)
as
insert into tbl_just(age,gender)
values(@age,@gender)
taskIns_sp 22,'M'

--drop proc taskup_sp
create proc taskup_sp
as
select age ,gender
from tbl_just
begin
update tbl_just set age=18 where gender = 'm'
end



create proc taskdel_sp
@age int
as
begin
delete tbl_just where age = 18
end



--Task5
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))

select*from production.product



--Task6
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]

--Task7
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name
