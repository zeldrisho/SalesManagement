using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBanHang;
using DTO_QLBanHang;
using System.Data;
namespace BUS_QLBanHang
{
    public class BUS_Hang
    {
        //xem danh sách 
        DAL_Hang dalHang = new DAL_Hang();
        public DataTable DanhSachHang()
        {
            return dalHang.danhSachHang();
        }
        //thêm
        public bool insertHang(DTO_Hang hang)
        {
            return dalHang.insertHang(hang);
        }
        // cập nhật
        public bool updateHang(DTO_Hang hang)
        {
            return dalHang.updateHang(hang);
        }
        // xóa
        public bool deleteHang(string mahang)
        {
            return dalHang.deleteHang(mahang);
        }
        // tìm kiêm
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
