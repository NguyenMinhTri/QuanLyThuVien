namespace UI
{
    partial class frmDKPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDKPhieuThu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._tbMaDG = new System.Windows.Forms.TextBox();
            this._tbTenDG = new System.Windows.Forms.TextBox();
            this._tbTongNo = new System.Windows.Forms.TextBox();
            this._tbTienThu = new System.Windows.Forms.TextBox();
            this._tbTienConLai = new System.Windows.Forms.TextBox();
            this._dtNgayThu = new System.Windows.Forms.DateTimePicker();
            this._btnLapPhieu = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this._btnThemMoi = new MetroFramework.Controls.MetroButton();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Độc Giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Nợ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Tiền Thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Còn Lại:";
            // 
            // _tbMaDG
            // 
            this._tbMaDG.Location = new System.Drawing.Point(106, 62);
            this._tbMaDG.Name = "_tbMaDG";
            this._tbMaDG.Size = new System.Drawing.Size(215, 20);
            this._tbMaDG.TabIndex = 1;
            this._tbMaDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbMaDG_KeyPress);
            this._tbMaDG.Leave += new System.EventHandler(this._tbMaDG_Leave);
            // 
            // _tbTenDG
            // 
            this._tbTenDG.Enabled = false;
            this._tbTenDG.Location = new System.Drawing.Point(106, 103);
            this._tbTenDG.Name = "_tbTenDG";
            this._tbTenDG.ReadOnly = true;
            this._tbTenDG.Size = new System.Drawing.Size(215, 20);
            this._tbTenDG.TabIndex = 10;
            // 
            // _tbTongNo
            // 
            this._tbTongNo.Location = new System.Drawing.Point(106, 183);
            this._tbTongNo.Name = "_tbTongNo";
            this._tbTongNo.ReadOnly = true;
            this._tbTongNo.Size = new System.Drawing.Size(215, 20);
            this._tbTongNo.TabIndex = 10;
            // 
            // _tbTienThu
            // 
            this._tbTienThu.Location = new System.Drawing.Point(106, 223);
            this._tbTienThu.Name = "_tbTienThu";
            this._tbTienThu.Size = new System.Drawing.Size(215, 20);
            this._tbTienThu.TabIndex = 2;
            this._tbTienThu.TextChanged += new System.EventHandler(this._tbTienThu_TextChanged);
            this._tbTienThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbTienThu_KeyPress);
            // 
            // _tbTienConLai
            // 
            this._tbTienConLai.Enabled = false;
            this._tbTienConLai.Location = new System.Drawing.Point(106, 263);
            this._tbTienConLai.Name = "_tbTienConLai";
            this._tbTienConLai.ReadOnly = true;
            this._tbTienConLai.Size = new System.Drawing.Size(215, 20);
            this._tbTienConLai.TabIndex = 1;
            // 
            // _dtNgayThu
            // 
            this._dtNgayThu.Enabled = false;
            this._dtNgayThu.Location = new System.Drawing.Point(106, 142);
            this._dtNgayThu.Name = "_dtNgayThu";
            this._dtNgayThu.Size = new System.Drawing.Size(215, 20);
            this._dtNgayThu.TabIndex = 2;
            // 
            // _btnLapPhieu
            // 
            this._btnLapPhieu.Location = new System.Drawing.Point(26, 318);
            this._btnLapPhieu.Name = "_btnLapPhieu";
            this._btnLapPhieu.Size = new System.Drawing.Size(75, 23);
            this._btnLapPhieu.TabIndex = 3;
            this._btnLapPhieu.Text = "Lập Phiếu";
            this._btnLapPhieu.UseSelectable = true;
            this._btnLapPhieu.Click += new System.EventHandler(this._btnLapPhieu_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(246, 318);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 4;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _btnThemMoi
            // 
            this._btnThemMoi.Location = new System.Drawing.Point(136, 318);
            this._btnThemMoi.Name = "_btnThemMoi";
            this._btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this._btnThemMoi.TabIndex = 14;
            this._btnThemMoi.Text = "Thêm Mới";
            this._btnThemMoi.UseSelectable = true;
            this._btnThemMoi.Click += new System.EventHandler(this._btnThemMoi_Click);
            // 
            // frmDKPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 374);
            this.Controls.Add(this._btnThemMoi);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnLapPhieu);
            this.Controls.Add(this._dtNgayThu);
            this.Controls.Add(this._tbTienConLai);
            this.Controls.Add(this._tbTienThu);
            this.Controls.Add(this._tbTongNo);
            this.Controls.Add(this._tbTenDG);
            this.Controls.Add(this._tbMaDG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDKPhieuThu";
            this.Resizable = false;
            this.Text = "Phiếu Thu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _tbMaDG;
        private System.Windows.Forms.TextBox _tbTenDG;
        private System.Windows.Forms.TextBox _tbTongNo;
        private System.Windows.Forms.TextBox _tbTienThu;
        private System.Windows.Forms.TextBox _tbTienConLai;
        private System.Windows.Forms.DateTimePicker _dtNgayThu;
        private MetroFramework.Controls.MetroButton _btnLapPhieu;
        private MetroFramework.Controls.MetroButton _btnThoat;
        private MetroFramework.Controls.MetroButton _btnThemMoi;
    }
}