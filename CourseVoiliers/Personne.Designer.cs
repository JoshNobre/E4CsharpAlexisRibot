namespace CourseVoiliers
{
    partial class Personne
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
            this.pERSONNEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_voilierDataSet1 = new CourseVoiliers.bdd_voilierDataSet1();
            this.pERSONNETableAdapter = new CourseVoiliers.bdd_voilierDataSet1TableAdapters.PERSONNETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.idPersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomPersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPPersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villePersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse1PersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse2PersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysPersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolePersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVoilierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonneDataGridViewTextBoxColumn,
            this.nomPersonneDataGridViewTextBoxColumn,
            this.prenomPersonneDataGridViewTextBoxColumn,
            this.cPPersonneDataGridViewTextBoxColumn,
            this.villePersonneDataGridViewTextBoxColumn,
            this.adresse1PersonneDataGridViewTextBoxColumn,
            this.adresse2PersonneDataGridViewTextBoxColumn,
            this.paysPersonneDataGridViewTextBoxColumn,
            this.rolePersonneDataGridViewTextBoxColumn,
            this.idVoilierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pERSONNEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // pERSONNEBindingSource
            // 
            this.pERSONNEBindingSource.DataMember = "PERSONNE";
            this.pERSONNEBindingSource.DataSource = this.bdd_voilierDataSet1;
            // 
            // bdd_voilierDataSet1
            // 
            this.bdd_voilierDataSet1.DataSetName = "bdd_voilierDataSet1";
            this.bdd_voilierDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONNETableAdapter
            // 
            this.pERSONNETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idPersonneDataGridViewTextBoxColumn
            // 
            this.idPersonneDataGridViewTextBoxColumn.DataPropertyName = "Id_Personne";
            this.idPersonneDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.idPersonneDataGridViewTextBoxColumn.Name = "idPersonneDataGridViewTextBoxColumn";
            this.idPersonneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomPersonneDataGridViewTextBoxColumn
            // 
            this.nomPersonneDataGridViewTextBoxColumn.DataPropertyName = "Nom_Personne";
            this.nomPersonneDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomPersonneDataGridViewTextBoxColumn.Name = "nomPersonneDataGridViewTextBoxColumn";
            // 
            // prenomPersonneDataGridViewTextBoxColumn
            // 
            this.prenomPersonneDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Personne";
            this.prenomPersonneDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomPersonneDataGridViewTextBoxColumn.Name = "prenomPersonneDataGridViewTextBoxColumn";
            // 
            // cPPersonneDataGridViewTextBoxColumn
            // 
            this.cPPersonneDataGridViewTextBoxColumn.DataPropertyName = "CP_Personne";
            this.cPPersonneDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.cPPersonneDataGridViewTextBoxColumn.Name = "cPPersonneDataGridViewTextBoxColumn";
            // 
            // villePersonneDataGridViewTextBoxColumn
            // 
            this.villePersonneDataGridViewTextBoxColumn.DataPropertyName = "Ville_Personne";
            this.villePersonneDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villePersonneDataGridViewTextBoxColumn.Name = "villePersonneDataGridViewTextBoxColumn";
            // 
            // adresse1PersonneDataGridViewTextBoxColumn
            // 
            this.adresse1PersonneDataGridViewTextBoxColumn.DataPropertyName = "Adresse1_Personne";
            this.adresse1PersonneDataGridViewTextBoxColumn.HeaderText = "Adresse 1";
            this.adresse1PersonneDataGridViewTextBoxColumn.Name = "adresse1PersonneDataGridViewTextBoxColumn";
            // 
            // adresse2PersonneDataGridViewTextBoxColumn
            // 
            this.adresse2PersonneDataGridViewTextBoxColumn.DataPropertyName = "Adresse2_Personne";
            this.adresse2PersonneDataGridViewTextBoxColumn.HeaderText = "Adresse 2";
            this.adresse2PersonneDataGridViewTextBoxColumn.Name = "adresse2PersonneDataGridViewTextBoxColumn";
            // 
            // paysPersonneDataGridViewTextBoxColumn
            // 
            this.paysPersonneDataGridViewTextBoxColumn.DataPropertyName = "Pays_Personne";
            this.paysPersonneDataGridViewTextBoxColumn.HeaderText = "Pays ";
            this.paysPersonneDataGridViewTextBoxColumn.Name = "paysPersonneDataGridViewTextBoxColumn";
            // 
            // rolePersonneDataGridViewTextBoxColumn
            // 
            this.rolePersonneDataGridViewTextBoxColumn.DataPropertyName = "Role_Personne";
            this.rolePersonneDataGridViewTextBoxColumn.HeaderText = "Role";
            this.rolePersonneDataGridViewTextBoxColumn.Name = "rolePersonneDataGridViewTextBoxColumn";
            // 
            // idVoilierDataGridViewTextBoxColumn
            // 
            this.idVoilierDataGridViewTextBoxColumn.DataPropertyName = "Id_Voilier";
            this.idVoilierDataGridViewTextBoxColumn.HeaderText = "Identifiant de voilier";
            this.idVoilierDataGridViewTextBoxColumn.Name = "idVoilierDataGridViewTextBoxColumn";
            // 
            // Personne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personne";
            this.Text = "Personne";
            this.Load += new System.EventHandler(this.Personne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_voilierDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdd_voilierDataSet1 bdd_voilierDataSet1;
        private System.Windows.Forms.BindingSource pERSONNEBindingSource;
        private bdd_voilierDataSet1TableAdapters.PERSONNETableAdapter pERSONNETableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomPersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPPersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villePersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse1PersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse2PersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysPersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolePersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVoilierDataGridViewTextBoxColumn;
    }
}