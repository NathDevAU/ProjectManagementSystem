namespace ProjectManagement
{
    partial class ExpertDetailsForm
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.IsExternalTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ExpertTypeLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.EditExpertInfoBtn = new System.Windows.Forms.Button();
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProjectsForCurrentExpertGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsForCurrentExpertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(131, 38);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(131, 110);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // IsExternalTextBox
            // 
            this.IsExternalTextBox.Location = new System.Drawing.Point(131, 146);
            this.IsExternalTextBox.Name = "IsExternalTextBox";
            this.IsExternalTextBox.ReadOnly = true;
            this.IsExternalTextBox.Size = new System.Drawing.Size(100, 20);
            this.IsExternalTextBox.TabIndex = 2;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(131, 75);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.ReadOnly = true;
            this.MiddleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleNameTextBox.TabIndex = 3;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(34, 41);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "Име";
            // 
            // ExpertTypeLabel
            // 
            this.ExpertTypeLabel.AutoSize = true;
            this.ExpertTypeLabel.Location = new System.Drawing.Point(34, 149);
            this.ExpertTypeLabel.Name = "ExpertTypeLabel";
            this.ExpertTypeLabel.Size = new System.Drawing.Size(91, 13);
            this.ExpertTypeLabel.TabIndex = 5;
            this.ExpertTypeLabel.Text = "Тип на екснерта";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(34, 110);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(34, 75);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(53, 13);
            this.MiddleNameLabel.TabIndex = 7;
            this.MiddleNameLabel.Text = "Презиме";
            // 
            // EditExpertInfoBtn
            // 
            this.EditExpertInfoBtn.Location = new System.Drawing.Point(37, 206);
            this.EditExpertInfoBtn.Name = "EditExpertInfoBtn";
            this.EditExpertInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.EditExpertInfoBtn.TabIndex = 8;
            this.EditExpertInfoBtn.Text = "Редактирай";
            this.EditExpertInfoBtn.UseVisualStyleBackColor = true;
            this.EditExpertInfoBtn.Click += new System.EventHandler(this.EditExpertInfoBtn_Click);
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Location = new System.Drawing.Point(156, 206);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveChangesBtn.TabIndex = 9;
            this.SaveChangesBtn.Text = "Запази промените";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            this.SaveChangesBtn.Visible = false;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProjectsForCurrentExpertGrid);
            this.panel1.Location = new System.Drawing.Point(263, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 204);
            this.panel1.TabIndex = 10;
            // 
            // ProjectsForCurrentExpertGrid
            // 
            this.ProjectsForCurrentExpertGrid.AllowUserToAddRows = false;
            this.ProjectsForCurrentExpertGrid.AllowUserToDeleteRows = false;
            this.ProjectsForCurrentExpertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsForCurrentExpertGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsForCurrentExpertGrid.Location = new System.Drawing.Point(0, 0);
            this.ProjectsForCurrentExpertGrid.Name = "ProjectsForCurrentExpertGrid";
            this.ProjectsForCurrentExpertGrid.ReadOnly = true;
            this.ProjectsForCurrentExpertGrid.Size = new System.Drawing.Size(480, 204);
            this.ProjectsForCurrentExpertGrid.TabIndex = 0;
            // 
            // ExpertDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveChangesBtn);
            this.Controls.Add(this.EditExpertInfoBtn);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.ExpertTypeLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.IsExternalTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Name = "ExpertDetailsForm";
            this.Text = "ExpertDetailsForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsForCurrentExpertGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox IsExternalTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label ExpertTypeLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Button EditExpertInfoBtn;
        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ProjectsForCurrentExpertGrid;
    }
}