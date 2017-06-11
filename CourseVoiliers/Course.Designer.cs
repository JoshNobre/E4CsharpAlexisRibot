namespace CourseVoiliers
{
    partial class Course
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdd_voilierDataSet = new CourseVoiliers.bdd_voilierDataSet();
            this.bddvoilierDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new CourseVoiliers.bdd_voilierDataSetTableAdapters.COURSETableAdapter();
            this.idCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCourseDataGridViewTextBoxColumn,
            this.nomCourseDataGridViewTextBoxColumn,
            this.lieuCourseDataGridViewTextBoxColumn,
            this.dateCourseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOURSEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdd_voilierDataSet
            // 
            this.bdd_voilierDataSet.DataSetName = "bdd_voilierDataSet";
            this.bdd_voilierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bddvoilierDataSetBindingSource
            // 
            this.bddvoilierDataSetBindingSource.DataSource = this.bdd_voilierDataSet;
            this.bddvoilierDataSetBindingSource.Position = 0;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.bddvoilierDataSetBindingSource;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // idCourseDataGridViewTextBoxColumn
            // 
            this.idCourseDataGridViewTextBoxColumn.DataPropertyName = "Id_Course";
            this.idCourseDataGridViewTextBoxColumn.HeaderText = "Id_Course";
            this.idCourseDataGridViewTextBoxColumn.Name = "idCourseDataGridViewTextBoxColumn";
            this.idCourseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomCourseDataGridViewTextBoxColumn
            // 
            this.nomCourseDataGridViewTextBoxColumn.DataPropertyName = "Nom_Course";
            this.nomCourseDataGridViewTextBoxColumn.HeaderText = "Nom_Course";
            this.nomCourseDataGridViewTextBoxColumn.Name = "nomCourseDataGridViewTextBoxColumn";
            // 
            // lieuCourseDataGridViewTextBoxColumn
            // 
            this.lieuCourseDataGridViewTextBoxColumn.DataPropertyName = "Lieu_Course";
            this.lieuCourseDataGridViewTextBoxColumn.HeaderText = "Lieu_Course";
            this.lieuCourseDataGridViewTextBoxColumn.Name = "lieuCourseDataGridViewTextBoxColumn";
            // 
            // dateCourseDataGridViewTextBoxColumn
            // 
            this.dateCourseDataGridViewTextBoxColumn.DataPropertyName = "Date_Course";
            this.dateCourseDataGridViewTextBoxColumn.HeaderText = "Date_Course";
            this.dateCourseDataGridViewTextBoxColumn.Name = "dateCourseDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bddvoilierDataSetBindingSource;
        private bdd_voilierDataSet bdd_voilierDataSet;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private bdd_voilierDataSetTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}