namespace library_project
{
    partial class BookForm
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
            lblBookId = new Label();
            txtBookId = new TextBox();
            lblBookName = new Label();
            txtBookName = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(173, 50);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(72, 25);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "کد کتاب";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(282, 50);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(150, 31);
            txtBookId.TabIndex = 1;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(186, 119);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(76, 25);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "نام کتاب";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(282, 119);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(150, 31);
            txtBookName.TabIndex = 3;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(161, 185);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(101, 25);
            lblAuthor.TabIndex = 4;
            lblAuthor.Text = "نام نویسنده";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(282, 179);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(150, 31);
            txtAuthor.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(255, 292);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtAuthor);
            Controls.Add(lblAuthor);
            Controls.Add(txtBookName);
            Controls.Add(lblBookName);
            Controls.Add(txtBookId);
            Controls.Add(lblBookId);
            Name = "BookForm";
            Text = "BookForm";
            Load += BookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookId;
        private TextBox txtBookId;
        private Label lblBookName;
        private TextBox txtBookName;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Button btnSave;
    }
}