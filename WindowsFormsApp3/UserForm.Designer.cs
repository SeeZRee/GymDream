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
            this.TextBoxEditLogUser = new System.Windows.Forms.TextBox();
            this.TextBoxPasswordUser = new System.Windows.Forms.TextBox();
            this.TextBoxDeleteUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxLoginUser
            // 
            this.TextBoxLoginUser.Location = new System.Drawing.Point(73, 49);
            this.TextBoxLoginUser.Name = "TextBoxLoginUser";
            this.TextBoxLoginUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxLoginUser.TabIndex = 14;
            // 
            // TextBoxEditIdUser
            // 
            this.TextBoxEditIdUser.Location = new System.Drawing.Point(419, 102);
            this.TextBoxEditIdUser.Name = "TextBoxEditIdUser";
            this.TextBoxEditIdUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxEditIdUser.TabIndex = 19;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAdd.Location = new System.Drawing.Point(73, 161);
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
            this.label2.Location = new System.Drawing.Point(70, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDelete.Location = new System.Drawing.Point(250, 161);
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
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин\r\n";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEdit.Location = new System.Drawing.Point(419, 161);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(117, 34);
            this.ButtonEdit.TabIndex = 12;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEditUser_Click);
            // 
            // TextBoxEditLogUser
            // 
            this.TextBoxEditLogUser.Location = new System.Drawing.Point(419, 49);
            this.TextBoxEditLogUser.Name = "TextBoxEditLogUser";
            this.TextBoxEditLogUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxEditLogUser.TabIndex = 16;
            // 
            // TextBoxPasswordUser
            // 
            this.TextBoxPasswordUser.Location = new System.Drawing.Point(73, 102);
            this.TextBoxPasswordUser.Name = "TextBoxPasswordUser";
            this.TextBoxPasswordUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxPasswordUser.TabIndex = 13;
            // 
            // TextBoxDeleteUser
            // 
            this.TextBoxDeleteUser.Location = new System.Drawing.Point(250, 102);
            this.TextBoxDeleteUser.Name = "TextBoxDeleteUser";
            this.TextBoxDeleteUser.Size = new System.Drawing.Size(117, 20);
            this.TextBoxDeleteUser.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id Пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Id Пользователя";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 387);
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
            this.MaximumSize = new System.Drawing.Size(628, 426);
            this.MinimumSize = new System.Drawing.Size(628, 426);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
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
        private System.Windows.Forms.TextBox TextBoxEditLogUser;
        private System.Windows.Forms.TextBox TextBoxPasswordUser;
        private System.Windows.Forms.TextBox TextBoxDeleteUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}