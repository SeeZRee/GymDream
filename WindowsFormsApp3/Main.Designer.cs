﻿namespace WindowsFormsApp3
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
            this.TrainerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(158, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.MaximumSize = new System.Drawing.Size(776, 521);
            this.panel1.MinimumSize = new System.Drawing.Size(776, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 521);
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
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
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
            this.AbonementButton.Click += new System.EventHandler(this.AbonementButton_Click);
            // 
            // TrainerButton
            // 
            this.TrainerButton.Location = new System.Drawing.Point(13, 259);
            this.TrainerButton.Name = "TrainerButton";
            this.TrainerButton.Size = new System.Drawing.Size(141, 38);
            this.TrainerButton.TabIndex = 15;
            this.TrainerButton.Text = "Тренера";
            this.TrainerButton.UseVisualStyleBackColor = true;
            this.TrainerButton.Click += new System.EventHandler(this.TrainerButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 541);
            this.Controls.Add(this.TrainerButton);
            this.Controls.Add(this.AbonementButton);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(960, 580);
            this.MinimumSize = new System.Drawing.Size(960, 580);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Button AbonementButton;
        private System.Windows.Forms.Button TrainerButton;
    }
}

