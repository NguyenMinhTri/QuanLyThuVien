using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace UI
{
    public partial class frmKetNoi : MetroFramework.Forms.MetroForm
    {
        BUSDuLieu _busDuLieu = new BUSDuLieu();
        public frmKetNoi()
        {
            InitializeComponent();
            try
            {
                for (int i = 0; i < GetServerName().Count; i++)
                {
                    cbbServer.Items.Add(GetServerName()[i]);
                }
                cbbServer.SelectedIndex = 0;
            }
            catch { }
        }
        public List<string> GetServerName()
        {
            List<string> serverNames = new List<string>();

            string machineName = null;
            try
            {
                machineName = Environment.MachineName;
            }
            catch
            { }

            if (machineName != null)
            {
                serverNames.Add(machineName);

                List<string> instanceNames = GetInstanceName();
                foreach (string instanceName in instanceNames)
                    serverNames.Add(machineName + @"\" + instanceName);
            }

            return serverNames;
        }
        public List<string> GetInstanceName()
        {
            List<string> instanceNames = new List<string>();

            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        instanceNames.Add(instanceName);
                    }
                }
            }

            return instanceNames;
        }

        private void cbbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                List<string> database = _busDuLieu.DanhSachCoSoDuLieu(cbbServer.Text);
                if (database.Count != 0)
                {
                    for (int i = 0; i < database.Count; i++)
                    {
                        // if(database[i]== "DATA_THUVIEN")
                        cbbDatabase.Items.Add(database[i]);
                    }
                    cbbDatabase.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            //  if (cbbDatabase.Text == "DATA_THUVIEN")
            {

                _busDuLieu.KhoiTaoChuoiKetNoi(cbbServer.Text, cbbDatabase.Text);
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
                frmMain.ShowDialog();

            }
            //  else
            //      MessageBox.Show("Sai Tên Cơ Sỡ Dữ Liệu Vui Lòng Chọn Lại");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
