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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DB_MID_PROJECT.Manage_Advisor
{
    public partial class manage_advisor_form : Form
    {
        public manage_advisor_form()
        {
            InitializeComponent();
        }

        private void add_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Advisor values (@Id, @Designation,@Salary)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Id",int.Parse(a_id_txtbx.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Correct Value :");
            }
            try
            {
                cmd.Parameters.AddWithValue("@Salary", float.Parse(ad_salary_txtbx.Text));
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            if(title_Box.Text != "")
            {
                string title = title_Box.Text;
                int Id = 0;
                SqlCommand check_command = new SqlCommand("SELECT Id FROM Lookup WHERE @Title = Value",con);
                check_command.Parameters.AddWithValue("@Title",title);
                var result = check_command.ExecuteScalar();

                if(result != null )
                {
                    Id = Convert.ToInt32(result);
                    cmd.Parameters.AddWithValue("@Designation", Id);
                }
                check_command.ExecuteNonQuery();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter Correct Value");
                }

            }
            else
            {
                MessageBox.Show("Please Enter designation: ");
            }
            showAdvisor();

        }
        private void showAdvisor()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Advisor", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void show_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Advisor", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand command = new SqlCommand("select * from Advisor", con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            int id = 0;
            float salary = 0f;
            int titleId = 0;
            for(int i = 0; i < table.Rows.Count; i++) 
            { 
                DataRow row = table.Rows[i];
                id = int.Parse(row["Id"].ToString());
                if(id == int.Parse(a_id_txtbx.Text))
                {
                    salary = float.Parse(row["Salary"].ToString());
                    titleId = int.Parse(row["Designation"].ToString());
                }
            }

            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Advisor set  Designation = @Designation,Salary=@Salary where Id=@Id", con1);
            cmd.Parameters.AddWithValue("@Id", a_id_txtbx.Text);
            if(ad_salary_txtbx.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Salary", ad_salary_txtbx.Text);
                }
                catch (Exception c)
                {
                    MessageBox.Show("Please Enter Correct Salary: ");
                }
            }
            else
            {
                cmd.Parameters.AddWithValue("@Salary", salary);
            }
            if (title_Box.Text != "")
            {
                string title = title_Box.Text;
                int Id = 0;
                SqlCommand check_command = new SqlCommand("SELECT Id FROM Lookup WHERE @Title = Value", con);
                check_command.Parameters.AddWithValue("@Title", title);
                var result = check_command.ExecuteScalar();

                if (result != null)
                {
                    Id = Convert.ToInt32(result);
                    cmd.Parameters.AddWithValue("@Designation", Id);
                }
            }
            else
            {
                cmd.Parameters.AddWithValue("@Designation", titleId);
            }
            try
            {

                cmd.ExecuteNonQuery();
            }
            catch (Exception c)
            {
                MessageBox.Show("Please Enter Correct Value");
            }
            showAdvisor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN_FOLDER.features_form ff = new MAIN_FOLDER.features_form();
            this.Hide();
            ff.Show();
        }

        private void manage_advisor_form_Load(object sender, EventArgs e)
        {

        }

        private void a_id_txtbx_Enter(object sender, EventArgs e)
        {
            if (a_id_txtbx.Text == "Enter Advisor Id For Updation Or Deletion")
            {
                a_id_txtbx.Text = "";
                a_id_txtbx.ForeColor = Color.Black;
            }
        }

        private void a_id_txtbx_Leave(object sender, EventArgs e)
        {
            if (a_id_txtbx.Text == "")
            {
                a_id_txtbx.Text = "Enter Advisor Id For Updation Or Deletion";
                a_id_txtbx.ForeColor = Color.Gray;
            }
        }

        private void ad_salary_txtbx_Enter(object sender, EventArgs e)
        {
            if (ad_salary_txtbx.Text == "Enter Advisor Salary")
            {
                ad_salary_txtbx.Text = "";
                ad_salary_txtbx.ForeColor = Color.Black;
            }
        }

        private void ad_salary_txtbx_Leave(object sender, EventArgs e)
        {
            if (ad_salary_txtbx.Text == "")
            {
                ad_salary_txtbx.Text = "Enter Advisor Salary";
                ad_salary_txtbx.ForeColor = Color.Gray;
            }
        }

        private void dlt_advisor_button_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (a_id_txtbx.Text != "")
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Advisor WHERE Id=@Id", con);
                try
                {
                    cmd.Parameters.AddWithValue("@Id", int.Parse(a_id_txtbx.Text));
                    check = true;
                }
                catch (Exception c)
                {
                    MessageBox.Show("Please Enter Correct Id: ");
                }
                if (check == true)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted SuccessFully");
                }
            }
            else
            {
                MessageBox.Show("Please Enter  Id");
            }
        }
    }
}
