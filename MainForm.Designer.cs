namespace library_project
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            menuMemberToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuBookToolStripMenuItem = new ToolStripMenuItem();
            bookFormToolStripMenuItem = new ToolStripMenuItem();
            menuBorrowToolStripMenuItem = new ToolStripMenuItem();
            barrowFormFToolStripMenuItem = new ToolStripMenuItem();
            menuSearchToolStripMenuItem = new ToolStripMenuItem();
            searchFormFToolStripMenuItem = new ToolStripMenuItem();
            menuExitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuMemberToolStripMenuItem, menuBookToolStripMenuItem, menuBorrowToolStripMenuItem, menuSearchToolStripMenuItem, menuExitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuMemberToolStripMenuItem
            // 
            menuMemberToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuMemberToolStripMenuItem.Name = "menuMemberToolStripMenuItem";
            menuMemberToolStripMenuItem.Size = new Size(140, 29);
            menuMemberToolStripMenuItem.Text = "menuMember";
            menuMemberToolStripMenuItem.Click += menuMemberToolStripMenuItem_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(239, 34);
            menuToolStripMenuItem.Text = "Member Form f";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // menuBookToolStripMenuItem
            // 
            menuBookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookFormToolStripMenuItem });
            menuBookToolStripMenuItem.Name = "menuBookToolStripMenuItem";
            menuBookToolStripMenuItem.Size = new Size(114, 29);
            menuBookToolStripMenuItem.Text = "menuBook";
            menuBookToolStripMenuItem.Click += menuBookToolStripMenuItem_Click;
            // 
            // bookFormToolStripMenuItem
            // 
            bookFormToolStripMenuItem.Name = "bookFormToolStripMenuItem";
            bookFormToolStripMenuItem.Size = new Size(197, 34);
            bookFormToolStripMenuItem.Text = "BookForm";
            // 
            // menuBorrowToolStripMenuItem
            // 
            menuBorrowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { barrowFormFToolStripMenuItem });
            menuBorrowToolStripMenuItem.Name = "menuBorrowToolStripMenuItem";
            menuBorrowToolStripMenuItem.Size = new Size(130, 29);
            menuBorrowToolStripMenuItem.Text = "menuBorrow";
            menuBorrowToolStripMenuItem.Click += menuBorrowToolStripMenuItem_Click;
            // 
            // barrowFormFToolStripMenuItem
            // 
            barrowFormFToolStripMenuItem.Name = "barrowFormFToolStripMenuItem";
            barrowFormFToolStripMenuItem.Size = new Size(222, 34);
            barrowFormFToolStripMenuItem.Text = "BarrowForm f";
            // 
            // menuSearchToolStripMenuItem
            // 
            menuSearchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchFormFToolStripMenuItem });
            menuSearchToolStripMenuItem.Name = "menuSearchToolStripMenuItem";
            menuSearchToolStripMenuItem.Size = new Size(125, 29);
            menuSearchToolStripMenuItem.Text = "menuSearch";
            menuSearchToolStripMenuItem.Click += menuSearchToolStripMenuItem_Click;
            // 
            // searchFormFToolStripMenuItem
            // 
            searchFormFToolStripMenuItem.Name = "searchFormFToolStripMenuItem";
            searchFormFToolStripMenuItem.Size = new Size(270, 34);
            searchFormFToolStripMenuItem.Text = "Search Form f";
            // 
            // menuExitToolStripMenuItem
            // 
            menuExitToolStripMenuItem.Name = "menuExitToolStripMenuItem";
            menuExitToolStripMenuItem.Size = new Size(100, 29);
            menuExitToolStripMenuItem.Text = "menuExit";
            menuExitToolStripMenuItem.Click += menuExitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuMemberToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem menuBookToolStripMenuItem;
        private ToolStripMenuItem bookFormToolStripMenuItem;
        private ToolStripMenuItem menuBorrowToolStripMenuItem;
        private ToolStripMenuItem barrowFormFToolStripMenuItem;
        private ToolStripMenuItem menuSearchToolStripMenuItem;
        private ToolStripMenuItem searchFormFToolStripMenuItem;
        private ToolStripMenuItem menuExitToolStripMenuItem;
    }
}