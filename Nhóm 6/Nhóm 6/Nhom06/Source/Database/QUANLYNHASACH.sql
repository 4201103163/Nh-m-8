CREATE DATABASE QLNS
GO

USE QLNS
GO

--Quan ly nha sach
--Nhan vien
CREATE TABLE NhanVien
(
	NV_id NVARCHAR(50) PRIMARY KEY,
	NV_name NVARCHAR(100) NOT NULL,
	NV_birthday DATE,
	NV_datework DATE,
	NV_number NVARCHAR(100),
	NV_address NVARCHAR(100),	
	NV_note VARCHAR(100)			
)
GO

--Khach hang
CREATE TABLE KhachHang
(
	KH_id NVARCHAR(50) PRIMARY KEY,
	KH_name NVARCHAR(100) NOT NULL,
	KH_number NVARCHAR(100),
	KH_mail NVARCHAR(100),
	KH_scores INT NOT NULL DEFAULT 0,
	KH_note NVARCHAR(100)	
)
GO

--Tai khoan
CREATE TABLE TaiKhoan
(	
	NV_id NVARCHAR (50) PRIMARY KEY, 		
	Username NVARCHAR(50) NOT NULL,
	Pass NVARCHAR(50) NOT NULL,	 	
	Acc_Type NVARCHAR(50) NOT NULL,	
	FOREIGN KEY (NV_id) REFERENCES dbo.NhanVien(NV_id)	
)
GO

CREATE TABLE NhomTheLoai
(
	NTL_id NVARCHAR(50) PRIMARY KEY,
	NTL_name NVARCHAR(100) NOT NULL,
	NTL_note NVARCHAR(100)
)
GO
CREATE TABLE NhomTacGia
(
	NTG_id NVARCHAR(50) PRIMARY KEY,
	NTG_name NVARCHAR(100) NOT NULL,
	NTG_note NVARCHAR(100)
)
GO
CREATE TABLE NhomNhaXuatBan
(
	NXB_id NVARCHAR(50) PRIMARY KEY,
	NXB_name NVARCHAR(100) NOT NULL,
	NXB_number NVARCHAR(100) NOT NULL,
	NXB_address NVARCHAR(100) NOT NULL,
	NXB_note NVARCHAR(100) NULL
)
GO
CREATE TABLE NhomNhaCungCap
(
	NCC_id NVARCHAR(50) PRIMARY KEY,
	NCC_name NVARCHAR(100) NOT NULL,
	NCC_number NVARCHAR(100) NOT NULL,
	NCC_address NVARCHAR(100) NOT NULL,
	NCC_note NVARCHAR(100) NULL
)
GO
CREATE TABLE DSSach
(
	Sach_id NVARCHAR(50) PRIMARY KEY,
	Sach_name NVARCHAR(100) NOT NULL,	
	Sach_theloai NVARCHAR(100) NOT NULL,	 	
	Sach_tacgia NVARCHAR(100) NOT NULL,	
	Sach_nxb INT NOT NULL,			
	Sach_gianhap INT NOT NULL,
	Sach_giaban INT NOT NULL,
	Sach_number INT NOT NULL DEFAULT 0								
)
GO

--Hoa don
CREATE TABLE HoaDon
 (
	HD_id NVARCHAR(50) PRIMARY KEY,
	HD_date DATETIME NOT NULL,	
	NV_id NVARCHAR(50),	
	KH_id NVARCHAR(50),
	HD_money FLOAT NOT NULL DEFAULT 0,
	HD_note NVARCHAR(100),
	FOREIGN KEY (NV_id) REFERENCES dbo.NhanVien(NV_id),
	FOREIGN KEY (KH_id) REFERENCES dbo.KhachHang(KH_id)
)
GO
CREATE TABLE CTHoaDon
 (
	HD_id NVARCHAR(50) NOT NULL,	
	Sach_id NVARCHAR(50) NOT NULL,
	Sach_name NVARCHAR(100) NOT NULL,
	CTHD_cost FLOAT NOT NULL DEFAULT 0,
	Sach_CTHD_count INT NOT NULL DEFAULT 0,	
	CTHD_money FLOAT NOT NULL DEFAULT 0,
	PRIMARY KEY(HD_id, Sach_id),
	FOREIGN KEY (HD_id) REFERENCES dbo.HoaDon(HD_id),
	FOREIGN KEY (Sach_id) REFERENCES dbo.DSSach(Sach_id)
 )
GO

--Phieu nhap
CREATE TABLE PhieuNhap
(	
	PN_id NVARCHAR(50) PRIMARY KEY,
	PN_date DATETIME NOT NULL,	
	NV_id NVARCHAR(50),			
	PN_note NVARCHAR(100),	
	FOREIGN KEY (NV_id) REFERENCES dbo.NhanVien(NV_id)		
)
GO
CREATE TABLE CTPhieuNhap
(	
	PN_id NVARCHAR(50) NOT NULL,
	Sach_id NVARCHAR(50) NOT NULL,
	Sach_name NVARCHAR(50) NOT NULL,	
	Sach_giaban FLOAT NOT NULL,
	NXB_name NVARCHAR(50) NOT NULL,
	NCC_name NVARCHAR(50) NOT NULL,
	NTL_name NVARCHAR(50) NOT NULL,
	NTG_name NVARCHAR(50) NOT NULL,	
	PN_amount INT NOT NULL DEFAULT 0,	
	PRIMARY KEY(PN_id, Sach_id),
	FOREIGN KEY (PN_id) REFERENCES dbo.PhieuNhap(PN_id),
	FOREIGN KEY (Sach_id) REFERENCES dbo.DSSach(Sach_id)			
)
GO

