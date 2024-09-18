using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMSTutorial
{
    public partial class AddDiagnosis : Form
    {
        public AddDiagnosis()
        {
            InitializeComponent();
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
            // Check if the input in textId is not empty
            if (!string.IsNullOrEmpty(textId.Text))
            {
                try
                {
                    // Step 1: Validate PatientId (Input Validation)
                    if (!int.TryParse(textId.Text, out int PatientId))
                    {
                        MessageBox.Show("Please enter a valid Patient ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Step 2: Establish a connection to the database
                    using (SqlConnection con = new SqlConnection("data source = LAPTOP-5KOMBA96\\SQLEXPRESS; database = HospitalDB; integrated security = True"))
                    {
                        // Open the connection
                        con.Open();

                        // Step 3: Retrieve Data Based on PatientId
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patients WHERE PatientId = @PatientId", con))
                        {
                            // Use parameterized query to prevent SQL injection
                            cmd.Parameters.AddWithValue("@PatientId", PatientId);

                            // Execute the query and fill the DataGridView
                            SqlDataAdapter DA = new SqlDataAdapter(cmd);
                            DataSet DS = new DataSet();
                            DA.Fill(DS);

                            // If data is found, bind to the DataGridView, else show a message
                            if (DS.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = DS.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No patient found with this ID.", "Patient Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.DataSource = null; // Clear DataGridView
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display any errors
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void btnSave1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            try
            {
                // Step 1: Validate Input
                int PatientId;
                if (!int.TryParse(textId.Text, out PatientId))
                {
                    MessageBox.Show("Please enter a valid Patient ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure all required fields are filled
                if (string.IsNullOrEmpty(textSymptoms.Text) || string.IsNullOrEmpty(textDiagnosis.Text) ||
                    string.IsNullOrEmpty(textMedicines.Text) || comboWard.SelectedIndex == -1 || comboType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all fields before saving.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Step 2: Establish a connection to the database
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-5KOMBA96\\SQLEXPRESS; database = HospitalDB; integrated security = True"))
                {
                    // Open the connection
                    con.Open();

                    // Step 3: Create an SQL command to insert the data
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Diagnosis (PatientId, Symptoms, Diagnosis, Medicines, WardType, WardRequired) VALUES (@PatientId, @Symptoms, @Diagnosis, @Medicines, @WardType, @WardRequired)", con))
                    {
                        // Step 4: Set up the parameters
                        cmd.Parameters.AddWithValue("@PatientId", PatientId);
                        cmd.Parameters.AddWithValue("@Symptoms", textSymptoms.Text);
                        cmd.Parameters.AddWithValue("@Diagnosis", textDiagnosis.Text);
                        cmd.Parameters.AddWithValue("@Medicines", textMedicines.Text);
                        cmd.Parameters.AddWithValue("@WardType", comboType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@WardRequired", comboWard.SelectedItem.ToString());

                        // Step 5: Execute the command
                        cmd.ExecuteNonQuery();

                        // Step 6: Provide feedback to the user
                        MessageBox.Show("Diagnosis information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally, clear the form fields after saving
                        ClearFormFields();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to clear the form after saving
        private void ClearFormFields()
        {
            textId.Clear();
            textSymptoms.Clear();
            textDiagnosis.Clear();
            textMedicines.Clear();
            comboWard.SelectedIndex = -1;
            comboType.SelectedIndex = -1;
        }
    }
}
