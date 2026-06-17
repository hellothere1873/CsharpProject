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

namespace ErgasiaExaminouAnargyrosLeakos
{
    public partial class ProductsLowStock : Form
    {
        public ProductsLowStock()
        {
            InitializeComponent();
        }


        private void SwitchModeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var searchProductByID = new SearchProductByID();
            searchProductByID.Closed += (s, args) => this.Close();
            searchProductByID.Show();
        }

        private void ShowProductsInLowStockButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            string sql = $"select pp.ProductID, pp.Name, pp.SafetyStockLevel, SUM(pi.Quantity) AS TotalQty " +
                            $"from Production.Product pp " +
                            $"join Production.ProductInventory pi " +
                            $"on pp.ProductID = pi.ProductID " +
                            $"group by pp.ProductID, pp.Name, pp.SafetyStockLevel " +
                            $"having SUM(pi.Quantity) < pp.SafetyStockLevel ";
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
    }
}
