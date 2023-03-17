								********Giới thiệu về đồ án**********
							HỌC VIỆN CÔNG NGHỆ BƯU CHÍNH VIỄN THÔNG HỒ CHÍ MINH

		Đây là đồ án môn học: Lập trình âm thanh
		Sinh viên thực hiện : Trần Văn Ngạn
		Giảng viên hướng dẫn: thầy Võ Xuân Thể
		Thời gian thực hiện : 03/01/2023 đến 07/03/2023 (Học kỳ 6 của khóa học)
		Kết quả đạt được    : Tạo lập được chương trình Winform quản lý âm thanh ( có một số xử lý cơ bản trên file âm thanh)
		

		CHÚ Ý ĐỌC KỸ PHẦN DƯỚI ĐÂY

*********************************************************************************************************************************************

							*******CẤU TRÚC CỦA THƯ MỤC AP06TVNGAN_Coi_Xe********

Thư mục chứa 6 thư mục con:
	+ Báo cáo đồ án: Chứa file báo cáo đồ án và file bài tập học phần

	+ Bộ cài đặt: Chứa file cài đặt app (file .msi)
		. Nhấp đúp vào file này có thể cài đặt và gỡ cài đặt app

	+ File nhạc: Quan trọng
		. Chứa thư mục AUDIO_DATA( cần thiết cho app)
		. NSD cần copy thư mục AUDIO_DATA này vào C:\Program Files\TVNGAN
		. Nếu không thực hiện copy, chương trình sẽ không có file audio mẫu
		. Lúc này, NSD bắt buộc phải thêm mới file audio để có thể sử dụng các chức năng của app
		. NSD có thể thêm file mới từ thư mục có đường dẫn: \AP06TVNGAN_Coi_Xe\Project\DESIGN_APP\AP06TVNGAN\AudioFiles đính kèm

	+ Project:
		. Chứa thư mục DESIGN_APP: gồm 2 thư mục con:
						- AP06TVNGAN	: Chính là project winform ( phần code của dự án)
						- AP06TVNGAN_SETUP: Thư mục thiết lập trình biên dịch dự án sang file .exe
						để NSD có thể cài đặt app

	+ SQL_SERVER: Quan trọng, cần đọc file readme.txt bên trong thư mục

	+ Thu_vien: NSD cần chú ý tới hai file .dll quan trọng

		- ikpMP3.dll (thư viện phát âm thanh)
			. NSD cần copy file này vào C:\Program Files\TVNGAN\AP06TVNGAN_SETUP
			. Để chương trình hoạt động bình thường
		- irrKlang.NET4.dll ( thư viện dùng để lập trình âm thanh 2D và 3D)



Chú thích:
	+ APP  	 : Chương trình (Application).
	+ Audio	 : âm thanh.
	+ Code	 : Mã lệnh.
	+ Copy 	 : Sao chép.
	+ File 	 : tệp tin.
	+ File audio : Tệp tin âm thanh.
	+ NSD        : Người sử dụng (User).
	+ Project    : dự án.
	+ Setup      : thiết lập hoặc cài đặt.
	+ Source code: mã nguồn của phần mềm.
	+ Winform    : là một ứng dụng Windows Forms, một loại ứng dụng giao diện người dùng đồ họa (GUI) được xây dựng trên nền tảng .NET Framework của Microsoft.


*********************************************************************************************************************************************
		Bản quyền © 2023 Trần Văn Ngạn. Tất cả các quyền được bảo lưu.

		Phần mềm AP06TVNGAN được phát triển bởi Trần Văn Ngạn và được sử dụng để quản lý file âm thanh.
		Phần mềm này có thể được sử dụng miễn phí cho mục đích cá nhân và phi thương mại.
		Việc sử dụng phần mềm này cho mục đích thương mại chỉ được phép khi có sự đồng ý bằng văn bản từ Trần Văn Ngạn.

		Source code của phần mềm AP06TVNGAN và hướng dẫn sử dụng đi kèm có thể được tìm thấy trong thư mục hiện tại hoặc tại trang web https://github.com/totengiday.