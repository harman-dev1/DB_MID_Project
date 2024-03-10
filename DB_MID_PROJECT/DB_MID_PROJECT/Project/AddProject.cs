using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectA
{
    public partial class AddProject : UserControl
    {
        public AddProject()
        {
            InitializeComponent();
            idBox.Enabled = true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Project values (@Description, @Title)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Title", titleBox.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Title:");
            }
            try
            {
                if (descriptionBox.Text != "")
                    cmd.Parameters.AddWithValue("@Description", descriptionBox.Text);
                else
                {
                    MessageBox.Show("Please Enter Value");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("please Enter Correct Value");
            }
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Correct Value: ");
            }
            MessageBox.Show("Successfully saved");
            idBox.Enabled = true;
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            bool check = false;

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Project WHERE Id=@Id", con);
            if (idBox.Text != "")
                cmd.Parameters.AddWithValue("@Id", idBox.Text);
            else
            {
                MessageBox.Show("Please Enter Id");
            }
            try
            {
                check = true;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                check = false;
                MessageBox.Show("Please Wrtite COrrect Value");
            }
            if (check == true)
                MessageBox.Show("Data Deleted SuccessFully");

        }

        private void idBox_Validating(object sender, CancelEventArgs e)
        {
            if (idBox.Text != "")
            {
                Regex regex = new Regex(@"^+\d+$");

                // Check if the textbox text matches the pattern
                if (!regex.IsMatch(idBox.Text))
                {
                    e.Cancel = true; // Cancel the validation
                    MessageBox.Show("Please enter a valid Id # OR Clear Section to Exit.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand command = new SqlCommand("select * from Project", con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            string ttile = "";
            string description = "";
            int id = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                id = int.Parse(row["Id"].ToString());
                if (id == int.Parse(idBox.Text))
                {
                    ttile = row["Title"].ToString();
                    description = row["Description"].ToString();
                    break;
                }

            }
            bool check = false;
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Project set  Description = @Description,Title=@Title where Id=@Id", con1);
            cmd.Parameters.AddWithValue("@Id", id);
            if (titleBox.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Title", titleBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Correct Title: ");
                }
            }
            if (titleBox.Text == "")
            {
                cmd.Parameters.AddWithValue("@Title", ttile);
            }
            if (descriptionBox.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Description", descriptionBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Correct Description: ");
                }
            }
            if (descriptionBox.Text == "")
            {
                cmd.Parameters.AddWithValue("@Description", description);
            }
            try
            {
                check = true;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                check = false;
                MessageBox.Show("Please Enter Value");
            }
            if (check == true)
            {
                MessageBox.Show("Data Updated Successfully: ");
            }

        }

        private void adpabutton_Click(object sender, EventArgs e)
        {
            ProjectAdvisor a = new ProjectAdvisor();
            // Get a reference to the parent control
            Control parentControl = this.Parent;

            // Create a new instance of the user control that you want to show
            ProjectAdvisor newControl = new ProjectAdvisor();

            // Set the position and size of the new control
            newControl.Location = this.Location;
            newControl.Size = this.Size;

            // Hide the current control by setting its Visible property to false
            this.Visible = false;

            // Show the new control by adding it to the parent control's Controls collection and setting its Visible property to true
            parentControl.Controls.Add(newControl);
            newControl.Visible = true;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
