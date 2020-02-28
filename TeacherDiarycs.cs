using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DatabaseRudnevProject
{
    public partial class TeacherDiarycs : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\Nikita\source\repos\DatabaseRudnevProject\DB\opilane.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection sqlCon2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\opilane\source\repos\DatabaseRudnevProject\DB\opilane.mdf;Integrated Security=True;Connect Timeout=30");
        int StudentId = 0;

        public TeacherDiarycs()
        {
            InitializeComponent();
            FalseControl();
            label1.Text = "Welcome to teacher diary, " + LoginTeacher.getText;
            /*     try
                 {
                     if (sqlCon.State == ConnectionState.Closed)
                     {
                         sqlCon.Open();
                     }
                     SqlDataAdapter sqlDa = new SqlDataAdapter("TeacherNameShow", sqlCon);// преобразовывает из 1 формата в другой, отображает
                     sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                     sqlDa.SelectCommand.Parameters.Add("@Name");
                     // numericMark.Text = DataGrid.CurrentRow.Cells[6].Value.ToString();
                     DataTable dtbl = new DataTable();
                     sqlDa.Fill(dtbl);
                     sqlCon.Close();
                 }
                 catch (Exception ex) // если ошибка
                 {
                     MessageBox.Show(ex.Message, "Error Message");
                 }
                 finally
                 {
                     sqlCon.Close();
                 }*/

            /*  SqlDataAdapter sqlDa = new SqlDataAdapter("MainShowTeacher", sqlCon);// преобразовывает из 1 формата в другой, отображает
              sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
              sqlDa.SelectCommand.Parameters.AddWithValue("@Name", textSearch.Text.Trim());

              DataTable dtbl = new DataTable();
              sqlDa.Fill(dtbl);
              DataGrid.DataSource = dtbl;
              DataGrid.Columns[0].Visible = false;
              sqlCon.Close();
              label1.Text = DataGrid.Columns[0].ToString();*/
            /*        SqlDataAdapter sqlDa = new SqlDataAdapter("MainShowTeacher", sqlCon);
                    string sqlExpression = "";
                    DataSet dataSet = new DataSet();
                    var fil= sqlDa.Fill(dataSet,sqlExpression);
                    SqlCommand command = new SqlCommand(sqlExpression, sqlCon);
                    SqlDataReader reader = command.ExecuteReader();

                 /*   SqlDataAdapter sqlDa = new SqlDataAdapter("MainShowTeacher", sqlCon);// преобразовывает из 1 формата в другой, отображает
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    label1.Text = "Welcome" +  fil;
                    sqlCon.Close();*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you really want to exit", "Exit", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("EditStudent", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                sqlCmd.Parameters.AddWithValue("@opilaneId", StudentId);
                sqlCmd.Parameters.AddWithValue("@TaughtSubjects", textSubject.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ClassNumber", labelClass.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Work", textWork.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Mark", numericMark.Text.Trim());
                sqlCmd.ExecuteNonQuery(); // вывод
                FillDataGridView();
                FalseControl();
                MessageBox.Show("Updated successfull");
            }
            catch (Exception ex) // если ошибка
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlDataAdapter sqlDa = new SqlDataAdapter("MainShowTeacher", sqlCon);// преобразовывает из 1 формата в другой, отображает
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Surname", textSearch.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@Name", textSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid.DataSource = dtbl;
            DataGrid.Columns[0].Visible = false;
            sqlCon.Close();
        }
        void FalseControl()
        {
            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
            }
        }
        void TrueControl()
        {
            foreach (Control control in panel1.Controls)
            {
                control.Visible = true;
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
                TrueControl();
            }
            catch (Exception ex) // если ошибка
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
           if(textSearch.Text.Length!=0)
           {
            try
            {
                    FalseControl();
                    FillDataGridView();
            }
            catch (Exception ex) // если ошибка
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
           }

        }

        async void TeacherDiarycs_Load(object sender, EventArgs e)
        {
            MainMenu.checkAnimation = true;
            for (Opacity = 0; Opacity < 1; Opacity += 0.01)
            {
                await Task.Delay(10);
            }
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (DataGrid.CurrentRow.Index != -1)
            {
                StudentId = Convert.ToInt32( DataGrid.CurrentRow.Cells[0].Value);
                labelName.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
                labelSurname.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
                labelClass.Text = DataGrid.CurrentRow.Cells[3].Value.ToString();
                textWork.Text = DataGrid.CurrentRow.Cells[4].Value.ToString();
                textSubject.Text = DataGrid.CurrentRow.Cells[5].Value.ToString();
                numericMark.Text = DataGrid.CurrentRow.Cells[6].Value.ToString();
                TrueControl();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            FalseControl();
        }

        private void TeacherDiarycs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch_Click(sender, e);
            }
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGrid_DoubleClick(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you really want to log out", "Log out", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                LoginTeacher.autoLog = false;
                this.Hide();
                var form2 = new MainMenu();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainMenu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