--Bao Cao Ton
CREATE TABLE BaoCaoTon
(
	BCT_id NVARCHAR(50) NOT NULL,	
	NV_id NVARCHAR(50) NOT NULL,
	BCT_date DATETIME NOT NULL,
	BCT_TonDau INT NOT NULL, 
	BCT_TonCuoi INT NOT NULL,	
	BCT_note NVARCHAR(100),	
	PRIMARY KEY(BCT_id),
	FOREIGN KEY (NV_id) REFERENCES dbo.NhanVien(NV_id)	
)
GO
CREATE TABLE CTBaoCaoTon
(
	BCT_id NVARCHAR(50) NOT NULL,	
	Sach_id NVARCHAR(50) NOT NULL,
	Sach_name NVARCHAR(50) NOT NULL,	
	Sach_giaban FLOAT NOT NULL,
	NXB_name NVARCHAR(50) NOT NULL,
	NCC_name NVARCHAR(50) NOT NULL,
	NTL_name NVARCHAR(50) NOT NULL,
	NTG_name NVARCHAR(50) NOT NULL,	
	PRIMARY KEY(BCT_id, Sach_id),
	FOREIGN KEY (BCT_id) REFERENCES dbo.BaoCaoTon(BCT_id),	
	FOREIGN KEY (Sach_id) REFERENCES dbo.DSSach(Sach_id)
)
GO

--Bao Cao No
CREATE TABLE BaoCaoNo
(
	BCN_id NVARCHAR(50) NOT NULL,	
	NV_id NVARCHAR(50) NOT NULL,
	BCN_date DATETIME NOT NULL,
	BCN_TonDau INT NOT NULL, 
	BCN_TonCuoi INT NOT NULL,	
	BCN_note NVARCHAR(100),	
	PRIMARY KEY(BCN_id),
	FOREIGN KEY (NV_id) REFERENCES dbo.NhanVien(NV_id)	
)
GO
CREATE TABLE CTBaoCaoNo
(
	BCN_id NVARCHAR(50) NOT NULL,	
	KH_id NVARCHAR(50) NOT NULL,	
	PRIMARY KEY(BCN_id, KH_id),
	FOREIGN KEY (BCN_id) REFERENCES dbo.BaoCaoNo(BCN_id),	
	FOREIGN KEY (KH_id) REFERENCES dbo.KhachHang(KH_id)
)
GO

--Nhan vien
INSERT INTO dbo.NhanVien(NV_id, NV_name, NV_birthday, NV_datework, NV_number, NV_address, NV_note)
VALUES	(N'ql001', N'Phạm Hữu Trí', CONVERT(DATETIME,'12/03/1990',103),CONVERT(DATETIME,'12/03/2017',103), N'0167342721',N'34 Phan Đăng Lưu',NULL),
		(N'ql002', N'Nguyễn Thị Phương Trinh',CONVERT(DATETIME,'12/03/1991',103),CONVERT(DATETIME,'12/03/2016',103), N'0983256082',N'540 Trần Hưng Đạo',NULL),
		(N'ql003', N'Nguyễn Thành Được',CONVERT(DATETIME,'12/03/1991',103),CONVERT(DATETIME,'12/03/2015',103), N'0903007718',N'1256 – 1258 Võ Văn Kiệt',NULL),
		(N'nv004', N'Trần Thiên Hải',CONVERT(DATETIME,'12/03/1992',103),CONVERT(DATETIME,'12/03/2017',103), N'0983052791',N'367-367 A Phan Đình Phùng',NULL),
		(N'nv005', N'Nguyễn Thị Hường',CONVERT(DATETIME,'12/03/1990',103),CONVERT(DATETIME,'12/03/2016',103), N'0977905598',N'207 – 209 Phan Đăng Lưu',NULL),
		(N'nv006', N'Phạm Gia Tuệ',CONVERT(DATETIME,'12/03/1993',103),CONVERT(DATETIME,'12/03/2014',103), N'0983526715',N'476 Hai Bà Trưng',NULL),
		(N'nv007', N'Phạm Hữu Tuệ',CONVERT(DATETIME,'12/03/1993',103),CONVERT(DATETIME,'12/03/2013',103), N'0982536715',N'199 Nguyễn Thị Minh Khai',NULL),
		(N'nv008', N'Nguyễn Thúy Ngân',CONVERT(DATETIME,'12/03/1995',103),CONVERT(DATETIME,'12/03/2015',103), N'0983526517',N'772 B Sư Vạn Hạnh',NULL),
		(N'ql009', N'Nguyễn Thị Hồng Nhung',CONVERT(DATETIME,'12/03/1996',103),CONVERT(DATETIME,'12/03/2016',103), N'0919191991',N'179-181 Sư Vạn Hạnh',NULL),
		(N'nv0010', N'Võ Quốc Duy',CONVERT(DATETIME,'12/03/1989',103),CONVERT(DATETIME,'12/09/2017',103), N'0919191919',N'222 Sư Vạn Hạnh',NULL),
		(N'nv0011', N'Phạm Ánh Xuân',CONVERT(DATETIME,'12/03/1988',103),CONVERT(DATETIME,'12/10/2015',103), N'01298765432', N'12/12 Dan Chu',NULL),
	    (N'nv0012', N'Nguyễn Minh Ngọc',CONVERT(DATETIME,'12/03/1987',103),CONVERT(DATETIME,'12/05/2016',103), N'098399999', N'1/92 Lac Long Quan',NULL),
		(N'nv0013', N'Trương Việt Hoa',CONVERT(DATETIME,'12/03/1986',103),CONVERT(DATETIME,'12/06/2017',103), N'0166582802', N'12 Pham Van Dong',NULL),
		(N'nv0014', N'Võ Văn Ngân',CONVERT(DATETIME,'12/03/1989',103),CONVERT(DATETIME,'12/09/2018',103), N'0966737562', N'19/6/2 Nguyen Van Troi',NULL),
		(N'nv0015', N'Vũ Văn Công',CONVERT(DATETIME,'12/03/1999',103),CONVERT(DATETIME,'12/12/2019',103), N'0983977628', N'123 Minh Phung',NULL),
		(N'nv0016', N'Nguyễn Quang Phúc',CONVERT(DATETIME,'12/03/1997',103),CONVERT(DATETIME,'12/11/2011',103), N'0909008364', N'259 Ly Thuong Kiet',NULL),
		(N'nv0017', N'Đỗ Như Ý',CONVERT(DATETIME,'12/03/1995',103),CONVERT(DATETIME,'12/01/2010',103), N'0167893097', N'123 Au Co',NULL),
		(N'nv0018', N'Nguyễn Quốc Trung',CONVERT(DATETIME,'12/03/1996',103),CONVERT(DATETIME,'12/02/2012',103), N'0963231321', N'15 Vo Van Tan',NULL),
		(N'nv0020', N'Lê Đình Duy',CONVERT(DATETIME,'12/03/1981',103),CONVERT(DATETIME,'12/03/2013',103), N'0123575666', N'120 Hoang Hoa Tham',NULL)

