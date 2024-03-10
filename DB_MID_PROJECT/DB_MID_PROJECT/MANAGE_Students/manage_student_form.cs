using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_MID_PROJECT.MANAGE_Students
{
    public partial class manage_student_form : Form
    {
        public manage_student_form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN_FOLDER.features_form af = new MAIN_FOLDER.features_form();
            this.Hide();
            af.Show();
        }

        private void add_student_button_Click(object sender, EventArgs e)
        {
            add_student_form af = new add_student_form();
            this.Hide();
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show_student_person ssp = new show_student_person();    
            ssp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete_student_form df = new delete_student_form();
            this.Hide();
            df.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_student_form ef = new edit_student_form();
            ef.Show();
            this.Hide();
        }
    }
}
