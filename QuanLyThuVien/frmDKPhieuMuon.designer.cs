namespace UI
{
    partial class frmDKPhieuMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDKPhieuMuon));
            this.label1 = new System.Windows.Forms.Label();
            this._tbMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._tbMaSachMuon = new System.Windows.Forms.TextBox();
            this._btnThemDS = new MetroFramework.Controls.MetroButton();
            this._lbTenBangDocGia = new System.Windows.Forms.Label();
            this._tableDS = new MetroFramework.Controls.MetroGrid();
            this._dgw_txtMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._btnLapPhieu = new MetroFramework.Controls.MetroButton();
            this._dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this._btnThemMoi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this._tableDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả:";
            // 
            // _tbMaDG
            // 
            this._tbMaDG.Location = new System.Drawing.Point(96, 63);
            this._tbMaDG.Name = "_tbMaDG";
            this._tbMaDG.Size = new System.Drawing.Size(200, 20);
            this._tbMaDG.TabIndex = 1;
            this._tbMaDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbMaDG_KeyPress);
            this._tbMaDG.Leave += new System.EventHandler(this._tbMaDG_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên:";
            // 
            // _tbHoTen
            // 
            this._tbHoTen.Enabled = false;
            this._tbHoTen.Location = new System.Drawing.Point(96, 103);
            this._tbHoTen.Name = "_tbHoTen";
            this._tbHoTen.ReadOnly = true;
            this._tbHoTen.Size = new System.Drawing.Size(200, 20);
            this._tbHoTen.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Mượn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Sách Cần Mượn :";
            // 
            // _tbMaSachMuon
            // 
            this._tbMaSachMuon.Location = new System.Drawing.Point(451, 63);
            this._tbMaSachMuon.Name = "_tbMaSachMuon";
            this._tbMaSachMuon.Size = new System.Drawing.Size(152, 20);
            this._tbMaSachMuon.TabIndex = 2;
            this._tbMaSachMuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbMaSachMuon_KeyPress);
            this._tbMaSachMuon.Leave += new System.EventHandler(this._tbMaSachMuon_Leave);
            // 
            // _btnThemDS
            // 
            this._btnThemDS.Location = new System.Drawing.Point(340, 100);
            this._btnThemDS.Name = "_btnThemDS";
            this._btnThemDS.Size = new System.Drawing.Size(263, 23);
            this._btnThemDS.TabIndex = 3;
            this._btnThemDS.Text = "Thêm Sách Vào Chi Tiết Sách Mượn";
            this._btnThemDS.UseSelectable = true;
            this._btnThemDS.Click += new System.EventHandler(this._btnThemDS_Click);
            // 
            // _lbTenBangDocGia
            // 
            this._lbTenBangDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbTenBangDocGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._lbTenBangDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbTenBangDocGia.Location = new System.Drawing.Point(26, 166);
            this._lbTenBangDocGia.Name = "_lbTenBangDocGia";
            this._lbTenBangDocGia.Size = new System.Drawing.Size(577, 22);
            this._lbTenBangDocGia.TabIndex = 9;
            this._lbTenBangDocGia.Text = "Chi Tiết Sách Mượn";
            this._lbTenBangDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tableDS
            // 
            this._tableDS.AllowUserToAddRows = false;
            this._tableDS.AllowUserToDeleteRows = false;
            this._tableDS.AllowUserToResizeRows = false;
            this._tableDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._tableDS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tableDS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tableDS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._tableDS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._tableDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._tableDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tableDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._dgw_txtMaSach,
            this._dgw_txtTenSach,
            this._dgw_txtTacGia,
            this._dgw_txtTheLoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._tableDS.DefaultCellStyle = dataGridViewCellStyle2;
            this._tableDS.EnableHeadersVisualStyles = false;
            this._tableDS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._tableDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tableDS.Location = new System.Drawing.Point(26, 192);
            this._tableDS.Name = "_tableDS";
            this._tableDS.ReadOnly = true;
            this._tableDS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._tableDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._tableDS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._tableDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._tableDS.Size = new System.Drawing.Size(588, 188);
            this._tableDS.TabIndex = 10;
            // 
            // _dgw_txtMaSach
            // 
            this._dgw_txtMaSach.HeaderText = "Mã Sách";
            this._dgw_txtMaSach.Name = "_dgw_txtMaSach";
            this._dgw_txtMaSach.ReadOnly = true;
            // 
            // _dgw_txtTenSach
            // 
            this._dgw_txtTenSach.HeaderText = "Tên Sách";
            this._dgw_txtTenSach.Name = "_dgw_txtTenSach";
            this._dgw_txtTenSach.ReadOnly = true;
            // 
            // _dgw_txtTacGia
            // 
            this._dgw_txtTacGia.HeaderText = "Tác Giả";
            this._dgw_txtTacGia.Name = "_dgw_txtTacGia";
            this._dgw_txtTacGia.ReadOnly = true;
            // 
            // _dgw_txtTheLoai
            // 
            this._dgw_txtTheLoai.HeaderText = "Thể Loại";
            this._dgw_txtTheLoai.Name = "_dgw_txtTheLoai";
            this._dgw_txtTheLoai.ReadOnly = true;
            // 
            // _btnLapPhieu
            // 
            this._btnLapPhieu.Location = new System.Drawing.Point(26, 386);
            this._btnLapPhieu.Name = "_btnLapPhieu";
            this._btnLapPhieu.Size = new System.Drawing.Size(108, 23);
            this._btnLapPhieu.TabIndex = 4;
            this._btnLapPhieu.Text = "Lập Phiếu Mượn";
            this._btnLapPhieu.UseSelectable = true;
            this._btnLapPhieu.Click += new System.EventHandler(this._btnLapPhieu_Click);
            // 
            // _dtNgayMuon
            // 
            this._dtNgayMuon.Location = new System.Drawing.Point(96, 143);
            this._dtNgayMuon.Name = "_dtNgayMuon";
            this._dtNgayMuon.Size = new System.Drawing.Size(200, 20);
            this._dtNgayMuon.TabIndex = 12;
            this._dtNgayMuon.Value = new System.DateTime(2015, 12, 7, 12, 11, 5, 0);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(527, 386);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 5;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _btnThemMoi
            // 
            this._btnThemMoi.Location = new System.Drawing.Point(273, 386);
            this._btnThemMoi.Name = "_btnThemMoi";
            this._btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this._btnThemMoi.TabIndex = 13;
            this._btnThemMoi.Text = "Thêm Mới";
            this._btnThemMoi.UseSelectable = true;
            this._btnThemMoi.Click += new System.EventHandler(this._btnThemMoi_Click);
            // 
            // frmDKPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 424);
            this.Controls.Add(this._btnThemMoi);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._dtNgayMuon);
            this.Controls.Add(this._btnLapPhieu);
            this.Controls.Add(this._tableDS);
            this.Controls.Add(this._lbTenBangDocGia);
            this.Controls.Add(this._btnThemDS);
            this.Controls.Add(this._tbMaSachMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._tbHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tbMaDG);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDKPhieuMuon";
            this.Resizable = false;
            this.Text = "Phiếu Mượn Sách";
            ((System.ComponentModel.ISupportInitialize)(this._tableDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbMaSachMuon;
        private MetroFramework.Controls.MetroButton _btnThemDS;
        private System.Windows.Forms.Label _lbTenBangDocGia;
        private MetroFramework.Controls.MetroGrid _tableDS;
        private MetroFramework.Controls.MetroButton _btnLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTheLoai;
        private System.Windows.Forms.DateTimePicker _dtNgayMuon;
        private MetroFramework.Controls.MetroButton _btnThoat;
        private MetroFramework.Controls.MetroButton _btnThemMoi;
    }
}