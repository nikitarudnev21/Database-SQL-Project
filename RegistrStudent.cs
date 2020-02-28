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
    public partial class RegistrStudent : Form
    {
           SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
           AttachDbFilename=C:\Users\Nikita\source\repos\DatabaseRudnevProject\DB\opilane.mdf;Integrated Security=True;Connect Timeout=30");
        /*SqlConnection sqlCon2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\opilane\source\repos\DatabaseRudnevProject\DB\opilane.mdf;Integrated Security=True;Connect Timeout=30");*/
        int checkcount = 0;

        public RegistrStudent()
        {
            InitializeComponent();
            labelLog.Visible = false;
            labelPass.Visible = false;

        }

        private void CheckTeacher_CheckedChanged(object sender, EventArgs e)
        {
        }

        void BtnDelete_Click(object sender, EventArgs e)
        {
                this.Hide();
                 var form2 = new MainMenu();
                 form2.Closed += (s, args) => this.Close();
                 form2.Show();
                 
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            comboClassnum.Text = "";
            comboEducation.Text = "";
            comboGender.Text = "";
            textDescription.Text = "";
            textAddress.Text = "";
            textSurname.Text = "";
            textName.Text = "";
            textNumber.Text = "";
            textMail.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            string surnamee = textSurname.Text;
            string namee = textName.Text;
            string mail = textMail.Text;
            string num = textNumber.Text;
            bool isIntSurname = surnamee.All(char.IsDigit);
            bool isIntName = namee.All(char.IsDigit);
            bool isLetterNumber = num.All(char.IsLetter);

         
                if (comboEducation.Text != "" && comboGender.Text != "" && isIntSurname == false && !surnamee.Contains(" ")
                    && isLetterNumber == false && !num.Contains(" ") && numericAge.Value != 0 &&
                    textBoxPass.TextLength > 4 && textBoxLog.TextLength > 4 && mail.Contains("@"))
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    SqlCommand sqlCmd = new SqlCommand("AddTeacher", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@opetajaId", 0);
                    sqlCmd.Parameters.AddWithValue("@Name", textName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Surname", textSurname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MobileNumber", textNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", textNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Mail", textMail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Age", numericAge.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Education", comboEducation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Description", textDescription.Text.Trim());

                    if (comboGender.SelectedIndex == 0)
                    {
                        sqlCmd.Parameters.AddWithValue("@Gender", "Male");
                    }
                    if (comboGender.SelectedIndex == 1)
                    {
                        sqlCmd.Parameters.AddWithValue("@Gender", "Female");
                    }
                    if (comboGender.SelectedIndex == 2)
                    {
                        sqlCmd.Parameters.AddWithValue("@Gender", "Other");
                    }
                    sqlCmd.Parameters.AddWithValue("@ClassroomTeacher", 0);
                    sqlCmd.Parameters.AddWithValue("@Login", textBoxLog.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textBoxPass.Text.Trim());
                    sqlCmd.ExecuteNonQuery(); // вывод
                    MessageBox.Show("Saved successfull");
                    checkcount = 1;
                    this.Hide();
                    var form2 = new LoginTeacher();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                    LoginTeacher.autoLog = true;
                }
            
            if (checkcount == 0)
            {
                if (textBoxPass.TextLength < 4 && textBoxPass.TextLength != 0)
                {
                    textBoxPass.ForeColor = Color.Firebrick;
                    MessageBox.Show("password must contain at least 4 characters");
                }
                if (textBoxLog.TextLength < 4 && textBoxLog.TextLength != 0)
                {
                    textBoxLog.ForeColor = Color.Firebrick;
                    MessageBox.Show("login must contain at least 4 characters");
                }
                else
                {
                    MessageBox.Show("Please fill the fields correctly");
                }
            }

            /*   if(ListSubjects.SelectedItems.Count!=0)
                {
                    MessageBox.Show("at least 1 subject");
                }
                if (isIntSurname==false && !surnamee.Contains(" "))
                {
                    MessageBox.Show("no numbers and probel");
                }
                if (isLetterNumber == false && !num.Contains(" "))
                {
                    MessageBox.Show("no leters and probel in number");
                }
                else if(numericAge.Value==0)
                {
                    MessageBox.Show("Please choose your age");
                }

                else
                {
                    this.Hide();
                    var form2 = new TeacherDiarycs();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }*/
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            textBoxPass.ForeColor = SystemColors.InfoText;
            labelPass.Visible = false;
            if (textBoxPass.TextLength <= 7)
            {
                labelPass.Text = "Weak password";
                labelPass.Visible = true;
                labelPass.ForeColor = Color.Firebrick;
            }
            if (textBoxPass.TextLength >= 8)
            {
                labelPass.Text = "Medium password";
                labelPass.Visible = true;
                labelPass.ForeColor = Color.DarkGoldenrod;
            }
            if (textBoxPass.TextLength >= 16)
            {
                labelPass.Visible = true;
                labelPass.Text = "Strong password";
                labelPass.ForeColor = Color.ForestGreen;
            }
            if (textBoxPass.TextLength == 0)
            {
                labelPass.Visible = false;
            }
        }

        private void TextBoxLog_TextChanged(object sender, EventArgs e)
        {
            textBoxLog.ForeColor = SystemColors.InfoText;
            labelLog.Visible = false;
            if (textBoxLog.TextLength <= 7)
            {
                labelLog.Text = "Weak login";
                labelLog.Visible = true;
                labelLog.ForeColor = Color.Firebrick;
            }
            if (textBoxLog.TextLength >= 8)
            {
                labelLog.Text = "Medium login";
                labelLog.Visible = true;
                labelLog.ForeColor = Color.DarkGoldenrod;
            }
            if (textBoxLog.TextLength >= 16)
            {
                labelLog.Visible = true;
                labelLog.Text = "Strong login";
                labelLog.ForeColor = Color.ForestGreen;
            }
            if (textBoxLog.TextLength == 0)
            {
                labelLog.Visible = false;
            }


        }

        private void ComboClassnum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboGender_TextChanged(object sender, EventArgs e)
        {
            comboGender.Text = "";
        }

        private void ComboEducation_TextChanged(object sender, EventArgs e)
        {
            comboEducation.Text = "";
        }

        private void ComboClassnum_TextChanged(object sender, EventArgs e)
        {
            comboClassnum.Text = "";
        }

        private void RegistrTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void RegistrTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        async void RegistrStudent_Load(object sender, EventArgs e)
        {
            MainMenu.checkAnimation = true;
            for (Opacity = 0; Opacity < 1; Opacity += 0.01)
            {
                await Task.Delay(10);
            }
        }
    }
}
