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
    public partial class Deleteitem : Form
    {
        public Deleteitem()
        {
            InitializeComponent();
        }


        private void deleteitembtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Product WHERE ID = @Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(idinputtxt.Text));

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Product with the provided ID does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void backbtncreatepost_Click(object sender, EventArgs e)
        {
            Burgar_temcs productpage = new Burgar_temcs();
            productpage.Show();
            this.Hide();
        }
    }
}
