# Phần mềm quản lý bán hàng

## Screenshots
<details>
  <summary>Click here</summary>
  <ul>
    <li>Màn hình chính</li>
    <img src="https://i.imgur.com/qAhffhd.png" />
    <li>Form đăng nhập</li>
    <img src="https://i.imgur.com/IlE2iJg.png" />
    <li>Form nhân viên</li>
    <img src="https://i.imgur.com/LpYR6ds.png" />
    <li>Form thống kê</li>
    <img src="https://i.imgur.com/dmBU76X.png" />
    <li>Form sản phẩm</li>
    <img src="https://i.imgur.com/fvRF5N6.png" />
    <li>Form khách hàng</li>
    <img src="https://i.imgur.com/WXjcitn.png" />
    <li>Form hồ sơ nhân viên</li>
    <img src="https://i.imgur.com/48GObnU.png" />
    <li>Form đổi mật khẩu</li>
    <img src="https://i.imgur.com/vNn32NY.png" />
    <li>Database diagram</li>
    <img src="https://i.imgur.com/DP8kNYC.png" />
    <li>Tự động gửi mail chứa thông tin đăng nhập khi thêm nhân viên mới</li>
    <img src="https://i.imgur.com/U0rRrfF.jpg" />
    <li>Tự động gửi mail chứa mật khẩu mới khi ấn quên mật khẩu</li>
    <img src="https://i.imgur.com/bNjNfD3.png" />
  </ul>
</details>

## Công nghệ được sử dụng
- Visual Studio 2022, SSMS 18
- SQL Server 2019 Express, Azure SQL Database
- .NET Framework 4.7.2
- ADO.NET
- Guna.UI2.WinForms
- Microsoft.ReportingServices.ReportViewerControl.Winforms
- EPPlus, Microsoft.Office.Interop.Excel
- Advanced Installer

## Hướng dẫn
- Dùng SSMS run query DBQLBanHang-script.sql
- Dùng Visual Studio mở QLBanHang/QLBanHang.sln
- Thay đổi connection string trong App.config cho phù hợp
- Register Guna Framework để edit form
- Chức năng send mail: sửa tài khoản, mật khẩu ở QLBanHang/GUI_QLBanHang/SendMail.cs

## Tài khoản mặc định
- Admin 
  + Email: trunghsg2012@gmail.com
  + Password: m@tkh@u
- Nhân viên
  + Email: tranminphat@gmail.com
  + Password: mknv1

## Remote database
- Tạo tài khoản: https://azure.microsoft.com/en-us/free
- Deloy database: https://www.progress.com/documentation/sitefinity-cms/deploy-the-database-to-azure-sql
- https://portal.azure.com -> Overview -> Set server firewall -> Add a firewall ruld
  + Start: 0.0.0.0
  + End: 255.255.255.255
- https://portal.azure.com -> Connection strings -> Copy & edit password

## Nguồn tham khảo
- https://github.com/BemmTeam/SOF205_QLBanHang
- https://github.com/gtechsltn/QLBanHang