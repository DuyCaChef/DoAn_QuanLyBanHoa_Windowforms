# ?? QU?N LÝ BÁN HOA - H??NG D?N S? D?NG

## ?? Mô t? d? án
?ây là ?ng d?ng qu?n lý bán hoa ???c phát tri?n b?ng C# Windows Forms và MySQL, h? tr? qu?n lý hoa, khách hàng, ??n hàng và khuy?n mãi.

## ??? Công ngh? s? d?ng
- **Framework**: .NET 8.0
- **UI**: Windows Forms
- **Database**: MySQL
- **Language**: C# 12.0

## ?? C?u trúc d? án

```
QuanLyBanHoa/
??? Data/                    # L?p Database và Models
?   ??? Database.cs         # K?t n?i MySQL
?   ??? Hoa.cs              # Model Hoa
?   ??? KhachHang.cs        # Model Khách Hàng
?   ??? NhanVien.cs         # Model Nhân Viên
?   ??? DonHang.cs          # Model ??n Hàng
?   ??? ChiTietDonHang.cs   # Model Chi Ti?t ??n Hàng
?   ??? KhuyenMai.cs        # Model Khuy?n Mãi
??? Models/                  # Session và các model khác
?   ??? Session.cs          # Qu?n lý phiên ??ng nh?p
??? Modules/                 # Các form giao di?n
?   ??? frmDangNhap.cs      # Form ??ng nh?p
?   ??? frmHoa.cs           # Form qu?n lý hoa
??? Program.cs              # Entry point
```

## ??? C?u trúc Database

### B?ng `hoa`
| C?t | Ki?u | Mô t? |
|-----|------|-------|
| MaHoa | INT (PK, AUTO_INCREMENT) | Mã hoa |
| TenHoa | VARCHAR(100) | Tên hoa |
| Gia | DECIMAL(18,2) | Giá bán |
| SoLuong | INT | S? l??ng t?n kho |
| MoTa | TEXT | Mô t? hoa |

### Các b?ng khác
- `khachhang`: Qu?n lý thông tin khách hàng
- `nhanvien`: Qu?n lý nhân viên
- `donhang`: Qu?n lý ??n hàng
- `chitietdonhang`: Chi ti?t ??n hàng
- `khuyenmai`: Ch??ng trình khuy?n mãi

## ?? Cài ??t và Ch?y ?ng d?ng

