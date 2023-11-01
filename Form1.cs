using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlCommandBuilder commandBuilder;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM Sellers;";
            string connect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ado2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dataGridView1.DataSource = null;
            conn = new SqlConnection(connect);
            conn.Open();
            adapter = new SqlDataAdapter(sql1, conn);
            ds = new DataSet();
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql2 = "SELECT * FROM Buyers;";
            string connect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ado2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dataGridView1.DataSource = null;
            conn = new SqlConnection(connect);
            conn.Open();
            adapter = new SqlDataAdapter(sql2, conn);
            ds = new DataSet();
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT * FROM Sales;";
            string connect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ado2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dataGridView1.DataSource = null;
            conn = new SqlConnection(connect);
            conn.Open();
            adapter = new SqlDataAdapter(sql3, conn);
            ds = new DataSet();
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}