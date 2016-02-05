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
    public partial class Form_GestionEmployes : Form
    {
        static private DataSet ds;
        private BindingSource sourceEmp = new BindingSource();
        static private OracleConnection conn_ = new OracleConnection();
        static private string DataSource = "(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
            + "(HOST=" + Properties.Settings.Default.DB_HostName
            + ")(PORT=" + Properties.Settings.Default.DB_Port.ToString()
            + ")))(CONNECT_DATA=(SERVICE_NAME=" + Properties.Settings.Default.DB_ServiceName
            + ")))";

        static private string ConnectionString;

        static private void OpenConnection()
        {
            ConnectionString = "Data Source =" + DataSource
                + " ; User Id=" + Properties.Settings.Default.DB_Username
                + " ; Password=" + Properties.Settings.Default.DB_Password + ";";

            if (conn_.State == ConnectionState.Closed)
            {
                conn_.ConnectionString = ConnectionString;
                conn_.Open();
            }
            else
            {
                throw new Exception("DB_ALREADY_OPEN");
            }
        }

        static public OracleConnection GetConnection()
        {
            if (conn_.State != ConnectionState.Open) OpenConnection();
            return conn_;
        }

        public Form_GestionEmployes()
        {
            InitializeComponent();
            ds = new DataSet();

            Load();
        }

        private void Load()
        {
            FillDepartement();
            FillEmployes();
        }

        private void FillDepartement()
        {
            lb_Departement.Items.Clear();// Reset pour ne pas avoir de surprise.
            string select_dep = @"SELECT DEPARTEMENT.NOM,COUNT(DEPARTEMENT.NOM) as NBEMP FROM DEPARTEMENT 
                INNER JOIN EMPLOYES1 ON EMPLOYES1.CODEDEP = DEPARTEMENT.CODEDEP 
                GROUP BY  DEPARTEMENT.NOM";

            GetDBData("Departement", select_dep);

            lb_Departement.Items.Add("-Tout-"); // Default

            List<string> tempList = List("Departement", "Nom");

            foreach (string dep in tempList)
            {
                lb_Departement.Items.Add(dep);
            }
        }

        private void FillEmployes()
        {
            string select_emp = @"with
                src_type_2 as (
                  select NUMEMP, EMPLOYES1.NOM, PRENOM, SALAIRE, DATEEMBAUCHE, DEPARTEMENT.NOM 
                  as NOMDEP, EMPLOYES1.NUMEMPRESP
                  from EMPLOYES1 
                  left outer join DEPARTEMENT 
                  on DEPARTEMENT.CODEDEP=EMPLOYES1.CODEDEP
                ),
                all_type_1 as (
                  SELECT NUMEMP, 
                  COALESCE(PRENOM, '') || ' ' || COALESCE(NOM, '') as RESPNOM
                  FROM EMPLOYES1
                )
                select src.NUMEMP, src.PRENOM, src.NOM, src.SALAIRE, src.DATEEMBAUCHE, src.NOMDEP, tgt.RESPNOM
                  from all_type_1 tgt
                  right join src_type_2 src on src.NUMEMPRESP = tgt.NUMEMP";

            GetDBData("employes1", select_emp);

            sourceEmp.DataSource = ds.Tables["Employes1"];
            dgv_Employes.DataSource = sourceEmp;

            dgv_Employes.Columns[0].HeaderText = "ID";
            dgv_Employes.Columns[1].HeaderText = "Prénom";
            dgv_Employes.Columns[2].HeaderText = "Nom";
            dgv_Employes.Columns[3].HeaderText = "Salaire";
            dgv_Employes.Columns[4].HeaderText = "Date d'embauche";
            dgv_Employes.Columns[5].HeaderText = "Nom du département";
            dgv_Employes.Columns[6].HeaderText = "Nom du responsable";
        }

        private static void GetDBData(string TableName, string SelectSQL)
        {
            if (ds.Tables[TableName] != null) ds.Tables[TableName].Clear();

            OracleConnection conn = GetConnection();
            OracleDataAdapter DataAdapter = new OracleDataAdapter(new OracleCommand(SelectSQL, conn));
            DataAdapter.Fill(ds, TableName);
            conn.Close();
        }

        public static List<string> List(string Table, string Column, bool Sort = true)
        {
            List<string> List = new List<string>();

            if (ds.Tables[Table].Rows.Count == 0) throw new Exception("LIST_EMPTY");

            foreach (DataRow dr in ds.Tables[Table].Rows)
            {
                List.Add(dr[Column].ToString());
            }

            // SORT
            if (Sort) List = List.OrderBy(q => q).ToList();

            return List;
        }

        private void bt_Afficher_Click(object sender, EventArgs e)
        {
            Form_AffichageEmploye form = new Form_AffichageEmploye(sourceEmp);
            form.ShowDialog();
        }

        private void dgv_Employes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgv_Employes.SelectedRows.Count == 1)
            {
                bt_Afficher_Click(null, null);
            }
        }

        private void FilterDep(string filter)
        {
            sourceEmp.Filter = "NOMDEP like '" + filter +"'";
        }

        private void lb_Departement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Departement.Text != "-Tout-") FilterDep(lb_Departement.Text);
            else FilterDep("%");
        }

        private void DeleteEmp(int empid)
        {
            string delete = "DELETE FROM EMPLOYES1 where numemp=:empid";
            OracleCommand cmd = new OracleCommand(delete, GetConnection());
            cmd.Parameters.Add(new OracleParameter("empid", empid));
            try
            {
                cmd.ExecuteNonQuery();
                FillEmployes();
            }
            catch (OracleException oe)
            {
                if (oe.Message == "ORA-02292: integrity constraint (LUSSIERM.EMPLOYES1_EMPLOYES1_FK) violated - child record found") MessageBox.Show("L'employé ne peut être supprimé - Il est référencé comme boss pour des employés.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void bt_Supprimer_Click(object sender, EventArgs e)
        {
            if (dgv_Employes.SelectedRows.Count == 1)
                DeleteEmp(int.Parse(dgv_Employes.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void bt_EmpDep_Click(object sender, EventArgs e)
        {
            Form_EmployesDepartement form = new Form_EmployesDepartement(ds.Tables["Departement"]);
            form.ShowDialog();
        }

        private void bt_Modifier_Click(object sender, EventArgs e)
        {
            Form_AffichageEmploye form = new Form_AffichageEmploye(sourceEmp, GetConnection(), double.Parse(dgv_Employes.SelectedRows[0].Cells[3].Value.ToString()));
            if (form.ShowDialog() == DialogResult.OK) FillEmployes();
        }
    }
}
