namespace library_project
{
    partial class BorrowForm
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
            lblMemberId = new Label();
            txtMemberId = new TextBox();
            lblFrom = new Label();
            dtFrom = new DateTimePicker();
            lblTo = new Label();
            dtTo = new DateTimePicker();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(93, 29);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(72, 25);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "کد کتاب";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(190, 29);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(150, 31);
            txtBookId.TabIndex = 1;
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(92, 96);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(73, 25);
            lblMemberId.TabIndex = 2;
            lblMemberId.Text = "کد عضو";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(190, 96);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(150, 31);
            txtMemberId.TabIndex = 3;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(61, 160);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(104, 25);
            lblFrom.TabIndex = 4;
            lblFrom.Text = "تاریخ امانت ";
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(171, 160);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(300, 31);
            dtFrom.TabIndex = 5;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(52, 213);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(113, 25);
            lblTo.TabIndex = 6;
            lblTo.Text = "تاریخ بازگشت";
            // 
            // dtTo
            // 
            dtTo.Location = new Point(171, 213);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(300, 31);
            dtTo.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(252, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "ثبت امانت";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(dtTo);
            Controls.Add(lblTo);
            Controls.Add(dtFrom);
            Controls.Add(lblFrom);
            Controls.Add(txtMemberId);
            Controls.Add(lblMemberId);
            Controls.Add(txtBookId);
            Controls.Add(lblBookId);
            Name = "BorrowForm";
            Text = "BorrowForm";
            Load += BorrowForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookId;
        private TextBox txtBookId;
        private Label lblMemberId;
        private TextBox txtMemberId;
        private Label lblFrom;
        private DateTimePicker dtFrom;
        private Label lblTo;
        private DateTimePicker dtTo;
        private Button btnSave;
    }
}