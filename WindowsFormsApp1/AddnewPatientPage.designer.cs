namespace AllForms
{
    partial class AddnewPatientPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddnewPatientPage));
            this.firstname = new System.Windows.Forms.Label();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.last_name_textBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.national_code = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.date_of_birth = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.vaccine_name = new System.Windows.Forms.Label();
            this.num_inj_doses = new System.Windows.Forms.Label();
            this.fdose_date = new System.Windows.Forms.Label();
            this.sdose_date = new System.Windows.Forms.Label();
            this.num_inj_dose_comboBox = new System.Windows.Forms.ComboBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.vaccine_name_comboBox = new System.Windows.Forms.ComboBox();
            this.fdose_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.insert = new System.Windows.Forms.Button();
            this.sdose_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.national_code_textBox = new System.Windows.Forms.RichTextBox();
            this.ID_textBox = new System.Windows.Forms.RichTextBox();
            this.phone_num_textBox = new System.Windows.Forms.RichTextBox();
            this.backPatient_Button = new System.Windows.Forms.Button();
            this.logout_button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PatientGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosesNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose1DateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose2DateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaccine_Project_dbDataSet = new WindowsFormsApp1.Vaccine_Project_dbDataSet();
            this.patient_TableTableAdapter = new WindowsFormsApp1.Vaccine_Project_dbDataSetTableAdapters.Patient_TableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccine_Project_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(73, 24);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(72, 16);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name";
            this.firstname.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(77, 42);
            this.first_name_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(282, 22);
            this.first_name_textBox.TabIndex = 1;
            this.first_name_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.first_name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_name_textBox_KeyPress);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(73, 86);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(72, 16);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "Last Name";
            this.lastname.Click += new System.EventHandler(this.label2_Click);
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.Location = new System.Drawing.Point(77, 104);
            this.last_name_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.Size = new System.Drawing.Size(282, 22);
            this.last_name_textBox.TabIndex = 3;
            this.last_name_textBox.TextChanged += new System.EventHandler(this.last_name_textBox_TextChanged);
            this.last_name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.last_name_textBox_KeyPress);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(73, 207);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(175, 16);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID ( Shomare Shenasname )";
            this.ID.Click += new System.EventHandler(this.label3_Click);
            // 
            // national_code
            // 
            this.national_code.AutoSize = true;
            this.national_code.Location = new System.Drawing.Point(73, 146);
            this.national_code.Name = "national_code";
            this.national_code.Size = new System.Drawing.Size(174, 16);
            this.national_code.TabIndex = 5;
            this.national_code.Text = "National Code ( Code Melli )";
            this.national_code.Click += new System.EventHandler(this.label4_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(73, 261);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(52, 16);
            this.gender.TabIndex = 8;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.label5_Click);
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Location = new System.Drawing.Point(167, 279);
            this.male_radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(58, 20);
            this.male_radioButton.TabIndex = 10;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            this.male_radioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(267, 279);
            this.female_radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(74, 20);
            this.female_radioButton.TabIndex = 11;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // date_of_birth
            // 
            this.date_of_birth.AutoSize = true;
            this.date_of_birth.Location = new System.Drawing.Point(73, 326);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(79, 16);
            this.date_of_birth.TabIndex = 12;
            this.date_of_birth.Text = "Date of Birth";
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Location = new System.Drawing.Point(571, 24);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(97, 16);
            this.phone_number.TabIndex = 13;
            this.phone_number.Text = "Phone Number";
            this.phone_number.Click += new System.EventHandler(this.label7_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(571, 86);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(58, 16);
            this.address.TabIndex = 15;
            this.address.Text = "Address";
            // 
            // vaccine_name
            // 
            this.vaccine_name.AutoSize = true;
            this.vaccine_name.Location = new System.Drawing.Point(571, 146);
            this.vaccine_name.Name = "vaccine_name";
            this.vaccine_name.Size = new System.Drawing.Size(96, 16);
            this.vaccine_name.TabIndex = 16;
            this.vaccine_name.Text = "Vaccine Name";
            // 
            // num_inj_doses
            // 
            this.num_inj_doses.AutoSize = true;
            this.num_inj_doses.Location = new System.Drawing.Point(571, 207);
            this.num_inj_doses.Name = "num_inj_doses";
            this.num_inj_doses.Size = new System.Drawing.Size(160, 16);
            this.num_inj_doses.TabIndex = 17;
            this.num_inj_doses.Text = "Number of injected doses";
            // 
            // fdose_date
            // 
            this.fdose_date.AutoSize = true;
            this.fdose_date.Location = new System.Drawing.Point(571, 279);
            this.fdose_date.Name = "fdose_date";
            this.fdose_date.Size = new System.Drawing.Size(148, 16);
            this.fdose_date.TabIndex = 18;
            this.fdose_date.Text = "First dose injection date";
            this.fdose_date.Click += new System.EventHandler(this.label11_Click);
            // 
            // sdose_date
            // 
            this.sdose_date.AutoSize = true;
            this.sdose_date.Location = new System.Drawing.Point(571, 337);
            this.sdose_date.Name = "sdose_date";
            this.sdose_date.Size = new System.Drawing.Size(170, 16);
            this.sdose_date.TabIndex = 19;
            this.sdose_date.Text = "Second dose injection date";
            // 
            // num_inj_dose_comboBox
            // 
            this.num_inj_dose_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num_inj_dose_comboBox.FormattingEnabled = true;
            this.num_inj_dose_comboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.num_inj_dose_comboBox.Location = new System.Drawing.Point(574, 226);
            this.num_inj_dose_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_inj_dose_comboBox.Name = "num_inj_dose_comboBox";
            this.num_inj_dose_comboBox.Size = new System.Drawing.Size(282, 24);
            this.num_inj_dose_comboBox.TabIndex = 20;
            this.num_inj_dose_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(574, 104);
            this.address_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(282, 22);
            this.address_textBox.TabIndex = 21;
            this.address_textBox.TextChanged += new System.EventHandler(this.address_textBox_TextChanged);
            // 
            // vaccine_name_comboBox
            // 
            this.vaccine_name_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vaccine_name_comboBox.FormattingEnabled = true;
            this.vaccine_name_comboBox.Location = new System.Drawing.Point(574, 163);
            this.vaccine_name_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vaccine_name_comboBox.Name = "vaccine_name_comboBox";
            this.vaccine_name_comboBox.Size = new System.Drawing.Size(282, 24);
            this.vaccine_name_comboBox.TabIndex = 22;
            this.vaccine_name_comboBox.SelectedIndexChanged += new System.EventHandler(this.vaccine_name_comboBox_SelectedIndexChanged);
            // 
            // fdose_dateTimePicker
            // 
            this.fdose_dateTimePicker.Location = new System.Drawing.Point(574, 298);
            this.fdose_dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fdose_dateTimePicker.MinDate = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            this.fdose_dateTimePicker.Name = "fdose_dateTimePicker";
            this.fdose_dateTimePicker.Size = new System.Drawing.Size(282, 22);
            this.fdose_dateTimePicker.TabIndex = 23;
            this.fdose_dateTimePicker.Value = new System.DateTime(2022, 6, 30, 0, 0, 0, 0);
            this.fdose_dateTimePicker.ValueChanged += new System.EventHandler(this.fdose_dateTimePicker_ValueChanged);
            // 
            // birth_dateTimePicker
            // 
            this.birth_dateTimePicker.Location = new System.Drawing.Point(76, 344);
            this.birth_dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birth_dateTimePicker.MinDate = new System.DateTime(1904, 1, 1, 0, 0, 0, 0);
            this.birth_dateTimePicker.Name = "birth_dateTimePicker";
            this.birth_dateTimePicker.Size = new System.Drawing.Size(282, 22);
            this.birth_dateTimePicker.TabIndex = 25;
            this.birth_dateTimePicker.Value = new System.DateTime(2022, 6, 29, 0, 0, 0, 0);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(377, 395);
            this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(180, 36);
            this.insert.TabIndex = 27;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // sdose_dateTimePicker
            // 
            this.sdose_dateTimePicker.CustomFormat = "";
            this.sdose_dateTimePicker.Location = new System.Drawing.Point(574, 355);
            this.sdose_dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdose_dateTimePicker.Name = "sdose_dateTimePicker";
            this.sdose_dateTimePicker.Size = new System.Drawing.Size(282, 22);
            this.sdose_dateTimePicker.TabIndex = 28;
            this.sdose_dateTimePicker.ValueChanged += new System.EventHandler(this.sdose_dateTimePicker_ValueChanged);
            // 
            // national_code_textBox
            // 
            this.national_code_textBox.Location = new System.Drawing.Point(76, 165);
            this.national_code_textBox.Name = "national_code_textBox";
            this.national_code_textBox.Size = new System.Drawing.Size(282, 22);
            this.national_code_textBox.TabIndex = 29;
            this.national_code_textBox.Text = "";
            this.national_code_textBox.TextChanged += new System.EventHandler(this.national_code_textBox_TextChanged);
            this.national_code_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.national_code_textBox_KeyPress);
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(76, 226);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(282, 22);
            this.ID_textBox.TabIndex = 30;
            this.ID_textBox.Text = "";
            this.ID_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_textBox_KeyPress);
            // 
            // phone_num_textBox
            // 
            this.phone_num_textBox.Location = new System.Drawing.Point(574, 42);
            this.phone_num_textBox.Name = "phone_num_textBox";
            this.phone_num_textBox.Size = new System.Drawing.Size(282, 22);
            this.phone_num_textBox.TabIndex = 31;
            this.phone_num_textBox.Text = "";
            this.phone_num_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_num_textBox_KeyPress);
            // 
            // backPatient_Button
            // 
            this.backPatient_Button.Location = new System.Drawing.Point(-1, -1);
            this.backPatient_Button.Name = "backPatient_Button";
            this.backPatient_Button.Size = new System.Drawing.Size(69, 36);
            this.backPatient_Button.TabIndex = 32;
            this.backPatient_Button.Text = "Back";
            this.backPatient_Button.UseVisualStyleBackColor = true;
            this.backPatient_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // logout_button2
            // 
            this.logout_button2.Location = new System.Drawing.Point(872, 407);
            this.logout_button2.Name = "logout_button2";
            this.logout_button2.Size = new System.Drawing.Size(69, 36);
            this.logout_button2.TabIndex = 33;
            this.logout_button2.Text = "Log out";
            this.logout_button2.UseVisualStyleBackColor = true;
            this.logout_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PatientGridView
            // 
            this.PatientGridView.AllowUserToAddRows = false;
            this.PatientGridView.AllowUserToDeleteRows = false;
            this.PatientGridView.AutoGenerateColumns = false;
            this.PatientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.nationalCodeDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.vaccineNameDataGridViewTextBoxColumn,
            this.dosesNumDataGridViewTextBoxColumn,
            this.dose1DateDataGridViewTextBoxColumn,
            this.dose2DateDataGridViewTextBoxColumn});
            this.PatientGridView.DataSource = this.patientTableBindingSource;
            this.PatientGridView.Location = new System.Drawing.Point(34, 470);
            this.PatientGridView.Name = "PatientGridView";
            this.PatientGridView.ReadOnly = true;
            this.PatientGridView.RowHeadersWidth = 51;
            this.PatientGridView.RowTemplate.Height = 24;
            this.PatientGridView.Size = new System.Drawing.Size(890, 150);
            this.PatientGridView.TabIndex = 34;
            this.PatientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "National_Code";
            this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "National_Code";
            this.nationalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            this.nationalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "Birth_Date";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth_Date";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "Phone_Num";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "Phone_Num";
            this.phoneNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            this.phoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
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
            // dose1DateDataGridViewTextBoxColumn
            // 
            this.dose1DateDataGridViewTextBoxColumn.DataPropertyName = "Dose1_Date";
            this.dose1DateDataGridViewTextBoxColumn.HeaderText = "Dose1_Date";
            this.dose1DateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dose1DateDataGridViewTextBoxColumn.Name = "dose1DateDataGridViewTextBoxColumn";
            this.dose1DateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dose1DateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dose2DateDataGridViewTextBoxColumn
            // 
            this.dose2DateDataGridViewTextBoxColumn.DataPropertyName = "Dose2_Date";
            this.dose2DateDataGridViewTextBoxColumn.HeaderText = "Dose2_Date";
            this.dose2DateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dose2DateDataGridViewTextBoxColumn.Name = "dose2DateDataGridViewTextBoxColumn";
            this.dose2DateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dose2DateDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientTableBindingSource
            // 
            this.patientTableBindingSource.DataMember = "Patient_Table";
            this.patientTableBindingSource.DataSource = this.vaccine_Project_dbDataSet;
            // 
            // vaccine_Project_dbDataSet
            // 
            this.vaccine_Project_dbDataSet.DataSetName = "Vaccine_Project_dbDataSet";
            this.vaccine_Project_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_TableTableAdapter
            // 
            this.patient_TableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddnewPatientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatientGridView);
            this.Controls.Add(this.logout_button2);
            this.Controls.Add(this.backPatient_Button);
            this.Controls.Add(this.phone_num_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.national_code_textBox);
            this.Controls.Add(this.sdose_dateTimePicker);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.birth_dateTimePicker);
            this.Controls.Add(this.fdose_dateTimePicker);
            this.Controls.Add(this.vaccine_name_comboBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.num_inj_dose_comboBox);
            this.Controls.Add(this.sdose_date);
            this.Controls.Add(this.fdose_date);
            this.Controls.Add(this.num_inj_doses);
            this.Controls.Add(this.vaccine_name);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.female_radioButton);
            this.Controls.Add(this.male_radioButton);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.national_code);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.last_name_textBox);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.first_name_textBox);
            this.Controls.Add(this.firstname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddnewPatientPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccine_Project_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox last_name_textBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label national_code;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.Label date_of_birth;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label vaccine_name;
        private System.Windows.Forms.Label num_inj_doses;
        private System.Windows.Forms.Label fdose_date;
        private System.Windows.Forms.Label sdose_date;
        private System.Windows.Forms.ComboBox num_inj_dose_comboBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.ComboBox vaccine_name_comboBox;
        private System.Windows.Forms.DateTimePicker fdose_dateTimePicker;
        private System.Windows.Forms.DateTimePicker birth_dateTimePicker;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DateTimePicker sdose_dateTimePicker;
        private System.Windows.Forms.RichTextBox national_code_textBox;
        private System.Windows.Forms.RichTextBox ID_textBox;
        private System.Windows.Forms.RichTextBox phone_num_textBox;
        private System.Windows.Forms.Button backPatient_Button;
        private System.Windows.Forms.Button logout_button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView PatientGridView;
        private WindowsFormsApp1.Vaccine_Project_dbDataSet vaccine_Project_dbDataSet;
        private System.Windows.Forms.BindingSource patientTableBindingSource;
        private WindowsFormsApp1.Vaccine_Project_dbDataSetTableAdapters.Patient_TableTableAdapter patient_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosesNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose1DateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose2DateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

