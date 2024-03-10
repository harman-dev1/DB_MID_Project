using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace DB_MID_PROJECT.MAIN_FOLDER
{
    public partial class features_form : Form
    {
        public object FontConstants { get; private set; }

        public features_form()
        {

            InitializeComponent();
            
        }
        private void studentbutton_MouseHover_1(object sender, EventArgs e)
        {
            studentbutton.Text = "Manage Student";
            studentbutton.ForeColor = Color.Black;
            studentbutton.BackColor = Color.White;
        }

        private void studentbutton_MouseLeave_1(object sender, EventArgs e)
        {
            studentbutton.Text = "Student";
            studentbutton.BackColor = Color.Black ;
            studentbutton.ForeColor = Color.White;
        }

        private void advisorbutton_MouseHover_1(object sender, EventArgs e)
        {
            advisorbutton.ForeColor = Color.Black;
            advisorbutton.BackColor = Color.White;
            advisorbutton.Text = "Manage Advisor";
        }

        private void advisorbutton_MouseLeave_1(object sender, EventArgs e)
        {
            advisorbutton.ForeColor = Color.White;
            advisorbutton.BackColor = Color.Black;
            advisorbutton.Text = "Advisor";
        }

        private void groupbutton_MouseHover_1(object sender, EventArgs e)
        {
            groupbutton.ForeColor = Color.Black;
            groupbutton.BackColor = Color.White;
            groupbutton.Text = "Manage Group";
        }

        private void groupbutton_MouseLeave_1(object sender, EventArgs e)
        {
            groupbutton.ForeColor = Color.White;
            groupbutton.BackColor = Color.Black;
            groupbutton.Text = "Group";
        }

        private void projectbutton_MouseHover_1(object sender, EventArgs e)
        {
            projectbutton.ForeColor = Color.Black;
            projectbutton.BackColor = Color.White;
            projectbutton.Text = "Manage Project";
        }

        private void projectbutton_MouseLeave_1(object sender, EventArgs e)
        {
            projectbutton.ForeColor = Color.White;
            projectbutton.BackColor = Color.Black;
            projectbutton.Text = "Project";
        }

        private void evaluationbutton_MouseHover(object sender, EventArgs e)
        {
            evaluationbutton.ForeColor = Color.Black;
            evaluationbutton.BackColor = Color.White;
            evaluationbutton.Text = "Manage Evaluation";
        }

        private void evaluationbutton_MouseLeave(object sender, EventArgs e)
        {
            evaluationbutton.ForeColor = Color.White;
            evaluationbutton.BackColor = Color.Black;
            evaluationbutton.Text = "Evaluation";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Student_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void features_form_Load(object sender, EventArgs e)
        {

        }

        private void studentbutton_Click(object sender, EventArgs e)
        {
            MANAGE_Students.manage_student_form mf = new MANAGE_Students.manage_student_form();
            this.Hide();
            mf.Show();
        }

        private void advisorbutton_Click(object sender, EventArgs e)
        {
            Manage_Advisor.manage_advisor_form mf = new Manage_Advisor.manage_advisor_form();
            this.Hide();
            mf.Show();
        }

        private void projectbutton_Click(object sender, EventArgs e)
        {
            Project.Project_manage pm = new Project.Project_manage();   
            this.Hide();    
            pm.Show();  
        }

        private void groupbutton_Click(object sender, EventArgs e)
        {
            Group.manage_group_form mgf = new Group.manage_group_form();
            mgf.Show();
            this.Hide();
        }

        private void evaluationbutton_Click(object sender, EventArgs e)
        {
            Evaluation.manage_evaluation_form mef = new Evaluation.manage_evaluation_form();    
            mef.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

            if (comboBox1.Text == "List of projects along with advisory board and list of students")
            {
                SqlCommand cmd = new SqlCommand("SELECT distinct P.Title , P.Description , P.[Main Advisor] , P.[Co-Advisor] ,\r\nP.[Industry Advisor] , Student.RegistrationNo [Registration No.]\r\nFROM GroupProject\r\nJOIN (SELECT Project.Id, Title, Description, (SELECT\r\nProjectAdvisor.AdvisorId FROM ProjectAdvisor WHERE\r\nProjectAdvisor.ProjectId = Project.Id AND\r\nProjectAdvisor.AdvisorRole\r\n= 11)[Main Advisor], (SELECT ProjectAdvisor.AdvisorId FROM\r\nProjectAdvisor WHERE ProjectAdvisor.ProjectId = Project.Id AND\r\nProjectAdvisor.AdvisorRole = 12)[Co-Advisor], (SELECT\r\nProjectAdvisor.AdvisorId FROM ProjectAdvisor WHERE\r\nProjectAdvisor.ProjectId = Project.Id AND\r\nProjectAdvisor.AdvisorRole = 14) [Industry Advisor] FROM Project)\r\nAS P\r\nON P.Id = GroupProject.ProjectId\r\nJOIN GroupStudent\r\nON GroupStudent.GroupId = GroupProject.GroupId\r\nJoin Student\r\nON Student.Id = GroupStudent.StudentId;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            else if (comboBox1.Text == "Select advisors and the projects they are supervising")
            {
                SqlCommand cmd = new SqlCommand("SELECT Project.Id [Project ID] , Project.Title , Advisor.Id\r\n[Advisor ID] , (SELECT Value From Lookup WHERE ID = Designation)\r\nAS Designation , (SELECT Value From Lookup WHERE ID = AdvisorRole)\r\nAS Role FROM Project JOIN ProjectAdvisor ON Project.Id =\r\nProjectAdvisor.ProjectId JOIN Advisor ON ProjectAdvisor.AdvisorId\r\n= Advisor.Id Order BY Advisor.Id\r\n", con);
                //SqlCommand cmd = new SqlCommand("SELECT distinct [Registration No.] , p.[Project ID],p.[Project Title],\r\np.GroupId,Evaluation.Name , GroupEvaluation.ObtainedMarks FROM\r\nEvaluation JOIN GroupEvaluation ON Evaluation.Id =\r\nGroupEvaluation.EvaluationId JOIN(SELECT(SELECT RegistrationNo\r\nFrom Student WHere Student.Id = GroupStudent.StudentId) AS\r\n[Registration No.], GroupStudent.GroupId, (SELECT Project.Id\r\nFROM Project WHERE Exists(SELECT GroupProject.ProjectId FROM\r\nGroupProject WHERE GroupProject.GroupId = GroupStudent.GroupId\r\nAND Project.Id = GroupProject.ProjectId)) AS[Project ID],\r\n(SELECT Project.Title FROM Project WHERE Exists(SELECT\r\nGroupProject.ProjectId FROM GroupProject WHERE\r\nGroupProject.GroupId = GroupStudent.GroupId AND Project.Id =\r\nGroupProject.ProjectId)) AS[Project Title] FROM GroupStudent)\r\nAS P ON GroupEvaluation.GroupId = P.GroupId Order BY\r\nP.GroupId\r\n", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Select groups and their projects with the assigned dates")
            {
                SqlCommand cmd = new SqlCommand("SELECT [Group].Id [Group ID],Created_On [Group Created On],\r\nCASE WHEN AssignmentDate IS NULL THEN 'No Project Assigned'\r\nELSE CAST(AssignmentDate AS varchar) END AS[Project\r\nAssignment], (SELECT COUNT(*) FROM GroupStudent WHERE\r\nGroupStudent.GroupId = GroupProject.GroupId) AS[No.of\r\nStudents] FROM[Group] Left join GroupProject ON\r\nGroupProject.GroupId = [Group].Id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string firstItem = comboBox1.Text;

            if (firstItem == "List of projects along with advisory board and list of students")
            {
                SqlCommand cmd = new SqlCommand("SELECT distinct P.Title , P.Description , P.[Main Advisor] , P.[Co-Advisor] ,\r\nP.[Industry Advisor] , Student.RegistrationNo [Registration No.]\r\nFROM GroupProject\r\nJOIN (SELECT Project.Id, Title, Description, (SELECT\r\nProjectAdvisor.AdvisorId FROM ProjectAdvisor WHERE\r\nProjectAdvisor.ProjectId = Project.Id AND\r\nProjectAdvisor.AdvisorRole\r\n= 11)[Main Advisor], (SELECT ProjectAdvisor.AdvisorId FROM\r\nProjectAdvisor WHERE ProjectAdvisor.ProjectId = Project.Id AND\r\nProjectAdvisor.AdvisorRole = 12)[Co-Advisor], (SELECT\r\nProjectAdvisor.AdvisorId FROM ProjectAdvisor WHERE\r\nProjectAdvisor.ProjectId = Project.Id AND\r\nProjectAdvisor.AdvisorRole = 14) [Industry Advisor] FROM Project)\r\nAS P\r\nON P.Id = GroupProject.ProjectId\r\nJOIN GroupStudent\r\nON GroupStudent.GroupId = GroupProject.GroupId\r\nJoin Student\r\nON Student.Id = GroupStudent.StudentId;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);

                // Set the output file path
                string outputPath = "output.pdf";

                // Create a FileStream object to write the PDF to the output file
                FileStream file = new FileStream(outputPath, FileMode.Create);

                // Create a PDF writer that writes to the FileStream
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, file);

                // Open the document
                pdfDoc.Open();

                // Create a table to hold the query result
                PdfPTable table = new PdfPTable(dt.Columns.Count);

                // Add the table header
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dt.Columns[i].ColumnName));
                }

                // Add the table data
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        table.AddCell(new Phrase(dt.Rows[i][j].ToString()));
                    }
                }

                // Add the table to the document
                pdfDoc.Add(table);

                // Close the document
                pdfDoc.Close();

                // Close the FileStream
                file.Close();
            }

            else if (comboBox1.Text == "Select groups and their projects with the assigned dates")
            {
                SqlCommand cmd = new SqlCommand("SELECT [Group].Id [Group ID],Created_On [Group Created On],\r\nCASE WHEN AssignmentDate IS NULL THEN 'No Project Assigned'\r\nELSE CAST(AssignmentDate AS varchar) END AS[Project\r\nAssignment], (SELECT COUNT(*) FROM GroupStudent WHERE\r\nGroupStudent.GroupId = GroupProject.GroupId) AS[No.of\r\nStudents] FROM[Group] Left join GroupProject ON\r\nGroupProject.GroupId = [Group].Id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);

                // Set the output file path
                string outputPath = "output3.pdf";

                // Create a FileStream object to write the PDF to the output file
                FileStream file = new FileStream(outputPath, FileMode.Create);

                // Create a PDF writer that writes to the FileStream
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, file);

                // Open the document
                pdfDoc.Open();

                // Create a table to hold the query result
                PdfPTable table = new PdfPTable(dt.Columns.Count);

                // Add the table header
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dt.Columns[i].ColumnName));
                }

                // Add the table data
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        table.AddCell(new Phrase(dt.Rows[i][j].ToString()));
                    }
                }

                // Add the table to the document
                pdfDoc.Add(table);

                // Close the document
                pdfDoc.Close();

                // Close the FileStream
                file.Close();
            }
            else if (comboBox1.Text == "Select advisors and the projects they are supervising")
            {
                SqlCommand cmd = new SqlCommand("SELECT Project.Id [Project ID] , Project.Title , Advisor.Id\r\n[Advisor ID] , (SELECT Value From Lookup WHERE ID = Designation)\r\nAS Designation , (SELECT Value From Lookup WHERE ID = AdvisorRole)\r\nAS Role FROM Project JOIN ProjectAdvisor ON Project.Id =\r\nProjectAdvisor.ProjectId JOIN Advisor ON ProjectAdvisor.AdvisorId\r\n= Advisor.Id Order BY Advisor.Id\r\n", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);

                // Set the output file path
                string outputPath = "output2.pdf";

                // Create a FileStream object to write the PDF to the output file
                FileStream file = new FileStream(outputPath, FileMode.Create);

                // Create a PDF writer that writes to the FileStream
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, file);

                // Open the document
                pdfDoc.Open();

                // Create a table to hold the query result
                PdfPTable table = new PdfPTable(dt.Columns.Count);

                // Add the table header
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dt.Columns[i].ColumnName));
                }

                // Add the table data
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        table.AddCell(new Phrase(dt.Rows[i][j].ToString()));
                    }
                }

                // Add the table to the document
                pdfDoc.Add(table);

                // Close the document
                pdfDoc.Close();

                // Close the FileStream
                file.Close();
            }
        }


    }
}
