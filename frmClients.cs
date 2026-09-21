using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClientManagementSystem
{
    public partial class frmClients : Form
    {
        //Data Source = LAPTOP - 3790I1BK\SQLEXPRESS;Initial Catalog = ClientsDB; Integrated Security = True; Encrypt=False

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-3790I1BK\SQLEXPRESS;Initial Catalog=ClientsDB;Integrated Security=True;Encrypt=False");
        public frmClients()
        {

            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        void List()
        {
            connection.Open();

            string query = "select * from Clients";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgDatas.DataSource = dt;
            connection.Close();

            foreach (DataGridViewColumn col in dgDatas.Columns)
            {

                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        void Reset()
        {
            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAge.Clear();
            txtNationalId.Clear();
            mtxtPhone.Clear();
            txtJob.Clear();
            txtCity.Clear();
            rbMarried.Checked = false;
            rbSingle.Checked = false;

            txtName.Focus();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {

            Timer timer = new Timer();
            timer.Interval = 1000;

            timer.Tick += Timer_Tick;
            timer.Start();

            List();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgDatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            connection.Open();
            var id = dgDatas.Rows[e.RowIndex].Cells[0].Value;

            string query = "select * from Clients where Id=@id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("id", id);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtSurname.Text = dt.Rows[0]["Surname"].ToString();
                txtAge.Text = dt.Rows[0]["Age"].ToString();
                txtNationalId.Text = dt.Rows[0]["NationalId"].ToString();
                mtxtPhone.Text = dt.Rows[0]["Phone"].ToString();
                txtJob.Text = dt.Rows[0]["Job"].ToString();
                txtCity.Text = dt.Rows[0]["City"].ToString();

                if (dt.Rows[0]["MaritalStatus"].ToString() == "True")
                {
                    rbMarried.Checked = true;

                }
                else
                {
                    rbSingle.Checked = true;
                }

            }
            connection.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string surname = txtSurname.Text;
            string age = txtAge.Text;
            string nationalId = txtNationalId.Text;
            string phone = mtxtPhone.Text;
            string job = txtJob.Text;
            string city = txtCity.Text;
            bool maritalStatus = rbMarried.Checked;

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(age) ||
                string.IsNullOrEmpty(nationalId) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(job) ||
                string.IsNullOrEmpty(city) ||
                (!rbMarried.Checked && !rbSingle.Checked))
            {
                MessageBox.Show("PLEASE FILL IN ALL FIELDS!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connection.Open();

            string query = "insert into Clients (Name,Surname,Age,NationalId,Phone,MaritalStatus,Job,City) values ( @Name,@Surname,@Age,@NationalId,@Phone,@MaritalStatus,@Job,@City)";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Surname", surname);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@NationalId", nationalId);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
            cmd.Parameters.AddWithValue("@Job", job);
            cmd.Parameters.AddWithValue("@City", city);

            cmd.ExecuteNonQuery();

            MessageBox.Show("SUCCESSFULLY ADDED!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();

            List();

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                string query = "delete from Clients where Id=@id";
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", txtId.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("SUCCESSFULLY DELETED!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

                List();
                Reset();


            }
            else
            {
                MessageBox.Show("SELECT A CLİENT FROM THE LIST!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string age = txtAge.Text;
            string nationalId = txtNationalId.Text;
            string phone = mtxtPhone.Text;
            string job = txtJob.Text;
            string city = txtCity.Text;
            bool maritalStatus = rbMarried.Checked;

            if (txtId.Text != "")
            {
                connection.Open();

                string query = "update Clients set Name=@Name,  Surname=@Surname,Age=@Age,   NationalId= @NationalId,  Phone = @Phone,MaritalStatus = @MaritalStatus, Job = @Job, City = @City where Id=@id ";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@NationalId", nationalId);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                cmd.Parameters.AddWithValue("@Job", job);
                cmd.Parameters.AddWithValue("@City", city);

                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESSFULLY UPDATED!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();

                List();

            }

            else
            {
                MessageBox.Show("SELECT A CLİENT FROM THE LIST!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
