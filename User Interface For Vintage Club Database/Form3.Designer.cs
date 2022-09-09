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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Form3IDTaker = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.generalTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.machine_Database_FixedDataSet4 = new User_Interface_For_Vintage_Club_Database.Machine_Database_FixedDataSet4();
            this.general_TableTableAdapter = new User_Interface_For_Vintage_Club_Database.Machine_Database_FixedDataSet4TableAdapters.General_TableTableAdapter();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form3IDTaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_Database_FixedDataSet4)).BeginInit();
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
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(842, 869);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 115);
            this.button2.TabIndex = 8;
            this.button2.Text = "< Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(606, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(929, 56);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search:";
            // 
            // Form3IDTaker
            // 
            this.Form3IDTaker.Location = new System.Drawing.Point(-25, -9);
            this.Form3IDTaker.Name = "Form3IDTaker";
            this.Form3IDTaker.Size = new System.Drawing.Size(24, 22);
            this.Form3IDTaker.TabIndex = 11;
            this.Form3IDTaker.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewImageColumn3,
            this.dataGridViewTextBoxColumn27});
            this.dataGridView1.DataSource = this.generalTableBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.Size = new System.Drawing.Size(1890, 424);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // generalTableBindingSource2
            // 
            this.generalTableBindingSource2.DataMember = "General_Table";
            this.generalTableBindingSource2.DataSource = this.machine_Database_FixedDataSet4;
            // 
            // machine_Database_FixedDataSet4
            // 
            this.machine_Database_FixedDataSet4.DataSetName = "Machine_Database_FixedDataSet4";
            this.machine_Database_FixedDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // general_TableTableAdapter
            // 
            this.general_TableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn14.HeaderText = "ID";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Machine_Type";
            this.dataGridViewTextBoxColumn15.HeaderText = "Machine Type";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 350;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Year_Built";
            this.dataGridViewTextBoxColumn16.HeaderText = "Year Built";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 350;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn25.HeaderText = "Make";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 350;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn20.HeaderText = "Model";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 350;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Original_Owner";
            this.dataGridViewTextBoxColumn17.HeaderText = "Original Owner";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 350;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Date_Acquired";
            this.dataGridViewTextBoxColumn18.HeaderText = "Date Acquired";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 350;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn19.HeaderText = "Description";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Image";
            this.dataGridViewImageColumn2.HeaderText = "Image";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Visible = false;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Machine_Location";
            this.dataGridViewTextBoxColumn21.HeaderText = "Machine Location";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 400;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Restoration_Status";
            this.dataGridViewTextBoxColumn22.HeaderText = "Restoration Status";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 400;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Link_to_TractorData";
            this.dataGridViewTextBoxColumn23.HeaderText = "Link to TractorData";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "SecondImage";
            this.dataGridViewImageColumn3.HeaderText = "SecondImage";
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Visible = false;
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "IfSold";
            this.dataGridViewTextBoxColumn27.HeaderText = "If Sold";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 350;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Form3IDTaker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form3IDTaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_Database_FixedDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
#pragma warning disable CS0169 // The field 'Form3.idDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.idDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.imageDataGridViewImageColumn' is never used
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
#pragma warning restore CS0169 // The field 'Form3.imageDataGridViewImageColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.machineTypeDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn machineTypeDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.machineTypeDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.yearBuiltDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn yearBuiltDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.yearBuiltDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.makeDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.makeDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.modelDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.modelDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.machineLocationDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn machineLocationDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.machineLocationDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.restorationStatusDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn restorationStatusDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.restorationStatusDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.originalOwnerDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn originalOwnerDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.originalOwnerDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.dateAcquiredDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAcquiredDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.dateAcquiredDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.descriptionDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.descriptionDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.maintenenceInformationDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenenceInformationDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.maintenenceInformationDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.linktoTractorDataDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn linktoTractorDataDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.linktoTractorDataDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.donatedOrLoanedDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn donatedOrLoanedDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.donatedOrLoanedDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Form3IDTaker;
#pragma warning disable CS0169 // The field 'Form3.donatedByDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn donatedByDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.donatedByDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridView dataGridView1;
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn1' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn1' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn2' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn2' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn3' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn3' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn4' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn4' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn5' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn5' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn6' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn6' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewImageColumn1' is never used
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewImageColumn1' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn7' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn7' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn8' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn8' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn9' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn9' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn10' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn10' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn11' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn11' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn12' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn12' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn13' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn13' is never used
#pragma warning disable CS0169 // The field 'Form3.secondImageDataGridViewImageColumn' is never used
        private System.Windows.Forms.DataGridViewImageColumn secondImageDataGridViewImageColumn;
#pragma warning restore CS0169 // The field 'Form3.secondImageDataGridViewImageColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.otherNotesDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn otherNotesDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.otherNotesDataGridViewTextBoxColumn' is never used
#pragma warning disable CS0169 // The field 'Form3.ifSoldDataGridViewTextBoxColumn' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn ifSoldDataGridViewTextBoxColumn;
#pragma warning restore CS0169 // The field 'Form3.ifSoldDataGridViewTextBoxColumn' is never used
        private Machine_Database_FixedDataSet4 machine_Database_FixedDataSet4;
        private System.Windows.Forms.BindingSource generalTableBindingSource2;
        private Machine_Database_FixedDataSet4TableAdapters.General_TableTableAdapter general_TableTableAdapter;
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn24' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn24' is never used
#pragma warning disable CS0169 // The field 'Form3.dataGridViewTextBoxColumn26' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
#pragma warning restore CS0169 // The field 'Form3.dataGridViewTextBoxColumn26' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
    }
}