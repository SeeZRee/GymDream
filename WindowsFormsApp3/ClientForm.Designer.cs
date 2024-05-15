namespace WindowsFormsApp3
{
    partial class ClientForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxFioClient = new System.Windows.Forms.TextBox();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxNumClient = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Id_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Abonement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComboBoxAbonementsForClients = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxTrainerForClients = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "ФИО клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Номер телефона";
            // 
            // TextBoxFioClient
            // 
            this.TextBoxFioClient.Location = new System.Drawing.Point(316, 175);
            this.TextBoxFioClient.Name = "TextBoxFioClient";
            this.TextBoxFioClient.Size = new System.Drawing.Size(117, 20);
            this.TextBoxFioClient.TabIndex = 32;
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddClient.Location = new System.Drawing.Point(609, 64);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(117, 34);
            this.ButtonAddClient.TabIndex = 23;
            this.ButtonAddClient.Text = "Добавить";
            this.ButtonAddClient.UseVisualStyleBackColor = false;
            this.ButtonAddClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDelete.Location = new System.Drawing.Point(609, 113);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(117, 34);
            this.ButtonDelete.TabIndex = 24;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEdit.Location = new System.Drawing.Point(609, 161);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(117, 34);
            this.ButtonEdit.TabIndex = 25;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // TextBoxNumClient
            // 
            this.TextBoxNumClient.Location = new System.Drawing.Point(316, 127);
            this.TextBoxNumClient.Name = "TextBoxNumClient";
            this.TextBoxNumClient.Size = new System.Drawing.Size(117, 20);
            this.TextBoxNumClient.TabIndex = 29;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Client,
            this.Id_Abonement,
            this.Phone_Number,
            this.FIO_Client,
            this.Id_Trainer,
            this.Id_Worker});
            this.dataGridView3.Location = new System.Drawing.Point(9, 261);
            this.dataGridView3.MaximumSize = new System.Drawing.Size(738, 249);
            this.dataGridView3.MinimumSize = new System.Drawing.Size(738, 249);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(738, 249);
            this.dataGridView3.TabIndex = 36;
            // 
            // Id_Client
            // 
            this.Id_Client.DataPropertyName = "Id_Client";
            this.Id_Client.HeaderText = "Id_Client";
            this.Id_Client.Name = "Id_Client";
            this.Id_Client.ReadOnly = true;
            // 
            // Id_Abonement
            // 
            this.Id_Abonement.DataPropertyName = "Id_Abonement";
            this.Id_Abonement.HeaderText = "Id_Abonement";
            this.Id_Abonement.Name = "Id_Abonement";
            this.Id_Abonement.ReadOnly = true;
            // 
            // Phone_Number
            // 
            this.Phone_Number.DataPropertyName = "Phone_Number";
            this.Phone_Number.HeaderText = "Номер телефона";
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.ReadOnly = true;
            // 
            // FIO_Client
            // 
            this.FIO_Client.DataPropertyName = "FIO_Client";
            this.FIO_Client.HeaderText = "Фио клиента";
            this.FIO_Client.Name = "FIO_Client";
            this.FIO_Client.ReadOnly = true;
            // 
            // Id_Trainer
            // 
            this.Id_Trainer.DataPropertyName = "Id_Trainer";
            this.Id_Trainer.HeaderText = "Id_Trainer";
            this.Id_Trainer.Name = "Id_Trainer";
            this.Id_Trainer.ReadOnly = true;
            // 
            // Id_Worker
            // 
            this.Id_Worker.DataPropertyName = "Id_Worker";
            this.Id_Worker.HeaderText = "Id_Worker";
            this.Id_Worker.Name = "Id_Worker";
            this.Id_Worker.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Id Клиента";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 37;
            // 
            // ComboBoxAbonementsForClients
            // 
            this.ComboBoxAbonementsForClients.FormattingEnabled = true;
            this.ComboBoxAbonementsForClients.Location = new System.Drawing.Point(174, 126);
            this.ComboBoxAbonementsForClients.Name = "ComboBoxAbonementsForClients";
            this.ComboBoxAbonementsForClients.Size = new System.Drawing.Size(117, 21);
            this.ComboBoxAbonementsForClients.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Абонементы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Тренера";
            // 
            // ComboBoxTrainerForClients
            // 
            this.ComboBoxTrainerForClients.FormattingEnabled = true;
            this.ComboBoxTrainerForClients.Location = new System.Drawing.Point(464, 126);
            this.ComboBoxTrainerForClients.Name = "ComboBoxTrainerForClients";
            this.ComboBoxTrainerForClients.Size = new System.Drawing.Size(117, 21);
            this.ComboBoxTrainerForClients.TabIndex = 41;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxTrainerForClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxAbonementsForClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxFioClient);
            this.Controls.Add(this.ButtonAddClient);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxNumClient);
            this.MaximumSize = new System.Drawing.Size(772, 558);
            this.MinimumSize = new System.Drawing.Size(772, 558);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxFioClient;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxNumClient;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ComboBoxAbonementsForClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxTrainerForClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Abonement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Worker;
    }
}