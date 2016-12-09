namespace UI
{
    partial class frmDKTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDKTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbTK = new System.Windows.Forms.TextBox();
            this._tbMK = new System.Windows.Forms.TextBox();
            this._tbNhapLai = new System.Windows.Forms.TextBox();
            this._rbDG = new MetroFramework.Controls.MetroRadioButton();
            this._rbTT = new MetroFramework.Controls.MetroRadioButton();
            this._btnDK = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Lại Mật Khẩu:";
            // 
            // _tbTK
            // 
            this._tbTK.AcceptsReturn = true;
            this._tbTK.Location = new System.Drawing.Point(170, 71);
            this._tbTK.Name = "_tbTK";
            this._tbTK.Size = new System.Drawing.Size(237, 20);
            this._tbTK.TabIndex = 1;
            // 
            // _tbMK
            // 
            this._tbMK.Location = new System.Drawing.Point(170, 112);
            this._tbMK.Name = "_tbMK";
            this._tbMK.Size = new System.Drawing.Size(237, 20);
            this._tbMK.TabIndex = 2;
            this._tbMK.UseSystemPasswordChar = true;
            // 
            // _tbNhapLai
            // 
            this._tbNhapLai.Location = new System.Drawing.Point(170, 152);
            this._tbNhapLai.Name = "_tbNhapLai";
            this._tbNhapLai.Size = new System.Drawing.Size(237, 20);
            this._tbNhapLai.TabIndex = 3;
            this._tbNhapLai.UseSystemPasswordChar = true;
            // 
            // _rbDG
            // 
            this._rbDG.AutoSize = true;
            this._rbDG.Checked = true;
            this._rbDG.Location = new System.Drawing.Point(170, 194);
            this._rbDG.Name = "_rbDG";
            this._rbDG.Size = new System.Drawing.Size(64, 15);
            this._rbDG.TabIndex = 4;
            this._rbDG.TabStop = true;
            this._rbDG.Text = "Độc Giả";
            this._rbDG.UseSelectable = true;
            // 
            // _rbTT
            // 
            this._rbTT.AutoSize = true;
            this._rbTT.Location = new System.Drawing.Point(240, 194);
            this._rbTT.Name = "_rbTT";
            this._rbTT.Size = new System.Drawing.Size(68, 15);
            this._rbTT.TabIndex = 6;
            this._rbTT.Text = "Thủ Thư";
            this._rbTT.UseSelectable = true;
            // 
            // _btnDK
            // 
            this._btnDK.Location = new System.Drawing.Point(55, 215);
            this._btnDK.Name = "_btnDK";
            this._btnDK.Size = new System.Drawing.Size(75, 23);
            this._btnDK.TabIndex = 7;
            this._btnDK.Text = "Đăng Ký";
            this._btnDK.UseSelectable = true;
            this._btnDK.Click += new System.EventHandler(this._btnDK_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(332, 215);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 8;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // frmDKTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnDK);
            this.Controls.Add(this._rbTT);
            this.Controls.Add(this._rbDG);
            this.Controls.Add(this._tbNhapLai);
            this.Controls.Add(this._tbMK);
            this.Controls.Add(this._tbTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDKTaiKhoan";
            this.Resizable = false;
            this.Text = "Tạo Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbTK;
        private System.Windows.Forms.TextBox _tbMK;
        private System.Windows.Forms.TextBox _tbNhapLai;
        private MetroFramework.Controls.MetroRadioButton _rbDG;
        private MetroFramework.Controls.MetroRadioButton _rbTT;
        private MetroFramework.Controls.MetroButton _btnDK;
        private MetroFramework.Controls.MetroButton _btnThoat;
    }
}