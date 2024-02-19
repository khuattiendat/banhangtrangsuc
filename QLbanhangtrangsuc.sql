create database QLbanhangtrangsuc
use QLbanhangtrangsuc
go
-- bang tai khoan

create table taikhoan 
(
	id int IDENTITY primary key,
	ten nvarchar(100)  not null ,
	sdt nvarchar(11) not null,
	gioitinh nvarchar(5) not null,
	ngaysinh date not null,
	diachi nvarchar(100) not null,
	email varchar(50) not null unique,
	matkhau nvarchar(100) not null default 0,
	loaiTK int not null default 0 -- 1: admin && 0: khach hang
)
-- bang khach hang
create table khachhang
(
	id int IDENTITY primary key,
	ten nvarchar(100) not null,
	sdt text
)
insert into khachhang (ten) values
(
	N'Ẩn danh'
)
go
-- bang loai san pham
create table loaisp
(
	id int identity primary key,
	tenloai nvarchar(50) not null unique
)
select * from loaisp where tenloai = N'Nhẫn' and id != 2
go
-- bang san pham
create table sanpham
(
	id int identity primary key,
	ten nvarchar(100) not null unique,
	gia float not null,
	tonkho int,
	idloaisp int not null,
	foreign key (idloaisp) references loaisp(id),
)
go
-- bang hoa don
create table hoadon 
(
	id int identity primary key,
	idkh int not null,
	ngaymua datetime default null,
	tonggia float,
	giamgia int,
	trangthai int default 0, -- 0 chưa thanh toán , 1 đã thanh toán
	foreign key (idkh) references dbo.khachhang(id)
)
--bang chi tiet hoa don
create table chitiethoadon 
(
	id int identity primary key,
	idhd int not null,
	idsp int not null,
	count int not null default 0,
	FOREIGN KEY (idhd) REFERENCES dbo.hoadon(id),
	FOREIGN KEY (idsp) REFERENCES dbo.sanpham(id)
)
go
-- chen du lieu
select * from taikhoan
insert into taikhoan(ten, sdt, gioitinh, ngaysinh, diachi, email, matkhau, loaiTK) values
(
	N'Khuất Tiến Đạt',
	N'0123456',
	'Nam',
	'2002-08-28',
	N'Hà Nội',
	'khuattiendat@gmail.com',
	'1',
	'0'
)
insert into taikhoan(ten, sdt, gioitinh, ngaysinh, diachi, email, matkhau, loaiTK) values
(
	N'admin',
	'0123456',
	'Nam',
	'2002-08-28',
	N'Hà Nội',
	'khuattiendat2002@gmail.com',
	'1',
	'1'
)
update taikhoan set email = 'khuattiendat2002@gmail.com' where id = 3
-- chen san pham
select * from sanpham
insert into sanpham(idloaisp, ten, gia) values
(
	'1',
	N'Nhẫn thiết kế vương miện',
	'2000000'
)
insert into sanpham(idloaisp, ten, gia) values
(
	'1',
	N'Nhẫn hình lá',
	'2500000'
)
insert into sanpham(idloaisp, ten, gia) values
(
	'1',
	N'Nhẫn đính đá',
	'2000000'
)
insert into sanpham(idloaisp, ten, gia) values
(
	'1',
	N'Nhẫn đính đá ngọc chai',
	'2990000'
)
insert into sanpham(idloaisp, ten, gia) values
(
	'2',
	N'Vòng choker kim loại',
	'2000000'
)
insert into sanpham(idloaisp, ten, gia) values
(
	'2',
	N'Vòng choker kiểu kết hợp',
	'2000000'
)
insert into sanpham(idloaisp, ten, gia) values
(
	'3',
	N'Lắc tay nam dây xích',
	'2000000'
)
insert into sanpham(idloaisp, ten, gia) values
(
	'3',
	N'Lắc tay nam bản to',
	'2950000'
)
select * from loaisp
insert into loaisp(tenloai) values
(
	N'Nhẫn'
)
insert into loaisp(tenloai) values
(
	N'Vòng'
)
insert into loaisp(tenloai) values
(
	N'Lắc tay'
)
-- proceduce
--Đăng nhập
create PROC DangNhap
@email nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.taikhoan WHERE email = @email AND matkhau = @passWord
END
GO
select * from hoadon
-- thêm hóa đơn
create proc Themhoadon
@idkh INT
as
BEGIN INSERT dbo.hoadon
        ( ngaymua ,
          idkh ,
          trangthai
        )
VALUES  (
          NULL , --
          @idkh , -- 
          0  -- 
        )
END
GO
-- thêm chi tiết hóa đơn
create proc ThemChiTietHoaDon
@idhd int , @idsp int , @count int
as
BEGIN INSERT dbo.chitiethoadon
        ( idhd ,
          idsp ,
          count
        )
VALUES  ( @idhd, 
		@idsp, 
		@count
        )
END
GO
delete from khachhang
-- lấy danh sách hóa đơn theo ngày
create PROC Laydanhsachhoadontheongay
@tungay date, @denngay date
AS 
BEGIN
	SELECT t.ten AS [Tên khách hàng], ngaymua AS [Ngày mua hàng], giamgia AS [Giảm giá (%)] , b.tonggia AS [Tổng tiền]
	FROM dbo.hoadon b,dbo.khachhang AS t
	WHERE ngaymua >= @tungay AND ngaymua <= @denngay AND b.trangthai = 1
	AND t.id = b.idkh
END
GO

