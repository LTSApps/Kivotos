using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kivotos
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void NewImp_btn_Click(object sender, EventArgs e)
        {
            new NewImprt().Show();
        }

        private void NewExp_btn_Click(object sender, EventArgs e)
        {
            new NewExprt().Show();
        }

        private void Strg_btn_Click(object sender, EventArgs e)
        {
            new Storage().Show();
        }

        private void PrcImp_btn_Click(object sender, EventArgs e)
        {
            new ProcImp().Show();
        }

        private void PrcExp_btn_Click(object sender, EventArgs e)
        {
            new ProcExp().Show();
        }

        private void PrcPro_btn_Click(object sender, EventArgs e)
        {
            new ProcProd().Show();
        }

        private void PrcMtrl_btn_Click(object sender, EventArgs e)
        {
            new ProcMtrl().Show();
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            new AboutUs().Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginScreen().Show();
        }
    }
}
