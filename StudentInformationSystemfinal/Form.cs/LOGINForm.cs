using System;
//using System.Collections.ObjectModel;
using System.Windows.Forms;
//using DevExpress.Utils.About;
//using DevExpress.Utils.Win.Hook;
//using DevExpress.XtraEditors;
//using StudentInformationSystemfinal.StudentInformationSystemFormcs;
//using static DevExpress.XtraEditors.Mask.MaskSettings;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
//using DevExpress.Office.Crypto;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
//using System.Reflection;
using StudentInformationSystemfinal.Form.cs;
using DevExpress.XtraEditors;
using StudentInformationSystemfinal.Models;
using DevExpress.CodeParser;

namespace StudentInformationSystemfinal
{
    public partial class LOGINForm : DevExpress.XtraEditors.XtraForm
    {
        public LOGINForm()
        {
            InitializeComponent();
        }


        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                var builder = new System.Text.StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool ValidateCredentialsFromDatabase(string username, string hashedPassword)
        {
            string connectionString = "YourConnectionStringHere"; // Replace with your connection string
            string query = "SELECT COUNT(*) FROM StudentInformation WHERE Username = @username AND Password = @password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", "juan");
                        command.Parameters.AddWithValue("@password", "1234");

                        int count = (int)command.ExecuteScalar();
                        return count > 0; // Return true if a match is found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }




        private object GetStudents()
        {
            throw new NotImplementedException();
        }

        private void richEditControl1_Click(object sender, EventArgs e)
        {

        }

        private void StudentInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void tePassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGIN2_Click(object sender, EventArgs e)
        {


        }

        UserCredentials userCredentials = new UserCredentials();

        private void LOGIN_Click(object sender, EventArgs e)
        {

            string inputUsername = teUserName.Text;
            string inputPassword = tePassword.Text;
            string userTypeChoice = cbeUserTypes.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword) || string.IsNullOrEmpty(userTypeChoice)) {
                XtraMessageBox.Show("Please fill up all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userTypeChoice == "Nurse")
            {
                if (inputUsername == userCredentials.Username && inputPassword == userCredentials.Password)
                {
                    Nurse_Homepage nurseHomePage = new Nurse_Homepage();
                    nurseHomePage.Show();
                }
                else {
                    XtraMessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (userTypeChoice == "Administrator") {
                if (inputUsername == userCredentials.Username && inputPassword == userCredentials.Password)
                {
                    DMCMEDICAL_Homepage dMCMEDICAL_Homepage = new DMCMEDICAL_Homepage();
                    dMCMEDICAL_Homepage.Show();
                }
                else {
                    XtraMessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void CREATEANACCOUNT_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            // Display confirmation dialog before exiting
            DialogResult result = XtraMessageBox.Show("Are you sure you want to exit?","Exit Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

                this.Show(); // Cancel the form close event
            }
            else
            {
                Application.Exit(); // Close the application
            }

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void panelControl1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

