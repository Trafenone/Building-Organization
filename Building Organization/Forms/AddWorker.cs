using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;

namespace Building_Organization.Forms
{
    public partial class AddWorker : Form
    {
        DataBase dataBase = new DataBase();
        public AddWorker()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSurname.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }
            if (String.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }
            if (String.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }
            if (String.IsNullOrEmpty(mtbPassNumber.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }
            if (String.IsNullOrEmpty(tbAdress.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }
            if(String.IsNullOrEmpty(tbPost.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }
            if (String.IsNullOrEmpty(dtp.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }
            if (String.IsNullOrEmpty(cbID.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }
            decimal salary;
            try
            {
                salary = decimal.Parse(tbSalary.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Невірно введено розмір платні", "Помилка");
                return;
            }
            dataBase.OpenConnection();

            var Surname = tbSurname.Text;
            var Firstname = tbName.Text;
            var Patronymic = tbLastName.Text;
            var PassNumber = mtbPassNumber.Text;
            var Adress = tbAdress.Text;
            var Post = tbPost.Text;
            var Salary = tbSalary.Text;
            var DateEmp = dtp.Text;
            var BrigadeId = cbID.Text;

            string query = $"INSERT INTO WORKERS (PassNumber, Surname, Firstname, Patronymic, DateEmp, Post, Salary, Adress, BrigadeId) VALUES ('{PassNumber}', '{Surname}', '{Firstname}', '{Patronymic}', '{DateEmp}', '{Post}', '{Salary}', '{Adress}', {BrigadeId})";

            SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

            cmd.ExecuteNonQuery();

            MessageBox.Show("Запит добавлений успішно", "Виконано", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.CloseConnection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "buildingDataSet.BRIGADE". При необходимости она может быть перемещена или удалена.
            this.bRIGADETableAdapter.Fill(this.buildingDataSet.BRIGADE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "buildingDataSet.CLIENT". При необходимости она может быть перемещена или удалена.
            this.cLIENTTableAdapter.Fill(this.buildingDataSet.CLIENT);

        }
    }
}
