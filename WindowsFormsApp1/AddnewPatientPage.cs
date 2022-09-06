using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Entity.Validation;

namespace AllForms
{
   
    public partial class AddnewPatientPage : Form
    {
        public Vaccine_Project_dbEntities Context;

        public AddnewPatientPage()
        {
            Context = new Vaccine_Project_dbEntities();
            InitializeComponent();
            fdose_dateTimePicker.Enabled = false;
            fdose_date.Enabled = false; 
            sdose_date.Visible = false;
            sdose_dateTimePicker.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vaccine_Project_dbDataSet.Patient_Table' table. You can move, or remove it, as needed.
            this.patient_TableTableAdapter.Fill(this.vaccine_Project_dbDataSet.Patient_Table);

            var vaccines = Context.Vaccine_Table;
            foreach (var vaccine in vaccines)
            {
                vaccine_name_comboBox.Items.Add(vaccine.Vaccine_Name);
            }
            RefreshMethod();
        }

        //Methods
        //name
        public void add_Name(Patient_Table Patient)
        {
 
            Patient.Name = first_name_textBox.Text;

        }
        //lastname
        public void add_Lastname(Patient_Table Patient)
        { 

            Patient.Last_Name = last_name_textBox.Text;

        }
        //code meli
        public void add_Nationalcode(Patient_Table Patient)
        {
 
            Patient.National_Code = national_code_textBox.Text;

        }
        //ID
        public void add_ID(Patient_Table Patient)
        {

            //ID_textBox.SelectionLength = 10;
            Patient.ID = ID_textBox.Text;
            
        }

        //gender
        public void add_Gender(Patient_Table Patient)
        {

            if (male_radioButton.Checked)
            {
                Patient.Gender = "Male";
            }
            else if (female_radioButton.Checked)
            {
                Patient.Gender = "Female";
            }
        }
        //birthday
        public void add_Birthdate(Patient_Table Patient)
        {

            Patient.Birth_Date = birth_dateTimePicker.Value.Date;

        }
        //phone number
        public void add_PhoneNum(Patient_Table Patient)
        {

            Patient.Phone_Num = phone_num_textBox.Text;
;
        }
        //address
        public void add_Address(Patient_Table Patient)
        {

            Patient.Address = address_textBox.Text;

        }
        //vaccine name
        public void add_VaccineName(Patient_Table Patient)
        {

            Patient.Vaccine_Name = vaccine_name_comboBox.Text;

        }
        //1st Dose date
        public void add_FDoseDate(Patient_Table Patient)
        {

            Patient.Dose1_Date = fdose_dateTimePicker.Value.Date;

        }
        //2nd Dose date
        public void add_SDoseDate(Patient_Table Patient)
        {
            if (num_inj_dose_comboBox.SelectedIndex == 0)
            {
                Patient.Dose2_Date = fdose_dateTimePicker.Value.Date.AddDays(21);
            }
            else
            {
                Patient.Dose2_Date = sdose_dateTimePicker.Value.Date;
            }
        }
        //Doses Number
        public void add_DoseNum(Patient_Table Patient)
        {
            Patient.Doses_Num = Convert.ToInt32(num_inj_dose_comboBox.SelectedItem);

        }
        //2nd Dose date message
        public void SecondDoseDateMessage(Patient_Table Patient)
        {
            if (Patient.Doses_Num == 1)
            {
                MessageBox.Show("You should inject your second dose on :" + Patient.Dose2_Date);

            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (num_inj_dose_comboBox.SelectedIndex == 0)
            {
                fdose_dateTimePicker.Enabled = true;
                fdose_date.Enabled = true;
                sdose_dateTimePicker.Visible = false;
                sdose_date.Visible = false;

            }

            else if (num_inj_dose_comboBox.SelectedIndex == 1)
            {
                fdose_dateTimePicker.Enabled = true;
                fdose_date.Enabled = true;
                sdose_dateTimePicker.Visible = true;
                sdose_date.Visible = true;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            
            if (Check_Validation())
            {
                errorProvider1.Clear();
                Patient_Table Patient = new Patient_Table();
                //adding
                add_Name(Patient);
                add_Lastname(Patient);
                add_Address(Patient);
                add_Birthdate(Patient);
                add_DoseNum(Patient);
                add_FDoseDate(Patient);
                add_SDoseDate(Patient);
                add_VaccineName(Patient);
                add_PhoneNum(Patient);
                add_Nationalcode(Patient);
                add_ID(Patient);
                add_Gender(Patient);
                //saving in database
                Context.Patient_Table.Add(Patient);
                Context.SaveChanges();
                MessageBox.Show("Patient added seccussfully!");
                SecondDoseDateMessage(Patient);
                //refresh
                first_name_textBox.Text = "";
                last_name_textBox.Text = "";
                phone_num_textBox.Text = "";
                ID_textBox.Text = "";
                national_code_textBox.Text = "";
                address_textBox.Text = "";
                birth_dateTimePicker.Value = DateTime.Now;
                fdose_dateTimePicker.Value = DateTime.Now;
                sdose_dateTimePicker.Value = DateTime.Now;
                male_radioButton.Checked = false;
                female_radioButton.Checked = false;
                vaccine_name_comboBox.SelectedItem = "";
                num_inj_dose_comboBox.SelectedItem = "";
            }
            else
            {
                MessageBox.Show("Form is not complete!");
                WhichField();
            }
        }

        //logout button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage loginpage = new LogInPage();
            loginpage.ShowDialog();
            this.Close();
        }

        //back button
        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionPage selectionPage = new SelectionPage();
            selectionPage.ShowDialog();
            this.Close();
        }

