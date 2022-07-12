namespace User_Interface_For_Vintage_Club_Database
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.machine_DatabaseDataSet = new User_Interface_For_Vintage_Club_Database.Machine_DatabaseDataSet();
            this.generalTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_TableTableAdapter = new User_Interface_For_Vintage_Club_Database.Machine_DatabaseDataSetTableAdapters.General_TableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.machineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearBuiltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restorationStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAcquiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenenceInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linktoTractorDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donatedOrLoanedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::User_Interface_For_Vintage_Club_Database.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(798, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.machineTypeDataGridViewTextBoxColumn,
            this.yearBuiltDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.machineLocationDataGridViewTextBoxColumn,
            this.restorationStatusDataGridViewTextBoxColumn,
            this.originalOwnerDataGridViewTextBoxColumn,
            this.dateAcquiredDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.maintenenceInformationDataGridViewTextBoxColumn,
            this.linktoTractorDataDataGridViewTextBoxColumn,
            this.donatedOrLoanedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.generalTableBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1831, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(842, 869);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 115);
            this.button2.TabIndex = 8;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // machine_DatabaseDataSet
            // 
            this.machine_DatabaseDataSet.DataSetName = "Machine_DatabaseDataSet";
            this.machine_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generalTableBindingSource
            // 
            this.generalTableBindingSource.DataMember = "General_Table";
            this.generalTableBindingSource.DataSource = this.machine_DatabaseDataSet;
            // 
            // general_TableTableAdapter
            // 
            this.general_TableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 6;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // machineTypeDataGridViewTextBoxColumn
            // 
            this.machineTypeDataGridViewTextBoxColumn.DataPropertyName = "Machine_Type";
            this.machineTypeDataGridViewTextBoxColumn.HeaderText = "Machine_Type";
            this.machineTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machineTypeDataGridViewTextBoxColumn.Name = "machineTypeDataGridViewTextBoxColumn";
            this.machineTypeDataGridViewTextBoxColumn.Width = 250;
            // 
            // yearBuiltDataGridViewTextBoxColumn
            // 
            this.yearBuiltDataGridViewTextBoxColumn.DataPropertyName = "Year_Built";
            this.yearBuiltDataGridViewTextBoxColumn.HeaderText = "Year_Built";
            this.yearBuiltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearBuiltDataGridViewTextBoxColumn.Name = "yearBuiltDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.Width = 200;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 200;
            // 
            // machineLocationDataGridViewTextBoxColumn
            // 
            this.machineLocationDataGridViewTextBoxColumn.DataPropertyName = "Machine_Location";
            this.machineLocationDataGridViewTextBoxColumn.HeaderText = "Machine_Location";
            this.machineLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.machineLocationDataGridViewTextBoxColumn.Name = "machineLocationDataGridViewTextBoxColumn";
            this.machineLocationDataGridViewTextBoxColumn.Width = 400;
            // 
            // restorationStatusDataGridViewTextBoxColumn
            // 
            this.restorationStatusDataGridViewTextBoxColumn.DataPropertyName = "Restoration_Status";
            this.restorationStatusDataGridViewTextBoxColumn.HeaderText = "Restoration_Status";
            this.restorationStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restorationStatusDataGridViewTextBoxColumn.Name = "restorationStatusDataGridViewTextBoxColumn";
            this.restorationStatusDataGridViewTextBoxColumn.Visible = false;
            this.restorationStatusDataGridViewTextBoxColumn.Width = 200;
            // 
            // originalOwnerDataGridViewTextBoxColumn
            // 
            this.originalOwnerDataGridViewTextBoxColumn.DataPropertyName = "Original_Owner";
            this.originalOwnerDataGridViewTextBoxColumn.HeaderText = "Original_Owner";
            this.originalOwnerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.originalOwnerDataGridViewTextBoxColumn.Name = "originalOwnerDataGridViewTextBoxColumn";
            this.originalOwnerDataGridViewTextBoxColumn.Visible = false;
            this.originalOwnerDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAcquiredDataGridViewTextBoxColumn
            // 
            this.dateAcquiredDataGridViewTextBoxColumn.DataPropertyName = "Date_Acquired";
            this.dateAcquiredDataGridViewTextBoxColumn.HeaderText = "Date_Acquired";
            this.dateAcquiredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAcquiredDataGridViewTextBoxColumn.Name = "dateAcquiredDataGridViewTextBoxColumn";
            this.dateAcquiredDataGridViewTextBoxColumn.Visible = false;
            this.dateAcquiredDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenenceInformationDataGridViewTextBoxColumn
            // 
            this.maintenenceInformationDataGridViewTextBoxColumn.DataPropertyName = "Maintenence_Information";
            this.maintenenceInformationDataGridViewTextBoxColumn.HeaderText = "Maintenence_Information";
            this.maintenenceInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenenceInformationDataGridViewTextBoxColumn.Name = "maintenenceInformationDataGridViewTextBoxColumn";
            this.maintenenceInformationDataGridViewTextBoxColumn.Visible = false;
            this.maintenenceInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // linktoTractorDataDataGridViewTextBoxColumn
            // 
            this.linktoTractorDataDataGridViewTextBoxColumn.DataPropertyName = "Link_to_TractorData";
            this.linktoTractorDataDataGridViewTextBoxColumn.HeaderText = "Link_to_TractorData";
            this.linktoTractorDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.linktoTractorDataDataGridViewTextBoxColumn.Name = "linktoTractorDataDataGridViewTextBoxColumn";
            this.linktoTractorDataDataGridViewTextBoxColumn.Visible = false;
            this.linktoTractorDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // donatedOrLoanedDataGridViewTextBoxColumn
            // 
            this.donatedOrLoanedDataGridViewTextBoxColumn.DataPropertyName = "Donated_Or_Loaned";
            this.donatedOrLoanedDataGridViewTextBoxColumn.HeaderText = "Donated_Or_Loaned";
            this.donatedOrLoanedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donatedOrLoanedDataGridViewTextBoxColumn.Name = "donatedOrLoanedDataGridViewTextBoxColumn";
            this.donatedOrLoanedDataGridViewTextBoxColumn.Visible = false;
            this.donatedOrLoanedDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 1055);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private Machine_DatabaseDataSet machine_DatabaseDataSet;
        private System.Windows.Forms.BindingSource generalTableBindingSource;
        private Machine_DatabaseDataSetTableAdapters.General_TableTableAdapter general_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearBuiltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restorationStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAcquiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenenceInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linktoTractorDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donatedOrLoanedDataGridViewTextBoxColumn;
    }
}