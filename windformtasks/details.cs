using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace windformtasks
{
    public partial class details : Form
    {  
        public int _index;
        regester_copy reg = new regester_copy();
        BindingList<RegistrationDetails> regList;
        public details(BindingList<RegistrationDetails> regDetailsList, int id)
        {
            InitializeComponent();
            regList = regDetailsList;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrationDetails r = new RegistrationDetails();
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
                string message = "successfully deleted";
                string title = "Congrats";
                System.Windows.MessageBox.Show(message, title);
                dataGridView1.Rows.Remove(dataGridView1.Rows[id]);                
                dataGridView1.Refresh();
            }
            catch (Exception E)
            {
                System.Windows.MessageBox.Show(E.Message);
            }
        }
        public void display()
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void details_Load(object sender, EventArgs e)
        {
            try
            {               
                dataGridView1.DataSource = regList;
                dxdatagridview.DataSource = regList;
                gridControl1.DataSource= regList;
            }
            catch (Exception E)
            {
                System.Windows.MessageBox.Show(E.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                regester_copy regForm = new regester_copy();
                _index = dataGridView1.CurrentCell.RowIndex;
                //_index = dxdatagridview.CurrentCell.RowIndex;
                DataGridViewRow edit = dataGridView1.Rows[_index];
                regForm.numericUpDown1.Text = edit.Cells["id"].Value.ToString();
                regForm.txt_name.Text = edit.Cells["name"].Value.ToString();
                regForm.num_age.Value = Convert.ToInt32(edit.Cells["age"].Value);
                regForm.com_state.Text = edit.Cells["state"].Value.ToString();
                regForm.com_city.Text = edit.Cells["city"].Value.ToString();
                regForm.com_country.Text = edit.Cells["country"].Value.ToString();
                regForm.txt_phone_no.Text = edit.Cells["phone_no"].Value.ToString();
                regForm.txt_address.Text = edit.Cells["address"].Value.ToString();
                regForm.txt_qualification.Text = edit.Cells["qualification"].Value.ToString();
                //this.Hide();
                regForm.Show();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            reg.save();
        }
        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void dxbtn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                regester_copy regForm = new regester_copy();
                _index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow edit = dataGridView1.Rows[_index];
                regForm.numericUpDown1.Text = edit.Cells["id"].Value.ToString();
                regForm.txt_name.Text = edit.Cells["name"].Value.ToString();
                regForm.num_age.Value = Convert.ToInt32(edit.Cells["age"].Value);
                regForm.com_state.Text = edit.Cells["state"].Value.ToString();
                regForm.com_city.Text = edit.Cells["city"].Value.ToString();
                regForm.com_country.Text = edit.Cells["country"].Value.ToString();
                regForm.txt_phone_no.Text = edit.Cells["phone_no"].Value.ToString();
                regForm.txt_address.Text = edit.Cells["address"].Value.ToString();
                regForm.txt_qualification.Text = edit.Cells["qualification"].Value.ToString();
                //this.Hide();
                regForm.Show();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void dxbtn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrationDetails r = new RegistrationDetails();
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
                string message = "successfully deleted";
                string title = "Congrats";
                System.Windows.MessageBox.Show(message, title);
                dataGridView1.Rows.Remove(dataGridView1.Rows[id]);
                dataGridView1.Refresh();
            }
            catch (Exception E)
            {
                System.Windows.MessageBox.Show(E.Message);
            }
        }

        private void dxbtn_Addnew_Click(object sender, EventArgs e)
        {
            reg.save();
        }

        private void dxbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}