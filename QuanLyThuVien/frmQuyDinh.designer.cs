namespace UI
{
    partial class frmQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyDinh));
            this._tileTKSachTre = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this._tbTuoiToiThieu = new System.Windows.Forms.TextBox();
            this._tbTuoiToiDa = new System.Windows.Forms.TextBox();
            this._tbThoiHan = new System.Windows.Forms.TextBox();
            this._tbSSTD = new System.Windows.Forms.TextBox();
            this._tbSNTD = new System.Windows.Forms.TextBox();
            this._tbThoiHanXB = new System.Windows.Forms.TextBox();
            this._tbTienPhat = new System.Windows.Forms.TextBox();
            this._btnThayDoi = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this._btnThemQuyDinh = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // _tileTKSachTre
            // 
            this._tileTKSachTre.Image = ((System.Drawing.Image)(resources.GetObject("_tileTKSachTre.Image")));
            this._tileTKSachTre.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this._tileTKSachTre.Name = "_tileTKSachTre";
            this._tileTKSachTre.SymbolColor = System.Drawing.Color.Empty;
            this._tileTKSachTre.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this._tileTKSachTre.TileSize = new System.Drawing.Size(200, 80);
            // 
            // 
            // 
            this._tileTKSachTre.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._tileTKSachTre.TitleText = "Thống Kê Sách Trả Trể";
            this._tileTKSachTre.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(47, 311);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(104, 13);
            this.label56.TabIndex = 9;
            this.label56.Text = "Tiền Phạt Mỗi Ngày:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(47, 271);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(135, 13);
            this.label57.TabIndex = 10;
            this.label57.Text = "Thời Hạn Xuất Bản (Năm) :";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(47, 231);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(116, 13);
            this.label58.TabIndex = 11;
            this.label58.Text = "Số Ngày Mượn Tối Đa:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(47, 191);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(116, 13);
            this.label59.TabIndex = 12;
            this.label59.Text = "Số Sách Mượn Tối Đa:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(47, 151);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(76, 13);
            this.label60.TabIndex = 13;
            this.label60.Text = "Thời Hạn Thẻ:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(47, 71);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(79, 13);
            this.label62.TabIndex = 14;
            this.label62.Text = "Tuổi Tối Thiểu:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(47, 111);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(66, 13);
            this.label61.TabIndex = 15;
            this.label61.Text = "Tuổi Tối Đa:";
            // 
            // _tbTuoiToiThieu
            // 
            this._tbTuoiToiThieu.Location = new System.Drawing.Point(178, 64);
            this._tbTuoiToiThieu.Name = "_tbTuoiToiThieu";
            this._tbTuoiToiThieu.Size = new System.Drawing.Size(206, 20);
            this._tbTuoiToiThieu.TabIndex = 1;
            this._tbTuoiToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbTuoiToiThieu_KeyPress);
            // 
            // _tbTuoiToiDa
            // 
            this._tbTuoiToiDa.Location = new System.Drawing.Point(178, 104);
            this._tbTuoiToiDa.Name = "_tbTuoiToiDa";
            this._tbTuoiToiDa.Size = new System.Drawing.Size(206, 20);
            this._tbTuoiToiDa.TabIndex = 2;
            this._tbTuoiToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbTuoiToiDa_KeyPress);
            // 
            // _tbThoiHan
            // 
            this._tbThoiHan.Location = new System.Drawing.Point(178, 144);
            this._tbThoiHan.Name = "_tbThoiHan";
            this._tbThoiHan.Size = new System.Drawing.Size(206, 20);
            this._tbThoiHan.TabIndex = 3;
            this._tbThoiHan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbThoiHan_KeyPress);
            // 
            // _tbSSTD
            // 
            this._tbSSTD.Location = new System.Drawing.Point(178, 184);
            this._tbSSTD.Name = "_tbSSTD";
            this._tbSSTD.Size = new System.Drawing.Size(206, 20);
            this._tbSSTD.TabIndex = 4;
            this._tbSSTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbSSTD_KeyPress);
            // 
            // _tbSNTD
            // 
            this._tbSNTD.Location = new System.Drawing.Point(178, 224);
            this._tbSNTD.Name = "_tbSNTD";
            this._tbSNTD.Size = new System.Drawing.Size(206, 20);
            this._tbSNTD.TabIndex = 5;
            this._tbSNTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbSNTD_KeyPress);
            // 
            // _tbThoiHanXB
            // 
            this._tbThoiHanXB.Location = new System.Drawing.Point(178, 264);
            this._tbThoiHanXB.Name = "_tbThoiHanXB";
            this._tbThoiHanXB.Size = new System.Drawing.Size(206, 20);
            this._tbThoiHanXB.TabIndex = 7;
            this._tbThoiHanXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbThoiHanXB_KeyPress);
            // 
            // _tbTienPhat
            // 
            this._tbTienPhat.Location = new System.Drawing.Point(178, 304);
            this._tbTienPhat.Name = "_tbTienPhat";
            this._tbTienPhat.Size = new System.Drawing.Size(206, 20);
            this._tbTienPhat.TabIndex = 8;
            this._tbTienPhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbTienPhat_KeyPress);
            // 
            // _btnThayDoi
            // 
            this._btnThayDoi.Location = new System.Drawing.Point(51, 351);
            this._btnThayDoi.Name = "_btnThayDoi";
            this._btnThayDoi.Size = new System.Drawing.Size(75, 23);
            this._btnThayDoi.TabIndex = 9;
            this._btnThayDoi.Text = "Thay Đổi";
            this._btnThayDoi.UseSelectable = true;
            this._btnThayDoi.Click += new System.EventHandler(this._btnThayDoi_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(309, 354);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 10;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _btnThemQuyDinh
            // 
            this._btnThemQuyDinh.Location = new System.Drawing.Point(51, 351);
            this._btnThemQuyDinh.Name = "_btnThemQuyDinh";
            this._btnThemQuyDinh.Size = new System.Drawing.Size(75, 23);
            this._btnThemQuyDinh.TabIndex = 9;
            this._btnThemQuyDinh.Text = "Thêm";
            this._btnThemQuyDinh.UseSelectable = true;
            this._btnThemQuyDinh.Visible = false;
            this._btnThemQuyDinh.Click += new System.EventHandler(this._btnThemQuyDinh_Click);
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 400);
            this.Controls.Add(this._btnThemQuyDinh);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnThayDoi);
            this.Controls.Add(this._tbTienPhat);
            this.Controls.Add(this._tbThoiHanXB);
            this.Controls.Add(this._tbSNTD);
            this.Controls.Add(this._tbSSTD);
            this.Controls.Add(this._tbThoiHan);
            this.Controls.Add(this._tbTuoiToiDa);
            this.Controls.Add(this._tbTuoiToiThieu);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label61);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuyDinh";
            this.Resizable = false;
            this.Text = "Quy Định";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTileItem _tileTKSachTre;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox _tbTuoiToiThieu;
        private System.Windows.Forms.TextBox _tbTuoiToiDa;
        private System.Windows.Forms.TextBox _tbThoiHan;
        private System.Windows.Forms.TextBox _tbSSTD;
        private System.Windows.Forms.TextBox _tbSNTD;
        private System.Windows.Forms.TextBox _tbThoiHanXB;
        private System.Windows.Forms.TextBox _tbTienPhat;
        private MetroFramework.Controls.MetroButton _btnThayDoi;
        private MetroFramework.Controls.MetroButton _btnThoat;
        private MetroFramework.Controls.MetroButton _btnThemQuyDinh;
    }
}