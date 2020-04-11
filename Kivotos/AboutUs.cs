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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
            this.label2.Text = String.Format("Version: {0}", AssemblyVersion);
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void updtcheck_btn_Click(object sender, EventArgs e)
        {
            UpdateCheckInfo info = null;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("Υπάρχει διαθέσιμη ενημέρωση. Θέλετε να την εφαρμόσετε τώρα?", "Κιβωτός - Διαθέσιμη Ενημέρωση", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("Η εφαρμογή εντόπισε μια σημαντική ενημέρωση από " +
                            "την έκδοση 1.0 στην έκδοση ... " + info.MinimumRequiredVersion.ToString() +
                            "Η εφαρμογή θα εκτελέσει την ενημέρωση και θα επανεκκινήσει.",
                            "Κιβωτός - Διαθέσιμη Ενημέρωση", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("Η εφαρμογή ενημερώθηκε επιτυχώς και θα επανεκκινήσει!");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Αποτυχία εγκατάστασης της νεότερης εκδοσης. \n\nΠαρακαλόύμε ελέγξτε την σύνδεσή σας, ή προπαθήστε αργότερα. Error: " + dde, "Κιβωτός - Σφάλμα ενημέρωσης!", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
