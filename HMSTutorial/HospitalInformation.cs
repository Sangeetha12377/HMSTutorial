using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMSTutorial
{
    public partial class HospitalInformation : Form
    {
        public HospitalInformation()
        {
            InitializeComponent();
            LoadHospitalData(); // Call to load data when form is initialized
        }

        private void LoadHospitalData()
        {
            try
            {
                // Replace with your actual connection string
                string connectionString = "Server=LAPTOP-5KOMBA96\\SQLEXPRESS;Database = HospitalDB;Trusted_Connection=True";
                string query = "SELECT HospitalName, Address, Contact, Departments, NumberOfBeds, Facilities, Timings, DoctorAvailability, About FROM HospitalInformation";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No data available.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message);
            }
        }
    }
}
