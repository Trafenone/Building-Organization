namespace Building_Organization
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnFavours = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnBrigade = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaxed = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.brigadeControl1 = new Building_Organization.Controls.BrigadeControl();
            this.clientControl1 = new Building_Organization.Forms.ClientControl();
            this.workerControl1 = new Building_Organization.Controls.WorkerControl();
            this.panelMenu.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.panelMenu.Controls.Add(this.btnMaterials);
            this.panelMenu.Controls.Add(this.btnFavours);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.btnClient);
            this.panelMenu.Controls.Add(this.btnWorkers);
            this.panelMenu.Controls.Add(this.btnBrigade);
            this.panelMenu.Controls.Add(this.panelHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 600);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMaterials
            // 
            this.btnMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterials.FlatAppearance.BorderSize = 0;
            this.btnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterials.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaterials.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaterials.Image = global::Building_Organization.Properties.Resources.icons8_paint_bucket_50;
            this.btnMaterials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterials.Location = new System.Drawing.Point(0, 430);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMaterials.Size = new System.Drawing.Size(220, 70);
            this.btnMaterials.TabIndex = 6;
            this.btnMaterials.Text = "   Materials";
            this.btnMaterials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterials.UseVisualStyleBackColor = true;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnFavours
            // 
            this.btnFavours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavours.FlatAppearance.BorderSize = 0;
            this.btnFavours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFavours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFavours.Image = global::Building_Organization.Properties.Resources.icons8_service_50__1_;
            this.btnFavours.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavours.Location = new System.Drawing.Point(0, 360);
            this.btnFavours.Name = "btnFavours";
            this.btnFavours.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFavours.Size = new System.Drawing.Size(220, 70);
            this.btnFavours.TabIndex = 5;
            this.btnFavours.Text = "   Favours";
            this.btnFavours.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavours.UseVisualStyleBackColor = true;
            this.btnFavours.Click += new System.EventHandler(this.btnFavours_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrder.Image = global::Building_Organization.Properties.Resources.icons8_purchase_order_50;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 290);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(220, 70);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "   Orders";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClient.Image = global::Building_Organization.Properties.Resources.icons8_client_50;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(0, 220);
            this.btnClient.Name = "btnClient";
            this.btnClient.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClient.Size = new System.Drawing.Size(220, 70);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "   Clients";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkers.FlatAppearance.BorderSize = 0;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWorkers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWorkers.Image = global::Building_Organization.Properties.Resources.icons8_worker_50;
            this.btnWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkers.Location = new System.Drawing.Point(0, 150);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnWorkers.Size = new System.Drawing.Size(220, 70);
            this.btnWorkers.TabIndex = 1;
            this.btnWorkers.Text = "   Workers";
            this.btnWorkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnBrigade
            // 
            this.btnBrigade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrigade.FlatAppearance.BorderSize = 0;
            this.btnBrigade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrigade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrigade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrigade.Image = global::Building_Organization.Properties.Resources.icons8_workers_50;
            this.btnBrigade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrigade.Location = new System.Drawing.Point(0, 80);
            this.btnBrigade.Name = "btnBrigade";
            this.btnBrigade.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBrigade.Size = new System.Drawing.Size(220, 70);
            this.btnBrigade.TabIndex = 2;
            this.btnBrigade.Text = "   Brigades";
            this.btnBrigade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrigade.UseVisualStyleBackColor = false;
            this.btnBrigade.Click += new System.EventHandler(this.btnBrigade_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(220, 80);
            this.panelHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::Building_Organization.Properties.Resources.icons8_home_50;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 80);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.panelTitleBar.Controls.Add(this.btnMaxed);
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnMax);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(980, 30);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnMaxed
            // 
            this.btnMaxed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxed.FlatAppearance.BorderSize = 0;
            this.btnMaxed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMaxed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxed.Image = global::Building_Organization.Properties.Resources.icons8_восстановить_окно_32;
            this.btnMaxed.Location = new System.Drawing.Point(802, 0);
            this.btnMaxed.Name = "btnMaxed";
            this.btnMaxed.Size = new System.Drawing.Size(40, 30);
            this.btnMaxed.TabIndex = 4;
            this.btnMaxed.UseVisualStyleBackColor = true;
            this.btnMaxed.Visible = false;
            this.btnMaxed.Click += new System.EventHandler(this.btnMaxed_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::Building_Organization.Properties.Resources.icons8_minus_32;
            this.btnMin.Location = new System.Drawing.Point(848, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 30);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::Building_Organization.Properties.Resources.icons8_maximize_button_32;
            this.btnMax.Location = new System.Drawing.Point(894, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 30);
            this.btnMax.TabIndex = 2;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Building_Organization.Properties.Resources.icons8_close_30;
            this.btnClose.Location = new System.Drawing.Point(940, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 30);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(52, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(301, 30);
            this.title.TabIndex = 0;
            this.title.Text = "Будівельна організація";
            // 
            // brigadeControl1
            // 
            this.brigadeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brigadeControl1.Location = new System.Drawing.Point(220, 30);
            this.brigadeControl1.Name = "brigadeControl1";
            this.brigadeControl1.Size = new System.Drawing.Size(980, 570);
            this.brigadeControl1.TabIndex = 3;
            // 
            // clientControl1
            // 
            this.clientControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl1.Location = new System.Drawing.Point(220, 30);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(980, 570);
            this.clientControl1.TabIndex = 2;
            this.clientControl1.TabStop = false;
            // 
            // workerControl1
            // 
            this.workerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workerControl1.Location = new System.Drawing.Point(220, 30);
            this.workerControl1.Name = "workerControl1";
            this.workerControl1.Size = new System.Drawing.Size(980, 570);
            this.workerControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.workerControl1);
            this.Controls.Add(this.brigadeControl1);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будівельна організація";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnFavours;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMaxed;
        private System.Windows.Forms.Button btnHome;
        private Forms.ClientControl clientControl1;
        private System.Windows.Forms.Button btnBrigade;
        private Controls.BrigadeControl brigadeControl1;
        private Controls.WorkerControl workerControl1;
    }
}

