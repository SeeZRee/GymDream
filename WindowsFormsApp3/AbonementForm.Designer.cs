namespace WindowsFormsApp3
{
    partial class AbonementForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id_Abonement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Abonement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxAbonementName = new System.Windows.Forms.TextBox();
            this.TextBoxIdAbonement = new System.Windows.Forms.TextBox();
            this.ButtonAddAbonement = new System.Windows.Forms.Button();
            this.ButtonDeleteAbonement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxPriceAbonement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Abonement,
            this.Name_Abonement,
            this.Price});
            this.dataGridView2.Location = new System.Drawing.Point(9, 261);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.MaximumSize = new System.Drawing.Size(738, 249);
            this.dataGridView2.MinimumSize = new System.Drawing.Size(738, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(738, 249);
            this.dataGridView2.TabIndex = 37;
            // 
            // Id_Abonement
            // 
            this.Id_Abonement.DataPropertyName = "Id_Abonement";
            this.Id_Abonement.FillWeight = 76.14214F;
            this.Id_Abonement.HeaderText = "Id_Abonement";
            this.Id_Abonement.Name = "Id_Abonement";
            this.Id_Abonement.ReadOnly = true;
            // 
            // Name_Abonement
            // 
            this.Name_Abonement.DataPropertyName = "Name_Abonement";
            this.Name_Abonement.FillWeight = 111.9289F;
            this.Name_Abonement.HeaderText = "Название Абонемента";
            this.Name_Abonement.Name = "Name_Abonement";
            this.Name_Abonement.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 111.9289F;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Id Абонемента";
            // 
            // TextBoxAbonementName
            // 
            this.TextBoxAbonementName.Location = new System.Drawing.Point(296, 195);
            this.TextBoxAbonementName.Name = "TextBoxAbonementName";
            this.TextBoxAbonementName.Size = new System.Drawing.Size(117, 20);
            this.TextBoxAbonementName.TabIndex = 28;
            // 
            // TextBoxIdAbonement
            // 
            this.TextBoxIdAbonement.Location = new System.Drawing.Point(159, 195);
            this.TextBoxIdAbonement.Name = "TextBoxIdAbonement";
            this.TextBoxIdAbonement.Size = new System.Drawing.Size(117, 20);
            this.TextBoxIdAbonement.TabIndex = 33;
            // 
            // ButtonAddAbonement
            // 
            this.ButtonAddAbonement.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddAbonement.Location = new System.Drawing.Point(613, 71);
            this.ButtonAddAbonement.Name = "ButtonAddAbonement";
            this.ButtonAddAbonement.Size = new System.Drawing.Size(117, 34);
            this.ButtonAddAbonement.TabIndex = 24;
            this.ButtonAddAbonement.Text = "Добавить";
            this.ButtonAddAbonement.UseVisualStyleBackColor = false;
            this.ButtonAddAbonement.Click += new System.EventHandler(this.ButtonAddAbonement_Click);
            // 
            // ButtonDeleteAbonement
            // 
            this.ButtonDeleteAbonement.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDeleteAbonement.Location = new System.Drawing.Point(613, 127);
            this.ButtonDeleteAbonement.Name = "ButtonDeleteAbonement";
            this.ButtonDeleteAbonement.Size = new System.Drawing.Size(117, 34);
            this.ButtonDeleteAbonement.TabIndex = 25;
            this.ButtonDeleteAbonement.Text = "Удалить";
            this.ButtonDeleteAbonement.UseVisualStyleBackColor = false;
            this.ButtonDeleteAbonement.Click += new System.EventHandler(this.ButtonDeleteAbonement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название абонемента";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEdit.Location = new System.Drawing.Point(613, 181);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(117, 34);
            this.ButtonEdit.TabIndex = 26;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextBoxPriceAbonement
            // 
            this.TextBoxPriceAbonement.Location = new System.Drawing.Point(437, 195);
            this.TextBoxPriceAbonement.Name = "TextBoxPriceAbonement";
            this.TextBoxPriceAbonement.Size = new System.Drawing.Size(117, 20);
            this.TextBoxPriceAbonement.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Цена";
            // 
            // AbonementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 519);
            this.Controls.Add(this.TextBoxPriceAbonement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxAbonementName);
            this.Controls.Add(this.TextBoxIdAbonement);
            this.Controls.Add(this.ButtonAddAbonement);
            this.Controls.Add(this.ButtonDeleteAbonement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonEdit);
            this.MinimumSize = new System.Drawing.Size(772, 558);
            this.Name = "AbonementForm";
            this.Text = "AbonementForm";
            this.Load += new System.EventHandler(this.AbonementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxAbonementName;
        private System.Windows.Forms.TextBox TextBoxIdAbonement;
        private System.Windows.Forms.Button ButtonAddAbonement;
        private System.Windows.Forms.Button ButtonDeleteAbonement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxPriceAbonement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Abonement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Abonement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}