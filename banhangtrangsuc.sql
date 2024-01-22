use banhangtrangsuc
go
create table taikhoan 
(
	idad int IDENTITY primary key,
	tenad nvarchar(100) not null,
	sdt int not null,
	gioitinh nvarchar(5) not null,
	ngaysinh date not null,
	diachi nvarchar(100) not null,
	email varchar(50) not null,
	matkhau nvarchar(100) not null default 0,
	loaiTK int not null default 0 -- 1: admin && 0: khach hang
)
go
insert into taikhoan(tenad, sdt, gioitinh, ngaysinh, diachi, email, matkhau) values (
	N'dat',
	'0123456',
	'nam',
	'2002-08-08',
	'ha noi',
	'khuat2002@gmail.com',
	'123'
)
insert into taikhoan(tenad, sdt, gioitinh, ngaysinh, diachi, email, matkhau, loaiTK) values (
	N'admin1',
	'0123456',
	'nam',
	'2002-08-08',
	'ha noi',
	'khuat2002@gmail.com',
	'1',
	'1'
)
select * from sanpham
create table loaiSP 
(
	idloai int identity primary key,
	tenloai nvarchar(50)
)
go
-- chèn dữ liệu loaisp\
insert into loaiSP(tenloai) values
(
	N'NHẫn'
)
insert into loaiSP(tenloai) values
(
	N'Vòng cổ'
)
insert into loaiSP(tenloai) values
(
	N'Lắc tay'
)
create table sanpham
(
	idsp int identity primary key,
	tensp nvarchar(100) not null,
	gia float not null,
	idloai int not null,
	foreign key (idloai) references loaiSP(idloai)
)
create table khachhang
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL ,
	sodienthoai int,
)
insert into khachhang(name, sodienthoai) values
(
	N'dat1',
	'03432422'
)
-- chèn dữ liệu sản phẩm

insert into sanpham(idloai, tensp, gia) values
(
	'1',
	N'Nhẫn thiết kế vương miện',
	'2000000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'1',
	N'Nhẫn hình lá',
	'2500000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'1',
	N'Nhẫn đính đá tam giác',
	'3200000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'1',
	N'Nhẫn đính đá ngọc chai',
	'2000000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'2',
	N'Vòng choker kim loại',
	'2000000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'2',
	N'Vòng choker kiểu kết hợp',
	'3000000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'2',
	N'Vòng choker tattoo',
	'2000000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'2',
	N'Vòng choker kiểu punk rock',
	'2000000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'3',
	N'Lắc tay nam dây xích.',
	'2900000'
)
insert into sanpham(idloai, tensp, gia) values
(
	'3',
	N'Lắc tay nam bản to.',
	'5500000'
)
select idhd from hoadon
create table hoadon 
(
	idhd int identity primary key,
	idkh int,
	datecheckin Datetime not null default getdate(),
	datecheckout datetime,
	trangthai int default 0, -- 0 chưa thanh toán , 1 đã thanh toán
	foreign key (idkh) references dbo.khachhang(id)
)

create table chitiethoadon 
(
	idctdh int identity primary key,
	idhd int not null,
	idsp int not null,
	count int not null default 0,
	FOREIGN KEY (idhd) REFERENCES dbo.hoadon(idhd),
	FOREIGN KEY (idsp) REFERENCES dbo.sanpham(idsp)
)
-- proceduce
create PROC DangNhap
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.taikhoan WHERE tenad = @userName AND matkhau = @passWord
END
GO
select * from taikhoan
create proc DangKy
@userName nvarchar(100), @passWord nvarchar(100), @number int, @gender nvarchar(5), @ngaysinh dateTime, @address nvarchar(100),@email nvarchar(100), @typeAcc int
as
begin
	insert into taikhoan(tenad, sdt, gioitinh, ngaysinh, diachi, email, matkhau) values (
	@userName,
	@number,
	@gender,
	@ngaysinh,
	@address,
	@email,
	@typeAcc
)
end
go
select * from hoadon
create proc Themhoadon
@idkhachhang INT
as
BEGIN INSERT	dbo.hoadon
        ( datecheckin ,
          datecheckout ,
          idkh ,
          trangthai
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          @idkhachhang , -- idTable - int
          0  -- status - int
        )
END
