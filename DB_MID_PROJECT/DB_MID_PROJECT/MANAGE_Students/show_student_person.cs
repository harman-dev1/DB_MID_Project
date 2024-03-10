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
    public partial class show_student_person : Form
    {
        public show_student_person()
        {
            InitializeComponent();
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
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Person JOIN Student ON Person.Id = Student.Id",con);
            SqlDataAdapter da = new SqlDataAdapter( cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            student_person_grid_view.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manage_student_form mf = new manage_student_form();
            mf.Show();
            this.Hide();
        }
    }
}
