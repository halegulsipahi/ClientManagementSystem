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
    }
}
