create database QuanLiQuanCafe
go

use QuanLiQuanCafe
go

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống',  -- Trống || có người
)
go

create table Account
(
	UserName nvarchar(100) primary key,
	DisplayName Nvarchar(100) not null default N'Kter',
	PassWord nvarchar(1000) not null default 0,
	Type int not null default 0 -- 1: admin && 0: staff
)
go



create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên'
)
go

create table Food
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0,

	foreign key (idCategory) references dbo.FoodCategory(id)
)
go

create table Bill
(
	id int identity primary key,
	DateCheckIn date not null default getdate(),
	DateCheckOut date,
	idTable int not null,
	status int not null default 0  -- 1: đã thanh toán && 0: chưa thanh toán

	foreign key (idTable) references dbo.TableFood(id),
)
go
alter table dbo.Bill
add discount int 
go

update dbo.Bill set discount = 0
go
alter table dbo.Bill add totalPrice float
go

create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0,

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id),
)
go

insert into dbo.Account
		(
			UserName,
			DisplayName,
			PassWord,
			Type
		)
values	(	
			N'K9',
			N'RongK9',
			N'1',
			1
		)
insert into dbo.Account
		(
			UserName,
			DisplayName,
			PassWord,
			Type
		)
values   (
			N'staff' ,
			N'staff' ,
			N'1' ,
			0
)
go

create proc USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName
end
go

exec dbo.USP_GetAccountByUserName @userName = N'K9'
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
go

exec dbo.USP_Login @userName = N'K9', @passWord = N'1'
go

------------------- Thêm bàn
declare @i int = 0
while @i < 10
begin
	insert dbo.TableFood(name) values (N'Bàn ' + CAST(@i as nvarchar(100)))
	set @i = @i + 1
end
go


create proc USP_GetTableList
as select * from dbo.TableFood
go


-- Thêm category
insert dbo.FoodCategory (name)
values (N'Hải sản')
insert dbo.FoodCategory (name)
values (N'Nông sản')
insert dbo.FoodCategory (name)
values (N'Lâm sản')
insert dbo.FoodCategory (name)
values (N'Sản sản')
insert dbo.FoodCategory (name)
values (N'Nước')



-- Thêm món ăn
insert dbo.Food (name, idCategory, price)
values (N'Mực một nắng nướng sa tế', 1, 120000)
insert dbo.Food (name, idCategory, price)
values (N'Nghêu hấp xả', 1, 50000)
insert dbo.Food (name, idCategory, price)
values (N'Vú dê nướng sữa', 2, 60000)
insert dbo.Food (name, idCategory, price)
values (N'heo rừng nướng muối ớt', 3, 75000)
insert dbo.Food (name, idCategory, price)
values (N'Cơm chiên mushi', 4, 99999)
insert dbo.Food (name, idCategory, price)
values (N'7Up', 5, 15000)
insert dbo.Food (name, idCategory, price)
values (N'cafe', 5, 12000)


-- Thêm bill
insert dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
values (getdate(), null, 1, 0, 0)
insert dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
values (getdate(), null, 2, 0, 0)
insert dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
values (getdate(), getdate(), 2, 1, 0)


--delete dbo.BillInfo
--delete dbo.Bill
--delete Food
--delete FoodCategory
--delete TableFood

--DBCC CHECKIDENT (Food , RESEED, 0)
--DBCC CHECKIDENT (FoodCategory , RESEED, 0)
--DBCC CHECKIDENT (Bill , RESEED, 0)
--DBCC CHECKIDENT (BillInfo , RESEED, 0)
--DBCC CHECKIDENT (TableFood , RESEED, 0)

select * from dbo.BillInfo
select * from dbo.Bill
-- Thêm bill info 
insert dbo.BillInfo (idBill, idFood, count)
values (1, 1, 2)
insert dbo.BillInfo (idBill, idFood, count)
values (1, 3, 4)
insert dbo.BillInfo (idBill, idFood, count)
values (1, 5, 1)
insert dbo.BillInfo (idBill, idFood, count)
values (2, 1, 2)
insert dbo.BillInfo (idBill, idFood, count)
values (2, 5, 2)
insert dbo.BillInfo (idBill, idFood, count)
values (3, 5, 2)
go

select * from dbo.Bill
select * from dbo.BillInfo
select * from dbo.Food
select * from dbo.FoodCategory
select * from dbo.TableFood



--select f.name, bi.count, f.price, f.price*bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f
--where bi.idBill = b.id and bi.idFood = f.id and b.idTable = 1
--go

alter proc USP_InsertBill
@idTable int
as
begin
	insert dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
	values (getdate(), null, @idTable, 0, 0)
end
go

alter proc USP_InsertBillInfo
@idBill int , @idFood int, @count int
as
begin
	
	declare @isExitsBillInfo int;
	declare @foodCount int = 1;

	select @isExitsBillInfo = id, @foodCount = b.count 
	from dbo.BillInfo as b
	where idBill = @idBill and idFood = @idFood

	if(@isExitsBillInfo > 0)
	begin
		declare @newCount int = @foodCount + @count
		if(@newCount > 0)
			update dbo.BillInfo set count = @foodCount + @count where idFood = @idFood
		else
			delete dbo.BillInfo where idBill = @idBill and idFood = @idFood
	end
	else
	begin
		insert dbo.BillInfo (idBill, idFood, count)
		values (@idBill, @idFood, @count)
	end

end
go

