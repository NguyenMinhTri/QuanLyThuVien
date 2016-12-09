namespace UI
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this._tbMKMoi = new System.Windows.Forms.TextBox();
            this._tbMKCu = new System.Windows.Forms.TextBox();
            this._tbTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._btnDoiMK = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // _tbMKMoi
            // 
            this._tbMKMoi.Location = new System.Drawing.Point(168, 148);
            this._tbMKMoi.Name = "_tbMKMoi";
            this._tbMKMoi.Size = new System.Drawing.Size(237, 20);
            this._tbMKMoi.TabIndex = 2;
            this._tbMKMoi.UseSystemPasswordChar = true;
            // 
            // _tbMKCu
            // 
            this._tbMKCu.Location = new System.Drawing.Point(168, 108);
            this._tbMKCu.Name = "_tbMKCu";
            this._tbMKCu.Size = new System.Drawing.Size(237, 20);
            this._tbMKCu.TabIndex = 1;
            this._tbMKCu.UseSystemPasswordChar = true;
            // 
            // _tbTK
            // 
            this._tbTK.AcceptsReturn = true;
            this._tbTK.Location = new System.Drawing.Point(168, 67);
            this._tbTK.Name = "_tbTK";
            this._tbTK.ReadOnly = true;
            this._tbTK.Size = new System.Drawing.Size(237, 20);
            this._tbTK.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu Cũ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Tài Khoản:";
            // 
            // _btnDoiMK
            // 
            this._btnDoiMK.Location = new System.Drawing.Point(53, 190);
            this._btnDoiMK.Name = "_btnDoiMK";
            this._btnDoiMK.Size = new System.Drawing.Size(75, 23);
            this._btnDoiMK.TabIndex = 3;
            this._btnDoiMK.Text = "Thay Đổi";
            this._btnDoiMK.UseSelectable = true;
            this._btnDoiMK.Click += new System.EventHandler(this._btnDoiMK_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(330, 190);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 3;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 236);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnDoiMK);
            this.Controls.Add(this._tbMKMoi);
            this.Controls.Add(this._tbMKCu);
            this.Controls.Add(this._tbTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.Resizable = false;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbMKMoi;
        private System.Windows.Forms.TextBox _tbMKCu;
        private System.Windows.Forms.TextBox _tbTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton _btnDoiMK;
        private MetroFramework.Controls.MetroButton _btnThoat;
    }
}