namespace WindowsFormsApp3
{
    partial class WorkerForm
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
            this.TextBoxLoginWorker = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxPasswordWorker = new System.Windows.Forms.TextBox();
            this.TextBoxIdWorker = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxPostForWorker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLoginWorker
            // 
            this.TextBoxLoginWorker.Location = new System.Drawing.Point(203, 125);
            this.TextBoxLoginWorker.Name = "TextBoxLoginWorker";
            this.TextBoxLoginWorker.Size = new System.Drawing.Size(117, 20);
            this.TextBoxLoginWorker.TabIndex = 14;
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
            this.label2.Location = new System.Drawing.Point(200, 157);
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
            this.label1.Location = new System.Drawing.Point(200, 107);
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
            // TextBoxPasswordWorker
            // 
            this.TextBoxPasswordWorker.Location = new System.Drawing.Point(203, 173);
            this.TextBoxPasswordWorker.Name = "TextBoxPasswordWorker";
            this.TextBoxPasswordWorker.Size = new System.Drawing.Size(117, 20);
            this.TextBoxPasswordWorker.TabIndex = 13;
            // 
            // TextBoxIdWorker
            // 
            this.TextBoxIdWorker.Location = new System.Drawing.Point(27, 173);
            this.TextBoxIdWorker.Name = "TextBoxIdWorker";
            this.TextBoxIdWorker.Size = new System.Drawing.Size(117, 20);
            this.TextBoxIdWorker.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Id Сотрудника";
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
            this.Id_Worker,
            this.Login,
            this.Password,
            this.Id_Post,
            this.Date_Log,
            this.Date_Exit});
            this.dataGridView1.Location = new System.Drawing.Point(9, 261);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(738, 249);
            this.dataGridView1.TabIndex = 23;
            // 
            // Id_Worker
            // 
            this.Id_Worker.DataPropertyName = "Id_Worker";
            this.Id_Worker.HeaderText = "Id Сотрудника";
            this.Id_Worker.Name = "Id_Worker";
            this.Id_Worker.ReadOnly = true;
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
            // Date_Log
            // 
            this.Date_Log.DataPropertyName = "Date_Log";
            this.Date_Log.HeaderText = "Время входа ";
            this.Date_Log.Name = "Date_Log";
            this.Date_Log.ReadOnly = true;
            // 
            // Date_Exit
            // 
            this.Date_Exit.DataPropertyName = "Date_Exit";
            this.Date_Exit.HeaderText = "Время выхода";
            this.Date_Exit.Name = "Date_Exit";
            this.Date_Exit.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Должность";
            // 
            // ComboBoxPostForWorker
            // 
            this.ComboBoxPostForWorker.FormattingEnabled = true;
            this.ComboBoxPostForWorker.Location = new System.Drawing.Point(393, 172);
            this.ComboBoxPostForWorker.Name = "ComboBoxPostForWorker";
            this.ComboBoxPostForWorker.Size = new System.Drawing.Size(117, 21);
            this.ComboBoxPostForWorker.TabIndex = 40;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 519);
            this.Controls.Add(this.ComboBoxPostForWorker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxLoginWorker);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxPasswordWorker);
            this.Controls.Add(this.TextBoxIdWorker);
            this.MaximumSize = new System.Drawing.Size(772, 558);
            this.MinimumSize = new System.Drawing.Size(772, 558);
            this.Name = "WorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLoginWorker;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxPasswordWorker;
        private System.Windows.Forms.TextBox TextBoxIdWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxPostForWorker;
    }
}