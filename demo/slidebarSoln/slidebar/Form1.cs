using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slidebar
{
    public partial class main_Form : Form
    {
        bool slidebarExpand=true;
        bool usertoolsColaps = false;
        bool settingsColaps = true;
        public main_Form()
        {
            InitializeComponent();
            //slidebar.Width = slidebar.MinimumSize.Width;
            //slidebarExpand = false; // Ensure the state matches the collapsed size
            //usertoolsContainer.Height = usertoolsContainer.MinimumSize.Height;
            //usertoolsColaps = true; // Set the state to collapsed

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            if (slidebarExpand == true)
            {
                slidebar.Width -= 10;
                if (slidebar.Width <= 62)
                {
                    slidebarExpand = false;
                    slidebarTimer.Stop();

                }
            }
            else
            {
                slidebar.Width += 10;
                if (slidebar.Width >= 255)
                {
                    slidebarExpand = true;
                    slidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start(); 
        }
        private void menu_container_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void menu_Button_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }


        private void main_Form_Load(object sender, EventArgs e)
        {

        }

        private void usertoolsTimer_Click(object sender, EventArgs e)
        {
            if (usertoolsColaps == false) 
            {
                usertoolsContainer.Height += 10;
                if(usertoolsContainer.Height >= 316)
                {
                    usertoolsTimer.Stop();
                    usertoolsColaps = true;
                }
            }
            else
            {
                usertoolsContainer.Height -= 10;
                if(usertoolsContainer.Height <= 64)
                {
                    usertoolsTimer.Stop();
                    usertoolsColaps = false;                
                }
            }
        }

        private void usertools_Click(object sender, MouseEventArgs e)
        {
            usertoolsTimer.Start();
        }

        private void user_tools_button_Click(object sender, EventArgs e)
        {
            usertoolsTimer.Start();
        }

        private void user_tools_icon_Click(object sender, EventArgs e)
        {
            usertoolsTimer.Start();
        }

        
        private void settigsTimer_Click(object sender, EventArgs e)
        {
            if (settingsColaps == false)
            {
                settingsContainer.Height += 10;
                if (settingsContainer.Height >= 188)
                {
                    settingsTimer.Stop();
                    settingsColaps = true;
                }
            }
            else
            {
                settingsContainer.Height -= 10;
                if (settingsContainer.Height <= 64)
                {
                    settingsTimer.Stop();
                    settingsColaps = false;
                }
            }
        }

        private void settings_panel_Click(object sender, MouseEventArgs e)
        {
            settingsTimer.Start();
        }

        private void menu_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
