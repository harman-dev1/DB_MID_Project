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

namespace DB_MID_PROJECT.Project
{
    public partial class Project_manage : Form
    {
        public Project_manage()
        {
            InitializeComponent();
        }

        private void add_project_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Project values(@Description, @Title)",con);
            try
            {
                cmd.Parameters.AddWithValue("@Title", Project_title_box.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Plzz Enter Title");
            }
            try
            {
                if(description_text_box.Text != "")
                {
                    cmd.Parameters.AddWithValue("@Description", description_text_box.Text);
                }
                else
                {
                    MessageBox.Show("Plzz Enter Some Description");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("please Enter Correct Value");
            }

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully!!!");
                show_projects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void show_projects()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void show_project_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_project_button_Click(object sender, EventArgs e)
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
                if (id == int.Parse(project_id_text_box.Text))
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
            if (Project_title_box.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Title", Project_title_box.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Correct Title: ");
                }
            }
            if (Project_title_box.Text == "")
            {
                cmd.Parameters.AddWithValue("@Title", ttile);
            }
            if (description_text_box.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Description", description_text_box.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Correct Description: ");
                }
            }
            if (description_text_box.Text == "")
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

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN_FOLDER.features_form ff = new MAIN_FOLDER.features_form();
            ff.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proect_advisor_form pf = new proect_advisor_form();
            pf.Show();
            this.Hide();
        }

        private void Project_manage_Load(object sender, EventArgs e)
        {

        }

        

        private void description_text_box_Leave(object sender, EventArgs e)
        {
            if (description_text_box.Text == "")
            {
                description_text_box.Text = "Enter Project Description";
                description_text_box.ForeColor = Color.Blue;
            }
        }


        private void description_text_box_Enter(object sender, EventArgs e)
        {
            if (description_text_box.Text == "Enter Project Description")
            {
                description_text_box.Text = "";
                description_text_box.ForeColor = Color.Black;
            }
        }

        private void Project_title_box_Enter(object sender, EventArgs e)
        {
            if (Project_title_box.Text == "Enter Project Title")
            {
                Project_title_box.Text = "";
                Project_title_box.ForeColor = Color.Black;
            }
        }


        private void Project_title_bx_Leave(object sender, EventArgs e)
        {
            if (Project_title_box.Text == "")
            {
                Project_title_box.Text = "Enter Project Title";
                Project_title_box.ForeColor = Color.Blue;
            }
        }

        private void project_id_text_boxEnter(object sender, EventArgs e)
        {
            if (project_id_text_box.Text == "Enter Project Id for Updation Or Deletion")
            {
                project_id_text_box.Text = "";
                project_id_text_box.ForeColor = Color.Black;
            }
        }


        private void project_id_text_boxLeave(object sender, EventArgs e)
        {
            if (project_id_text_box.Text == "")
            {
                project_id_text_box.Text = "Enter Project Id for Updation Or Deletion";
                project_id_text_box.ForeColor = Color.Blue;
            }
        }

        private void dlt_project_button_Click(object sender, EventArgs e)
        {
            bool check = false;

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Project WHERE Id=@Id", con);
            if (project_id_text_box.Text != "")
                cmd.Parameters.AddWithValue("@Id", project_id_text_box.Text);
            else
            {
                MessageBox.Show("Please Enter Id");
            }
            try
            {
                check = true;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex )
            {
                check = false;
                MessageBox.Show(ex.Message) ;
            }
            if (check == true)
                MessageBox.Show("Data Deleted SuccessFully");

        }
    }
}
