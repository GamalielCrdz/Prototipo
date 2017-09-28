using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            pan_Marca.Location = new Point(0, btn_Home.Location.Y);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            pan_Marca.Location = new Point(0, btn_Menu.Location.Y);
        }

        private void btn_Ord_Click(object sender, EventArgs e)
        {
            pan_Marca.Location = new Point(0, btn_Ord.Location.Y);
        }

        private void btn_Sucursales_Click(object sender, EventArgs e)
        {
            pan_Marca.Location = new Point(0, btn_Sucursales.Location.Y);
        }

        private void btn_Fran_Click(object sender, EventArgs e)
        {
            pan_Marca.Location = new Point(0, btn_Fran.Location.Y);
        }

        private void btn_Cont_Click(object sender, EventArgs e)
        {
            pan_Marca.Location = new Point(0, btn_Cont.Location.Y);
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


    }
}