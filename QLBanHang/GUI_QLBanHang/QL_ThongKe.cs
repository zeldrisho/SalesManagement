using System;
using System.Windows.Forms;
namespace GUI_QLBanHang
{
    public partial class QL_ThongKe : UserControl
    {
        public QL_ThongKe()
        {
            InitializeComponent();
        }
        
        private void QL_ThongKe_Load(object sender, EventArgs e)
        {
            BUS_QLBanHang.BUS_Hang busHang = new BUS_QLBanHang.BUS_Hang();
            dataGridViewNhapKho.DataSource = busHang.thongKeSP();
            dataGridViewTonKho.DataSource = busHang.thongKeTonKho();
            designView();
        }

        void designView()
        {
            dataGridViewTonKho.Columns[0].HeaderText = "Tên hàng";
            dataGridViewTonKho.Columns[1].HeaderText = "Số lượng";
            dataGridViewTonKho.Columns[0].DividerWidth = 2;
            dataGridViewNhapKho.Columns[0].HeaderText = "Mã nhân viên";
            dataGridViewNhapKho.Columns[1].HeaderText = "Tên nhân viên";
            dataGridViewNhapKho.Columns[2].HeaderText = "Số lượng sản phẩm nhập";
            dataGridViewNhapKho.Columns[0].DividerWidth = 2;
            dataGridViewNhapKho.Columns[1].DividerWidth = 2;
            dataGridViewNhapKho.Columns[2].DividerWidth = 2;
        }
    }
}
