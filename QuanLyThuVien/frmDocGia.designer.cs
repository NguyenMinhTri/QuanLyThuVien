namespace UI
{
    partial class frmDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this._btnDangKi = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._tbHoTen = new System.Windows.Forms.TextBox();
            this._cbbLoaiDocGia = new System.Windows.Forms.ComboBox();
            this._tbDiaChi = new System.Windows.Forms.TextBox();
            this._tbMail = new System.Windows.Forms.TextBox();
            this._dtNgayHetHan = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this._dtNgayLapThe = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this._dtNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this._btnThemMoi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this._dtNgayHetHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dtNgayLapThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dtNgaySinh)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(270, 353);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 64;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _btnDangKi
            // 
            this._btnDangKi.Location = new System.Drawing.Point(58, 353);
            this._btnDangKi.Name = "_btnDangKi";
            this._btnDangKi.Size = new System.Drawing.Size(75, 23);
            this._btnDangKi.TabIndex = 65;
            this._btnDangKi.Text = "Đăng Ký";
            this._btnDangKi.UseSelectable = true;
            this._btnDangKi.Click += new System.EventHandler(this._btnDangKi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Ngày Hết Hạn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ngày Lập Thẻ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Loại Độc Giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Họ Và Tên:";
            // 
            // _tbHoTen
            // 
            this._tbHoTen.Location = new System.Drawing.Point(152, 67);
            this._tbHoTen.Name = "_tbHoTen";
            this._tbHoTen.Size = new System.Drawing.Size(193, 20);
            this._tbHoTen.TabIndex = 60;
            // 
            // _cbbLoaiDocGia
            // 
            this._cbbLoaiDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbbLoaiDocGia.FormattingEnabled = true;
            this._cbbLoaiDocGia.Location = new System.Drawing.Point(152, 186);
            this._cbbLoaiDocGia.Name = "_cbbLoaiDocGia";
            this._cbbLoaiDocGia.Size = new System.Drawing.Size(193, 21);
            this._cbbLoaiDocGia.TabIndex = 63;
            // 
            // _tbDiaChi
            // 
            this._tbDiaChi.Location = new System.Drawing.Point(152, 107);
            this._tbDiaChi.Name = "_tbDiaChi";
            this._tbDiaChi.Size = new System.Drawing.Size(193, 20);
            this._tbDiaChi.TabIndex = 61;
            // 
            // _tbMail
            // 
            this._tbMail.Location = new System.Drawing.Point(152, 147);
            this._tbMail.Name = "_tbMail";
            this._tbMail.Size = new System.Drawing.Size(193, 20);
            this._tbMail.TabIndex = 62;
            // 
            // _dtNgayHetHan
            // 
            // 
            // 
            // 
            this._dtNgayHetHan.BackgroundStyle.Class = "DateTimeInputBackground";
            this._dtNgayHetHan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgayHetHan.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this._dtNgayHetHan.IsInputReadOnly = true;
            this._dtNgayHetHan.IsPopupCalendarOpen = false;
            this._dtNgayHetHan.Location = new System.Drawing.Point(152, 307);
            // 
            // 
            // 
            this._dtNgayHetHan.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._dtNgayHetHan.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgayHetHan.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this._dtNgayHetHan.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this._dtNgayHetHan.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this._dtNgayHetHan.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this._dtNgayHetHan.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this._dtNgayHetHan.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._dtNgayHetHan.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this._dtNgayHetHan.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this._dtNgayHetHan.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgayHetHan.MonthCalendar.DisplayMonth = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this._dtNgayHetHan.MonthCalendar.MarkedDates = new System.DateTime[0];
            this._dtNgayHetHan.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._dtNgayHetHan.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._dtNgayHetHan.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this._dtNgayHetHan.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._dtNgayHetHan.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgayHetHan.MonthCalendar.TodayButtonVisible = true;
            this._dtNgayHetHan.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this._dtNgayHetHan.Name = "_dtNgayHetHan";
            this._dtNgayHetHan.Size = new System.Drawing.Size(193, 20);
            this._dtNgayHetHan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._dtNgayHetHan.TabIndex = 52;
            // 
            // _dtNgayLapThe
            // 
            // 
            // 
            // 
            this._dtNgayLapThe.BackgroundStyle.Class = "DateTimeInputBackground";
            this._dtNgayLapThe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgayLapThe.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this._dtNgayLapThe.ButtonDropDown.Visible = true;
            this._dtNgayLapThe.IsPopupCalendarOpen = false;
            this._dtNgayLapThe.Location = new System.Drawing.Point(152, 267);
            // 
            // 
            // 
            this._dtNgayLapThe.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._dtNgayLapThe.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgayLapThe.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this._dtNgayLapThe.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this._dtNgayLapThe.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this._dtNgayLapThe.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this._dtNgayLapThe.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this._dtNgayLapThe.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._dtNgayLapThe.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this._dtNgayLapThe.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this._dtNgayLapThe.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgayLapThe.MonthCalendar.DisplayMonth = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this._dtNgayLapThe.MonthCalendar.MarkedDates = new System.DateTime[0];
            this._dtNgayLapThe.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._dtNgayLapThe.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._dtNgayLapThe.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this._dtNgayLapThe.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._dtNgayLapThe.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgayLapThe.MonthCalendar.TodayButtonVisible = true;
            this._dtNgayLapThe.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this._dtNgayLapThe.Name = "_dtNgayLapThe";
            this._dtNgayLapThe.Size = new System.Drawing.Size(193, 20);
            this._dtNgayLapThe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._dtNgayLapThe.TabIndex = 51;
            // 
            // _dtNgaySinh
            // 
            // 
            // 
            // 
            this._dtNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this._dtNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this._dtNgaySinh.ButtonDropDown.Visible = true;
            this._dtNgaySinh.IsPopupCalendarOpen = false;
            this._dtNgaySinh.Location = new System.Drawing.Point(152, 227);
            // 
            // 
            // 
            this._dtNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._dtNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this._dtNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this._dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this._dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this._dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this._dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this._dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this._dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this._dtNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this._dtNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this._dtNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this._dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this._dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._dtNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._dtNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this._dtNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this._dtNgaySinh.Name = "_dtNgaySinh";
            this._dtNgaySinh.Size = new System.Drawing.Size(193, 20);
            this._dtNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._dtNgaySinh.TabIndex = 50;
            // 
            // _btnThemMoi
            // 
            this._btnThemMoi.Location = new System.Drawing.Point(163, 353);
            this._btnThemMoi.Name = "_btnThemMoi";
            this._btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this._btnThemMoi.TabIndex = 66;
            this._btnThemMoi.Text = "Thêm Mới";
            this._btnThemMoi.UseSelectable = true;
            this._btnThemMoi.Click += new System.EventHandler(this._btnThemMoi_Click);
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 397);
            this.Controls.Add(this._btnThemMoi);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnDangKi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._tbHoTen);
            this.Controls.Add(this._cbbLoaiDocGia);
            this.Controls.Add(this._tbDiaChi);
            this.Controls.Add(this._tbMail);
            this.Controls.Add(this._dtNgayHetHan);
            this.Controls.Add(this._dtNgayLapThe);
            this.Controls.Add(this._dtNgaySinh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDocGia";
            this.Resizable = false;
            this.Text = "Đăng Ký Độc Giả";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtNgayHetHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dtNgayLapThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dtNgaySinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton _btnThoat;
        private MetroFramework.Controls.MetroButton _btnDangKi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _tbHoTen;
        private System.Windows.Forms.ComboBox _cbbLoaiDocGia;
        private System.Windows.Forms.TextBox _tbDiaChi;
        private System.Windows.Forms.TextBox _tbMail;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput _dtNgayHetHan;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput _dtNgayLapThe;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput _dtNgaySinh;
        private MetroFramework.Controls.MetroButton _btnThemMoi;
    }
}