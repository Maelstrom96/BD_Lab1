namespace DB_Lab1
{
    partial class Form_GestionEmployes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Employes = new System.Windows.Forms.DataGridView();
            this.lv_Departements = new System.Windows.Forms.ListView();
            this.txt_Departement = new System.Windows.Forms.Label();
            this.bt_Afficher = new System.Windows.Forms.Button();
            this.bt_Modifier = new System.Windows.Forms.Button();
            this.bt_Supprimer = new System.Windows.Forms.Button();
            this.bt_Ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Employes
            // 
            this.dgv_Employes.AllowUserToAddRows = false;
            this.dgv_Employes.AllowUserToDeleteRows = false;
            this.dgv_Employes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employes.Location = new System.Drawing.Point(12, 30);
            this.dgv_Employes.Name = "dgv_Employes";
            this.dgv_Employes.ReadOnly = true;
            this.dgv_Employes.Size = new System.Drawing.Size(693, 481);
            this.dgv_Employes.TabIndex = 0;
            // 
            // lv_Departements
            // 
            this.lv_Departements.Location = new System.Drawing.Point(731, 96);
            this.lv_Departements.Name = "lv_Departements";
            this.lv_Departements.Size = new System.Drawing.Size(222, 415);
            this.lv_Departements.TabIndex = 1;
            this.lv_Departements.UseCompatibleStateImageBehavior = false;
            // 
            // txt_Departement
            // 
            this.txt_Departement.AutoSize = true;
            this.txt_Departement.Font = new System.Drawing.Font("Myriad Pro", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Departement.Location = new System.Drawing.Point(753, 61);
            this.txt_Departement.Name = "txt_Departement";
            this.txt_Departement.Size = new System.Drawing.Size(180, 32);
            this.txt_Departement.TabIndex = 2;
            this.txt_Departement.Text = "Departements";
            // 
            // bt_Afficher
            // 
            this.bt_Afficher.Location = new System.Drawing.Point(23, 522);
            this.bt_Afficher.Name = "bt_Afficher";
            this.bt_Afficher.Size = new System.Drawing.Size(75, 23);
            this.bt_Afficher.TabIndex = 3;
            this.bt_Afficher.Text = "Afficher";
            this.bt_Afficher.UseVisualStyleBackColor = true;
            // 
            // bt_Modifier
            // 
            this.bt_Modifier.Location = new System.Drawing.Point(206, 522);
            this.bt_Modifier.Name = "bt_Modifier";
            this.bt_Modifier.Size = new System.Drawing.Size(75, 23);
            this.bt_Modifier.TabIndex = 4;
            this.bt_Modifier.Text = "Modifier";
            this.bt_Modifier.UseVisualStyleBackColor = true;
            // 
            // bt_Supprimer
            // 
            this.bt_Supprimer.Location = new System.Drawing.Point(298, 522);
            this.bt_Supprimer.Name = "bt_Supprimer";
            this.bt_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.bt_Supprimer.TabIndex = 5;
            this.bt_Supprimer.Text = "Supprimer";
            this.bt_Supprimer.UseVisualStyleBackColor = true;
            // 
            // bt_Ajouter
            // 
            this.bt_Ajouter.Location = new System.Drawing.Point(115, 522);
            this.bt_Ajouter.Name = "bt_Ajouter";
            this.bt_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.bt_Ajouter.TabIndex = 4;
            this.bt_Ajouter.Text = "Ajouter";
            this.bt_Ajouter.UseVisualStyleBackColor = true;
            // 
            // Form_GestionEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 589);
            this.Controls.Add(this.bt_Supprimer);
            this.Controls.Add(this.bt_Ajouter);
            this.Controls.Add(this.bt_Modifier);
            this.Controls.Add(this.bt_Afficher);
            this.Controls.Add(this.txt_Departement);
            this.Controls.Add(this.lv_Departements);
            this.Controls.Add(this.dgv_Employes);
            this.Name = "Form_GestionEmployes";
            this.Text = "Gestion des employés";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Employes;
        private System.Windows.Forms.ListView lv_Departements;
        private System.Windows.Forms.Label txt_Departement;
        private System.Windows.Forms.Button bt_Afficher;
        private System.Windows.Forms.Button bt_Modifier;
        private System.Windows.Forms.Button bt_Supprimer;
        private System.Windows.Forms.Button bt_Ajouter;
    }
}

