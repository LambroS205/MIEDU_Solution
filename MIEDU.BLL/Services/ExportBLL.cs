using System;
using System.Collections.Generic;
using ClosedXML.Excel;
using MIEDU.Models.Entities;

namespace MIEDU.BLL.Services
{
    public class ExportBLL
    {
        public void ExportDanhSachGiangVien(List<GiangVien> list, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Danh Sách Giảng Viên");

                // 1. Tạo Dòng Tiêu đề (Header)
                worksheet.Cell(1, 1).Value = "Mã Nhân Sự";
                worksheet.Cell(1, 2).Value = "Họ Tên";
                worksheet.Cell(1, 3).Value = "Ngày Sinh";
                worksheet.Cell(1, 4).Value = "Giới Tính";
                worksheet.Cell(1, 5).Value = "Số Điện Thoại";
                worksheet.Cell(1, 6).Value = "Email";
                worksheet.Cell(1, 7).Value = "Mã Khoa";
                worksheet.Cell(1, 8).Value = "Học Vị";
                worksheet.Cell(1, 9).Value = "Chức Danh";
                worksheet.Cell(1, 10).Value = "Số Giờ Chuẩn";

                // 2. Format cho Header nổi bật
                var headerRange = worksheet.Range("A1:J1");
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.LightBlue;
                headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // 3. Đổ Dữ liệu từ List vào các dòng tiếp theo
                for (int i = 0; i < list.Count; i++)
                {
                    var gv = list[i];
                    int row = i + 2;
                    worksheet.Cell(row, 1).Value = gv.MaNhanSu;
                    worksheet.Cell(row, 2).Value = gv.HoTen;
                    worksheet.Cell(row, 3).Value = gv.NgaySinh?.ToString("dd/MM/yyyy") ?? "";
                    worksheet.Cell(row, 4).Value = gv.GioiTinh;
                    worksheet.Cell(row, 5).Value = gv.SoDienThoai;
                    worksheet.Cell(row, 6).Value = gv.Email;
                    worksheet.Cell(row, 7).Value = gv.MaKhoa;
                    worksheet.Cell(row, 8).Value = gv.HocVi;
                    worksheet.Cell(row, 9).Value = gv.ChucDanh;
                    worksheet.Cell(row, 10).Value = gv.SoGioChuan;
                }

                // 4. Auto-fit các cột để nội dung không bị che khuất
                worksheet.Columns().AdjustToContents();

                // 5. Lưu file vào đường dẫn được chỉ định
                workbook.SaveAs(filePath);
            }
        }
    }
}