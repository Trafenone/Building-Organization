using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Building_Organization.Forms
{
    enum RowState
    { 
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class ClientControl : UserControl
    {
        DataBase dataBase = new DataBase();

        int selectedRow;


        public ClientControl()
        {
            InitializeComponent();
        }

        private void ClientControl_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("PassNumber", "Номер паспорта");
            dataGridView1.Columns.Add("Surname", "Прізвище");
            dataGridView1.Columns.Add("Firstname", "Ім'я");
            dataGridView1.Columns.Add("Patronymic", "По-батькові");
            dataGridView1.Columns.Add("Phone", "Телефон");
            dataGridView1.Columns.Add("IsNew", String.Empty);

            dataGridView1.Columns[6].Visible = false;
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt16(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = $"SELECT * FROM CLIENT";

            SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                mtbPassNumber.Text = row.Cells[1].Value.ToString();
                tbSurname.Text = row.Cells[2].Value.ToString();
                tbName.Text = row.Cells[3].Value.ToString();
                tbLastName.Text = row.Cells[4].Value.ToString();
                mtbPhone.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }
        private void UpdateTable()
        {
            dataBase.OpenConnection();

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[6].Value;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value);

                    string query = $"DElETE FROM CLIENT WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

                    cmd.ExecuteNonQuery();
                    break;
                }
                if(rowState == RowState.Modified)
                {
                    Int16 Id = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value);
                    string PassNumber = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string Surname = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string Name = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string LastName = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string Phone = dataGridView1.Rows[i].Cells[5].Value.ToString();

                    string query = $"UPDATE CLIENT set PassNumber = '{PassNumber}', Surname = '{Surname}', Firstname = '{Name}', Patronymic = '{LastName}', Phone = '{Phone}' WHERE Id = '{Id}'";

                    SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

                    cmd.ExecuteNonQuery();

                    break ;
                }
            }
        }
        private void SearchClient(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = $"SELECT * FROM CLIENT WHERE CONCAT (Id, PassNumber, Surname, Firstname, Patronymic, Phone) LIKE '%" + tbSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

            dataBase.OpenConnection();
            
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchClient(dataGridView1);
        }

        private void DeleteRow()
        {
            if(dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                if (index != -1)
                {
                    dataGridView1.Rows[index].Visible = false;

                    dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void Edit()
        {
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

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

                Int16 id = (Int16)dataGridView1.Rows[index].Cells[0].Value;

                string PassNumber = mtbPassNumber.Text;
                string Surname = tbSurname.Text;
                string Name = tbName.Text;
                string LastName = tbLastName.Text;
                string Phone = mtbPhone.Text;

                dataGridView1.Rows[index].SetValues(id, PassNumber, Surname, Name, LastName, Phone);
                dataGridView1.Rows[index].Cells[6].Value = RowState.Modified;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            ClearFields();
        }
        private void ClearFields()
        {
            tbSurname.Text = "";
            tbLastName.Text = "";
            tbName.Text = "";
            tbLastName.Text = "";
            mtbPhone.Text = "";
            mtbPassNumber.Text = "";
            dataGridView1.CurrentCell = null;
        }
        private void btnErase_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
