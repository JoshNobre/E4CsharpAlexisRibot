namespace CourseVoiliers
{
    partial class Voilier
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
            this.bdd_voilierDataSet2 = new CourseVoiliers.bdd_voilierDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vOILIERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vOILIERTableAdapter1 = new CourseVoiliers.bdd_voilierDataSet2TableAdapters.VOILIERTableAdapter();
            this.bdd_voilierDataSet3 = new CourseVoiliers.bdd_voilierDataSet3();
            this.bddvoilierDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet4 = new CourseVoiliers.bdd_voilierDataSet4();
            this.inscriptionCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscriptionCourseTableAdapter = new CourseVoiliers.bdd_voilierDataSet4TableAdapters.InscriptionCourseTableAdapter();
            this.idVoilierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVoilierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longueurVoilierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOILIERBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bdd_voilierDataSet2
            // 
            this.bdd_voilierDataSet2.DataSetName = "bdd_voilierDataSet2";
            this.bdd_voilierDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVoilierDataGridViewTextBoxColumn,
            this.nomVoilierDataGridViewTextBoxColumn,
            this.longueurVoilierDataGridViewTextBoxColumn,
            this.nomCourseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inscriptionCourseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vOILIERBindingSource2
            // 
            this.vOILIERBindingSource2.DataMember = "VOILIER";
            this.vOILIERBindingSource2.DataSource = this.bdd_voilierDataSet2;
            // 
            // vOILIERTableAdapter1
            // 
            this.vOILIERTableAdapter1.ClearBeforeFill = true;
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
            // bdd_voilierDataSet4
            // 
            this.bdd_voilierDataSet4.DataSetName = "bdd_voilierDataSet4";
            this.bdd_voilierDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscriptionCourseBindingSource
            // 
            this.inscriptionCourseBindingSource.DataMember = "InscriptionCourse";
            this.inscriptionCourseBindingSource.DataSource = this.bdd_voilierDataSet4;
            // 
            // inscriptionCourseTableAdapter
            // 
            this.inscriptionCourseTableAdapter.ClearBeforeFill = true;
            // 
            // idVoilierDataGridViewTextBoxColumn
            // 
            this.idVoilierDataGridViewTextBoxColumn.DataPropertyName = "Id_Voilier";
            this.idVoilierDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.idVoilierDataGridViewTextBoxColumn.Name = "idVoilierDataGridViewTextBoxColumn";
            // 
            // nomVoilierDataGridViewTextBoxColumn
            // 
            this.nomVoilierDataGridViewTextBoxColumn.DataPropertyName = "Nom_Voilier";
            this.nomVoilierDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomVoilierDataGridViewTextBoxColumn.Name = "nomVoilierDataGridViewTextBoxColumn";
            // 
            // longueurVoilierDataGridViewTextBoxColumn
            // 
            this.longueurVoilierDataGridViewTextBoxColumn.DataPropertyName = "Longueur_Voilier";
            this.longueurVoilierDataGridViewTextBoxColumn.HeaderText = "Longueur";
            this.longueurVoilierDataGridViewTextBoxColumn.Name = "longueurVoilierDataGridViewTextBoxColumn";
            // 
            // nomCourseDataGridViewTextBoxColumn
            // 
            this.nomCourseDataGridViewTextBoxColumn.DataPropertyName = "Nom_Course";
            this.nomCourseDataGridViewTextBoxColumn.HeaderText = "Nom de la course";
            this.nomCourseDataGridViewTextBoxColumn.Name = "nomCourseDataGridViewTextBoxColumn";
            // 
            // Voilier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 271);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Voilier";
            this.Text = "Voilier";
            this.Load += new System.EventHandler(this.Voilier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOILIERBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvoilierDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionCourseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private bdd_voilierDataSet2 bdd_voilierDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vOILIERBindingSource2;
        private bdd_voilierDataSet2TableAdapters.VOILIERTableAdapter vOILIERTableAdapter1;
        private System.Windows.Forms.BindingSource bddvoilierDataSet3BindingSource;
        private bdd_voilierDataSet3 bdd_voilierDataSet3;
        private bdd_voilierDataSet4 bdd_voilierDataSet4;
        private System.Windows.Forms.BindingSource inscriptionCourseBindingSource;
        private bdd_voilierDataSet4TableAdapters.InscriptionCourseTableAdapter inscriptionCourseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVoilierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVoilierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longueurVoilierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCourseDataGridViewTextBoxColumn;
    }
}