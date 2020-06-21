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
	Anh ntext,
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-10 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-20 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-01-15 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-03-05 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-02-13 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-05-01 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-03-21 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-02-20 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	'dd4b21e9ef71e1291183a46b913ae6f2',
	null,
	'NV1',
	'2020-04-12 00:00:00',
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
--	N'Xem Nhân Viên 1',
--	N'Quyền được xem thông tin tất cả nhân viên',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q2',
--	N'Xem Nhân Viên 2',
--	N'Quyền được xem thông tin của mình',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q3',
--	N'Thêm Nhân Viên',
--	N'Quyền được thêm nhân viên mới',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q4',
--	N'Chỉnh sửa Nhân Viên',
--	N'Quyền được chỉnh sửa thông tin tất cả nhân viên',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q5',
--	N'Chỉnh sửa Nhân Viên 2',
--	N'Quyền được chỉnh sửa thông tin của mình',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q6',
--	N'Chỉnh sửa Nhân Viên 3',
--	N'Quyền được chỉnh sửa thông tin nhân viên mà mình tạo mình',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q1',
--	N'Xem Nhân Viên',
--	N'Quyền được xem thông tin tất cả nhân viên',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q1',
--	N'Xem Nhân Viên',
--	N'Quyền được xem thông tin tất cả nhân viên',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q1',
--	N'Xem Nhân Viên',
--	N'Quyền được xem thông tin tất cả nhân viên',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q1',
--	N'Xem Nhân Viên',
--	N'Quyền được xem thông tin tất cả nhân viên',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
--INSERT INTO QUYEN VALUES
--(
--	'Q1',
--	N'Xem Nhân Viên',
--	N'Quyền được xem thông tin tất cả nhân viên',
--	'NV1',
--	'2020-01-01 00:00:00',
--	null
--)
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
	Anh ntext,
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
	'https://i.imgur.com/EBAfw53.jpg',
	N'Thế giới ngầm được phản ánh trong tiểu thuyết Bố già là sự gặp gỡ giữa một bên là ý chí cương cường và nền tảng gia tộc chặt chẽ theo truyền thống Mafia xứ Sicily với một bên là xã hội Mỹ nhập nhằng đen trắng, mảnh đất màu mỡ cho những cơ hội làm ăn bất chính hứa hẹn những món lợi kếch xù. Trong thế giới ấy, hình tượng Bố già được tác giả dày công khắc họa đã trở thành bức chân dung bất hủ trong lòng người đọc. Từ một kẻ nhập cư tay trắng đến ông trùm tột đỉnh quyền uy, Don Vito Corleone là con rắn hổ mang thâm trầm, nguy hiểm khiến kẻ thù phải kiềng nể, e dè, nhưng cũng được bạn bè, thân quyến xem như một đấng toàn năng đầy nghĩa khí. Nhân vật trung tâm ấy đồng thời cũng là hiện thân của một pho triết lí rất “đời” được nhào nặn từ vốn sống của hàng chục năm lăn lộn giữa chốn giang hồ bao phen vào sinh ra tử. Với kết cấu hoàn hảo, cốt truyện không thiếu những pha hành động gay cấn, tình tiết bất ngờ và không khí kình địch đến nghẹt thở, Bố già xứng đáng là đỉnh cao trong sự nghiệp văn chương của Mario Puzo.',
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
	'https://i.imgur.com/IkeTrVF.jpg',
	N'Hai số phận (có tên gốc tiếng Anh là: Kane and Abel) là một cuốn tiểu thuyết được sáng tác vào năm 1979 bởi nhà văn người Anh Jeffrey Archer. Tựa đề Kane and Abel dựa theo câu chuyện của anh em: Cain và Abel trong Kinh Thánh Cựu Ước. Hai số phận của hai con người này hoàn toàn khác nhau, một người sinh ra trong nghèo khó nhưng lại rất may mắn, một người sinh ra trong giàu có nhưng lại rất nỗ lực. Hai con người ai cũng phải trải qua những biến cố, mất mát và trải nghiệm sống để mà có thể đi đến thành công. Tác phẩm được xuất bản tại Vương quốc Anh vào năm 1979 và tại Hoa Kỳ vào tháng 2 năm 1980, cuốn sách phổ biến thành công trên thế giới. Sách đạt danh hiệu sách bán chạy nhất theo danh sách của tờ New York Times và năm 1985 nó được đưa lên chương trình truyền hình miniseries của CBS với tên là Kane & Abel bắt đầu với Peter Strauss vai Rosnovski và Sam Neill vai Kane.',
	120000,
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
	'https://i.imgur.com/4eievki.jpg',
	N'Đắc nhân tâm – How to win friends and Influence People  của Dale Carnegie là quyển sách nổi tiếng nhất, bán chạy nhất và có tầm ảnh hưởng nhất của mọi thời đại. Tác phẩm đã được chuyển ngữ sang hầu hết các thứ tiếng trên thế giới và có mặt ở hàng trăm quốc gia. Đây là quyển sách duy nhất về thể loại self-help liên tục đứng đầu danh mục sách bán chạy nhất (best-selling Books) do báo The New York Times bình chọn suốt 10 năm liền. Riêng bản tiếng Anh của sách đã bán được hơn 15 triệu bản trên thế giới. Tác phẩm có sức lan toả vô cùng rộng lớn – dù bạn đi đến bất cứ nơi đâu, bất kỳ quốc gia nào cũng đều có thể nhìn thấy. Tác phẩm được đánh giá là quyển sách đầu tiên và hay nhất, có ảnh hưởng làm thay đổi cuộc đời của hàng triệu người trên thế giới. Không còn nữa khái niệm giới hạn, Đắc Nhân Tâm là nghệ thuật thu phục lòng người, là làm cho tất cả mọi người yêu mến mình. Đắc nhân tâm và cái Tài trong mỗi người chúng ta. Đắc Nhân Tâm trong ý nghĩa đó cần được thụ đắc bằng sự hiểu rõ bản thân, thành thật với chính mình, hiểu biết và quan tâm đến những người xung quanh để nhìn ra và khơi gợi những tiềm năng ẩn khuất nơi họ, giúp họ phát triển lên một tầm cao mới. Đây chính là nghệ thuật cao nhất về con người và chính là ý nghĩa sâu sắc nhất đúc kết từ những nguyên tắc vàng của Dale Carnegie. Quyển sách Đắc nhắn tâm là cuốn sách “đầu tiên và hay nhất mọi thời đại về nghệ thuật giao tiếp và ứng xử”, quyển sách đã từng mang đến thành công và hạnh phúc cho hàng triệu người trên khắp thế giới. Đắc Nhân Tâm là cuốn sách gối đầu giường về đối nhân xử thế.',
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
	150000,
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
	130000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S6',
	N'Muôn Kiếp Nhân Sinh',
	N'Nhà Xuất Bản Tổng hợp TP.HCM',
	N'Việt',
	null,
	N'“Muôn kiếp nhân sinh” là tác phẩm do Giáo sư John Vũ - Nguyên Phong viết từ năm 2017 và hoàn tất đầu năm 2020 ghi lại những câu chuyện, trải nghiệm tiền kiếp kỳ lạ từ nhiều kiếp sống của người bạn tâm giao lâu năm, ông Thomas – một nhà kinh doanh tài chính nổi tiếng ở New York. Những câu chuyện chưa từng tiết lộ này sẽ giúp mọi người trên thế giới chiêm nghiệm, khám phá các quy luật về luật Nhân quả và Luân hồi của vũ trụ giữa lúc trái đất đang gặp nhiều tai ương, biến động, khủng hoảng từng ngày. “Muôn kiếp nhân sinh” là một bức tranh lớn với vô vàn mảnh ghép cuộc đời, là một cuốn phim đồ sộ, sống động về những kiếp sống huyền bí, trải dài từ nền văn minh Atlantis hùng mạnh đến vương quốc Ai Cập cổ đại của các Pharaoh quyền uy, đến Hợp Chủng Quốc Hoa Kỳ ngày nay.',
	140000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S7',
	N'Nhà Giả Kim',
	N'Nhà Xuất Bản Văn Học',
	N'Việt',
	null,
	N'Tất cả những trải nghiệm trong chuyến phiêu du theo đuổi vận mệnh của mình đã giúp Santiago thấu hiểu được ý nghĩa sâu xa nhất của hạnh phúc, hòa hợp với vũ trụ và con người. Tiểu thuyết Nhà giả kim của Paulo Coelho như một câu chuyện cổ tích giản dị, nhân ái, giàu chất thơ, thấm đẫm những minh triết huyền bí của phương Đông. Trong lần xuất bản đầu tiên tại Brazil vào năm 1988, sách chỉ bán được 900 bản. Nhưng, với số phận đặc biệt của cuốn sách dành cho toàn nhân loại, vượt ra ngoài biên giới quốc gia, Nhà giả kim đã làm rung động hàng triệu tâm hồn, trở thành một trong những cuốn sách bán chạy nhất mọi thời đại, và có thể làm thay đổi cuộc đời người đọc.',
	50000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S8',
	N'Đọc Vị Bất Kỳ Ai',
	N'Nhà Xuất Bản Lao Động',
	N'Việt',
	null,
	N'Bạn băn khoăn không biết người ngồi đối diện đang nghĩ gì? Họ có đang nói dối bạn không? Đối tác đang ngồi đối diện với bạn trên bàn đàm phán đang nghĩ gì và nói gì tiếp theo? ĐỌC người khác là một trong những công cụ quan trọng, có giá trị nhất, giúp ích cho bạn trong mọi khía cạnh của cuộc sống. ĐỌC VỊ người khác để: Hãy chiếm thế thượng phong trong việc chủ động nhận biết điều cần tìm kiếm - ở bất kỳ ai bằng cách “thâm nhập vào suy nghĩ” của người khác. ĐỌC VỊ BẤT KỲ AI là cẩm nang dạy bạn cách thâm nhập vào tâm trí của người khác để biết điều người ta đang nghĩ. Cuốn sách này sẽ không giúp bạn rút ra các kết luận chung về một ai đó dựa vào cảm tính hay sự võ đoán. Những nguyên tắc được chia sẻ trong cuốn sách này không đơn thuần là những lý thuyết hay mẹo vặt chỉ đúng trong một số trường hợp hoặc với những đối tượng nhất định. Các kết quả nghiên cứu trong cuốn sách này được đưa ra dựa trên phương pháp S.N.A.P - cách thức phân tích và tìm hiểu tính cách một cách bài bản trong phạm vi cho phép mà không làm mếch lòng đối tượng được phân tích. Phương pháp này dựa trên những phân tích về tâm lý, chứ không chỉ đơn thuần dựa trên ngôn ngữ cử chỉ, trực giác hay võ đoán.',
	95000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S9',
	N'Cân bằng cảm xúc, cả lúc bão giông',
	N'Nhà Xuất Bản Thế Giới',
	N'Việt',
	null,
	N'Một ngày, chúng ta có khoảng 16 tiếng tiếp xúc với con người, công việc, các nguồn thông tin từ mạng xã hội, loa đài báo giấy… Việc này mang đến cho bạn vô vàn cảm xúc, cả tiêu cực lẫn tích cực. Bạn có thể thấy vui khi nhìn một em bé đến trường nhưng 5 phút sau đã nổi cơn tam bành khi bị đứa trẻ con đi xe đạp đâm sầm vào lại còn ăn vạ. Hoặc bạn rất dễ phát điên nếu như chỉ còn 5 giây nữa đèn giao thông chuyển từ đỏ sang xanh mà kẻ đi đằng sau bấm còi inh ỏi. Hay là, bạn thấy buồn chỉ vì hôm nay trời mưa man mác, mà vẫn phải ngồi trong văn phòng làm việc, bạn bi quan rằng tuổi trẻ thật buồn tẻ. Hãy thừa nhận đi! Ai trong số chúng ta cũng sẽ trải qua những điều này. Và cuốn sách này dạy bạn cách làm hòa với chính những tiêu cực bên trong mình',
	115000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S10',
	N'Chủ Nghĩa Khắc Kỷ - Phong Cách Sống Bản Lĩnh Và Bình Thản',
	N'Nhà Xuất Bản Công Thương',
	N'Việt',
	null,
	N'Bạn mong muốn điều gì từ cuộc sống này? Có thể câu trả lời của bạn là muốn có một người bạn đời biết quan tâm, một công việc tốt và một ngôi nhà đẹp, nhưng chúng thực ra chỉ là một số thứ bạn muốn có trong cuộc sống. Khi hỏi bạn mong muốn điều gì từ cuộc sống này, tôi đang hỏi theo nghĩa rộng nhất. Tôi không hỏi về những mục tiêu mà bạn đề ra khi thực hiện các hoạt động hằng ngày, mà tôi đang hỏi về mục tiêu lớn lao trong cuộc sống của bạn. Nói cách khác, trong số những thứ bạn có thể theo đuổi trong cuộc sống, thứ nào bạn tin là có giá trị nhất? Nhiều người sẽ khó lòng nêu ra được mục tiêu này. Họ biết mình muốn gì trong từng phút một hoặc thậm chí từng thập kỷ một trong suốt cuộc đời mình, nhưng họ chưa bao giờ dành thời gian để suy ngẫm về mục tiêu sống lớn lao của bản thân. Chuyện này có lẽ cũng dễ hiểu. Nền văn hóa của chúng ta vốn không khuyến khích mọi người nghĩ về những điều như vậy, mà chỉ tạo ra hết xao lãng này đến xao lãng khác, để chúng ta không bao giờ phải bận tâm đến chúng. Nhưng một mục tiêu lớn lao trong đời là thành phần đầu tiên của một triết lý sống. Nếu bạn không có một mục tiêu lớn lao trong đời, tức là bạn không có một triết lý sống chặt chẽ.',
	175000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S11',
	N'Hành Trình Về Phương Đông',
	N'Nhà xuất bản Trí Việt',
	N'Việt',
	null,
	N'Hành Trình Về Phương Đông mở ra một chân trời mới về Đông Tây gặp nhau, để khoa học Minh triết hội ngộ, để Hiện đại Cổ xưa giao duyên, để Đất Trời là một. Thế giới, vì vậy đã trở nên hài hòa hơn, rộng mở, diệu kỳ hơn và, do đó, nhân văn hơn. Hành Trình Về Phương Đông kể về những trải nghiệm của một đoàn khoa học gồm các chuyên gia hàng đầu của Hội Khoa Học Hoàng Gia Anh được cử sang Ấn Độ nghiên cứu về huyền học và những khả năng siêu nhiên của con người. Suốt hai năm trời rong ruổi khắp các đền chùa Ấn Độ, chúng kiến nhiều pháp luật, nhiều cảnh mê tín dị đoan, thậm chí lừa đảủa nhiều pháp sư, đạo sĩọ được tiếp xúc với những vị thế, họ được chứng kiến, trải nghiệm, hiểu biết sâu sắc về các khoa học cổ xưa và bí truyền của văn hóa Ấn Độ như Yoga, thiền định, thuật chiêm duyên, nghiệp báo, luật nhân quả, cõi sống và cõi chế',
	180000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S12',
	N'Đàn Ông Sao Hỏa Đàn Bà Sao Kim',
	N'Nhà Xuất Bản Hồng Đức',
	N'Việt',
	null,
	N'Ngày xửa ngày xưa, những người sao Hỏa và sao Kim đã gặp gỡ, yêu nhau và sống hạnh phúc bởi họ tôn trọng và chấp nhận mọi điều khác biệt. Rồi họ đến Trái Đất và chứng lãng quên đã xảy ra: Họ quên rằng họ đến từ những hành tinh khác Hiểu biết về giới tính giúp chúng ta thêm khoan dung và biết tha thứ khi ai đó không đáp lại theo cách mà ta mong đợi Tình chỉ đẹp khi còn dang dở Cưới nhau về nham nhở lắm em ơ',
	150000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S13',
	N'Payback Time - Ngày Đòi Nợ',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	N'"Trong chứng khoán và thị trường tài chính, dám tham gia đầu tư cũng là một thành công tâm lý ban đầu. Dù vậy, 95% nhà đầu tư Việt Nam thuộc nhóm nhà đầu tư nhỏ lẻ với vốn kiến thức tài chính vô cùng hạn chế. Họ tham gia vào thị trường chứng khoán với 100% ý chí và sự quyết tâm chiến thắng thị trường, nhưng thật không may mắn kết cục cuối cùng của họ luôn là sự thất bại và mất tiền. Bởi vì, chúng ta thường dễ dàng nghe theo các “lời khuyên miễn phí” đến từ bạn bè, những người môi giới, những người nghe ngóng thông tin từ các “đội lái” làm giá và thao túng chứng khoán. Chúng ta không biết làm thế nào để phân biệt hai khái niệm “giá cả – pricing” và “giá trị – value”. Hay mua mua, bán bán liên tục hàng ngày với việc dán mắt vào bảng điện tử, phân tích biểu đồ, đường trung bình giá… và mong đợi một vận may cổ phiếu cùng giá của nó sẽ đi theo suy đoán của mình?',
	135000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S14',
	N'Bạn Đắt Giá Bao Nhiêu?',
	N'Nhà Xuất Bản Thế Giới',
	N'Việt',
	null,
	N'Bạn Đắt Giá Bao Nhiêu? Câu trả lời này do chính bạn quyết định, chính bạn “định giá”. Hơn bốn mươi câu chuyện trong sách xoay quanh các chủ đề tình yêu, hôn nhân, gia đình, sự nghiệp… đến từ chính cuộc sống của tác giả và những người xung quanh, vừa thực tế lại vừa gợi mở, dễ dàng giúp chúng ta liên hệ với tình huống của chính mình. Với những câu chuyện đó, Vãn Tình hi vọng có thể giúp các cô gái thoát khỏi tình cảnh khó khăn, tìm lại bản ngã, sống cuộc đời theo cách mà mình mong muốn.',
	115000,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
