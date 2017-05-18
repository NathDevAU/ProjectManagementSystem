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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ApplyChangesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProjectsGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpertTypeDropDown = new System.Windows.Forms.ComboBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.projectVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payPerHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Презиме";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Enabled = false;
            this.FirstNameTextBox.Location = new System.Drawing.Point(95, 37);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Enabled = false;
            this.LastNameTextBox.Location = new System.Drawing.Point(95, 106);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Enabled = false;
            this.MiddleNameTextBox.Location = new System.Drawing.Point(95, 71);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.MiddleNameTextBox.TabIndex = 5;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(84, 192);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Редактирай";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ApplyChangesBtn
            // 
            this.ApplyChangesBtn.Location = new System.Drawing.Point(22, 192);
            this.ApplyChangesBtn.Name = "ApplyChangesBtn";
            this.ApplyChangesBtn.Size = new System.Drawing.Size(56, 23);
            this.ApplyChangesBtn.TabIndex = 7;
            this.ApplyChangesBtn.Text = "Запази промените";
            this.ApplyChangesBtn.UseVisualStyleBackColor = true;
            this.ApplyChangesBtn.Click += new System.EventHandler(this.ApplyChangesBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProjectsGV);
            this.panel1.Location = new System.Drawing.Point(246, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 286);
            this.panel1.TabIndex = 8;
            // 
            // ProjectsGV
            // 
            this.ProjectsGV.AutoGenerateColumns = false;
            this.ProjectsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.payPerHDataGridViewTextBoxColumn});
            this.ProjectsGV.DataSource = this.projectVMBindingSource;
            this.ProjectsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsGV.Location = new System.Drawing.Point(0, 0);
            this.ProjectsGV.Name = "ProjectsGV";
            this.ProjectsGV.Size = new System.Drawing.Size(744, 286);
            this.ProjectsGV.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип";
            // 
            // ExpertTypeDropDown
            // 
            this.ExpertTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpertTypeDropDown.Enabled = false;
            this.ExpertTypeDropDown.FormattingEnabled = true;
            this.ExpertTypeDropDown.Location = new System.Drawing.Point(95, 142);
            this.ExpertTypeDropDown.Name = "ExpertTypeDropDown";
            this.ExpertTypeDropDown.Size = new System.Drawing.Size(145, 21);
            this.ExpertTypeDropDown.TabIndex = 10;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(165, 192);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "Затвори";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // projectVMBindingSource
            // 
            this.projectVMBindingSource.DataSource = typeof(ProjectManagement.ViewModels.ProjectVM);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Начална дата";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Крайна дата";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // payPerHDataGridViewTextBoxColumn
            // 
            this.payPerHDataGridViewTextBoxColumn.DataPropertyName = "PayPerH";
            this.payPerHDataGridViewTextBoxColumn.HeaderText = "Часова ставка";
            this.payPerHDataGridViewTextBoxColumn.Name = "payPerHDataGridViewTextBoxColumn";
            // 
            // ExpertL
            // 
            this.ExpertL.AutoSize = true;
            this.ExpertL.Location = new System.Drawing.Point(246, 18);
            this.ExpertL.Name = "ExpertL";
            this.ExpertL.Size = new System.Drawing.Size(118, 13);
            this.ExpertL.TabIndex = 12;
            this.ExpertL.Text = "Проекти на експерта:";
            // 
            // ExpertDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 347);
            this.Controls.Add(this.ExpertL);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ExpertTypeDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ApplyChangesBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExpertDetailsForm";
            this.Text = "Детайли за експерт";
            this.Load += new System.EventHandler(this.ExpertDetailsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ApplyChangesBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ProjectsGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ExpertTypeDropDown;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payPerHDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectVMBindingSource;
        private System.Windows.Forms.Label ExpertL;
    }
}