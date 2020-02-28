namespace DatabaseRudnevProject
{
    partial class LoginTeacher
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelLog = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.labelLog);
            this.panel3.Controls.Add(this.labelPass);
            this.panel3.Controls.Add(this.textBoxPass);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBoxLog);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnReg);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 415);
            this.panel3.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(58, 56);
            this.dataGridView1.TabIndex = 51;
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
            this.label14.Location = new System.Drawing.Point(70, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 45);
            this.label14.TabIndex = 41;
            this.label14.Text = "Authorization";
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
            this.btnDelete.Location = new System.Drawing.Point(129, 343);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 40);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Cancel";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReg.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btnReg.Location = new System.Drawing.Point(228, 343);
            this.btnReg.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(110, 40);
            this.btnReg.TabIndex = 27;
            this.btnReg.Text = "Login";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // LoginTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(356, 417);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginTeacher";
            this.Opacity = 0D;
            this.Text = "LoginTeacher";
            this.Load += new System.EventHandler(this.LoginTeacher_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginTeacher_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Label labelPass;
        public System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}