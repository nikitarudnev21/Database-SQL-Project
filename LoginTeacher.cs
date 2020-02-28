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

namespace DatabaseRudnevProject
{
    public partial class LoginTeacher : Form
    {
        public static string getText;
        public static bool autoLog = false;
         SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
         AttachDbFilename=C:\Users\Nikita\source\repos\DatabaseRudnevProject\DB\opilane.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection sqlCon2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\opilane\source\repos\DatabaseRudnevProject\DB\opilane.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginTeacher()
        {
            InitializeComponent();
            labelPass.Visible = false;
            labelLog.Visible = false;
            dataGridView1.Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainMenu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string query = "Select Name, Surname from tbl_Opetaja Where Login ='" + textBoxLog.Text.Trim() +
                "' and Password = '" + textBoxPass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                dataGridView1.DataSource = dtbl;
                dataGridView1.Visible = true;
                getText = dataGridView1.CurrentRow.Cells[0].Value.ToString() + " " +
                    dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.Hide();
                var form2 = new TeacherDiarycs();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                LoginTeacher.autoLog = true;
            }
            else
            {
                LoginTeacher.autoLog = false;
                labelPass.Text = "wrong login or password";
                labelPass.Visible = true;
                labelPass.ForeColor = Color.Firebrick;
            }
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            textBoxPass.ForeColor = SystemColors.InfoText;
            labelPass.Visible = false;
            if (textBoxPass.TextLength == 0)
            {
                labelPass.Visible = false;
            }
        }

        private void TextBoxLog_TextChanged(object sender, EventArgs e)
        {
            textBoxLog.ForeColor = SystemColors.InfoText;
            labelPass.Visible = false;
            if (textBoxLog.TextLength == 0)
            {
                labelPass.Visible = false;
            }

        }

        private void LoginTeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnReg_Click(sender, e);
            }
        }

        private void LoginTeacher_Load(object sender, EventArgs e)
        {
            MainMenu.checkAnimation = true;
            if (LoginTeacher.autoLog)
            {
                this.Hide();
                var form2 = new TeacherDiarycs();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        async void LoginTeacher_Load_1(object sender, EventArgs e)
        {
            for (Opacity = 0; Opacity < 1; Opacity += 0.01)
            {
                await Task.Delay(10);
            }
        }
    }
}
