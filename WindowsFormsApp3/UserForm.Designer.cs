namespace WindowsFormsApp3
{
    partial class UserForm
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
            this.TextBoxLoginUser = new System.Windows.Forms.TextBox();
            this.TextBoxEditIdUser = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxPasswordUser = new System.Windows.Forms.TextBox();
            this.TextBoxDeleteUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxEditLogUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLoginUser
            // 
            this.TextBoxLoginUser.Location = new System.Drawing.Point(102, 123);
            this.TextBoxLoginUser.Name = "TextBoxLoginUser";
            this.TextBoxLoginUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxLoginUser.TabIndex = 14;
            // 
            // TextBoxEditIdUser
            // 
            this.TextBoxEditIdUser.Location = new System.Drawing.Point(448, 176);
            this.TextBoxEditIdUser.Name = "TextBoxEditIdUser";
            this.TextBoxEditIdUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxEditIdUser.TabIndex = 19;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAdd.Location = new System.Drawing.Point(630, 53);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(117, 34);
            this.ButtonAdd.TabIndex = 10;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDelete.Location = new System.Drawing.Point(630, 109);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(117, 34);
            this.ButtonDelete.TabIndex = 11;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин\r\n";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEdit.Location = new System.Drawing.Point(630, 165);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(117, 34);
            this.ButtonEdit.TabIndex = 12;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEditUser_Click);
            // 
            // TextBoxPasswordUser
            // 
            this.TextBoxPasswordUser.Location = new System.Drawing.Point(102, 176);
            this.TextBoxPasswordUser.Name = "TextBoxPasswordUser";
            this.TextBoxPasswordUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxPasswordUser.TabIndex = 13;
            // 
            // TextBoxDeleteUser
            // 
            this.TextBoxDeleteUser.Location = new System.Drawing.Point(279, 176);
            this.TextBoxDeleteUser.Name = "TextBoxDeleteUser";
            this.TextBoxDeleteUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxDeleteUser.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Id Пользователя";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_User,
            this.Login,
            this.Password,
            this.Id_Post,
            this.Id_Client});
            this.dataGridView1.Location = new System.Drawing.Point(9, 261);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(738, 249);
            this.dataGridView1.TabIndex = 23;
            // 
            // Id_User
            // 
            this.Id_User.DataPropertyName = "Id_User";
            this.Id_User.HeaderText = "Id_User";
            this.Id_User.Name = "Id_User";
            this.Id_User.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Пароль";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Id_Post
            // 
            this.Id_Post.DataPropertyName = "Id_Post";
            this.Id_Post.HeaderText = "Должность";
            this.Id_Post.Name = "Id_Post";
            this.Id_Post.ReadOnly = true;
            // 
            // Id_Client
            // 
            this.Id_Client.DataPropertyName = "Id_Client";
            this.Id_Client.HeaderText = "Клиент";
            this.Id_Client.Name = "Id_Client";
            this.Id_Client.ReadOnly = true;
            // 
            // TextBoxEditLogUser
            // 
            this.TextBoxEditLogUser.Location = new System.Drawing.Point(448, 123);
            this.TextBoxEditLogUser.Name = "TextBoxEditLogUser";
            this.TextBoxEditLogUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxEditLogUser.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id Пользователя";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxLoginUser);
            this.Controls.Add(this.TextBoxEditIdUser);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxEditLogUser);
            this.Controls.Add(this.TextBoxPasswordUser);
            this.Controls.Add(this.TextBoxDeleteUser);
            this.MaximumSize = new System.Drawing.Size(772, 558);
            this.MinimumSize = new System.Drawing.Size(772, 558);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLoginUser;
        private System.Windows.Forms.TextBox TextBoxEditIdUser;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxPasswordUser;
        private System.Windows.Forms.TextBox TextBoxDeleteUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Client;
        private System.Windows.Forms.TextBox TextBoxEditLogUser;
        private System.Windows.Forms.Label label4;
    }
}