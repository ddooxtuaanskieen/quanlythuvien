USE master
GO

DROP DATABASE QUANLYTHUVIEN
GO

CREATE DATABASE QUANLYTHUVIEN
GO

USE QUANLYTHUVIEN
GO


CREATE TABLE NHANVIEN
(
	MaNhanVien nvarchar(15) not null primary key,
	HoVaTen nvarchar(200) not null,
	SoCMT nvarchar(15) not null,
	NgaySinh date not null,
	DiaChi nvarchar(200) not null,
	SoDienThoai nvarchar(15) not null,
	Email nvarchar(200) not null,
	MatKhau ntext not null default '4A7D1ED414474E4033AC29CCB8653D9B',
	Anh ntext default null,
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate(),
	NgayXoa datetime default null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV1', 
	N'Đỗ Tuấn Kiên', 
	'013550061', 
	'1997-08-23', 
	N'Xã Đông Mỹ, Huyện Thanh Trì, Thành phố Hà Nội', 
	'0976133520',
	'kien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV2', 
	N'Đỗ Tuấn Cường', 
	'520930080', 
	'2000-02-05', 
	N'Số 141a, ngõ 267/2 đường Hoàng Hoa Thám, Phường Liễu Giai, Quận Ba Đình, Thành phố Hà Nội',
	'0964199927', 
	'cuong@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV3', 
	N'Nguyễn Việt Hưng', 
	'148465572', 
	'1992-08-15', 
	N'Số 9 ngõ 97 Văn Cao, Phường Liễu Giai, Quận Ba Đình, Thành phố Hà Nội', 
	'0916241555', 
	'hung@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV4', 
	N'Nguyễn Lâm Tùng', 
	'825068763', 
	'1999-08-08', 
	N'Số 40 ngõ 188 phố Tư Đình, Tổ 9, Phường Long Biên, Quận Long Biên, Thành phố Hà Nội',
	'0928265412',
	'tung@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV5', 
	N'Phan Trung Hiếu', 
	'305389937', 
	'1995-03-07', 
	N'Số nhà 103, đường Nhân Trạch, Phường Phú Lãm, Quận Hà Đông, Thành phố Hà Nội',
	'0957225905',
	'hieu@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV6', 
	N'Hoàng Trung Hải', 
	'807355565', 
	'1990-12-09', 
	N'Lô số 14, khu BT1, dự án khu nhà ở Trung Văn, Phường Trung Văn, Quận Nam Từ Liêm, Hà Nội',
	'0994037216',
	'hieu@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV7', 
	N'Lâm Chí Dũng', 
	'288066208', 
	'1992-11-07', 
	N'Số nhà 53 ngách 158 ngõ 99 phố Định Công Hạ, Phường Định Công, Quận Hoàng Mai, Hà Nội',
	'0959862499',
	'dung@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV8', 
	N'Nguyễn Ðức Toàn', 
	'699176883', 
	'1996-04-29', 
	N'Xóm 2, thôn Lương Châu, Xã Tiên Dược, Huyện Sóc Sơn, Hà Nội',
	'0969810189',
	'toan@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV9', 
	N'Vũ Ngọc Lân', 
	'717124172', 
	'1996-09-01', 
	N'Số 210 Lê Trọng Tấn, Phường Khương Mai, Quận Thanh Xuân, Hà Nội',
	'0996754804',
	'lan@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO NHANVIEN VALUES 
(
	'NV10', 
	N'Lương Gia Thịnh', 
	'238320459', 
	'1998-01-03', 
	N'Số 69 phố Đăm, Phường Tây Tựu, Quận Bắc Từ Liêm, Hà Nội',
	'0955740834',
	'thinh@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO

CREATE TABLE QUYEN
(
	MaQuyen nvarchar(15) not null primary key,
	Ten nvarchar(200) not null,
	Mota ntext,
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate(),
	NgayXoa datetime default null
)
GO
--INSERT INTO QUYEN VALUES
--(
--	'Q1',
--	N'Xem Nhân Viên',
--	N'Quyền được xem thông tin tất cả nhân viên',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)

CREATE TABLE PHANQUYEN
(
	MaNhanVien nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	MaQuyen nvarchar(15) not null foreign key references QUYEN(MaQuyen),
	primary key(MaNhanVien, MaQuyen),
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate()
)
GO

CREATE TABLE SACH
(
	MaSach nvarchar(15) not null primary key,
	TieuDe nvarchar(200) not null,
	NhaXuatBan nvarchar(200),
	NgonNgu nvarchar(200),
	Anh ntext default null,
	Mota ntext,
	Gia int not null,
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate(),
	NgayXoa datetime default null
)
GO
INSERT INTO SACH VALUES
(
	'S1',
	N'Bố già',
	N'Nhà xuất bản Văn học',
	N'Việt',
	null,
	null,
	100000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S2',
	N'Hai số phận',
	N'Nhà xuất bản Văn học',
	N'Việt',
	null,
	null,
	100000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S3',
	N'Đắc nhân tâm',
	N'Nhà xuất bản Văn học',
	N'Việt',
	null,
	null,
	75000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S4',
	N'Không gia đình',
	N'Nhà xuất bản Văn học',
	N'Việt',
	null,
	null,
	120000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S5',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S6',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S7',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S8',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S9',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S10',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S11',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S12',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S13',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S14',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S15',
	N'Mắt biếc',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	null,
	70000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO

CREATE TABLE TACGIA
(
	MaTacGia nvarchar(15) not null primary key,
	HoVaTen nvarchar(200) not null,
	NgaySinh date,
	DiaChi nvarchar(200),
	SoDienThoai nvarchar(15),
	Email nvarchar(200),
	Anh ntext default null,
	MoTa ntext,
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate(),
	NgayXoa datetime default null
)
GO
INSERT INTO TACGIA VALUES
(
	'TG1',
	'Mario Puzo',
	null,
	null,
	null,
	null,
	null,
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO TACGIA VALUES
(
	'TG2',
	'Hector Malot',
	null,
	null,
	null,
	null,
	null,
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO TACGIA VALUES
(
	'TG3',
	N'Nguyễn Nhật Ánh',
	null,
	null,
	null,
	null,
	null,
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO TACGIA VALUES
(
	'TG4',
	'Jeffrey Archer',
	null,
	null,
	null,
	null,
	null,
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO TACGIA VALUES
(
	'TG5',
	'Dale Carnegie',
	null,
	null,
	null,
	null,
	null,
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO

CREATE TABLE SANGTAC
(
	MaSach nvarchar(15) not null foreign key references SACH(MaSach),
	MaTacGia nvarchar(15) not null foreign key references TACGIA(MaTacGia),
	primary key(MaSach, MaTacGia),
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate()
)
GO
INSERT INTO SANGTAC VALUES
(
	'S1',
	'TG1',
	'NV1',
	'2020-01-01 00:00:00'
)
GO
INSERT INTO SANGTAC VALUES
(
	'S2',
	'TG4',
	'NV1',
	'2020-01-01 00:00:00'
)
GO
INSERT INTO SANGTAC VALUES
(
	'S3',
	'TG5',
	'NV1',
	'2020-01-01 00:00:00'
)
GO
INSERT INTO SANGTAC VALUES
(
	'S4',
	'TG2',
	'NV1',
	'2020-01-01 00:00:00'
)
GO
INSERT INTO SANGTAC VALUES
(
	'S5',
	'TG3',
	'NV1',
	'2020-01-01 00:00:00'
)
GO

CREATE TABLE THELOAI
(
	MaTheloai nvarchar(15) not null primary key,
	Ten nvarchar(200) not null,
	MoTa ntext,
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate(),
	NgayXoa datetime default null
)
GO
INSERT INTO THELOAI VALUES
(
	'TL1',
	N'Trinh thám',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO THELOAI VALUES
(
	'TL2',
	N'Lãng mạn',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO THELOAI VALUES
(
	'TL3',
	N'Giật gân',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO THELOAI VALUES
(
	'TL4',
	N'Học đường',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO THELOAI VALUES
(
	'TL5',
	'Phiêu lưu',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO THELOAI VALUES
(
	'TL6',
	N'Kinh dị',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO THELOAI VALUES
(
	'TL7',
	N'Xã hội',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO THELOAI VALUES
(
	'TL8',
	N'Thiếu nhi',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO

CREATE TABLE PHANLOAI
(
	MaSach nvarchar(15) not null foreign key references SACH(MaSach),
	MaTheloai nvarchar(15) not null foreign key references THELOAI(MaTheloai),
	primary key(MaSach, MaTheloai),
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate()
)
GO

CREATE TABLE DOCGIA
(
	MaDocGia nvarchar(15) not null primary key,
	HoVaTen nvarchar(200) not null,
	SoCMT nvarchar(15) not null,
	NgaySinh date not null,
	DiaChi nvarchar(200) not null,
	SoDienThoai nvarchar(15) not null,
	Email nvarchar(200) not null,
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayLap datetime not null default getdate(),
	NgayXoa datetime default null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG1',
	N'Lương Định',
	'154214528',
	'1997-09-22',
	N'Nhà vườn B10, KĐT Trung Hòa Nhân Chính, Phường Nhân Chính, Quận Thanh Xuân, Hà Nội',
	'0952214412',
	'averysimplena.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG2',
	N'Thủy Nam An',
	'521411125',
	'1997-09-01',
	N'Tâng 9, toà nhà Tổng Công ty 319, số 63 Lê Văn Lương, Phường Trung Hoà, Quận Cầu Giấy, Hà Nội',
	'0956665573',
	'averysimplen.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG3',
	N'Vũ Trường Vinh',
	'512452147',
	'1991-09-17',
	N'Số 11, ngõ 12, đường Kim Giang, Phường Kim Giang, Quận Thanh Xuân, Hà Nội',
	'0965558475',
	'averysimpl.en.a.me@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG4',
	N'Nguyễn Phước Sơn',
	'521222523',
	'1995-09-21',
	N'Nhà CO2- L16, An Vượng Villas, Khu đô thị mới Dương Nội, Phường Dương Nội, Quận Hà Đông, Hà Nội',
	'0965552224',
	'averysimp.lenam.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG5',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG6',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG7',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG8',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG9',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG10',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG11',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG12',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG13',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG14',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO DOCGIA VALUES
(
	'DG15',
	N'Đào Lương Tài',
	'214521452',
	'1992-03-22',
	N'Số 19, ngách 124/64 đường âu Cơ, Phường Tứ Liên, Quận Tây Hồ, Hà Nội',
	'0952221451',
	'averysimp.len.a.m.e@gmail.com',
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO

CREATE TABLE MUONTRA
(
	MaMuonTra nvarchar(15) not null primary key,
	MaDocGia nvarchar(15) not null foreign key references DOCGIA(MaDocGia),
	MaSach nvarchar(15) not null foreign key references SACH(MaSach),
	NguoiChoMuon nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien),
	NgayMuon datetime not null default getdate(),
	NgayHenTra datetime not null,
	NguoiNhanTra nvarchar(15) foreign key references NHANVIEN(MaNhanVien),
	NgayTra datetime,
	Phi int
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT1',
	'DG1',
	'S1',
	'NV1',
	'2020-01-01 00:00:00',
	'2020-01-10 00:00:00',
	'NV1',
	'2020-01-05 00:00:00',
	0
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT2',
	'DG1',
	'S2',
	'NV1',
	'2020-01-01 00:00:00',
	'2020-01-10 00:00:00',
	'NV1',
	'2020-01-05 00:00:00',
	0
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT3',
	'DG2',
	'S1',
	'NV1',
	'2020-01-11 00:00:00',
	'2020-01-20 00:00:00',
	'NV1',
	'2020-01-15 00:00:00',
	0
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT4',
	'DG2',
	'S2',
	'NV1',
	'2020-01-11 00:00:00',
	'2020-01-15 00:00:00',
	'NV1',
	'2020-01-20 00:00:00',
	2500
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT5',
	'DG3',
	'S1',
	'NV1',
	'2020-01-21 00:00:00',
	'2020-01-31 00:00:00',
	'NV1',
	'2020-01-25 00:00:00',
	0
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT6',
	'DG3',
	'S2',
	'NV1',
	'2020-01-21 00:00:00',
	'2020-12-31 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT7',
	'DG4',
	'S1',
	'NV1',
	'2020-02-01 00:00:00',
	'2020-02-10 00:00:00',
	'NV1',
	'2020-02-05 00:00:00',
	0
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT8',
	'DG4',
	'S3',
	'NV1',
	'2020-02-01 00:00:00',
	'2020-02-10 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT9',
	'DG5',
	'S1',
	'NV1',
	'2020-02-11 00:00:00',
	'2020-02-15 00:00:00',
	'NV1',
	'2020-02-20 00:00:00',
	2500
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT10',
	'DG5',
	'S4',
	'NV1',
	'2020-02-11 00:00:00',
	'2020-02-15 00:00:00',
	'NV1',
	'2020-02-20 00:00:00',
	2500
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT11',
	'DG6',
	'S1',
	'NV1',
	'2020-02-21 00:00:00',
	'2020-02-25 00:00:00',
	'NV1',
	'2020-02-28 00:00:00',
	1500
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT12',
	'DG6',
	'S4',
	'NV1',
	'2020-02-21 00:00:00',
	'2020-12-31 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT13',
	'DG7',
	'S1',
	'NV1',
	'2020-03-01 00:00:00',
	'2020-03-05 00:00:00',
	'NV1',
	'2020-03-10 00:00:00',
	2500
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT14',
	'DG7',
	'S5',
	'NV1',
	'2020-03-01 00:00:00',
	'2020-03-10 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT15',
	'DG8',
	'S1',
	'NV1',
	'2020-03-11 00:00:00',
	'2020-12-31 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT16',
	'DG8',
	'S6',
	'NV1',
	'2020-03-11 00:00:00',
	'2020-12-31 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT17',
	'DG9',
	'S7',
	'NV1',
	'2020-03-21 00:00:00',
	'2020-12-31 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT18',
	'DG9',
	'S8',
	'NV1',
	'2020-03-21 00:00:00',
	'2020-03-31 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT19',
	'DG10',
	'S9',
	'NV1',
	'2020-04-01 00:00:00',
	'2020-04-10 00:00:00',
	null,
	null,
	null
)
GO
INSERT INTO MUONTRA VALUES
(
	'MT20',
	'DG10',
	'S10',
	'NV1',
	'2020-04-01 00:00:00',
	'2020-04-10 00:00:00',
	null,
	null,
	null
)
GO

CREATE PROCEDURE GETAVAILABLEBOOKS
AS
BEGIN
	SELECT * FROM SACH
	WHERE SACH.NgayXoa IS NULL
	AND SACH.MaSach NOT IN
	(
		SELECT MUONTRA.MaSach FROM MUONTRA
		WHERE MUONTRA.NgayTra IS NULL
	)
END
GO

CREATE PROCEDURE GETAVALIDMEMBER(@n INT)
AS
BEGIN
	--n là số sách được giữ tối đa
	SELECT * FROM DOCGIA
	WHERE DOCGIA.NgayXoa IS NULL
	AND DOCGIA.MaDocGia NOT IN
	(
		SELECT MUONTRA.MaDocGia FROM MUONTRA
		WHERE MUONTRA.NgayTra IS NULL
		GROUP BY MUONTRA.MaDocGia
		HAVING COUNT(MUONTRA.MaDocGia) >= @n
		--Lọc ra những người cầm quá số sách quy định
	)
	AND MaDocGia NOT IN
	(
		SELECT DISTINCT MUONTRA.MaDocGia FROM MUONTRA
		WHERE MUONTRA.NgayTra IS NULL
		AND MUONTRA.NgayHenTra < GETDATE()
		--Lọc ra những người cầm sách quá hẹn mà chưa trả
	)
END
GO

CREATE PROCEDURE GETTOPMEMBER
AS
BEGIN
SELECT DOCGIA.MaDocGia, DOCGIA.HoVaTen, COUNT(MUONTRA.MaDocGia) AS 'MUON' FROM DOCGIA
INNER JOIN MUONTRA
ON DOCGIA.MaDocGia = MUONTRA.MaDocGia
GROUP BY DOCGIA.MaDocGia, DOCGIA.HoVaTen
ORDER BY COUNT(MUONTRA.MaDocGia) DESC
END
GO

CREATE PROCEDURE GETTOPBOOK
AS
BEGIN
SELECT SACH.MaSach, SACH.TieuDe, COUNT(MUONTRA.MaSach) AS 'MUON' FROM SACH
INNER JOIN MUONTRA
ON SACH.MaSach = MUONTRA.MaSach
GROUP BY SACH.MaSach, SACH.TieuDe
ORDER BY COUNT(MUONTRA.MaSach) DESC
END
GO

CREATE PROCEDURE GETBLACKLIST(@N INT)
AS
BEGIN
-- Muộn trả sách n lần là vào danh sách đen
SELECT DOCGIA.MaDocGia, DOCGIA.HoVaTen, COUNT(MUONTRA.MaDocGia) AS 'TRE' FROM DOCGIA
INNER JOIN MUONTRA
ON DOCGIA.MaDocGia = MUONTRA.MaDocGia
WHERE MUONTRA.NgayTra > MUONTRA.NgayHenTra
OR 
	(
		MUONTRA.NgayTra IS NULL
		AND NgayHenTra < GETDATE()
	)
GROUP BY DOCGIA.MaDocGia, DOCGIA.HoVaTen
HAVING COUNT(MUONTRA.MaDocGia) >= @n
ORDER BY COUNT(MUONTRA.MaDocGia) DESC
END
GO