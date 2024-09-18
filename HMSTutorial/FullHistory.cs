using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMSTutorial
{
    public partial class FullHistory : Form
    {
        public FullHistory()
        {
            InitializeComponent();
        }
        //private void button7_Click(object sender, EventArgs e)
        //{
        //    // Create and show FullHistory form
        //    FullHistory fullHistoryForm = new FullHistory();
        //    fullHistoryForm.Show();
        //}


        private void FullHistory_Load(object sender, EventArgs e)
        {
            LoadPatientHistory();
        }

        private void LoadPatientHistory()
        {
            string connectionString = "Server=LAPTOP-5KOMBA96\\SQLEXPRESS;Database = HospitalDB;Trusted_Connection=True";
            string query = @"
                SELECT p.PatientID, p.Name, p.ContactNumber, p.Gender, p.Age, p.Address, p.BloodGroup, d.DiagnosisId, d.Diagnosis, d.Medicines, d.Symptoms, d.WardTYpe, d.WardRequired
                FROM Patients p
                JOIN Diagnosis d ON p.PatientID = d.PatientID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
