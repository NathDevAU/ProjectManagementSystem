namespace ProjectManagement
{
    partial class MainContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.създайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експертToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.създайToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testFormToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.testToolStripMenuItem.Text = "Файл";
            // 
            // testFormToolStripMenuItem
            // 
            this.testFormToolStripMenuItem.Name = "testFormToolStripMenuItem";
            this.testFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testFormToolStripMenuItem.Text = "TestForm";
            this.testFormToolStripMenuItem.Click += new System.EventHandler(this.testFormToolStripMenuItem_Click);
            // 
            // създайToolStripMenuItem
            // 
            this.създайToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новПроектToolStripMenuItem,
            this.експертToolStripMenuItem});
            this.създайToolStripMenuItem.Name = "създайToolStripMenuItem";
            this.създайToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.създайToolStripMenuItem.Text = "Създай";
            // 
            // новПроектToolStripMenuItem
            // 
            this.новПроектToolStripMenuItem.Name = "новПроектToolStripMenuItem";
            this.новПроектToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.новПроектToolStripMenuItem.Text = "Нов проект";
            // 
            // експертToolStripMenuItem
            // 
            this.експертToolStripMenuItem.Name = "експертToolStripMenuItem";
            this.експертToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.експертToolStripMenuItem.Text = "Експерт";
            this.експертToolStripMenuItem.Click += new System.EventHandler(this.експертToolStripMenuItem_Click);
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 333);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainContainer";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem създайToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem експертToolStripMenuItem;
    }
}

