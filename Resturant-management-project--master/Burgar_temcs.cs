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

namespace E_Project
{
    public partial class Burgar_temcs : Form
    {
        public Burgar_temcs()
        {
            InitializeComponent();
        }
        

        private void createbtn_Click(object sender, EventArgs e)
        {
            Createproduct create=new Createproduct();
            create.Show();
            this.Hide();
        }
            SqlConnection con =new SqlConnection( "Data Source=USER\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True;");
        private void display()
        {
            
                try
                {

                con.Open();
                string strCommand = "SELECT [Name], [Description], [Price], [Size], [ID] FROM [dbo].[Product]";
                SqlCommand objCommand = new SqlCommand(strCommand, con);
                //bind data with ui
                DataSet objDataSet = new DataSet();
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
                objAdapter.Fill(objDataSet);

                // Clear existing columns from DataGridView
                Productbox.Columns.Clear();

                // Bind data to DataGridView
                Productbox.DataSource = objDataSet.Tables[0];

                con.Close();



            }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);

                }

            

        }

        private void updategrid_Click(object sender, EventArgs e)
        {
            display();
           
        

    }

        private void Burgar_temcs_Load(object sender, EventArgs e)
        {
            display() ;
        }

        private void Productboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)//deletebutton
        {
            Deleteitem item= new Deleteitem();
            item.Show();
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            updatedetails update=new updatedetails();
            update.Show();
            this.Hide();
        }

        /* private void Productboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
          SqlConnection con=new SqlConnection()





        using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT [Name]\r\n      ,[Description]\r\n      ,[Price]\r\n      ,[Size]\r\n      ,[ID]\r\n  FROM [dbo].[Product]\r\n";
                    // SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from product", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the GridView
                    Productboard.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
         }*/

    }
}
