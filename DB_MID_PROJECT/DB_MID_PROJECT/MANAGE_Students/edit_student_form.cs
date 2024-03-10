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
    public partial class edit_student_form : Form
    {
        public edit_student_form()
        {
            InitializeComponent();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if(registeration_textBox.Text == "")
            {
                MessageBox.Show("Plzz Enter Registeration Number");
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                int id = 0;
                string regNo = registeration_textBox.Text.Trim();
                SqlCommand command1 = new SqlCommand("SELECT Id FROM Student WHERE RegistrationNo = @RegistrationNo", con);
                command1.Parameters.AddWithValue("@RegistrationNo", regNo);
                var result = command1.ExecuteScalar();
                if(result != null)
                {
                    id = Convert.ToInt32(result);
                    SqlCommand first_name_command = new SqlCommand("SELECT FirstName from Person WHERE Id = @Id", con);
                    first_name_command.Parameters.AddWithValue("@Id", id);
                    string firstName = (string)first_name_command.ExecuteScalar();
                    if(first_name_textBox.Text != "")
                    {
                        firstName = first_name_textBox.Text;
                    }

                    SqlCommand last_name_command = new SqlCommand("SELECT LastName from Person WHERE Id = @Id", con);
                    last_name_command.Parameters.AddWithValue("@Id", id);
                    string lastName = (string)last_name_command.ExecuteScalar();
                    if(last_name_textBox.Text != "")
                    {
                        lastName = last_name_textBox.Text;
                    }

                    SqlCommand email_command = new SqlCommand("SELECT Email FROM Person Where Id = @Id",con);
                    email_command.Parameters.AddWithValue("@Id", id);
                    string email = (string)email_command.ExecuteScalar();
                    if(email_textBox.Text != "")
                    {
                        email = email_textBox.Text;
                    }
                    /*SqlCommand phone_number_command = new SqlCommand("SELECT Contact FROM Person WHERE Id = @Id", con);
                    phone_number_command.Parameters.AddWithValue("@Id", id);
                    object result1 = phone_number_command.ExecuteScalar();
                    Int32 phone_no;
                    if (result1 != null)
                    {
                        if (!string.IsNullOrEmpty(contact_textBox.Text))
                        {
                            
                            if (Int32.TryParse(contact_textBox.Text, out phone_no))
                            {
                                phone_no = (contact_textBox.Text);
                                // Update the phone_no variable with the new value
                            }
                            else
                            {
                                // Handle the case where the text box contains non-numeric characters
                            }
                        }
                    }*/

                    SqlCommand gender_command = new SqlCommand("SELECT Gender From Person Where Id = @Id", con);
                    gender_command.Parameters.AddWithValue("@Id", id);
                    int gender = (int)gender_command.ExecuteScalar();
                    if (!string.IsNullOrEmpty(gender_txt_box.Text))
                    {
                        gender = Convert.ToInt16(gender_txt_box.Text);
                    }

                    SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName, LastName = @LastName , Email = @Email, Gender = @Gender WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName); // Update with the new first name
                    cmd.Parameters.AddWithValue("@LastName", lastName); // Update with the new last name
                   // cmd.Parameters.AddWithValue("@Contact", phone_no);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Id", id); // Specify the ID of the student to update
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Updated Successfully!!!");
                    registeration_textBox.Text = "";
                    first_name_textBox.Text = "";
                    last_name_textBox.Text = "";
                    email_textBox.Text = "";
                    contact_textBox.Text = "";
                    gender_txt_box.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Enter Correct Registeration Number");
                    registeration_textBox.Text = "";
                }
            }
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

        private void student_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            student_person_grid_view.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manage_student_form mf = new manage_student_form();
            this.Hide();
            mf.Show();
        }

        private void edit_student_form_Load(object sender, EventArgs e)
        {

        }
        private void first_name_textBox_Enter(object sender, EventArgs e)
        {
            if (first_name_textBox.Text == "Enter Updated First Name")
            {
                first_name_textBox.Text = "";
                first_name_textBox.ForeColor = Color.Black;
            }
        }

        private void first_name_textBox_Leave(object sender, EventArgs e)
        {
            if (first_name_textBox.Text == "")
            {
                first_name_textBox.Text = "Enter Updated First Name";
                first_name_textBox.ForeColor = Color.Gray;
            }
        }

        private void last_name_textBox_Enter(object sender, EventArgs e)
        {
            if (last_name_textBox.Text == "Enter Updated Last Name")
            {
                last_name_textBox.Text = "";
                last_name_textBox.ForeColor = Color.Black;
            }
        }

        private void last_name_textBox_Leave(object sender, EventArgs e)
        {
            if (last_name_textBox.Text == "")
            {
                last_name_textBox.Text = "Enter Updated Last Name";
                last_name_textBox.ForeColor = Color.Gray;
            }
        }

        private void registeration_textBox_Enter(object sender, EventArgs e)
        {
            if (registeration_textBox.Text == "Enter Reg No whom you wanna edit")
            {
                registeration_textBox.Text = "";
                registeration_textBox.ForeColor = Color.Black;
            }
        }

        private void registeration_textBox_Leave(object sender, EventArgs e)
        {
            if (registeration_textBox.Text == "")
            {
                registeration_textBox.Text = "Enter Reg No whom you wanna edit";
                registeration_textBox.ForeColor = Color.Gray;
            }
        }

        private void email_textBox_Enter(object sender, EventArgs e)
        {
            if (email_textBox.Text == "Enter Updated Email")
            {
                email_textBox.Text = "";
                email_textBox.ForeColor = Color.Black;
            }
        }

        private void email_textBox_Leave(object sender, EventArgs e)
        {
            if (email_textBox.Text == "")
            {
                email_textBox.Text = "Enter Updated Email";
                email_textBox.ForeColor = Color.Gray;
            }
        }

        private void contact_textBox_Enter(object sender, EventArgs e)
        {
            if (contact_textBox.Text == "Enter Updated Contact No")
            {
                contact_textBox.Text = "";
                contact_textBox.ForeColor = Color.Black;
            }
        }

        private void contact_textBox_Leave(object sender, EventArgs e)
        {
            if (contact_textBox.Text == "")
            {
                contact_textBox.Text = "Enter Updated Contact No";
                contact_textBox.ForeColor = Color.Gray;
            }
        }

        private void gender_txt_box_Enter(object sender, EventArgs e)
        {
            if (gender_txt_box.Text == "Enter Updated Gender")
            {
                gender_txt_box.Text = "";
                gender_txt_box.ForeColor = Color.Black;
            }
        }

        private void gender_txt_box_Leave(object sender, EventArgs e)
        {
            if (gender_txt_box.Text == "")
            {
                gender_txt_box.Text = "Enter Updated Gender";
                gender_txt_box.ForeColor = Color.Gray;
            }
        }
    }
}
