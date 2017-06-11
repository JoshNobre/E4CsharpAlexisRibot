namespace CourseVoiliers
{
    partial class Classement
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
            this.getTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet3 = new CourseVoiliers.bdd_voilierDataSet3();
            this.getTimesTableAdapter = new CourseVoiliers.bdd_voilierDataSet3TableAdapters.getTimesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet2 = new CourseVoiliers.bdd_voilierDataSet2();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bindingSourceClassement2 = new System.Windows.Forms.BindingSource(this.components);
            this.ePREUVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddvoilierDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cOURSETableAdapter = new CourseVoiliers.bdd_voilierDataSet2TableAdapters.COURSETableAdapter();
            this.bindingSourceClassement1 = new System.Windows.Forms.BindingSource(this.components);
            this.ePREUVETableAdapter = new CourseVoiliers.bdd_voilierDataSet2TableAdapters.EPREUVETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomVoilierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsRéelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTimesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet8 = new CourseVoiliers.bdd_voilierDataSet8();
            this.getTimesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet5 = new CourseVoiliers.bdd_voilierDataSet5();
            this.getTimesTableAdapter1 = new CourseVoiliers.bdd_voilierDataSet5TableAdapters.getTimesTableAdapter();
            this.getTimesTableAdapter2 = new CourseVoiliers.bdd_voilierDataSet8TableAdapters.getTimesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClassement2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePREUVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClassement1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTimesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTimesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // getTimesBindingSource
            // 
            this.getTimesBindingSource.DataMember = "getTimes";
            this.getTimesBindingSource.DataSource = this.bdd_voilierDataSet3;
            // 
            // bdd_voilierDataSet3
            // 
            this.bdd_voilierDataSet3.DataSetName = "bdd_voilierDataSet3";
            this.bdd_voilierDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTimesTableAdapter
            // 
            this.getTimesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cOURSEBindingSource;
            this.comboBox1.DisplayMember = "Nom_Course";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id_Course";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.bdd_voilierDataSet2;
            // 
            // bdd_voilierDataSet2
            // 
            this.bdd_voilierDataSet2.DataSetName = "bdd_voilierDataSet2";
            this.bdd_voilierDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceClassement2, "Id_Epreuve", true));
            this.comboBox2.DataSource = this.ePREUVEBindingSource;
            this.comboBox2.DisplayMember = "Libelle";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(234, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "Id_Epreuve";
            // 
            // bindingSourceClassement2
            // 
            this.bindingSourceClassement2.DataMember = "EPREUVE";
            this.bindingSourceClassement2.DataSource = this.bdd_voilierDataSet2;
            // 
            // ePREUVEBindingSource
            // 
            this.ePREUVEBindingSource.DataMember = "EPREUVE";
            this.ePREUVEBindingSource.DataSource = this.bddvoilierDataSet2BindingSource;
            // 
            // bddvoilierDataSet2BindingSource
            // 
            this.bddvoilierDataSet2BindingSource.DataSource = this.bdd_voilierDataSet2;
            this.bddvoilierDataSet2BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Epreuve";
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceClassement1
            // 
            this.bindingSourceClassement1.DataMember = "COURSE";
            this.bindingSourceClassement1.DataSource = this.bdd_voilierDataSet2;
            // 
            // ePREUVETableAdapter
            // 
            this.ePREUVETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomVoilierDataGridViewTextBoxColumn,
            this.tempsRéelDataGridViewTextBoxColumn,
            this.position});
            this.dataGridView1.DataSource = this.getTimesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(54, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
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
            // position
            // 
            this.position.DataPropertyName = "Nom_Voilier";
            this.position.HeaderText = "Position";
            this.position.Name = "position";
            // 
            // getTimesBindingSource2
            // 
            this.getTimesBindingSource2.DataMember = "getTimes";
            this.getTimesBindingSource2.DataSource = this.bdd_voilierDataSet8;
            // 
            // bdd_voilierDataSet8
            // 
            this.bdd_voilierDataSet8.DataSetName = "bdd_voilierDataSet8";
            this.bdd_voilierDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTimesBindingSource1
            // 
            this.getTimesBindingSource1.DataMember = "getTimes";
            this.getTimesBindingSource1.DataSource = this.bdd_voilierDataSet5;
            // 
            // bdd_voilierDataSet5
            // 
            this.bdd_voilierDataSet5.DataSetName = "bdd_voilierDataSet5";
            this.bdd_voilierDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTimesTableAdapter1
            // 
            this.getTimesTableAdapter1.ClearBeforeFill = true;
            // 
            // getTimesTableAdapter2
            // 
            this.getTimesTableAdapter2.ClearBeforeFill = true;
            // 
            // Classement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 215);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Classement";
            this.Text = "Classement";
            this.Load += new System.EventHandler(this.Classement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClassement2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePREUVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClassement1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTimesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTimesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bdd_voilierDataSet3 bdd_voilierDataSet3;
        private System.Windows.Forms.BindingSource getTimesBindingSource;
        private bdd_voilierDataSet3TableAdapters.getTimesTableAdapter getTimesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private bdd_voilierDataSet2 bdd_voilierDataSet2;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private bdd_voilierDataSet2TableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceClassement1;
        private System.Windows.Forms.BindingSource bindingSourceClassement2;
        private bdd_voilierDataSet2TableAdapters.EPREUVETableAdapter ePREUVETableAdapter;
        private System.Windows.Forms.BindingSource ePREUVEBindingSource;
        private System.Windows.Forms.BindingSource bddvoilierDataSet2BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdd_voilierDataSet5 bdd_voilierDataSet5;
        private System.Windows.Forms.BindingSource getTimesBindingSource1;
        private bdd_voilierDataSet5TableAdapters.getTimesTableAdapter getTimesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVoilierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsRéelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private bdd_voilierDataSet8 bdd_voilierDataSet8;
        private System.Windows.Forms.BindingSource getTimesBindingSource2;
        private bdd_voilierDataSet8TableAdapters.getTimesTableAdapter getTimesTableAdapter2;
    }
}