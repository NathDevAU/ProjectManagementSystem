namespace ProjectManagement
{
    partial class CreatingTaskForm
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
            this.task_name = new System.Windows.Forms.Label();
            this.task_Name_TB = new System.Windows.Forms.TextBox();
            this.task_result = new System.Windows.Forms.Label();
            this.task_description = new System.Windows.Forms.Label();
            this.task_begin = new System.Windows.Forms.Label();
            this.task_priority = new System.Windows.Forms.Label();
            this.taskStartDate = new System.Windows.Forms.DateTimePicker();
            this.task_end = new System.Windows.Forms.Label();
            this.taskEndDate = new System.Windows.Forms.DateTimePicker();
            this.task_Priority_CB = new System.Windows.Forms.ComboBox();
            this.task_comment = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.task_Description_RTB = new System.Windows.Forms.RichTextBox();
            this.TaskForProjectLabel = new System.Windows.Forms.Label();
            this.task_Project_TB = new System.Windows.Forms.TextBox();
            this.task_Result_RTB = new System.Windows.Forms.RichTextBox();
            this.task_comment_RTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // task_name
            // 
            this.task_name.AutoSize = true;
            this.task_name.Location = new System.Drawing.Point(29, 23);
            this.task_name.Name = "task_name";
            this.task_name.Size = new System.Drawing.Size(136, 13);
            this.task_name.TabIndex = 0;
            this.task_name.Text = "Наименование на задача";
            // 
            // task_Name_TB
            // 
            this.task_Name_TB.Location = new System.Drawing.Point(227, 23);
            this.task_Name_TB.Name = "task_Name_TB";
            this.task_Name_TB.Size = new System.Drawing.Size(215, 20);
            this.task_Name_TB.TabIndex = 1;
            // 
            // task_result
            // 
            this.task_result.AutoSize = true;
            this.task_result.Location = new System.Drawing.Point(29, 220);
            this.task_result.Name = "task_result";
            this.task_result.Size = new System.Drawing.Size(184, 13);
            this.task_result.TabIndex = 2;
            this.task_result.Text = "Резултат от изпълнение на задача";
            // 
            // task_description
            // 
            this.task_description.AutoSize = true;
            this.task_description.Location = new System.Drawing.Point(29, 125);
            this.task_description.Name = "task_description";
            this.task_description.Size = new System.Drawing.Size(110, 13);
            this.task_description.TabIndex = 3;
            this.task_description.Text = "Описание на задача";
            // 
            // task_begin
            // 
            this.task_begin.AutoSize = true;
            this.task_begin.Location = new System.Drawing.Point(25, 415);
            this.task_begin.Name = "task_begin";
            this.task_begin.Size = new System.Drawing.Size(97, 13);
            this.task_begin.TabIndex = 4;
            this.task_begin.Text = "Начало на задача";
            // 
            // task_priority
            // 
            this.task_priority.AutoSize = true;
            this.task_priority.Location = new System.Drawing.Point(29, 80);
            this.task_priority.Name = "task_priority";
            this.task_priority.Size = new System.Drawing.Size(114, 13);
            this.task_priority.TabIndex = 5;
            this.task_priority.Text = "Приоритет на задача";
            // 
            // taskStartDate
            // 
            this.taskStartDate.Location = new System.Drawing.Point(28, 440);
            this.taskStartDate.Name = "taskStartDate";
            this.taskStartDate.Size = new System.Drawing.Size(172, 20);
            this.taskStartDate.TabIndex = 17;
            // 
            // task_end
            // 
            this.task_end.AutoSize = true;
            this.task_end.Location = new System.Drawing.Point(431, 415);
            this.task_end.Name = "task_end";
            this.task_end.Size = new System.Drawing.Size(85, 13);
            this.task_end.TabIndex = 18;
            this.task_end.Text = "Край на задача";
            // 
            // taskEndDate
            // 
            this.taskEndDate.Location = new System.Drawing.Point(344, 440);
            this.taskEndDate.Name = "taskEndDate";
            this.taskEndDate.Size = new System.Drawing.Size(172, 20);
            this.taskEndDate.TabIndex = 19;
            // 
            // task_Priority_CB
            // 
            this.task_Priority_CB.FormattingEnabled = true;
            this.task_Priority_CB.Items.AddRange(new object[] {
            "Висок",
            "Среден",
            "Нисък"});
            this.task_Priority_CB.Location = new System.Drawing.Point(227, 80);
            this.task_Priority_CB.Name = "task_Priority_CB";
            this.task_Priority_CB.Size = new System.Drawing.Size(215, 21);
            this.task_Priority_CB.TabIndex = 20;
            this.task_Priority_CB.SelectedIndexChanged += new System.EventHandler(this.ExpertTypeDropDown_SelectedIndexChanged);
            // 
            // task_comment
            // 
            this.task_comment.AutoSize = true;
            this.task_comment.Location = new System.Drawing.Point(29, 319);
            this.task_comment.Name = "task_comment";
            this.task_comment.Size = new System.Drawing.Size(57, 13);
            this.task_comment.TabIndex = 28;
            this.task_comment.Text = "Коментар";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(371, 626);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(64, 28);
            this.Create.TabIndex = 30;
            this.Create.Text = "Създай";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(452, 626);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(64, 28);
            this.Close.TabIndex = 31;
            this.Close.Text = "Затвори";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // task_Description_RTB
            // 
            this.task_Description_RTB.Location = new System.Drawing.Point(227, 122);
            this.task_Description_RTB.Name = "task_Description_RTB";
            this.task_Description_RTB.Size = new System.Drawing.Size(289, 83);
            this.task_Description_RTB.TabIndex = 34;
            this.task_Description_RTB.Text = "";
            // 
            // TaskForProjectLabel
            // 
            this.TaskForProjectLabel.AutoSize = true;
            this.TaskForProjectLabel.Location = new System.Drawing.Point(29, 52);
            this.TaskForProjectLabel.Name = "TaskForProjectLabel";
            this.TaskForProjectLabel.Size = new System.Drawing.Size(67, 13);
            this.TaskForProjectLabel.TabIndex = 35;
            this.TaskForProjectLabel.Text = "Към проект";
            // 
            // task_Project_TB
            // 
            this.task_Project_TB.Enabled = false;
            this.task_Project_TB.Location = new System.Drawing.Point(227, 52);
            this.task_Project_TB.Name = "task_Project_TB";
            this.task_Project_TB.Size = new System.Drawing.Size(215, 20);
            this.task_Project_TB.TabIndex = 36;
            // 
            // task_Result_RTB
            // 
            this.task_Result_RTB.Location = new System.Drawing.Point(227, 220);
            this.task_Result_RTB.Name = "task_Result_RTB";
            this.task_Result_RTB.Size = new System.Drawing.Size(289, 83);
            this.task_Result_RTB.TabIndex = 37;
            this.task_Result_RTB.Text = "";
            // 
            // task_comment_RTB
            // 
            this.task_comment_RTB.Location = new System.Drawing.Point(227, 319);
            this.task_comment_RTB.Name = "task_comment_RTB";
            this.task_comment_RTB.Size = new System.Drawing.Size(289, 83);
            this.task_comment_RTB.TabIndex = 38;
            this.task_comment_RTB.Text = "";
            // 
            // CreatingTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 656);
            this.Controls.Add(this.task_comment_RTB);
            this.Controls.Add(this.task_Result_RTB);
            this.Controls.Add(this.task_Project_TB);
            this.Controls.Add(this.TaskForProjectLabel);
            this.Controls.Add(this.task_Description_RTB);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.task_comment);
            this.Controls.Add(this.task_Priority_CB);
            this.Controls.Add(this.taskEndDate);
            this.Controls.Add(this.task_end);
            this.Controls.Add(this.taskStartDate);
            this.Controls.Add(this.task_priority);
            this.Controls.Add(this.task_begin);
            this.Controls.Add(this.task_description);
            this.Controls.Add(this.task_result);
            this.Controls.Add(this.task_Name_TB);
            this.Controls.Add(this.task_name);
            this.Name = "CreatingTaskForm";
            this.Text = "Създаване на задача";
            this.Load += new System.EventHandler(this.CreatingTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task_name;
        private System.Windows.Forms.TextBox task_Name_TB;
        private System.Windows.Forms.Label task_result;
        private System.Windows.Forms.Label task_description;
        private System.Windows.Forms.Label task_begin;
        private System.Windows.Forms.Label task_priority;
        private System.Windows.Forms.DateTimePicker taskStartDate;
        private System.Windows.Forms.Label task_end;
        private System.Windows.Forms.DateTimePicker taskEndDate;
        private System.Windows.Forms.ComboBox task_Priority_CB;
        private System.Windows.Forms.Label task_comment;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.RichTextBox task_Description_RTB;
        private System.Windows.Forms.Label TaskForProjectLabel;
        private System.Windows.Forms.TextBox task_Project_TB;
        private System.Windows.Forms.RichTextBox task_Result_RTB;
        private System.Windows.Forms.RichTextBox task_comment_RTB;
    }
}