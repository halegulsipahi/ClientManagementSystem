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

        private void frmClients_Load(object sender, EventArgs e)
        {

            Timer timer = new Timer();
            timer.Interval = 1000;

            timer.Tick += Timer_Tick;
            timer.Start();

            connection.Open();

            string query = "select * from Clients";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgDatas.DataSource = dt;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgDatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

        }

        private void btnReset_Click(object sender, EventArgs e)
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
        }
    }
}
