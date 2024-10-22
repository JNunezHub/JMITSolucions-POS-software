using JMITSolucions_POS_software.General;
using JMITSolucions_POS_software.Screens;
using MetroSet_UI.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;


namespace JMITSolucions_POS_software
{
    public partial class LoginForm : MetroSetForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LoginBotton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSetting.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Login_VerifyLoginDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            this.Hide();
                            DashboardForm df = new DashboardForm();
                            df.Show();
                        }
                        else
                        {
                            MessageBox.Show("User Name or Password is incorrect", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }

            }

        }
        private bool IsValid()
        {
            if (UserNameTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("User name is required!", "Form validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PasswordTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Password is required", "Form validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}