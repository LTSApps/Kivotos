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

namespace Kivotos
{
    public partial class ProcMtrl : Form
    {
        public ProcMtrl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6IBE4MF;Initial Catalog=KivotosDB2;Integrated Security=True");
        private void ProcMtrl_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select IteCode AS Κωδικός_Υλικού, ItDesc AS Περιγραφή_Υλικού From Items", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Insert Into Items(IteCode,ItDesc) Values('" + textBox1.Text +"','" + textBox2.Text +"')", con);
            DataTable dt = new DataTable();
            sda.Update(dt);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Τα στοιχεία καταχωρήθηκαν επιτυχώς!!!", "Επιτυχία!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();

            sda = new SqlDataAdapter("Select IteCode AS Κωδικός_Υλικού, ItDesc AS Περιγραφή From Items ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Delete From Items Where IteCode='" + textBox1.Text + "'", selectConnection: con);
            DataTable dt = new DataTable();
            sda.Update(dt);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Τα στοιχεία αφαιρέθηκαν επιτυχώς!!!", "Επιτυχία!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();

            sda = new SqlDataAdapter("Select IteCode AS Κωδικός_Υλικού, ItDesc AS Περιγραφή From Items ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (textBox1.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand("Select ItDesc From Items Where IteCode= '" + textBox1.Text + "'", con);
                cmd1.Parameters.AddWithValue("IteCode", int.Parse(textBox1.Text));
                SqlDataReader dar = cmd1.ExecuteReader();
                while (dar.Read())
                {
                    textBox2.Text = dar.GetValue(0).ToString();
                }
                con.Close();
            }
        }
    }
}
