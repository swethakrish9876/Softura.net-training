use Trail
go

create table Customer(
CustomerID int,
CustomerName varchar(20),
EmailId varchar(20),
MobileNo varchar(20),
Constraint PK_CustId Primary key (CustomerID)
)

create proc GetAllCustomers
as
select CustomerID,CustomerName,EmailId,MobileNo 
from dbo.Customer
exec GetAllCustomers
 

 create proc NewCustomer
 @sno int,
 @cname Varchar(20),
 @email varchar(35),
 @mob varchar(10)
 as
 insert into Customer(CustomerID,CustomerName,EmailId,MobileNo)
 values(@sno,@cname,@email,@mob)
 exec NewCustomer



 select *from Customer
