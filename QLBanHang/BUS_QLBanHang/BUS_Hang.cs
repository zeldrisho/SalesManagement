using DAL_QLBanHang;
using DTO_QLBanHang;
using System.Data;

namespace BUS_QLBanHang
{
    public class BUS_Hang
    {
        // Xem danh sách 
        DAL_Hang dalHang = new DAL_Hang();
        public DataTable DanhSachHang()
        {
            return dalHang.danhSachHang();
        }

        public bool insertHang(DTO_Hang hang)
        {
            return dalHang.insertHang(hang);
        }

        public bool updateHang(DTO_Hang hang)
        {
            return dalHang.updateHang(hang);
        }

        public bool deleteHang(string mahang)
        {
            return dalHang.deleteHang(mahang);
        }

        public DataTable searchHang(string tenHang)
        {
            return dalHang.searchHang(tenHang);
        }

        public DataTable thongKeTonKho()
        {
            return dalHang.thongKeTonKho();
        }

        public DataTable thongKeSP()
        {
            return dalHang.thongKeSP();
        }
    }
}
