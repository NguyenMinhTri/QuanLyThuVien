namespace UI
{
    partial class frmTK_SachTheoTL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTK_SachTheoTL));
            this._dtNgayTK = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this._tableThongKe = new MetroFramework.Controls.MetroGrid();
            this._dgw_txtTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtSoLuotMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtTiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this._tbTong = new System.Windows.Forms.TextBox();
            this._btnTK = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this._tableThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // _dtNgayTK
            // 
            this._dtNgayTK.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtNgayTK.CustomFormat = "MM/ yyyy";
            this._dtNgayTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtNgayTK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtNgayTK.Location = new System.Drawing.Point(250, 63);
            this._dtNgayTK.Name = "_dtNgayTK";
            this._dtNgayTK.ShowUpDown = true;
            this._dtNgayTK.Size = new System.Drawing.Size(122, 31);
            this._dtNgayTK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Thời Gian(Tháng/Năm):";
            // 
            // _tableThongKe
            // 
            this._tableThongKe.AllowUserToAddRows = false;
            this._tableThongKe.AllowUserToDeleteRows = false;
            this._tableThongKe.AllowUserToResizeRows = false;
            this._tableThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._tableThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tableThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tableThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._tableThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._tableThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._tableThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tableThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._dgw_txtTheLoai,
            this._dgw_txtSoLuotMuon,
            this._dgw_txtTiLe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._tableThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            this._tableThongKe.EnableHeadersVisualStyles = false;
            this._tableThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._tableThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._tableThongKe.Location = new System.Drawing.Point(24, 113);
            this._tableThongKe.Name = "_tableThongKe";
            this._tableThongKe.ReadOnly = true;
            this._tableThongKe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._tableThongKe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._tableThongKe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._tableThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._tableThongKe.Size = new System.Drawing.Size(579, 164);
            this._tableThongKe.TabIndex = 2;
            // 
            // _dgw_txtTheLoai
            // 
            this._dgw_txtTheLoai.HeaderText = "Thể Loại";
            this._dgw_txtTheLoai.Name = "_dgw_txtTheLoai";
            this._dgw_txtTheLoai.ReadOnly = true;
            // 
            // _dgw_txtSoLuotMuon
            // 
            this._dgw_txtSoLuotMuon.HeaderText = "Số Lượt Mượn";
            this._dgw_txtSoLuotMuon.Name = "_dgw_txtSoLuotMuon";
            this._dgw_txtSoLuotMuon.ReadOnly = true;
            // 
            // _dgw_txtTiLe
            // 
            this._dgw_txtTiLe.HeaderText = "Tỉ Lệ";
            this._dgw_txtTiLe.Name = "_dgw_txtTiLe";
            this._dgw_txtTiLe.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng Số Lượt Mượn:";
            // 
            // _tbTong
            // 
            this._tbTong.Location = new System.Drawing.Point(134, 296);
            this._tbTong.Name = "_tbTong";
            this._tbTong.ReadOnly = true;
            this._tbTong.Size = new System.Drawing.Size(55, 20);
            this._tbTong.TabIndex = 4;
            // 
            // _btnTK
            // 
            this._btnTK.Location = new System.Drawing.Point(388, 71);
            this._btnTK.Name = "_btnTK";
            this._btnTK.Size = new System.Drawing.Size(96, 23);
            this._btnTK.TabIndex = 5;
            this._btnTK.Text = "Xem Thống Kê";
            this._btnTK.UseSelectable = true;
            this._btnTK.Click += new System.EventHandler(this._btnTK_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(528, 296);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 6;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // frmTK_SachTheoTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 326);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnTK);
            this.Controls.Add(this._tbTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tableThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dtNgayTK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTK_SachTheoTL";
            this.Resizable = false;
            this.Text = "Báo Cáo Thống Kê Tình Hình Mượn Sách Theo Thể Loại";
            ((System.ComponentModel.ISupportInitialize)(this._tableThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker _dtNgayTK;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid _tableThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtSoLuotMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTiLe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbTong;
        private MetroFramework.Controls.MetroButton _btnTK;
        private MetroFramework.Controls.MetroButton _btnThoat;
    }
}