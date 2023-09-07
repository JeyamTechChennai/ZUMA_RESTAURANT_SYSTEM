
 PROJECT : Zuma Restaurant System
!!!!!!!!!!!!! If any doubts & clarifications ...please contact 6383180750 !!!!!!!!



use Zuma_Restaurant
drop table tbl_user
create table tbl_user
(
Id int primary key,
Name varchar(50),
Password varchar(50)
)

create procedure sp_reg_user
(
@Id int ,
@Name varchar(50),
@Password varchar(50)
)
as
begin
insert into tbl_user(Id,Name ,Password) values(@Id,@Name,@Password)
end

create table tbl_login
(
Username varchar(50)unique,
Password varchar(50)
)

--create procedure sp_login
--(
--		@uname varchar(50),
--		@pwd varchar(50)
--)
--as begin
----   select count(1) from tbl_user
----    where Username = @uname and Password=@pwd
----end
--SELECT * FROM tbl_user WHERE  uname  = 'admin' AND pwd = '12345';
--end
DROP PROCEDURE sp_login
CREATE PROCEDURE sp_login
    @Username VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    -- Declare a variable to hold the count of matching records
    DECLARE @MatchCount INT;

    -- Check if the username and password match
    SELECT @MatchCount = COUNT(*)
    FROM tbl_user
 WHERE @Username = @username AND @Password =  @password;

  IF @MatchCount = 1
        SELECT 1 AS 'LoginSuccessful';
    ELSE
        SELECT 0 AS 'LoginSuccessful';

END
select * from tbl_login



create table tbl_fooddetails
(
Id int identity(1,1),
Name varchar(50),
food varchar(50),
food1 varchar(50),
price int
)
create procedure sp_fooddetails
( 
        @id varchar(50),
        @name varchar(50),
		@food varchar(50),
		@food1 varchar(50),
		@price int
)
as begin
insert into tbl_fooddetails
   (Id,Name,food,food1,price)
   values ( @id ,@name,@food,@food1,@price)
end


