namespace CourseVoiliers
{
    partial class ClassementGen
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
            this.getTotalTempsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet7 = new CourseVoiliers.bdd_voilierDataSet7();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet2 = new CourseVoiliers.bdd_voilierDataSet2();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bdd_voilierDataSet3 = new CourseVoiliers.bdd_voilierDataSet3();
            this.bddvoilierDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new CourseVoiliers.bdd_voilierDataSet2TableAdapters.COURSETableAdapter();
            this.getTotalTempsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTotalTempsTableAdapter = new CourseVoiliers.bdd_voilierDataSet6TableAdapters.getTotalTempsTableAdapter();
            this.getTotalTempsTableAdapter1 = new CourseVoiliers.bdd_voilierDataSet7TableAdapters.getTotalTempsTableAdapter();
            this.bdd_voilierDataSet9 = new CourseVoiliers.bdd_voilierDataSet9();
            this.classementGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classementGeneralTableAdapter = new CourseVoiliers.bdd_voilierDataSet9TableAdapters.ClassementGeneralTableAdapter();
            this.classementGeneralBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomVoilierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsRéelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.getTotalTempsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTotalTempsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classementGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classementGeneralBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // getTotalTempsBindingSource1
            // 
            this.getTotalTempsBindingSource1.DataMember = "getTotalTemps";
            this.getTotalTempsBindingSource1.DataSource = this.bdd_voilierDataSet7;
            // 
            // bdd_voilierDataSet7
            // 
            this.bdd_voilierDataSet7.DataSetName = "bdd_voilierDataSet7";
            this.bdd_voilierDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "Id_Course", true));
            this.comboBox1.DataSource = this.cOURSEBindingSource;
            this.comboBox1.DisplayMember = "Nom_Course";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id_Course";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "COURSE";
            this.bindingSource1.DataSource = this.bdd_voilierDataSet2;
            // 
            // bdd_voilierDataSet2
            // 
            this.bdd_voilierDataSet2.DataSetName = "bdd_voilierDataSet2";
            this.bdd_voilierDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.bdd_voilierDataSet2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bdd_voilierDataSet3
            // 
            this.bdd_voilierDataSet3.DataSetName = "bdd_voilierDataSet3";
            this.bdd_voilierDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bddvoilierDataSet3BindingSource
            // 
            this.bddvoilierDataSet3BindingSource.DataSource = this.bdd_voilierDataSet3;
            this.bddvoilierDataSet3BindingSource.Position = 0;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // getTotalTempsTableAdapter
            // 
            this.getTotalTempsTableAdapter.ClearBeforeFill = true;
            // 
            // getTotalTempsTableAdapter1
            // 
            this.getTotalTempsTableAdapter1.ClearBeforeFill = true;
            // 
            // bdd_voilierDataSet9
            // 
            this.bdd_voilierDataSet9.DataSetName = "bdd_voilierDataSet9";
            this.bdd_voilierDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classementGeneralBindingSource
            // 
            this.classementGeneralBindingSource.DataMember = "ClassementGeneral";
            this.classementGeneralBindingSource.DataSource = this.bdd_voilierDataSet9;
            // 
            // classementGeneralTableAdapter
            // 
            this.classementGeneralTableAdapter.ClearBeforeFill = true;
            // 
            // classementGeneralBindingSource1
            // 
            this.classementGeneralBindingSource1.DataMember = "ClassementGeneral";
            this.classementGeneralBindingSource1.DataSource = this.bdd_voilierDataSet9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomVoilierDataGridViewTextBoxColumn,
            this.tempsRéelDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.classementGeneralBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // nomVoilierDataGridViewTextBoxColumn
            // 
            this.nomVoilierDataGridViewTextBoxColumn.DataPropertyName = "Nom_Voilier";
            this.nomVoilierDataGridViewTextBoxColumn.HeaderText = "Nom_Voilier";
            this.nomVoilierDataGridViewTextBoxColumn.Name = "nomVoilierDataGridViewTextBoxColumn";
            // 
            // tempsRéelDataGridViewTextBoxColumn
            // 
            this.tempsRéelDataGridViewTextBoxColumn.DataPropertyName = "Temps réel";
            this.tempsRéelDataGridViewTextBoxColumn.HeaderText = "Temps réel";
            this.tempsRéelDataGridViewTextBoxColumn.Name = "tempsRéelDataGridViewTextBoxColumn";
            this.tempsRéelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Position";
            this.Column1.Name = "Column1";
            // 
            // ClassementGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ClassementGen";
            this.Text = "ClassementGen";
            this.Load += new System.EventHandler(this.ClassementGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getTotalTempsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTotalTempsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classementGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classementGeneralBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bddvoilierDataSet3BindingSource;
        private bdd_voilierDataSet3 bdd_voilierDataSet3;
        private bdd_voilierDataSet2 bdd_voilierDataSet2;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private bdd_voilierDataSet2TableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource getTotalTempsBindingSource;
        private bdd_voilierDataSet6TableAdapters.getTotalTempsTableAdapter getTotalTempsTableAdapter;
        private bdd_voilierDataSet7 bdd_voilierDataSet7;
        private System.Windows.Forms.BindingSource getTotalTempsBindingSource1;
        private bdd_voilierDataSet7TableAdapters.getTotalTempsTableAdapter getTotalTempsTableAdapter1;
        private bdd_voilierDataSet9 bdd_voilierDataSet9;
        private System.Windows.Forms.BindingSource classementGeneralBindingSource;
        private bdd_voilierDataSet9TableAdapters.ClassementGeneralTableAdapter classementGeneralTableAdapter;
        private System.Windows.Forms.BindingSource classementGeneralBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVoilierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsRéelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}