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
    public partial class Form_AjouterEmploye : Form
    {
        private OracleConnection _conn;

        public Form_AjouterEmploye(List<String> Departements, OracleConnection conn)
        {
            InitializeComponent();

            _conn = conn;

            // Set departement
            cb_Dept.Items.Clear();
            foreach (String dep in Departements)
            {
                cb_Dept.Items.Add(dep);
            }
        }

        private void bt_Enregistrer_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO EMPLOYES1 VALUES (SEQNUMEMP.NEXTVAL, :nom , :prenom , :salaire , :dateembauche , (SELECT CODEDEP FROM DEPARTEMENT WHERE NOM=:departement ), :responsable )";

            try
            {
                if (tb_Nom.Text.Equals(String.Empty)) throw new Exception("Le nom est vide.");
                if (tb_Prenom.Text.Equals(String.Empty)) throw new Exception("Le prénom est vide.");
                if (tb_Resp.Text.Equals(String.Empty)) throw new Exception("Le responsable est vide.");
                if (tb_Salaire.Text.Equals(string.Empty)) throw new Exception("Le salaire est vide.");
                if (double.Parse(tb_Salaire.Text) < 0) throw new Exception("Le salaire ne peut pas être négatif.");
                if (double.Parse(tb_Salaire.Text) >= 500000) throw new Exception("Le salaire doit être plus petit que 500 000.");

                OracleCommand cmd = new OracleCommand(insert, _conn);

                cmd.Parameters.Add(new OracleParameter("nom", tb_Nom.Text));
                cmd.Parameters.Add(new OracleParameter("prenom", tb_Prenom.Text));
                cmd.Parameters.Add(new OracleParameter("salaire", double.Parse(tb_Salaire.Text)));
                cmd.Parameters.Add(new OracleParameter("dateembauche", dtp_date.Value.Date));
                cmd.Parameters.Add(new OracleParameter("departement", cb_Dept.Text));
                cmd.Parameters.Add(new OracleParameter("responsable", tb_Resp.Text));

                cmd.ExecuteNonQuery();
                _conn.Close();

                MessageBox.Show("L'employé a été ajouté.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
