using Building_Organization.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Building_Organization
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DefaultTheme()
        {
            clientControl1.Visible = false;
            brigadeControl1.Visible = false; 
            workerControl1.Visible = false;

            panelTitleBar.BackColor = Color.FromArgb(130, 192, 204);

            btnClient.BackColor = panelMenu.BackColor;
            btnBrigade.BackColor = panelMenu.BackColor;
            btnWorkers.BackColor = panelMenu.BackColor;
            btnOrder.BackColor = panelMenu.BackColor;
            btnFavours.BackColor = panelMenu.BackColor;
            btnMaterials.BackColor = panelMenu.BackColor;

            title.Text = "Будівельна організація";
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            DefaultTheme();

            workerControl1.Visible = true;

            btnWorkers.BackColor = Color.FromArgb(255, 224, 192);
            panelTitleBar.BackColor = Color.FromArgb(255, 224, 192);

            title.Text = "Робітники";
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            DefaultTheme();

            clientControl1.Visible = true;

            btnClient.BackColor = Color.FromArgb(255, 255, 153);
            panelTitleBar.BackColor = Color.FromArgb(255, 255, 153);

            title.Text = "Клієнти";
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            clientControl1.Visible = false;
            brigadeControl1.Visible = false;
            workerControl1.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMaxed.Location = btnMax.Location;
            btnMaxed.Visible = true;
        }

        private void btnMaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxed.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DefaultTheme();
        }

        private void btnBrigade_Click(object sender, EventArgs e)
        {
            DefaultTheme();

            brigadeControl1.Visible = true;

            btnBrigade.BackColor = Color.Pink;
            panelTitleBar.BackColor = Color.Pink;

            title.Text = "Бригади";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DefaultTheme();

            //////////////////TASK
            
            btnOrder.BackColor = Color.FromArgb(204, 255, 153);
            panelTitleBar.BackColor = Color.FromArgb(204, 255, 153);

            title.Text = "Бригади";

        }

        private void btnFavours_Click(object sender, EventArgs e)
        {
            DefaultTheme();

            //////////////////TASK
            btnFavours.BackColor = Color.FromArgb(153, 255, 153);
            panelTitleBar.BackColor = Color.FromArgb(153, 255, 153);

            title.Text = "Послуги";
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            DefaultTheme();

            //////////////////TASK

            btnMaterials.BackColor = Color.FromArgb(153, 255, 204);
            panelTitleBar.BackColor = Color.FromArgb(153, 255, 204);

            title.Text = "Матеріали";
        }
    }
}
