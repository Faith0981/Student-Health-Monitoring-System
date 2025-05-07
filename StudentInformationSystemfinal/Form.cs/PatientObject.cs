using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StudentInformationSystemfinal.Form.cs;
using Dapper;
using System.Data.SQLite;

namespace StudentInformationSystemfinal.Form.cs
{
    public partial class PatientObject : DevExpress.XtraEditors.XtraForm
    {
        public PatientObject()
        {
            InitializeComponent();
        }
        private readonly string _connectionString = @"Data Source=.\HealthMonitoringSystem.db;Version=3;";

        private void ADDPATIENT_Click(object sender, EventArgs e)
        {
            ADD_PATIENT addPatient = new ADD_PATIENT();
            addPatient.Show();

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {

        }

        private void PatientObject_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(_connectionString)) {
                var query = connection.Query("SELECT * FROM Patient").ToList();
                gridControl1.DataSource = query;
            }
        }
    }
}