namespace ProjectManagement
{
    partial class SearchExpertForm
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
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchFilterDropDown = new System.Windows.Forms.ComboBox();
            this.SearchExpertTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExpertSearchResultGrid = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpertType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.expertsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExperTypeLabel = new System.Windows.Forms.Label();
            this.ExternalExpertRaidoBtn = new System.Windows.Forms.RadioButton();
            this.InternalExpertRadioBtn = new System.Windows.Forms.RadioButton();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AllExpertTypes = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpertSearchResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(19, 18);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(57, 13);
            this.SearchByLabel.TabIndex = 0;
            this.SearchByLabel.Text = "Търси по:";
            // 
            // SearchFilterDropDown
            // 
            this.SearchFilterDropDown.FormattingEnabled = true;
            this.SearchFilterDropDown.Location = new System.Drawing.Point(131, 18);
            this.SearchFilterDropDown.Name = "SearchFilterDropDown";
            this.SearchFilterDropDown.Size = new System.Drawing.Size(135, 21);
            this.SearchFilterDropDown.TabIndex = 1;
            // 
            // SearchExpertTextBox
            // 
            this.SearchExpertTextBox.Location = new System.Drawing.Point(282, 19);
            this.SearchExpertTextBox.Name = "SearchExpertTextBox";
            this.SearchExpertTextBox.Size = new System.Drawing.Size(210, 20);
            this.SearchExpertTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Търсене";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExpertSearchResultGrid);
            this.panel1.Location = new System.Drawing.Point(22, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 308);
            this.panel1.TabIndex = 4;
            // 
            // ExpertSearchResultGrid
            // 
            this.ExpertSearchResultGrid.AllowUserToAddRows = false;
            this.ExpertSearchResultGrid.AllowUserToDeleteRows = false;
            this.ExpertSearchResultGrid.AutoGenerateColumns = false;
            this.ExpertSearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpertSearchResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ExpertType,
            this.DetailsBtn});
            this.ExpertSearchResultGrid.DataSource = this.expertsBindingSource;
            this.ExpertSearchResultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpertSearchResultGrid.Location = new System.Drawing.Point(0, 0);
            this.ExpertSearchResultGrid.Name = "ExpertSearchResultGrid";
            this.ExpertSearchResultGrid.ReadOnly = true;
            this.ExpertSearchResultGrid.Size = new System.Drawing.Size(549, 308);
            this.ExpertSearchResultGrid.TabIndex = 0;
            this.ExpertSearchResultGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpertSearchResultGrid_CellContentClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Презиме";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExpertType
            // 
            this.ExpertType.DataPropertyName = "ExpertType";
            this.ExpertType.HeaderText = "Тип";
            this.ExpertType.Name = "ExpertType";
            this.ExpertType.ReadOnly = true;
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.DataPropertyName = "Id";
            this.DetailsBtn.HeaderText = "Детайли";
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.ReadOnly = true;
            this.DetailsBtn.Text = "Детайли";
            this.DetailsBtn.UseColumnTextForButtonValue = true;
            // 
            // expertsBindingSource
            // 
            this.expertsBindingSource.DataSource = typeof(ProjectManagement.ViewModels.Expert);
            // 
            // ExperTypeLabel
            // 
            this.ExperTypeLabel.AutoSize = true;
            this.ExperTypeLabel.Location = new System.Drawing.Point(19, 59);
            this.ExperTypeLabel.Name = "ExperTypeLabel";
            this.ExperTypeLabel.Size = new System.Drawing.Size(94, 13);
            this.ExperTypeLabel.TabIndex = 5;
            this.ExperTypeLabel.Text = "Тип на експерта:";
            // 
            // ExternalExpertRaidoBtn
            // 
            this.ExternalExpertRaidoBtn.AutoSize = true;
            this.ExternalExpertRaidoBtn.Location = new System.Drawing.Point(282, 57);
            this.ExternalExpertRaidoBtn.Name = "ExternalExpertRaidoBtn";
            this.ExternalExpertRaidoBtn.Size = new System.Drawing.Size(65, 17);
            this.ExternalExpertRaidoBtn.TabIndex = 6;
            this.ExternalExpertRaidoBtn.TabStop = true;
            this.ExternalExpertRaidoBtn.Text = "Външен";
            this.ExternalExpertRaidoBtn.UseVisualStyleBackColor = true;
            // 
            // InternalExpertRadioBtn
            // 
            this.InternalExpertRadioBtn.AutoSize = true;
            this.InternalExpertRadioBtn.Location = new System.Drawing.Point(131, 59);
            this.InternalExpertRadioBtn.Name = "InternalExpertRadioBtn";
            this.InternalExpertRadioBtn.Size = new System.Drawing.Size(76, 17);
            this.InternalExpertRadioBtn.TabIndex = 7;
            this.InternalExpertRadioBtn.TabStop = true;
            this.InternalExpertRadioBtn.Text = "Вътрешен";
            this.InternalExpertRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(498, 405);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Затвори";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AllExpertTypes
            // 
            this.AllExpertTypes.AutoSize = true;
            this.AllExpertTypes.Location = new System.Drawing.Point(431, 59);
            this.AllExpertTypes.Name = "AllExpertTypes";
            this.AllExpertTypes.Size = new System.Drawing.Size(61, 17);
            this.AllExpertTypes.TabIndex = 9;
            this.AllExpertTypes.TabStop = true;
            this.AllExpertTypes.Text = "Всички";
            this.AllExpertTypes.UseVisualStyleBackColor = true;
            // 
            // SearchExpertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 438);
            this.Controls.Add(this.AllExpertTypes);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.InternalExpertRadioBtn);
            this.Controls.Add(this.ExternalExpertRaidoBtn);
            this.Controls.Add(this.ExperTypeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchExpertTextBox);
            this.Controls.Add(this.SearchFilterDropDown);
            this.Controls.Add(this.SearchByLabel);
            this.Name = "SearchExpertForm";
            this.Text = "Търсене на експерт";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpertSearchResultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.ComboBox SearchFilterDropDown;
        private System.Windows.Forms.TextBox SearchExpertTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ExpertSearchResultGrid;
        private System.Windows.Forms.Label ExperTypeLabel;
        private System.Windows.Forms.RadioButton ExternalExpertRaidoBtn;
        private System.Windows.Forms.RadioButton InternalExpertRadioBtn;
        private System.Windows.Forms.BindingSource expertsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn isExternalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpertType;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.RadioButton AllExpertTypes;
    }
}