        public void WhichField()
        {
            if (first_name_textBox.Text == String.Empty)
            {
                errorProvider1.SetError(first_name_textBox, "Please Enter firstname");
            }
            if (last_name_textBox.Text == String.Empty)
            {
                errorProvider1.SetError(last_name_textBox, "Please Enter lastname");
            }
            if (national_code_textBox.Text == String.Empty)
            {
                errorProvider1.SetError(national_code_textBox, "Please Enter national code");
            }
            if (ID_textBox.Text == String.Empty)
            {
                errorProvider1.SetError(ID_textBox, "Please Enter ID");
            }
            if (male_radioButton.Checked == false && female_radioButton.Checked == false)
            {
                errorProvider1.SetError(female_radioButton, "Please choose a gender");
            }
            if (phone_num_textBox.Text == String.Empty)
            {
                errorProvider1.SetError(phone_num_textBox, "Please Enter phone number");
            }
            if (address_textBox.Text == String.Empty)
            {
                errorProvider1.SetError(address_textBox, "Please Enter address");
            }
            if (vaccine_name_comboBox.SelectedItem == null)
            {
                errorProvider1.SetError(vaccine_name_comboBox, "Please choose Vaccine");
            }
            if (num_inj_dose_comboBox.SelectedItem == null)
            {
                errorProvider1.SetError(num_inj_dose_comboBox, "Please choose the dose of injected numbers");
            }
        }

        public bool Check_Validation()
        {
            if (first_name_textBox.Text == string.Empty || last_name_textBox.Text == String.Empty ||
                national_code_textBox.Text == String.Empty || ID_textBox.Text == String.Empty ||
                (male_radioButton.Checked == false && female_radioButton.Checked == false) ||
                phone_num_textBox.Text == String.Empty || address_textBox.Text == String.Empty ||
                vaccine_name_comboBox.Items == null || num_inj_dose_comboBox.Items == null)
            {
                return false;
            }
            else
                return true;

        }

        //key handling
        private void first_name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }


        private void last_name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void national_code_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void ID_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void phone_num_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        //ref method
        public void RefreshMethod()
        {
            PatientGridView.DataSource = Context.Patient_Table.ToList();
        }

        //ref button
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshMethod();
        }










        private void vaccine_name_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sdose_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void address_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void national_code_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_num_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fdose_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
