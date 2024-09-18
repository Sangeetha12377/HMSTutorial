using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMSTutorial
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // Create and show AddPatient form
            AddPatient addPatientForm = new AddPatient();
            addPatientForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Name (string)
                string patientName = txtName.Text.Trim();
                if (string.IsNullOrEmpty(patientName))
                {
                    MessageBox.Show("Please enter the patient's name.");
                    return;
                }

                // Contact Number (Int64)
                if (!Int64.TryParse(txtContact.Text.Trim(), out Int64 contactNumber))
                {
                    MessageBox.Show("Please enter a valid contact number (digits only).");
                    return;
                }

                // Age (int)
                if (!int.TryParse(txtAge.Text.Trim(), out int age))
                {
                    MessageBox.Show("Please enter a valid age.");
                    return;
                }

                // Address (string)
                string address = txtAddress.Text.Trim();
                if (string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please enter the patient's address.");
                    return;
                }

                // Gender (selected from ComboBox)
                string gender = comboGender.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Please select the patient's gender.");
                    return;
                }

                // Blood Group (string)
                string bloodGroup = txtBlood.Text.Trim();
                if (string.IsNullOrEmpty(bloodGroup))
                {
                    MessageBox.Show("Please enter the patient's blood group.");
                    return;
                }

                // Major Disease (string)
                string majorDisease = txtMajor.Text.Trim();
                if (string.IsNullOrEmpty(majorDisease))
                {
                    majorDisease = "None";
                }

                // Connection string for the SQL Server database
                string connectionString = "Server=LAPTOP-5KOMBA96\\SQLEXPRESS;Database=HospitalDB;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to insert patient data
                    string query = "INSERT INTO Patients (Name, ContactNumber, Gender, Age, Address, BloodGroup, MajorDisease) " +
                                   "VALUES (@Name, @ContactNumber, @Gender, @Age, @Address, @BloodGroup, @MajorDisease)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adding parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Name", patientName);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                        command.Parameters.AddWithValue("@MajorDisease", majorDisease);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient record has been saved successfully!");
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while saving the patient record.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}







