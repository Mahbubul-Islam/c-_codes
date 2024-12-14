using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidebar.Width = 43; // Set to collapsed width
            sidebarExpand = false; // Sidebar is collapsed by default
            usertoolsContainer.Height = 55;
            sidebarExpand = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        bool usertoolsExpand = false;
        private void usertoolsTransition_Tick(object sender, EventArgs e)
        {
            if (usertoolsExpand == false) 
            {
                usertoolsContainer.Height += 10;
                if (usertoolsContainer.Height >= 276) 
                {
                    usertoolsTransition.Stop();
                    usertoolsExpand = true;
                }
            }
            else
            {
                usertoolsContainer.Height -= 10;
                if(usertoolsContainer.Height <= 55)
                {
                    usertoolsTransition.Stop();
                    usertoolsExpand = false;
                }
            }
        }

        
        
        private void usertoolsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            usertoolsTransition.Start();
        }

        private void usertoolsLabel_Click(object sender, EventArgs e)
        {
            usertoolsTransition.Start();
        }

        private void usertoolsIcon_Click(object sender, EventArgs e)
        {
            usertoolsTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                sidebar.Width -= 5;
                if(sidebar.Width <= 43) 
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    homePannel.Width = sidebar.Width;
                    usertoolsPanel.Width = sidebar.Width;
                    profilePannel.Width = sidebar.Width;
                    aboutusPannel.Width = sidebar.Width;
                    settingsPanel.Width = sidebar.Width;
                    usertoolsContainer.Width = sidebar.Width;
                    settingsContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 250) 
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    homePannel.Width = sidebar.Width;
                    usertoolsPanel.Width = sidebar.Width;
                    profilePannel.Width = sidebar.Width;
                    aboutusPannel.Width = sidebar.Width;
                    settingsPanel.Width = sidebar.Width;
                    usertoolsContainer.Width = sidebar.Width;
                    settingsContainer.Width = sidebar.Width;
                }

            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usertoolsDropdown_Click(object sender, EventArgs e)
        {
            usertoolsTransition.Start();
        }

        bool settingsExpand = false;
        private void settingsTransition_Tick(object sender, EventArgs e)
        {
            if (settingsExpand == false)
            {
                settingsContainer.Height += 10;
                if (settingsContainer.Height >= 167)
                {
                    settingsTransition.Stop();
                    settingsExpand = true;
                }
            }
            else
            {
                settingsContainer.Height -= 10;
                if (settingsContainer.Height <= 55)
                {
                    settingsTransition.Stop();
                    settingsExpand = false;
                }
            }
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            settingsTransition.Start();
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {
            settingsTransition.Start();
        }

        private void settingsPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void settingsDropdown_Click(object sender, EventArgs e)
        {
            settingsTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usertoolsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
