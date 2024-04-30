namespace WindowsFormsApp3
{
    partial class RegistrationForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.PassRegTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogRegTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassRegTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Войти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PassRegTextBox
            // 
            this.PassRegTextBox.Location = new System.Drawing.Point(58, 60);
            this.PassRegTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PassRegTextBox.Name = "PassRegTextBox";
            this.PassRegTextBox.Size = new System.Drawing.Size(120, 20);
            this.PassRegTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // LogRegTextBox
            // 
            this.LogRegTextBox.Location = new System.Drawing.Point(58, 16);
            this.LogRegTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LogRegTextBox.Name = "LogRegTextBox";
            this.LogRegTextBox.Size = new System.Drawing.Size(120, 20);
            this.LogRegTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // PassRegTextBox2
            // 
            this.PassRegTextBox2.Location = new System.Drawing.Point(58, 103);
            this.PassRegTextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.PassRegTextBox2.Name = "PassRegTextBox2";
            this.PassRegTextBox2.Size = new System.Drawing.Size(120, 20);
            this.PassRegTextBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Повторите пароль";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 172);
            this.Controls.Add(this.PassRegTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PassRegTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogRegTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PassRegTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogRegTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassRegTextBox2;
        private System.Windows.Forms.Label label3;
    }
}