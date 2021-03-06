using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using windformtask2;
using windformtasks;

namespace windformtasks
{
    public partial class regester_copy : Form
    {
        Form1 frm = new Form1();
        RegistrationDetails _reg = new RegistrationDetails();
        BindingList<RegistrationDetails> RegDetailsList = new BindingList<RegistrationDetails>();
        public regester_copy()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
        }

        public bool validate()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name.Text)) { string message = "Enter valid name";  string title = "Warning";  MessageBox.Show(message,title); return false; }
                if (string.IsNullOrEmpty(num_age.Text)) { string message = "Enter valid age"; string title = "Warning"; MessageBox.Show(message, title); }
                if (string.IsNullOrEmpty(rad_male.Text)) { string message = "Enter valid gender"; string title = "Warning"; MessageBox.Show(message, title); }

               
                if (string.IsNullOrEmpty(com_city.Text)) { string message = "Enter valid city"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (string.IsNullOrEmpty(com_state.Text)) { string message = "Enter valid state"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (string.IsNullOrEmpty(com_country.Text)) { string message = "Enter valid country"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (!validmobilenumber()) return false;
                 if (string.IsNullOrEmpty(txt_qualification.Text)) { string message = "Enter valid qualification"; string title = "Warning"; MessageBox.Show(message, title); return false; }
                if (string.IsNullOrEmpty(txt_address.Text)) { string message = "Enter valid address"; string title = "Warning"; MessageBox.Show(message, title); return false; }

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
                string message = "Data Successfully saved"; 
                string title = "Congrats"; 
                MessageBox.Show(message, title);
                RegDetailsList.Add(details);
            }
            else
            {
                string message = "Data unSuccessfully";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }
        private void but_add_Click(object sender, EventArgs e)
        {
            save();
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
            try
            {
                save();
                details _list = new details(RegDetailsList, _reg.id);
                int ind = _list._index;
                _list.dataGridView1.Rows[ind].Cells["id"].Value = _reg.id;
                _list.dataGridView1.Rows[ind].Cells["name"].Value = _reg.name;
                _list.dataGridView1.Rows[ind].Cells["age"].Value = _reg.age;
                _list.dataGridView1.Rows[ind].Cells["gender"].Value = _reg.gender;
                _list.dataGridView1.Rows[ind].Cells["qualification"].Value = _reg.qualification;
                _list.dataGridView1.Rows[ind].Cells["state"].Value = _reg.state;
                _list.dataGridView1.Rows[ind].Cells["city"].Value = _reg.city;
                _list.dataGridView1.Rows[ind].Cells["country"].Value = _reg.country;
                _list.dataGridView1.Rows[ind].Cells["phone_no"].Value = _reg.phone_no;
                _list.dataGridView1.Rows[ind].Cells["address"].Value = _reg.address;
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            details det = new details(RegDetailsList,_reg.id);
            det.Show();
            //this.Hide();
        }
        public bool validmobilenumber()
        {
            try
            {
                Regex re = new Regex(@" ^[0 - 9]{ 10 }$");
                if (re.IsMatch(txt_phone_no.Text) || txt_phone_no.Text.Length > 11 || txt_phone_no.Text.Length < 9)
                {
                    string message = "Invalid  Mobile Number !! Enter valid number!!";                   
                    string title = "Warning";
                    MessageBox.Show(message, title);
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

        private void dxbtn_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void dxbtn_update_Click(object sender, EventArgs e)
        {
            try
            {
                save();
                details _list = new details(RegDetailsList, _reg.id);
                int ind = _list._index;
                _list.dataGridView1.Rows[ind].Cells["id"].Value = _reg.id;
                _list.dataGridView1.Rows[ind].Cells["name"].Value = _reg.name;
                _list.dataGridView1.Rows[ind].Cells["age"].Value = _reg.age;
                _list.dataGridView1.Rows[ind].Cells["gender"].Value = _reg.gender;
                _list.dataGridView1.Rows[ind].Cells["qualification"].Value = _reg.qualification;
                _list.dataGridView1.Rows[ind].Cells["state"].Value = _reg.state;
                _list.dataGridView1.Rows[ind].Cells["city"].Value = _reg.city;
                _list.dataGridView1.Rows[ind].Cells["country"].Value = _reg.country;
                _list.dataGridView1.Rows[ind].Cells["phone_no"].Value = _reg.phone_no;
                _list.dataGridView1.Rows[ind].Cells["address"].Value = _reg.address;
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dxbtn_view_Click(object sender, EventArgs e)
        {
            details det = new details(RegDetailsList, _reg.id);
            det.Show();
            //this.Hide();
        }

        private void dxbtn_clear_Click(object sender, EventArgs e)
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

        private void dxbtn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            //frm.Show();
        }
    }
}