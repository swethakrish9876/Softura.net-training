use Trail 
go


select * from Enrollment

go
alter proc sp_Enroll
@Name VarChar(20)
as
begin
delete [dbo].[Enrollment]
where Name=@Name
end
exec sp_Enroll 'nikshi'





--create proc sp_Enrol
--(@Sno int,@Name varchar(20),@Sid int,@Sage int)
--as
--insert Enrollment values(@sno,@Name,@Sid,@Sage)

--sp_Enrol 6, 'Krishna',6,18
