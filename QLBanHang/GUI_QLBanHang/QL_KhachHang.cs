using System;
using System.Data;
using System.Windows.Forms;
using BUS_QLBanHang;
using DTO_QLBanHang;
namespace GUI_QLBanHang
{
    public partial class QL_KhachHang : UserControl
    {
        public QL_KhachHang(string email)
        {
            InitializeComponent();
           this.email  = email;
        }
        private string email;
        BUS_KhachHang busKH = new BUS_KhachHang();

        private void setValue(bool param, bool isLoad)
        {
            txtDienThoai.ReadOnly = false;

            txtDienThoai.Text = null;
            txtDiaChi.Text = null;
            btnThem.Enabled = param;
            txtTenKhach.Text = null;
            rdoNam.Enabled = param;
            rdoNu.Enabled = param;
        
            if (isLoad)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = !param;
                btnXoa.Enabled = !param;
            }
            rdoNam.Checked = true;
        }

        private void loadGridView()
        {
            dataGridViewKhachHang.Columns[0].HeaderText = "Số điện thoại";
            dataGridViewKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dataGridViewKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewKhachHang.Columns[3].HeaderText = "Giới tính";
            dataGridViewKhachHang.Columns[0].DividerWidth = 2;
            dataGridViewKhachHang.Columns[1].DividerWidth = 2;
            dataGridViewKhachHang.Columns[2].DividerWidth = 2;
            dataGridViewKhachHang.Columns[3].DividerWidth = 2;
        }

        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void showKhachHang()
        {
            dataGridViewKhachHang.DataSource = busKH.DanhSachKH();
            loadGridView();
            setValue(true, false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool isTrueSDT = int.TryParse(txtDienThoai.Text, out int sdt);

            if (isTrueSDT && txtDienThoai.Text != "" && txtTenKhach.Text != "" && rdoNam.Checked || rdoNu.Checked)
            {
                string gioitinh = (rdoNam.Checked) ? "Nam" : "Nữ";
                DTO_KhachHang khachHang = new DTO_KhachHang(txtDienThoai.Text, txtTenKhach.Text, txtDiaChi.Text, gioitinh, email);
                if (busKH.insertKhachHang(khachHang))
                {
                    msgBox("Thêm khách hàng thành công!");
                    showKhachHang();
                }
                else
                    msgBox("Thêm khách hàng không thành công", true);
            }
            else
                msgBox("Vui lòng kiểm tra lại dữ liệu", true);
        }

        // xuất danh sách khách hàng
        private void QL_KhachHang_Load(object sender, EventArgs e)
        {
            showKhachHang();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (busKH.deleteKhachHang(txtDienThoai.Text))
                {
                    msgBox("Xóa thành công");
                    showKhachHang();
                }
                else
                    msgBox("Không xóa được", true);
            }
        }

        private void dataGridViewKhachHang_Click(object sender, EventArgs e)
        {
            if (dataGridViewKhachHang.Rows.Count >0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                rdoNam.Enabled = true;
                rdoNu.Enabled = true;
        
                txtDienThoai.Text = dataGridViewKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKhach.Text = dataGridViewKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridViewKhachHang.CurrentRow.Cells[2].Value.ToString();
                string gioitinh = dataGridViewKhachHang.CurrentRow.Cells[3].Value.ToString();
                if (gioitinh == "Nam")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            setValue(true, false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool isTrueSDT = int.TryParse(txtDienThoai.Text, out int sdt);

            if (isTrueSDT && txtDienThoai.Text != "" && txtTenKhach.Text != "" && rdoNam.Checked || rdoNu.Checked)
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string gioitinh = (rdoNam.Checked) ? "Nam" : "Nữ";
                    DTO_KhachHang khachHang = new DTO_KhachHang(txtDienThoai.Text, txtTenKhach.Text, txtDiaChi.Text, gioitinh);
                    if (busKH.updateKhachHang(khachHang))
                    {
                        msgBox("Sửa khách hàng thành công!");
                        showKhachHang();
                    }
                    else
                        msgBox("Sửa khách hàng không thành công", true);
                }
            }
            else
                msgBox("Vui lòng kiểm tra lại dữ liệu", true);


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text !="")
            {
                DataTable data = busKH.searchKhachHang(txtTimKiem.Text);
                if (data.Rows.Count > 0)
                {
                    dataGridViewKhachHang.DataSource = data;
                    loadGridView();
                }
                else msgBox("Không tìm thấy khách hàng nào");
            }
        }
    }
}
