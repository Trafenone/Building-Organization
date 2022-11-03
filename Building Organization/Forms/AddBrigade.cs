using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Building_Organization.Forms
{
    public partial class AddBrigade : Form
    {
        DataBase dataBase = new DataBase();
        public AddBrigade()
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

            string query = $"INSERT INTO BRIGADE (PassNumber, Surname, Firstname, Patronymic, Phone) VALUES ('{PassNumber}', '{Surname}', '{Name}', '{LastName}', '{Phone}')";

            SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

            cmd.ExecuteNonQuery();

            MessageBox.Show("Запит добавлений успішно", "Виконано", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.CloseConnection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
