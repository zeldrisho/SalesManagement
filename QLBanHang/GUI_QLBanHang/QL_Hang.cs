using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DTO_QLBanHang;
using BUS_QLBanHang;
using System.IO;

namespace GUI_QLBanHang
{
    public partial class QL_Hang : UserControl
    {
        public QL_Hang(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        private string email;
        private string fileAddress;
        private string fileName;
        private string fileSavePath;
        private string checkFileName;
        BUS_Hang busHang = new BUS_Hang();
        private void setValue(bool param, bool isLoad)
        {

            txtMaHang.Text = null;
            txtMaHang.Enabled = !param;

            txtTenHang.Text = null;
            txtSoLuong.Text = null;
            txtDonGiaBan.Text = null;
            txtDonGiaNhap.Text = null;
            txtHinh.Text = null;
            txtGhiChu.Text = null;
            btnThem.Enabled = param;
            pcbSanPham.Image = Properties.Resources.pic;
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
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private Image cloneImage(string path)
        {
            Image result;
            using (Bitmap original = new Bitmap(path)) 
            {
                result = (Bitmap)original.Clone();

            };

            return result;
        }
        private void loadGridView()
        {
            dataGridViewHang.Columns[0].HeaderText = "Mã hàng";
            dataGridViewHang.Columns[1].HeaderText = "Tên hàng";
            dataGridViewHang.Columns[2].HeaderText = "Số lượng";
            dataGridViewHang.Columns[3].HeaderText = "Đơn giá nhập";
            dataGridViewHang.Columns[4].HeaderText = "Đơn giá bán";
            dataGridViewHang.Columns[5].HeaderText = "Hình ảnh";
            dataGridViewHang.Columns[6].HeaderText = "Ghi chú";
            foreach (DataGridViewColumn item in dataGridViewHang.Columns)
                item.DividerWidth = 2;
        }
        private bool checkIsNummber(string text)
        {
            return int.TryParse(text,out int s);
        }
        private void moHinh()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            open.FilterIndex = 1;
            open.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileAddress = open.FileName;
                pcbSanPham.Image = cloneImage(fileAddress) ;
                fileName = Path.GetFileName(fileAddress);
                string saveDirectory = Application.StartupPath;
                fileSavePath = saveDirectory + @"\Images\" + fileName ;
                txtHinh.Text = fileName;
            }
        }
        // show 
        private void showHang()
        {
            dataGridViewHang.DataSource = busHang.DanhSachHang();
            loadGridView();
        }

        private void QL_Hang_Load(object sender, EventArgs e)
        {
            showHang();
            setValue(true, false);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // check number 
            if (!checkIsNummber(txtSoLuong.Text) || !checkIsNummber(txtDonGiaBan.Text) || !checkIsNummber(txtDonGiaNhap.Text))
                msgBox("Vui lòng nhập chữ số!", true);
            else if (txtTenHang.Text == "" || txtGhiChu.Text == "")
                msgBox("Thiếu trường thông tin!", true);
            else if (txtHinh.Text == "")
                msgBox("Vui lòng chọn hình!", true);
            else
            {
                DTO_Hang hang = new DTO_Hang()
                {
                    tenHang = txtTenHang.Text,
                    soLuong = int.Parse(txtSoLuong.Text),
                    donGiaBan = int.Parse(txtDonGiaBan.Text),
                    donGiaNhap = int.Parse(txtDonGiaNhap.Text),
                    ghiChu = txtGhiChu.Text,
                    hinhAnh = fileName,
                    email = this.email
                };
                if (busHang.insertHang(hang))
                {
                    showHang();
                    if (File.Exists(fileSavePath))
                        File.Delete(fileSavePath);

                    File.Copy(fileAddress, fileSavePath);

                    msgBox("Thêm sản phẩm thành công");
                }
                else
                {
                    msgBox("Thêm sản phẩm không được", true);
                }

            }
        }

        private void btnMoHinh_Click(object sender, EventArgs e)
        {
            moHinh();
        }

        private void pcbSanPham_Click(object sender, EventArgs e)
        {
            moHinh();
        }
        
        private void dataGridViewHang_Click(object sender, EventArgs e)
        {
            if (dataGridViewHang.Rows.Count > 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                string Directory = Application.StartupPath;

                txtMaHang.ReadOnly = true;
                txtMaHang.Text = dataGridViewHang.CurrentRow.Cells[0].Value.ToString();
                txtTenHang.Text = dataGridViewHang.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dataGridViewHang.CurrentRow.Cells[2].Value.ToString();
                txtDonGiaNhap.Text = dataGridViewHang.CurrentRow.Cells[3].Value.ToString();
                txtDonGiaBan.Text = dataGridViewHang.CurrentRow.Cells[4].Value.ToString();
                checkFileName = dataGridViewHang.CurrentRow.Cells[5].Value.ToString();
                txtHinh.Text = checkFileName;
                pcbSanPham.Image = cloneImage(Directory + @"\Images\" + checkFileName);
                txtGhiChu.Text = dataGridViewHang.CurrentRow.Cells[6].Value.ToString();
            }

        }
        // sửa

        private void btnSua_Click(object sender, EventArgs e)
        {
            // check number 
            if (MessageBox.Show("Bạn có chắc muốn sửa?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!checkIsNummber(txtSoLuong.Text) || !checkIsNummber(txtDonGiaBan.Text) || !checkIsNummber(txtDonGiaNhap.Text))
                    msgBox("Vui lòng nhập chữ số!", true);
                else if (txtTenHang.Text == "" || txtGhiChu.Text == "")
                    msgBox("Thiếu trường thông tin!", true);
                else if (txtHinh.Text == "")
                    msgBox("Vui lòng chọn hình!", true);
                else
                {
                    DTO_Hang hang = new DTO_Hang()
                    {
                        tenHang = txtTenHang.Text,
                        soLuong = int.Parse(txtSoLuong.Text),
                        donGiaBan = int.Parse(txtDonGiaBan.Text),
                        donGiaNhap = int.Parse(txtDonGiaNhap.Text),
                        ghiChu = txtGhiChu.Text,
                        hinhAnh = txtHinh.Text,
                        maHang = int.Parse(txtMaHang.Text)
                    };
                    if (busHang.updateHang(hang))
                    {
                        showHang();
                        if (hang.hinhAnh != checkFileName)
                        {
                            if (File.Exists(fileSavePath))
                                File.Delete(fileSavePath);
                            File.Copy(fileAddress, fileSavePath);
                        }
                        msgBox("Sửa sản phẩm thành công!");
                    }
                    else
                    {
                        msgBox("Sửa sản phẩm không được", true);
                    }
                }
            }
        }

        // xóa

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?" , "Xác nhận" , MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busHang.deleteHang(txtMaHang.Text))
                {
                    showHang();
                    msgBox("Xóa thành công");
                }
                else
                    msgBox("Xóa không thành công!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                DataTable table = busHang.searchHang(txtTimKiem.Text);
                if (table.Rows.Count > 0)
                {
                    dataGridViewHang.DataSource = table;
                }
                else
                    msgBox("Không tìm thấy kết quả!");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            setValue(true, false);
        }
    }
}
