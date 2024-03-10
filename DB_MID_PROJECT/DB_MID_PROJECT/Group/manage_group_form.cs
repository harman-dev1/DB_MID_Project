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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DB_MID_PROJECT.Group
{
    public partial class manage_group_form : Form
    {
        public manage_group_form()
        {
            InitializeComponent();
        }

        private void add_group_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Group] (Created_On) VALUES (@Created_On)", con);
            DateTime created_on = this.group_assignment_date.Value;
            cmd.Parameters.AddWithValue("@Created_On", created_on.ToString("yyyy/dd/MM"));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Group saved successfully :");
            all_groups();
        }

        private void all_groups()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Group]", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN_FOLDER.features_form ff = new MAIN_FOLDER.features_form();
            ff.Show();
            this.Hide();
        }

        private void show_group_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Group]", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_group_button_Click(object sender, EventArgs e)
        {
            bool check = false;
            if(group_id_text_box.Text != "")
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update [Group] set  Created_On = @Created_On where Id=@Id", con);
                try
                {
                    cmd.Parameters.AddWithValue("@Id", int.Parse(group_id_text_box.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Correct Id : ");
                }
                DateTime createdon = this.group_assignment_date.Value;
                cmd.Parameters.AddWithValue("@Created_On", this.group_assignment_date.Value);
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                    check = false;
                }
                if (check == true)
                {
                    MessageBox.Show("Data Updated Successfully : ");
                    all_groups();
                }
            }
            else
            {
                MessageBox.Show("Enter Group Id For Updation");
            }
        }

        private void manage_group_form_Load(object sender, EventArgs e)
        {

        }

        private void group_id_text_box_Enter(object sender, EventArgs e)
        {
            if (group_id_text_box.Text == "Enter Id for Deletion Or Updation")
            {
                group_id_text_box.Text = "";
                group_id_text_box.ForeColor = Color.Black;
            }
        }

        private void group_id_text_box_Leave(object sender, EventArgs e)
        {
            if (group_id_text_box.Text == "")
            {
                group_id_text_box.Text = "Enter Id for Deletion Or Updation";
                group_id_text_box.ForeColor = Color.Gray;
            }
        }

        private void group_projects_button_Click(object sender, EventArgs e)
        {
            group_project_form gf = new group_project_form();
            this.Hide();
            gf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            group_student_form gsf = new group_student_form();
            this.Hide();    
            gsf.Show();
        }

        private void dlt_group_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM [Group] WHERE Id=@Id", con);
            if (group_id_text_box.Text != "")
            {
                try
                {

                    cmd.Parameters.AddWithValue("@Id", int.Parse(group_id_text_box.Text));
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
            else
            {
                MessageBox.Show("Plzz enter Some Group Id :");
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfuly");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
    }
}
