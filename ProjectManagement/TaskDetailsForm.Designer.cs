namespace ProjectManagement
{
    partial class TaskDetailsForm
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
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.TaskNameTb = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.TaskProgressBar = new System.Windows.Forms.ProgressBar();
            this.TaskHoursLabel = new System.Windows.Forms.Label();
            this.ComentLabel = new System.Windows.Forms.Label();
            this.EditTasks = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.TaskDescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionRtb = new System.Windows.Forms.RichTextBox();
            this.ComentRtb = new System.Windows.Forms.RichTextBox();
            this.ResultRtb = new System.Windows.Forms.RichTextBox();
            this.TaskResultRtb = new System.Windows.Forms.Label();
            this.TaskHoursTb = new System.Windows.Forms.MaskedTextBox();
            this.TaskStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskStartDateLabel = new System.Windows.Forms.Label();
            this.TaskEndDateLabel = new System.Windows.Forms.Label();
            this.TaskExpertLabel = new System.Windows.Forms.Label();
            this.TaskExpertCb = new System.Windows.Forms.ComboBox();
            this.NewExpertBnt = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TaskForProjectLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.PriorityCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(24, 23);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(83, 13);
            this.TaskNameLabel.TabIndex = 1;
            this.TaskNameLabel.Text = "Наименование";
            // 
            // TaskNameTb
            // 
            this.TaskNameTb.Enabled = false;
            this.TaskNameTb.Location = new System.Drawing.Point(135, 20);
            this.TaskNameTb.Name = "TaskNameTb";
            this.TaskNameTb.Size = new System.Drawing.Size(256, 20);
            this.TaskNameTb.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(448, 57);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(94, 13);
            this.StatusLabel.TabIndex = 22;
            this.StatusLabel.Text = "Статус на задача";
            // 
            // StatusCb
            // 
            this.StatusCb.Enabled = false;
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Планирана",
            "Очаква одобрение",
            "Одобрена",
            "В изпълнение",
            "Отказана",
            "Изпълнена"});
            this.StatusCb.Location = new System.Drawing.Point(575, 57);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(141, 21);
            this.StatusCb.TabIndex = 23;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(17, 454);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(112, 13);
            this.ProgressLabel.TabIndex = 24;
            this.ProgressLabel.Text = "Готовност на задача";
            // 
            // TaskProgressBar
            // 
            this.TaskProgressBar.Location = new System.Drawing.Point(135, 454);
            this.TaskProgressBar.Name = "TaskProgressBar";
            this.TaskProgressBar.Size = new System.Drawing.Size(581, 23);
            this.TaskProgressBar.TabIndex = 26;
            // 
            // TaskHoursLabel
            // 
            this.TaskHoursLabel.AutoSize = true;
            this.TaskHoursLabel.Location = new System.Drawing.Point(448, 23);
            this.TaskHoursLabel.Name = "TaskHoursLabel";
            this.TaskHoursLabel.Size = new System.Drawing.Size(105, 13);
            this.TaskHoursLabel.TabIndex = 27;
            this.TaskHoursLabel.Text = "Отработени часове";
            // 
            // ComentLabel
            // 
            this.ComentLabel.AutoSize = true;
            this.ComentLabel.Location = new System.Drawing.Point(24, 258);
            this.ComentLabel.Name = "ComentLabel";
            this.ComentLabel.Size = new System.Drawing.Size(57, 13);
            this.ComentLabel.TabIndex = 29;
            this.ComentLabel.Text = "Коментар";
            // 
            // EditTasks
            // 
            this.EditTasks.Location = new System.Drawing.Point(548, 496);
            this.EditTasks.Name = "EditTasks";
            this.EditTasks.Size = new System.Drawing.Size(75, 37);
            this.EditTasks.TabIndex = 31;
            this.EditTasks.Text = "Редактирай";
            this.EditTasks.UseVisualStyleBackColor = true;
            this.EditTasks.Click += new System.EventHandler(this.EditTasks_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(641, 496);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 37);
            this.CloseBtn.TabIndex = 32;
            this.CloseBtn.Text = "Затвори";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // TaskDescriptionLabel
            // 
            this.TaskDescriptionLabel.AutoSize = true;
            this.TaskDescriptionLabel.Location = new System.Drawing.Point(24, 93);
            this.TaskDescriptionLabel.Name = "TaskDescriptionLabel";
            this.TaskDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.TaskDescriptionLabel.TabIndex = 33;
            this.TaskDescriptionLabel.Text = "Описание";
            // 
            // DescriptionRtb
            // 
            this.DescriptionRtb.Enabled = false;
            this.DescriptionRtb.Location = new System.Drawing.Point(135, 93);
            this.DescriptionRtb.Name = "DescriptionRtb";
            this.DescriptionRtb.Size = new System.Drawing.Size(256, 66);
            this.DescriptionRtb.TabIndex = 34;
            this.DescriptionRtb.Text = "";
            // 
            // ComentRtb
            // 
            this.ComentRtb.Enabled = false;
            this.ComentRtb.Location = new System.Drawing.Point(135, 258);
            this.ComentRtb.Name = "ComentRtb";
            this.ComentRtb.Size = new System.Drawing.Size(256, 66);
            this.ComentRtb.TabIndex = 35;
            this.ComentRtb.Text = "";
            // 
            // ResultRtb
            // 
            this.ResultRtb.Enabled = false;
            this.ResultRtb.Location = new System.Drawing.Point(135, 175);
            this.ResultRtb.Name = "ResultRtb";
            this.ResultRtb.Size = new System.Drawing.Size(256, 66);
            this.ResultRtb.TabIndex = 37;
            this.ResultRtb.Text = "";
            // 
            // TaskResultRtb
            // 
            this.TaskResultRtb.AutoSize = true;
            this.TaskResultRtb.Location = new System.Drawing.Point(24, 175);
            this.TaskResultRtb.Name = "TaskResultRtb";
            this.TaskResultRtb.Size = new System.Drawing.Size(98, 13);
            this.TaskResultRtb.TabIndex = 36;
            this.TaskResultRtb.Text = "Очакван резултат";
            // 
            // TaskHoursTb
            // 
            this.TaskHoursTb.Enabled = false;
            this.TaskHoursTb.Location = new System.Drawing.Point(575, 20);
            this.TaskHoursTb.Mask = "00:00";
            this.TaskHoursTb.Name = "TaskHoursTb";
            this.TaskHoursTb.Size = new System.Drawing.Size(141, 20);
            this.TaskHoursTb.TabIndex = 38;
            this.TaskHoursTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TaskHoursTb.ValidatingType = typeof(System.DateTime);
            // 
            // TaskStartDatePicker
            // 
            this.TaskStartDatePicker.Enabled = false;
            this.TaskStartDatePicker.Location = new System.Drawing.Point(575, 93);
            this.TaskStartDatePicker.Name = "TaskStartDatePicker";
            this.TaskStartDatePicker.Size = new System.Drawing.Size(141, 20);
            this.TaskStartDatePicker.TabIndex = 39;
            // 
            // TaskEndDatePicker
            // 
            this.TaskEndDatePicker.Enabled = false;
            this.TaskEndDatePicker.Location = new System.Drawing.Point(575, 269);
            this.TaskEndDatePicker.Name = "TaskEndDatePicker";
            this.TaskEndDatePicker.Size = new System.Drawing.Size(141, 20);
            this.TaskEndDatePicker.TabIndex = 40;
            // 
            // TaskStartDateLabel
            // 
            this.TaskStartDateLabel.AutoSize = true;
            this.TaskStartDateLabel.Location = new System.Drawing.Point(448, 93);
            this.TaskStartDateLabel.Name = "TaskStartDateLabel";
            this.TaskStartDateLabel.Size = new System.Drawing.Size(108, 13);
            this.TaskStartDateLabel.TabIndex = 41;
            this.TaskStartDateLabel.Text = "Начало на задачата";
            // 
            // TaskEndDateLabel
            // 
            this.TaskEndDateLabel.AutoSize = true;
            this.TaskEndDateLabel.Location = new System.Drawing.Point(457, 275);
            this.TaskEndDateLabel.Name = "TaskEndDateLabel";
            this.TaskEndDateLabel.Size = new System.Drawing.Size(96, 13);
            this.TaskEndDateLabel.TabIndex = 42;
            this.TaskEndDateLabel.Text = "Край на задачата";
            // 
            // TaskExpertLabel
            // 
            this.TaskExpertLabel.AutoSize = true;
            this.TaskExpertLabel.Location = new System.Drawing.Point(24, 341);
            this.TaskExpertLabel.Name = "TaskExpertLabel";
            this.TaskExpertLabel.Size = new System.Drawing.Size(69, 13);
            this.TaskExpertLabel.TabIndex = 43;
            this.TaskExpertLabel.Text = "Изпълнител";
            // 
            // TaskExpertCb
            // 
            this.TaskExpertCb.Enabled = false;
            this.TaskExpertCb.FormattingEnabled = true;
            this.TaskExpertCb.Location = new System.Drawing.Point(135, 341);
            this.TaskExpertCb.Name = "TaskExpertCb";
            this.TaskExpertCb.Size = new System.Drawing.Size(256, 21);
            this.TaskExpertCb.TabIndex = 44;
            // 
            // NewExpertBnt
            // 
            this.NewExpertBnt.Enabled = false;
            this.NewExpertBnt.Location = new System.Drawing.Point(226, 368);
            this.NewExpertBnt.Name = "NewExpertBnt";
            this.NewExpertBnt.Size = new System.Drawing.Size(165, 25);
            this.NewExpertBnt.TabIndex = 45;
            this.NewExpertBnt.Text = "Добавяне на нов изпълнител";
            this.NewExpertBnt.UseVisualStyleBackColor = true;
            this.NewExpertBnt.Visible = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(460, 496);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 37);
            this.SaveBtn.TabIndex = 46;
            this.SaveBtn.Text = "Запази";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TaskForProjectLabel
            // 
            this.TaskForProjectLabel.AutoSize = true;
            this.TaskForProjectLabel.Location = new System.Drawing.Point(24, 56);
            this.TaskForProjectLabel.Name = "TaskForProjectLabel";
            this.TaskForProjectLabel.Size = new System.Drawing.Size(67, 13);
            this.TaskForProjectLabel.TabIndex = 47;
            this.TaskForProjectLabel.Text = "Към проект";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(135, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 48;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Location = new System.Drawing.Point(24, 407);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(61, 13);
            this.PriorityLabel.TabIndex = 49;
            this.PriorityLabel.Text = "Приоритет";
            // 
            // PriorityCb
            // 
            this.PriorityCb.Enabled = false;
            this.PriorityCb.FormattingEnabled = true;
            this.PriorityCb.Items.AddRange(new object[] {
            "Висок",
            "Среден",
            "Нисък"});
            this.PriorityCb.Location = new System.Drawing.Point(135, 407);
            this.PriorityCb.Name = "PriorityCb";
            this.PriorityCb.Size = new System.Drawing.Size(256, 21);
            this.PriorityCb.TabIndex = 50;
            // 
            // TaskDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 545);
            this.Controls.Add(this.PriorityCb);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TaskForProjectLabel);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NewExpertBnt);
            this.Controls.Add(this.TaskExpertCb);
            this.Controls.Add(this.TaskExpertLabel);
            this.Controls.Add(this.TaskEndDateLabel);
            this.Controls.Add(this.TaskStartDateLabel);
            this.Controls.Add(this.TaskEndDatePicker);
            this.Controls.Add(this.TaskStartDatePicker);
            this.Controls.Add(this.TaskHoursTb);
            this.Controls.Add(this.ResultRtb);
            this.Controls.Add(this.TaskResultRtb);
            this.Controls.Add(this.ComentRtb);
            this.Controls.Add(this.DescriptionRtb);
            this.Controls.Add(this.TaskDescriptionLabel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.EditTasks);
            this.Controls.Add(this.ComentLabel);
            this.Controls.Add(this.TaskHoursLabel);
            this.Controls.Add(this.TaskProgressBar);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.TaskNameTb);
            this.Controls.Add(this.TaskNameLabel);
            this.Name = "TaskDetailsForm";
            this.Text = "Детайли на задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.TextBox TaskNameTb;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ProgressBar TaskProgressBar;
        private System.Windows.Forms.Label TaskHoursLabel;
        private System.Windows.Forms.Label ComentLabel;
        private System.Windows.Forms.Button EditTasks;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label TaskDescriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionRtb;
        private System.Windows.Forms.RichTextBox ComentRtb;
        private System.Windows.Forms.RichTextBox ResultRtb;
        private System.Windows.Forms.Label TaskResultRtb;
        private System.Windows.Forms.MaskedTextBox TaskHoursTb;
        private System.Windows.Forms.DateTimePicker TaskStartDatePicker;
        private System.Windows.Forms.DateTimePicker TaskEndDatePicker;
        private System.Windows.Forms.Label TaskStartDateLabel;
        private System.Windows.Forms.Label TaskEndDateLabel;
        private System.Windows.Forms.Label TaskExpertLabel;
        private System.Windows.Forms.ComboBox TaskExpertCb;
        private System.Windows.Forms.Button NewExpertBnt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label TaskForProjectLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.ComboBox PriorityCb;
    }
}