GO
SELECT*FROM NhanVien

--Khach hang
INSERT INTO dbo.KhachHang(KH_id, KH_name, KH_number, KH_mail, KH_scores, KH_note)
VALUES ( N'kh001', N'Lê An', N'0919191919', N'lean@gmail.com', 0, NULL),
	   ( N'kh002', N'Nguyễn Phú Trung', N'0167342721', N'nguyenphutrung@gmail.com', 0, NULL),
	   ( N'kh003', N'Đoàn Minh Tân', N'0983256082', N'doanminhtan@gmail.com', 100, NULL),
	   ( N'kh004', N'Trần Thiện Minh', N'0913206582', N'tranthienminh@gmail.com', 200, NULL),
	   ( N'kh005', N'Võ Quốc Huy', N'0903007718', N'voquochuy@gmail.com', 0, NULL),
	   ( N'kh006', N'Phạm Minh Hiệp', N'0977905598', N'phamminhhiep@gmail.com', 500, NULL),
	   ( N'kh007', N'Lê Ngọc Thảo', N'0123583779', N'lengocthao@gmail.com', 0, NULL),
	   ( N'kh008', N'Hồ Thị Hoa', N'0166333696', N'hothihoa@gmail.com', 300, NULL),
	   ( N'kh009', N'Nguyễn Võ Toàn', N'0983052791', N'nguyenvotoan@gmail.com', 100, NULL),		
	   ( N'kh0010', N'Đỗ Minh Đăng', N'0983526715', N'dominhdang@gmail.com', 400, NULL),
	   ( N'kh0011', N'Lê Đình Duy', N'0919191919', N'ledinhduy@gmail.com', 0, NULL),
	   ( N'kh0012', N'Nguyễn Quốc Trung', N'0167342721', N'nguyenquoctrung@gmail.com', 0, NULL),
	   ( N'kh0013', N'Võ Văn Ngân', N'0983256082', N'vovanngan@gmail.com', 100, NULL),
	   ( N'kh0014', N'Nguyễn Quang Phúc', N'0913206582', N'nguyenquangphuc@gmail.com', 200, NULL),
	   ( N'kh0015', N'Nguyễn Hải Sơn', N'0903007718', N'nguyenhaison@gmail.com', 0, NULL),
	   ( N'kh0016', N'Đỗ Anh Tuấn', N'0977905598', N'doanhtuan@gmail.com', 500, NULL),
	   ( N'kh0017', N'Nguyễn Thị Phương Trinh', N'0123583779', N'nguyenthiphuongtrinh@gmail.com', 0, NULL),
	   ( N'kh0018', N'Nguyễn Thị Hồng Nhung', N'0166333696', N'nguyenthihongnhung@gmail.com', 300, NULL),
	   ( N'kh0019', N'Trương Việt Hoa', N'0983052791', N'truongviethoa@gmail.com', 100, NULL),		
	   ( N'kh0020', N'Nguyễn Thúy Ngân', N'0983526715', N'nguyenthuyngan@gmail.com', 400, NULL)
GO
SELECT*FROM  KhachHang

--Tai khoan
INSERT INTO dbo.TaiKhoan(NV_id, Username, Pass ,Acc_Type)
VALUES	(N'ql001',N'Triph',999,N'Admin'),
		(N'ql002',N'Trinhntp',888,N'Admin'),
		(N'ql003',N'Duocnt',888,N'Admin'),
		(N'nv004',N'Haitt',888,N'User'),
		(N'nv005',N'Huongnt',999,N'User'),
		(N'nv006',N'Tuepg',888,N'User'),
		(N'nv007',N'Tueph',888,N'User'),
		(N'nv008',N'Ngannt',888,N'User'),
		(N'ql009',N'Nhungnth',999,N'Admin'),
		(N'nv0010',N'Duyvq',888,N'User')		
	  		
GO
SELECT*FROM TaiKhoan

--Nhom the loai
INSERT INTO dbo.NhomTheLoai(NTL_id, NTL_name, NTL_note)
VALUES	(N'tl001',N'Sách Kinh tế',NULL),
		(N'tl002',N'Sách Thiếu nhi',NULL),
		(N'tl003',N'Nuôi dạy con',NULL),
		(N'tl004',N'Truyện kinh dị',NULL),
		(N'tl005',N'Tiểu thuyết',NULL),
		(N'tl006',N'Truyện ngắn',NULL),
		(N'tl007',N'Kỹ năng sống',NULL),	  
		(N'tl008',N'Sách nấu ăn',NULL),	  
		(N'tl009',N'Tâm lý',NULL),	  
		(N'tl0010',N'Sách Tin học',NULL),	
		(N'tl0011',N'Văn học 1',NULL),	
		(N'tl0012',N'Văn học 2',NULL),	
		(N'tl0013',N'Truyện tranh',NULL),	
		(N'tl0014',N'Ngoại ngữ',NULL),	
		(N'tl0015',N'Bán hàng',NULL)		
