using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windformtasks
{
   
    public partial class register : Form
    {
        DataTable dt = new DataTable();
        public int id { get; set; }
        public int age { get; set; }
        public long phone_no { get; set; }

        public string name { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public string country { get; set; }
        public string address { get; set; }
        public string qualification { get; set; }
        public int index { get; set; }

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

        private void but_add_Click(object sender, EventArgs e)
        { 
            id = int.Parse(txt_id.Text);
            name = txt_name.Text;
             age = int.Parse(num_age.Text);
            gender = rad_male.Text;
             city = com_city.Text;
             state = com_state.Text;
            country = com_country.Text;
            phone_no = Convert.ToInt64(txt_phone_no.Text);
            address = txt_address.Text;
             qualification = txt_qualification.Text;


            if (rad_male.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            display();
        }
        public void display()
        {

            dt.Columns.Add("id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Gender");
            dt.Columns.Add("City");
            dt.Columns.Add("State");
            dt.Columns.Add("Country");
            dt.Columns.Add("Phone_no");
            dt.Columns.Add("Address");
            dt.Columns.Add("Qualification");

            DataRow dr = dt.NewRow();

            dr[0] = id;
            dr[1] = name;
            dr[2] = age;
            dr[3] = gender;
            dr[4] = city;
            dr[5] = state;
            dr[6] = country;
            dr[7] = phone_no;
            dr[8] = address;
            dr[9] = qualification;

            dt.Rows.Add(dr);
            datagrid.DataSource = dt;


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

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.datagrid.SelectedRows)
            {
                datagrid.Rows.RemoveAt(item.Index);
            }

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex(Index);
        }
    }


    
}
