namespace WindowsFormsApp3
{
    partial class PostForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Id_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddPost = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxIdPost = new System.Windows.Forms.TextBox();
            this.TextBoxNamePost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Id Должности";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Post,
            this.Name_Post});
            this.dataGridView4.Location = new System.Drawing.Point(9, 261);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(738, 249);
            this.dataGridView4.TabIndex = 47;
            // 
            // Id_Post
            // 
            this.Id_Post.DataPropertyName = "Id_Post";
            this.Id_Post.HeaderText = "Id_Post";
            this.Id_Post.Name = "Id_Post";
            this.Id_Post.ReadOnly = true;
            // 
            // Name_Post
            // 
            this.Name_Post.DataPropertyName = "Name_Post";
            this.Name_Post.HeaderText = "Должность";
            this.Name_Post.Name = "Name_Post";
            this.Name_Post.ReadOnly = true;
            // 
            // ButtonAddPost
            // 
            this.ButtonAddPost.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddPost.Location = new System.Drawing.Point(630, 53);
            this.ButtonAddPost.Name = "ButtonAddPost";
            this.ButtonAddPost.Size = new System.Drawing.Size(117, 34);
            this.ButtonAddPost.TabIndex = 40;
            this.ButtonAddPost.Text = "Добавить";
            this.ButtonAddPost.UseVisualStyleBackColor = false;
            this.ButtonAddPost.Click += new System.EventHandler(this.ButtonAddPost_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDelete.Location = new System.Drawing.Point(630, 109);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(117, 34);
            this.ButtonDelete.TabIndex = 41;
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
            this.ButtonEdit.TabIndex = 42;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // TextBoxIdPost
            // 
            this.TextBoxIdPost.Location = new System.Drawing.Point(105, 176);
            this.TextBoxIdPost.Name = "TextBoxIdPost";
            this.TextBoxIdPost.Size = new System.Drawing.Size(117, 20);
            this.TextBoxIdPost.TabIndex = 43;
            // 
            // TextBoxNamePost
            // 
            this.TextBoxNamePost.Location = new System.Drawing.Point(279, 176);
            this.TextBoxNamePost.Name = "TextBoxNamePost";
            this.TextBoxNamePost.Size = new System.Drawing.Size(117, 20);
            this.TextBoxNamePost.TabIndex = 44;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.ButtonAddPost);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxIdPost);
            this.Controls.Add(this.TextBoxNamePost);
            this.MaximumSize = new System.Drawing.Size(772, 558);
            this.MinimumSize = new System.Drawing.Size(772, 558);
            this.Name = "PostForm";
            this.Text = "PostForm";
            this.Load += new System.EventHandler(this.PostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button ButtonAddPost;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxIdPost;
        private System.Windows.Forms.TextBox TextBoxNamePost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Post;
    }
}