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
    public partial class NewExprt : Form
    {
        public NewExprt()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6IBE4MF;Initial Catalog=KivotosDB2;Integrated Security=True");

        private void NewExprt_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select StrgCode AS Κωδ_Εγγραφής, ImpCode AS Κωδ_Εισαγωγής, Description AS Περιγραφή, ProdCode AS Κωδ_Προϊόντος, Prod AS Περιγ_Προϊόντος,  Mtrl1Code AS Κωδικός_Υλικού1, Mtrl1 AS Υλικό1, Mtrl1Amnt AS Ποσότητα, Mtrl2Code AS Κωδικός_Υλικού2, Mtrl2 AS Υλικό2, Mtrl2Amnt AS Ποσότητα, Weight AS Μικτό_Kg, Datetime AS Ημερομηνία, Details AS Λεπτομέρειες From Storage", con);
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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Delete From Storage Where StrgCode = '" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Update(dt);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Τα στοιχεία διεγράφησαν επιτυχώς!!!", "Επιτυχία!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();

            sda = new SqlDataAdapter("Select StrgCode AS Κωδ_Εγγραφής, ImpCode AS Κωδ_Εισαγωγής, Description AS Περιγραφή, ProdCode AS Κωδ_Προϊόντος, Prod AS Περιγ_Προϊόντος, Mtrl1Code AS Κωδικός_Υλικού1, Mtrl1 AS Υλικό1, Mtrl1Amnt AS Ποσότητα, Mtrl2Code AS Κωδικός_Υλικού2, Mtrl2 AS Υλικό2, Mtrl2Amnt AS Ποσότητα, Weight AS Μικτό_Kg, Datetime AS Ημερομηνία, Details AS Λεπτομέρειες From Storage", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (textBox2.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand("Select ImpDesc From Import Where ImpCode= '" + textBox2.Text + "'", con);
                cmd1.Parameters.AddWithValue("ImpCode", int.Parse(textBox2.Text));
                SqlDataReader dar = cmd1.ExecuteReader();
                while (dar.Read())
                {
                    textBox3.Text = dar.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (textBox4.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand("Select ProdDesc From Products Where ProdCode= '" + textBox4.Text + "'", con);
                cmd1.Parameters.AddWithValue("ProdCode", int.Parse(textBox4.Text));
                SqlDataReader dar = cmd1.ExecuteReader();
                while (dar.Read())
                {
                    textBox5.Text = dar.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (textBox6.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand("Select ItDesc From Items Where IteCode= '" + textBox6.Text + "'", con);
                cmd1.Parameters.AddWithValue("IteCode", int.Parse(textBox6.Text));
                SqlDataReader dar = cmd1.ExecuteReader();
                while (dar.Read())
                {
                    textBox7.Text = dar.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (textBox9.Text != "")
            {
                SqlCommand cmd1 = new SqlCommand("Select ItDesc From Items Where IteCode= '" + textBox9.Text + "'", con);
                cmd1.Parameters.AddWithValue("IteCode", int.Parse(textBox9.Text));
                SqlDataReader dar = cmd1.ExecuteReader();
                while (dar.Read())
                {
                    textBox10.Text = dar.GetValue(0).ToString();
                }
                con.Close();
            }
        }
    }
}
