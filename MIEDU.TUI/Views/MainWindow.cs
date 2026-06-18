using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Terminal.Gui.App;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
using MIEDU.BLL.Services;
using MIEDU.Models.Entities;

namespace MIEDU.TUI.Views
{
    public class MainWindow : Window
    {
        private GiangVienBLL _giangVienBLL;
        private ListView _listView;
        private TextField _txtSearch;
        private IApplication _app;

        public MainWindow(IApplication app) : base()
        {
            _app = app;
            Title = $"HỆ THỐNG QUẢN LÝ MIEDU (User: {LoginWindow.CurrentUser?.Username})";
            _giangVienBLL = new GiangVienBLL();

            var menu = new MenuBar(new MenuBarItem[] {
                new MenuBarItem("_Hệ thống", new MenuItem [] {
                    new MenuItem("_Đăng xuất", "", () => {
                        _app.RequestStop();
                        using var loginWindow = new LoginWindow(_app);
                        _app.Run(loginWindow);
                    }),
                    new MenuItem("_Thoát", "", () => _app.RequestStop())
                }),
                new MenuBarItem("_Chức năng", new MenuItem [] {
                    new MenuItem("_Quản lý giảng viên", "", () => LoadData()),
                    // Cập nhật MessageBox.Query thêm _app vào tham số đầu tiên
                    new MenuItem("_Phân công", "", () => MessageBox.Query(_app, "Thông báo", "Tính năng đang phát triển!", "OK"))
                })
            });

            var lblSearch = new Label { Text = "Tìm kiếm:", X = 1, Y = 2 };
            _txtSearch = new TextField { Text = "", X = Pos.Right(lblSearch) + 1, Y = 2, Width = 25 };

            var btnSearch = new Button { Text = "Tìm kiếm", X = Pos.Right(_txtSearch) + 1, Y = 2 };
            var btnSort = new Button { Text = "Sắp xếp", X = Pos.Right(btnSearch) + 1, Y = 2 };
            var btnRefresh = new Button { Text = "Tải lại", X = Pos.Right(btnSort) + 1, Y = 2 };

            var frame = new FrameView
            {
                Title = "Danh sách Giảng viên",
                X = 1,
                Y = 4,
                Width = Dim.Fill() - 1,
                Height = Dim.Fill() - 1
            };

            _listView = new ListView()
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };
            frame.Add(_listView);

            // Sửa Clicked thành Accepting theo chuẩn v2
            btnSearch.Accepting += (s, e) => {
                var keyword = _txtSearch.Text.ToString();
                var data = _giangVienBLL.Search(keyword);
                UpdateListView(data);
            };

            btnSort.Accepting += (s, e) => {
                var data = _giangVienBLL.GetSortedByName();
                UpdateListView(data);
            };

            btnRefresh.Accepting += (s, e) => {
                _txtSearch.Text = "";
                LoadData();
            };

            // Thêm tất cả vào Window chính
            Add(menu, lblSearch, _txtSearch, btnSearch, btnSort, btnRefresh, frame);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var data = _giangVienBLL.GetAll();
                UpdateListView(data);
            }
            catch (Exception ex)
            {
                // Cập nhật MessageBox.ErrorQuery thêm _app vào tham số đầu tiên
                MessageBox.ErrorQuery(_app, "Lỗi DB", "Không thể kết nối CSDL!\n" + ex.Message, "OK");
            }
        }

        private void UpdateListView(IEnumerable<GiangVien> data)
        {
            // Dùng chuỗi Format căn lề để giả lập Table hiển thị theo cột
            var displayList = data.Select(gv =>
                $"{gv.MaNhanSu,-8} | {gv.HoTen,-20} | {gv.MaKhoa,-7} | {gv.HocVi,-15} | {gv.ChucDanh}").ToList();

            // Thêm Header giả lập
            displayList.Insert(0, $"{"MÃ GV",-8} | {"HỌ TÊN",-20} | {"KHOA",-7} | {"HỌC VỊ",-15} | CHỨC DANH");
            displayList.Insert(1, new string('-', 85));

            // Khởi tạo ObservableCollection để tương thích với ListView.SetSource() trong Terminal.Gui v2
            _listView.SetSource(new ObservableCollection<string>(displayList));
        }
    }
}