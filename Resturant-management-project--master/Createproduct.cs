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
    public partial class Createproduct : Form
    {
        public Createproduct()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Product values(@Name,@Description,@Price,@Size)",con);
            cmd.Parameters.AddWithValue("Name",nametxtboxproduct.Text);
            cmd.Parameters.AddWithValue("@Description",descriptiontxt.Text);
            cmd.Parameters.AddWithValue("@Price",int.Parse(pricetxtbox.Text));
            cmd.Parameters.AddWithValue("@Size", int.Parse(sizetxtbox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Added Successfully ");
            
        }
       


            private void backbtncreatepost_Click(object sender, EventArgs e)
        {
            Burgar_temcs productpage=new Burgar_temcs();
            productpage.Show();
            this.Hide();
        }
    }
}
