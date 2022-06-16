using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using BUS_QLBanHang;
using DTO_QLBanHang;
namespace GUI_QLBanHang
{
    public partial class QL_NhanVien : UserControl
    {
        public QL_NhanVien()
        {
            InitializeComponent();
        }
        //thiết lập
        BUS_NhanVien busNV = new BUS_NhanVien();
        private void setValue(bool param, bool isLoad)
        {
            txtEmail.ReadOnly = false;

            txtEmail.Text = null;
            txtDiaChi.Text = null;
            btnThem.Enabled = param;
            txtTenNhanVien.Text = null;
            rdoHoatDong.Enabled = param;
            rdoNgungHoatDong.Enabled = param;
            rdoNhanVien.Enabled = param;
            rdoQuanTri.Enabled = param;
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
            //rdoQuanTri.Checked = false;
            rdoNhanVien.Checked = true;
            //rdoNgungHoatDong.Checked = false;
            rdoHoatDong.Checked = true;
        }

        private bool isValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void loadGridView()
        {
            dataGridViewNhanVien.Columns[0].HeaderText = "Email";
            dataGridViewNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dataGridViewNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewNhanVien.Columns[3].HeaderText = "Vai trò";
            dataGridViewNhanVien.Columns[4].HeaderText = "Tình trạng";
            dataGridViewNhanVien.Columns[0].Width = 250;
            dataGridViewNhanVien.Columns[0].DividerWidth = 2;
            dataGridViewNhanVien.Columns[1].DividerWidth = 2;
            dataGridViewNhanVien.Columns[2].DividerWidth = 2;
            dataGridViewNhanVien.Columns[3].DividerWidth = 2;
            dataGridViewNhanVien.Columns[4].DividerWidth = 2;
        }
        // xuất danh sách nhân viên
        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            showNhanVien();
            setValue(true, false);
        }
     
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showNhanVien();
        }
        private void showNhanVien()
        {
            dataGridViewNhanVien.DataSource = busNV.danhSachNV();
            loadGridView();
        }
        
        // thêm nhân viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != "" && txtEmail.Text != "" && txtTenNhanVien.Text != ""
                && rdoHoatDong.Checked || rdoNgungHoatDong.Checked && rdoNhanVien.Checked || rdoQuanTri.Checked)
            {
                if (isValidEmail(txtEmail.Text))
                {
                    int vaitro = (rdoQuanTri.Checked) ? 1 : 0;
                    int tinhtrang = (rdoHoatDong.Checked) ? 1 : 0;
                    // gọi đối tượng mail để có thể tạo random mật khẩu và sendmail

                    string password = busNV.getPassword();
                    DTO_NhanVien nhanVien = new DTO_NhanVien(txtEmail.Text, txtTenNhanVien.Text, txtDiaChi.Text, vaitro, tinhtrang, password);
                    if (busNV.insertNhanVien(nhanVien))
                    {
                        msgBox("Thêm nhân viên thành công!");
                        setValue(false, true);
                        showNhanVien();
                        // send mail 
                        SendMail load = new SendMail(nhanVien.EmailNV, password);
                        load.ShowDialog();
                        msgBox(load.getResult);
                    }
                    else
                        msgBox("Không thêm nhân viên được", true);
                }
                else msgBox("Email không đúng định dạng!", true);
            }
            else msgBox("Thiếu trường thông tin!", true);
        }

        private void dataGridViewNhanVien_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            rdoNgungHoatDong.Enabled = true;
            rdoHoatDong.Enabled = true;
            rdoNhanVien.Enabled = true;
            rdoQuanTri.Enabled = true;
            txtEmail.ReadOnly = true;
            txtEmail.Text = dataGridViewNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dataGridViewNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridViewNhanVien.CurrentRow.Cells[2].Value.ToString();
            int vaitro = int.Parse(dataGridViewNhanVien.CurrentRow.Cells[3].Value.ToString());
            int tinhtrang = int.Parse(dataGridViewNhanVien.CurrentRow.Cells[4].Value.ToString());
            if (vaitro == 1)
                rdoQuanTri.Checked = true;
            else
                rdoNhanVien.Checked = true;
            if (tinhtrang == 1)
                rdoHoatDong.Checked = true;
            else
                rdoNgungHoatDong.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != "" && txtEmail.Text != "" && txtTenNhanVien.Text != ""
               && rdoHoatDong.Checked || rdoNgungHoatDong.Checked && rdoNhanVien.Checked || rdoQuanTri.Checked)
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int vaitro = (rdoQuanTri.Checked) ? 1 : 0;
                    int tinhtrang = (rdoHoatDong.Checked) ? 1 : 0;
                    DTO_NhanVien nhanVien = new DTO_NhanVien(txtEmail.Text, txtTenNhanVien.Text, txtDiaChi.Text, vaitro, tinhtrang);
                    if (busNV.updateNhanVien(nhanVien))
                    {
                        msgBox("Sửa nhân viên thành công!");
                        setValue(false, true);
                        showNhanVien();
                    }
                    else
                        msgBox("Sửa nhân viên không thành công", true);
                } else
                    setValue(false, true);
            }
            else msgBox("Thiếu trường thông tin!", true);
        }

        // xóa nhân viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNV.deleteNhanVien(txtEmail.Text))
                {
                    msgBox("Xóa nhân viên thành công!");
                    setValue(true, false);
                    showNhanVien();
                }
                else
                    msgBox("Xóa nhân viên không thành công", true);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            setValue(true, false);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text != "")
            {
                DataTable data = busNV.searchNhanVien(txttimkiem.Text);
                if (data.Rows.Count >0)
                {
                    dataGridViewNhanVien.DataSource = data;
                    loadGridView();
                }
                else
                {
                    msgBox("Không tìm thấy nhân viên nào!");
                }
            }else msgBox("Vui lòng nhập tên cần tìm kiếm", true);
        }
    }
}
