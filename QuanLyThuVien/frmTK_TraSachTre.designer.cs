namespace UI
{
    partial class frmTK_TraSachTre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTK_TraSachTre));
            this.label1 = new System.Windows.Forms.Label();
            this._dtNgayTK = new System.Windows.Forms.DateTimePicker();
            this._btnThongKe = new MetroFramework.Controls.MetroButton();
            this._tableThongKe = new MetroFramework.Controls.MetroGrid();
            this._dgw_txtTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dgw_txtSoNgayTraTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this._tableThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Thời Gian:";
            // 
            // _dtNgayTK
            // 
            this._dtNgayTK.Location = new System.Drawing.Point(196, 73);
            this._dtNgayTK.Name = "_dtNgayTK";
            this._dtNgayTK.Size = new System.Drawing.Size(198, 20);
            this._dtNgayTK.TabIndex = 1;
            // 
            // _btnThongKe
            // 
            this._btnThongKe.Location = new System.Drawing.Point(426, 73);
            this._btnThongKe.Name = "_btnThongKe";
            this._btnThongKe.Size = new System.Drawing.Size(89, 23);
            this._btnThongKe.TabIndex = 2;
            this._btnThongKe.Text = "Xem Thống Kê";
            this._btnThongKe.UseSelectable = true;
            this._btnThongKe.Click += new System.EventHandler(this._btnThongKe_Click);
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
            this._dgw_txtTenSach,
            this._dgw_txtNgayMuon,
            this._dgw_txtSoNgayTraTre});
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
            this._tableThongKe.Location = new System.Drawing.Point(24, 118);
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
            this._tableThongKe.Size = new System.Drawing.Size(542, 211);
            this._tableThongKe.TabIndex = 3;
            // 
            // _dgw_txtTenSach
            // 
            this._dgw_txtTenSach.HeaderText = "Tên Sách";
            this._dgw_txtTenSach.Name = "_dgw_txtTenSach";
            this._dgw_txtTenSach.ReadOnly = true;
            // 
            // _dgw_txtNgayMuon
            // 
            this._dgw_txtNgayMuon.HeaderText = "Ngày Mượn";
            this._dgw_txtNgayMuon.Name = "_dgw_txtNgayMuon";
            this._dgw_txtNgayMuon.ReadOnly = true;
            // 
            // _dgw_txtSoNgayTraTre
            // 
            this._dgw_txtSoNgayTraTre.HeaderText = "Số Ngày Trả Trể";
            this._dgw_txtSoNgayTraTre.Name = "_dgw_txtSoNgayTraTre";
            this._dgw_txtSoNgayTraTre.ReadOnly = true;
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(491, 335);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 4;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // frmTK_TraSachTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 366);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._tableThongKe);
            this.Controls.Add(this._btnThongKe);
            this.Controls.Add(this._dtNgayTK);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTK_TraSachTre";
            this.Resizable = false;
            this.Text = "Báo Cáo Thống Kê Sách Trả Trể";
            ((System.ComponentModel.ISupportInitialize)(this._tableThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker _dtNgayTK;
        private MetroFramework.Controls.MetroButton _btnThongKe;
        private MetroFramework.Controls.MetroGrid _tableThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtNgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dgw_txtSoNgayTraTre;
        private MetroFramework.Controls.MetroButton _btnThoat;
    }
}