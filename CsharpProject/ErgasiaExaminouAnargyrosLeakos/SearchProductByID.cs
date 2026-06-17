using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ErgasiaExaminouAnargyrosLeakos
{
    public partial class SearchProductByID : Form
    {

        public SearchProductByID()
        {
            InitializeComponent();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            string sql = $"select pp.ProductID, pp.Name " +
                            $"from Production.Product pp " +
                            $"where CAST(ProductID AS VARCHAR) = '{textBox1.Text}'  " +
                            $"or Name like '{textBox1.Text}%' ";
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                  Initial Catalog=AdventureWorks2022;
                                  Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            command = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            command.Dispose();
            cnn.Close();
        }

        private void SwitchModeButton_Click(object sender, EventArgs e)
        { 
            this.Hide();
            var GeneralStock = new GeneralStock();
            GeneralStock.Closed += (s, args) => this.Close();
            GeneralStock.Show();
        }

        private int selectedProductId = -1;
        private void ChooseProductButton_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Select a product first.");
                return;
            }
            dataGridView1.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header double-clicks
            label3.Show();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                label3.Text = "Selected ProductID: " + productId.ToString();
                selectedProductId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                
            }
        }

        private void GeneralStockButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            string sql = $"select pp.ProductID, pp.Name, SUM(pi.Quantity) AS TotalQty " +
                            $"from Production.Product pp " +
                            $"join Production.ProductInventory pi " +
                            $"on pp.ProductID = pi.ProductID " +
                            $"where pp.ProductID = @ProductID " +
                            $"group by pp.ProductID, pp.Name";
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                  Initial Catalog=AdventureWorks2022;
                                  Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            command = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            command.Parameters.AddWithValue("@ProductID", selectedProductId);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            command.Dispose();
            cnn.Close();
        }

        private void EntireStockButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            string sql = $"select pp.ProductID, pp.Name, pi.LocationID, pi.Quantity " +
                            $"from Production.Product pp " +
                            $"join Production.ProductInventory pi " +
                            $"on pp.ProductID = pi.ProductID " +
                            $"where pp.ProductID = @ProductID ";
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                  Initial Catalog=AdventureWorks2022;
                                  Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            command = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            command.Parameters.AddWithValue("@ProductID", selectedProductId);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            command.Dispose();
            cnn.Close();
        }

        private void DetailedStorage_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            string sql = $"select pp.ProductID, pp.Name, pi.LocationID, pi.Shelf, pi.Bin " +
                            $"from Production.Product pp " +
                            $"join Production.ProductInventory pi " +
                            $"on pp.ProductID = pi.ProductID " +
                            $"where pp.ProductID = @ProductID ";
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                  Initial Catalog=AdventureWorks2022;
                                  Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            command = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            command.Parameters.AddWithValue("@ProductID", selectedProductId);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            command.Dispose();
            cnn.Close();
        }
    }

}
