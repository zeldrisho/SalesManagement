
namespace GUI_QLBanHang
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGuild = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.menuHuongDan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemThongTinNV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.menuHuongDan.SuspendLayout();
            this.menuTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.pnMenu.Controls.Add(this.btnAccount);
            this.pnMenu.Controls.Add(this.lblEmail);
            this.pnMenu.Controls.Add(this.guna2Separator1);
            this.pnMenu.Controls.Add(this.btnLogin);
            this.pnMenu.Controls.Add(this.btnGuild);
            this.pnMenu.Controls.Add(this.btnStatistic);
            this.pnMenu.Controls.Add(this.btnProduct);
            this.pnMenu.Controls.Add(this.btnCustomer);
            this.pnMenu.Controls.Add(this.btnEmployee);
            this.pnMenu.Controls.Add(this.lbl1);
            this.pnMenu.Controls.Add(this.pcbIcon);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(208, 654);
            this.pnMenu.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.Animated = true;
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.CustomImages.Image = global::GUI_QLBanHang.Properties.Resources.taikhoan;
            this.btnAccount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.FillColor = System.Drawing.Color.Empty;
            this.btnAccount.FillColor2 = System.Drawing.Color.Empty;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnAccount.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnAccount.Location = new System.Drawing.Point(3, 401);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(202, 45);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.UseTransparentBackground = true;
            this.btnAccount.Visible = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.MouseHover += new System.EventHandler(this.btnAccount_MouseHover);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblEmail.Location = new System.Drawing.Point(9, 543);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(191, 59);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Đăng nhập để sử dụng";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(10, 532);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(189, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Image = global::GUI_QLBanHang.Properties.Resources.login_64px;
            this.btnLogin.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogin.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogin.FillColor2 = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnLogin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnLogin.Location = new System.Drawing.Point(5, 605);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(202, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseTransparentBackground = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGuild
            // 
            this.btnGuild.Animated = true;
            this.btnGuild.BackColor = System.Drawing.Color.Transparent;
            this.btnGuild.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuild.CustomImages.Image = global::GUI_QLBanHang.Properties.Resources.classroom_64px;
            this.btnGuild.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuild.FillColor = System.Drawing.Color.Empty;
            this.btnGuild.FillColor2 = System.Drawing.Color.Empty;
            this.btnGuild.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuild.ForeColor = System.Drawing.Color.White;
            this.btnGuild.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnGuild.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnGuild.Location = new System.Drawing.Point(3, 452);
            this.btnGuild.Name = "btnGuild";
            this.btnGuild.Size = new System.Drawing.Size(202, 45);
            this.btnGuild.TabIndex = 2;
            this.btnGuild.Text = "Hướng dẫn";
            this.btnGuild.UseTransparentBackground = true;
            this.btnGuild.Click += new System.EventHandler(this.btnGuild_Click);
            this.btnGuild.MouseHover += new System.EventHandler(this.btnGuild_MouseHover);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Animated = true;
            this.btnStatistic.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistic.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.CustomImages.Image = global::GUI_QLBanHang.Properties.Resources.combo_chart_64px;
            this.btnStatistic.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistic.FillColor = System.Drawing.Color.Empty;
            this.btnStatistic.FillColor2 = System.Drawing.Color.Empty;
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnStatistic.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnStatistic.Location = new System.Drawing.Point(3, 248);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(202, 45);
            this.btnStatistic.TabIndex = 2;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseTransparentBackground = true;
            this.btnStatistic.Visible = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Animated = true;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.CustomImages.Image = global::GUI_QLBanHang.Properties.Resources.product_64px;
            this.btnProduct.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.FillColor = System.Drawing.Color.Empty;
            this.btnProduct.FillColor2 = System.Drawing.Color.Empty;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnProduct.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnProduct.Location = new System.Drawing.Point(3, 299);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(202, 45);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.UseTransparentBackground = true;
            this.btnProduct.Visible = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Animated = true;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.CustomImages.Image = global::GUI_QLBanHang.Properties.Resources.people_working_together_48px;
            this.btnCustomer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.FillColor = System.Drawing.Color.Empty;
            this.btnCustomer.FillColor2 = System.Drawing.Color.Empty;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnCustomer.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnCustomer.Location = new System.Drawing.Point(3, 350);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(202, 45);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.UseTransparentBackground = true;
            this.btnCustomer.Visible = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Animated = true;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.CustomImages.Image = global::GUI_QLBanHang.Properties.Resources.user_48px;
            this.btnEmployee.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.FillColor = System.Drawing.Color.Empty;
            this.btnEmployee.FillColor2 = System.Drawing.Color.Empty;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnEmployee.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnEmployee.Location = new System.Drawing.Point(3, 197);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(202, 45);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Nhân viên";
            this.btnEmployee.UseTransparentBackground = true;
            this.btnEmployee.Visible = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1.Location = new System.Drawing.Point(6, 129);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(196, 30);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Quản Lý Bán Hàng";
            // 
            // pcbIcon
            // 
            this.pcbIcon.Image = global::GUI_QLBanHang.Properties.Resources.product_500px;
            this.pcbIcon.Location = new System.Drawing.Point(36, 24);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(136, 101);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 2;
            this.pcbIcon.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.pnMenu;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.panelControl;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // panelControl
            // 
            this.panelControl.BackgroundImage = global::GUI_QLBanHang.Properties.Resources.store;
            this.panelControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelControl.Location = new System.Drawing.Point(214, 33);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(913, 619);
            this.panelControl.TabIndex = 2;
            // 
            // menuHuongDan
            // 
            this.menuHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.menuHuongDan.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.menuHuongDan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHuongDan,
            this.toolStripSeparator1,
            this.itemGioiThieu});
            this.menuHuongDan.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuHuongDan.Name = "contextMenuStrip1";
            this.menuHuongDan.Size = new System.Drawing.Size(247, 70);
            // 
            // itemHuongDan
            // 
            this.itemHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.itemHuongDan.ForeColor = System.Drawing.Color.LightCoral;
            this.itemHuongDan.Image = global::GUI_QLBanHang.Properties.Resources.huongdan;
            this.itemHuongDan.Name = "itemHuongDan";
            this.itemHuongDan.Size = new System.Drawing.Size(246, 30);
            this.itemHuongDan.Text = "Hướng dẫn sử dụng";
            this.itemHuongDan.Click += new System.EventHandler(this.itemHuongDan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // itemGioiThieu
            // 
            this.itemGioiThieu.ForeColor = System.Drawing.Color.LightCoral;
            this.itemGioiThieu.Image = global::GUI_QLBanHang.Properties.Resources.gioithieu;
            this.itemGioiThieu.Name = "itemGioiThieu";
            this.itemGioiThieu.Size = new System.Drawing.Size(246, 30);
            this.itemGioiThieu.Text = "Giới thiệu phần mềm";
            this.itemGioiThieu.Click += new System.EventHandler(this.itemGioiThieu_Click);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.menuTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semilight", 13F);
            this.menuTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemThongTinNV,
            this.toolStripSeparator2,
            this.itemDoiMatKhau});
            this.menuTaiKhoan.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuTaiKhoan.Name = "contextMenuStrip1";
            this.menuTaiKhoan.Size = new System.Drawing.Size(209, 70);
            // 
            // itemThongTinNV
            // 
            this.itemThongTinNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.itemThongTinNV.ForeColor = System.Drawing.Color.LightCoral;
            this.itemThongTinNV.Image = global::GUI_QLBanHang.Properties.Resources.hoso;
            this.itemThongTinNV.Name = "itemThongTinNV";
            this.itemThongTinNV.Size = new System.Drawing.Size(208, 30);
            this.itemThongTinNV.Text = "Hồ sơ nhân viên";
            this.itemThongTinNV.Click += new System.EventHandler(this.itemThongTinNV_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // itemDoiMatKhau
            // 
            this.itemDoiMatKhau.ForeColor = System.Drawing.Color.LightCoral;
            this.itemDoiMatKhau.Image = global::GUI_QLBanHang.Properties.Resources.password_reset_64px;
            this.itemDoiMatKhau.Name = "itemDoiMatKhau";
            this.itemDoiMatKhau.Size = new System.Drawing.Size(208, 30);
            this.itemDoiMatKhau.Text = "Đổi mật khẩu";
            this.itemDoiMatKhau.Click += new System.EventHandler(this.itemDoiMatKhau_Click);
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl4.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1087, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1036, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(985, 1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1135, 654);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.menuHuongDan.ResumeLayout(false);
            this.menuTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnMenu;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lbl1;
        private Guna.UI2.WinForms.Guna2GradientButton btnEmployee;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuild;
        private Guna.UI2.WinForms.Guna2GradientButton btnStatistic;
        private Guna.UI2.WinForms.Guna2GradientButton btnProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btnCustomer;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.Panel panelControl;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private System.Windows.Forms.ContextMenuStrip menuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem itemHuongDan;
        private System.Windows.Forms.ToolStripMenuItem itemGioiThieu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ContextMenuStrip menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem itemThongTinNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemDoiMatKhau;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}

