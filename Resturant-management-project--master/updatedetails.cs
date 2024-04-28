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

namespace E_Project
{
    public partial class updatedetails : Form
    {
        public updatedetails()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtxtbox.Text))
            {
                MessageBox.Show("Please enter the product ID.");
                return;
            }

            int id = int.Parse(idtxtbox.Text);
            bool anyUpdate = false; // Flag to check if any field is being updated

            using (SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True;"))
            {
                try
                {
                    con.Open();

                    string query = "UPDATE Product SET ";

                    // Check if any specific field is being updated
                    if (!string.IsNullOrEmpty(pricetxtboxproduct.Text))
                    {
                        query += "Price = @Price, ";
                        anyUpdate = true;
                    }
                    if (!string.IsNullOrEmpty(nametxtboxupdate.Text))
                    {
                        query += "Name = @Name, ";
                        anyUpdate = true;
                    }
                    if (!string.IsNullOrEmpty(descriptiontxtupdate.Text))
                    {
                        query += "Description = @Description, ";
                        anyUpdate = true;
                    }
                    if (!string.IsNullOrEmpty(sizetxtboxproduct.Text))
                    {
                        query += "Size = @Size, ";
                        anyUpdate = true;
                    }

                    // Remove the trailing comma and space
                    if (anyUpdate)
                    {
                        query = query.Remove(query.Length - 2);

                        // Add WHERE clause
                        query += " WHERE ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            if (!string.IsNullOrEmpty(pricetxtboxproduct.Text))
                            {
                                cmd.Parameters.AddWithValue("@Price", int.Parse(pricetxtboxproduct.Text));
                            }
                            if (!string.IsNullOrEmpty(nametxtboxupdate.Text))
                            {
                                cmd.Parameters.AddWithValue("@Name", nametxtboxupdate.Text);
                            }
                            if (!string.IsNullOrEmpty(descriptiontxtupdate.Text))
                            {
                                cmd.Parameters.AddWithValue("@Description", descriptiontxtupdate.Text);
                            }
                            if (!string.IsNullOrEmpty(sizetxtboxproduct.Text))
                            {
                                cmd.Parameters.AddWithValue("@Size", sizetxtboxproduct.Text);
                            }

                            cmd.Parameters.AddWithValue("@ID", id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("No Product with the provided ID was found");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide at least one field to update.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product: " + ex.Message);
                }
            }
        }

        private void backbtncreatepost_Click(object sender, EventArgs e)
        {
            Burgar_temcs back=new Burgar_temcs();
            back.Show();
            this.Hide();

        }
    }


     }

 
        
    

