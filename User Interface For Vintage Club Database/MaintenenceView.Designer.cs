namespace User_Interface_For_Vintage_Club_Database
{
    partial class MaintenenceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenenceView));
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.basicTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenenceInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGrabberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenenceInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machine_Database_FixedDataSet3 = new User_Interface_For_Vintage_Club_Database.Machine_Database_FixedDataSet3();
            this.maintenenceTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.machine_Database_FixedDataSet2 = new User_Interface_For_Vintage_Club_Database.Machine_Database_FixedDataSet2();
            this.maintenence_TableTableAdapter1 = new User_Interface_For_Vintage_Club_Database.Machine_Database_FixedDataSet2TableAdapters.Maintenence_TableTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maintenence_InformationTableAdapter = new User_Interface_For_Vintage_Club_Database.Machine_Database_FixedDataSet3TableAdapters.Maintenence_InformationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.MainIdTaker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenenceInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_Database_FixedDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenenceTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_Database_FixedDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainIdTaker)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1221, 964);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(716, 92);
            this.button7.TabIndex = 84;
            this.button7.Text = "Maintenence Information Form >";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(300, 964);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(686, 89);
            this.button2.TabIndex = 83;
            this.button2.Text = "< Back To Editing Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(868, 889);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(527, 60);
            this.button3.TabIndex = 86;
            this.button3.Text = "Debugging Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.basicTitleDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.whoByDataGridViewTextBoxColumn,
            this.maintenenceInformationDataGridViewTextBoxColumn,
            this.iDGrabberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maintenenceInformationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(201, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1682, 426);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // basicTitleDataGridViewTextBoxColumn
            // 
            this.basicTitleDataGridViewTextBoxColumn.DataPropertyName = "Basic_Title";
            this.basicTitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.basicTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basicTitleDataGridViewTextBoxColumn.Name = "basicTitleDataGridViewTextBoxColumn";
            this.basicTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.basicTitleDataGridViewTextBoxColumn.Width = 450;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 300;
            // 
            // whoByDataGridViewTextBoxColumn
            // 
            this.whoByDataGridViewTextBoxColumn.DataPropertyName = "Who_By";
            this.whoByDataGridViewTextBoxColumn.HeaderText = "Who By";
            this.whoByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.whoByDataGridViewTextBoxColumn.Name = "whoByDataGridViewTextBoxColumn";
            this.whoByDataGridViewTextBoxColumn.ReadOnly = true;
            this.whoByDataGridViewTextBoxColumn.Width = 450;
            // 
            // maintenenceInformationDataGridViewTextBoxColumn
            // 
            this.maintenenceInformationDataGridViewTextBoxColumn.DataPropertyName = "Maintenence_Information";
            this.maintenenceInformationDataGridViewTextBoxColumn.HeaderText = "Maintenence Information";
            this.maintenenceInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenenceInformationDataGridViewTextBoxColumn.Name = "maintenenceInformationDataGridViewTextBoxColumn";
            this.maintenenceInformationDataGridViewTextBoxColumn.ReadOnly = true;
            this.maintenenceInformationDataGridViewTextBoxColumn.Visible = false;
            this.maintenenceInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDGrabberDataGridViewTextBoxColumn
            // 
            this.iDGrabberDataGridViewTextBoxColumn.DataPropertyName = "ID_Grabber";
            this.iDGrabberDataGridViewTextBoxColumn.HeaderText = "ID Grabber";
            this.iDGrabberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDGrabberDataGridViewTextBoxColumn.Name = "iDGrabberDataGridViewTextBoxColumn";
            this.iDGrabberDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDGrabberDataGridViewTextBoxColumn.Visible = false;
            this.iDGrabberDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenenceInformationBindingSource
            // 
            this.maintenenceInformationBindingSource.DataMember = "Maintenence_Information";
            this.maintenenceInformationBindingSource.DataSource = this.machine_Database_FixedDataSet3;
            // 
            // machine_Database_FixedDataSet3
            // 
            this.machine_Database_FixedDataSet3.DataSetName = "Machine_Database_FixedDataSet3";
            this.machine_Database_FixedDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintenenceTableBindingSource1
            // 
            this.maintenenceTableBindingSource1.DataMember = "Maintenence_Table";
            this.maintenenceTableBindingSource1.DataSource = this.machine_Database_FixedDataSet2;
            // 
            // machine_Database_FixedDataSet2
            // 
            this.machine_Database_FixedDataSet2.DataSetName = "Machine_Database_FixedDataSet2";
            this.machine_Database_FixedDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintenence_TableTableAdapter1
            // 
            this.maintenence_TableTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::User_Interface_For_Vintage_Club_Database.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(784, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // maintenence_InformationTableAdapter
            // 
            this.maintenence_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 69);
            this.label1.TabIndex = 89;
            this.label1.Text = "Maintenence History";
            // 
            // MainIdTaker
            // 
            this.MainIdTaker.Enabled = false;
            this.MainIdTaker.Location = new System.Drawing.Point(39, 39);
            this.MainIdTaker.Name = "MainIdTaker";
            this.MainIdTaker.Size = new System.Drawing.Size(120, 22);
            this.MainIdTaker.TabIndex = 90;
            // 
            // MaintenenceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.MainIdTaker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaintenenceView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintenenceView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintenenceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenenceInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_Database_FixedDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenenceTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machine_Database_FixedDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainIdTaker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Machine_Database_FixedDataSet2 machine_Database_FixedDataSet2;
        private System.Windows.Forms.BindingSource maintenenceTableBindingSource1;
        private Machine_Database_FixedDataSet2TableAdapters.Maintenence_TableTableAdapter maintenence_TableTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Machine_Database_FixedDataSet3 machine_Database_FixedDataSet3;
        private System.Windows.Forms.BindingSource maintenenceInformationBindingSource;
        private Machine_Database_FixedDataSet3TableAdapters.Maintenence_InformationTableAdapter maintenence_InformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenenceInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGrabberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown MainIdTaker;
    }
}