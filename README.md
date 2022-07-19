# Phần mềm quản lý bán hàng

## Công nghệ được sử dụng
- Visual Studio 2022, SSMS 18
- SQL Server 2019 Express, Azure SQL Database
- .NET Framework 4.7.2
- ADO.NET
- Guna.UI2.WinForms
- Advanced Installer

## Hướng dẫn
- Dùng SSMS run query SqlScripts/generated-script.sql
- Dùng Visual Studio mở SalesManagement/SalesManagement.sln
- Thay đổi connection string trong App.config cho phù hợp
- Register Guna Framework để edit form
- Chức năng send mail: sửa tài khoản, mật khẩu ở SalesManagement/GUI/SendMail.cs

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
- https://portal.azure.com -> Overview -> Set server firewall -> Add a firewall rule
  + Start: 0.0.0.0
  + End: 255.255.255.255
- https://portal.azure.com -> Connection strings -> Copy & edit password

## Nguồn tham khảo
- https://github.com/gtechsltn/QLBanHang
- https://www.youtube.com/channel/UCwI8AQlBewsdxbyk2r4n9CQ
- https://www.youtube.com/c/KTeam
- https://www.youtube.com/channel/UCljqNyim6NFh6ZWj1qXXpSg