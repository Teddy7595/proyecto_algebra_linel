using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Algebra_0._0._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.iconMIN.Visible = false;
            if (this.panelCANVAS.Controls.Count > 0)
                this.panelCANVAS.Controls.RemoveAt(0);
            opcionesFORM hijo1 = new opcionesFORM();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelCANVAS.Controls.Add(hijo1);
            this.panelCANVAS.Tag = hijo1;
            hijo1.Show();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconCERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void iconMAX_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.iconMIN.Visible = true;
            this.iconMAX.Visible = false;
        }

        private void iconMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.iconMAX.Visible = true;
            this.iconMIN.Visible = false;
        }

        private void iconMIN2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