INSERT INTO SACH VALUES
(
	'S15',
	N'Dám Bị Ghét',
	N'Nhà xuất bản Nhã Nam',
	N'Việt',
	null,
	N'Dám Bị Ghét Các mối quan hệ xã hội thật mệt mỏi. Cuộc sống sao mà nhạt nhẽo và vô nghĩa. Bản thân mình xấu xí và kém cỏi. Quá khứ đầy buồn đau còn tương lai thì mờ mịt. Yêu cầu của người khác thật khắc nghiệt và phi lý. TẠI SAO BẠN CỨ PHẢI SỐNG THEO KHUÔN MẪU NGƯỜI KHÁC ĐẶT RA? Dưới hình thức một cuộc đối thoại giữa Chàng thanh niên và Triết gia, cuốn sách trình bày một cách sinh động và hấp dẫn những nét chính trong tư tưởng của nhà tâm lý học Alfred Adler, người được mệnh danh là một trong “ba người khổng lồ của tâm lý học hiện đại”, sánh ngang với Freud và Jung. Khác với Freud cho rằng quá khứ và hoàn cảnh là động lực làm nên con người ta của hiện tại, Adler chủ trương “cuộc đời ta là do ta lựa chọn”, và tâm lý học Adler được gọi là “tâm lý học của lòng can đảm”.',
	120000,
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
	Anh ntext,
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
	Anh ntext,
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
	'dotuankiendotuankien@gmail.com',
	null,
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
	'dotuankiendotuankien@gmail.com',
	null,
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
	'dotuankiendotuankien@gmail.com',
	null,
	'NV1',
	'2020-01-10 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	null,
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
	'dotuankiendotuankien@gmail.com',
	null,
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
	'dotuankiendotuankien@gmail.com',
	null,
	'NV1',
	'2020-02-10 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	null,
	'NV1',
	'2020-01-25 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	null,
	'NV1',
	'2020-02-10 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	null,
	'NV1',
	'2020-02-20 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	null,
	'NV1',
	'2020-02-22 00:00:00',
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
	'dotuankiendotuankien@gmail.com',
	null,
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
	'dotuankiendotuankien@gmail.com',
	null,
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
	'dotuankiendotuankien@gmail.com',
	null,
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
	'dotuankiendotuankien@gmail.com',
	null,
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
	'dotuankiendotuankien@gmail.com',
	null,
	'NV1',
	'2020-01-01 00:00:00',
	null
)
GO
CREATE TABLE THEDOCGIA
(
	MaDocGia nvarchar(15) not null foreign key references DOCGIA(MaDocGia),
	NgayGiaHan datetime not null default getdate(),
	primary key (MaDocGia, NgayGiaHan),
	HanCu datetime,
	HanMoi datetime,
	NguoiLap nvarchar(15) not null foreign key references NHANVIEN(MaNhanVien)
)
GO
INSERT INTO THEDOCGIA VALUES
(
	'DG1',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG2',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG3',
	'2020-01-01 00:00:00',
	null,
	'2020-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG4',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG5',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG6',
	'2020-01-01 00:00:00',
	null,
	'2020-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG7',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG8',
	'2020-01-01 00:00:00',
	null,
	'2020-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG9',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG10',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG11',
	'2020-01-01 00:00:00',
	null,
	'2020-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG12',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG13',
	'2020-01-01 00:00:00',
	null,
	'2020-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG14',
	'2020-01-01 00:00:00',
	null,
	'2020-12-31 00:00:00',
	'NV1'
)
INSERT INTO THEDOCGIA VALUES
(
	'DG15',
	'2020-01-01 00:00:00',
	null,
	'2021-12-31 00:00:00',
	'NV1'
)

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
	Phi int,
	Phat int
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
	2000,
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
	2000,
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
	2000,
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
	2000,
	6000
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
	2000,
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
	2000,
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
	2000,
	5000
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
	2000,
	7500
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
	2000,
	3000
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
	2000,
	5000
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

