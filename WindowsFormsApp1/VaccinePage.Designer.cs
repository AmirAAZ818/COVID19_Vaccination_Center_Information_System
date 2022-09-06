namespace AllForms
{
    partial class VaccinePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinePage));
            this.addVaccineName_TextBox = new System.Windows.Forms.RichTextBox();
            this.vaccinelabel = new System.Windows.Forms.Label();
            this.vaccinelabel2 = new System.Windows.Forms.Label();
            this.vaccinelabel3 = new System.Windows.Forms.Label();
            this.VaccineNum_textBox = new System.Windows.Forms.RichTextBox();
            this.VaccineCountry_comboBox = new System.Windows.Forms.ComboBox();
            this.addVaccine_Button = new System.Windows.Forms.Button();
            this.backVaccine_Button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.vaccine_Project_dbDataSet = new WindowsFormsApp1.Vaccine_Project_dbDataSet();
            this.vaccineProjectdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VaccineGridView = new System.Windows.Forms.DataGridView();
            this.vaccineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosesNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryOfExportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaccine_Project_dbDataSet1 = new WindowsFormsApp1.Vaccine_Project_dbDataSet1();
            this.vaccine_TableTableAdapter = new WindowsFormsApp1.Vaccine_Project_dbDataSet1TableAdapters.Vaccine_TableTableAdapter();
            this.Refbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccine_Project_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineProjectdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VaccineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccine_Project_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // addVaccineName_TextBox
            // 
            this.addVaccineName_TextBox.Location = new System.Drawing.Point(294, 89);
            this.addVaccineName_TextBox.Name = "addVaccineName_TextBox";
            this.addVaccineName_TextBox.Size = new System.Drawing.Size(308, 24);
            this.addVaccineName_TextBox.TabIndex = 0;
            this.addVaccineName_TextBox.Text = "";
            this.addVaccineName_TextBox.TextChanged += new System.EventHandler(this.addVaccineName_TextBox_TextChanged);
            this.addVaccineName_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addVaccineName_TextBox_KeyPress);
            // 
            // vaccinelabel
            // 
            this.vaccinelabel.AutoSize = true;
            this.vaccinelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinelabel.Location = new System.Drawing.Point(294, 59);
            this.vaccinelabel.Name = "vaccinelabel";
            this.vaccinelabel.Size = new System.Drawing.Size(123, 22);
            this.vaccinelabel.TabIndex = 1;
            this.vaccinelabel.Text = "Vaccine Name";
            // 
            // vaccinelabel2
            // 
            this.vaccinelabel2.AutoSize = true;
            this.vaccinelabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinelabel2.Location = new System.Drawing.Point(294, 153);
            this.vaccinelabel2.Name = "vaccinelabel2";
            this.vaccinelabel2.Size = new System.Drawing.Size(153, 22);
            this.vaccinelabel2.TabIndex = 2;
            this.vaccinelabel2.Text = "Producing country";
            // 
            // vaccinelabel3
            // 
            this.vaccinelabel3.AutoSize = true;
            this.vaccinelabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinelabel3.Location = new System.Drawing.Point(294, 254);
            this.vaccinelabel3.Name = "vaccinelabel3";
            this.vaccinelabel3.Size = new System.Drawing.Size(295, 22);
            this.vaccinelabel3.TabIndex = 3;
            this.vaccinelabel3.Text = "Number Of Vaccine Doses Imported";
            // 
            // VaccineNum_textBox
            // 
            this.VaccineNum_textBox.Location = new System.Drawing.Point(294, 296);
            this.VaccineNum_textBox.Name = "VaccineNum_textBox";
            this.VaccineNum_textBox.Size = new System.Drawing.Size(308, 24);
            this.VaccineNum_textBox.TabIndex = 4;
            this.VaccineNum_textBox.Text = "";
            this.VaccineNum_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VaccineNum_textBox_KeyPress);
            // 
            // VaccineCountry_comboBox
            // 
            this.VaccineCountry_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VaccineCountry_comboBox.FormattingEnabled = true;
            this.VaccineCountry_comboBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cabo Verde",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Curacao",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Islamic Republic of Iran",
            "Iraq",
            "Ireland",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.VaccineCountry_comboBox.Location = new System.Drawing.Point(298, 189);
            this.VaccineCountry_comboBox.Name = "VaccineCountry_comboBox";
            this.VaccineCountry_comboBox.Size = new System.Drawing.Size(308, 24);
            this.VaccineCountry_comboBox.TabIndex = 5;
            // 
            // addVaccine_Button
            // 
            this.addVaccine_Button.Location = new System.Drawing.Point(405, 365);
            this.addVaccine_Button.Name = "addVaccine_Button";
            this.addVaccine_Button.Size = new System.Drawing.Size(99, 47);
            this.addVaccine_Button.TabIndex = 6;
            this.addVaccine_Button.Text = "Add";
            this.addVaccine_Button.UseVisualStyleBackColor = true;
            this.addVaccine_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // backVaccine_Button
            // 
            this.backVaccine_Button.Location = new System.Drawing.Point(-1, -1);
            this.backVaccine_Button.Name = "backVaccine_Button";
            this.backVaccine_Button.Size = new System.Drawing.Size(69, 36);
            this.backVaccine_Button.TabIndex = 7;
            this.backVaccine_Button.Text = "Back";
            this.backVaccine_Button.UseVisualStyleBackColor = true;
            this.backVaccine_Button.Click += new System.EventHandler(this.backVaccine_Button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(872, 407);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(69, 36);
            this.logout_button.TabIndex = 8;
            this.logout_button.Text = "Log out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // vaccine_Project_dbDataSet
            // 
            this.vaccine_Project_dbDataSet.DataSetName = "Vaccine_Project_dbDataSet";
            this.vaccine_Project_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vaccineProjectdbDataSetBindingSource
            // 
            this.vaccineProjectdbDataSetBindingSource.DataSource = this.vaccine_Project_dbDataSet;
            this.vaccineProjectdbDataSetBindingSource.Position = 0;
            // 
            // VaccineGridView
            // 
            this.VaccineGridView.AllowUserToAddRows = false;
            this.VaccineGridView.AllowUserToDeleteRows = false;
            this.VaccineGridView.AutoGenerateColumns = false;
            this.VaccineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VaccineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccineNameDataGridViewTextBoxColumn,
            this.dosesNumDataGridViewTextBoxColumn,
            this.countryOfExportDataGridViewTextBoxColumn});
            this.VaccineGridView.DataSource = this.vaccineTableBindingSource;
            this.VaccineGridView.Location = new System.Drawing.Point(183, 462);
            this.VaccineGridView.Name = "VaccineGridView";
            this.VaccineGridView.ReadOnly = true;
            this.VaccineGridView.RowHeadersWidth = 51;
            this.VaccineGridView.RowTemplate.Height = 24;
            this.VaccineGridView.Size = new System.Drawing.Size(563, 150);
            this.VaccineGridView.TabIndex = 9;
            // 
            // vaccineNameDataGridViewTextBoxColumn
            // 
            this.vaccineNameDataGridViewTextBoxColumn.DataPropertyName = "Vaccine_Name";
            this.vaccineNameDataGridViewTextBoxColumn.HeaderText = "Vaccine_Name";
            this.vaccineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaccineNameDataGridViewTextBoxColumn.Name = "vaccineNameDataGridViewTextBoxColumn";
            this.vaccineNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccineNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dosesNumDataGridViewTextBoxColumn
            // 
            this.dosesNumDataGridViewTextBoxColumn.DataPropertyName = "Doses_Num";
            this.dosesNumDataGridViewTextBoxColumn.HeaderText = "Doses_Num";
            this.dosesNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosesNumDataGridViewTextBoxColumn.Name = "dosesNumDataGridViewTextBoxColumn";
            this.dosesNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.dosesNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryOfExportDataGridViewTextBoxColumn
            // 
            this.countryOfExportDataGridViewTextBoxColumn.DataPropertyName = "Country_Of_Export";
            this.countryOfExportDataGridViewTextBoxColumn.HeaderText = "Country_Of_Export";
            this.countryOfExportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryOfExportDataGridViewTextBoxColumn.Name = "countryOfExportDataGridViewTextBoxColumn";
            this.countryOfExportDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryOfExportDataGridViewTextBoxColumn.Width = 125;
            // 
            // vaccineTableBindingSource
            // 
            this.vaccineTableBindingSource.DataMember = "Vaccine_Table";
            this.vaccineTableBindingSource.DataSource = this.vaccine_Project_dbDataSet1;
            // 
            // vaccine_Project_dbDataSet1
            // 
            this.vaccine_Project_dbDataSet1.DataSetName = "Vaccine_Project_dbDataSet1";
            this.vaccine_Project_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vaccine_TableTableAdapter
            // 
            this.vaccine_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Refbutton
            // 
            this.Refbutton.Location = new System.Drawing.Point(12, 628);
            this.Refbutton.Name = "Refbutton";
            this.Refbutton.Size = new System.Drawing.Size(80, 44);
            this.Refbutton.TabIndex = 10;
            this.Refbutton.Text = "Refresh";
            this.Refbutton.UseVisualStyleBackColor = true;
            this.Refbutton.Click += new System.EventHandler(this.Refbutton_Click);
            // 
            // VaccinePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 684);
            this.Controls.Add(this.Refbutton);
            this.Controls.Add(this.VaccineGridView);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.backVaccine_Button);
            this.Controls.Add(this.addVaccine_Button);
            this.Controls.Add(this.VaccineCountry_comboBox);
            this.Controls.Add(this.VaccineNum_textBox);
            this.Controls.Add(this.vaccinelabel3);
            this.Controls.Add(this.vaccinelabel2);
            this.Controls.Add(this.vaccinelabel);
            this.Controls.Add(this.addVaccineName_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VaccinePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VACCINE";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccine_Project_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineProjectdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VaccineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccine_Project_dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox addVaccineName_TextBox;
        private System.Windows.Forms.Label vaccinelabel;
        private System.Windows.Forms.Label vaccinelabel2;
        private System.Windows.Forms.Label vaccinelabel3;
        private System.Windows.Forms.RichTextBox VaccineNum_textBox;
        private System.Windows.Forms.ComboBox VaccineCountry_comboBox;
        private System.Windows.Forms.Button addVaccine_Button;
        private System.Windows.Forms.Button backVaccine_Button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridView VaccineGridView;
        private WindowsFormsApp1.Vaccine_Project_dbDataSet vaccine_Project_dbDataSet;
        private System.Windows.Forms.BindingSource vaccineProjectdbDataSetBindingSource;
        private WindowsFormsApp1.Vaccine_Project_dbDataSet1 vaccine_Project_dbDataSet1;
        private System.Windows.Forms.BindingSource vaccineTableBindingSource;
        private WindowsFormsApp1.Vaccine_Project_dbDataSet1TableAdapters.Vaccine_TableTableAdapter vaccine_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosesNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryOfExportDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Refbutton;
    }
}