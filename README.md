
<div align="center" id="readme-top">
 
# 🎥🎬 CINEMA MANAGEMENT SYSTEM

[![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen)]()
[![Platform](https://img.shields.io/badge/Platform-Windows-blue)]()
[![Language](https://img.shields.io/badge/Language-C%23-purple)]()
[![Framework](https://img.shields.io/badge/.NET-Framework-informational)]()

**Đồ án môn học: IT008 - Lập trình trực quan**
**Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM (UIT-VNUHCM)**

<p align="center">
  <img src="https://github.com/user-attachments/assets/43f51b59-30e9-4c20-8012-04bdad649056" alt="Banner/GIF" />
  <br/>
  <i>Zerobug's Project - "Rạp chiếu phim hiện đại trong tầm tay"</i>
</p>

</div>

---

## 📑 Mục lục (Table of Contents)
- [Giới thiệu (Introduction)](#-giới-thiệu-introduction)
- [Thành viên nhóm (Team Members)](#-thành-viên-nhóm-team-members)
- [Công nghệ sử dụng (Tech Stack)](#%EF%B8%8F-công-nghệ-sử-dụng-tech-stack)
- [Tính năng (Features)](#-tính-năng-features)
- [Cơ sở dữ liệu (Database)](#%EF%B8%8F-cơ-sở-dữ-liệu-database)
- [Hướng dẫn cài đặt & Sử dụng (Installation & Usage)](#-hướng-dẫn-cài-đặt--sử-dụng-installation--usage)
- [Hình ảnh Demo (Screenshots)](#-hình-ảnh-demo-screenshots)

---

## 📝 Giới thiệu (Introduction)
Dự án **Cinema Management** là một phần mềm quản lý rạp chiếu phim toàn diện được xây dựng trên nền tảng **Windows Forms (WinForms)**. Ứng dụng áp dụng kiến trúc **3-Tier (3 Lớp)** để đảm bảo tính bảo mật, dễ bảo trì và mở rộng.

**Giảng viên hướng dẫn:** Thầy Mai Trọng Khang

---

## 👥 Thành viên nhóm (Team Members) | Team Zerobug 🐛

| STT | Họ và tên | MSSV | Github |
|:--:|:---|:--:|:--:|
| 1 | **Trần Quang Hạ** | 24520432 | [@tqha1011](https://github.com/tqha1011) |
| 2 | **Tăng Chấn Hồng** | 24520579 | [@24520579](https://github.com/24520579) |
| 3 | **Hà Thảo Tiên** | 24521761 | [@Tienn203](https://github.com/Tienn203) |
| 4 | **Trần Phương Ánh Vân** | 24521984 | [@anhvansan](https://github.com/anhvansan) |

---

## 🛠️ Công nghệ sử dụng (Tech Stack)

| Category | Technology |
|:---|:---|
| **Core Language** | ![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white) |
| **IDE** | ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=flat-square&logo=visual-studio&logoColor=white) |
| **Framework** | .NET Framework (WinForms) |
| **UI Library** | **Krypton Toolkit** (Modern UI Controls) |
| **Architecture** | 3-Tier Architecture (Presentation - BLL - DAL) |
| **Database** | ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=white) ![Azure](https://img.shields.io/badge/Azure-0078D4?style=flat-square&logo=microsoft-azure&logoColor=white) |
| **Version Control** | ![Git](https://img.shields.io/badge/git-%23F05033.svg?style=flat-square&logo=git&logoColor=white) |

---

## 🎯 Tính năng (Features)

Hệ thống phân quyền rõ ràng cho hai đối tượng sử dụng chính: **Quản lý (Manager)** và **Nhân viên (Employee)**.

### 🛡️ Dành cho Quản lý (Manager)
Người quản trị có toàn quyền kiểm soát hệ thống và dữ liệu.
- **Quản lý Phim (Movie Management):**
  - Thêm, xóa, sửa thông tin phim.
  - Cập nhật Poster, Trailer, Thể loại, Thời lượng.
- **Quản lý Lịch chiếu (Showtime Management):**
  - Sắp xếp lịch chiếu cho từng phòng.
  - Tự động kiểm tra trùng lặp lịch chiếu.
- **Quản lý Nhân viên (Staff Management):**
  - CRUD thông tin nhân viên.
  - Cấp tài khoản và phân quyền đăng nhập.
- **Thống kê & Báo cáo (Statistics):**
  - Xem doanh thu theo ngày, tháng, năm.
  - Thống kê phim bán chạy nhất (Best-selling movies).
  - Biểu đồ trực quan về lượng vé bán ra.
- **Quản lý đồ ăn (Food && Beverage):**
  - Cập nhật các món ăn 
  - Thêm các món ăn mới sẵn sàng phục vụ

### 🎫 Dành cho Nhân viên (Employee)
Giao diện tối ưu cho tốc độ phục vụ tại quầy.
- **Bán vé (Ticket Booking):**
  - Chọn phim, chọn suất chiếu.
  - **Sơ đồ ghế trực quan:** Chọn ghế, hiển thị trạng thái ghế (đã đặt/trống/đang chọn).
- **Dịch vụ Bắp & Nước (Order Food & Beverage):**
  - Order Combo bắp nước kèm vé.
  - Tính tổng tiền tự động.
- **Thanh toán & Xuất vé:**
  - Hỗ trợ in hóa đơn (PDF Export).
  - Tạo mã QR cho vé.

---

## 🗃️ Cơ sở dữ liệu (Database)

Hệ thống sử dụng **SQL Server** được deploy trên **Azure SQL Database**.

![erd Database](https://github.com/user-attachments/assets/9a47715c-899c-4868-92c2-02216f85fe93)

---

## 🚀 Hướng dẫn cài đặt & Sử dụng (Installation & Usage)

Để chạy được dự án này trên máy local, vui lòng làm theo các bước sau:

### Yêu cầu (Prerequisites)
- [Visual Studio 2022/2026](https://visualstudio.microsoft.com/vs/) (Khuyên dùng).
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Nếu chạy DB local) hoặc kết nối Internet (Nếu dùng Azure).
- .NET Framework 4.7.2 (phiên bản tương ứng với project).

### Các bước cài đặt (Steps)

1. **Clone Repository**
   Mở Git Bash hoặc Terminal và chạy lệnh:
   ```bash
   git clone [https://github.com/tqha1011/Cinema_management.git](https://github.com/tqha1011/Cinema_management.git)
2. **Database Setup**
   Bạn có thể chọn 1 trong 2 cách sau:

   ### Cách A: Sử dụng Database Cloud (Khuyên dùng)
   * Dự án đã được cấu hình sẵn để kết nối tới Azure SQL Database.
   * **Yêu cầu:** Máy tính cần có kết nối Internet ổn định khi chạy ứng dụng.

   ### Cách B: Sử dụng Local SQL Server
   *  Mở **SQL Server Management Studio (SSMS)**.
   *  Mở file script tạo database tại: `Cinema_management/Database/script.sql`.
   *  Nhấn **Execute** (`F5`) để tạo Database và dữ liệu mẫu.
   *  Lấy **Connection String** của máy bạn và cập nhật vào file `App.config` trong code:

   ```xml
   <connectionStrings>
     <add name="CinemaDb" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=CinemaManagement;Integrated Security=True" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
3. Cài đặt thư viện và Build
   * Mở file Cinema_management.sln bằng [Visual Studio](https://visualstudio.microsoft.com/vs/)
   * Tại **Solution Explorer**, chuột phải **Solution** -> **Restore Nuget Packages** để tải các thư viện cần thiết
   * Build để chạy chương trình
<p align="right"><a href="#readme-top">Quay lại đầu trang</a></p>
