using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Building_Organization.Forms
{
    public partial class AddClient : Form
    {
        DataBase dataBase = new DataBase();
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbSurname.Text))
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
            if (String.IsNullOrEmpty(mtbPhone.Text))
            {
                MessageBox.Show("Невірні дані", "Помилка");
                return;
            }

            dataBase.OpenConnection();

            var Surname = tbSurname.Text;
            var Name = tbName.Text;
            var LastName = tbLastName.Text;
            var PassNumber = mtbPassNumber.Text;
            var Phone = mtbPhone.Text;

            string query = $"INSERT INTO CLIENT (PassNumber, Surname, Firstname, Patronymic, Phone) VALUES ('{PassNumber}', '{Surname}', '{Name}', '{LastName}', '{Phone}')";

            SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

            cmd.ExecuteNonQuery();

            MessageBox.Show("Запит добавлений успішно", "Виконано", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.CloseConnection();
        }
    }
}
