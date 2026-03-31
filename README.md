# 📦 HỆ THỐNG QUẢN LÝ KHO (Warehouse Management System)

## 🧑‍💻 Giới thiệu

Đây là hệ thống quản lý kho vật tư được xây dựng bằng **ASP.NET Core MVC** nhằm hỗ trợ:

* Quản lý nhập kho
* Theo dõi tồn kho
* Quản lý vật tư
* Hỗ trợ nghiệp vụ kho trong xưởng sản xuất

---

## 🚀 Công nghệ sử dụng

* ASP.NET Core MVC
* C#
* SQL Server
* Entity Framework Core *(hoặc List nếu demo)*

---

## 📌 Chức năng chính

### 🔹 1. Quản lý nhập kho (PhieuNhap)

* Thêm phiếu nhập
* Sửa phiếu nhập
* Xóa phiếu nhập
* Xem danh sách

### 🔹 2. Quản lý vật tư *(có thể mở rộng)*

* Thêm vật tư
* Cập nhật số lượng tồn

### 🔹 3. Theo dõi tồn kho

* Hiển thị số lượng tồn
* Cảnh báo khi thiếu hàng *(nâng cao)*

---

## 🧱 Kiến trúc hệ thống (MVC)

* **Model**: Chứa dữ liệu (PhieuNhap, VatTu,...)
* **View**: Giao diện người dùng (Razor)
* **Controller**: Xử lý logic nghiệp vụ

---

## 📂 Cấu trúc thư mục

```
/Controllers
    PhieuNhapController.cs

/Models
    PhieuNhap.cs

/Views
    /PhieuNhap
        Index.cshtml
        Create.cshtml
        Edit.cshtml
        Delete.cshtml
```

---

## ⚙️ Cài đặt và chạy

### 🔹 Bước 1: Clone project

```bash
git clone <link-repo>
```

### 🔹 Bước 2: Mở bằng Visual Studio

### 🔹 Bước 3: Cấu hình database (nếu có)

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=QuanLyKhoDB;Trusted_Connection=True;"
}
```

### 🔹 Bước 4: Chạy project

* Nhấn **F5** hoặc **Ctrl + F5**

---

## 📸 Demo chức năng

* Trang danh sách phiếu nhập
* Form thêm / sửa / xóa

*(Có thể thêm ảnh screenshot vào đây)*

---

## 🎯 Mục tiêu

* Áp dụng mô hình MVC
* Hiểu cách xây dựng hệ thống quản lý kho
* Thực hành CRUD trong ASP.NET Core

---

## 📌 Hướng phát triển

* Thêm xuất kho
* Thêm đăng nhập & phân quyền
* Dashboard báo cáo
* Tích hợp quét mã vạch

---

## 👨‍🎓 Thông tin sinh viên

* Họ tên: Lồ Đức Minh
* MSSV: DTC245010068
* Lớp: KTMTK23A

---

## 📄 License

Dự án phục vụ mục đích học tập.
