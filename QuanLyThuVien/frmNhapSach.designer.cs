namespace UI
{
    partial class frmNhapSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapSach));
            this._tableDSTam = new MetroFramework.Controls.MetroGrid();
            this._dgw_txtTenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtNhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._btnAddDS = new MetroFramework.Controls.MetroButton();
            this._btnLapPhieu = new MetroFramework.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cbbTenDauSach = new System.Windows.Forms.ComboBox();
            this._tbTheLoai = new System.Windows.Forms.TextBox();
            this._tbTacGia = new System.Windows.Forms.TextBox();
            this._tbTriGia = new System.Windows.Forms.TextBox();
            this._tbNamXB = new System.Windows.Forms.TextBox();
            this._tbNhaXB = new System.Windows.Forms.TextBox();
            this._tbSoLuong = new System.Windows.Forms.TextBox();
            this._dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this._tbThanhTien = new System.Windows.Forms.TextBox();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this._tableDSTam)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableDSTam
            // 
            this._tableDSTam.AllowUserToAddRows = false;
            this._tableDSTam.AllowUserToDeleteRows = false;
            this._tableDSTam.AllowUserToResizeRows = false;
            this._tableDSTam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._tableDSTam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tableDSTam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tableDSTam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._tableDSTam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._tableDSTam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._tableDSTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tableDSTam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._dgw_txtTenDauSach,
            this._dgw_txtNamXB,
            this._dgw_txtNhaXB,
            this._dgw_txtTriGia,
            this._dgw_txtSoLuong,
            this._dgw_txtThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._tableDSTam.DefaultCellStyle = dataGridViewCellStyle2;
            this._tableDSTam.EnableHeadersVisualStyles = false;
            this._tableDSTam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._tableDSTam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tableDSTam.Location = new System.Drawing.Point(357, 65);
            this._tableDSTam.Name = "_tableDSTam";
            this._tableDSTam.ReadOnly = true;
            this._tableDSTam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._tableDSTam.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._tableDSTam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._tableDSTam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._tableDSTam.Size = new System.Drawing.Size(533, 349);
            this._tableDSTam.TabIndex = 10;
            this._tableDSTam.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._tableDSTam_RowsAdded);
            // 
            // _dgw_txtTenDauSach
            // 
            this._dgw_txtTenDauSach.HeaderText = "Tên Đầu Sách";
            this._dgw_txtTenDauSach.Name = "_dgw_txtTenDauSach";
            this._dgw_txtTenDauSach.ReadOnly = true;
            // 
            // _dgw_txtNamXB
            // 
            this._dgw_txtNamXB.HeaderText = "Năm Xuất Bản";
            this._dgw_txtNamXB.Name = "_dgw_txtNamXB";
            this._dgw_txtNamXB.ReadOnly = true;
            // 
            // _dgw_txtNhaXB
            // 
            this._dgw_txtNhaXB.HeaderText = "Nhà XB";
            this._dgw_txtNhaXB.Name = "_dgw_txtNhaXB";
            this._dgw_txtNhaXB.ReadOnly = true;
            // 
            // _dgw_txtTriGia
            // 
            this._dgw_txtTriGia.HeaderText = "Trị Giá";
            this._dgw_txtTriGia.Name = "_dgw_txtTriGia";
            this._dgw_txtTriGia.ReadOnly = true;
            // 
            // _dgw_txtSoLuong
            // 
            this._dgw_txtSoLuong.HeaderText = "Số Lượng";
            this._dgw_txtSoLuong.Name = "_dgw_txtSoLuong";
            this._dgw_txtSoLuong.ReadOnly = true;
            // 
            // _dgw_txtThanhTien
            // 
            this._dgw_txtThanhTien.HeaderText = "Thành Tiền";
            this._dgw_txtThanhTien.Name = "_dgw_txtThanhTien";
            this._dgw_txtThanhTien.ReadOnly = true;
            // 
            // _btnAddDS
            // 
            this._btnAddDS.Location = new System.Drawing.Point(33, 435);
            this._btnAddDS.Name = "_btnAddDS";
            this._btnAddDS.Size = new System.Drawing.Size(122, 23);
            this._btnAddDS.TabIndex = 6;
            this._btnAddDS.Text = "Thêm Vào Danh Sách";
            this._btnAddDS.UseSelectable = true;
            this._btnAddDS.Click += new System.EventHandler(this._btnAddDS_Click);
            // 
            // _btnLapPhieu
            // 
            this._btnLapPhieu.Location = new System.Drawing.Point(357, 435);
            this._btnLapPhieu.Name = "_btnLapPhieu";
            this._btnLapPhieu.Size = new System.Drawing.Size(75, 23);
            this._btnLapPhieu.TabIndex = 7;
            this._btnLapPhieu.Text = "Lập Phiếu";
            this._btnLapPhieu.UseSelectable = true;
            this._btnLapPhieu.Click += new System.EventHandler(this._btnLapPhieu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ngày Nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Số Lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nhà XB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Năm XB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Trị Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tác Giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Đầu Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thể Loại :";
            // 
            // _cbbTenDauSach
            // 
            this._cbbTenDauSach.BackColor = System.Drawing.SystemColors.Window;
            this._cbbTenDauSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbbTenDauSach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cbbTenDauSach.FormattingEnabled = true;
            this._cbbTenDauSach.Location = new System.Drawing.Point(145, 65);
            this._cbbTenDauSach.Name = "_cbbTenDauSach";
            this._cbbTenDauSach.Size = new System.Drawing.Size(183, 21);
            this._cbbTenDauSach.TabIndex = 1;
            this._cbbTenDauSach.SelectedIndexChanged += new System.EventHandler(this._cbbTenDauSach_SelectedIndexChanged);
            // 
            // _tbTheLoai
            // 
            this._tbTheLoai.Location = new System.Drawing.Point(145, 106);
            this._tbTheLoai.Name = "_tbTheLoai";
            this._tbTheLoai.ReadOnly = true;
            this._tbTheLoai.Size = new System.Drawing.Size(183, 20);
            this._tbTheLoai.TabIndex = 23;
            // 
            // _tbTacGia
            // 
            this._tbTacGia.Location = new System.Drawing.Point(145, 147);
            this._tbTacGia.Name = "_tbTacGia";
            this._tbTacGia.ReadOnly = true;
            this._tbTacGia.Size = new System.Drawing.Size(183, 20);
            this._tbTacGia.TabIndex = 23;
            // 
            // _tbTriGia
            // 
            this._tbTriGia.Location = new System.Drawing.Point(145, 187);
            this._tbTriGia.Name = "_tbTriGia";
            this._tbTriGia.Size = new System.Drawing.Size(183, 20);
            this._tbTriGia.TabIndex = 2;
            this._tbTriGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbTriGia_KeyPress);
            this._tbTriGia.Leave += new System.EventHandler(this._tbTriGia_Leave);
            // 
            // _tbNamXB
            // 
            this._tbNamXB.Location = new System.Drawing.Point(145, 227);
            this._tbNamXB.Name = "_tbNamXB";
            this._tbNamXB.Size = new System.Drawing.Size(183, 20);
            this._tbNamXB.TabIndex = 3;
            this._tbNamXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbNamXB_KeyPress);
            this._tbNamXB.Leave += new System.EventHandler(this._tbNamXB_Leave);
            // 
            // _tbNhaXB
            // 
            this._tbNhaXB.Location = new System.Drawing.Point(145, 267);
            this._tbNhaXB.Name = "_tbNhaXB";
            this._tbNhaXB.Size = new System.Drawing.Size(183, 20);
            this._tbNhaXB.TabIndex = 4;
            // 
            // _tbSoLuong
            // 
            this._tbSoLuong.Location = new System.Drawing.Point(145, 346);
            this._tbSoLuong.Name = "_tbSoLuong";
            this._tbSoLuong.Size = new System.Drawing.Size(183, 20);
            this._tbSoLuong.TabIndex = 5;
            this._tbSoLuong.TextChanged += new System.EventHandler(this._tbSoLuong_TextChanged);
            this._tbSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbSoLuong_KeyPress);
            this._tbSoLuong.Leave += new System.EventHandler(this._tbSoLuong_Leave);
            // 
            // _dtNgayNhap
            // 
            this._dtNgayNhap.Enabled = false;
            this._dtNgayNhap.Location = new System.Drawing.Point(145, 306);
            this._dtNgayNhap.Name = "_dtNgayNhap";
            this._dtNgayNhap.Size = new System.Drawing.Size(183, 20);
            this._dtNgayNhap.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thành Tiền";
            // 
            // _tbThanhTien
            // 
            this._tbThanhTien.Location = new System.Drawing.Point(145, 387);
            this._tbThanhTien.Name = "_tbThanhTien";
            this._tbThanhTien.ReadOnly = true;
            this._tbThanhTien.Size = new System.Drawing.Size(183, 20);
            this._tbThanhTien.TabIndex = 23;
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(806, 435);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 8;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // frmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 464);
            this.Controls.Add(this._dtNgayNhap);
            this.Controls.Add(this._tbThanhTien);
            this.Controls.Add(this._tbSoLuong);
            this.Controls.Add(this._tbNhaXB);
            this.Controls.Add(this._tbNamXB);
            this.Controls.Add(this._tbTriGia);
            this.Controls.Add(this._tbTacGia);
            this.Controls.Add(this._tbTheLoai);
            this.Controls.Add(this._cbbTenDauSach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnLapPhieu);
            this.Controls.Add(this._btnAddDS);
            this.Controls.Add(this._tableDSTam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhapSach";
            this.Resizable = false;
            this.Text = "Nhập Sách Mới";
            ((System.ComponentModel.ISupportInitialize)(this._tableDSTam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid _tableDSTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtNhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtThanhTien;
        private MetroFramework.Controls.MetroButton _btnAddDS;
        private MetroFramework.Controls.MetroButton _btnLapPhieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbbTenDauSach;
        private System.Windows.Forms.TextBox _tbTheLoai;
        private System.Windows.Forms.TextBox _tbTacGia;
        private System.Windows.Forms.TextBox _tbTriGia;
        private System.Windows.Forms.TextBox _tbNamXB;
        private System.Windows.Forms.TextBox _tbNhaXB;
        private System.Windows.Forms.TextBox _tbSoLuong;
        private System.Windows.Forms.DateTimePicker _dtNgayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbThanhTien;
        private MetroFramework.Controls.MetroButton _btnThoat;
    }
}