### B??c 1: Cài ??t MySQL
1. T?i và cài ??t MySQL Server t? [https://dev.mysql.com/downloads/](https://dev.mysql.com/downloads/)
2. Ho?c s? d?ng XAMPP/WAMP ?? cài MySQL

### B??c 2: T?o Database
1. M? MySQL Workbench ho?c phpMyAdmin
2. Ch?y file `Database_Script.sql` ?? t?o database và d? li?u m?u

### B??c 3: C?u hình Connection String
M? file `QuanLyBanHoa/Data/Database.cs` và c?p nh?t:

```csharp
private static readonly string connectionString =
    "server=localhost;uid=root;pwd=YOUR_PASSWORD;database=quanlybanhoa;charset=utf8mb4;";
```

**Thay `YOUR_PASSWORD` b?ng m?t kh?u MySQL c?a b?n!**

### B??c 4: Restore NuGet Packages
```bash
dotnet restore
```

### B??c 5: Build và ch?y
```bash
dotnet build
dotnet run
```

Ho?c m? Solution trong Visual Studio và nh?n F5.

## ?? Ch?c n?ng ?ã hoàn thành

### Form Qu?n Lý Hoa (frmHoa.cs)
? **Xem danh sách hoa**: Hi?n th? t?t c? hoa trong database  
? **Thêm hoa m?i**: Thêm s?n ph?m hoa v?i ??y ?? thông tin  
? **S?a thông tin hoa**: C?p nh?t thông tin hoa ?ã có  
? **Xóa hoa**: Xóa hoa kh?i h? th?ng (có ki?m tra ràng bu?c)  
? **Tìm ki?m hoa**: Tìm theo tên, mã ho?c mô t?  
? **Validation**: Ki?m tra d? li?u ??u vào  
? **Format giá ti?n**: H? tr? nhi?u ??nh d?ng nh?p giá  

### Form ??ng Nh?p (frmDangNhap.cs)
? ??ng nh?p v?i tài kho?n Admin/Nhân viên  
? L?u session ng??i dùng  

## ?? H??ng d?n s? d?ng Form Hoa

### Thêm hoa m?i
1. Nh?p ??y ?? thông tin: Tên hoa, Giá, S? l??ng, Mô t?
2. Nh?n nút **"Thêm"**
3. Ki?m tra danh sách hoa ?ã ???c c?p nh?t

### S?a thông tin hoa
1. Click ch?n 1 dòng trong b?ng danh sách
2. Thông tin t? ??ng hi?n th? ? form bên trái
3. Nh?n nút **"S?a"** ?? chuy?n ch? ?? ch?nh s?a
4. Thay ??i thông tin c?n s?a
5. Nh?n nút **"L?u"** ?? hoàn t?t

### Xóa hoa
1. Click ch?n hoa c?n xóa
2. Nh?n nút **"Xóa"**
3. Xác nh?n xóa trong h?p tho?i

### Tìm ki?m
1. Nh?p t? khóa vào ô "Tìm ki?m"
2. Nh?n nút **"Tìm"**
3. K?t qu? s? hi?n th? trong b?ng

## ?? Tài kho?n m?c ??nh

### Admin
- **Email**: admin123@gmail.com
- **Password**: admin@123

### Nhân viên
- **Email**: staff123@gmail.com
- **Password**: staff@123

## ?? Các tính n?ng n?i b?t

### 1. Validation thông minh
- Ki?m tra d? li?u tr?ng
- Ki?m tra ??nh d?ng giá ti?n (h? tr? nhi?u format)
- Ki?m tra giá tr? h?p l? (>0)

### 2. X? lý l?i Database
- B?t l?i Foreign Key constraint
- Hi?n th? thông báo thân thi?n
- Rollback t? ??ng khi l?i

### 3. UI/UX t?t
- DataGridView t? ??ng format
- Selection highlight
- Button state management
- Clear form sau m?i action

### 4. Tính n?ng Event
- Event `HoaDataChanged` ?? thông báo cho các form khác
- Auto-refresh sau CRUD operations

## ?? X? lý l?i th??ng g?p

### L?i k?t n?i MySQL
```
K?t n?i th?t b?i: Unable to connect to any of the specified MySQL hosts
```
**Gi?i pháp**: Ki?m tra MySQL service ?ang ch?y và connection string ?úng

### L?i Character Set
```
Incorrect string value: '\xC4\x90\xC3\xA0...'
```
**Gi?i pháp**: ??m b?o database dùng `utf8mb4` collation

### L?i Foreign Key
```
Cannot delete or update a parent row: a foreign key constraint fails
```
**Gi?i pháp**: Xóa các b?n ghi liên quan trong b?ng con tr??c

## ?? TODO - Tính n?ng c?n phát tri?n
- [ ] Form Qu?n lý Khách hàng
- [ ] Form Qu?n lý ??n hàng
- [ ] Form Th?ng kê báo cáo
- [ ] Export Excel/PDF
- [ ] Phân quy?n chi ti?t theo Role
- [ ] ??ng nh?p v?i Database (thay vì hardcode)
- [ ] Upload hình ?nh cho s?n ph?m
- [ ] In hóa ??n

## ????? ?óng góp
M?i ?óng góp ??u ???c chào ?ón! Hãy t?o Pull Request ho?c Issue.

## ?? License
MIT License - T? do s? d?ng cho m?c ?ích h?c t?p và th??ng m?i.

---
**Phát tri?n b?i**: ?? án Qu?n Lý Bán Hoa  
**N?m**: 2024  
**Framework**: .NET 8.0 + MySQL
