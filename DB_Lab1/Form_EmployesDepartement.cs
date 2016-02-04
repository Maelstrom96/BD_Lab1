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
    public partial class Form_EmployesDepartement : Form
    {
        private DataTable _dt;
        public Form_EmployesDepartement(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;

            dgv_empdep.DataSource = _dt;

            dgv_empdep.Columns[0].HeaderText = "Nom du département";
            dgv_empdep.Columns[1].HeaderText = "Nombre d'employés";
        }
    }
}
