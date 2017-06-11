namespace CourseVoiliers
{
    partial class VEC
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
            this.bdd_voilierDataSet_ALL = new CourseVoiliers.bdd_voilierDataSet_ALL();
            this.vECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vECTableAdapter = new CourseVoiliers.bdd_voilierDataSet_ALLTableAdapters.VECTableAdapter();
            this.heureDepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureArriveeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOrdreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEpreuveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVoilierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet_ALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vECBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heureDepartDataGridViewTextBoxColumn,
            this.heureArriveeDataGridViewTextBoxColumn,
            this.numOrdreDataGridViewTextBoxColumn,
            this.idEpreuveDataGridViewTextBoxColumn,
            this.idCourseDataGridViewTextBoxColumn,
            this.idVoilierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vECBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdd_voilierDataSet_ALL
            // 
            this.bdd_voilierDataSet_ALL.DataSetName = "bdd_voilierDataSet_ALL";
            this.bdd_voilierDataSet_ALL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vECBindingSource
            // 
            this.vECBindingSource.DataMember = "VEC";
            this.vECBindingSource.DataSource = this.bdd_voilierDataSet_ALL;
            // 
            // vECTableAdapter
            // 
            this.vECTableAdapter.ClearBeforeFill = true;
            // 
            // heureDepartDataGridViewTextBoxColumn
            // 
            this.heureDepartDataGridViewTextBoxColumn.DataPropertyName = "HeureDepart";
            this.heureDepartDataGridViewTextBoxColumn.HeaderText = "HeureDepart";
            this.heureDepartDataGridViewTextBoxColumn.Name = "heureDepartDataGridViewTextBoxColumn";
            // 
            // heureArriveeDataGridViewTextBoxColumn
            // 
            this.heureArriveeDataGridViewTextBoxColumn.DataPropertyName = "HeureArrivee";
            this.heureArriveeDataGridViewTextBoxColumn.HeaderText = "HeureArrivee";
            this.heureArriveeDataGridViewTextBoxColumn.Name = "heureArriveeDataGridViewTextBoxColumn";
            // 
            // numOrdreDataGridViewTextBoxColumn
            // 
            this.numOrdreDataGridViewTextBoxColumn.DataPropertyName = "Num_Ordre";
            this.numOrdreDataGridViewTextBoxColumn.HeaderText = "Num_Ordre";
            this.numOrdreDataGridViewTextBoxColumn.Name = "numOrdreDataGridViewTextBoxColumn";
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
            this.button1.Location = new System.Drawing.Point(22, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VEC";
            this.Text = "VEC";
            this.Load += new System.EventHandler(this.VEC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet_ALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vECBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdd_voilierDataSet_ALL bdd_voilierDataSet_ALL;
        private System.Windows.Forms.BindingSource vECBindingSource;
        private bdd_voilierDataSet_ALLTableAdapters.VECTableAdapter vECTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureArriveeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOrdreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEpreuveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVoilierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}