--
select * from taikhoan
select * from chitiethoadon
delete hoadon
alter PROC USP_Themchitiethoadon
@idhd INT, @idsp INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	DECLARE @TONKHO INT
	DECLARE @SLHD INT
	select @SLHD = cthd.count from chitiethoadon as cthd inner join hoadon as hd on cthd.idhd=hd.id where idsp = @idsp and idhd = @idhd
	select @TONKHO = tonkho from sanpham where id = @idsp;
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.chitiethoadon AS b 
	WHERE idhd = @idhd AND idsp = @idsp
	if(@TONKHO - (@SLHD + @count) < 0)
		BEGIN
			RAISERROR('Số lượng sản phẩm còn lại không đủ, thêm mới bị hủy bỏ',16, 1)
			return;
		END
	if(@TONKHO - @count >=0) 
	BEGIN
	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.chitiethoadon SET count = @foodCount + @count WHERE idsp = @idsp
		ELSE
			DELETE dbo.chitiethoadon WHERE idhd = @idhd AND idsp = @idsp
	END
	ELSE
	BEGIN
		INSERT	dbo.chitiethoadon
        ( idhd, idsp, count )
		VALUES  ( @idhd, -- idBill - int
          @idsp, -- idFood - int
          @count  -- count - int
          )
	END
	end

	else
	begin
			RAISERROR('Số lượng sản phẩm còn lại không đủ, thêm mới bị hủy bỏ',16, 1)
			RETURN;
	end

END
GO
--
alter proc checkTotalProduct
@idhd INT, @idsp INT, @count INT
as
BEGIN
	DECLARE @TONKHO INT
	DECLARE @SLHD INT
	select @TONKHO = tonkho from sanpham where id = @idsp;
	select @SLHD = cthd.count from chitiethoadon as cthd inner join hoadon as hd on cthd.idhd=hd.id where idsp = @idsp and idhd = @idhd
	if(@TONKHO - (@SLHD + @count) >=0)
		BEGIN
			return;
		END
	else
		BEGIN
			UPDATE dbo.chitiethoadon SET count = @SLHD WHERE idsp = @idsp
			RAISERROR('Số lượng sản phẩm còn lại không đủ',16, 1)
		END
		
END
--
select * from chitiethoadon
alter proc UpdateTotalProduct @idsp int , @idhd int 
as
begin 
	DECLARE @slsp INT
	DECLARE @slhd INT
	select  @slsp = tonkho from sanpham where id = @idsp
	select @slhd = cthd.count from chitiethoadon as cthd inner join hoadon as hd on cthd.idhd=hd.id where idsp = @idsp and idhd = @idhd
	--DECLARE @newsl INT = 
	if(@slsp - @slhd >= 0)
		begin
			update sanpham set tonkho = @slsp - @slhd where id = @idsp
		end
end
--
select * from sanpham
exec UpdateTotalincreaseProduct 3,74
alter proc UpdateTotalincreaseProduct @idsp int , @idhd int 
as
begin 
	DECLARE @slsp INT
	DECLARE @slhd INT
	select  @slsp = tonkho from sanpham where id = @idsp
	select @slhd = cthd.count from chitiethoadon as cthd inner join hoadon as hd on cthd.idhd=hd.id where idsp = @idsp and idhd = @idhd
	--DECLARE @newsl INT = 
	if(@slhd >= 0)
		begin
			update sanpham set tonkho = @slsp + @slhd where id = @idsp
		end
end
select * from sanpham where id = [1,2]
update sanpham set tonkho = 110 where id = 6
select * from chitiethoadon
select * from hoadon
CREATE TRIGGER UTG_UpdateBill
ON dbo.hoadon FOR UPDATE
AS
BEGIN
	DECLARE @idhd INT
	
	SELECT @idhd = id FROM Inserted	
	
	DECLARE @idkh INT
	
	SELECT @idkh = idkh FROM dbo.hoadon WHERE id = @idhd
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.hoadon WHERE idkh = @idkh AND trangthai = 0
	
	--IF (@count = 0)
		--UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
--
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.chitiethoadon FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idhd INT
	
	SELECT @idhd = idhd FROM Inserted
	
	DECLARE @idkh INT
	
	SELECT @idkh = idkh FROM dbo.hoadon WHERE id = @idhd AND trangthai = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.chitiethoadon WHERE idhd = @idhd
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idkh
		PRINT @idhd
		PRINT @count
		
		--UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable		
		
	END		
	ELSE
	BEGIN
	PRINT @idkh
		PRINT @idhd
		PRINT @count
	--UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable	
	end
	
END
GO
select * from hoadon
select * from chitiethoadon
select * from sanpham
select tonkho from  sanpham sp  sp. where id = 1

select cthd.count from chitiethoadon as cthd
inner join hoadon as hd on cthd.idhd=hd.id 
 where idsp = 1 and idhd = 8
delete from chitiethoadon where chitiethoadon.idhd = 8 and chitiethoadon.idsp = 1
from chitiethoadon as cthd inner join sanpham as sp on cthd.idsp=sp.id  where cthd.idsp = 1
SELECT f.ten, bi.count, f.gia, f.gia*bi.count AS totalPrice 
	FROM dbo.chitiethoadon AS bi, dbo.hoadon AS b, dbo.sanpham AS f
	WHERE bi.idhd = b.id AND bi.idsp = f.id AND b.trangthai =0 AND b.idkh =  1

SELECT MAX(id) FROM sanpham
select * from sanpham