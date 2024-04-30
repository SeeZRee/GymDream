namespace WindowsFormsApp3
{
    partial class Autorisation
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
            this.Авторизация = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GroupBoxAutorisation = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Авторизация
            // 
            this.Авторизация.AutoSize = true;
            this.Авторизация.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Авторизация.Location = new System.Drawing.Point(28, 43);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(245, 42);
            this.Авторизация.TabIndex = 1;
            this.Авторизация.Text = "Авторизация";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 32;
            this.button2.Location = new System.Drawing.Point(153, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupBoxAutorisation
            // 
            this.GroupBoxAutorisation.Location = new System.Drawing.Point(27, 164);
            this.GroupBoxAutorisation.Name = "GroupBoxAutorisation";
            this.GroupBoxAutorisation.Size = new System.Drawing.Size(246, 211);
            this.GroupBoxAutorisation.TabIndex = 4;
            this.GroupBoxAutorisation.TabStop = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(271, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 5;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 387);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GroupBoxAutorisation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Авторизация);
            this.Name = "Autorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Autorisation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Авторизация;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox GroupBoxAutorisation;
        private System.Windows.Forms.Button button3;
    }
}