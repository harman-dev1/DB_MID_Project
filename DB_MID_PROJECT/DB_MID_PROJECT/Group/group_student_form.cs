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
    public partial class group_student_form : Form
    {
        public group_student_form()
        {
            InitializeComponent();
            addStudentIdInBox();
            addGroupIdInBox();
            add_status();
        }

        private void dataGridforgroupproject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_GROUP_project_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand countcmd = new SqlCommand("SELECT COUNT(*) as count FROM GroupStudent GROUP BY GroupStudent.GroupId", con);
            var result = countcmd.ExecuteScalar();
            if(result!= null || result == null)
            {
                int count = Convert.ToInt32(result);
                if(count < 4 || result == null)
                {
                    SqlCommand cmd = new SqlCommand("Insert into GroupStudent values (@GroupId, @StudentId,@Status,@AssignmentDate) ", con);
                    if (group_id__comboBox.Text != "")
                    {
                        try
                        {

                            cmd.Parameters.AddWithValue("@GroupId", int.Parse(group_id__comboBox.Text));

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (student_id_combo_box.Text != "")
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@StudentId", int.Parse(student_id_combo_box.Text));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    if (Status_ofStudent.Text != "")
                    {
                        int Id = 0;
                        SqlCommand command3 = new SqlCommand("select * from Lookup", con);
                        SqlDataAdapter data3 = new SqlDataAdapter(command3);
                        DataTable table3 = new DataTable();
                        data3.Fill(table3);
                        for (int i = 0; i < table3.Rows.Count; i++)
                        {
                            DataRow row = table3.Rows[i];
                            string cate = row["Value"].ToString();
                            cate = cate.Trim();
                            if (cate == Status_ofStudent.Text)
                            {
                                Id = int.Parse(row["Id"].ToString());
                            }
                        }
                        try
                        {

                            cmd.Parameters.AddWithValue("@Status", Id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    DateTime createdon = this.dateTimePicker1.Value;
                    cmd.Parameters.AddWithValue("@AssignmentDate", createdon.ToString("yyyy/dd/MM"));
                    bool ch = false;
                    try
                    {
                        ch = true;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        ch = false;
                        MessageBox.Show(ex.Message);
                    }
                    if (ch == true)
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Limit Exceeded!!!!");
                }
                MessageBox.Show("Data Save SuccessFully : ");
            }
            
        }
        private void addStudentIdInBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                student_id_combo_box.Items.Add(row["Id"].ToString());
            }

        }

        private void add_status()
        {
            Status_ofStudent.Items.Add("Active");
            Status_ofStudent.Items.Add("InActive");
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

        private void button8_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select GroupStudent.GroupId, Student.Id,GroupStudent.Status,GroupStudent.AssignmentDate from [GroupStudent] join Student on GroupStudent.StudentId = Student.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridforgroupproject.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manage_group_form mgf = new manage_group_form();
            this.Hide();
            mgf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manage_group_form mgf = new manage_group_form();
            this.Hide(); mgf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM GroupStudent WHERE GroupId=@GroupId  and StudentId=@StudentId", con);
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
                MessageBox.Show("Please Enter Grupe Id");
            }
            if (student_id_combo_box.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@StudentId", int.Parse(student_id_combo_box.Text));
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct Student Id");
            }
            bool check = false;
            try
            {
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
            if (check == true)
            {
                MessageBox.Show("Data deleted Successfully");
            }
        }
    }
}
