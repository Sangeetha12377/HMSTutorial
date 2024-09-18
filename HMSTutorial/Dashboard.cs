using System;
using System.Windows.Forms;

namespace HMSTutorial
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // Code to open the Add New Patient Record form
            AddPatient addNewPatientForm = new AddPatient();
            addNewPatientForm.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            // Code to open the Full History of the Patient form
            FullHistory fullHistoryForm = new FullHistory();
            fullHistoryForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Code to open the Add Diagnosis Information form
            AddDiagnosis addDiagnosisForm = new AddDiagnosis();
            addDiagnosisForm.Show();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            // Code to open the Add Diagnosis Information form
            HospitalInformation hospitalInformationForm = new HospitalInformation();
            hospitalInformationForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Code to exit the application
            Application.Exit();
        }
    }
}
