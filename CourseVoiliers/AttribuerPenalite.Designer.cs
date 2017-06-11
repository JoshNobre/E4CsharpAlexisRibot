namespace CourseVoiliers
{
    partial class AttribuerPenalite
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
            this.sevoireattribuerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.se_voire_attribuerTableAdapter = new CourseVoiliers.bdd_voilierDataSetTableAdapters.se_voire_attribuerTableAdapter();
            this.idPenaliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEpreuveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVoilierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevoireattribuerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPenaliteDataGridViewTextBoxColumn,
            this.idEpreuveDataGridViewTextBoxColumn,
            this.idCourseDataGridViewTextBoxColumn,
            this.idVoilierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sevoireattribuerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdd_voilierDataSet
            // 
            this.bdd_voilierDataSet.DataSetName = "bdd_voilierDataSet";
            this.bdd_voilierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sevoireattribuerBindingSource
            // 
            this.sevoireattribuerBindingSource.DataMember = "se_voire_attribuer";
            this.sevoireattribuerBindingSource.DataSource = this.bdd_voilierDataSet;
            // 
            // se_voire_attribuerTableAdapter
            // 
            this.se_voire_attribuerTableAdapter.ClearBeforeFill = true;
            // 
            // idPenaliteDataGridViewTextBoxColumn
            // 
            this.idPenaliteDataGridViewTextBoxColumn.DataPropertyName = "Id_Penalite";
            this.idPenaliteDataGridViewTextBoxColumn.HeaderText = "Id_Penalite";
            this.idPenaliteDataGridViewTextBoxColumn.Name = "idPenaliteDataGridViewTextBoxColumn";
            // 
            // idEpreuveDataGridViewTextBoxColumn
            // 
            this.idEpreuveDataGridViewTextBoxColumn.DataPropertyName = "Id_Epreuve";
            this.idEpreuveDataGridViewTextBoxColumn.HeaderText = "Id_Epreuve";
            this.idEpreuveDataGridViewTextBoxColumn.Name = "idEpreuveDataGridViewTextBoxColumn";
            // 
            // idCourseDataGridViewTextBoxColumn
            // 
            this.idCourseDataGridViewTextBoxColumn.DataPropertyName = "Id_Course";
            this.idCourseDataGridViewTextBoxColumn.HeaderText = "Id_Course";
            this.idCourseDataGridViewTextBoxColumn.Name = "idCourseDataGridViewTextBoxColumn";
            // 
            // idVoilierDataGridViewTextBoxColumn
            // 
            this.idVoilierDataGridViewTextBoxColumn.DataPropertyName = "Id_Voilier";
            this.idVoilierDataGridViewTextBoxColumn.HeaderText = "Id_Voilier";
            this.idVoilierDataGridViewTextBoxColumn.Name = "idVoilierDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttribuerPenalite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AttribuerPenalite";
            this.Text = "AttribuerPenalite";
            this.Load += new System.EventHandler(this.AttribuerPenalite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevoireattribuerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdd_voilierDataSet bdd_voilierDataSet;
        private System.Windows.Forms.BindingSource sevoireattribuerBindingSource;
        private bdd_voilierDataSetTableAdapters.se_voire_attribuerTableAdapter se_voire_attribuerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPenaliteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEpreuveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVoilierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}