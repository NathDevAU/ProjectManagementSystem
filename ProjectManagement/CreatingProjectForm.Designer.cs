namespace ProjectManagement
{
    partial class CreatingProjectForm
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
            this.ProjectIdLabel = new System.Windows.Forms.Label();
            this.ProjectDescriptionLabel = new System.Windows.Forms.Label();
            this.ProjectClientLabel = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectEndDateLabel = new System.Windows.Forms.Label();
            this.ProjectStartDateLabel = new System.Windows.Forms.Label();
            this.PayPerHourLabel = new System.Windows.Forms.Label();
            this.ProjectIdTextBox = new System.Windows.Forms.TextBox();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectStartDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ProjectClientComboBox = new System.Windows.Forms.ComboBox();
            this.RegisterNewClientBtn = new System.Windows.Forms.Button();
            this.PayPerHourTextBox = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectIdLabel
            // 
            this.ProjectIdLabel.AutoSize = true;
            this.ProjectIdLabel.Location = new System.Drawing.Point(27, 22);
            this.ProjectIdLabel.Name = "ProjectIdLabel";
            this.ProjectIdLabel.Size = new System.Drawing.Size(85, 13);
            this.ProjectIdLabel.TabIndex = 0;
            this.ProjectIdLabel.Text = "Код на проекта";
            // 
            // ProjectDescriptionLabel
            // 
            this.ProjectDescriptionLabel.AutoSize = true;
            this.ProjectDescriptionLabel.Location = new System.Drawing.Point(27, 98);
            this.ProjectDescriptionLabel.Name = "ProjectDescriptionLabel";
            this.ProjectDescriptionLabel.Size = new System.Drawing.Size(116, 13);
            this.ProjectDescriptionLabel.TabIndex = 1;
            this.ProjectDescriptionLabel.Text = "Описание на проекта";
            // 
            // ProjectClientLabel
            // 
            this.ProjectClientLabel.AutoSize = true;
            this.ProjectClientLabel.Location = new System.Drawing.Point(27, 191);
            this.ProjectClientLabel.Name = "ProjectClientLabel";
            this.ProjectClientLabel.Size = new System.Drawing.Size(102, 13);
            this.ProjectClientLabel.TabIndex = 2;
            this.ProjectClientLabel.Text = "Клиент на проекта";
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(27, 58);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(88, 13);
            this.ProjectNameLabel.TabIndex = 3;
            this.ProjectNameLabel.Text = "Име на проекта";
            // 
            // ProjectEndDateLabel
            // 
            this.ProjectEndDateLabel.AutoSize = true;
            this.ProjectEndDateLabel.Location = new System.Drawing.Point(361, 289);
            this.ProjectEndDateLabel.Name = "ProjectEndDateLabel";
            this.ProjectEndDateLabel.Size = new System.Drawing.Size(129, 13);
            this.ProjectEndDateLabel.TabIndex = 4;
            this.ProjectEndDateLabel.Text = "Крайна дата на проекта";
            // 
            // ProjectStartDateLabel
            // 
            this.ProjectStartDateLabel.AutoSize = true;
            this.ProjectStartDateLabel.Location = new System.Drawing.Point(27, 289);
            this.ProjectStartDateLabel.Name = "ProjectStartDateLabel";
            this.ProjectStartDateLabel.Size = new System.Drawing.Size(135, 13);
            this.ProjectStartDateLabel.TabIndex = 5;
            this.ProjectStartDateLabel.Text = "Начална дата на проекта";
            // 
            // PayPerHourLabel
            // 
            this.PayPerHourLabel.AutoSize = true;
            this.PayPerHourLabel.Location = new System.Drawing.Point(27, 246);
            this.PayPerHourLabel.Name = "PayPerHourLabel";
            this.PayPerHourLabel.Size = new System.Drawing.Size(83, 13);
            this.PayPerHourLabel.TabIndex = 6;
            this.PayPerHourLabel.Text = "Часова ставка";
            // 
            // ProjectIdTextBox
            // 
            this.ProjectIdTextBox.Location = new System.Drawing.Point(168, 22);
            this.ProjectIdTextBox.Name = "ProjectIdTextBox";
            this.ProjectIdTextBox.Size = new System.Drawing.Size(207, 20);
            this.ProjectIdTextBox.TabIndex = 7;
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(168, 58);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(207, 20);
            this.ProjectNameTextBox.TabIndex = 11;
            // 
            // ProjectStartDateDatePicker
            // 
            this.ProjectStartDateDatePicker.Location = new System.Drawing.Point(168, 283);
            this.ProjectStartDateDatePicker.Name = "ProjectStartDateDatePicker";
            this.ProjectStartDateDatePicker.Size = new System.Drawing.Size(172, 20);
            this.ProjectStartDateDatePicker.TabIndex = 12;
            // 
            // ProjectEndDatePicker
            // 
            this.ProjectEndDatePicker.Location = new System.Drawing.Point(496, 283);
            this.ProjectEndDatePicker.Name = "ProjectEndDatePicker";
            this.ProjectEndDatePicker.Size = new System.Drawing.Size(154, 20);
            this.ProjectEndDatePicker.TabIndex = 13;
            // 
            // ProjectDescriptionTextBox
            // 
            this.ProjectDescriptionTextBox.Location = new System.Drawing.Point(168, 95);
            this.ProjectDescriptionTextBox.Multiline = true;
            this.ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox";
            this.ProjectDescriptionTextBox.Size = new System.Drawing.Size(375, 78);
            this.ProjectDescriptionTextBox.TabIndex = 14;
            // 
            // ProjectClientComboBox
            // 
            this.ProjectClientComboBox.FormattingEnabled = true;
            this.ProjectClientComboBox.Location = new System.Drawing.Point(168, 191);
            this.ProjectClientComboBox.Name = "ProjectClientComboBox";
            this.ProjectClientComboBox.Size = new System.Drawing.Size(212, 21);
            this.ProjectClientComboBox.TabIndex = 15;
            // 
            // RegisterNewClientBtn
            // 
            this.RegisterNewClientBtn.Location = new System.Drawing.Point(386, 189);
            this.RegisterNewClientBtn.Name = "RegisterNewClientBtn";
            this.RegisterNewClientBtn.Size = new System.Drawing.Size(157, 23);
            this.RegisterNewClientBtn.TabIndex = 16;
            this.RegisterNewClientBtn.Text = "Регистрация на нов клиент";
            this.RegisterNewClientBtn.UseVisualStyleBackColor = true;
            // 
            // PayPerHourTextBox
            // 
            this.PayPerHourTextBox.Location = new System.Drawing.Point(168, 246);
            this.PayPerHourTextBox.Name = "PayPerHourTextBox";
            this.PayPerHourTextBox.Size = new System.Drawing.Size(100, 20);
            this.PayPerHourTextBox.TabIndex = 17;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(494, 357);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 18;
            this.buttonCreate.Text = "Създай";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(575, 357);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Затвори";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(274, 253);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(22, 13);
            this.CurrencyLabel.TabIndex = 20;
            this.CurrencyLabel.Text = "лв.";
            // 
            // CreatingProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 392);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.PayPerHourTextBox);
            this.Controls.Add(this.RegisterNewClientBtn);
            this.Controls.Add(this.ProjectClientComboBox);
            this.Controls.Add(this.ProjectDescriptionTextBox);
            this.Controls.Add(this.ProjectEndDatePicker);
            this.Controls.Add(this.ProjectStartDateDatePicker);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.ProjectIdTextBox);
            this.Controls.Add(this.PayPerHourLabel);
            this.Controls.Add(this.ProjectStartDateLabel);
            this.Controls.Add(this.ProjectEndDateLabel);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.ProjectClientLabel);
            this.Controls.Add(this.ProjectDescriptionLabel);
            this.Controls.Add(this.ProjectIdLabel);
            this.Name = "CreatingProjectForm";
            this.Text = "Създаване на нов проект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectIdLabel;
        private System.Windows.Forms.Label ProjectDescriptionLabel;
        private System.Windows.Forms.Label ProjectClientLabel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label ProjectEndDateLabel;
        private System.Windows.Forms.Label ProjectStartDateLabel;
        private System.Windows.Forms.Label PayPerHourLabel;
        private System.Windows.Forms.TextBox ProjectIdTextBox;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.DateTimePicker ProjectStartDateDatePicker;
        private System.Windows.Forms.DateTimePicker ProjectEndDatePicker;
        private System.Windows.Forms.TextBox ProjectDescriptionTextBox;
        private System.Windows.Forms.ComboBox ProjectClientComboBox;
        private System.Windows.Forms.Button RegisterNewClientBtn;
        private System.Windows.Forms.TextBox PayPerHourTextBox;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label CurrencyLabel;
    }
}