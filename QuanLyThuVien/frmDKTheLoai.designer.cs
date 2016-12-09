namespace UI
{
    partial class frmDKTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDKTheLoai));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._tbTenTL = new MetroFramework.Controls.MetroTextBox();
            this._btnAdd = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this._btnThemMoi = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên Thể Loại :";
            // 
            // _tbTenTL
            // 
            // 
            // 
            // 
            this._tbTenTL.CustomButton.Image = null;
            this._tbTenTL.CustomButton.Location = new System.Drawing.Point(240, 1);
            this._tbTenTL.CustomButton.Name = "";
            this._tbTenTL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._tbTenTL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._tbTenTL.CustomButton.TabIndex = 1;
            this._tbTenTL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._tbTenTL.CustomButton.UseSelectable = true;
            this._tbTenTL.CustomButton.Visible = false;
            this._tbTenTL.Lines = new string[0];
            this._tbTenTL.Location = new System.Drawing.Point(125, 63);
            this._tbTenTL.MaxLength = 32767;
            this._tbTenTL.Name = "_tbTenTL";
            this._tbTenTL.PasswordChar = '\0';
            this._tbTenTL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._tbTenTL.SelectedText = "";
            this._tbTenTL.SelectionLength = 0;
            this._tbTenTL.SelectionStart = 0;
            this._tbTenTL.Size = new System.Drawing.Size(262, 23);
            this._tbTenTL.TabIndex = 2;
            this._tbTenTL.UseSelectable = true;
            this._tbTenTL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._tbTenTL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._tbTenTL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tbTenTL_KeyPress);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(23, 105);
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
            this._btnThoat.Location = new System.Drawing.Point(312, 105);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 4;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _btnThemMoi
            // 
            this._btnThemMoi.Location = new System.Drawing.Point(169, 105);
            this._btnThemMoi.Name = "_btnThemMoi";
            this._btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this._btnThemMoi.TabIndex = 16;
            this._btnThemMoi.Text = "Thêm Mới";
            this._btnThemMoi.UseSelectable = true;
            this._btnThemMoi.Click += new System.EventHandler(this._btnThemMoi_Click);
            // 
            // frmDKTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 151);
            this.Controls.Add(this._btnThemMoi);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._tbTenTL);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDKTheLoai";
            this.Resizable = false;
            this.Text = "Thể Loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox _tbTenTL;
        private MetroFramework.Controls.MetroButton _btnAdd;
        private MetroFramework.Controls.MetroButton _btnThoat;
        private MetroFramework.Controls.MetroButton _btnThemMoi;
    }
}