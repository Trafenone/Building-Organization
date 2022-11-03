using Building_Organization.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Building_Organization.Controls
{
    public partial class WorkerControl : UserControl
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        enum RowState
        {
            Modified,
            ModifiedNew,
            Deleted
        }

        public WorkerControl()
        {
            InitializeComponent();
        }
        private void UpdateTable()
        {
            dataBase.OpenConnection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[10].Value;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value);

                    string query = $"DElETE FROM WORKERS WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

                    cmd.ExecuteNonQuery();
                    break;
                }
                if (rowState == RowState.Modified)
                {
                    Int16 Id = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value);
                    string PassNumber = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string Surname = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string Firstname = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string Patronymic = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string DateEmp = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    string Post = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    string Salary = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    string Adress = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    Int16 BrigadeId = Int16.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                    

                    string query = $"UPDATE CLIENT set PassNumber = '{PassNumber}', Surname = '{Surname}', Firstname = '{Firstname}', Patronymic = '{Patronymic}', DateEmp = '{DateEmp}', Post = '{Post}', Salary = '{Salary}', Adress = '{Adress}', BrigadeId = '{BrigadeId}' WHERE Id = '{Id}'";

                    SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

                    cmd.ExecuteNonQuery();

                    break;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.Show();
        }
        private void Edit()
        {
            if (dataGridView1.CurrentCell != null)
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
                if (String.IsNullOrEmpty(tbPost.Text))
                {
                    MessageBox.Show("Невірні дані", "Помилка");
                    return;
                }
                if (String.IsNullOrEmpty(dtp.Text))
                {
                    MessageBox.Show("Невірні дані", "Помилка");
                    return;
                }
                if (String.IsNullOrEmpty(cmId.Text))
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

                int index = dataGridView1.CurrentCell.RowIndex;

                Int16 id = (Int16)dataGridView1.Rows[index].Cells[0].Value;

                var Surname = tbSurname.Text;
                var Firstname = tbName.Text;
                var Patronymic = tbLastName.Text;
                var PassNumber = mtbPassNumber.Text;
                var Adress = tbAdress.Text;
                var Post = tbPost.Text;
                var Salary = tbSalary.Text;
                var DateEmp = dtp.Text;
                var BrigadeId = cmId.Text;

                dataGridView1.Rows[index].SetValues(PassNumber, Surname, Firstname, Patronymic, DateEmp, Post, Salary, Adress, BrigadeId);
                dataGridView1.Rows[index].Cells[10].Value = RowState.Modified;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            ClearFields();
        }
        private void DeleteRow()
        {
            if (dataGridView1.CurrentCell != null)
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
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("PassNumber", "Номер паспорта");
            dataGridView1.Columns.Add("Surname", "Прізвище");
            dataGridView1.Columns.Add("Firstname", "Ім'я");
            dataGridView1.Columns.Add("Patronymic", "По-батькові");
            dataGridView1.Columns.Add("DateEmp", "Дата працевлаштування");
            dataGridView1.Columns.Add("Post", "Посада");
            dataGridView1.Columns.Add("Salary", "Оклад");
            dataGridView1.Columns.Add("Adress", "Адреса");
            dataGridView1.Columns.Add("BrigadeId", "ID Бригади");
            dataGridView1.Columns.Add("IsNew", String.Empty);
           
            dataGridView1.Columns[10].Visible = false;
        }
        private void WorkerControl_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt16(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetDateTime(5),
                record.GetString(6), record.GetDecimal(7), record.GetString(8), record.GetInt16(9), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = $"SELECT * FROM WORKERS";

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
                dtp.Text = row.Cells[5].Value.ToString();
                tbPost.Text = row.Cells[6].Value.ToString();
                tbSalary.Text = row.Cells[7].Value.ToString();
                tbAdress.Text = row.Cells[8].Value.ToString();
                cmId.SelectedText = row.Cells[9].Value.ToString();
            }
        }
        private void ClearFields()
        {
            mtbPassNumber.Text = "";
            tbSurname.Text = "";
            tbName.Text = "";
            tbLastName.Text = "";
            dtp.Text = "";
            tbPost.Text = "";
            tbSalary.Text = "";
            tbAdress.Text = "";
            cmId.Text = "";
            dataGridView1.CurrentCell = null;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1); 
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void SearchClient(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = $"SELECT * FROM WORKERS WHERE CONCAT (Id, PassNumber, Surname, Firstname, Patronymic,  DateEmp, Post, Salary, Adress, BrigadeId) LIKE '%" + tbSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, dataBase.GetConnection());

            dataBase.OpenConnection();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchClient(dataGridView1);
        }
    }
}
