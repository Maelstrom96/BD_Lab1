using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab1
{
    public partial class Form_AffichageEmploye : Form
    {
        private BindingSource _bs;
        private OracleConnection _conn;

        public Form_AffichageEmploye(BindingSource source)
        {
            InitializeComponent();

            _bs = source;
            Bind();
        }

        public Form_AffichageEmploye(BindingSource source, OracleConnection conn, double salaire)
        {
            InitializeComponent();

            _bs = source;
            _conn = conn;
            Bind();
            this.DialogResult = DialogResult.Abort;

            lb_SalaireEmp.DataBindings.Clear();
            lb_SalaireEmp.Text = string.Empty;
            tb_Salaire.Text = salaire.ToString();
            tb_Salaire.Show();
            bt_Enregistrer.Show();

            // Hide
            bt_Debut.Hide();
            bt_Fin.Hide();
            bt_Precedent.Hide();
            bt_Suivant.Hide();
        }

        public void Bind()
        {
            lb_DateEmbauche.DataBindings.Add("text", _bs, "DATEEMBAUCHE");
            lb_Departement.DataBindings.Add("text", _bs, "NOMDEP");
            lb_NomEmp.DataBindings.Add("text", _bs, "NOM");
            lb_NumEmp.DataBindings.Add("text", _bs, "NUMEMP");
            lb_PrenomEmp.DataBindings.Add("text", _bs, "PRENOM");
            lb_RespEmp.DataBindings.Add("text", _bs, "RESPNOM");
            lb_SalaireEmp.DataBindings.Add("text", _bs, "SALAIRE");
        }

        private void Load()
        {

        }

        private void bt_Suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[_bs].Position += 1;
        }

        private void bt_Fin_Click(object sender, EventArgs e)
        {
            this.BindingContext[_bs].Position = this.BindingContext[_bs].Count;
        }

        private void bt_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[_bs].Position -= 1;
        }

        private void bt_Debut_Click(object sender, EventArgs e)
        {
            this.BindingContext[_bs].Position = 0;
        }

        private void Enregistrer(object sender, EventArgs e)
        {
            try
            {
                if (tb_Salaire.Text.Equals(string.Empty)) throw new Exception("Le salaire ne peut pas être vide.");
                if (double.Parse(tb_Salaire.Text) < 0) throw new Exception("Le salaire ne peut pas être négatif.");
                if (double.Parse(tb_Salaire.Text) >= 500000) throw new Exception("Le salaire doit être plus petit que 500 000.");

                string update = "UPDATE EMPLOYES1 SET SALAIRE=:SAL WHERE NUMEMP=:ID";

                OracleCommand cmd = new OracleCommand(update, _conn);

                cmd.Parameters.Add(new OracleParameter("SAL", double.Parse(tb_Salaire.Text)));
                cmd.Parameters.Add(new OracleParameter("ID", int.Parse(lb_NumEmp.Text)));

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("L'employé a été mis à jour.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("Une erreur c'est produite. (ExecuteNonQuery returned 0)");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
