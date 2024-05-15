namespace WindowsFormsApp3
{
    partial class TrainerForm
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Id_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO_Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxOkladTrainer = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxIdTrainer = new System.Windows.Forms.TextBox();
            this.TextBoxFioTrainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
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
            this.Id_Trainer,
            this.FIO_Trainer,
            this.Oklad});
            this.dataGridView3.Location = new System.Drawing.Point(9, 261);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(738, 249);
            this.dataGridView3.TabIndex = 37;
            // 
            // Id_Trainer
            // 
            this.Id_Trainer.DataPropertyName = "Id_Trainer";
            this.Id_Trainer.HeaderText = "Id_Trainer";
            this.Id_Trainer.Name = "Id_Trainer";
            this.Id_Trainer.ReadOnly = true;
            // 
            // FIO_Trainer
            // 
            this.FIO_Trainer.DataPropertyName = "FIO_Trainer";
            this.FIO_Trainer.HeaderText = "Фио тренера";
            this.FIO_Trainer.Name = "FIO_Trainer";
            this.FIO_Trainer.ReadOnly = true;
            // 
            // Oklad
            // 
            this.Oklad.DataPropertyName = "Oklad";
            this.Oklad.HeaderText = "Оклад";
            this.Oklad.Name = "Oklad";
            this.Oklad.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Оклад";
            // 
            // TextBoxOkladTrainer
            // 
            this.TextBoxOkladTrainer.Location = new System.Drawing.Point(448, 176);
            this.TextBoxOkladTrainer.Name = "TextBoxOkladTrainer";
            this.TextBoxOkladTrainer.Size = new System.Drawing.Size(117, 20);
            this.TextBoxOkladTrainer.TabIndex = 33;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAdd.Location = new System.Drawing.Point(630, 53);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(117, 34);
            this.ButtonAdd.TabIndex = 24;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDelete.Location = new System.Drawing.Point(630, 109);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(117, 34);
            this.ButtonDelete.TabIndex = 25;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEdit.Location = new System.Drawing.Point(630, 165);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(117, 34);
            this.ButtonEdit.TabIndex = 26;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextBoxIdTrainer
            // 
            this.TextBoxIdTrainer.Location = new System.Drawing.Point(102, 176);
            this.TextBoxIdTrainer.Name = "TextBoxIdTrainer";
            this.TextBoxIdTrainer.Size = new System.Drawing.Size(117, 20);
            this.TextBoxIdTrainer.TabIndex = 27;
            // 
            // TextBoxFioTrainer
            // 
            this.TextBoxFioTrainer.Location = new System.Drawing.Point(279, 176);
            this.TextBoxFioTrainer.Name = "TextBoxFioTrainer";
            this.TextBoxFioTrainer.Size = new System.Drawing.Size(117, 20);
            this.TextBoxFioTrainer.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Id Тренера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Фио тренера";
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxOkladTrainer);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxIdTrainer);
            this.Controls.Add(this.TextBoxFioTrainer);
            this.MaximumSize = new System.Drawing.Size(772, 558);
            this.MinimumSize = new System.Drawing.Size(772, 558);
            this.Name = "TrainerForm";
            this.Text = "TrainerForm";
            this.Load += new System.EventHandler(this.TrainerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxOkladTrainer;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxIdTrainer;
        private System.Windows.Forms.TextBox TextBoxFioTrainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oklad;
    }
}