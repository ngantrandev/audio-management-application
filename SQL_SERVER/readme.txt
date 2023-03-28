*** Lưu ý rằng NSD không cần sử dụng server với tên server và thông tin đăng nhập giống hướng dẫn

*** Tuy nhiên NSD bắt buộc phải
		+ tạo server hoặc sử dụng server với thông tin có đầy đủ các trường dữ liệu như hướng dẫn
		+ tên database và thông tin table phải giống như hướng dẫn.

*** Để thuận tiện: + NSD nên làm theo hướng dẫn
			 + Hoặc sử dụng server có chứa thông tin trong mục bắt buộc


					*******HƯỚNG DẪN CHI TIẾT CÁCH KHỞI TẠO SERVER**********

Trong dự án này, chúng ta sử dụng MICROSOFT SQL SERVER 2022 với thông tin sau:
			Tên của server là: NGANCONDETHUONG
			Phương thức xác thực: SQL Server Authencation
			Tên đăng nhập: sa
			Mật khẩu: 123
			Database: AP06TVNGAN, table AUDIOFILES
	


Bước 1: Cài đặt SQL Server
		Cách 1: Dùng file cài đặt .exe từ file đính kèm thư mục có tên là: SQL2022-SSEI-Dev.exe

		Cách 2: Tải SQL SERVER từ trang chủ: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
				(Có thể chọn bản Developer hoặc Express)
				- Cài đặt file vừa tải
				- Thiết lập server với thông tin như trên


Bước 2: 
	Cách 1: Dễ nhất nhưng yêu cầu database chưa tồn tại
		Khởi tạo database AP06TVNGAN bằng file Init_Data.bat đính kèm
			- Nhấp đúp chuột vào file có tên Init_Data.bat, nằm cùng thư mục với file readme.txt này
			- Sau khi tiến trình hoàn thành => Database được khởi tạo thành công
	Cách 2:
		- Dùng file .bak nằm trong thư mục Backup đính kèm
		để thực hiện backup database (có vai trò giống như khởi tạo database)


	Cách 3:
		- Dùng mã lệnh query nằm trong thư mục Query đính kèm
		để khởi tạo database