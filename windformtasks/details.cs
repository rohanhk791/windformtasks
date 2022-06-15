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
        public string _index;
        //regester_copy reg = new regester_copy();
        //DataTable dt = new DataTable();
        //register res = new register();

        //details det = new details();

        List<RegistrationDetails> regList;
        public details(List<RegistrationDetails> regDetailsList)
        {
            InitializeComponent();
            regList = regDetailsList;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
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
               //dataGridView1.Rows.Add(regList);
                dataGridView1.DataSource = regList;
               
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            //dataGridView1.DataBindings();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                //regester_copy regForm = new regester_copy(this);
                //_index = dataGridView1.CurrentCell.RowIndex;
                //DataGridViewRow edit = dataGridView1.Rows[_index];
                //regForm.txt_id.Text = edit.Cells["Id"].Value.ToString();
                //regForm.txt_name.Text = edit.Cells["EName"].Value.ToString();
                ////regForm.date_DateTime.Value = Convert.ToDateTime(edit.Cells["Date"].Value);
                ////regForm.COMB_Age.Text = edit.Cells[1].Value.ToString();
                //regForm.num_age.Value = Convert.ToInt32(edit.Cells["Age"].Value);
                //getGender(edit.Cells["Gender"].Value.ToString(), regForm);
                //regForm.txt_aualification.Text = edit.Cells["Qualification"].Value.ToString();
                //regForm.comb_state.Text = edit.Cells["State"].Value.ToString();
                //regForm.comb_city.Text = edit.Cells["City"].Value.ToString();
                //regForm.comb_country.Text = edit.Cells["Country"].Value.ToString();
                //regForm.txt_phone_no.Text = edit.Cells["Phone"].Value.ToString();
                //regForm.txt_Address.Text = edit.Cells["Address"].Value.ToString();
                //regForm.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
