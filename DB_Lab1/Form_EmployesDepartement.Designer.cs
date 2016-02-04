namespace DB_Lab1
{
    partial class Form_EmployesDepartement
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
            this.dgv_empdep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empdep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_empdep
            // 
            this.dgv_empdep.AllowUserToAddRows = false;
            this.dgv_empdep.AllowUserToDeleteRows = false;
            this.dgv_empdep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empdep.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_empdep.Location = new System.Drawing.Point(12, 12);
            this.dgv_empdep.MultiSelect = false;
            this.dgv_empdep.Name = "dgv_empdep";
            this.dgv_empdep.ReadOnly = true;
            this.dgv_empdep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_empdep.Size = new System.Drawing.Size(357, 418);
            this.dgv_empdep.TabIndex = 0;
            // 
            // Form_EmployesDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 444);
            this.Controls.Add(this.dgv_empdep);
            this.Name = "Form_EmployesDepartement";
            this.Text = "Form_EmployesDepartement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empdep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_empdep;
    }
}