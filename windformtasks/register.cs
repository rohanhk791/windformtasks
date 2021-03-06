using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

//using System.Text.RegularExpressions.Regex Regex;

namespace windformtasks
{
    public class RegistrationDetails
    {
        public int id { get; set; }

        public string name { get; set; }
        public int age { get; set; }
       

        
        public string gender { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public string country { get; set; }
        public long phone_no { get; set; }
        public string address { get; set; }
        public string qualification { get; set; }
        //public  int index { get; set; }
        // public  string text1 { get; set; }
    }
    public partial class register : Form
    {
        List<RegistrationDetails> RegDetailsList = new List<RegistrationDetails>();
        //details det = new details();
        //DataTable dt = new DataTable();

        public register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public bool validate()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name.Text)) { MessageBox.Show("Enter valid name"); return false; }
                if (string.IsNullOrEmpty(rad_male.Text)) { MessageBox.Show("Enter valid gender"); return false; }
                if (string.IsNullOrEmpty(txt_qualification.Text)) { MessageBox.Show("Enter valid qualification"); return false; }
                if (string.IsNullOrEmpty(com_city.Text)) { MessageBox.Show("Enter valid city name"); return false; }
                if (string.IsNullOrEmpty(com_state.Text)) { MessageBox.Show("Enter valid state name"); return false; }
                if (string.IsNullOrEmpty(com_country.Text)) { MessageBox.Show("Enter valid country name"); return false; }
                if (string.IsNullOrEmpty(txt_address.Text)) { MessageBox.Show("Enter valid address"); return false; }

                if (!validmobilenumber()) return false;
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
        }
        public void save()
        {
            RegistrationDetails details;
            if (validate())
            {
                details = new RegistrationDetails();
                details.id = Convert.ToInt32(numericUpDown1.Value);
                details.name = txt_name.Text;
                details.age = int.Parse(num_age.Text);
                details.gender = rad_male.Text;
                if (!string.IsNullOrEmpty(txt_phone_no.Text)) details.phone_no = Convert.ToInt64(txt_phone_no.Text);
                details.qualification = txt_qualification.Text;
                details.city = com_city.Text;
                details.state = com_state.Text;
                details.country = com_country.Text;
                details.address = txt_address.Text;
                if (rad_male.Checked)
                {
                    details.gender = "male";
                }
                else
                {
                    details.gender = "female";
                }

                MessageBox.Show("Data Success");
                RegDetailsList.Add(details);

            }
            else
            {
                MessageBox.Show("Data not saved");
            }
        }
        private void but_add_Click(object sender, EventArgs e)
        {
            save();

        }

        private void com_city_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                foreach (var clear in this.Controls)
                {
                    if (clear is TextBox)
                    {
                        ((TextBox)clear).Text = String.Empty;

                    }

                    if (clear is ComboBox)
                    {

                        ((ComboBox)clear).Text = String.Empty;
                    }
                    if (clear is NumericUpDown)
                    {

                        ((NumericUpDown)clear).Text = String.Empty;
                    }

                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            //DataGridViewRow newdata = det.datagridview1.selectedrows[0];
            //newdata.cells[0].value = txt_id.text;
            //newdata.cells[1].value = txt_name.text;
            //newdata.cells[2].value = num_age.text;
            //newdata.cells[3].value = rad_male.text;
            //newdata.cells[4].value = com_city.text;
            //newdata.cells[5].value = com_state.text;
            //newdata.cells[6].value = com_country.text;
            //newdata.cells[7].value = txt_phone_no.text;
            //newdata.cells[8].value = txt_address.text;
            //newdata.cells[9].value = txt_qualification.text;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            //details det = new details(RegDetailsList);
            //det.Show();

        }
        public bool validmobilenumber()
        {
            try
            {
                Regex re = new Regex(@" ^[0 - 9]{ 10 }$");
                if (re.IsMatch(txt_phone_no.Text) || txt_phone_no.Text.Length > 11 || txt_phone_no.Text.Length < 9)
                {
                    MessageBox.Show("Invalid  Mobile Number!!");
                    txt_phone_no.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
        }
        private void txt_phone_no_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