GO
SELECT*FROM NhomTheLoai

--Nhom tac gia
INSERT INTO dbo.NhomTacGia(NTG_id, NTG_name, NTG_note)
VALUES	(N'tg001',N'Vương Vũ Chấn',NULL),
		(N'tg002',N'Phan Cuồng',NULL),
		(N'tg003',N'Đỗ Phấn',NULL),
		(N'tg004',N'Paulo Coelko',NULL),
		(N'tg005',N'Trần Hoàng Ngân',NULL),
		(N'tg006',N'Nam Cao',NULL),
		(N'tg007',N'Lý Lan',NULL),	  
		(N'tg008',N'Kiều Bích Hậu',NULL),	  
		(N'tg009',N'Born',NULL),	  
		(N'tg0010',N'Nguyễn Tiến Dũng',NULL),	
		(N'tg0011',N'Nguyễn Du',NULL),	
		(N'tg0012',N'Tô Hoài',NULL),	
		(N'tg0013',N'Trần Chiến',NULL),	
		(N'tg0014',N'Hamlet Trương',NULL),	
		(N'tg0015',N'Iris Cao',NULL),	
		(N'tg0016',N'Nguyễn Nhật Ánh',NULL),	
		(N'tg0017',N'Phan Ý Yên',NULL),
		(N'tg0018',N'Phạm Phương',NULL),
		(N'tg0019',N'Stephen Petranek',NULL),
		(N'tg0020',N'Phan Việt',NULL)
GO
SELECT*FROM NhomTacGia

