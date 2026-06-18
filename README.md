🎓 Hệ Thống Quản Lý Giảng Viên - Đại Học MIEDU
Dự án Quản lý Giảng viên Đại học MIEDU là một hệ thống phần mềm được xây dựng hoàn toàn bằng C# trên nền tảng .NET 10.0. Dự án áp dụng chặt chẽ mô hình kiến trúc 3 Lớp (3-Tier Architecture) và tuân thủ tuyệt đối 4 đặc tính của Lập trình Hướng đối tượng (OOP).
Đặc biệt, hệ thống hỗ trợ đa giao diện, cho phép người dùng thao tác qua Windows Forms (Desktop GUI) truyền thống hoặc qua Terminal/Console (TUI) cực kỳ nhẹ và linh hoạt.
✨ Chức Năng Nổi Bật
🔐 Xác thực & Phân quyền (RBAC): Đăng nhập an toàn, phân quyền Admin và Giảng viên.
👨‍🏫 Quản lý Cán bộ / Giảng viên: Hiển thị danh sách, tìm kiếm (theo mã, tên), lọc theo Khoa và sắp xếp thông minh bằng LINQ.
📚 Phân công Giảng dạy: Giao diện trực quan để chọn Giảng viên, Môn học và lưu thông tin phân công theo Học kỳ / Năm học.
🖥️ Đa nền tảng Giao diện:
MIEDU.UI: Giao diện Windows Forms hiện đại (Light mode) với Sidebar điều hướng.
MIEDU.TUI: Giao diện Text-based User Interface chạy trực tiếp trên Console/Terminal (hỗ trợ chuột và phím tắt).
🛠️ Công Nghệ & Kiến Trúc
Kiến Trúc 3-Tier (3 Lớp)
Dự án được chia thành 5 Projects riêng biệt để đảm bảo tính Decoupling (Giảm thiểu sự phụ thuộc):
MIEDU.Models: Tầng Core, định nghĩa các Entities và Interfaces.
MIEDU.DAL: Tầng Data Access, xử lý kết nối DB bằng Microsoft.Data.SqlClient.
MIEDU.BLL: Tầng Business Logic, xử lý nghiệp vụ và LINQ.
MIEDU.UI: Tầng Presentation (WinForms).
MIEDU.TUI: Tầng Presentation (Terminal.Gui v2).
Thiết kế Hướng Đối Tượng (OOP)
Trừu tượng (Abstraction): Lớp abstract NhanSu, Interface IUser.
Kế thừa (Inheritance): GiangVien và ChuyenVien kế thừa từ NhanSu.
Đóng gói (Encapsulation): Các fields được private, dữ liệu truy xuất qua Properties với Logic Validation (Ví dụ: Kiểm tra định dạng Email, SĐT).
Đa hình (Polymorphism): Override phương thức HienThiThongTin(), TinhGioLam() tùy theo đối tượng là Giảng viên hay Chuyên viên.
🚀 Hướng Dẫn Cài Đặt & Chạy Dự Án
1. Yêu cầu hệ thống
.NET 10.0 SDK trở lên.
Visual Studio 2022 (Hoặc VS Code / Rider).
SQL Server (bản Developer, Express hoặc LocalDB).
2. Thiết lập Database
Mở SQL Server Management Studio (SSMS).
Mở file Database/MIEDU_CreateDB.sql có trong mã nguồn.
Chạy (Execute / F5) toàn bộ script để tạo Database MIEDU_DB, các bảng và Dữ liệu mẫu (Seed Data).
3. Cấu hình Chuỗi kết nối (Connection String)
Mở file appsettings.json trong 2 project MIEDU.UI và MIEDU.TUI, cập nhật lại chuỗi kết nối cho phù hợp với máy của bạn.
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=MIEDU_DB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}


4. Chạy Ứng dụng
Bạn có thể thiết lập MIEDU.UI hoặc MIEDU.TUI làm Startup Project trong Visual Studio và nhấn F5. Hoặc dùng Terminal:
Chạy bản WinForms (UI):
dotnet run --project MIEDU.UI


Chạy bản Console/Terminal (TUI):
dotnet run --project MIEDU.TUI


🔑 Tài Khoản Đăng Nhập Mẫu
Admin: admin / 123456
Giảng viên 1: gv001 / 123456
Giảng viên 2: gv002 / 123456


🔮 Hướng Phát Triển Tương Lai (Roadmap)
[ ] Tích hợp Entity Framework Core thay cho ADO.NET thuần.
[ ] Thêm tính năng Quản lý Điểm thi và Sinh viên.
[ ] Báo cáo Thống kê dưới dạng Biểu đồ (Charts).
[ ] Xuất dữ liệu ra file Excel / PDF.
Phát triển bởi [Tên của bạn] - Phục vụ môn học Phân tích thiết kế hệ thống Hướng đối tượng.
