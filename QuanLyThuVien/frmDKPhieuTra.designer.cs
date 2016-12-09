namespace UI
{
    partial class frmDKPhieuTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDKPhieuTra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbMaDG = new System.Windows.Forms.TextBox();
            this._tbHoTen = new System.Windows.Forms.TextBox();
            this._dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this._tbTongNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._tbTienPhat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._tbMaSach = new System.Windows.Forms.TextBox();
            this._btnThemSach = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this._tableSach = new MetroFramework.Controls.MetroGrid();
            this._dgw_txtMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtSoNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtTienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._btnLapPhieu = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this._btnThemMoi = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this._tableSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Trả:";
            // 
            // _tbMaDG
            // 
            this._tbMaDG.Location = new System.Drawing.Point(107, 57);
            this._tbMaDG.Name = "_tbMaDG";
            this._tbMaDG.Size = new System.Drawing.Size(200, 20);
            this._tbMaDG.TabIndex = 1;
            this._tbMaDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbMaDG_KeyPress);
            this._tbMaDG.Leave += new System.EventHandler(this._tbMaDG_Leave);
            // 
            // _tbHoTen
            // 
            this._tbHoTen.Location = new System.Drawing.Point(107, 97);
            this._tbHoTen.Name = "_tbHoTen";
            this._tbHoTen.ReadOnly = true;
            this._tbHoTen.Size = new System.Drawing.Size(200, 20);
            this._tbHoTen.TabIndex = 10;
            // 
            // _dtNgayTra
            // 
            this._dtNgayTra.Enabled = false;
            this._dtNgayTra.Location = new System.Drawing.Point(107, 136);
            this._dtNgayTra.Name = "_dtNgayTra";
            this._dtNgayTra.Size = new System.Drawing.Size(200, 20);
            this._dtNgayTra.TabIndex = 10;
            this._dtNgayTra.Value = new System.DateTime(2015, 12, 13, 22, 25, 20, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Nợ:";
            // 
            // _tbTongNo
            // 
            this._tbTongNo.Location = new System.Drawing.Point(440, 404);
            this._tbTongNo.Name = "_tbTongNo";
            this._tbTongNo.ReadOnly = true;
            this._tbTongNo.Size = new System.Drawing.Size(223, 20);
            this._tbTongNo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền Phạt Kỳ Này:";
            // 
            // _tbTienPhat
            // 
            this._tbTienPhat.Location = new System.Drawing.Point(130, 404);
            this._tbTienPhat.Name = "_tbTienPhat";
            this._tbTienPhat.ReadOnly = true;
            this._tbTienPhat.Size = new System.Drawing.Size(200, 20);
            this._tbTienPhat.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Sách:";
            // 
            // _tbMaSach
            // 
            this._tbMaSach.Location = new System.Drawing.Point(426, 57);
            this._tbMaSach.Name = "_tbMaSach";
            this._tbMaSach.Size = new System.Drawing.Size(200, 20);
            this._tbMaSach.TabIndex = 2;
            // 
            // _btnThemSach
            // 
            this._btnThemSach.Location = new System.Drawing.Point(427, 94);
            this._btnThemSach.Name = "_btnThemSach";
            this._btnThemSach.Size = new System.Drawing.Size(199, 23);
            this._btnThemSach.TabIndex = 3;
            this._btnThemSach.Text = "Thêm Sách Vào Chi Tiết Sách Trả";
            this._btnThemSach.UseSelectable = true;
            this._btnThemSach.Click += new System.EventHandler(this._btnThemSach_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chi Tiết Sách Trả";
            // 
            // _tableSach
            // 
            this._tableSach.AllowUserToAddRows = false;
            this._tableSach.AllowUserToDeleteRows = false;
            this._tableSach.AllowUserToResizeRows = false;
            this._tableSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._tableSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tableSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tableSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._tableSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._tableSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._tableSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tableSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._dgw_txtMaSach,
            this._dgw_txtNgayMuon,
            this._dgw_txtSoNgayMuon,
            this._dgw_txtTienPhat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._tableSach.DefaultCellStyle = dataGridViewCellStyle2;
            this._tableSach.EnableHeadersVisualStyles = false;
            this._tableSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._tableSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tableSach.Location = new System.Drawing.Point(24, 184);
            this._tableSach.Name = "_tableSach";
            this._tableSach.ReadOnly = true;
            this._tableSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._tableSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._tableSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._tableSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._tableSach.Size = new System.Drawing.Size(639, 208);
            this._tableSach.TabIndex = 10;
            // 
            // _dgw_txtMaSach
            // 
            this._dgw_txtMaSach.HeaderText = "Mã Sách";
            this._dgw_txtMaSach.Name = "_dgw_txtMaSach";
            this._dgw_txtMaSach.ReadOnly = true;
            // 
            // _dgw_txtNgayMuon
            // 
            this._dgw_txtNgayMuon.HeaderText = "Ngày Mượn";
            this._dgw_txtNgayMuon.Name = "_dgw_txtNgayMuon";
            this._dgw_txtNgayMuon.ReadOnly = true;
            // 
            // _dgw_txtSoNgayMuon
            // 
            this._dgw_txtSoNgayMuon.HeaderText = "Số Ngày Mượn";
            this._dgw_txtSoNgayMuon.Name = "_dgw_txtSoNgayMuon";
            this._dgw_txtSoNgayMuon.ReadOnly = true;
            // 
            // _dgw_txtTienPhat
            // 
            this._dgw_txtTienPhat.HeaderText = "Tiền Phạt";
            this._dgw_txtTienPhat.Name = "_dgw_txtTienPhat";
            this._dgw_txtTienPhat.ReadOnly = true;
            // 
            // _btnLapPhieu
            // 
            this._btnLapPhieu.Location = new System.Drawing.Point(16, 436);
            this._btnLapPhieu.Name = "_btnLapPhieu";
            this._btnLapPhieu.Size = new System.Drawing.Size(91, 23);
            this._btnLapPhieu.TabIndex = 4;
            this._btnLapPhieu.Text = "Lập Phiếu Trả";
            this._btnLapPhieu.UseSelectable = true;
            this._btnLapPhieu.Click += new System.EventHandler(this._btnLapPhieu_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(588, 436);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 11;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _btnThemMoi
            // 
            this._btnThemMoi.Location = new System.Drawing.Point(292, 436);
            this._btnThemMoi.Name = "_btnThemMoi";
            this._btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this._btnThemMoi.TabIndex = 15;
            this._btnThemMoi.Text = "Thêm Mới";
            this._btnThemMoi.UseSelectable = true;
            this._btnThemMoi.Click += new System.EventHandler(this._btnThemMoi_Click);
            // 
            // frmDKPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 474);
            this.Controls.Add(this._btnThemMoi);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnLapPhieu);
            this.Controls.Add(this._tableSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._btnThemSach);
            this.Controls.Add(this._tbTienPhat);
            this.Controls.Add(this._dtNgayTra);
            this.Controls.Add(this._tbHoTen);
            this.Controls.Add(this._tbMaSach);
            this.Controls.Add(this._tbTongNo);
            this.Controls.Add(this._tbMaDG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDKPhieuTra";
            this.Resizable = false;
            this.Text = "Phiếu Trả";
            ((System.ComponentModel.ISupportInitialize)(this._tableSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbMaDG;
        private System.Windows.Forms.TextBox _tbHoTen;
        private System.Windows.Forms.DateTimePicker _dtNgayTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbTongNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _tbTienPhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tbMaSach;
        private MetroFramework.Controls.MetroButton _btnThemSach;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroGrid _tableSach;
        private MetroFramework.Controls.MetroButton _btnLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtSoNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTienPhat;
        private MetroFramework.Controls.MetroButton _btnThoat;
        private MetroFramework.Controls.MetroButton _btnThemMoi;
    }
}