--Nhom nha xuat ban
INSERT INTO dbo.NhomNhaXuatBan(NXB_id, NXB_name, NXB_address, NXB_number, NXB_note)
VALUES	(N'nxb001',N'NHÀ XUẤT BẢN TRẺ',N'161 B Lý Chính Thắng – Phường 7 – Quận 3 – Thành phố Hồ Chí Minh',N'(84.8) 39316289',NULL),
		(N'nxb002',N'NHÀ XUẤT BẢN KIM ĐỒNG',N'55 Quang Trung, Hà Nội, Việt Nam',N'(04)3 9428653',NULL),
		(N'nxb003',N'NHÀ XUẤT BẢN TỔNG HỢP TPHCM',N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP.HCM',N'(84.8) 38 225 340',NULL),
		(N'nxb004',N'NHÀ XUẤT BẢN CHÍNH TRỊ QUỐC GIA',N'Số 24 Quang Trung – Hoàn Kiếm – Hà Nội',N'0.4.3822-1633',NULL),
		(N'nxb005',N'NHÀ XUẤT BẢN GIÁO DỤC',N'81 Trần Hưng Đạo – TP. Hà Nội',N'04.38220801',NULL),
		(N'nxb006',N'NHÀ XUẤT BẢN ĐẠI HỌC QUỐC GIA TPHCM',N'Số 3 Công trường Quốc tế, P.6, Q.3, TP. Hồ Chí Minh',N'08.38239170',NULL),
		(N'nxb007',N'NHÀ XUẤT BẢN ĐẠI HỌC SƯ PHẠM',N'136 Đường Xuân Thuỷ, Quận Cầu Giấy, Thành phố Hà Nội',N'043.7547.735',NULL),	  
		(N'nxb008',N'NHÀ XUẤT BẢN ĐẠI HỌC QUỐC GIA HÀ NỘI',N'16, Hàng Chuối, P. Phạm Đình Hổ, Q. Hai Bà Trưng, Tp. Hà Nội',N' (04) 39714899',NULL),  
		(N'nxb009',N'NHÀ XUẤT BẢN LAO ĐỘNG',N'175 Giảng Võ – Đống Đa – Hà Nội',N'043.8515380',NULL),
		(N'nxb0010',N'NHÀ XUẤT BẢN TƯ PHÁP',N'Số 35 Trần Quốc Toản – Hoàn Kiếm – Hà Nội',N'04.62632078',NULL),
		(N'nxb0011',N'NHÀ XUẤT BẢN ĐẠI HỌC BÁCH KHOA',N'số 98 Hoàng Quốc Việt, Nghĩa Đô, Cầu Giấy, Hà Nội',N'08.38239172',NULL),
		(N'nxb0012',N'NHÀ XUẤT BẢN GIAO THÔNG VẬN TẢI',N'80B Trần Hưng Đạo, Hoàn Kiếm, Hà Nội',N'84-4-3.9423346',NULL),
		(N'nxb0013',N'NHÀ XUẤT BẢN TRI THỨC',N'53 Nguyễn Du - Quận Hai Bà Trưng - Hà Nội',N'844 3945 4661',NULL),
		(N'nxb0014',N'NHÀ XUẤT BẢN VĂN HÓA SÀI GÒN',N'90 Ký Con P.Nguyễn Thái Bình,, Quận 1, TP Hồ Chí Minh',N'(08) 39142890',NULL),
		(N'nxb0015',N'NHÀ XUẤT BẢN VĂN HÓA THÔNG TIN',N'43 Lò Đúc – Hà Nội',N'(04) 39719531',NULL),
		(N'nxb0016',N'NHÀ XUẤT BẢN VĂN HỌC',N'18, Nguyễn Trường Tộ, P. Trúc Bạch, Q. Ba Đình, Tp. Hà Nội',N'(84-24) 37 161 518',NULL),
		(N'nxb0017',N'NHÀ XUẤT BẢN HỘI NHÀ VĂN',N'Số 65 Nguyễn Du – Hà Nội',N'04.38222135',NULL),
		(N'nxb0018',N'NHÀ XUẤT BẢN QUÂN ĐỘI NHÂN DÂN',N'23 Lý Nam Đế, Hà Nội',N'(043)8455766',NULL),
		(N'nxb0019',N'NHÀ XUẤT BẢN PHỤ NỮ',N'39 Hàng Chuối, Hà Nội',N'(04) 39710717',NULL),
		(N'nxb0020',N'NHÀ XUẤT BẢN THÀNH PHỐ HỒ CHÍ MINH',N'62, Nguyễn Thị Minh Khai, Q. 1, Tp. Hồ Chí Minh',N'(84-8) 38 256 713',NULL)
GO
SELECT*FROM NhomNhaXuatBan

--Nhom nha cung cap
INSERT INTO dbo.NhomNhaCungCap(NCC_id, NCC_name, NCC_address, NCC_number, NCC_note)
VALUES	(N'ncc001',N'Công Ty TNHH Thương Mại An Huy Vina',N'Quốc Lộ 18, Từ Phong, Cách Bi, Quế Võ,Bắc Ninh', N'(0241) 2203333', NULL),
		(N'ncc002',N'Công Ty Cổ Phần Tổng Hợp Việt Dương',N'395 Nguyễn Trãi, Võ Cường, Tp. Bắc Ninh,Bắc Ninh', N'(0241) 3812262', NULL),
		(N'ncc003',N'Công Ty Cổ Phần SBI',N'Số 50, KP3, TT. Phố Mới, Quế Võ,Bắc Ninh', N'(075) 3822389', NULL),
		(N'ncc004',N'Công Ty Cổ Phần Sách - Thiết Bị Bến Tre',N'3 Đồng Khởi, P. 3, Tp. Bến Tre,Bến Tre', N'(0650) 3756667', NULL),
		(N'ncc005',N'Công Ty TNHH Thương Mại Và Dịch Vụ Hà Vũ',N'100 Nguyễn Văn Tiết,TT. Lái Thiêu, TX. Thuận An,Bình Dương', N'(0650) 3636982', NULL),
		(N'ncc006',N'Công Ty TNHH MTV Thương Mại - Dịch Vụ Đa Lộc',N'17 Thích Quảng Đức, P. Phú Hòa, Tp. Thủ Dầu Một,Bình Dương', N'(08)975612383', NULL),
		(N'ncc007',N'Công Ty TNHH MTV Hoàng Liên Việt',N'Số 92, Đường ĐX 095, P. Hiệp An, Tp. Thủ Dầu Một,Bình Dương', N'(056) 3824144', NULL),
		(N'ncc008',N'Công Ty TNHH MTV Thương Mại Dịch Vụ Kiến Ong',N'41/1A, Kp. Đông Tác, P. Tân Đông Hiệp, TX. Dĩ An,Bình Dương', N'(062) 3815799', NULL),
		(N'ncc009',N'Công Ty TNHH Văn Phòng Phẩm Như ý',N'48/163/58/10 Đường Hoàng Hoa Thám, Tổ 110, KP 8, P. Hiệp Thành, Tp. Thủ Dầu Một,Bình Dương', N'(0780) 2240810', NULL),
		(N'ncc0010',N'Công Ty TNHH MTV In Ấn Văn Phòng Phẩm Danh Tiếng Phát',N'428A Cách Mạng Tháng Tám, P. Phú Cường, TP. Thủ Dầu Một,Bình Dương', N'(071) 3527823', NULL),
		(N'ncc0011',N'Công Ty TNHH First Stationery Việt Nam',N'Khu Công Nghiệp Việt Nam-Singapore, 52 Đại Lộ Độc Lập, H. Thuận An,Bình Dương', N'(0511) 3821147', NULL),
		(N'ncc0012',N'Công Ty TNHH Fuda Việt Nam',N'D10,X. Thuận Giao, H. Thuận An,Bình Dương', N'0914 468 408', NULL),
		(N'ncc0013',N'Công Ty TNHH Toàn Trẻ',N'Y7B - KP4, Phường Tân Hiệp, Biên Hòa,Đồng Nai', N'(0511) 3531790', NULL),
		(N'ncc0014',N'Công Ty TNHH MTV Thương Mại Dịch Vụ Hoàng Duy Khoa',N'F23B, P. Tân Hiệp, Tp. Biên Hòa,Đồng Nai', N'(0511) 3614602', NULL),
		(N'ncc0015',N'Công Ty TNHH Một Thành Viên Hoài Anh',N'30D1 Cách Mạng Tháng Tám, P. Quang Vinh, Tp. Biên Hòa,Đồng Nai', N'(0511) 3750017', NULL),
		(N'ncc0016',N'Công Ty TNHH Hồng Chuyên',N'45 Mai Lão Bạng, Q. Hải Châu,Tp. Đà Nẵng', N'(061) 8878240', NULL),
		(N'ncc0017',N'Công Ty Cổ Phần Quảng Cáo & Dịch Vụ Văn Hóa Đà Nẵng',N'78-80 Hùng Vương, P. Hải Châu 1, Q. Hải Châu,Tp. Đà Nẵng', N'(061) 3880574', NULL),
		(N'ncc0018',N'Công Ty Cổ Phần Thương Mại Dịch Vụ Sao Ma',N'112B Đường 30/4, P. An Phú, Q. Ninh Kiều,Tp. Cần Thơ', N'(061) 3843000', NULL),
		(N'ncc0019',N'Công Ty TNHH Thương Mại Dịch Vụ Đông Anh',N'12 Trần Bạch Đằng, An Khánh, Ninh Kiều,TP. Cần Thơ', N'(061) 3883995', NULL),
		(N'ncc0020',N'Doanh Nghiệp Tư Nhân Nam Thạnh',N'82B Trưng Trắc, X. Đức Thắng, Tp. Phan Thiết,Bình Thuận', N'(061) 3821974', NULL)
GO
SELECT*FROM NhomNhaCungCap

--Danh sach sach
INSERT INTO dbo.DSSach(Sach_id ,Sach_name, Sach_theloai, Sach_tacgia, Sach_nxb, Sach_gianhap, Sach_giaban, Sach_number)
VALUES  (N's001', N'Vua Sư tử', N'Sách Thiếu nhi',N'Disney', 1990, 20000, 36000, 150),
		(N's002', N'Bí mật của đôi cánh', N'Sách Thiếu nhi',N'Disney', 1990, 20000, 39000, 150),
		(N's003', N'Dũng sĩ Hercules', N'Sách Thiếu nhi',N'Disney', 1990, 20000, 36000, 150),
		(N's004', N'Bé tập vẽ', N'Sách Thiếu nhi',N'Hoa Mai', 1990, 20000, 18000, 150),
		(N's005', N'Chàng thợ săn và Nàng công chúa', N'Sách Thiếu nhi',N'Hoa Mai', 1990, 20000, 19000, 150),
		(N's006', N'Em Tìm Hiểu Môi Trường - Mẹ Và Con Một Số Loài Vật', N'Sách Thiếu nhi',N'Hoa Mai', 1990, 20000, 18000, 150),
		(N's007', N'Thực chiến cân thị trường', N'Sách Kinh tế',N'Đỗ Thanh Tịnh', 1990, 20000, 60000, 150),
		(N's008', N'Khởi Nghiệp 0 Đồng - Chinh Phục Triệu Đô', N'Sách Kinh tế',N'Đỗ Thanh Tịnh', 1990, 20000, 60000, 150),
		(N's009', N'8 Bước Dẫn Đến Thành Công Của Các Nhà Doanh Nghiệp', N'Sách Kinh tế',N'Đỗ Thanh Tịnh', 1990, 20000, 24000, 150),
		(N's0010', N'Để được trong dụng & Đãi ngộ', N'Sách Kinh tế',N'Brian Tracy', 1990, 20000, 34000, 150),
		(N's0011', N'Thuật tổ chức cuộc họp', N'Sách Kinh tế',N'Brian Tracy', 1990, 20000, 47000, 150),
		(N's0012', N'Thuật Thiết Lập Chiến Lược Kinh Doanh', N'Sách Kinh tế',N'Brian Tracy', 1990, 20000, 47000, 150),
		(N's0013', N'Chăm sóc sức khỏe thai phụ', N'Nuôi dạy con',N'BS. Nguyễn Lân Đính', 1990, 20000, 32000, 150),
		(N's0014', N'Chăm Sóc Và Nuôi Dạy Con Toàn Tập', N'Nuôi dạy con',N'BS. Nguyễn Lân Đính', 1990, 20000, 128000, 150),
		(N's0015', N'Cẩm Nang Chăm Sóc Sức Khỏe Và Luyện Thể Hình Đẹp', N'Nuôi dạy con',N'BS. Nguyễn Lân Đính', 1990, 20000, 86000, 150),
		(N's0016', N'Nuôi Dạy Con Kiểu Nhật Bản (Dành Cho Ông Bố Bận Rộn)', N'Nuôi dạy con',N'Akehashi Daiji', 1990, 20000, 79000, 150),
		(N's0017', N'Nuôi Dạy Con Kiểu Nhật Bản - Tập 2', N'Nuôi dạy con',N'Akehashi Daiji', 1990, 20000, 68000, 150),
		(N's0018', N'Nuôi Dạy Con Kiểu Nhật Bản', N'Nuôi dạy con',N'Akehashi Daiji', 1990, 20000, 76000, 150),
		(N's0019', N'Việt Nam Miền Ngon (Song Ngữ)', N'Sách Nấu ăn',N'Phan Đăng Lưu', 1990, 20000, 78000, 150),
		(N's0020', N'Ăn gì cũng dễ thương', N'Sách Nấu ăn',N'Phan Đăng Lưu', 1990, 20000, 180000, 150),
		(N's0021', N'Bí mật chocolate', N'Sách Nấu ăn',N'Phan Đăng Lưu', 1990, 20000, 120000, 150),	
		(N's0022', N'Bếp thời hiện đại', N'Sách Nấu ăn',N'Nguyễn Kim Ngân', 1990, 20000, 90000, 150),	
		(N's0023', N'Mẹ nấu ăn ngon tuyệt', N'Sách Nấu ăn',N'Nguyễn Kim Ngân', 1990, 20000, 23000, 150),	
		(N's0024', N'120 món ăn ngon Việt Nam', N'Sách Nấu ăn',N'Nguyễn Kim Ngân', 1990, 20000, 130000, 150),	
		(N's0025', N'Đắc nhân tâm', N'Tâm Lý',N'Lương Trần', 1990, 20000, 127000, 150),	
		(N's0026', N'Không thể bị lừa dối', N'Tâm Lý',N'Lương Trần', 1990, 20000, 32000, 150),	
		(N's0027', N'Khám phá ngôn ngữ tư duy', N'Tâm Lý',N'Lương Trần', 1990, 20000, 73000, 150),	
		(N's0028', N'Thuật đọc nguội', N'Tâm Lý',N'Thạch Chân Ngữ', 1990, 20000, 54000, 150),	
		(N's0029', N'Những đòn tâm lý trong thuyết phục', N'Tâm Lý',N'Thạch Chân Ngữ', 1990, 20000, 57000, 150),	
		(N's0030', N'Trong chớp mắt', N'Tâm Lý',N'Thạch Chân Ngữ', 1990, 20000, 56000, 150),	
		(N's0031', N'Kiểm thử phần mềm', N'Sách Tin học',N'Phạm Quang Hiển', 1990, 20000, 120000, 150),	
		(N's0032', N'Tự học C# bằng hình ảnh', N'Sách Tin học',N'Phạm Quang Hiển', 1990, 20000, 220000, 150),	
		(N's0033', N'Giao Diện Người Và Máy Với S7 & Intouch', N'Sách Tin học',N'Phạm Quang Hiển', 1990, 20000, 320000, 150),	
		(N's0034', N'Joomla dành cho người tự học', N'Sách Tin học',N'Thế Phát', 1990, 20000, 78000, 150),	
		(N's0035', N'Giáo trình thực hành coreldreaw X7-X8', N'Sách Tin học',N'Thế Phát', 1990, 20000, 143000, 150),	
		(N's0036', N'Tin học đồ họa', N'Sách Tin học',N'Thế Phát', 1990, 20000, 45000, 150),	
		(N's0037', N'Quán gò đi lên', N'Truyện Kinh dị',N'Nguyễn Nhật Ánh', 1990, 20000, 36000, 150),	
		(N's0038', N'Cô gái đến từ hôm qua', N'Truyện Kinh dị',N'Nguyễn Nhật Ánh', 1990, 20000, 36000, 150),	
		(N's0039', N'Đảo mộng mơ', N'Truyện Kinh dị',N'Nguyễn Nhật Ánh', 1990, 20000, 36000, 150),	
		(N's0040', N'Mỗi đêm một câu chuyện kinh dị', N'Truyện Kinh dị',N'Vương Vũ Chấn', 1990, 20000, 36000, 150),	
		(N's0041', N'Đại Nam dị truyện', N'Truyện Kinh dị',N'Vương Vũ Chấn', 1990, 20000, 36000, 150),	
		(N's0042', N'Những chuyện ma kinh hoàng', N'Truyện Kinh dị',N'Vương Vũ Chấn', 1990, 20000, 36000, 150),	
		(N's0043', N'Rừng người', N'Tiểu thuyết',N'Đỗ Phấn', 1990, 20000, 36000, 150),	
		(N's0044', N'Rụng xuống ngày hư ảo', N'Tiểu thuyết',N'Đỗ Phấn', 1990, 20000, 36000, 150),	
		(N's0045', N'Dằng dặc triền sông mưa', N'Tiểu thuyết',N'Đỗ Phấn', 1990, 20000, 36000, 150),	
		(N's0046', N'Nhà giả kim', N'Tiểu thuyết',N'Paulo Coelko', 1990, 20000, 36000, 150),	
		(N's0047', N'Brida', N'Tiểu thuyết',N'Paulo Coelko', 1990, 20000, 36000, 150),	
		(N's0048', N'Quỷ dữ và Nàng Prym', N'Tiểu thuyết',N'Paulo Coelko', 1990, 20000, 36000, 150),	
		(N's0049', N'Mây vàng', N'Truyện ngắn',N'Kiều Bích Hậu', 1990, 20000, 36000, 150),	
		(N's0050', N'Theo dấu loa kèn', N'Truyện ngắn',N'Kiều Bích Hậu', 1990, 20000, 36000, 150),	
		(N's0051', N'Hoa hồng không ở cùng mắm tôm', N'Truyện ngắn',N'Kiều Bích Hậu', 1990, 20000, 60000, 150),	
		(N's0052', N'Giấc mơ', N'Truyện ngắn',N'Phạm Phương', 1990, 20000, 36000, 150),	
		(N's0053', N'Hoa nước', N'Truyện ngắn',N'Trần Chiến', 1990, 20000, 36000, 150),	
		(N's0054', N'Phù phiếm truyện', N'Truyện ngắn',N'Phan Việt', 1990, 20000, 35000, 150),	
		(N's0055', N'Tâm hồn cao thượng', N'Kỹ năng sống',N'Edmondo De Amicis', 1990, 20000, 36000, 150),	
		(N's0056', N'Mãi mãi là yêu thương', N'Kỹ năng sống',N'Thành Vương MTP', 1990, 20000, 69000, 150),	
		(N's0057', N'Ngôn ngữ cơ thể ', N'Kỹ năng sống',N'James Borg', 1990, 20000, 79000, 150),	
		(N's0059', N'Đánh Thức Năng Lực Vô Hạn', N'Kỹ năng sống',N'Anthony Robbins', 1990, 20000, 80000, 150),	
		(N's0060', N'Bí quyết tay trắng thành triệu phú', N'Kỹ năng sống',N'Adam Khoo', 1990, 20000, 35000, 150),	
		(N's0061', N'Phải Trái Đúng Sai (Tái Bản 2017)', N'Kỹ năng sống',N'Michael Sandel', 1990, 20000, 72000, 150),	
		(N's0062', N'Nanh trắng', N'Sách Văn học nước ngoài',N'Jack London', 1990, 20000, 50000, 150),	
		(N's0063', N'Tiếng gọi của hoang dã', N'Sách Văn học nước ngoài',N'Jack London', 1990, 20000, 59000, 150),	
		(N's0064', N'Hoa Tuylip Đen', N'Sách Văn học nước ngoài',N'Alexandre Dumas', 1990, 20000, 48000, 150),	
		(N's0065', N'Trà hoa nữ', N'Sách Văn học nước ngoài',N'Alexandre Dumas', 1990, 20000, 70000, 150),	
		(N's0066', N'Bá Tước Monte Cristo', N'Sách Văn học nước ngoài',N'Alexandre Dumas', 1990, 20000, 65000, 150),	
		(N's0067', N'Ba người lính ngự lâm', N'Sách Văn học nước ngoài',N'Alexandre Dumas', 1990, 20000, 60000, 150),	
		(N's0068', N'Dế mèn phiêu lưu ký', N'Sách Văn học trong nước',N'Tô Hoài', 1990, 20000, 55000, 150),	
		(N's0069', N'Chuyện cũ Hà Nội', N'Sách Văn học trong nước',N'Tô Hoài', 1990, 20000, 50000, 150),	
		(N's0070', N'101 truyện ngày xưa', N'Sách Văn học trong nước',N'Tô Hoài', 1990, 20000, 40000, 150),	
		(N's0071', N'Võ Dê', N'Sách Văn học trong nước',N'Vũ Trọng Phụng', 1990, 20000, 39000, 150),	
		(N's0072', N'Trúng số độc đắc', N'Sách Văn học trong nước',N'Vũ Trọng Phụng', 1990, 20000, 44000, 150),	
		(N's0073', N'Tác phẩm và lời bình', N'Sách Văn học trong nước',N'Vũ Trọng Phụng', 1990, 20000, 44000, 150),	
		(N's0074', N'Truyện cổ tích về các nàng công chúa', N'Truyện tranh',N'Ngô Minh Vân', 1990, 20000, 36000, 150),	
		(N's0075', N'Truyện cổ tích về các chàng hoàng tử', N'Truyện tranh',N'Ngô Minh Vân', 1990, 20000, 36000, 150),	
		(N's0076', N'Chú thỏ bé nhỏ Flipsy - Khu rừng hiểm nguy', N'Truyện tranh',N'Marco Campanella', 1990, 20000, 126000, 150),	
		(N's0077', N'Chú thỏ bé nhỏ Flipsy - Mẹ ơi, mẹ ở đâu?', N'Truyện tranh',N'Marco Campanella', 1990, 20000, 46000, 150),	
		(N's0078', N'Chú thỏ bé nhỏ Flipsy - Cháu đói! Cháu lại đói!', N'Truyện tranh',N'Marco Campanella', 1990, 20000, 106000, 150),	
		(N's0079', N'Elmer và chú gấu bông thất lạc', N'Truyện tranh',N'David McKee', 1990, 20000, 116000, 150),	
		(N's0080', N'Ngữ pháp Tiếng anh', N'Ngoại ngữ',N'Mai Lan Hương', 1990, 20000, 46000, 150),	
		(N's0081', N'Giải thích ngữ pháp tiếng anh', N'Ngoại ngữ',N'Mai Lan Hương', 1990, 20000, 56000, 150),	
		(N's0082', N'Trắc nghiệm ngữ pháp tiếng anh', N'Ngoại ngữ',N'Mai Lan Hương', 1990, 20000, 66000, 150),	
		(N's0083', N'Mind map English Grammar', N'Ngoại ngữ',N'Tiến sĩ Nguyễn Đắc ', 1990, 20000, 76000, 150),	
		(N's0084', N'Để nói thông thạo tiếng anh', N'Ngoại ngữ',N'Tiến sĩ Nguyễn Đắc ', 1990, 20000, 77000, 150),	
		(N's0085', N'Chinh phục tiếng anh từ con số 0', N'Ngoại ngữ',N'Tiến sĩ Nguyễn Đắc ', 1990, 20000, 75000, 150),	
		(N's0086', N'Thấu hiểu tiếp thị từ A đến Z', N'Bán hàng',N'Philip Kotler', 1990, 20000, 95000, 150),	
		(N's0087', N'Kotler bàn về tiếp thị', N'Bán hàng',N'Philip Kotler', 1990, 20000, 85000, 150),
		(N's0088', N'Quản trị Marketing', N'Bán hàng',N'Philip Kotler', 1990, 20000, 80000, 150),	
		(N's0089', N'Đánh cắp ý tưởng', N'Bán hàng',N'Steve Cone', 1990, 20000, 90000, 150),	
		(N's0090', N'Trạng thái mua hàng', N'Bán hàng',N'Joe Vitale', 1990, 20000, 95000, 150),		
		(N's0091', N'Thôi miền bằng ngôn từ', N'Bán hàng',N'Joe Vitale', 1990, 20000, 119000, 150)		
GO
SELECT*FROM DSSach

INSERT INTO dbo.HoaDon(HD_id, HD_date, NV_id, KH_id, HD_money, HD_note)
 VALUES (N'hd001',CONVERT(DATETIME, GETDATE(),103),N'ql001', N'kh001',200000,NULL)
		
GO
SELECT*FROM  HoaDon

INSERT INTO dbo.PhieuNhap(PN_id,PN_date,NV_id, PN_note)
VALUES  (N'pn001',CONVERT(DATETIME, GETDATE(),103),N'ql001',NULL)
		
GO
SELECT*FROM PhieuNhap

--Bao Cao Ton
INSERT INTO dbo.BaoCaoTon(BCT_id, NV_id, BCT_date, BCT_TonDau, BCT_TonCuoi, BCT_note)
VALUES  (N'bct001',N'ql001',CONVERT(DATETIME, GETDATE(),103),50,10,NULL)
		
GO
SELECT*FROM BaoCaoTon

--Bao Cao Cong No
INSERT INTO dbo.BaoCaoNo(BCN_id, NV_id, BCN_date, BCN_TonDau, BCN_TonCuoi, BCN_note)
VALUES  (N'bcn001',N'ql001',CONVERT(DATETIME, GETDATE(),103),10,5,NULL)
		
GO
SELECT*FROM BaoCaoNo
--Quan ly nha sach
