# Phần mềm quản lý bán hàng

<details>
  <summary>Screenshots</summary>
  <img src="https://i.imgur.com/y5hMket.png" />
</details>

## Công nghệ được sử dụng
- Visual Studio 2022, SSMS 18
- SQL Server 2019 Express, Azure SQL Database
- .NET Framework 4.7.2
- ADO.NET
- Guna.UI2.WinForms 2.0.3.2, DevExpress 21.2
- Advanced Installer 19.5

## Hướng dẫn cách chạy chương trình
- Mở SSMS -> Chuột phải Databases -> Import Data-tier Application... -> Chọn DBQLBanHang.bacpac
- Dùng Visual Studio mở QLBanHang.sln
- Thay đổi connection string trong App.config cho phù hợp
- Register Guna Framework để edit form

## Tài khoản
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