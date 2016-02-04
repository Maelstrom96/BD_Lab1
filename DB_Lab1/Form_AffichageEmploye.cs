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

        public Form_AffichageEmploye(BindingSource source)
        {
            InitializeComponent();

            _bs = source;
            Bind();
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
    }
}
