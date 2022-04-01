use AdventureWorks2019
go

--task1
select firstname,lastname
from Person.Person
where title is not null

--task2
select firstname,lastname
from Person.Person
where FirstName like '%a%' and  LastName like '%a%'

--task3
select cur.CurrencyCode, name
from Sales.Currency cur,Sales.CountryRegionCurrency regcur



--task4

--create table Hr_Dept
--as (select * from HumanResources.Department )

select * into HR_Dept from HumanResources.Department
select*from HR_Dept


--task5
create table tbl_dummy
(
Sno int identity(1,1),
Name varchar(20),
age int,
college varchar(20),
place varchar(20)

)
insert into  tbl_dummy values('swe',21,'pec','chennai')
insert into  tbl_dummy values('krish',21,'pec','chennai')
insert into  tbl_dummy values('niksh',21,'pec','chennai')
insert into  tbl_dummy values('yog',21,'pec','chennai')
insert into  tbl_dummy values('jen',21,'pec','chennai')
insert into  tbl_dummy values('dev',21,'pec','chennai')
insert into  tbl_dummy values('nithin',21,'pec','chennai')
insert into  tbl_dummy values('john',21,'pec','chennai')
insert into  tbl_dummy values('haris',21,'pec','chennai')
insert into  tbl_dummy values('anandh',21,'pec','chennai')
insert into  tbl_dummy values('vishal',21,'pec','chennai')
insert into  tbl_dummy values('dilli',21,'pec','chennai')
insert into  tbl_dummy values('venkat',21,'pec','chennai')
insert into  tbl_dummy values('abdul',21,'pec','chennai')
insert into  tbl_dummy values('rukesh',21,'pec','chennai')
insert into  tbl_dummy values('kavi',21,'pec','chennai')
insert into  tbl_dummy values('yuvaraj',21,'pec','chennai')
insert into  tbl_dummy values('pavan',21,'pec','chennai')
insert into  tbl_dummy values('giri',21,'pec','chennai')
insert into  tbl_dummy values('moses',21,'pec','chennai')



select * from tbl_dummy


--task6

select pea.BusinessEntityID,AddressTypeID
from Person.BusinessEntityAddress pea
join [HumanResources].[EmployeeDepartmentHistory]  hre
on hre.BusinessEntityID=pea.BusinessEntityID
join [HumanResources].[Department] hrd
on hrd.DepartmentID=hre.DepartmentID


--task7
select distinct GroupName
from HumanResources.Department


--task 8

select pph.standardcost,sum(listprice) sum1,sum(pph.standardcost+ListPrice) Sum2
from Production.ProductCostHistory pph
join Production.Product pp
on pp.ProductID=pph.ProductID
group by pph.StandardCost





--task 9

--select
--datediff(YY ,'2007-12-05','2010-05-30')yearsonrole


select
datediff(YY ,startdate,enddate)yearsonrole
from HumanResources.EmployeeDepartmentHistory


select*from HumanResources.EmployeeDepartmentHistory

--task10
select sum(SalesQuota) sumsales
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota





--task 11

select MAX(taxrate) Max_taxrate
from Sales.SalesTaxRate




--task12
select hd.DepartmentID,he.BusinessEntityID,ShiftID,BirthDate,DATEDIFF(yy,BirthDate,getDate()) age
from [HumanResources].[Employee] he
join [HumanResources].[EmployeeDepartmentHistory] hed
on he.BusinessEntityID=hed.BusinessEntityID
join[HumanResources].[Department] hd
on hed.DepartmentID=hd.DepartmentID





--task13

create view vw_view
as
select hd.DepartmentID,he.BusinessEntityID,ShiftID,BirthDate,DATEDIFF(yy,BirthDate,getDate()) age
from [HumanResources].[Employee] he
join [HumanResources].[EmployeeDepartmentHistory] hed
on he.BusinessEntityID=hed.BusinessEntityID
join[HumanResources].[Department] hd
on hed.DepartmentID=hd.DepartmentID


select * from vw_view


--task 14
select count(*) No_of_rows_hr
from [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],
[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]


SELECT count(*)
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],
[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]


--task 15
select MAX(rate) highestsalary,Name
from [HumanResources].[EmployeePayHistory] hep
join [HumanResources].[EmployeeDepartmentHistory] hed
on hed.BusinessEntityID=hep.BusinessEntityID
join [HumanResources].[Department] hd
on hed.DepartmentID=hd.DepartmentID
group by Name

--task 16
select FirstName, MiddleName,Title,AddressTypeID,pp.BusinessEntityID
from Person.Person pp
Left join Person.BusinessEntityAddress pbe
on pbe.BusinessEntityID=pp.BusinessEntityID
where title is not null

--task17
select ProductID , LocationID,Shelf
from Production.ProductInventory
where ProductID>300 and ProductID<350 and (LocationID=50 or Shelf='E')


--task 18
select pl.LocationID,Shelf,Name
from[Production].[Location] pl
join [Production].[ProductInventory] ppi
on pl.LocationID=ppi.LocationID


--task19
select AddressID AddressLine1,AddressLine2,pa.StateProvinceID,StateProvinceCode,CountryRegionCode
from [Person].[Address] pa
join [Person].[StateProvince] psp
on pa.StateProvinceID=psp.StateProvinceID


--task 20

select sum([SubTotal]) subtotal,sum([TaxAmt]) taxamt
from [Sales].[CountryRegionCurrency] crc
join [Sales].[SalesTerritory] st
on crc.[CountryRegionCode]=st.[CountryRegionCode]
join [Sales].[SalesOrderHeader] soh
on st.[TerritoryID]=soh.[TerritoryID]
group by st.[TerritoryID]



