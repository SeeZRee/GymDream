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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNum = new System.Windows.Forms.TextBox();
            this.TextBoxEditIdClient = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxEditNum = new System.Windows.Forms.TextBox();
            this.TextBoxFio = new System.Windows.Forms.TextBox();
            this.TextBoxDeleteClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Id Клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Id Клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Номер телефона";
            // 
            // TextBoxNum
            // 
            this.TextBoxNum.Location = new System.Drawing.Point(73, 49);
            this.TextBoxNum.Name = "TextBoxNum";
            this.TextBoxNum.Size = new System.Drawing.Size(117, 20);
            this.TextBoxNum.TabIndex = 27;
            // 
            // TextBoxEditIdClient
            // 
            this.TextBoxEditIdClient.Location = new System.Drawing.Point(419, 102);
            this.TextBoxEditIdClient.Name = "TextBoxEditIdClient";
            this.TextBoxEditIdClient.Size = new System.Drawing.Size(117, 20);
            this.TextBoxEditIdClient.TabIndex = 32;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAdd.Location = new System.Drawing.Point(73, 161);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(117, 34);
            this.ButtonAdd.TabIndex = 23;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ФИО";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDelete.Location = new System.Drawing.Point(250, 161);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(117, 34);
            this.ButtonDelete.TabIndex = 24;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Номер телефона";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEdit.Location = new System.Drawing.Point(419, 161);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(117, 34);
            this.ButtonEdit.TabIndex = 25;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // TextBoxEditNum
            // 
            this.TextBoxEditNum.Location = new System.Drawing.Point(419, 49);
            this.TextBoxEditNum.Name = "TextBoxEditNum";
            this.TextBoxEditNum.Size = new System.Drawing.Size(117, 20);
            this.TextBoxEditNum.TabIndex = 29;
            // 
            // TextBoxFio
            // 
            this.TextBoxFio.Location = new System.Drawing.Point(73, 102);
            this.TextBoxFio.Name = "TextBoxFio";
            this.TextBoxFio.Size = new System.Drawing.Size(117, 20);
            this.TextBoxFio.TabIndex = 26;
            // 
            // TextBoxDeleteClient
            // 
            this.TextBoxDeleteClient.Location = new System.Drawing.Point(250, 102);
            this.TextBoxDeleteClient.Name = "TextBoxDeleteClient";
            this.TextBoxDeleteClient.Size = new System.Drawing.Size(117, 20);
            this.TextBoxDeleteClient.TabIndex = 28;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 387);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxNum);
            this.Controls.Add(this.TextBoxEditIdClient);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxEditNum);
            this.Controls.Add(this.TextBoxFio);
            this.Controls.Add(this.TextBoxDeleteClient);
            this.MaximumSize = new System.Drawing.Size(628, 426);
            this.MinimumSize = new System.Drawing.Size(628, 426);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxNum;
        private System.Windows.Forms.TextBox TextBoxEditIdClient;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxEditNum;
        private System.Windows.Forms.TextBox TextBoxFio;
        private System.Windows.Forms.TextBox TextBoxDeleteClient;
    }
}