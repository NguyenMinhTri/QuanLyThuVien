namespace UI
{
    partial class frmDKLoaiDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDKLoaiDG));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._tbTenDG = new MetroFramework.Controls.MetroTextBox();
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
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tên Loại Độc Giả :";
            // 
            // _tbTenDG
            // 
            // 
            // 
            // 
            this._tbTenDG.CustomButton.Image = null;
            this._tbTenDG.CustomButton.Location = new System.Drawing.Point(210, 1);
            this._tbTenDG.CustomButton.Name = "";
            this._tbTenDG.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._tbTenDG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._tbTenDG.CustomButton.TabIndex = 1;
            this._tbTenDG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._tbTenDG.CustomButton.UseSelectable = true;
            this._tbTenDG.CustomButton.Visible = false;
            this._tbTenDG.Lines = new string[0];
            this._tbTenDG.Location = new System.Drawing.Point(142, 63);
            this._tbTenDG.MaxLength = 32767;
            this._tbTenDG.Name = "_tbTenDG";
            this._tbTenDG.PasswordChar = '\0';
            this._tbTenDG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._tbTenDG.SelectedText = "";
            this._tbTenDG.SelectionLength = 0;
            this._tbTenDG.SelectionStart = 0;
            this._tbTenDG.Size = new System.Drawing.Size(232, 23);
            this._tbTenDG.TabIndex = 2;
            this._tbTenDG.UseSelectable = true;
            this._tbTenDG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._tbTenDG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(23, 110);
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
            this._btnThoat.Location = new System.Drawing.Point(299, 110);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 3;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _btnThemMoi
            // 
            this._btnThemMoi.Location = new System.Drawing.Point(162, 110);
            this._btnThemMoi.Name = "_btnThemMoi";
            this._btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this._btnThemMoi.TabIndex = 4;
            this._btnThemMoi.Text = "Thêm Mới";
            this._btnThemMoi.UseSelectable = true;
            this._btnThemMoi.Click += new System.EventHandler(this._btnThemMoi_Click);
            // 
            // frmDKLoaiDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 147);
            this.Controls.Add(this._btnThemMoi);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._tbTenDG);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDKLoaiDG";
            this.Resizable = false;
            this.Text = "Loại Độc Giả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox _tbTenDG;
        private MetroFramework.Controls.MetroButton _btnAdd;
        private MetroFramework.Controls.MetroButton _btnThoat;
        private MetroFramework.Controls.MetroButton _btnThemMoi;
    }
}