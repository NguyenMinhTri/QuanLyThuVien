namespace UI
{
    partial class frmDauSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDauSach));
            this._btnAdd = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this._tbTenDauSach = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this._cbbTheLoai = new System.Windows.Forms.ComboBox();
            this._cbbTacGia2 = new System.Windows.Forms.ComboBox();
            this._cbbTacGia1 = new System.Windows.Forms.ComboBox();
            this._btnThemMoi = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(44, 232);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 4;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.UseSelectable = true;
            this._btnAdd.Visible = false;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(285, 232);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 4;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _tbTenDauSach
            // 
            this._tbTenDauSach.Location = new System.Drawing.Point(148, 64);
            this._tbTenDauSach.Name = "_tbTenDauSach";
            this._tbTenDauSach.Size = new System.Drawing.Size(212, 20);
            this._tbTenDauSach.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Tên Đầu Sách: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(41, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "Thể Loại:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(41, 151);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Tác Giả 1:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(41, 191);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "Tác Giả 2:";
            // 
            // _cbbTheLoai
            // 
            this._cbbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbbTheLoai.FormattingEnabled = true;
            this._cbbTheLoai.Location = new System.Drawing.Point(148, 102);
            this._cbbTheLoai.Name = "_cbbTheLoai";
            this._cbbTheLoai.Size = new System.Drawing.Size(212, 21);
            this._cbbTheLoai.TabIndex = 12;
            // 
            // _cbbTacGia2
            // 
            this._cbbTacGia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbbTacGia2.FormattingEnabled = true;
            this._cbbTacGia2.Location = new System.Drawing.Point(148, 183);
            this._cbbTacGia2.Name = "_cbbTacGia2";
            this._cbbTacGia2.Size = new System.Drawing.Size(212, 21);
            this._cbbTacGia2.TabIndex = 13;
            // 
            // _cbbTacGia1
            // 
            this._cbbTacGia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbbTacGia1.FormattingEnabled = true;
            this._cbbTacGia1.Location = new System.Drawing.Point(148, 143);
            this._cbbTacGia1.Name = "_cbbTacGia1";
            this._cbbTacGia1.Size = new System.Drawing.Size(212, 21);
            this._cbbTacGia1.TabIndex = 14;
            this._cbbTacGia1.SelectedIndexChanged += new System.EventHandler(this._cbbTacGia1_SelectedIndexChanged);
            // 
            // _btnThemMoi
            // 
            this._btnThemMoi.Location = new System.Drawing.Point(163, 232);
            this._btnThemMoi.Name = "_btnThemMoi";
            this._btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this._btnThemMoi.TabIndex = 15;
            this._btnThemMoi.Text = "Thêm Mới";
            this._btnThemMoi.UseSelectable = true;
            this._btnThemMoi.Click += new System.EventHandler(this._btnThemMoi_Click);
            // 
            // frmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 276);
            this.Controls.Add(this._btnThemMoi);
            this.Controls.Add(this._tbTenDauSach);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this._cbbTheLoai);
            this.Controls.Add(this._cbbTacGia2);
            this.Controls.Add(this._cbbTacGia1);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDauSach";
            this.Resizable = false;
            this.Text = "Đầu Sách";
            this.Load += new System.EventHandler(this.frmDauSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton _btnAdd;
        private MetroFramework.Controls.MetroButton _btnThoat;
        private System.Windows.Forms.TextBox _tbTenDauSach;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox _cbbTheLoai;
        private System.Windows.Forms.ComboBox _cbbTacGia2;
        private System.Windows.Forms.ComboBox _cbbTacGia1;
        private MetroFramework.Controls.MetroButton _btnThemMoi;
    }
}