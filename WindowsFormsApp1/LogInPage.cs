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
    public partial class LogInPage : Form
    {
        Vaccine_Project_dbEntities Context;
        public LogInPage()
        {
            Context = new Vaccine_Project_dbEntities();
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //Login button click evnt handler method
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username and Password is required!");
            }
            else
            {
                Login_Table login = new Login_Table();
                var Users = Context.Login_Table;

                bool Matchflag = true;

                foreach (var User in Users)
                {
                    if (User.Username == textBox1.Text)
                    {
                        if (User.Password == textBox2.Text)
                        {
                            this.Hide();
                            SelectionPage SelectionPage = new SelectionPage();
                            SelectionPage.ShowDialog();
                            Matchflag = false;
                            this.Close();
                            break;
                        }
                        else
                        {
                            Matchflag = false;
                            MessageBox.Show("Username or Password is invalid!");
                        }

                    }
                }

                if (Matchflag)
                {
                    MessageBox.Show("Username or Password is invalid!");
                }
            }
        }

        private void loginrichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
