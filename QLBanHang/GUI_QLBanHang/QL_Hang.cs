using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using DTO_QLBanHang;
using BUS_QLBanHang;
using System.Collections.Generic;

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
        //private string fileName;
        //private string fileSavePath;
        //private string checkFileName;
        private byte[] img;
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
            pcbSanPham.Image = null;
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

        private byte[] imageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
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

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridViewHang.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private bool checkIsNummber(string text)
        {
            return int.TryParse(text, out int s);
        }

        private void moHinh()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            open.Title = "Chọn ảnh";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileAddress = open.FileName;
                pcbSanPham.Image = cloneImage(fileAddress);

                //fileName = Path.GetFileName(fileAddress);
                //string saveDirectory = Application.StartupPath;
                //fileSavePath = saveDirectory + @"\Images\" + fileName ;
                //txtHinh.Text = fileName;

                pcbSanPham.ImageLocation = fileAddress;
                img = imageToByteArray(pcbSanPham);
            }
        }

        private void showHang()
        {
            dataGridViewHang.DataSource = busHang.DanhSachHang();
            loadGridView();
        }

        private void QL_Hang_Load(object sender, EventArgs e)
        {
            showHang();
            setValue(true, false);
            txtTenHang.Focus();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checkIsNummber(txtSoLuong.Text) || !checkIsNummber(txtDonGiaBan.Text) || !checkIsNummber(txtDonGiaNhap.Text))
                msgBox("Vui lòng nhập chữ số!", true);
            else if (txtTenHang.Text == "")
                msgBox("Thiếu trường thông tin!", true);
            else if (pcbSanPham.Image == null)
                msgBox("Vui lòng chọn hình!", true);
            else
            {
                DTO_Hang hang = new DTO_Hang()
                {
                    TenHang = txtTenHang.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    DonGiaBan = int.Parse(txtDonGiaBan.Text),
                    DonGiaNhap = int.Parse(txtDonGiaNhap.Text),
                    GhiChu = txtGhiChu.Text,
                    HinhAnh = imageToByteArray(pcbSanPham),
                    Email = email
                };
                if (busHang.insertHang(hang))
                {
                    showHang();
                    //if (File.Exists(fileSavePath))
                    //    File.Delete(fileSavePath);
                    //File.Copy(fileAddress, fileSavePath);
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
                //string Directory = Application.StartupPath;

                txtMaHang.ReadOnly = true;
                txtMaHang.Text = dataGridViewHang.CurrentRow.Cells[0].Value.ToString();
                txtTenHang.Text = dataGridViewHang.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dataGridViewHang.CurrentRow.Cells[2].Value.ToString();
                txtDonGiaNhap.Text = dataGridViewHang.CurrentRow.Cells[3].Value.ToString();
                txtDonGiaBan.Text = dataGridViewHang.CurrentRow.Cells[4].Value.ToString();
                //txtHinh.Text = checkFileName;
                //pcbSanPham.Image = cloneImage(Directory + @"\Images\" + checkFileName);

                MemoryStream memoryStream = new MemoryStream((byte[])dataGridViewHang.CurrentRow.Cells[5].Value);
                pcbSanPham.Image = Image.FromStream(memoryStream);

                txtGhiChu.Text = dataGridViewHang.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!checkIsNummber(txtSoLuong.Text) || !checkIsNummber(txtDonGiaBan.Text) || !checkIsNummber(txtDonGiaNhap.Text))
                    msgBox("Vui lòng nhập chữ số!", true);
                else if (txtTenHang.Text == "")
                    msgBox("Thiếu trường thông tin!", true);
                else if (pcbSanPham.Image == null)
                    msgBox("Vui lòng chọn hình!", true);
                else
                {
                    DTO_Hang hang = new DTO_Hang()
                    {
                        TenHang = txtTenHang.Text,
                        SoLuong = int.Parse(txtSoLuong.Text),
                        DonGiaBan = int.Parse(txtDonGiaBan.Text),
                        DonGiaNhap = int.Parse(txtDonGiaNhap.Text),
                        GhiChu = txtGhiChu.Text,
                        HinhAnh = imageToByteArray(pcbSanPham),
                        MaHang = int.Parse(txtMaHang.Text)
                    };
                    if (busHang.updateHang(hang))
                    {
                        showHang();
                        //if (hang.HinhAnh != checkFileName)
                        //{
                        //    if (File.Exists(fileSavePath))
                        //        File.Delete(fileSavePath);
                        //    File.Copy(fileAddress, fileSavePath);
                        //}
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

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    if (txtSearch.Text != "")
        //    {
        //        DataTable table = busHang.searchHang(txtSearch.Text);
        //        if (table.Rows.Count > 0)
        //        {
        //            dataGridViewHang.DataSource = table;
        //        }
        //        else
        //            msgBox("Không tìm thấy kết quả!");
        //    }
        //}

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            setValue(true, false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            if (name == "")
            {
                QL_Hang_Load(sender, e);
                txtSearch.Focus();
            }
            else
            {
                DataTable data = busHang.searchHang(txtSearch.Text);
                dataGridViewHang.DataSource = data;
            }
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            frmProductReport frmProductReport = new frmProductReport();
            frmProductReport.ShowDialog();
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            // Lỗi cột image
            //for (int i = 0; i < dataGridViewHang.Columns.Count; i++)
            //{
            //    application.Cells[1, i + 1] = dataGridViewHang.Columns[i].HeaderText;
            //}
            application.Cells[1, 1] = dataGridViewHang.Columns[0].HeaderText;
            application.Cells[1, 2] = dataGridViewHang.Columns[1].HeaderText;
            application.Cells[1, 3] = dataGridViewHang.Columns[2].HeaderText;
            application.Cells[1, 4] = dataGridViewHang.Columns[3].HeaderText;
            application.Cells[1, 5] = dataGridViewHang.Columns[4].HeaderText;
            application.Cells[1, 6] = dataGridViewHang.Columns[6].HeaderText;

            for (int i = 0; i < dataGridViewHang.Rows.Count; i++)
            {
                //for (int j = 0; j < dataGridViewHang.Columns.Count; j++)
                //{
                //    application.Cells[i + 2, j + 1] = dataGridViewHang.Rows[i].Cells[j].Value;
                //}
                application.Cells[i + 2, 1] = dataGridViewHang.Rows[i].Cells[0].Value;
                application.Cells[i + 2, 2] = dataGridViewHang.Rows[i].Cells[1].Value;
                application.Cells[i + 2, 3] = dataGridViewHang.Rows[i].Cells[2].Value;
                application.Cells[i + 2, 4] = dataGridViewHang.Rows[i].Cells[3].Value;
                application.Cells[i + 2, 5] = dataGridViewHang.Rows[i].Cells[4].Value;
                application.Cells[i + 2, 6] = dataGridViewHang.Rows[i].Cells[6].Value;
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet sheet = excelPackage.Workbook.Worksheets[0];
                DataTable data = new DataTable();
                for (int i = sheet.Dimension.Start.Column; i <= sheet.Dimension.End.Column; i++)
                {
                    data.Columns.Add(sheet.Cells[1, i].Value.ToString());
                }
                for (int i = sheet.Dimension.Start.Row + 1; i <= sheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = sheet.Dimension.Start.Column; j <= sheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(sheet.Cells[i, j].Value.ToString());
                    }
                }
                dataGridViewHang.DataSource = data;
                showHang();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file thành công!\n" + ex.Message);
                }
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file thành công!\n" + ex.Message);
                }
            }
        }
    }
}
