namespace UI
{
    partial class frmDKTacGia
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDKTacGia));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._tbTenTG = new MetroFramework.Controls.MetroTextBox();
            this._btnAdd = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this._btnThemMoi = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên Tác Giả :";
            // 
            // _tbTenTG
            // 
            // 
            // 
            // 
            this._tbTenTG.CustomButton.Image = null;
            this._tbTenTG.CustomButton.Location = new System.Drawing.Point(221, 1);
            this._tbTenTG.CustomButton.Name = "";
            this._tbTenTG.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._tbTenTG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._tbTenTG.CustomButton.TabIndex = 1;
            this._tbTenTG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._tbTenTG.CustomButton.UseSelectable = true;
            this._tbTenTG.CustomButton.Visible = false;
            this._tbTenTG.Lines = new string[0];
            this._tbTenTG.Location = new System.Drawing.Point(144, 56);
            this._tbTenTG.MaxLength = 32767;
            this._tbTenTG.Name = "_tbTenTG";
            this._tbTenTG.PasswordChar = '\0';
            this._tbTenTG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._tbTenTG.SelectedText = "";
            this._tbTenTG.SelectionLength = 0;
            this._tbTenTG.SelectionStart = 0;
            this._tbTenTG.Size = new System.Drawing.Size(243, 23);
            this._tbTenTG.TabIndex = 2;
            this._tbTenTG.UseSelectable = true;
            this._tbTenTG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._tbTenTG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._tbTenTG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbTenTG_KeyPress);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(33, 104);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 3;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.UseSelectable = true;
            this._btnAdd.Visible = false;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(312, 104);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 3;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _btnThemMoi
            // 
            this._btnThemMoi.Location = new System.Drawing.Point(173, 104);
            this._btnThemMoi.Name = "_btnThemMoi";
            this._btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this._btnThemMoi.TabIndex = 15;
            this._btnThemMoi.Text = "Thêm Mới";
            this._btnThemMoi.UseSelectable = true;
            this._btnThemMoi.Click += new System.EventHandler(this._btnThemMoi_Click);
            // 
            // frmDKTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 150);
            this.Controls.Add(this._btnThemMoi);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._tbTenTG);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDKTacGia";
            this.Resizable = false;
            this.Text = "Tác Giả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox _tbTenTG;
        private MetroFramework.Controls.MetroButton _btnAdd;
        private MetroFramework.Controls.MetroButton _btnThoat;
        private MetroFramework.Controls.MetroButton _btnThemMoi;
    }
}