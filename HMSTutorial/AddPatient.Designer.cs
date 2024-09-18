using System;

namespace HMSTutorial
{
    partial class AddPatient
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
            this.name = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Blood = new System.Windows.Forms.Label();
            this.Major = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtBlood = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.Record = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(152, 78);
            this.name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(56, 22);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(152, 349);
            this.Number.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(138, 22);
            this.Number.TabIndex = 1;
            this.Number.Text = "Contact Number";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(152, 235);
            this.Gender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(68, 22);
            this.Gender.TabIndex = 2;
            this.Gender.Text = "Gender";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(152, 126);
            this.Age.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(42, 22);
            this.Age.TabIndex = 3;
            this.Age.Text = "Age";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(152, 183);
            this.Address.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(76, 22);
            this.Address.TabIndex = 4;
            this.Address.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(383, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(500, 34);
            this.txtName.TabIndex = 5;
            // 
            // Blood
            // 
            this.Blood.AutoSize = true;
            this.Blood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blood.Location = new System.Drawing.Point(152, 290);
            this.Blood.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Blood.Name = "Blood";
            this.Blood.Size = new System.Drawing.Size(114, 22);
            this.Blood.TabIndex = 6;
            this.Blood.Text = "Blood Gorup";
            // 
            // Major
            // 
            this.Major.AutoSize = true;
            this.Major.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Major.Location = new System.Drawing.Point(69, 410);
            this.Major.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(302, 22);
            this.Major.TabIndex = 7;
            this.Major.Text = "Any Major Disease Suffered Earlier ";
            this.Major.Click += new System.EventHandler(this.label7_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(69, 501);
            this.Id.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(85, 22);
            this.Id.TabIndex = 8;
            this.Id.Text = "Patient Id";
            // 
            // txtMajor
            // 
            this.txtMajor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMajor.Location = new System.Drawing.Point(73, 448);
            this.txtMajor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(676, 34);
            this.txtMajor.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(383, 183);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(500, 34);
            this.txtAddress.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 814);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(676, 34);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Location = new System.Drawing.Point(383, 344);
            this.txtContact.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(500, 34);
            this.txtContact.TabIndex = 12;
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Location = new System.Drawing.Point(383, 126);
            this.txtAge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(500, 34);
            this.txtAge.TabIndex = 13;
            // 
            // txtBlood
            // 
            this.txtBlood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBlood.Location = new System.Drawing.Point(383, 290);
            this.txtBlood.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBlood.Name = "txtBlood";
            this.txtBlood.Size = new System.Drawing.Size(500, 34);
            this.txtBlood.TabIndex = 14;
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboGender.Location = new System.Drawing.Point(383, 235);
            this.comboGender.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(499, 34);
            this.comboGender.TabIndex = 15;
            // 
            // Record
            // 
            this.Record.AutoSize = true;
            this.Record.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Record.Location = new System.Drawing.Point(352, 0);
            this.Record.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(263, 25);
            this.Record.TabIndex = 16;
            this.Record.Text = "Add New Patient Record";
            // 
            // txtPatient
            // 
            this.txtPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatient.Location = new System.Drawing.Point(73, 526);
            this.txtPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(676, 34);
            this.txtPatient.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(876, 533);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 33);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 578);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.txtBlood);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.Blood);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Blood;
        private System.Windows.Forms.Label Major;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtBlood;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label Record;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Button btnSave;
    }
}