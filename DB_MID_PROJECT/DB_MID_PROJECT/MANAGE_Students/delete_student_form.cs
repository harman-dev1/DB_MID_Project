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

namespace DB_MID_PROJECT.MANAGE_Students
{
    public partial class delete_student_form : Form
    {
        public delete_student_form()
        {
            InitializeComponent();
        }
        private void registeration_textBox_Leave(object sender, EventArgs e)
        {
            if (registeration_textBox.Text == "")
            {
                registeration_textBox.Text = "Enter Reg No For Deletion";
                registeration_textBox.ForeColor = Color.Gray;
            }
        }


        private void registeration_textBox_Enter(object sender, EventArgs e)
        {
            if (registeration_textBox.Text == "Enter Reg No For Deletion")
            {
                registeration_textBox.Text = "";
                registeration_textBox.ForeColor = Color.Black;
            }
        }

        private void last_name_textBox_Leave(object sender, EventArgs e)
        {
            if (registeration_textBox.Text == "")
            {
                registeration_textBox.Text = "Enter Last Name";
                registeration_textBox.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE RegistrationNo=@RegistrationNo", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", registeration_textBox.Text);
            cmd.ExecuteNonQuery();
        }

        private void student_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            student_person_grid_view.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Person JOIN Student ON Person.Id = Student.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            student_person_grid_view.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manage_student_form mf = new manage_student_form();
            mf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int id = 0;
            if (!string.IsNullOrWhiteSpace(registeration_textBox.Text))
            {
                string regNo = registeration_textBox.Text.Trim();
                SqlCommand command1 = new SqlCommand("SELECT Id FROM Student WHERE RegistrationNo = @RegistrationNo", con);
                command1.Parameters.AddWithValue("@RegistrationNo", regNo);
                var result = command1.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                    SqlCommand command2 = new SqlCommand("delete from Student WHERE RegistrationNo = @RegistrationNo", con);
                    command2.Parameters.AddWithValue("@RegistrationNo", regNo);
                    command2.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Person WHERE Id = @Id", con);
                    cmd1.Parameters.AddWithValue("@Id", id);
                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("DELETE FROM GroupStudent WHERE StudentId = @StudentId", con);
                    cmd2.Parameters.AddWithValue("@StudentId", id);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully!!!");

                }
                else
                {
                    MessageBox.Show("No student found with the specified registration number.");
                }
            }
            else
            {
                MessageBox.Show("Plzz Enter Valid Registeration Number");
            }
        }

        private void delete_student_form_Load(object sender, EventArgs e)
        {

        }
    }
}
