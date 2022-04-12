use Trail 
go


select * from Enrollment

go
create proc sp_Enroll
(@Sno int,@Name varchar(20),@Sid int,@Sage int)
as
begin
delete [dbo].[Enrollment]
where Name='nikshi'
end



--create proc sp_Enrol
--(@Sno int,@Name varchar(20),@Sid int,@Sage int)
--as
--insert Enrollment values(@sno,@Name,@Sid,@Sage)

--sp_Enrol 6, 'Krishna',6,18