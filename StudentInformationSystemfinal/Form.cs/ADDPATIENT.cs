﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StudentInformationSystemfinal.Models;
using Dapper;
using System.Data.SQLite;

namespace StudentInformationSystemfinal.Form.cs
{
    public partial class ADD_PATIENT : DevExpress.XtraEditors.XtraForm
    {
        public ADD_PATIENT()
        {
            InitializeComponent();
        }

        private readonly string _connectionString = @"Data Source=.\HealthMonitoringSystem.db;Version=3;";

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void ADDPATIENT_Click(object sender, EventArgs e)
        {
            string firstName = FIRSTNAMEBUTTON.Text;
            string lastName = LASTNAMEBUTTON.Text;
            int age = Convert.ToInt32(textEdit1.Text);
            string grade = textEdit1.Text;
            string birthDate = BIRTHDATEBUTTON.Text;
            string parentGuardian = textEdit3.Text;
            string address = textEdit4.Text;
            string emergencyContactPerson = textEdit6.Text;
            long phoneNumber = long.Parse(textEdit7.Text);
            string knownAllergies = textEdit8.Text;
            string generalInformation = textEdit9.Text;

            var patient = new Patient
            {
               FirstName = firstName,
               LastName = lastName,
               Age = age,
              BirthDate = birthDate,
               ParentGuardianName = parentGuardian,
               Address = address,
               EmergencyContactPerson = emergencyContactPerson,
               EmergencyContactNumber = phoneNumber,
               KnownAllergies = knownAllergies,
               GeneralInformation = generalInformation
            };

            using (var connection = new SQLiteConnection(_connectionString)) {
                var insertQuery = @"INSERT INTO Patient (FirstName, LastName, Age, BirthDate, ParentGuardianName, Address, EmergencyContactPerson, EmergencyContactNumber, KnownAllergies, GeneralInformation)
                                    VALUES (@FirstName, @LastName, @Age, @BirthDate, @ParentGuardianName, @Address, @EmergencyContactPerson, @EmergencyContactNumber, @KnownAllergies, @GeneralInformation)";
                connection.Execute(insertQuery, patient);
                XtraMessageBox.Show("Patient added successfully");
            }
        }
    }
}