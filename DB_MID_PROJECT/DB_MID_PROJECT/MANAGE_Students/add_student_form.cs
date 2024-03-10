using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_MID_PROJECT.MANAGE_Students
{
    public partial class add_student_form : Form
    {
        public add_student_form()
        {
            InitializeComponent();
            //first_name_textBox.Enter += first_name_textBox_Enter;
            //first_name_textBox.Leave += first_name_textBox_Leave;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            manage_student_form mf = new manage_student_form();
            mf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checker = false,checker2 = false;
            var con = Configuration.getInstance().getConnection();
            if(registeration_textBox.Text == "" || first_name_textBox.Text == "" || last_name_textBox.Text == "" || contact_textBox.Text == "" || email_textBox.Text == "" || gender_txt_box.Text == "")
            {
                MessageBox.Show("Please enter some value in all textBox: ");
            }
            else if(registeration_textBox.Text != "")
            {
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNo = @RegistrationNo", con);
                checkCommand.Parameters.AddWithValue("@RegistrationNo", registeration_textBox.Text);
                int existingRecords = (int)checkCommand.ExecuteScalar();
                if(existingRecords > 0 )
                {
                    MessageBox.Show("A user with the same registeration exsists");
                    registeration_textBox.Text = "";
                }
                else
                {
                    SqlCommand command1 = new SqlCommand("select * from Person", con);
                    SqlDataAdapter data1 = new SqlDataAdapter(command1);
                    DataTable table = new DataTable();
                    data1.Fill(table);
                    SqlCommand cmd = new SqlCommand("Insert into Person values (@FirstName, @LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
                    if (first_name_textBox.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@FirstName", first_name_textBox.Text);
                    }
                    if (last_name_textBox.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@LastName", last_name_textBox.Text);
                    }
                    if (contact_textBox.Text != "")
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@Contact", contact_textBox.Text);
                            
                        }
                        catch (Exception c)
                        {
                            MessageBox.Show("Please Enter Correct Contact Number");
                            
                        }
                    }
                    if (email_textBox.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@Email", email_textBox.Text);
                        try
                        {
                            string email = email_textBox.Text;
                            checker = true;
                            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            {
                                checker = false;
                                throw new ArgumentException("Invalid email address");
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            checker = false;
                            MessageBox.Show(ex.Message, "Invalid email address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            checker = false;
                            MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (gender_txt_box.Text != "")
                    {
                        try
                        {
                            if (int.Parse(gender_txt_box.Text) == 1 || int.Parse(gender_txt_box.Text) == 2)
                            {
                                checker2 = true;
                                cmd.Parameters.AddWithValue("@Gender", int.Parse(gender_txt_box.Text));
                            }
                        }
                        catch (Exception ex)
                        {
                            checker2 = false;
                            MessageBox.Show("Please Enter Correct value of gender 1 or 2");
                        }

                    }
                    DateTime date_of_birth = this.d_of_birth.Value;
                    cmd.Parameters.AddWithValue("@DateOfBirth", date_of_birth.ToString("yyyy-MM-dd"));
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    SqlCommand command = new SqlCommand("select * from Person", con);
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    DataTable table1 = new DataTable();
                    data.Fill(table1);
                    int studentId = 0;
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        DataRow row = table1.Rows[i];
                        studentId = int.Parse(row["Id"].ToString());
                    }
                    SqlCommand cmd1 = new SqlCommand("Insert into Student values (@Id,@RegistrationNo)", con);
                    try
                    {
                        cmd1.Parameters.AddWithValue("@Id", studentId);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Enter Correct Value");
                    }
                    try
                    {
                        cmd1.Parameters.AddWithValue("@RegistrationNo", registeration_textBox.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please Enter Correct Value");
                    }
                    if (studentId >= 0 && checker != false && checker2 != false)
                    {
                        MessageBox.Show("Data Saved Successfully!!!");
                        first_name_textBox.Text = "";
                        last_name_textBox.Text = "";
                        contact_textBox.Text = "";
                        gender_txt_box.Text = "";
                        email_textBox.Text = "";
                    }
                    try
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }               

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void first_name_textBox_Enter(object sender, EventArgs e)
        {
            if(first_name_textBox.Text == "Enter First Name")
            {
                first_name_textBox.Text = "";
                first_name_textBox.ForeColor = Color.Black; 
            }
        }

        private void first_name_textBox_Leave(object sender, EventArgs e)
        {
            if (first_name_textBox.Text == "")
            {
                first_name_textBox.Text = "Enter First Name";
                first_name_textBox.ForeColor = Color.Gray;
            }
        }


        private void last_name_textBox_Enter(object sender, EventArgs e)
        {
            if (last_name_textBox.Text == "Enter Last Name")
            {
                last_name_textBox.Text = "";
                last_name_textBox.ForeColor = Color.Black;
            }
        }

        private void last_name_textBox_Leave(object sender, EventArgs e)
        {
            if (last_name_textBox.Text == "")
            {
                last_name_textBox.Text = "Enter Last Name";
                last_name_textBox.ForeColor = Color.Gray;
            }
        }


        private void email_textBox_Enter(object sender, EventArgs e)
        {
            if (email_textBox.Text == "Enter Email")
            {
                email_textBox.Text = "";
                email_textBox.ForeColor = Color.Black;
            }
        }

        private void email_textBox_Leave(object sender, EventArgs e)
        {
            if (email_textBox.Text == "")
            {
                email_textBox.Text = "Enter Email Name";
                email_textBox.ForeColor = Color.Gray;
            }
        }

        private void contact_textBox_Enter(object sender, EventArgs e)
        {
            if (contact_textBox.Text == "Enter Phone No")
            {
                contact_textBox.Text = "";
                contact_textBox.ForeColor = Color.Black;
            }
        }

        private void contact_textBox_textBox_Leave(object sender, EventArgs e)
        {
            if (contact_textBox.Text == "")
            {
                contact_textBox.Text = "Enter Phone No";
                contact_textBox.ForeColor = Color.Gray;
            }
        }


        private void gender_txt_box_Enter(object sender, EventArgs e)
        {
            if (gender_txt_box.Text == "Enter 1 for Male and 2 for Female")
            {
                gender_txt_box.Text = "";
                gender_txt_box.ForeColor = Color.Black;
            }
        }

        private void gender_txt_box_Leave(object sender, EventArgs e)
        {
            if (gender_txt_box.Text == "")
            {
                gender_txt_box.Text = "Enter 1 for Male and 2 for Female";
                gender_txt_box.ForeColor = Color.Gray;
            }
        }


        private void registeration_textBox_Enter(object sender, EventArgs e)
        {
            if (registeration_textBox.Text == "Enter Reg NO")
            {
                registeration_textBox.Text = "";
                registeration_textBox.ForeColor = Color.Black;
            }
        }

        private void registeration_textBox_Leave(object sender, EventArgs e)
        {
            if (registeration_textBox.Text == "")
            {
                registeration_textBox.Text = "Enter Reg NO";
                registeration_textBox.ForeColor = Color.Gray;
            }
        }

        private void add_student_form_Load(object sender, EventArgs e)
        {

        }
    }
}
