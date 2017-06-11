namespace CourseVoiliers
{
    partial class Penalite
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdd_voilierDataSet = new CourseVoiliers.bdd_voilierDataSet();
            this.pENALITEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pENALITETableAdapter = new CourseVoiliers.bdd_voilierDataSetTableAdapters.PENALITETableAdapter();
            this.idPenaliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsPenaliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPenaliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePenaliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENALITEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPenaliteDataGridViewTextBoxColumn,
            this.tempsPenaliteDataGridViewTextBoxColumn,
            this.nomPenaliteDataGridViewTextBoxColumn,
            this.codePenaliteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pENALITEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 137);
            this.dataGridView1.TabIndex = 2;
            // 
            // bdd_voilierDataSet
            // 
            this.bdd_voilierDataSet.DataSetName = "bdd_voilierDataSet";
            this.bdd_voilierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pENALITEBindingSource
            // 
            this.pENALITEBindingSource.DataMember = "PENALITE";
            this.pENALITEBindingSource.DataSource = this.bdd_voilierDataSet;
            // 
            // pENALITETableAdapter
            // 
            this.pENALITETableAdapter.ClearBeforeFill = true;
            // 
            // idPenaliteDataGridViewTextBoxColumn
            // 
            this.idPenaliteDataGridViewTextBoxColumn.DataPropertyName = "Id_Penalite";
            this.idPenaliteDataGridViewTextBoxColumn.HeaderText = "Id_Penalite";
            this.idPenaliteDataGridViewTextBoxColumn.Name = "idPenaliteDataGridViewTextBoxColumn";
            // 
            // tempsPenaliteDataGridViewTextBoxColumn
            // 
            this.tempsPenaliteDataGridViewTextBoxColumn.DataPropertyName = "Temps_Penalite";
            this.tempsPenaliteDataGridViewTextBoxColumn.HeaderText = "Temps_Penalite";
            this.tempsPenaliteDataGridViewTextBoxColumn.Name = "tempsPenaliteDataGridViewTextBoxColumn";
            // 
            // nomPenaliteDataGridViewTextBoxColumn
            // 
            this.nomPenaliteDataGridViewTextBoxColumn.DataPropertyName = "Nom_Penalite";
            this.nomPenaliteDataGridViewTextBoxColumn.HeaderText = "Nom_Penalite";
            this.nomPenaliteDataGridViewTextBoxColumn.Name = "nomPenaliteDataGridViewTextBoxColumn";
            // 
            // codePenaliteDataGridViewTextBoxColumn
            // 
            this.codePenaliteDataGridViewTextBoxColumn.DataPropertyName = "Code_Penalite";
            this.codePenaliteDataGridViewTextBoxColumn.HeaderText = "Code_Penalite";
            this.codePenaliteDataGridViewTextBoxColumn.Name = "codePenaliteDataGridViewTextBoxColumn";
            // 
            // Penalite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 318);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Penalite";
            this.Text = "Penalite";
            this.Load += new System.EventHandler(this.Penalite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pENALITEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdd_voilierDataSet bdd_voilierDataSet;
        private System.Windows.Forms.BindingSource pENALITEBindingSource;
        private bdd_voilierDataSetTableAdapters.PENALITETableAdapter pENALITETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPenaliteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsPenaliteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPenaliteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePenaliteDataGridViewTextBoxColumn;
    }
}