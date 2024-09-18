namespace HMSTutorial
{
    partial class AddDiagnosis
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
            this.PatientId = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Symptoms = new System.Windows.Forms.Label();
            this.textSymptoms = new System.Windows.Forms.TextBox();
            this.Diagnosis = new System.Windows.Forms.Label();
            this.Medicines = new System.Windows.Forms.Label();
            this.WardRequired = new System.Windows.Forms.Label();
            this.TypeOfWard = new System.Windows.Forms.Label();
            this.textMedicines = new System.Windows.Forms.TextBox();
            this.textDiagnosis = new System.Windows.Forms.TextBox();
            this.comboWard = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientId
            // 
            this.PatientId.AutoSize = true;
            this.PatientId.Location = new System.Drawing.Point(334, 68);
            this.PatientId.Name = "PatientId";
            this.PatientId.Size = new System.Drawing.Size(80, 22);
            this.PatientId.TabIndex = 0;
            this.PatientId.Text = "PatientId";
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.Information.Location = new System.Drawing.Point(281, -4);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(418, 25);
            this.Information.TabIndex = 1;
            this.Information.Text = "Adding More Information About Patient";
            // 
            // textId
            // 
            this.textId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textId.Location = new System.Drawing.Point(484, 66);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(145, 30);
            this.textId.TabIndex = 2;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 134);
            this.dataGridView1.TabIndex = 3;
            // 
            // Symptoms
            // 
            this.Symptoms.AutoSize = true;
            this.Symptoms.Location = new System.Drawing.Point(47, 305);
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.Size = new System.Drawing.Size(95, 22);
            this.Symptoms.TabIndex = 4;
            this.Symptoms.Text = "Symptoms";
            // 
            // textSymptoms
            // 
            this.textSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSymptoms.Location = new System.Drawing.Point(237, 305);
            this.textSymptoms.Name = "textSymptoms";
            this.textSymptoms.Size = new System.Drawing.Size(250, 30);
            this.textSymptoms.TabIndex = 5;
            // 
            // Diagnosis
            // 
            this.Diagnosis.AutoSize = true;
            this.Diagnosis.Location = new System.Drawing.Point(47, 365);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(95, 22);
            this.Diagnosis.TabIndex = 6;
            this.Diagnosis.Text = "Diagnosis";
            // 
            // Medicines
            // 
            this.Medicines.AutoSize = true;
            this.Medicines.Location = new System.Drawing.Point(47, 425);
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(92, 22);
            this.Medicines.TabIndex = 7;
            this.Medicines.Text = "Medicines";
            // 
            // WardRequired
            // 
            this.WardRequired.AutoSize = true;
            this.WardRequired.Location = new System.Drawing.Point(567, 305);
            this.WardRequired.Name = "WardRequired";
            this.WardRequired.Size = new System.Drawing.Size(129, 22);
            this.WardRequired.TabIndex = 8;
            this.WardRequired.Text = "Ward Required";
            // 
            // TypeOfWard
            // 
            this.TypeOfWard.AutoSize = true;
            this.TypeOfWard.Location = new System.Drawing.Point(567, 365);
            this.TypeOfWard.Name = "TypeOfWard";
            this.TypeOfWard.Size = new System.Drawing.Size(122, 22);
            this.TypeOfWard.TabIndex = 9;
            this.TypeOfWard.Text = "Type of Ward";
            // 
            // textMedicines
            // 
            this.textMedicines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMedicines.Location = new System.Drawing.Point(237, 425);
            this.textMedicines.Name = "textMedicines";
            this.textMedicines.Size = new System.Drawing.Size(250, 30);
            this.textMedicines.TabIndex = 10;
            // 
            // textDiagnosis
            // 
            this.textDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDiagnosis.Location = new System.Drawing.Point(237, 365);
            this.textDiagnosis.Name = "textDiagnosis";
            this.textDiagnosis.Size = new System.Drawing.Size(250, 30);
            this.textDiagnosis.TabIndex = 11;
            // 
            // comboWard
            // 
            this.comboWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWard.FormattingEnabled = true;
            this.comboWard.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboWard.Location = new System.Drawing.Point(747, 305);
            this.comboWard.Name = "comboWard";
            this.comboWard.Size = new System.Drawing.Size(175, 30);
            this.comboWard.TabIndex = 12;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "General",
            "Private"});
            this.comboType.Location = new System.Drawing.Point(747, 365);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(175, 30);
            this.comboType.TabIndex = 13;
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave1.ForeColor = System.Drawing.Color.White;
            this.btnSave1.Location = new System.Drawing.Point(420, 505);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(117, 44);
            this.btnSave1.TabIndex = 14;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // AddDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(977, 585);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.comboWard);
            this.Controls.Add(this.textDiagnosis);
            this.Controls.Add(this.textMedicines);
            this.Controls.Add(this.TypeOfWard);
            this.Controls.Add(this.WardRequired);
            this.Controls.Add(this.Medicines);
            this.Controls.Add(this.Diagnosis);
            this.Controls.Add(this.textSymptoms);
            this.Controls.Add(this.Symptoms);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.PatientId);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddDiagnosis";
            this.Text = "Add Diagnosis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label PatientId;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Symptoms;
        private System.Windows.Forms.TextBox textSymptoms;
        private System.Windows.Forms.Label Diagnosis;
        private System.Windows.Forms.Label Medicines;
        private System.Windows.Forms.Label WardRequired;
        private System.Windows.Forms.Label TypeOfWard;
        private System.Windows.Forms.TextBox textMedicines;
        private System.Windows.Forms.TextBox textDiagnosis;
        private System.Windows.Forms.ComboBox comboWard;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnSave1;
    }
}



