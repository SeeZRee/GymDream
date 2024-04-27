namespace WindowsFormsApp3
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.AbonementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(160, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 426);
            this.panel1.TabIndex = 10;
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(13, 12);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(141, 38);
            this.UserButton.TabIndex = 11;
            this.UserButton.Text = "Пользователи";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(13, 74);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(141, 38);
            this.ClientButton.TabIndex = 12;
            this.ClientButton.Text = "Клиенты";
            this.ClientButton.UseVisualStyleBackColor = true;
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(13, 135);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(141, 38);
            this.PostButton.TabIndex = 13;
            this.PostButton.Text = "Должности";
            this.PostButton.UseVisualStyleBackColor = true;
            // 
            // AbonementButton
            // 
            this.AbonementButton.Location = new System.Drawing.Point(13, 198);
            this.AbonementButton.Name = "AbonementButton";
            this.AbonementButton.Size = new System.Drawing.Size(141, 38);
            this.AbonementButton.TabIndex = 14;
            this.AbonementButton.Text = "Абонементы";
            this.AbonementButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AbonementButton);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Button AbonementButton;
    }
}

