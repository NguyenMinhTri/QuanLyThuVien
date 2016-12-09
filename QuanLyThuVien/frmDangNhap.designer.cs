namespace UI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._tbTK = new System.Windows.Forms.TextBox();
            this._tbMK = new System.Windows.Forms.TextBox();
            this._btnDangNhap = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // _tbTK
            // 
            this._tbTK.Location = new System.Drawing.Point(161, 69);
            this._tbTK.Name = "_tbTK";
            this._tbTK.Size = new System.Drawing.Size(198, 20);
            this._tbTK.TabIndex = 1;
            // 
            // _tbMK
            // 
            this._tbMK.Location = new System.Drawing.Point(161, 116);
            this._tbMK.Name = "_tbMK";
            this._tbMK.Size = new System.Drawing.Size(198, 20);
            this._tbMK.TabIndex = 2;
            this._tbMK.UseSystemPasswordChar = true;
            this._tbMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbMK_KeyPress);
            // 
            // _btnDangNhap
            // 
            this._btnDangNhap.Location = new System.Drawing.Point(66, 158);
            this._btnDangNhap.Name = "_btnDangNhap";
            this._btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this._btnDangNhap.TabIndex = 3;
            this._btnDangNhap.Text = "Đăng Nhập";
            this._btnDangNhap.UseSelectable = true;
            this._btnDangNhap.Click += new System.EventHandler(this._btnDangNhap_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(284, 158);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 4;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 216);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnDangNhap);
            this.Controls.Add(this._tbMK);
            this.Controls.Add(this._tbTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.Resizable = false;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbTK;
        private System.Windows.Forms.TextBox _tbMK;
        private MetroFramework.Controls.MetroButton _btnDangNhap;
        private MetroFramework.Controls.MetroButton _btnThoat;
    }
}