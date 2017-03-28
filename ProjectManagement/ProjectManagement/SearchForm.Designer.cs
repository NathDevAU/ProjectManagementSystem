namespace ProjectManagement
{
    partial class SearchForm
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
            this.SearchFilterLabel = new System.Windows.Forms.Label();
            this.SearchFilterDropDown = new System.Windows.Forms.ComboBox();
            this.SearchFilterTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPayByHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchFilterLabel
            // 
            this.SearchFilterLabel.AutoSize = true;
            this.SearchFilterLabel.Location = new System.Drawing.Point(12, 25);
            this.SearchFilterLabel.Name = "SearchFilterLabel";
            this.SearchFilterLabel.Size = new System.Drawing.Size(57, 13);
            this.SearchFilterLabel.TabIndex = 0;
            this.SearchFilterLabel.Text = "Търси по:";
            // 
            // SearchFilterDropDown
            // 
            this.SearchFilterDropDown.FormattingEnabled = true;
            this.SearchFilterDropDown.Location = new System.Drawing.Point(75, 22);
            this.SearchFilterDropDown.Name = "SearchFilterDropDown";
            this.SearchFilterDropDown.Size = new System.Drawing.Size(121, 21);
            this.SearchFilterDropDown.TabIndex = 1;
            // 
            // SearchFilterTextBox
            // 
            this.SearchFilterTextBox.Location = new System.Drawing.Point(245, 25);
            this.SearchFilterTextBox.Name = "SearchFilterTextBox";
            this.SearchFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchFilterTextBox.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(377, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Търси";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectId,
            this.ProjectName,
            this.ProjectClient,
            this.ProjectStartDate,
            this.ProjectEndDate,
            this.ProjectStatus,
            this.ProjectPayByHour});
            this.dataGridView1.Location = new System.Drawing.Point(15, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 200);
            this.dataGridView1.TabIndex = 4;
            // 
            // ProjectId
            // 
            this.ProjectId.HeaderText = "Код на проекта";
            this.ProjectId.Name = "ProjectId";
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Има на проекта";
            this.ProjectName.Name = "ProjectName";
            // 
            // ProjectClient
            // 
            this.ProjectClient.HeaderText = "Клиент";
            this.ProjectClient.Name = "ProjectClient";
            // 
            // ProjectStartDate
            // 
            this.ProjectStartDate.HeaderText = "Начало на проекта";
            this.ProjectStartDate.Name = "ProjectStartDate";
            // 
            // ProjectEndDate
            // 
            this.ProjectEndDate.HeaderText = "Край на проекта";
            this.ProjectEndDate.Name = "ProjectEndDate";
            // 
            // ProjectStatus
            // 
            this.ProjectStatus.HeaderText = "Статус на проекта";
            this.ProjectStatus.Name = "ProjectStatus";
            // 
            // ProjectPayByHour
            // 
            this.ProjectPayByHour.HeaderText = "Часова ставка";
            this.ProjectPayByHour.Name = "ProjectPayByHour";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchFilterTextBox);
            this.Controls.Add(this.SearchFilterDropDown);
            this.Controls.Add(this.SearchFilterLabel);
            this.Name = "SearchForm";
            this.Text = "Търсене на проект";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchFilterLabel;
        private System.Windows.Forms.ComboBox SearchFilterDropDown;
        private System.Windows.Forms.TextBox SearchFilterTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPayByHour;
    }
}