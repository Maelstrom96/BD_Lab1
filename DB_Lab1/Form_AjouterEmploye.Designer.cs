namespace DB_Lab1
{
    partial class Form_AjouterEmploye
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
            this.tb_Salaire = new System.Windows.Forms.TextBox();
            this.txt_RespEmp = new System.Windows.Forms.Label();
            this.txt_Departement = new System.Windows.Forms.Label();
            this.txt_DateEmbauche = new System.Windows.Forms.Label();
            this.lb_SalaireEmp = new System.Windows.Forms.Label();
            this.txt_SalaireEmp = new System.Windows.Forms.Label();
            this.txt_PrenomEmp = new System.Windows.Forms.Label();
            this.txt_NomEmp = new System.Windows.Forms.Label();
            this.bt_Enregistrer = new System.Windows.Forms.Button();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.tb_Resp = new System.Windows.Forms.TextBox();
            this.cb_Dept = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tb_Salaire
            // 
            this.tb_Salaire.Location = new System.Drawing.Point(133, 59);
            this.tb_Salaire.Name = "tb_Salaire";
            this.tb_Salaire.Size = new System.Drawing.Size(150, 20);
            this.tb_Salaire.TabIndex = 3;
            // 
            // txt_RespEmp
            // 
            this.txt_RespEmp.Location = new System.Drawing.Point(-62, 144);
            this.txt_RespEmp.Name = "txt_RespEmp";
            this.txt_RespEmp.Size = new System.Drawing.Size(189, 23);
            this.txt_RespEmp.TabIndex = 6;
            this.txt_RespEmp.Text = "Responsable directe :";
            this.txt_RespEmp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Departement
            // 
            this.txt_Departement.Location = new System.Drawing.Point(27, 121);
            this.txt_Departement.Name = "txt_Departement";
            this.txt_Departement.Size = new System.Drawing.Size(100, 23);
            this.txt_Departement.TabIndex = 0;
            this.txt_Departement.Text = "Departement :";
            this.txt_Departement.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_DateEmbauche
            // 
            this.txt_DateEmbauche.Location = new System.Drawing.Point(27, 92);
            this.txt_DateEmbauche.Name = "txt_DateEmbauche";
            this.txt_DateEmbauche.Size = new System.Drawing.Size(100, 23);
            this.txt_DateEmbauche.TabIndex = 0;
            this.txt_DateEmbauche.Text = "Date d\'embauche :";
            this.txt_DateEmbauche.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_SalaireEmp
            // 
            this.lb_SalaireEmp.AutoSize = true;
            this.lb_SalaireEmp.Location = new System.Drawing.Point(133, 62);
            this.lb_SalaireEmp.Name = "lb_SalaireEmp";
            this.lb_SalaireEmp.Size = new System.Drawing.Size(22, 13);
            this.lb_SalaireEmp.TabIndex = 0;
            this.lb_SalaireEmp.Text = "2 $";
            // 
            // txt_SalaireEmp
            // 
            this.txt_SalaireEmp.Location = new System.Drawing.Point(27, 62);
            this.txt_SalaireEmp.Name = "txt_SalaireEmp";
            this.txt_SalaireEmp.Size = new System.Drawing.Size(100, 23);
            this.txt_SalaireEmp.TabIndex = 0;
            this.txt_SalaireEmp.Text = "Salaire :";
            this.txt_SalaireEmp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_PrenomEmp
            // 
            this.txt_PrenomEmp.Location = new System.Drawing.Point(27, 36);
            this.txt_PrenomEmp.Name = "txt_PrenomEmp";
            this.txt_PrenomEmp.Size = new System.Drawing.Size(100, 23);
            this.txt_PrenomEmp.TabIndex = 0;
            this.txt_PrenomEmp.Text = "Prénom :";
            this.txt_PrenomEmp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_NomEmp
            // 
            this.txt_NomEmp.Location = new System.Drawing.Point(27, 11);
            this.txt_NomEmp.Name = "txt_NomEmp";
            this.txt_NomEmp.Size = new System.Drawing.Size(100, 23);
            this.txt_NomEmp.TabIndex = 0;
            this.txt_NomEmp.Text = "Nom :";
            this.txt_NomEmp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bt_Enregistrer
            // 
            this.bt_Enregistrer.Location = new System.Drawing.Point(157, 187);
            this.bt_Enregistrer.Name = "bt_Enregistrer";
            this.bt_Enregistrer.Size = new System.Drawing.Size(97, 23);
            this.bt_Enregistrer.TabIndex = 7;
            this.bt_Enregistrer.Text = "Enregistrer";
            this.bt_Enregistrer.UseVisualStyleBackColor = true;
            this.bt_Enregistrer.Click += new System.EventHandler(this.bt_Enregistrer_Click);
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.Location = new System.Drawing.Point(133, 33);
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(150, 20);
            this.tb_Prenom.TabIndex = 2;
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(133, 8);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(150, 20);
            this.tb_Nom.TabIndex = 1;
            // 
            // tb_Resp
            // 
            this.tb_Resp.Location = new System.Drawing.Point(133, 144);
            this.tb_Resp.Name = "tb_Resp";
            this.tb_Resp.Size = new System.Drawing.Size(150, 20);
            this.tb_Resp.TabIndex = 6;
            // 
            // cb_Dept
            // 
            this.cb_Dept.FormattingEnabled = true;
            this.cb_Dept.Location = new System.Drawing.Point(133, 118);
            this.cb_Dept.Name = "cb_Dept";
            this.cb_Dept.Size = new System.Drawing.Size(150, 21);
            this.cb_Dept.TabIndex = 5;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(133, 88);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(150, 20);
            this.dtp_date.TabIndex = 4;
            // 
            // Form_AjouterEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 237);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cb_Dept);
            this.Controls.Add(this.bt_Enregistrer);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.tb_Resp);
            this.Controls.Add(this.tb_Salaire);
            this.Controls.Add(this.txt_RespEmp);
            this.Controls.Add(this.txt_Departement);
            this.Controls.Add(this.txt_DateEmbauche);
            this.Controls.Add(this.lb_SalaireEmp);
            this.Controls.Add(this.txt_SalaireEmp);
            this.Controls.Add(this.txt_PrenomEmp);
            this.Controls.Add(this.txt_NomEmp);
            this.Name = "Form_AjouterEmploye";
            this.Text = "Form_AjouterEmploye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Salaire;
        private System.Windows.Forms.Label txt_RespEmp;
        private System.Windows.Forms.Label txt_Departement;
        private System.Windows.Forms.Label txt_DateEmbauche;
        private System.Windows.Forms.Label lb_SalaireEmp;
        private System.Windows.Forms.Label txt_SalaireEmp;
        private System.Windows.Forms.Label txt_PrenomEmp;
        private System.Windows.Forms.Label txt_NomEmp;
        private System.Windows.Forms.Button bt_Enregistrer;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.TextBox tb_Resp;
        private System.Windows.Forms.ComboBox cb_Dept;
        private System.Windows.Forms.DateTimePicker dtp_date;
    }
}