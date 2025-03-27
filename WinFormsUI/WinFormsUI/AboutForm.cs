using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class AboutForm : Form
    {
        private const uint majorVersion = 1;
        private const uint minorVersion = 0;
        private readonly string groupName = "ДТ-360а";

        public AboutForm()
        {
            InitializeComponent();
            
            // General Information
            lblAppName.Text = "Data workstation";
            lblVersion.Text = $"Version: {majorVersion}.{minorVersion}";
            lblAuthor.Text = $"Developer: student of the {groupName} group";
            lblDescription.Text = "An application for managing a list of workshops," + Environment.NewLine +
                                    "employees, and products.";

            lblDiscipline.Text = "Course: C# Programming";
            lblTeacher.Text = "Lecturer: Ilya Dubkov";

            // Features and Functionality
            featuresListBox.Items.Add("Workshop management (add/edit/delete)");
            featuresListBox.Items.Add("In-memory data collection storage");
            featuresListBox.Items.Add("Form-based data entry with change persistence");
            featuresListBox.Items.Add("Menu and toolbar functionality");
            featuresListBox.Items.Add("Comprehensive error handling");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projectLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/marabella070/CSharpLabs-Rethink-",
                UseShellExecute = true
            });
        }
    }
}
