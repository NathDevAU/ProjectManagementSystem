namespace ProjectManagement
{
    partial class ProjectDetailsForm
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
            this.TasksGrpB = new System.Windows.Forms.GroupBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.TasksGV = new System.Windows.Forms.DataGridView();
            this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRemainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.taskVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelNewClientBtn = new System.Windows.Forms.Button();
            this.ClientTb = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.HoursCountTb = new System.Windows.Forms.MaskedTextBox();
            this.RegisterNewClientBtn = new System.Windows.Forms.Button();
            this.ProjectClientComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectClientLabel = new System.Windows.Forms.Label();
            this.EditDetailsBtn = new System.Windows.Forms.Button();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.CostSoFarTb = new System.Windows.Forms.TextBox();
            this.TaskCountTb = new System.Windows.Forms.TextBox();
            this.CurrentProjectCostLabel = new System.Windows.Forms.Label();
            this.HoursCountLabel = new System.Windows.Forms.Label();
            this.TaskCountLabel = new System.Windows.Forms.Label();
            this.ChangeStatusBtn = new System.Windows.Forms.Button();
            this.StatusDdl = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PayPerHourTextBox = new System.Windows.Forms.TextBox();
            this.ProjectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ProjectEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectStartDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectIdTextBox = new System.Windows.Forms.TextBox();
            this.PayPerHourLabel = new System.Windows.Forms.Label();
            this.ProjectStartDateLabel = new System.Windows.Forms.Label();
            this.ProjectEndDateLabel = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectDescriptionLabel = new System.Windows.Forms.Label();
            this.ProjectIdLabel = new System.Windows.Forms.Label();
            this.TasksGrpB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskVMBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TasksGrpB
            // 
            this.TasksGrpB.Controls.Add(this.CloseBtn);
            this.TasksGrpB.Controls.Add(this.AddTaskBtn);
            this.TasksGrpB.Controls.Add(this.TasksGV);
            this.TasksGrpB.Location = new System.Drawing.Point(438, 12);
            this.TasksGrpB.Name = "TasksGrpB";
            this.TasksGrpB.Size = new System.Drawing.Size(458, 469);
            this.TasksGrpB.TabIndex = 44;
            this.TasksGrpB.TabStop = false;
            this.TasksGrpB.Text = "Задачи";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(275, 436);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(177, 23);
            this.CloseBtn.TabIndex = 70;
            this.CloseBtn.Text = "Затвори Формата";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Location = new System.Drawing.Point(6, 436);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(182, 23);
            this.AddTaskBtn.TabIndex = 69;
            this.AddTaskBtn.Text = "Добавяне на нова задача";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // TasksGV
            // 
            this.TasksGV.AutoGenerateColumns = false;
            this.TasksGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIdDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.timeRemainingDataGridViewTextBoxColumn,
            this.delayDataGridViewTextBoxColumn,
            this.DetailsBtnCol});
            this.TasksGV.DataSource = this.taskVMBindingSource;
            this.TasksGV.Location = new System.Drawing.Point(6, 14);
            this.TasksGV.Name = "TasksGV";
            this.TasksGV.ReadOnly = true;
            this.TasksGV.Size = new System.Drawing.Size(446, 409);
            this.TasksGV.TabIndex = 0;
            this.TasksGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGV_CellContentClick);
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            this.taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "TaskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "Задача";
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeRemainingDataGridViewTextBoxColumn
            // 
            this.timeRemainingDataGridViewTextBoxColumn.DataPropertyName = "TimeRemaining";
            this.timeRemainingDataGridViewTextBoxColumn.HeaderText = "Оставащо време";
            this.timeRemainingDataGridViewTextBoxColumn.Name = "timeRemainingDataGridViewTextBoxColumn";
            this.timeRemainingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delayDataGridViewTextBoxColumn
            // 
            this.delayDataGridViewTextBoxColumn.DataPropertyName = "Delay";
            this.delayDataGridViewTextBoxColumn.HeaderText = "Закъснение";
            this.delayDataGridViewTextBoxColumn.Name = "delayDataGridViewTextBoxColumn";
            this.delayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DetailsBtnCol
            // 
            this.DetailsBtnCol.HeaderText = "Детайли";
            this.DetailsBtnCol.Name = "DetailsBtnCol";
            this.DetailsBtnCol.ReadOnly = true;
            this.DetailsBtnCol.Text = "Детайли";
            this.DetailsBtnCol.UseColumnTextForButtonValue = true;
            // 
            // taskVMBindingSource
            // 
            this.taskVMBindingSource.DataSource = typeof(ProjectManagement.ViewModels.TaskVM);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelNewClientBtn);
            this.panel1.Controls.Add(this.ClientTb);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.HoursCountTb);
            this.panel1.Controls.Add(this.RegisterNewClientBtn);
            this.panel1.Controls.Add(this.ProjectClientComboBox);
            this.panel1.Controls.Add(this.ProjectClientLabel);
            this.panel1.Controls.Add(this.EditDetailsBtn);
            this.panel1.Controls.Add(this.CurrencyLabel);
            this.panel1.Controls.Add(this.CostSoFarTb);
            this.panel1.Controls.Add(this.TaskCountTb);
            this.panel1.Controls.Add(this.CurrentProjectCostLabel);
            this.panel1.Controls.Add(this.HoursCountLabel);
            this.panel1.Controls.Add(this.TaskCountLabel);
            this.panel1.Controls.Add(this.ChangeStatusBtn);
            this.panel1.Controls.Add(this.StatusDdl);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.PayPerHourTextBox);
            this.panel1.Controls.Add(this.ProjectDescriptionTextBox);
            this.panel1.Controls.Add(this.ProjectEndDatePicker);
            this.panel1.Controls.Add(this.ProjectStartDateDatePicker);
            this.panel1.Controls.Add(this.ProjectNameTextBox);
            this.panel1.Controls.Add(this.ProjectIdTextBox);
            this.panel1.Controls.Add(this.PayPerHourLabel);
            this.panel1.Controls.Add(this.ProjectStartDateLabel);
            this.panel1.Controls.Add(this.ProjectEndDateLabel);
            this.panel1.Controls.Add(this.ProjectNameLabel);
            this.panel1.Controls.Add(this.ProjectDescriptionLabel);
            this.panel1.Controls.Add(this.ProjectIdLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 469);
            this.panel1.TabIndex = 45;
            // 
            // CancelNewClientBtn
            // 
            this.CancelNewClientBtn.Location = new System.Drawing.Point(373, 230);
            this.CancelNewClientBtn.Name = "CancelNewClientBtn";
            this.CancelNewClientBtn.Size = new System.Drawing.Size(47, 21);
            this.CancelNewClientBtn.TabIndex = 75;
            this.CancelNewClientBtn.Text = "Отказ";
            this.CancelNewClientBtn.UseVisualStyleBackColor = true;
            this.CancelNewClientBtn.Click += new System.EventHandler(this.CancelNewClientBtn_Click);
            // 
            // ClientTb
            // 
            this.ClientTb.Location = new System.Drawing.Point(135, 231);
            this.ClientTb.Name = "ClientTb";
            this.ClientTb.Size = new System.Drawing.Size(176, 20);
            this.ClientTb.TabIndex = 74;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(135, 439);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(133, 23);
            this.SaveBtn.TabIndex = 73;
            this.SaveBtn.Text = "Запазване";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // HoursCountTb
            // 
            this.HoursCountTb.Enabled = false;
            this.HoursCountTb.Location = new System.Drawing.Point(135, 385);
            this.HoursCountTb.Mask = "00:00";
            this.HoursCountTb.Name = "HoursCountTb";
            this.HoursCountTb.Size = new System.Drawing.Size(176, 20);
            this.HoursCountTb.TabIndex = 72;
            this.HoursCountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HoursCountTb.ValidatingType = typeof(System.DateTime);
            // 
            // RegisterNewClientBtn
            // 
            this.RegisterNewClientBtn.Enabled = false;
            this.RegisterNewClientBtn.Location = new System.Drawing.Point(317, 230);
            this.RegisterNewClientBtn.Name = "RegisterNewClientBtn";
            this.RegisterNewClientBtn.Size = new System.Drawing.Size(53, 21);
            this.RegisterNewClientBtn.TabIndex = 71;
            this.RegisterNewClientBtn.Text = "Нов";
            this.RegisterNewClientBtn.UseVisualStyleBackColor = true;
            this.RegisterNewClientBtn.Visible = false;
            this.RegisterNewClientBtn.Click += new System.EventHandler(this.RegisterNewClientBtn_Click);
            // 
            // ProjectClientComboBox
            // 
            this.ProjectClientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectClientComboBox.Enabled = false;
            this.ProjectClientComboBox.FormattingEnabled = true;
            this.ProjectClientComboBox.Location = new System.Drawing.Point(135, 230);
            this.ProjectClientComboBox.Name = "ProjectClientComboBox";
            this.ProjectClientComboBox.Size = new System.Drawing.Size(176, 21);
            this.ProjectClientComboBox.TabIndex = 70;
            // 
            // ProjectClientLabel
            // 
            this.ProjectClientLabel.AutoSize = true;
            this.ProjectClientLabel.Location = new System.Drawing.Point(13, 231);
            this.ProjectClientLabel.Name = "ProjectClientLabel";
            this.ProjectClientLabel.Size = new System.Drawing.Size(102, 13);
            this.ProjectClientLabel.TabIndex = 69;
            this.ProjectClientLabel.Text = "Клиент на проекта";
            // 
            // EditDetailsBtn
            // 
            this.EditDetailsBtn.Location = new System.Drawing.Point(274, 439);
            this.EditDetailsBtn.Name = "EditDetailsBtn";
            this.EditDetailsBtn.Size = new System.Drawing.Size(143, 23);
            this.EditDetailsBtn.TabIndex = 68;
            this.EditDetailsBtn.Text = "Редактиране на проекта";
            this.EditDetailsBtn.UseVisualStyleBackColor = true;
            this.EditDetailsBtn.Click += new System.EventHandler(this.EditDetailsBtn_Click);
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(317, 417);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(22, 13);
            this.CurrencyLabel.TabIndex = 67;
            this.CurrencyLabel.Text = "лв.";
            // 
            // CostSoFarTb
            // 
            this.CostSoFarTb.Enabled = false;
            this.CostSoFarTb.Location = new System.Drawing.Point(135, 410);
            this.CostSoFarTb.Name = "CostSoFarTb";
            this.CostSoFarTb.Size = new System.Drawing.Size(176, 20);
            this.CostSoFarTb.TabIndex = 66;
            this.CostSoFarTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TaskCountTb
            // 
            this.TaskCountTb.Enabled = false;
            this.TaskCountTb.Location = new System.Drawing.Point(135, 352);
            this.TaskCountTb.Name = "TaskCountTb";
            this.TaskCountTb.Size = new System.Drawing.Size(176, 20);
            this.TaskCountTb.TabIndex = 64;
            this.TaskCountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurrentProjectCostLabel
            // 
            this.CurrentProjectCostLabel.AutoSize = true;
            this.CurrentProjectCostLabel.Location = new System.Drawing.Point(13, 410);
            this.CurrentProjectCostLabel.Name = "CurrentProjectCostLabel";
            this.CurrentProjectCostLabel.Size = new System.Drawing.Size(112, 13);
            this.CurrentProjectCostLabel.TabIndex = 63;
            this.CurrentProjectCostLabel.Text = "Разходи до момента";
            // 
            // HoursCountLabel
            // 
            this.HoursCountLabel.AutoSize = true;
            this.HoursCountLabel.Location = new System.Drawing.Point(13, 385);
            this.HoursCountLabel.Name = "HoursCountLabel";
            this.HoursCountLabel.Size = new System.Drawing.Size(105, 13);
            this.HoursCountLabel.TabIndex = 62;
            this.HoursCountLabel.Text = "Отработени часове";
            // 
            // TaskCountLabel
            // 
            this.TaskCountLabel.AutoSize = true;
            this.TaskCountLabel.Location = new System.Drawing.Point(13, 352);
            this.TaskCountLabel.Name = "TaskCountLabel";
            this.TaskCountLabel.Size = new System.Drawing.Size(70, 13);
            this.TaskCountLabel.TabIndex = 61;
            this.TaskCountLabel.Text = "Брой задачи";
            // 
            // ChangeStatusBtn
            // 
            this.ChangeStatusBtn.Location = new System.Drawing.Point(317, 69);
            this.ChangeStatusBtn.Name = "ChangeStatusBtn";
            this.ChangeStatusBtn.Size = new System.Drawing.Size(89, 23);
            this.ChangeStatusBtn.TabIndex = 60;
            this.ChangeStatusBtn.Text = "Промени";
            this.ChangeStatusBtn.UseVisualStyleBackColor = true;
            this.ChangeStatusBtn.Click += new System.EventHandler(this.ChangeStatusBtn_Click);
            // 
            // StatusDdl
            // 
            this.StatusDdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusDdl.FormattingEnabled = true;
            this.StatusDdl.Location = new System.Drawing.Point(135, 69);
            this.StatusDdl.Name = "StatusDdl";
            this.StatusDdl.Size = new System.Drawing.Size(176, 21);
            this.StatusDdl.TabIndex = 59;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 69);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(41, 13);
            this.StatusLabel.TabIndex = 58;
            this.StatusLabel.Text = "Статус";
            // 
            // PayPerHourTextBox
            // 
            this.PayPerHourTextBox.Enabled = false;
            this.PayPerHourTextBox.Location = new System.Drawing.Point(135, 320);
            this.PayPerHourTextBox.Name = "PayPerHourTextBox";
            this.PayPerHourTextBox.Size = new System.Drawing.Size(176, 20);
            this.PayPerHourTextBox.TabIndex = 56;
            // 
            // ProjectDescriptionTextBox
            // 
            this.ProjectDescriptionTextBox.Enabled = false;
            this.ProjectDescriptionTextBox.Location = new System.Drawing.Point(135, 104);
            this.ProjectDescriptionTextBox.Multiline = true;
            this.ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox";
            this.ProjectDescriptionTextBox.Size = new System.Drawing.Size(282, 118);
            this.ProjectDescriptionTextBox.TabIndex = 55;
            // 
            // ProjectEndDatePicker
            // 
            this.ProjectEndDatePicker.Enabled = false;
            this.ProjectEndDatePicker.Location = new System.Drawing.Point(135, 291);
            this.ProjectEndDatePicker.Name = "ProjectEndDatePicker";
            this.ProjectEndDatePicker.Size = new System.Drawing.Size(176, 20);
            this.ProjectEndDatePicker.TabIndex = 54;
            // 
            // ProjectStartDateDatePicker
            // 
            this.ProjectStartDateDatePicker.Enabled = false;
            this.ProjectStartDateDatePicker.Location = new System.Drawing.Point(135, 263);
            this.ProjectStartDateDatePicker.Name = "ProjectStartDateDatePicker";
            this.ProjectStartDateDatePicker.Size = new System.Drawing.Size(176, 20);
            this.ProjectStartDateDatePicker.TabIndex = 53;
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Enabled = false;
            this.ProjectNameTextBox.Location = new System.Drawing.Point(135, 17);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(176, 20);
            this.ProjectNameTextBox.TabIndex = 52;
            // 
            // ProjectIdTextBox
            // 
            this.ProjectIdTextBox.Enabled = false;
            this.ProjectIdTextBox.Location = new System.Drawing.Point(135, 43);
            this.ProjectIdTextBox.Name = "ProjectIdTextBox";
            this.ProjectIdTextBox.Size = new System.Drawing.Size(176, 20);
            this.ProjectIdTextBox.TabIndex = 51;
            // 
            // PayPerHourLabel
            // 
            this.PayPerHourLabel.AutoSize = true;
            this.PayPerHourLabel.Location = new System.Drawing.Point(13, 320);
            this.PayPerHourLabel.Name = "PayPerHourLabel";
            this.PayPerHourLabel.Size = new System.Drawing.Size(83, 13);
            this.PayPerHourLabel.TabIndex = 50;
            this.PayPerHourLabel.Text = "Часова ставка";
            // 
            // ProjectStartDateLabel
            // 
            this.ProjectStartDateLabel.AutoSize = true;
            this.ProjectStartDateLabel.Location = new System.Drawing.Point(13, 263);
            this.ProjectStartDateLabel.Name = "ProjectStartDateLabel";
            this.ProjectStartDateLabel.Size = new System.Drawing.Size(76, 13);
            this.ProjectStartDateLabel.TabIndex = 49;
            this.ProjectStartDateLabel.Text = "Начална дата";
            // 
            // ProjectEndDateLabel
            // 
            this.ProjectEndDateLabel.AutoSize = true;
            this.ProjectEndDateLabel.Location = new System.Drawing.Point(13, 291);
            this.ProjectEndDateLabel.Name = "ProjectEndDateLabel";
            this.ProjectEndDateLabel.Size = new System.Drawing.Size(70, 13);
            this.ProjectEndDateLabel.TabIndex = 48;
            this.ProjectEndDateLabel.Text = "Крайна дата";
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(13, 17);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(88, 13);
            this.ProjectNameLabel.TabIndex = 47;
            this.ProjectNameLabel.Text = "Име на проекта";
            // 
            // ProjectDescriptionLabel
            // 
            this.ProjectDescriptionLabel.AutoSize = true;
            this.ProjectDescriptionLabel.Location = new System.Drawing.Point(13, 107);
            this.ProjectDescriptionLabel.Name = "ProjectDescriptionLabel";
            this.ProjectDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.ProjectDescriptionLabel.TabIndex = 45;
            this.ProjectDescriptionLabel.Text = "Описание";
            // 
            // ProjectIdLabel
            // 
            this.ProjectIdLabel.AutoSize = true;
            this.ProjectIdLabel.Location = new System.Drawing.Point(13, 43);
            this.ProjectIdLabel.Name = "ProjectIdLabel";
            this.ProjectIdLabel.Size = new System.Drawing.Size(85, 13);
            this.ProjectIdLabel.TabIndex = 44;
            this.ProjectIdLabel.Text = "Код на проекта";
            // 
            // ProjectDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TasksGrpB);
            this.Name = "ProjectDetailsForm";
            this.Text = "Детайли на проект";
            this.Load += new System.EventHandler(this.ProjectDetailsForm_Load);
            this.TasksGrpB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TasksGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskVMBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox TasksGrpB;
        private System.Windows.Forms.DataGridView TasksGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditDetailsBtn;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.TextBox CostSoFarTb;
        private System.Windows.Forms.TextBox TaskCountTb;
        private System.Windows.Forms.Label CurrentProjectCostLabel;
        private System.Windows.Forms.Label HoursCountLabel;
        private System.Windows.Forms.Label TaskCountLabel;
        private System.Windows.Forms.Button ChangeStatusBtn;
        private System.Windows.Forms.ComboBox StatusDdl;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox PayPerHourTextBox;
        private System.Windows.Forms.TextBox ProjectDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker ProjectEndDatePicker;
        private System.Windows.Forms.DateTimePicker ProjectStartDateDatePicker;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.TextBox ProjectIdTextBox;
        private System.Windows.Forms.Label PayPerHourLabel;
        private System.Windows.Forms.Label ProjectStartDateLabel;
        private System.Windows.Forms.Label ProjectEndDateLabel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label ProjectDescriptionLabel;
        private System.Windows.Forms.Label ProjectIdLabel;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.Button RegisterNewClientBtn;
        private System.Windows.Forms.ComboBox ProjectClientComboBox;
        private System.Windows.Forms.Label ProjectClientLabel;
        private System.Windows.Forms.MaskedTextBox HoursCountTb;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.BindingSource taskVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeRemainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsBtnCol;
        private System.Windows.Forms.TextBox ClientTb;
        private System.Windows.Forms.Button CancelNewClientBtn;
    }
}