CREATE PROCEDURE THEDOCGIALATE(@n INT)
AS
BEGIN
	SELECT THEDOCGIA.MaDocGia, DATEDIFF(DAY, getdate(), MAX(THEDOCGIA.HANMOI)) AS N'HAN' FROM THEDOCGIA
	GROUP BY THEDOCGIA.MaDocGia
	HAVING DATEDIFF(DAY, getdate(), MAX(THEDOCGIA.HANMOI)) < @n
	ORDER BY DATEDIFF(DAY, getdate(), MAX(THEDOCGIA.HANMOI))
END
GO



----Thêm dữ liệu rác
----NHANVIEN
--INSERT INTO NHANVIEN VALUES 
--(
--'NV21',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV22',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV23',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV24',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV25',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV26',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV27',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV28',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV29',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV30',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV31',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV32',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV33',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV34',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV35',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV36',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV37',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV38',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV39',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV40',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV41',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV42',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV43',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV44',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV45',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV46',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV47',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV48',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV49',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV50',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV51',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV52',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV53',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV54',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV55',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV56',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV57',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV58',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV59',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV60',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV61',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV62',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV63',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV64',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV65',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV66',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV67',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV68',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV69',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV70',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV71',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV72',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV73',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV74',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV75',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV76',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV77',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV78',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV79',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV80',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV81',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV82',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV83',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV84',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV85',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV86',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV87',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV88',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV89',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV90',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV91',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV92',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV93',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV94',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV95',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV96',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV97',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV98',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV99',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO NHANVIEN VALUES 
--(
--'NV100',
--N'Nguyễn Văn A',
--'000000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'example@gmail.com',
--'dd4b21e9ef71e1291183a46b913ae6f2',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO

----SACH
--INSERT INTO SACH VALUES 
--(
--'S31',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S32',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S33',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S34',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S35',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S36',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S37',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S38',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S39',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S40',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S41',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S42',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S43',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S44',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S45',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S46',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S47',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S48',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S49',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S50',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S51',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S52',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S53',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S54',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S55',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S56',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S57',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S58',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S59',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S60',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S61',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S62',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S63',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S64',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S65',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S66',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S67',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S68',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S69',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S70',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S71',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S72',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S73',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S74',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S75',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S76',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S77',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S78',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S79',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S80',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S81',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S82',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S83',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S84',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S85',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S86',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S87',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S88',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S89',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S90',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S91',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S92',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S93',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S94',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S95',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S96',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S97',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S98',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S99',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO SACH VALUES 
--(
--'S100',
--N'Sách A',
--N'Nhà xuất bản A',
--N'Ngôn ngữ A',
--null,
--N'Mô tả A',
--0,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO

----DOCGIA
--INSERT INTO DOCGIA VALUES 
--(
--'DG31',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG32',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG33',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG34',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG35',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG36',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG37',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG38',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG39',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG40',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG41',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG42',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG43',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG44',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG45',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG46',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG47',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG48',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG49',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG50',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG51',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG52',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG53',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG54',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG55',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG56',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG57',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG58',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG59',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG60',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG61',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG62',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG63',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG64',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG65',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG66',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG67',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG68',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG69',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG70',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG71',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG72',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG73',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG74',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG75',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG76',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG77',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG78',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG79',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG80',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG81',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG82',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG83',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG84',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG85',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG86',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG87',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG88',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG89',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG90',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG91',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG92',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG93',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG94',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG95',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG96',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG97',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG98',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG99',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
--INSERT INTO DOCGIA VALUES 
--(
--'DG100',
--N'Nguyễn Văn B',
--'00000000',
--'2000-01-01',
--N'Hà Nội',
--'0000000000',
--'ex@gmail.com',
--null,
--'NV1', 
--'2020-01-01 00:00:00',
--null
--)
--GO
----PHIEUMUON


