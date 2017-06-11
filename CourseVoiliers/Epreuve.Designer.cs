namespace CourseVoiliers
{
    partial class Epreuve
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
            this.idEpreuveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePREUVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddvoilierDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet = new CourseVoiliers.bdd_voilierDataSet();
            this.ePREUVETableAdapter = new CourseVoiliers.bdd_voilierDataSetTableAdapters.EPREUVETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePREUVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEpreuveDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ePREUVEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // idEpreuveDataGridViewTextBoxColumn
            // 
            this.idEpreuveDataGridViewTextBoxColumn.DataPropertyName = "Id_Epreuve";
            this.idEpreuveDataGridViewTextBoxColumn.HeaderText = "Id_Epreuve";
            this.idEpreuveDataGridViewTextBoxColumn.Name = "idEpreuveDataGridViewTextBoxColumn";
            this.idEpreuveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            // 
            // ePREUVEBindingSource
            // 
            this.ePREUVEBindingSource.DataMember = "EPREUVE";
            this.ePREUVEBindingSource.DataSource = this.bddvoilierDataSetBindingSource;
            // 
            // bddvoilierDataSetBindingSource
            // 
            this.bddvoilierDataSetBindingSource.DataSource = this.bdd_voilierDataSet;
            this.bddvoilierDataSetBindingSource.Position = 0;
            // 
            // bdd_voilierDataSet
            // 
            this.bdd_voilierDataSet.DataSetName = "bdd_voilierDataSet";
            this.bdd_voilierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ePREUVETableAdapter
            // 
            this.ePREUVETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Epreuve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Epreuve";
            this.Text = "Epreuve";
            this.Load += new System.EventHandler(this.Epreuve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePREUVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bddvoilierDataSetBindingSource;
        private bdd_voilierDataSet bdd_voilierDataSet;
        private System.Windows.Forms.BindingSource ePREUVEBindingSource;
        private bdd_voilierDataSetTableAdapters.EPREUVETableAdapter ePREUVETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEpreuveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}