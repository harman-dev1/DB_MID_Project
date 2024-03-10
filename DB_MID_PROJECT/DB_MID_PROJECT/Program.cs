using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_MID_PROJECT
{
    static class Program
    {
        public static int CurrentStudentId;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN_FOLDER.features_form());

           /* using (var connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT MAX(Id) FROM Student", connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        Program.CurrentStudentId = (int)result;
                    }
                }
            }*/
        }
    }
}
