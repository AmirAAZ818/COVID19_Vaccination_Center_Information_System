using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllForms
{
    public partial class VaccinePage : Form
    {
        Vaccine_Project_dbEntities Context;
        public VaccinePage()
        {
            Context = new Vaccine_Project_dbEntities();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vaccine_Project_dbDataSet1.Vaccine_Table' table. You can move, or remove it, as needed.
            this.vaccine_TableTableAdapter.Fill(this.vaccine_Project_dbDataSet1.Vaccine_Table);
        }

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check_Validation())
            {
                errorProvider2.Clear();
                Vaccine_Table Vaccine = new Vaccine_Table();
                Vaccine.Vaccine_Name = addVaccineName_TextBox.Text;
                Vaccine.Doses_Num = Convert.ToInt32(VaccineNum_textBox.Text);
                Vaccine.Country_Of_Export = Convert.ToString(VaccineCountry_comboBox.SelectedItem);
                Context.Vaccine_Table.Add(Vaccine);
                Context.SaveChanges();
                MessageBox.Show("The vaccine added seccussfully");
                addVaccineName_TextBox.Text = "";
                VaccineCountry_comboBox.SelectedItem = null;
                VaccineNum_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Form in not complete!");
                WhichField();
            }
        }
        public void WhichField()
        {
            if (addVaccineName_TextBox.Text == String.Empty)
            {
                errorProvider2.SetError(addVaccineName_TextBox,"please enter a vaccine name");
            }
            if (VaccineCountry_comboBox.SelectedItem == null)
            {
                errorProvider2.SetError(VaccineCountry_comboBox, "please choose a country");
            }
            if (VaccineNum_textBox.Text == String.Empty)
            {
                errorProvider2.SetError(VaccineNum_textBox,"please enter the number");
            }

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage loginpage = new LogInPage();
            loginpage.ShowDialog();
            this.Close();
        }

        private void backVaccine_Button_Click(object sender, EventArgs e)
        {

            this.Hide();
            SelectionPage selectionPage = new SelectionPage();
            selectionPage.ShowDialog();
            this.Close();
        }
        public bool Check_Validation()
        {
            if (addVaccineName_TextBox.Text==String.Empty ||
                VaccineCountry_comboBox.SelectedItem==null|| VaccineNum_textBox.Text==String.Empty)

            {
                return false;
            }
            else
                return true;

        }


        private void VaccineNum_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public void Refreshing()
        {            
            VaccineGridView.DataSource = Context.Vaccine_Table.ToList();
        }

        private void Refbutton_Click(object sender, EventArgs e)
        {
            Refreshing();
        }

        private void addVaccineName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addVaccineName_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}