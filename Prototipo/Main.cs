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
            //panelInicio.Visible = true;
            //panelMenu.Visible = false;
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
            panelInicio.Visible = true;
            panelMenu.Visible = false;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            pan_Marca.Location = new Point(0, btn_Menu.Location.Y);
            panelInicio.Visible = false;
            panelMenu.Visible = true;
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

        private void labelPrincipios_Click(object sender, EventArgs e)
        {
            panelPFuerte.Visible = false;
            panelPostres.Visible = false;
            panelPrincipios.Visible = true;
        }

        private void labelPFuerte_Click(object sender, EventArgs e)
        {
            panelPFuerte.Visible = true;
            panelPostres.Visible = false;
            panelPrincipios.Visible = false;
        }

        private void labelPostres_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPostres.Visible = true;
            panelPFuerte.Visible = false;
            panelPrincipios.Visible = false;
        }
    }
}