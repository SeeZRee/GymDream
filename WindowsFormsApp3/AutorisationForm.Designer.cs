namespace WindowsFormsApp3
{
    partial class AutorisationForm
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
            this.AutorisationButton = new System.Windows.Forms.Button();
            this.PassAutoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogAutoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AutorisationButton
            // 
            this.AutorisationButton.Location = new System.Drawing.Point(58, 134);
            this.AutorisationButton.Name = "AutorisationButton";
            this.AutorisationButton.Size = new System.Drawing.Size(120, 30);
            this.AutorisationButton.TabIndex = 9;
            this.AutorisationButton.Text = "Войти";
            this.AutorisationButton.UseVisualStyleBackColor = true;
            this.AutorisationButton.Click += new System.EventHandler(this.AutorisationButton_Click);
            // 
            // PassAutoTextBox
            // 
            this.PassAutoTextBox.Location = new System.Drawing.Point(58, 60);
            this.PassAutoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PassAutoTextBox.Name = "PassAutoTextBox";
            this.PassAutoTextBox.Size = new System.Drawing.Size(120, 20);
            this.PassAutoTextBox.TabIndex = 8;
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
            // LogAutoTextBox
            // 
            this.LogAutoTextBox.Location = new System.Drawing.Point(58, 16);
            this.LogAutoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LogAutoTextBox.Name = "LogAutoTextBox";
            this.LogAutoTextBox.Size = new System.Drawing.Size(120, 20);
            this.LogAutoTextBox.TabIndex = 6;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // AutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 172);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AutorisationButton);
            this.Controls.Add(this.PassAutoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogAutoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AutorisationForm";
            this.Text = "AutorisationForm";
            this.Load += new System.EventHandler(this.AutorisationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AutorisationButton;
        private System.Windows.Forms.TextBox PassAutoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogAutoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}