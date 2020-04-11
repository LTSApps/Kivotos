using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Reflection;

namespace Kivotos
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.label2.Text = String.Format("Κιβωτός Version: {0}", AssemblyVersion);
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //The timer is now going to start
            timeLeft = 58;
            timer1.Start();
        }

        public int timeLeft { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                progressBar1.Increment(2);
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer1.Stop();
                new LoginScreen().Show();
                this.Hide();
            }
        }
    }
}

