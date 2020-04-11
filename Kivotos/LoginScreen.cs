using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Reflection;

namespace Kivotos
{
    public partial class LoginScreen : Form
    {
        MainScreen mainfrm;
        public LoginScreen()
        {
            InitializeComponent();
            mainfrm = new MainScreen();
            this.label3.Text = String.Format("Κιβωτός Version: {0}", AssemblyVersion);
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-6IBE4MF;Initial Catalog=KivotosDB2;Integrated Security=True";
            con.Open();
            string userid = textBox1.Text;
            string userpass = maskedTextBox1.Text;
            SqlCommand cmd = new SqlCommand("select * from Users where userid='" + textBox1.Text + "'and userpass='" + maskedTextBox1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = dt.Rows.Count;
            string usertype = dt.Rows[0][2].ToString();
            if (count > 0)
            {
                MessageBox.Show("Συνδεθήκατε επιτυχώς\nΕίσοδος στην εφαρμογή","Επιτυχία!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                mainfrm.Show();
                mainfrm.toolStripStatusLabel1.Text = textBox1.Text;
                mainfrm.toolStripStatusLabel2.Text = usertype;
                mainfrm.toolStripStatusLabel3.Text = DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Ελέγξτε και πάλι τα στοιχεία σύνδεσης!", "Σφάλμα Σύνδεσης!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
};
