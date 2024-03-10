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

namespace DB_MID_PROJECT.Group
{
    public partial class group_project_form : Form
    {
        public group_project_form()
        {
            InitializeComponent();
            
            addGroupIdInBox();
            addProjectIdInBox();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show_group_button_Click(object sender, EventArgs e)
        {
            
            
        }

        
        private void addGroupIdInBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Group]", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                group_id__comboBox.Items.Add(row["Id"].ToString());
            }

        }

        private void addProjectIdInBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Project]", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                Project_id_comboBox.Items.Add(row["Id"].ToString());
            }

        }

        private void projectIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_GROUP_project_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into GroupProject values (@ProjectId,@GroupId,@AssignmentDate)", con);

            try
            {
                cmd.Parameters.AddWithValue("@ProjectId",int.Parse(Project_id_comboBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmd.Parameters.AddWithValue("@GroupId", int.Parse(group_id__comboBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.Parameters.AddWithValue("@AssignmentDate", dateTimePicker1.Value);
            try
            {
                MessageBox.Show("Data Added Successfully!!!");
                cmd.ExecuteNonQuery();
            }

            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void show_group_project()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Group]", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridforgroupproject.DataSource = dt;

        }
        private void button8_Click(object sender, EventArgs e)
        {
            
            
            

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [GroupProject]", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridforgroupproject.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manage_group_form mgf = new manage_group_form ();
            this.Hide();
            mgf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool check = false;

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM GroupProject WHERE ProjectId=@ProjectId and GroupId=@GroupId", con);
            if (group_id__comboBox.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@GroupId", int.Parse(group_id__comboBox.Text));
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Group Id");
            }
            if (Project_id_comboBox.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@projectId", int.Parse(Project_id_comboBox.Text));
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Project Id");
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
    }
}
