namespace ProjectManagement
{
    partial class ExprertsRegisterForm
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
            this.ExpertNameLabel = new System.Windows.Forms.Label();
            this.ExpertNameTextBox = new System.Windows.Forms.TextBox();
            this.ExpertLastNameTextBox = new System.Windows.Forms.TextBox();
            this.ExpertLastNameLabel = new System.Windows.Forms.Label();
            this.ExpertMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.ExpertMiddleNameLabel = new System.Windows.Forms.Label();
            this.ExpertTypeLabel = new System.Windows.Forms.Label();
            this.OutsideExpert = new System.Windows.Forms.RadioButton();
            this.InsideExpert = new System.Windows.Forms.RadioButton();
            this.CreateExpertBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExpertNameLabel
            // 
            this.ExpertNameLabel.AutoSize = true;
            this.ExpertNameLabel.Location = new System.Drawing.Point(27, 30);
            this.ExpertNameLabel.Name = "ExpertNameLabel";
            this.ExpertNameLabel.Size = new System.Drawing.Size(29, 13);
            this.ExpertNameLabel.TabIndex = 0;
            this.ExpertNameLabel.Text = "Име";
            // 
            // ExpertNameTextBox
            // 
            this.ExpertNameTextBox.Location = new System.Drawing.Point(124, 30);
            this.ExpertNameTextBox.Name = "ExpertNameTextBox";
            this.ExpertNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.ExpertNameTextBox.TabIndex = 1;
            // 
            // ExpertLastNameTextBox
            // 
            this.ExpertLastNameTextBox.Location = new System.Drawing.Point(124, 109);
            this.ExpertLastNameTextBox.Name = "ExpertLastNameTextBox";
            this.ExpertLastNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.ExpertLastNameTextBox.TabIndex = 3;
            // 
            // ExpertLastNameLabel
            // 
            this.ExpertLastNameLabel.AutoSize = true;
            this.ExpertLastNameLabel.Location = new System.Drawing.Point(27, 109);
            this.ExpertLastNameLabel.Name = "ExpertLastNameLabel";
            this.ExpertLastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.ExpertLastNameLabel.TabIndex = 2;
            this.ExpertLastNameLabel.Text = "Фамилия";
            // 
            // ExpertMiddleNameTextBox
            // 
            this.ExpertMiddleNameTextBox.Location = new System.Drawing.Point(124, 70);
            this.ExpertMiddleNameTextBox.Name = "ExpertMiddleNameTextBox";
            this.ExpertMiddleNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.ExpertMiddleNameTextBox.TabIndex = 5;
            // 
            // ExpertMiddleNameLabel
            // 
            this.ExpertMiddleNameLabel.AutoSize = true;
            this.ExpertMiddleNameLabel.Location = new System.Drawing.Point(27, 70);
            this.ExpertMiddleNameLabel.Name = "ExpertMiddleNameLabel";
            this.ExpertMiddleNameLabel.Size = new System.Drawing.Size(53, 13);
            this.ExpertMiddleNameLabel.TabIndex = 4;
            this.ExpertMiddleNameLabel.Text = "Презиме";
            // 
            // ExpertTypeLabel
            // 
            this.ExpertTypeLabel.AutoSize = true;
            this.ExpertTypeLabel.Location = new System.Drawing.Point(27, 152);
            this.ExpertTypeLabel.Name = "ExpertTypeLabel";
            this.ExpertTypeLabel.Size = new System.Drawing.Size(91, 13);
            this.ExpertTypeLabel.TabIndex = 6;
            this.ExpertTypeLabel.Text = "Тип на експерта";
            // 
            // OutsideExpert
            // 
            this.OutsideExpert.AutoSize = true;
            this.OutsideExpert.Location = new System.Drawing.Point(124, 150);
            this.OutsideExpert.Name = "OutsideExpert";
            this.OutsideExpert.Size = new System.Drawing.Size(65, 17);
            this.OutsideExpert.TabIndex = 7;
            this.OutsideExpert.TabStop = true;
            this.OutsideExpert.Text = "Външен";
            this.OutsideExpert.UseVisualStyleBackColor = true;
            // 
            // InsideExpert
            // 
            this.InsideExpert.AutoSize = true;
            this.InsideExpert.Location = new System.Drawing.Point(230, 150);
            this.InsideExpert.Name = "InsideExpert";
            this.InsideExpert.Size = new System.Drawing.Size(76, 17);
            this.InsideExpert.TabIndex = 8;
            this.InsideExpert.TabStop = true;
            this.InsideExpert.Text = "Вътрешен";
            this.InsideExpert.UseVisualStyleBackColor = true;
            // 
            // CreateExpertBtn
            // 
            this.CreateExpertBtn.Location = new System.Drawing.Point(124, 212);
            this.CreateExpertBtn.Name = "CreateExpertBtn";
            this.CreateExpertBtn.Size = new System.Drawing.Size(88, 23);
            this.CreateExpertBtn.TabIndex = 9;
            this.CreateExpertBtn.Text = "Регистрирай";
            this.CreateExpertBtn.UseVisualStyleBackColor = true;
            this.CreateExpertBtn.Click += new System.EventHandler(this.CreateExpertBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Затвори";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExprertsRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateExpertBtn);
            this.Controls.Add(this.InsideExpert);
            this.Controls.Add(this.OutsideExpert);
            this.Controls.Add(this.ExpertTypeLabel);
            this.Controls.Add(this.ExpertMiddleNameTextBox);
            this.Controls.Add(this.ExpertMiddleNameLabel);
            this.Controls.Add(this.ExpertLastNameTextBox);
            this.Controls.Add(this.ExpertLastNameLabel);
            this.Controls.Add(this.ExpertNameTextBox);
            this.Controls.Add(this.ExpertNameLabel);
            this.Name = "ExprertsRegisterForm";
            this.Text = "Регистрация на експерти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExpertNameLabel;
        private System.Windows.Forms.TextBox ExpertNameTextBox;
        private System.Windows.Forms.TextBox ExpertLastNameTextBox;
        private System.Windows.Forms.Label ExpertLastNameLabel;
        private System.Windows.Forms.TextBox ExpertMiddleNameTextBox;
        private System.Windows.Forms.Label ExpertMiddleNameLabel;
        private System.Windows.Forms.Label ExpertTypeLabel;
        private System.Windows.Forms.RadioButton OutsideExpert;
        private System.Windows.Forms.RadioButton InsideExpert;
        private System.Windows.Forms.Button CreateExpertBtn;
        private System.Windows.Forms.Button button1;
    }
}