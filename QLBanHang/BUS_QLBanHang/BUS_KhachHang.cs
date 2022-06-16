using DAL_QLBanHang;
using DTO_QLBanHang;
using System.Data;
namespace BUS_QLBanHang
{
   public class BUS_KhachHang
    {
        DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
        // xuất danh sách 
        public DataTable DanhSachKH()
        {
            return dal_KhachHang.danhSachKH();
        }
        // thêm khách hàng
        public bool insertKhachHang(DTO_KhachHang khachHang)
        {
            return dal_KhachHang.insertKH(khachHang);
        }
        // xóa khách hàng
        public bool deleteKhachHang(string sdt)
        {
            return dal_KhachHang.deleteKH(sdt);
        }
        // sửa khách hàng
        public bool updateKhachHang(DTO_KhachHang khachHang)
        {
            return dal_KhachHang.updateKH(khachHang);
        }
        // tìm kiếm khách hàng
        public DataTable searchKhachHang(string tenkhach)
        {
            return dal_KhachHang.searchKH(tenkhach);
        }
    }

}
