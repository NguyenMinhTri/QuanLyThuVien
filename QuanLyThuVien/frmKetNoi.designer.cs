namespace UI
{
    partial class frmKetNoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetNoi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKetNoi = new MetroFramework.Controls.MetroButton();
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.cbbDatabase = new System.Windows.Forms.ComboBox();
            this.btnThoat = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ten Database:";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(58, 180);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetNoi.TabIndex = 1;
            this.btnKetNoi.Text = "Kết Nối";
            this.btnKetNoi.UseSelectable = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // cbbServer
            // 
            this.cbbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(151, 75);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(233, 21);
            this.cbbServer.TabIndex = 2;
            this.cbbServer.SelectedIndexChanged += new System.EventHandler(this.cbbServer_SelectedIndexChanged);
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.Location = new System.Drawing.Point(151, 128);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(233, 21);
            this.cbbDatabase.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(309, 180);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseSelectable = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 238);
            this.Controls.Add(this.cbbDatabase);
            this.Controls.Add(this.cbbServer);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKetNoi";
            this.Resizable = false;
            this.Text = "Kết Nối Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnKetNoi;
        private System.Windows.Forms.ComboBox cbbServer;
        private System.Windows.Forms.ComboBox cbbDatabase;
        private MetroFramework.Controls.MetroButton btnThoat;
    }
}