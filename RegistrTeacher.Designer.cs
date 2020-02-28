namespace DatabaseRudnevProject
{
    partial class RegistrTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.Namee = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.comboEducation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericStudents = new System.Windows.Forms.NumericUpDown();
            this.labelclassnum = new System.Windows.Forms.Label();
            this.labelnum = new System.Windows.Forms.Label();
            this.comboClassnum = new System.Windows.Forms.ComboBox();
            this.checkTeacher = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ListSubjects = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStudents)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textAddress.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.textAddress.Location = new System.Drawing.Point(181, 275);
            this.textAddress.Margin = new System.Windows.Forms.Padding(0);
            this.textAddress.MaxLength = 45;
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(355, 30);
            this.textAddress.TabIndex = 33;
            // 
            // textNumber
            // 
            this.textNumber.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textNumber.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.textNumber.Location = new System.Drawing.Point(181, 180);
            this.textNumber.Margin = new System.Windows.Forms.Padding(0);
            this.textNumber.MaxLength = 45;
            this.textNumber.Multiline = true;
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(355, 30);
            this.textNumber.TabIndex = 32;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Address.Location = new System.Drawing.Point(20, 276);
            this.Address.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(84, 26);
            this.Address.TabIndex = 31;
            this.Address.Text = "Address";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btnReset.Location = new System.Drawing.Point(104, 460);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 40);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset fields";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btnDelete.Location = new System.Drawing.Point(5, 460);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 40);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Cancel";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textName.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.textName.Location = new System.Drawing.Point(181, 79);
            this.textName.Margin = new System.Windows.Forms.Padding(0);
            this.textName.MaxLength = 45;
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(355, 30);
            this.textName.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btnSave.Location = new System.Drawing.Point(228, 460);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Register";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Namee
            // 
            this.Namee.AutoSize = true;
            this.Namee.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Namee.Location = new System.Drawing.Point(20, 85);
            this.Namee.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(62, 26);
            this.Namee.TabIndex = 25;
            this.Namee.Text = "Name";
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Mobile.Location = new System.Drawing.Point(20, 180);
            this.Mobile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(140, 26);
            this.Mobile.TabIndex = 26;
            this.Mobile.Text = "Mobile number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28F);
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 53);
            this.label1.TabIndex = 34;
            this.label1.Text = "Welcome to Teacher registration form";
            // 
            // textSurname
            // 
            this.textSurname.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textSurname.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.textSurname.Location = new System.Drawing.Point(181, 132);
            this.textSurname.Margin = new System.Windows.Forms.Padding(0);
            this.textSurname.MaxLength = 45;
            this.textSurname.Multiline = true;
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(355, 30);
            this.textSurname.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Surname";
            // 
            // textMail
            // 
            this.textMail.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textMail.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.textMail.Location = new System.Drawing.Point(181, 326);
            this.textMail.Margin = new System.Windows.Forms.Padding(0);
            this.textMail.MaxLength = 45;
            this.textMail.Multiline = true;
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(355, 30);
            this.textMail.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(20, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mail";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textDescription.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.textDescription.Location = new System.Drawing.Point(181, 385);
            this.textDescription.Margin = new System.Windows.Forms.Padding(0);
            this.textDescription.MaxLength = 250;
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(355, 136);
            this.textDescription.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(20, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.label5.Location = new System.Drawing.Point(187, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 45);
            this.label5.TabIndex = 41;
            this.label5.Text = "About me";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericAge);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.comboGender);
            this.panel1.Controls.Add(this.comboEducation);
            this.panel1.Controls.Add(this.Namee);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Mobile);
            this.panel1.Controls.Add(this.textDescription);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.textMail);
            this.panel1.Controls.Add(this.textNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textAddress);
            this.panel1.Controls.Add(this.textSurname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 644);
            this.panel1.TabIndex = 42;
            // 
            // numericAge
            // 
            this.numericAge.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numericAge.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.numericAge.Location = new System.Drawing.Point(181, 226);
            this.numericAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(120, 30);
            this.numericAge.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label13.Location = new System.Drawing.Point(20, 226);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 26);
            this.label13.TabIndex = 45;
            this.label13.Text = "Age";
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboGender.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboGender.Location = new System.Drawing.Point(181, 540);
            this.comboGender.MaxLength = 45;
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(355, 31);
            this.comboGender.TabIndex = 44;
            this.comboGender.TextChanged += new System.EventHandler(this.ComboGender_TextChanged);
            // 
            // comboEducation
            // 
            this.comboEducation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboEducation.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.comboEducation.FormattingEnabled = true;
            this.comboEducation.Items.AddRange(new object[] {
            "Secondary education",
            "Secondary vocational education",
            "Higher education",
            "Elementary Education",
            "Magistracy"});
            this.comboEducation.Location = new System.Drawing.Point(181, 591);
            this.comboEducation.MaxLength = 45;
            this.comboEducation.Name = "comboEducation";
            this.comboEducation.Size = new System.Drawing.Size(355, 31);
            this.comboEducation.TabIndex = 43;
            this.comboEducation.TextChanged += new System.EventHandler(this.ComboEducation_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(20, 591);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Education";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(20, 540);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Gender";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.numericStudents);
            this.panel2.Controls.Add(this.labelclassnum);
            this.panel2.Controls.Add(this.labelnum);
            this.panel2.Controls.Add(this.comboClassnum);
            this.panel2.Controls.Add(this.checkTeacher);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ListSubjects);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(562, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 512);
            this.panel2.TabIndex = 43;
            // 
            // numericStudents
            // 
            this.numericStudents.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numericStudents.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.numericStudents.Location = new System.Drawing.Point(236, 404);
            this.numericStudents.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericStudents.Name = "numericStudents";
            this.numericStudents.Size = new System.Drawing.Size(120, 30);
            this.numericStudents.TabIndex = 48;
            this.numericStudents.Visible = false;
            // 
            // labelclassnum
            // 
            this.labelclassnum.AutoSize = true;
            this.labelclassnum.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelclassnum.Location = new System.Drawing.Point(8, 460);
            this.labelclassnum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelclassnum.Name = "labelclassnum";
            this.labelclassnum.Size = new System.Drawing.Size(127, 26);
            this.labelclassnum.TabIndex = 47;
            this.labelclassnum.Text = "Class number";
            this.labelclassnum.Visible = false;
            // 
            // labelnum
            // 
            this.labelnum.AutoSize = true;
            this.labelnum.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelnum.Location = new System.Drawing.Point(8, 398);
            this.labelnum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelnum.Name = "labelnum";
            this.labelnum.Size = new System.Drawing.Size(189, 26);
            this.labelnum.TabIndex = 46;
            this.labelnum.Text = "Number of students";
            this.labelnum.Visible = false;
            // 
            // comboClassnum
            // 
            this.comboClassnum.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboClassnum.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.comboClassnum.FormattingEnabled = true;
            this.comboClassnum.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B",
            "3A",
            "3B",
            "4A",
            "4B",
            "5A",
            "5B",
            "5C",
            "6A",
            "6B",
            "7G",
            "8A",
            "8B",
            "9A",
            "9B",
            "10A",
            "10B",
            "10C",
            "11A",
            "11B",
            "12A",
            "12B"});
            this.comboClassnum.Location = new System.Drawing.Point(236, 466);
            this.comboClassnum.MaxLength = 3;
            this.comboClassnum.Name = "comboClassnum";
            this.comboClassnum.Size = new System.Drawing.Size(121, 31);
            this.comboClassnum.TabIndex = 45;
            this.comboClassnum.Visible = false;
            this.comboClassnum.TextChanged += new System.EventHandler(this.ComboClassnum_TextChanged);
            // 
            // checkTeacher
            // 
            this.checkTeacher.AutoSize = true;
            this.checkTeacher.BackColor = System.Drawing.Color.PeachPuff;
            this.checkTeacher.Location = new System.Drawing.Point(236, 354);
            this.checkTeacher.Name = "checkTeacher";
            this.checkTeacher.Size = new System.Drawing.Size(15, 14);
            this.checkTeacher.TabIndex = 44;
            this.checkTeacher.UseVisualStyleBackColor = false;
            this.checkTeacher.CheckedChanged += new System.EventHandler(this.CheckTeacher_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.Location = new System.Drawing.Point(8, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 26);
            this.label9.TabIndex = 43;
            this.label9.Text = "Classrooom teacher";
            // 
            // ListSubjects
            // 
            this.ListSubjects.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ListSubjects.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ListSubjects.FormattingEnabled = true;
            this.ListSubjects.Items.AddRange(new object[] {
            "Math",
            "English",
            "Physics",
            "Biology",
            "Russian language",
            "Programming",
            "Physical training",
            "Chemistry"});
            this.ListSubjects.Location = new System.Drawing.Point(230, 79);
            this.ListSubjects.Name = "ListSubjects";
            this.ListSubjects.Size = new System.Drawing.Size(220, 260);
            this.ListSubjects.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.label7.Location = new System.Drawing.Point(125, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 45);
            this.label7.TabIndex = 41;
            this.label7.Text = "Skills and post";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label12.Location = new System.Drawing.Point(8, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 26);
            this.label12.TabIndex = 35;
            this.label12.Text = "Academic subjects";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelLog);
            this.panel3.Controls.Add(this.labelPass);
            this.panel3.Controls.Add(this.textBoxPass);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBoxLog);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(1035, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 512);
            this.panel3.TabIndex = 44;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelLog.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLog.Location = new System.Drawing.Point(20, 153);
            this.labelLog.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(94, 27);
            this.labelLog.TabIndex = 50;
            this.labelLog.Text = "Bad login";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelPass.ForeColor = System.Drawing.Color.Firebrick;
            this.labelPass.Location = new System.Drawing.Point(16, 279);
            this.labelPass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(136, 27);
            this.labelPass.TabIndex = 49;
            this.labelPass.Text = "Bad password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxPass.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.textBoxPass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPass.Location = new System.Drawing.Point(21, 237);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPass.MaxLength = 30;
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(317, 30);
            this.textBoxPass.TabIndex = 47;
            this.textBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.Location = new System.Drawing.Point(16, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 26);
            this.label11.TabIndex = 46;
            this.label11.Text = "Password";
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxLog.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.textBoxLog.Location = new System.Drawing.Point(21, 116);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLog.MaxLength = 30;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(317, 30);
            this.textBoxLog.TabIndex = 45;
            this.textBoxLog.TextChanged += new System.EventHandler(this.TextBoxLog_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.Location = new System.Drawing.Point(16, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 26);
            this.label10.TabIndex = 44;
            this.label10.Text = "Login";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.label14.Location = new System.Drawing.Point(57, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 45);
            this.label14.TabIndex = 41;
            this.label14.Text = "Authorization";
            // 
            // RegistrTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1427, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrTeacher";
            this.Text = "RegistrTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrTeacher_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrTeacher_FormClosed);
            this.Load += new System.EventHandler(this.RegistrTeacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStudents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Namee;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textSurname;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox ListSubjects;
        private System.Windows.Forms.ComboBox comboEducation;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.CheckBox checkTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericStudents;
        private System.Windows.Forms.Label labelclassnum;
        private System.Windows.Forms.Label labelnum;
        private System.Windows.Forms.ComboBox comboClassnum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.NumericUpDown numericAge;
        private System.Windows.Forms.Label label13;
    }
}