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

namespace DB_MID_PROJECT.Evaluation
{
    public partial class manage_evaluation_form : Form
    {
        public manage_evaluation_form()
        {
            InitializeComponent();
            evaluation_id_box.Items.Clear();
            addIdInBox();
        }

        
        private void add_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Evaluation values ( @Name,@TotalMarks,@TotalWeightage)", con);

            try
            {
                cmd.Parameters.AddWithValue("@Name", evaluation_name_txtbx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(evaluation_marks_txtbx.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.Parameters.AddWithValue("@TotalWeightage", int.Parse(weightage_text_box.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bool check = false;
            try
            {
                check = true;
                cmd.ExecuteNonQuery();
            }
            catch (Exception c)
            {
                check = false;
                MessageBox.Show(c.Message);
            }
            if (check == true)
            {
                MessageBox.Show("Data Saved Successfully ");
                
            }
        }

        private void show_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select * from Evaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void display_all()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select * from Evaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand command = new SqlCommand("select * from Evaluation", con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            int marks = 0;
            int weight = 0;
            bool check = false;
            string name = "";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                try
                {
                    if (int.Parse(row["Id"].ToString()) == int.Parse(evaluation_id_box.Text))
                    {
                        marks = int.Parse(row["TotalMarks"].ToString());
                        weight = int.Parse(row["TotalWeightage"].ToString());
                        name = row["Name"].ToString();
                        break;
                    }
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                    break;
                }
            }
            SqlCommand cmd = new SqlCommand("Update Evaluation set  Name = @Name,TotalMarks=@TotalMarks,TotalWeightage=@TotalWeightage where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(evaluation_id_box.Text.Trim())
);
            if (evaluation_marks_txtbx.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(evaluation_marks_txtbx.Text));
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
            if (evaluation_marks_txtbx.Text == "")
            {
                cmd.Parameters.AddWithValue("@TotalMarks", marks);
            }
            if (weightage_text_box.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@TotalWeightage", int.Parse(weightage_text_box.Text));
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
            if (weightage_text_box.Text == "")
            {
                cmd.Parameters.AddWithValue("@TotalWeightage", weight);
            }
            if (evaluation_name_txtbx.Text != "")
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Name", evaluation_name_txtbx.Text);
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
            if (evaluation_name_txtbx.Text == "")
            {
                cmd.Parameters.AddWithValue("@Name", name);
            }

            try
            {
                cmd.ExecuteNonQuery();
                check = true;
                MessageBox.Show("Data Updated Successfully!!!");
                display_all();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
                check = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN_FOLDER.features_form ff = new MAIN_FOLDER.features_form    ();
            ff.Show();
            this.Hide();
        }

        private void addIdInBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Evaluation", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                evaluation_id_box.Items.Add(row["Id"].ToString());
            }

        }

        private void grooup_evauation_Click(object sender, EventArgs e)
        {
            group_evaluation_form gef = new group_evaluation_form   (); 
            gef.Show();
            this.Hide();
        }

        private void manage_evaluation_form_Load(object sender, EventArgs e)
        {

        }
        private void evaluation_name_txtbx_Enter(object sender, EventArgs e)
        {
            if (evaluation_name_txtbx.Text == "Enter Evaluation Name")
            {
                evaluation_name_txtbx.Text = "";
                evaluation_name_txtbx.ForeColor = Color.Black;
            }
        }

        private void evaluation_name_txtbx_Leave(object sender, EventArgs e)
        {
            if (evaluation_name_txtbx.Text == "")
            {
                evaluation_name_txtbx.Text = "Enter Evaluation Name";
                evaluation_name_txtbx.ForeColor = Color.Gray;
            }
        }

        private void evaluation_marks_txtbx_Enter(object sender, EventArgs e)
        {
            if (evaluation_marks_txtbx.Text == "Enter Evaluation Marks")
            {
                evaluation_marks_txtbx.Text = "";
                evaluation_marks_txtbx.ForeColor = Color.Black;
            }
        }

        private void evaluation_marks_txtbx_Leave(object sender, EventArgs e)
        {
            if (evaluation_marks_txtbx.Text == "")
            {
                evaluation_marks_txtbx.Text = "Enter Evaluation Marks";
                evaluation_marks_txtbx.ForeColor = Color.Gray;
            }
        }

        private void weightage_text_box_Enter(object sender, EventArgs e)
        {
            if (weightage_text_box.Text == "Enter Total Weightage")
            {
                weightage_text_box.Text = "";
                weightage_text_box.ForeColor = Color.Black;
            }
        }

        private void weightage_text_box_Leave(object sender, EventArgs e)
        {
            if (weightage_text_box.Text == "")
            {
                weightage_text_box.Text = "Enter Total Weightage";
                weightage_text_box.ForeColor = Color.Gray;
            }
        }

        private void dlt_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Evaluation WHERE Id=@Id", con);
            try
            {
                cmd.Parameters.AddWithValue("@Id", int.Parse(evaluation_id_box.Text));
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully :");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
    }
}