alter trigger UTG_UpdateBillInfo
on dbo.BillInfo for insert, update
as
begin
	declare @idBill int 

	select @idBill = idBill from inserted

	declare @idTable int 

	select @idTable = idTable from dbo.Bill where id = @idBill and status = 0
	
	update dbo.TableFood set status = N'Có người' where id = @idTable
end
go

alter trigger UTG_UpdateBill
on dbo.Bill for update
as
begin
	declare @idBill int 

	select @idBill = id from inserted

	declare @idTable int 

	select @idTable = idTable from dbo.Bill where id = @idBill 

	declare @count int = 0

	select @count = count(*) from dbo.Bill where idTable = @idTable and status = 0

	if(@count = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable
end
go



alter proc USP_SwitchTable
@idTable1 int, @idTable2 int
as
begin
	declare @idFirstBill int
	declare @idSecondBill int

	select @idSecondBill = id from dbo.Bill where idTable = @idTable2 and status = 0
	select @idFirstBill = id from dbo.Bill where idTable = @idTable1 and status = 0

	print @idFirstBill
	print @idSecondBill
	print '--------------'

	if(@idFirstBill is null)
	begin
		print '00000001'

		insert dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
		values (getdate(), null, @idTable1, 0, 0)

		select @idFirstBill = max(id) from dbo.Bill where idTable = @idTable1 and status = 0
	end

	print @idFirstBill
	print @idSecondBill
	print '--------------'

	if(@idSecondBill is null)
	begin
		print '00000002'


		insert dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
		values (getdate(), null, @idTable2, 0, 0)

		select @idSecondBill = max(id) from dbo.Bill where idTable = @idTable2 and status = 0
	end

	print @idFirstBill
	print @idSecondBill
	print '--------------'

	select id into IDBillInfoTable from dbo.BillInfo where idBill = @idSecondBill

	update dbo.BillInfo set idBill = @idSecondBill where idBill = @idFirstBill

	update dbo.BillInfo set idBill = @idFirstBill where id in (select * from IDBillInfoTable)


	drop table IDBillInfoTable
end
go


alter proc USP_GetListBillByDate
@checkIn date, @checkOut date
as
begin
	select t.name as[Tên bàn], b.totalPrice as [Tổng tiền], DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra], discount as [Giảm giá]
	from dbo.Bill as b, dbo.TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
end
go

create proc USP_UpdateAccount
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
as
begin
	declare @isRightPass int = 0

	select @isRightPass = count(*) from dbo.Account where UserName = @userName and PassWord = @password

	if(@isRightPass = 1)
	begin
		if(@newPassword = null or @newPassword = '')
		begin
			update dbo.Account set DisplayName = @displayName where UserName = @userName
		end
		else
			update dbo.Account set DisplayName = @displayName, PassWord = @newPassword where UserName = @userName
			
	end
end
go

select * from BillInfo
select * from Bill
select * from TableFood

alter trigger UTG_DeleteBillInfo
on dbo.BillInfo for delete
as
begin
	declare @idBillInfo int
	declare @idBill int
	select @idBillInfo = id, @idBill = deleted.idBill from deleted

	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill

	declare @count int = 0
	select @count = count(*) from dbo.BillInfo as bi, dbo.Bill as b where b.id = bi.idBill and b.id = @idBill and b.status = 0

	if(@count = 0)
		update dbo.TableFood set status = N'Trống' where id = @idTable
end
go
---------------------------hàm chuyển chữ có dấu thành không dấu ---------------------------------
CREATE FUNCTION [dbo].[fuConvertToUnsign1]
(
 @strInput NVARCHAR(4000)
)
RETURNS NVARCHAR(4000)
AS
BEGIN 
 IF @strInput IS NULL RETURN @strInput
 IF @strInput = '' RETURN @strInput
 DECLARE @RT NVARCHAR(4000)
 DECLARE @SIGN_CHARS NCHAR(136)
 DECLARE @UNSIGN_CHARS NCHAR (136)
 SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế
 ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý
 ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ
 ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'
 +NCHAR(272)+ NCHAR(208)
 SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee
 iiiiiooooooooooooooouuuuuuuuuuyyyyy
 AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII
 OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 DECLARE @COUNTER int
 DECLARE @COUNTER1 int
 SET @COUNTER = 1
 WHILE (@COUNTER <=LEN(@strInput))
 BEGIN 
 SET @COUNTER1 = 1
 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
 BEGIN
 IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1))
 = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
 BEGIN 
 IF @COUNTER=1
 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
 + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
 ELSE
 SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1)
 +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
 + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
 BREAK
 END
 SET @COUNTER1 = @COUNTER1 +1
 END
 SET @COUNTER = @COUNTER +1
 END
 SET @strInput = replace(@strInput,' ','-')
 RETURN @strInput
END
go
----------------------------------------------------------------------
--select * from Food where dbo.fuConvertToUnsign1(name) like N'%' + dbo.fuConvertToUnsign1(N'muc') + '%'

alter proc USP_GetListBillByDateAndPage
@checkIn date, @checkOut date, @page int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows
	declare @exceptRows int = (@page - 1) * @pageRows

	;with BillShow as( select b.id, t.name as[Tên bàn], b.totalPrice as [Tổng tiền], DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra], discount as [Giảm giá]
	from dbo.Bill as b, dbo.TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable )
	
	select top (@selectRows) * from BillShow where id not in (select top (@exceptRows) id from BillShow)

end
go

create proc USP_GetNumBillByDate
@checkIn date, @checkOut date
as
begin
	select count(*)
	from dbo.Bill as b, dbo.TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1 and t.id = b.idTable
end
go


