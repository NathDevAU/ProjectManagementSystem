namespace ProjectManagement
{
    partial class SearchProjectForm
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
            this.ProjectsGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DetailsBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectStatusCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGV)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.SearchFilterDropDown.Items.AddRange(new object[] {
            "Код на проект",
            "Наименование на проект",
            "Клиент",
            "Начало на проект",
            "Край на проекта",
            "Статус на проект"});
            this.SearchFilterDropDown.Location = new System.Drawing.Point(75, 22);
            this.SearchFilterDropDown.Name = "SearchFilterDropDown";
            this.SearchFilterDropDown.Size = new System.Drawing.Size(137, 21);
            this.SearchFilterDropDown.TabIndex = 1;
            this.SearchFilterDropDown.SelectedIndexChanged += new System.EventHandler(this.SearchFilterDropDown_SelectedIndexChanged);
            // 
            // SearchFilterTextBox
            // 
            this.SearchFilterTextBox.Location = new System.Drawing.Point(272, 22);
            this.SearchFilterTextBox.Name = "SearchFilterTextBox";
            this.SearchFilterTextBox.Size = new System.Drawing.Size(236, 20);
            this.SearchFilterTextBox.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(563, 19);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Търсене";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ProjectsGV
            // 
            this.ProjectsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetailsBtn});
            this.ProjectsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsGV.Location = new System.Drawing.Point(0, 0);
            this.ProjectsGV.Name = "ProjectsGV";
            this.ProjectsGV.ReadOnly = true;
            this.ProjectsGV.Size = new System.Drawing.Size(845, 268);
            this.ProjectsGV.TabIndex = 4;
            this.ProjectsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProjectsGV);
            this.panel1.Location = new System.Drawing.Point(28, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 268);
            this.panel1.TabIndex = 5;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(798, 344);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Затвори";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.HeaderText = "Детайли";
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.ReadOnly = true;
            this.DetailsBtn.Text = "Детайли";
            this.DetailsBtn.UseColumnTextForButtonValue = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(272, 22);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // ProjectStatusCb
            // 
            this.ProjectStatusCb.FormattingEnabled = true;
            this.ProjectStatusCb.Items.AddRange(new object[] {
            "Нов",
            "В изпълнение",
            "Замразен",
            "Прекратен"});
            this.ProjectStatusCb.Location = new System.Drawing.Point(272, 22);
            this.ProjectStatusCb.Name = "ProjectStatusCb";
            this.ProjectStatusCb.Size = new System.Drawing.Size(236, 21);
            this.ProjectStatusCb.TabIndex = 8;
            // 
            // SearchProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 378);
            this.Controls.Add(this.ProjectStatusCb);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchFilterTextBox);
            this.Controls.Add(this.SearchFilterDropDown);
            this.Controls.Add(this.SearchFilterLabel);
            this.Name = "SearchProjectForm";
            this.Text = "Търсене на проект";
            this.Load += new System.EventHandler(this.SearchProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchFilterLabel;
        private System.Windows.Forms.ComboBox SearchFilterDropDown;
        private System.Windows.Forms.TextBox SearchFilterTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView ProjectsGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox ProjectStatusCb;
    }
}