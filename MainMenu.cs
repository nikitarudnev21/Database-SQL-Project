using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseRudnevProject
{
    public partial class MainMenu : Form
    {
        public static bool checkAnimation;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async void BtnRegisterTeacher_Click(object sender, EventArgs e)
        {
          await Task.Delay(10);
          this.Hide();
          var form2 = new RegistrTeacher();
           form2.Closed += (s, args) => this.Close();
          form2.Show();
        }

         void BtnRegisterStudent_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new RegistrStudent();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void BtnLoginTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LoginTeacher();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(LoginTeacher.autoLog)
            {
                this.Hide();
                var form2 = new TeacherDiarycs();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("You are not logged in", "Error");
            }
        }

        async void MainMenu_Load(object sender, EventArgs e)
        {
            

            if (MainMenu.checkAnimation)
            {
                Namee.Text = "Welcome to NDiary";
                foreach (Button btn in panel1.Controls)
                {
                    btn.Enabled = true;
                }
                for (Opacity = 0; Opacity < 1; Opacity += 0.01)
                {
                    await Task.Delay(10);
                }
            }
            if (!MainMenu.checkAnimation)
            {
            for (Opacity = 0; Opacity < 1; Opacity += 0.01)
             {
               await Task.Delay(10);
             }
            char[] lbltext = "Welcome to NDiary".ToCharArray();
            foreach(char ch in lbltext)
            {
                Namee.Text += ch.ToString();
                await Task.Delay(70);
            }

                foreach (Button btn in panel1.Controls)
                {
                    btn.Enabled = true;
                }
            }
        }

        private void BtnLoginStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
