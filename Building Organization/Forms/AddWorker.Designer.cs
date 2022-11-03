namespace Building_Organization.Forms
{
    partial class AddWorker
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbPassNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbPost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingDataSet = new Building_Organization.BuildingDataSet();
            this.cLIENTTableAdapter = new Building_Organization.BuildingDataSetTableAdapters.CLIENTTableAdapter();
            this.bRIGADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRIGADETableAdapter = new Building_Organization.BuildingDataSetTableAdapters.BRIGADETableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRIGADEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Створення нового запису";
            // 
            // mtbPassNumber
            // 
            this.mtbPassNumber.BackColor = System.Drawing.Color.DarkBlue;
            this.mtbPassNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbPassNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbPassNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mtbPassNumber.Location = new System.Drawing.Point(218, 171);
            this.mtbPassNumber.Mask = "№ 000000000";
            this.mtbPassNumber.Name = "mtbPassNumber";
            this.mtbPassNumber.Size = new System.Drawing.Size(251, 20);
            this.mtbPassNumber.TabIndex = 18;
            this.mtbPassNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPassNumber.ValidatingType = typeof(int);
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.DarkBlue;
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbLastName.Location = new System.Drawing.Point(218, 140);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(251, 20);
            this.tbLastName.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.DarkBlue;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.Location = new System.Drawing.Point(218, 112);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(251, 20);
            this.tbName.TabIndex = 16;
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.DarkBlue;
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSurname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbSurname.Location = new System.Drawing.Point(218, 82);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(251, 20);
            this.tbSurname.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата працевлаштування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Номер паспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "По-батькові";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ім\'я";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Прізвище";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 62);
            this.panel1.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::Building_Organization.Properties.Resources.icons8_close_window_501;
            this.btnCancel.Location = new System.Drawing.Point(402, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 52);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightGray;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Image = global::Building_Organization.Properties.Resources.icons8_checked_checkbox_50;
            this.btnCreate.Location = new System.Drawing.Point(20, 436);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 52);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtp.CustomFormat = "yyyy-MM-dd";
            this.dtp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(273, 302);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(196, 27);
            this.dtp.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Адрес";
            // 
            // tbAdress
            // 
            this.tbAdress.BackColor = System.Drawing.Color.DarkBlue;
            this.tbAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAdress.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbAdress.Location = new System.Drawing.Point(218, 201);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(251, 20);
            this.tbAdress.TabIndex = 25;
            // 
            // tbPost
            // 
            this.tbPost.BackColor = System.Drawing.Color.DarkBlue;
            this.tbPost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPost.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPost.Location = new System.Drawing.Point(218, 234);
            this.tbPost.Name = "tbPost";
            this.tbPost.Size = new System.Drawing.Size(251, 20);
            this.tbPost.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Посада";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Оклад (грн)";
            // 
            // tbSalary
            // 
            this.tbSalary.BackColor = System.Drawing.Color.DarkBlue;
            this.tbSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSalary.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSalary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbSalary.Location = new System.Drawing.Point(218, 268);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(251, 20);
            this.tbSalary.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(145, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 31;
            this.label10.Text = "ID Бригади";
            // 
            // cbID
            // 
            this.cbID.BackColor = System.Drawing.Color.DarkBlue;
            this.cbID.DataSource = this.bRIGADEBindingSource;
            this.cbID.DisplayMember = "Id";
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbID.FormatString = "C2";
            this.cbID.Location = new System.Drawing.Point(273, 344);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(196, 27);
            this.cbID.TabIndex = 32;
            this.cbID.ValueMember = "Id";
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.buildingDataSet;
            // 
            // buildingDataSet
            // 
            this.buildingDataSet.DataSetName = "BuildingDataSet";
            this.buildingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // bRIGADEBindingSource
            // 
            this.bRIGADEBindingSource.DataMember = "BRIGADE";
            this.bRIGADEBindingSource.DataSource = this.buildingDataSet;
            // 
            // bRIGADETableAdapter
            // 
            this.bRIGADETableAdapter.ClearBeforeFill = true;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtbPassNumber);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "AddWorker";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати клієнта";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRIGADEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbPassNumber;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbPost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbID;
        private BuildingDataSet buildingDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private BuildingDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource bRIGADEBindingSource;
        private BuildingDataSetTableAdapters.BRIGADETableAdapter bRIGADETableAdapter;
    }
}