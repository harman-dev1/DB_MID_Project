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

namespace DB_MID_PROJECT.Evaluation
{
    public partial class group_evaluation_form : Form
    {
        public group_evaluation_form()
        {
            InitializeComponent();
            group_id_box.Items.Clear();
            evaluat_id_combo_box.Items.Clear();
            addevaluationIdInBox();
            addGroupIdInBox();
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
                group_id_box.Items.Add(row["Id"].ToString());
            }

        }
        private void addevaluationIdInBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Evaluation]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                evaluat_id_combo_box.Items.Add(row["Id"].ToString());
            }
        }
        private void add_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into GroupEvaluation values (@GroupId,@EvaluationId,@ObtainedMarks, @EvaluationDate)", con);
            if (group_id_box.Text != "")
            {
                try
                {

                    cmd.Parameters.AddWithValue("@GroupId", int.Parse(group_id_box.Text));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (evaluat_id_combo_box.Text != "")
            {
                try
                {

                    cmd.Parameters.AddWithValue("@EvaluationId", int.Parse(evaluat_id_combo_box.Text));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (evaluation_marks_txtbx.Text != "")
            {
                try
                {

                    cmd.Parameters.AddWithValue("@ObtainedMarks", int.Parse(evaluation_marks_txtbx.Text));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            DateTime createdon = this.dateTimePicker1.Value;
            cmd.Parameters.AddWithValue("@EvaluationDate", createdon.ToString("yyyy/dd/MM"));
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
                MessageBox.Show("Data Save SuccessFully : ");
            }
        }

        private void show_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select * from GroupEvaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void show_all_data()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select * from GroupEvaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dlt_advisor_button_Click(object sender, EventArgs e)
        {

        }

        private void update_advisor_button_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select * from GroupEvaluation where GroupId=@GroupId", con);
            try
            {
                cmd.Parameters.AddWithValue("@GroupId", int.Parse(group_id_box.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Correct Id");
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manage_evaluation_form mef = new manage_evaluation_form();
            mef.Show();
            this.Hide();
        }

        private void group_evaluation_form_Load(object sender, EventArgs e)
        {

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
    }
}
