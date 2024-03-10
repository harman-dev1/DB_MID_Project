using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DB_MID_PROJECT.Project
{
    public partial class proect_advisor_form : Form
    {
        public proect_advisor_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Advisor", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void add_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int projectId;
            int advisorId;
            if (project_Id_txtbx.Text != "" && advisor_role_text_box.Text != "" && advisor_id_Box.Text != "")
            {
                if (project_Id_txtbx.Text != "")
                {
                    SqlCommand project_id = new SqlCommand("SELECT Id FROM Project WHERE Id = @Id", con);
                    project_id.Parameters.AddWithValue("@Id", project_Id_txtbx.Text);
                    var result = project_id.ExecuteScalar();
                    if (result != null)
                    {
                        projectId = Convert.ToInt32(result);
                        MessageBox.Show("Entered Correct" );
                    }
                    else
                    {
                        MessageBox.Show("Plzz Enter Correct Project Id");
                    }
                }
                if(advisor_id_Box.Text != "")
                {
                    SqlCommand advisor_id_command = new SqlCommand("SELECT Id From Advisor WHERE Id = @Id",con);
                    advisor_id_command.Parameters.AddWithValue("@Id", advisor_id_Box.Text);
                    var result_advisor = advisor_id_command.ExecuteScalar();
                    if (result_advisor != null)
                    {                        
                        advisorId = Convert.ToInt32(result_advisor);
                    }
                    else
                    {
                        MessageBox.Show("Plzz Enter Correct Advisor Id");
                    }

                }



                SqlCommand cmd = new SqlCommand("Insert into ProjectAdvisor values (@AdvisorId,@ProjectId, @AdvisorRole,@AssignmentDate)", con);
                try
                {
                    cmd.Parameters.AddWithValue("@AdvisorId", advisor_id_Box.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Plzz Enter Title");
                }
                try
                {
                    if (project_Id_txtbx.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", project_Id_txtbx.Text);
                    }
                    else
                    {
                        MessageBox.Show("Plzz Enter Some Project Id");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("please Enter Correct Value");
                }

                try
                {
                    cmd.Parameters.AddWithValue("@AssignmentDate", advisor_date.Value.ToString("yyyy-MM-dd"));


                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message);
                }

                try
                {
                    string title = advisor_role_text_box.Text;
                    int Id = 0;
                    SqlCommand check_command = new SqlCommand("SELECT Id FROM Lookup WHERE @Title = Value", con);
                    check_command.Parameters.AddWithValue("@Title", title);
                    var result = check_command.ExecuteScalar();

                    if (result != null)
                    {
                        Id = Convert.ToInt32(result);
                        cmd.Parameters.AddWithValue("@AdvisorRole", Id);
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct Advisor role");
                    }
                    check_command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successfully!!!");
                    show_projects_advisor();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            
            else
            {
                MessageBox.Show("Plzz Enter Fill All Fields");
            }
        }
        private void show_projects_advisor()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from ProjectAdvisor", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void show_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from ProjectAdvisor", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_advisor_button_Click(object sender, EventArgs e)
        {
            int advisorId = 0;
            int projectId = 0;
            var con = Configuration.getInstance().getConnection();
            if (!string.IsNullOrEmpty(project_Id_txtbx.Text) && !string.IsNullOrEmpty(advisor_id_Box.Text))
            {
                SqlCommand command = new SqlCommand("SELECT AdvisorId, ProjectId FROM ProjectAdvisor WHERE AdvisorId = @AdvisorId AND ProjectId = @ProjectId", con);
                command.Parameters.AddWithValue("@AdvisorId", advisor_id_Box.Text);
                command.Parameters.AddWithValue("@ProjectId", project_Id_txtbx.Text);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        advisorId = reader.GetInt32(0);
                        projectId = reader.GetInt32(1);
                    }
                    else
                    {
                        MessageBox.Show("AdvisorId and ProjectId not found in the database.");
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Project Id and Advisor Id for updation.");
                return;
            }

            string advisor_role = advisor_role_text_box.Text;

            try
            {
                int roleId = GetRoleId(con, advisor_role);
                if (roleId != -1)
                {
                    SqlCommand update_command = new SqlCommand("UPDATE ProjectAdvisor SET AdvisorRole = @AdvisorRole WHERE AdvisorId = @AdvisorId AND ProjectId = @ProjectId", con);
                    update_command.Parameters.AddWithValue("@AdvisorRole", roleId);
                    update_command.Parameters.AddWithValue("@AdvisorId", advisorId);
                    update_command.Parameters.AddWithValue("@ProjectId", projectId);
                    update_command.ExecuteNonQuery();
                    MessageBox.Show("Update successful!");
                }
                else
                {
                    MessageBox.Show("Enter Correct Advisor role");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            show_projects_advisor();
        }

        private int GetRoleId(SqlConnection con, string roleTitle)
        {
            SqlCommand check_command = new SqlCommand("SELECT Id FROM Lookup WHERE Value = @Title", con);
            check_command.Parameters.AddWithValue("@Title", roleTitle);
            var result = check_command.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            return -1;
        }

        private void proect_advisor_form_Load(object sender, EventArgs e)
        {

        }

        private void project_id_text_boxEnter(object sender, EventArgs e)
        {
            if (project_Id_txtbx.Text == "Enter Project Id")
            {
                project_Id_txtbx.Text = "";
                project_Id_txtbx.ForeColor = Color.Black;
            }
        }


        private void project_id_text_boxLeave(object sender, EventArgs e)
        {
            if (project_Id_txtbx.Text == "")
            {
                project_Id_txtbx.Text = "Enter Project Id";
                project_Id_txtbx.ForeColor = Color.Blue;
            }
        }

        private void advisor_id_BoxEnter(object sender, EventArgs e)
        {
            if (advisor_id_Box.Text == "Enter Advisor Id")
            {
                advisor_id_Box.Text = "";
                advisor_id_Box.ForeColor = Color.Black;
            }
        }


        private void advisor_id_BoxLeave(object sender, EventArgs e)
        {
            if (advisor_id_Box.Text == "")
            {
                advisor_id_Box.Text = "Enter Advisor Id";
                advisor_id_Box.ForeColor = Color.Blue;
            }
        }

        private void dlt_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM ProjectAdvisor WHERE ProjectId=@ProjectId", con);
            if (project_Id_txtbx.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@ProjectId", int.Parse(project_Id_txtbx.Text));

                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Id");
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully ");
            }
            catch (Exception)
            {
                MessageBox.Show("Please Wrtite Correct Value");
            }
            MessageBox.Show("Data Deleted Successfully ");
        }
    }
}
