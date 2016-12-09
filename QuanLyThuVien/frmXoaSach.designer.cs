namespace UI
{
    partial class frmXoaSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaSach));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this._btnXoa = new MetroFramework.Controls.MetroButton();
            this._btnThoat = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(130, 65);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phiếu Nhập :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Số Lượng :";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(130, 124);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 2;
            this.metroComboBox2.UseSelectable = true;
            // 
            // _btnXoa
            // 
            this._btnXoa.Location = new System.Drawing.Point(23, 171);
            this._btnXoa.Name = "_btnXoa";
            this._btnXoa.Size = new System.Drawing.Size(75, 23);
            this._btnXoa.TabIndex = 3;
            this._btnXoa.Text = "Xóa";
            this._btnXoa.UseSelectable = true;
            this._btnXoa.Click += new System.EventHandler(this._btnXoa_Click);
            // 
            // _btnThoat
            // 
            this._btnThoat.Location = new System.Drawing.Point(176, 171);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.TabIndex = 3;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.UseSelectable = true;
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // frmXoaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 225);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnXoa);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroComboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmXoaSach";
            this.Resizable = false;
            this.Text = "Xóa Sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroButton _btnXoa;
        private MetroFramework.Controls.MetroButton _btnThoat;
    }
}